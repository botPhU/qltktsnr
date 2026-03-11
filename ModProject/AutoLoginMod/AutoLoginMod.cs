using System;
using MelonLoader;
using UnityEngine;
using Il2Cpp;
using Il2CppInterop.Runtime;

[assembly: MelonInfo(typeof(AutoLoginMod.AutoLoginMod), "AutoLoginMod", "4.1.0", "AI")]
[assembly: MelonGame("TSNR", "Tái Sinh Ngọc Rồng")]

namespace AutoLoginMod
{
    public class AutoLoginMod : MelonMod
    {
        private string savedUser = "";
        private string savedPass = "";
        private bool loginAttempted = false;
        private bool dumpDone = false;

        private bool shouldOptimize = false;
        private bool optimizeApplied = false;
        private int targetWidth = 400;
        private int targetHeight = 300;
        private int targetFps = 15;

        public override void OnEarlyInitializeMelon()
        {
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--user" && i + 1 < args.Length) savedUser = args[i + 1];
                if (args[i] == "--pass" && i + 1 < args.Length) savedPass = args[i + 1];
                if (args[i] == "--optimize") shouldOptimize = true;
                if (args[i] == "--width" && i + 1 < args.Length) int.TryParse(args[i + 1], out targetWidth);
                if (args[i] == "--height" && i + 1 < args.Length) int.TryParse(args[i + 1], out targetHeight);
                if (args[i] == "--fps" && i + 1 < args.Length) int.TryParse(args[i + 1], out targetFps);
            }
            if (!string.IsNullOrEmpty(savedUser))
                MelonLogger.Msg($"[AutoLogin] Detected user: {savedUser}");
            if (shouldOptimize)
                MelonLogger.Msg($"[AutoLogin] Will optimize AFTER login: {targetWidth}x{targetHeight}, {targetFps} FPS");
        }

        private int loginStep = 0;
        private float actionTimer = 0f;
        private float optimizeTimer = 0f;
        private float startTime = 0f;
        private bool timerStarted = false;

