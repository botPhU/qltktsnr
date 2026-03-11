using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp;

public class Main : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_isPC;

	private static readonly IntPtr NativeFieldInfoPtr_main;

	private static readonly IntPtr NativeFieldInfoPtr_g;

	private static readonly IntPtr NativeFieldInfoPtr_midlet;

	private static readonly IntPtr NativeFieldInfoPtr_res;

	private static readonly IntPtr NativeFieldInfoPtr_mainThreadName;

	private static readonly IntPtr NativeFieldInfoPtr_started;

	private static readonly IntPtr NativeFieldInfoPtr_isIpod;

	private static readonly IntPtr NativeFieldInfoPtr_isIphone4;

	private static readonly IntPtr NativeFieldInfoPtr_isWindowsPhone;

	private static readonly IntPtr NativeFieldInfoPtr_isIPhone;

	private static readonly IntPtr NativeFieldInfoPtr_IphoneVersionApp;

	private static readonly IntPtr NativeFieldInfoPtr_IMEI;

	private static readonly IntPtr NativeFieldInfoPtr_versionIp;

	private static readonly IntPtr NativeFieldInfoPtr_numberQuit;

	private static readonly IntPtr NativeFieldInfoPtr_typeClient;

	private static readonly IntPtr NativeFieldInfoPtr_PC_VERSION;

	private static readonly IntPtr NativeFieldInfoPtr_IP_APPSTORE;

	private static readonly IntPtr NativeFieldInfoPtr_WINDOWSPHONE;

	private static readonly IntPtr NativeFieldInfoPtr_level;

	private static readonly IntPtr NativeFieldInfoPtr_IP_JB;

	private static readonly IntPtr NativeFieldInfoPtr_updateCount;

	private static readonly IntPtr NativeFieldInfoPtr_paintCount;

	private static readonly IntPtr NativeFieldInfoPtr_count;

	private static readonly IntPtr NativeFieldInfoPtr_fps;

	private static readonly IntPtr NativeFieldInfoPtr_max;

	private static readonly IntPtr NativeFieldInfoPtr_up;

	private static readonly IntPtr NativeFieldInfoPtr_upmax;

	private static readonly IntPtr NativeFieldInfoPtr_timefps;

	private static readonly IntPtr NativeFieldInfoPtr_timeup;

	private static readonly IntPtr NativeFieldInfoPtr_isRun;

	private static readonly IntPtr NativeFieldInfoPtr_waitTick;

	private static readonly IntPtr NativeFieldInfoPtr_f;

	private static readonly IntPtr NativeFieldInfoPtr_isResume;

	private static readonly IntPtr NativeFieldInfoPtr_isMiniApp;

	private static readonly IntPtr NativeFieldInfoPtr_isQuitApp;

	private static readonly IntPtr NativeFieldInfoPtr_lastMousePos;

	private static readonly IntPtr NativeFieldInfoPtr_a;

	private static readonly IntPtr NativeFieldInfoPtr_ratioW;

	private static readonly IntPtr NativeFieldInfoPtr_ratioH;

	private static readonly IntPtr NativeFieldInfoPtr_ratioScale;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetInit_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnHideUnity_Private_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_setsizeChange_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMacAddress_Public_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_setBackupIcloud_Public_Static_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_doClearRMS_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_closeKeyBoard_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_checkInput_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_exit_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool isPC
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPC, (void*)(&flag));
		}
	}

	public unsafe static Main main
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_main, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Main>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_main, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)main));
		}
	}

	public unsafe static mGraphics g
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_g, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<mGraphics>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_g, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mGraphics2));
		}
	}

	public unsafe static GameMidlet midlet
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_midlet, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<GameMidlet>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_midlet, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameMidlet));
		}
	}

	public unsafe static string res
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_res, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_res, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string mainThreadName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainThreadName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainThreadName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool started
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_started, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_started, (void*)(&flag));
		}
	}

	public unsafe static bool isIpod
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isIpod, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isIpod, (void*)(&flag));
		}
	}

	public unsafe static bool isIphone4
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isIphone4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isIphone4, (void*)(&flag));
		}
	}

	public unsafe static bool isWindowsPhone
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isWindowsPhone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isWindowsPhone, (void*)(&flag));
		}
	}

	public unsafe static bool isIPhone
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isIPhone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isIPhone, (void*)(&flag));
		}
	}

	public unsafe static bool IphoneVersionApp
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IphoneVersionApp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IphoneVersionApp, (void*)(&flag));
		}
	}

	public unsafe static string IMEI
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IMEI, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IMEI, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int versionIp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_versionIp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_versionIp, (void*)(&num));
		}
	}

	public unsafe static int numberQuit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numberQuit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numberQuit, (void*)(&num));
		}
	}

	public unsafe static int typeClient
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeClient, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeClient, (void*)(&num));
		}
	}

	public unsafe static sbyte PC_VERSION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PC_VERSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PC_VERSION, (void*)(&b));
		}
	}

	public unsafe static sbyte IP_APPSTORE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IP_APPSTORE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IP_APPSTORE, (void*)(&b));
		}
	}

	public unsafe static sbyte WINDOWSPHONE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WINDOWSPHONE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WINDOWSPHONE, (void*)(&b));
		}
	}

	public unsafe int level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level)) = num;
		}
	}

	public unsafe static sbyte IP_JB
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IP_JB, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IP_JB, (void*)(&b));
		}
	}

	public unsafe int updateCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateCount)) = num;
		}
	}

	public unsafe long paintCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintCount);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintCount)) = num;
		}
	}

	public unsafe long count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
		}
	}

	public unsafe int fps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fps);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fps)) = num;
		}
	}

	public unsafe int max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max)) = num;
		}
	}

	public unsafe int up
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up)) = num;
		}
	}

	public unsafe int upmax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upmax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upmax)) = num;
		}
	}

	public unsafe long timefps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timefps);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timefps)) = num;
		}
	}

	public unsafe long timeup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeup);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeup)) = num;
		}
	}

	public unsafe bool isRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRun)) = flag;
		}
	}

	public unsafe static int waitTick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_waitTick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_waitTick, (void*)(&num));
		}
	}

	public unsafe static int f
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_f, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_f, (void*)(&num));
		}
	}

	public unsafe static bool isResume
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isResume, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isResume, (void*)(&flag));
		}
	}

	public unsafe static bool isMiniApp
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isMiniApp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isMiniApp, (void*)(&flag));
		}
	}

	public unsafe static bool isQuitApp
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isQuitApp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isQuitApp, (void*)(&flag));
		}
	}

	public unsafe Vector2 lastMousePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMousePos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMousePos)) = vector;
		}
	}

	public unsafe static int a
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_a, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_a, (void*)(&num));
		}
	}

	public unsafe static float ratioW
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ratioW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ratioW, (void*)(&num));
		}
	}

	public unsafe static float ratioH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ratioH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ratioH, (void*)(&num));
		}
	}

	public unsafe static float ratioScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ratioScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ratioScale, (void*)(&num));
		}
	}

	static Main()
	{
		Il2CppClassPointerStore<Main>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Main");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Main>.NativeClassPtr);
		NativeFieldInfoPtr_isPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isPC");
		NativeFieldInfoPtr_main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "main");
		NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "g");
		NativeFieldInfoPtr_midlet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "midlet");
		NativeFieldInfoPtr_res = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "res");
		NativeFieldInfoPtr_mainThreadName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "mainThreadName");
		NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "started");
		NativeFieldInfoPtr_isIpod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isIpod");
		NativeFieldInfoPtr_isIphone4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isIphone4");
		NativeFieldInfoPtr_isWindowsPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isWindowsPhone");
		NativeFieldInfoPtr_isIPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isIPhone");
		NativeFieldInfoPtr_IphoneVersionApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "IphoneVersionApp");
		NativeFieldInfoPtr_IMEI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "IMEI");
		NativeFieldInfoPtr_versionIp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "versionIp");
		NativeFieldInfoPtr_numberQuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "numberQuit");
		NativeFieldInfoPtr_typeClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "typeClient");
		NativeFieldInfoPtr_PC_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "PC_VERSION");
		NativeFieldInfoPtr_IP_APPSTORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "IP_APPSTORE");
		NativeFieldInfoPtr_WINDOWSPHONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "WINDOWSPHONE");
		NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "level");
		NativeFieldInfoPtr_IP_JB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "IP_JB");
		NativeFieldInfoPtr_updateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "updateCount");
		NativeFieldInfoPtr_paintCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "paintCount");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "count");
		NativeFieldInfoPtr_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "fps");
		NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "max");
		NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "up");
		NativeFieldInfoPtr_upmax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "upmax");
		NativeFieldInfoPtr_timefps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "timefps");
		NativeFieldInfoPtr_timeup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "timeup");
		NativeFieldInfoPtr_isRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isRun");
		NativeFieldInfoPtr_waitTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "waitTick");
		NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "f");
		NativeFieldInfoPtr_isResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isResume");
		NativeFieldInfoPtr_isMiniApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isMiniApp");
		NativeFieldInfoPtr_isQuitApp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "isQuitApp");
		NativeFieldInfoPtr_lastMousePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "lastMousePos");
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "a");
		NativeFieldInfoPtr_ratioW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "ratioW");
		NativeFieldInfoPtr_ratioH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "ratioH");
		NativeFieldInfoPtr_ratioScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Main>.NativeClassPtr, "ratioScale");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664670);
		NativeMethodInfoPtr_SetInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664671);
		NativeMethodInfoPtr_OnHideUnity_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664672);
		NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664673);
		NativeMethodInfoPtr_setsizeChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664674);
		NativeMethodInfoPtr_GetMacAddress_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664675);
		NativeMethodInfoPtr_setBackupIcloud_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664676);
		NativeMethodInfoPtr_doClearRMS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664677);
		NativeMethodInfoPtr_closeKeyBoard_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664678);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664679);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664680);
		NativeMethodInfoPtr_checkInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664681);
		NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664682);
		NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664683);
		NativeMethodInfoPtr_exit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664684);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Main>.NativeClassPtr, 100664685);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56074, XrefRangeEnd = 56114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56114, XrefRangeEnd = 56115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56115, XrefRangeEnd = 56117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnHideUnity(bool isGameShown)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isGameShown);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnHideUnity_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56117, XrefRangeEnd = 56154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56284, RefRangeEnd = 56285, XrefRangeStart = 56154, XrefRangeEnd = 56284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setsizeChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setsizeChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56285, XrefRangeEnd = 56287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMacAddress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMacAddress_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setBackupIcloud(string path)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setBackupIcloud_Public_Static_Void_String_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56304, RefRangeEnd = 56306, XrefRangeStart = 56287, XrefRangeEnd = 56304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doClearRMS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doClearRMS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 56316, RefRangeEnd = 56319, XrefRangeStart = 56306, XrefRangeEnd = 56316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void closeKeyBoard()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_closeKeyBoard_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56319, XrefRangeEnd = 56346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56346, XrefRangeEnd = 56365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56462, RefRangeEnd = 56463, XrefRangeStart = 56365, XrefRangeEnd = 56462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56463, XrefRangeEnd = 56528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56528, XrefRangeEnd = 56560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationPause(bool paused)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&paused);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56566, RefRangeEnd = 56568, XrefRangeStart = 56560, XrefRangeEnd = 56566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void exit()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_exit_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 56616, RefRangeEnd = 56631, XrefRangeStart = 56568, XrefRangeEnd = 56616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Main()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Main>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Main(IntPtr pointer)
		: base(pointer)
	{
	}
}