        public override void OnUpdate()
        {
            if (!timerStarted)
            {
                startTime = Time.time;
                timerStarted = true;
            }

            // === DUMP: sau 5 giây, in hết thông tin màn hình hiện tại ===
            if (!dumpDone && Time.time - startTime > 5f)
            {
                dumpDone = true;
                DumpScreenInfo();
            }

            // === AUTO LOGIN ===
            if (!loginAttempted && !string.IsNullOrEmpty(savedUser))
            {
                var curScreen = GameCanvas.currentScreen;
                if (curScreen == null) return;

                // BƯỚC 1: Ở MÀN HÌNH CHỌN SERVER → Click nút "Đổi tài khoản"
                if (loginStep == 0 && Time.time - startTime > 5f)
                {
                    // Thử cast sang ServerListScreen bằng Il2Cpp class pointer
                    try
                    {
                        var nativeClassPtr = Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr;
                        var objClassPtr = IL2CPP.il2cpp_object_get_class(curScreen.Pointer);
                        
                        bool isServerListScreen = false;
                        // Kiểm tra nếu class hiện tại IS hoặc kế thừa từ ServerListScreen
                        if (nativeClassPtr != IntPtr.Zero && objClassPtr != IntPtr.Zero)
                        {
                            isServerListScreen = IL2CPP.il2cpp_class_is_assignable_from(nativeClassPtr, objClassPtr);
                        }

                        MelonLogger.Msg($"[AutoLogin] Il2Cpp class check: isServerListScreen={isServerListScreen}");

                        if (isServerListScreen)
                        {
                            var serverScr = new ServerListScreen(curScreen.Pointer);
                            if (serverScr.cmd != null)
                            {
                                MelonLogger.Msg($"[AutoLogin] ServerListScreen has {serverScr.cmd.Count} commands:");
                                for (int i = 0; i < serverScr.cmd.Count; i++)
                                {
                                    var c = serverScr.cmd[i];
                                    if (c != null)
                                        MelonLogger.Msg($"[AutoLogin]   cmd[{i}]: caption='{c.caption}', idAction={c.idAction}");
                                }

                                // Nút "Đổi tài khoản" thường là nút thứ 3 (index 2)
                                // Nhưng hãy tìm theo idAction hoặc vị trí
                                int targetIndex = -1;
                                for (int i = 0; i < serverScr.cmd.Count; i++)
                                {
                                    var c = serverScr.cmd[i];
                                    if (c != null && c.caption != null)
                                    {
                                        MelonLogger.Msg($"[AutoLogin]   → Checking caption bytes...");
                                        // Tìm nút "Đổi" hoặc bấm nút cuối cùng trước "Máy chủ"
                                        if (c.idAction == 2 || c.caption.Contains("i t") || c.caption.Contains("kho"))
                                        {
                                            targetIndex = i;
                                            break;
                                        }
                                    }
                                }

                                // Fallback: nút index 2 (0=Chơi TK, 1=Chơi mới, 2=Đổi TK, 3=Máy chủ)
                                if (targetIndex < 0 && serverScr.cmd.Count > 2)
                                    targetIndex = 2;

                                if (targetIndex >= 0)
                                {
                                    MelonLogger.Msg($"[AutoLogin] ★ Clicking cmd[{targetIndex}]: '{serverScr.cmd[targetIndex].caption}'");
                                    serverScr.cmd[targetIndex].performAction();
                                    loginStep = 1;
                                    actionTimer = Time.time;
                                }
                            }
                        }
                        else
                        {
                            MelonLogger.Msg("[AutoLogin] Not ServerListScreen. Trying nCmdPlay field directly...");
                            
                            // Cách 2: thử truy cập nCmdPlay (field static trên ServerListScreen)
                            // ServerListScreen.nCmdPlay: kiểu instance field
                            // Thử bấm nút left, center, right từ mScreen
                            if (curScreen.left != null)
                                MelonLogger.Msg($"[AutoLogin] mScreen.left: '{curScreen.left.caption}'");
                            if (curScreen.center != null)
                                MelonLogger.Msg($"[AutoLogin] mScreen.center: '{curScreen.center.caption}'");
                            if (curScreen.right != null)
                                MelonLogger.Msg($"[AutoLogin] mScreen.right: '{curScreen.right.caption}'");
                        }
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Error($"[AutoLogin] Error in screen detection: {ex}");
                    }

                    // Nếu không tìm được, vẫn đánh dấu đã thử
                    if (loginStep == 0)
                    {
                        MelonLogger.Warning("[AutoLogin] Could not find server screen buttons. Will keep trying...");
                    }
                }

                // BƯỚC 2: ĐÃ CLICK ĐỔI TK → ĐĂNG NHẬP
                if (loginStep == 1 && Time.time - actionTimer > 2f)
                {
                    try
                    {
                        if (GameCanvas.loginScr != null)
                        {
                            var loginScr = GameCanvas.loginScr;
                            MelonLogger.Msg("[AutoLogin] LoginScr found!");

                            // QUAN TRỌNG: tắt "tiếp tục đăng nhập" bằng tài khoản cũ
                            LoginScr.isContinueToLogin = false;
                            loginScr.isLogin2 = true;
                            MelonLogger.Msg("[AutoLogin] Set isContinueToLogin=false, isLogin2=true");

                            if (loginScr.tfUser != null)
                            {
                                loginScr.tfUser.setText(savedUser);
                                loginScr.tfUser.text = savedUser;
                                MelonLogger.Msg($"[AutoLogin] Set user='{savedUser}'");
                            }
                            if (loginScr.tfPass != null)
                            {
                                loginScr.tfPass.setText(savedPass);
                                loginScr.tfPass.text = savedPass;
                                MelonLogger.Msg("[AutoLogin] Set pass=***");
                            }

                            // Gọi savePass() để game lưu credentials mới trước khi login
                            try { loginScr.savePass(); MelonLogger.Msg("[AutoLogin] savePass() called"); }
                            catch { /* ignore */ }

                            loginScr.doLogin();
                            MelonLogger.Msg("[AutoLogin] ✅ doLogin() called!");
                            loginAttempted = true;
                            optimizeTimer = Time.time;
                        }
                        else
                        {
                            MelonLogger.Msg("[AutoLogin] Waiting for LoginScr to appear...");
                        }
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Error($"[AutoLogin] Login error: {ex}");
                        loginAttempted = true;
                    }
                }
            }

            // === TỐI ƯU HÓA (ĐỘNG IPC) ===
            // Cứ 2 giây kiểm tra file cấu hình 1 lần xem Launcher có đổi setting không
            if (loginAttempted && Time.time - optimizeTimer > 2f)
            {
                optimizeTimer = Time.time;
                CheckAndApplySettings();
            }
        }

        private DateTime lastConfigWriteTime = DateTime.Now;

        private void CheckAndApplySettings()
        {
            try
            {
                // File setting nằm cùng chỗ với Launcher và Game (Ví dụ: sinh file ở thư mục Mods)
                string settingsPath = Path.Combine(MelonUtils.BaseDirectory, "Mods", "AutoLoginMod_Settings.json");
                
                if (!File.Exists(settingsPath)) return;

                FileInfo fi = new FileInfo(settingsPath);
                if (fi.LastWriteTime > lastConfigWriteTime)
                {
                    lastConfigWriteTime = fi.LastWriteTime;
                    
                    string json = File.ReadAllText(settingsPath);
                    // Dùng thủ công JSON Parsing thay vì dùng thư viện để giảm phụ thuộc
                    
                    bool newOptimize = json.Contains("\"Optimize\": true") || json.Contains("\"Optimize\":true");
                    int w = ExtractIntFromJson(json, "Width", 400);
                    int h = ExtractIntFromJson(json, "Height", 300);
                    int fps = ExtractIntFromJson(json, "Fps", 15);

                    if (newOptimize)
                    {
                        QualitySettings.SetQualityLevel(0, true);
                        Application.targetFrameRate = fps;
                        Screen.SetResolution(w, h, false);
                        
                        // GameCanvas size
                        GameCanvas.w = w;
                        GameCanvas.h = h;
                        GameCanvas.hw = w / 2;
                        GameCanvas.hh = h / 2;
                        GameCanvas.wd3 = w / 3;
                        GameCanvas.hd3 = h / 3;
                        GameCanvas.w2d3 = (w * 2) / 3;
                        GameCanvas.h2d3 = (h * 2) / 3;
                        GameCanvas.w3d4 = (w * 3) / 4;
                        GameCanvas.h3d4 = (h * 3) / 4;
                        GameCanvas.wd6 = w / 6;
                        GameCanvas.hd6 = h / 6;
                        mGraphics.zoomLevel = 1;

                        try {
                            if (Il2Cpp.Main.main != null)
                            {
                                Il2Cpp.Main.main.setsizeChange(); // BÁO CHO GAME RẰNG SIZE VỪA BỊ ĐỔI ĐỂ KHÔNG BỊ LỆCH GÓC
                            }
                        } catch { }

                        MelonLogger.Msg($"[AutoLogin] ⚡ Cập nhật cấu hình: {w}x{h}, {fps} FPS");
                    }
                    else
                    {
                        // Khôi phục mặc định (Ví dụ: 1024x600, 60 FPS)
                        QualitySettings.SetQualityLevel(3, true);
                        Application.targetFrameRate = 60;
                        Screen.SetResolution(1024, 600, false);
                        
                        // Reset properties
                        GameCanvas.w = 1024;
                        GameCanvas.h = 600;
                        GameCanvas.hw = 512;
                        GameCanvas.hh = 300;
                        mGraphics.zoomLevel = 1;

                        try { if (Il2Cpp.Main.main != null) Il2Cpp.Main.main.setsizeChange(); } catch { }

                        MelonLogger.Msg($"[AutoLogin] ⚡ Cập nhật: Khôi phục cấu hình cao.");
                    }
                }
            }
            catch (Exception ex)
            {
                // MelonLogger.Error($"[AutoLogin] JSON parsing / Settings Error: {ex}");
            }
        }

        private int ExtractIntFromJson(string json, string key, int defaultVal)
        {
            string searchStr = $"\"{key}\":";
            int idx = json.IndexOf(searchStr);
            if (idx == -1) return defaultVal;
            
            idx += searchStr.Length;
            int endIdx = json.IndexOfAny(new char[] { ',', '}', '\n', '\r' }, idx);
            if (endIdx == -1) endIdx = json.Length;

            string valStr = json.Substring(idx, endIdx - idx).Trim();
            if (int.TryParse(valStr, out int result)) return result;
            return defaultVal;
        }

        private void DumpScreenInfo()
        {
            MelonLogger.Msg("===== [AutoLogin] SCREEN DUMP =====");
            
            var curScreen = GameCanvas.currentScreen;
            if (curScreen == null)
            {
                MelonLogger.Msg("[DUMP] currentScreen is NULL");
                return;
            }

            // Type info
            var ptr = curScreen.Pointer;
            var classPtr = IL2CPP.il2cpp_object_get_class(ptr);
            IntPtr namePtr = IL2CPP.il2cpp_class_get_name(classPtr);
            string className = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(namePtr) ?? "UNKNOWN";
            MelonLogger.Msg($"[DUMP] currentScreen IL2CPP class = '{className}'");
            MelonLogger.Msg($"[DUMP] currentScreen C# type = '{curScreen.GetType().Name}'");

            // mScreen base fields
            try
            {
                if (curScreen.left != null)
                    MelonLogger.Msg($"[DUMP] left: caption='{curScreen.left.caption}', id={curScreen.left.idAction}");
                else
                    MelonLogger.Msg("[DUMP] left: NULL");
            } catch { MelonLogger.Msg("[DUMP] left: ERROR"); }

            try
            {
                if (curScreen.center != null)
                    MelonLogger.Msg($"[DUMP] center: caption='{curScreen.center.caption}', id={curScreen.center.idAction}");
                else
                    MelonLogger.Msg("[DUMP] center: NULL");
            } catch { MelonLogger.Msg("[DUMP] center: ERROR"); }

            try
            {
                if (curScreen.right != null)
                    MelonLogger.Msg($"[DUMP] right: caption='{curScreen.right.caption}', id={curScreen.right.idAction}");
                else
                    MelonLogger.Msg("[DUMP] right: NULL");
            } catch { MelonLogger.Msg("[DUMP] right: ERROR"); }

            // Try ServerListScreen cast via IL2CPP
            try
            {
                var slsClass = Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr;
                bool isAssignable = IL2CPP.il2cpp_class_is_assignable_from(slsClass, classPtr);
                MelonLogger.Msg($"[DUMP] Is ServerListScreen? {isAssignable}");

                if (isAssignable)
                {
                    var sls = new ServerListScreen(ptr);
                    if (sls.cmd != null)
                    {
                        MelonLogger.Msg($"[DUMP] ServerListScreen.cmd has {sls.cmd.Count} items:");
                        for (int i = 0; i < sls.cmd.Count; i++)
                        {
                            var c = sls.cmd[i];
                            if (c != null)
                                MelonLogger.Msg($"[DUMP]   cmd[{i}]: caption='{c.caption}', idAction={c.idAction}");
                            else
                                MelonLogger.Msg($"[DUMP]   cmd[{i}]: NULL");
                        }
                    }
                    else
                    {
                        MelonLogger.Msg("[DUMP] ServerListScreen.cmd is NULL");
                    }

                    MelonLogger.Msg($"[DUMP] ServerListScreen.nCmdPlay = {sls.nCmdPlay}");
                }
            }
            catch (Exception ex) { MelonLogger.Error($"[DUMP] ServerListScreen cast error: {ex.Message}"); }

            // Try LoginScr
            try
            {
                var loginScr = GameCanvas.loginScr;
                if (loginScr != null)
                {
                    MelonLogger.Msg("[DUMP] GameCanvas.loginScr EXISTS!");
                    if (loginScr.tfUser != null)
                        MelonLogger.Msg($"[DUMP]   tfUser.text='{loginScr.tfUser.text}'");
                    if (loginScr.cmdMenu != null)
                        MelonLogger.Msg($"[DUMP]   cmdMenu.caption='{loginScr.cmdMenu.caption}'");
                    if (loginScr.cmdLogin != null)
                        MelonLogger.Msg($"[DUMP]   cmdLogin.caption='{loginScr.cmdLogin.caption}'");
                }
                else
                {
                    MelonLogger.Msg("[DUMP] GameCanvas.loginScr is NULL");
                }
            }
            catch (Exception ex) { MelonLogger.Error($"[DUMP] loginScr error: {ex.Message}"); }

            MelonLogger.Msg("===== [AutoLogin] END DUMP =====");
        }
    }
}
