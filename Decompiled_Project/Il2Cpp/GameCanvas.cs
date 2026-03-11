using System;
using System.Runtime.CompilerServices;
using Il2CppAssets.src.g;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public class GameCanvas : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_timeNow;

	private static readonly System.IntPtr NativeFieldInfoPtr_open3Hour;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowGraphic;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverchat;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMoveNumberPad;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoading;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTouchControl;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTouchControlSmallScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTouchControlLargeScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_isConnectFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameStarted;

	private static readonly System.IntPtr NativeFieldInfoPtr_bRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyPressed;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyReleased;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyHold;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPointerDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPointerClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPointerJustRelease;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPointerMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_px;

	private static readonly System.IntPtr NativeFieldInfoPtr_py;

	private static readonly System.IntPtr NativeFieldInfoPtr_pxFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_pyFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_pxLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_pyLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_pxMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_pyMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_taskTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEff1;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEff2;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeTickEff1;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeTickEff2;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_hw;

	private static readonly System.IntPtr NativeFieldInfoPtr_hh;

	private static readonly System.IntPtr NativeFieldInfoPtr_wd3;

	private static readonly System.IntPtr NativeFieldInfoPtr_hd3;

	private static readonly System.IntPtr NativeFieldInfoPtr_w2d3;

	private static readonly System.IntPtr NativeFieldInfoPtr_h2d3;

	private static readonly System.IntPtr NativeFieldInfoPtr_w3d4;

	private static readonly System.IntPtr NativeFieldInfoPtr_h3d4;

	private static readonly System.IntPtr NativeFieldInfoPtr_wd6;

	private static readonly System.IntPtr NativeFieldInfoPtr_hd6;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_menu;

	private static readonly System.IntPtr NativeFieldInfoPtr_panel;

	private static readonly System.IntPtr NativeFieldInfoPtr_panel2;

	private static readonly System.IntPtr NativeFieldInfoPtr_loginScr;

	private static readonly System.IntPtr NativeFieldInfoPtr_registerScr;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDialog;

	private static readonly System.IntPtr NativeFieldInfoPtr_msgdlg;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputDlg;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentPopup;

	private static readonly System.IntPtr NativeFieldInfoPtr_requestLoseCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_listPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintz;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGetResFromServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_skyColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_curPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgW;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgH;

	private static readonly System.IntPtr NativeFieldInfoPtr_planet;

	private static readonly System.IntPtr NativeFieldInfoPtr_g;

	private static readonly System.IntPtr NativeFieldInfoPtr_img12;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgBlue;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgViolet;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPlaySound;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearOldData;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeOpenKeyBoard;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFocusPanel2;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintCarret;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugSession;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShowErrorForm;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintBG;

	private static readonly System.IntPtr NativeFieldInfoPtr_gsskyHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_gsgreenField1Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_gsgreenField2Y;

	private static readonly System.IntPtr NativeFieldInfoPtr_gshouseY;

	private static readonly System.IntPtr NativeFieldInfoPtr_gsmountainY;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgLayer0y;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgLayer1y;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgCloud;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSun;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSun2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgClear;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgBorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSunSpec;

	private static readonly System.IntPtr NativeFieldInfoPtr_borderConnerW;

	private static readonly System.IntPtr NativeFieldInfoPtr_borderConnerH;

	private static readonly System.IntPtr NativeFieldInfoPtr_borderCenterW;

	private static readonly System.IntPtr NativeFieldInfoPtr_borderCenterH;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudY;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunX;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunY;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunX2;

	private static readonly System.IntPtr NativeFieldInfoPtr_sunY2;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveX;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveXSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBoltEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_boltActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_tBolt;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_transY;

	private static readonly System.IntPtr NativeFieldInfoPtr_yb;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorTop;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorBotton;

	private static readonly System.IntPtr NativeFieldInfoPtr_yb1;

	private static readonly System.IntPtr NativeFieldInfoPtr_yb2;

	private static readonly System.IntPtr NativeFieldInfoPtr_yb3;

	private static readonly System.IntPtr NativeFieldInfoPtr_nBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgRain;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgRainFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgCaycot;

	private static readonly System.IntPtr NativeFieldInfoPtr_tam;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeBackGround;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveIDBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoadBGok;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimePress;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyAsciiPress;

	private static readonly System.IntPtr NativeFieldInfoPtr_pXYScrollMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSignal;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_longTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPointerJustDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_csWait;

	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBlackScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarH;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarLeftW;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarRightW;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarCenterW;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarX;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarY;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_expBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_lvPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarH;

	private static readonly System.IntPtr NativeFieldInfoPtr_girlHPBarY;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_dustX;

	private static readonly System.IntPtr NativeFieldInfoPtr_dustY;

	private static readonly System.IntPtr NativeFieldInfoPtr_dustState;

	private static readonly System.IntPtr NativeFieldInfoPtr_wsX;

	private static readonly System.IntPtr NativeFieldInfoPtr_wsY;

	private static readonly System.IntPtr NativeFieldInfoPtr_wsState;

	private static readonly System.IntPtr NativeFieldInfoPtr_wsF;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgWS;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgShuriken;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgDust;

	private static readonly System.IntPtr NativeFieldInfoPtr_isResume;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverScr;

	private static readonly System.IntPtr NativeFieldInfoPtr_resetToLoginScr;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSend;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPlatformName_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_GameCanvas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initPaint_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_closeKeyBoard_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onDisconnected_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onConnectionFail_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isWaiting_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_connect_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_connect2_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetTrans_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetTransGameScr_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initGameCanvas_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getWidth_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeight_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_debug_Public_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doResetToLoginScr_Public_Void_mScreen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showErrorForm_Public_Static_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCloud_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateBG_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fillRect_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBackgroundtLayer_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawSun1_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawSun2_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHDVersion_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBGGameScr_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetBg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getYBackground_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadBG_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_randomRaintEff_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyPressedz_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mapKeyPress_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyReleasedz_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mapKeyRelease_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pointerMouse_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scrollMouse_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pointerDragged_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHoldPress_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pointerPressed_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pointerReleased_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPointerIn_Public_Static_Boolean_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPointerHoldIn_Public_Static_Boolean_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMouseFocus_Public_Static_Boolean_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearKeyPressed_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearKeyHold_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkBackButton_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBlack_Public_Void_mGraphics_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintChangeMap_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_endDlg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startOKDlg_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startWaitDlg_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startOKDlg_Public_Static_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startWaitDlg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openWeb_Public_Void_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startOK_Public_Static_Void_String_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startYesNoDlg_Public_Static_Void_String_Int32_Object_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startYesNoDlg_Public_Static_Void_String_Command_Command_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMoneys_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getX_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getY_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sizeChanged_Protected_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isGetResourceFromServer_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadImageRMS_Public_Static_Image_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Public_Static_Texture2D_Texture2D_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resizeImage_Public_Static_Void_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadImage_Public_Static_Image_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cutPng_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_random_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startDust_Public_Boolean_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadWaterSplash_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startWaterSplash_Public_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateWaterSplash_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateDust_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPaint_Public_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintDust_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadDust_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintShukiren_Public_Static_Void_Int32_Int32_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetToLoginScrz_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPointer_Public_Static_Boolean_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearAllPointerEvent_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_backToRegister_Public_Static_Void_0;

	public unsafe static long timeNow
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeNow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeNow, (void*)(&num));
		}
	}

	public unsafe static bool open3Hour
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_open3Hour, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_open3Hour, (void*)(&flag));
		}
	}

	public unsafe static bool lowGraphic
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lowGraphic, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lowGraphic, (void*)(&flag));
		}
	}

	public unsafe static bool serverchat
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverchat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverchat, (void*)(&flag));
		}
	}

	public unsafe static bool isMoveNumberPad
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isMoveNumberPad, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isMoveNumberPad, (void*)(&flag));
		}
	}

	public unsafe static bool isLoading
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoading, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoading, (void*)(&flag));
		}
	}

	public unsafe static bool isTouch
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTouch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTouch, (void*)(&flag));
		}
	}

	public unsafe static bool isTouchControl
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTouchControl, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTouchControl, (void*)(&flag));
		}
	}

	public unsafe static bool isTouchControlSmallScreen
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTouchControlSmallScreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTouchControlSmallScreen, (void*)(&flag));
		}
	}

	public unsafe static bool isTouchControlLargeScreen
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTouchControlLargeScreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTouchControlLargeScreen, (void*)(&flag));
		}
	}

	public unsafe static bool isConnectFail
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isConnectFail, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isConnectFail, (void*)(&flag));
		}
	}

	public unsafe static GameCanvas instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCanvas>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCanvas));
		}
	}

	public unsafe static bool gameStarted
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gameStarted, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gameStarted, (void*)(&flag));
		}
	}

	public unsafe static bool bRun
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bRun, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bRun, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStructArray<bool> keyPressed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keyPressed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keyPressed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<bool> keyReleased
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keyReleased, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keyReleased, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<bool> keyHold
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keyHold, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keyHold, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool isPointerDown
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPointerDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPointerDown, (void*)(&flag));
		}
	}

	public unsafe static bool isPointerClick
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPointerClick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPointerClick, (void*)(&flag));
		}
	}

	public unsafe static bool isPointerJustRelease
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPointerJustRelease, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPointerJustRelease, (void*)(&flag));
		}
	}

	public unsafe static bool isPointerMove
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPointerMove, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPointerMove, (void*)(&flag));
		}
	}

	public unsafe static int px
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_px, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_px, (void*)(&num));
		}
	}

	public unsafe static int py
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_py, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_py, (void*)(&num));
		}
	}

	public unsafe static int pxFirst
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pxFirst, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pxFirst, (void*)(&num));
		}
	}

	public unsafe static int pyFirst
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pyFirst, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pyFirst, (void*)(&num));
		}
	}

	public unsafe static int pxLast
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pxLast, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pxLast, (void*)(&num));
		}
	}

	public unsafe static int pyLast
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pyLast, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pyLast, (void*)(&num));
		}
	}

	public unsafe static int pxMouse
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pxMouse, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pxMouse, (void*)(&num));
		}
	}

	public unsafe static int pyMouse
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pyMouse, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pyMouse, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<Position> arrPos
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrPos, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Position>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrPos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int gameTick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gameTick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gameTick, (void*)(&num));
		}
	}

	public unsafe static int taskTick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_taskTick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_taskTick, (void*)(&num));
		}
	}

	public unsafe static bool isEff1
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isEff1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isEff1, (void*)(&flag));
		}
	}

	public unsafe static bool isEff2
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isEff2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isEff2, (void*)(&flag));
		}
	}

	public unsafe static long timeTickEff1
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeTickEff1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeTickEff1, (void*)(&num));
		}
	}

	public unsafe static long timeTickEff2
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeTickEff2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeTickEff2, (void*)(&num));
		}
	}

	public unsafe static int w
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_w, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_w, (void*)(&num));
		}
	}

	public unsafe static int h
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_h, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_h, (void*)(&num));
		}
	}

	public unsafe static int hw
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hw, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hw, (void*)(&num));
		}
	}

	public unsafe static int hh
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hh, (void*)(&num));
		}
	}

	public unsafe static int wd3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wd3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wd3, (void*)(&num));
		}
	}

	public unsafe static int hd3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hd3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hd3, (void*)(&num));
		}
	}

	public unsafe static int w2d3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_w2d3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_w2d3, (void*)(&num));
		}
	}

	public unsafe static int h2d3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_h2d3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_h2d3, (void*)(&num));
		}
	}

	public unsafe static int w3d4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_w3d4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_w3d4, (void*)(&num));
		}
	}

	public unsafe static int h3d4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_h3d4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_h3d4, (void*)(&num));
		}
	}

	public unsafe static int wd6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wd6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wd6, (void*)(&num));
		}
	}

	public unsafe static int hd6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hd6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hd6, (void*)(&num));
		}
	}

	public unsafe static mScreen currentScreen
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentScreen, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mScreen>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentScreen, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mScreen2));
		}
	}

	public unsafe static Menu menu
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_menu, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Menu>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_menu, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)menu));
		}
	}

	public unsafe static Panel panel
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_panel, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Panel>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_panel, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)panel));
		}
	}

	public unsafe static Panel panel2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_panel2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Panel>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_panel2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)panel));
		}
	}

	public unsafe static LoginScr loginScr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_loginScr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoginScr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_loginScr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loginScr));
		}
	}

	public unsafe static RegisterScreen registerScr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_registerScr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegisterScreen>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_registerScr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)registerScreen));
		}
	}

	public unsafe static Dialog currentDialog
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentDialog, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dialog>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentDialog, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dialog));
		}
	}

	public unsafe static MsgDlg msgdlg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_msgdlg, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MsgDlg>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_msgdlg, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msgDlg));
		}
	}

	public unsafe static InputDlg inputDlg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputDlg, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDlg>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputDlg, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputDlg));
		}
	}

	public unsafe static MyVector currentPopup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentPopup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentPopup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static int requestLoseCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_requestLoseCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_requestLoseCount, (void*)(&num));
		}
	}

	public unsafe static MyVector listPoint
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listPoint, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listPoint, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static Paint paintz
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_paintz, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Paint>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_paintz, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)paint));
		}
	}

	public unsafe static bool isGetResFromServer
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isGetResFromServer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isGetResFromServer, (void*)(&flag));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgBG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgBG, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgBG, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int skyColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_skyColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_skyColor, (void*)(&num));
		}
	}

	public unsafe static int curPos
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curPos, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curPos, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> bgW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgW, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgW, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> bgH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgH, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgH, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int planet
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_planet, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_planet, (void*)(&num));
		}
	}

	public unsafe mGraphics g
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<mGraphics>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mGraphics2));
		}
	}

	public unsafe static Image img12
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_img12, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_img12, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgBlue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgBlue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgBlue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgViolet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgViolet, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgViolet, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool isPlaySound
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPlaySound, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPlaySound, (void*)(&flag));
		}
	}

	public unsafe static int clearOldData
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clearOldData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clearOldData, (void*)(&num));
		}
	}

	public unsafe static int timeOpenKeyBoard
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeOpenKeyBoard, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeOpenKeyBoard, (void*)(&num));
		}
	}

	public unsafe static bool isFocusPanel2
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isFocusPanel2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isFocusPanel2, (void*)(&flag));
		}
	}

	public unsafe bool isPaintCarret
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintCarret);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintCarret)) = flag;
		}
	}

	public unsafe static MyVector debugUpdate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_debugUpdate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_debugUpdate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector debugPaint
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_debugPaint, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_debugPaint, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector debugSession
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_debugSession, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_debugSession, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static bool isShowErrorForm
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isShowErrorForm, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isShowErrorForm, (void*)(&flag));
		}
	}

	public unsafe static bool paintBG
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_paintBG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_paintBG, (void*)(&flag));
		}
	}

	public unsafe static int gsskyHeight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gsskyHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gsskyHeight, (void*)(&num));
		}
	}

	public unsafe static int gsgreenField1Y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gsgreenField1Y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gsgreenField1Y, (void*)(&num));
		}
	}

	public unsafe static int gsgreenField2Y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gsgreenField2Y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gsgreenField2Y, (void*)(&num));
		}
	}

	public unsafe static int gshouseY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gshouseY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gshouseY, (void*)(&num));
		}
	}

	public unsafe static int gsmountainY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gsmountainY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gsmountainY, (void*)(&num));
		}
	}

	public unsafe static int bgLayer0y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgLayer0y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgLayer0y, (void*)(&num));
		}
	}

	public unsafe static int bgLayer1y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgLayer1y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgLayer1y, (void*)(&num));
		}
	}

	public unsafe static Image imgCloud
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgCloud, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgCloud, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgSun
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSun, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSun, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgSun2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSun2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSun2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgClear
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgClear, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgClear, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgBorder
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgBorder, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgBorder, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgSunSpec
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSunSpec, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSunSpec, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int borderConnerW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_borderConnerW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_borderConnerW, (void*)(&num));
		}
	}

	public unsafe static int borderConnerH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_borderConnerH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_borderConnerH, (void*)(&num));
		}
	}

	public unsafe static int borderCenterW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_borderCenterW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_borderCenterW, (void*)(&num));
		}
	}

	public unsafe static int borderCenterH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_borderCenterH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_borderCenterH, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> cloudX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloudX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloudX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> cloudY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloudY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloudY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int sunX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunX, (void*)(&num));
		}
	}

	public unsafe static int sunY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunY, (void*)(&num));
		}
	}

	public unsafe static int sunX2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunX2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunX2, (void*)(&num));
		}
	}

	public unsafe static int sunY2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sunY2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sunY2, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> layerSpeed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_layerSpeed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_layerSpeed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> moveX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_moveX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_moveX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> moveXSpeed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_moveXSpeed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_moveXSpeed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool isBoltEff
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isBoltEff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isBoltEff, (void*)(&flag));
		}
	}

	public unsafe static bool boltActive
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_boltActive, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_boltActive, (void*)(&flag));
		}
	}

	public unsafe static int tBolt
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tBolt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tBolt, (void*)(&num));
		}
	}

	public unsafe static int typeBg
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeBg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeBg, (void*)(&num));
		}
	}

	public unsafe static int transY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_transY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_transY, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> yb
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yb, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yb, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> colorTop
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorTop, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorTop, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> colorBotton
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorBotton, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorBotton, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int yb1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yb1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yb1, (void*)(&num));
		}
	}

	public unsafe static int yb2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yb2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yb2, (void*)(&num));
		}
	}

	public unsafe static int yb3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yb3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yb3, (void*)(&num));
		}
	}

	public unsafe static int nBg
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nBg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nBg, (void*)(&num));
		}
	}

	public unsafe static int lastBg
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastBg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastBg, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> bgRain
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgRain, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgRain, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> bgRainFont
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgRainFont, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgRainFont, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgCaycot
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgCaycot, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgCaycot, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image tam
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tam, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tam, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int typeBackGround
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeBackGround, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeBackGround, (void*)(&num));
		}
	}

	public unsafe static int saveIDBg
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_saveIDBg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_saveIDBg, (void*)(&num));
		}
	}

	public unsafe static bool isLoadBGok
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoadBGok, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoadBGok, (void*)(&flag));
		}
	}

	public unsafe static long lastTimePress
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimePress, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimePress, (void*)(&num));
		}
	}

	public unsafe static int keyAsciiPress
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keyAsciiPress, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keyAsciiPress, (void*)(&num));
		}
	}

	public unsafe static int pXYScrollMouse
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pXYScrollMouse, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pXYScrollMouse, (void*)(&num));
		}
	}

	public unsafe static Image imgSignal
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSignal, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSignal, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static MyVector flyTexts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTexts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTexts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe int longTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longTime)) = num;
		}
	}

	public unsafe static bool isPointerJustDown
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPointerJustDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPointerJustDown, (void*)(&flag));
		}
	}

	public unsafe int count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
		}
	}

	public unsafe static bool csWait
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_csWait, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_csWait, (void*)(&flag));
		}
	}

	public unsafe static MyRandom r
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_r, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyRandom>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_r, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myRandom));
		}
	}

	public unsafe static bool isBlackScreen
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isBlackScreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isBlackScreen, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStructArray<int> bgSpeed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgSpeed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgSpeed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int cmdBarX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarX, (void*)(&num));
		}
	}

	public unsafe static int cmdBarY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarY, (void*)(&num));
		}
	}

	public unsafe static int cmdBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarW, (void*)(&num));
		}
	}

	public unsafe static int cmdBarH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarH, (void*)(&num));
		}
	}

	public unsafe static int cmdBarLeftW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarLeftW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarLeftW, (void*)(&num));
		}
	}

	public unsafe static int cmdBarRightW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarRightW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarRightW, (void*)(&num));
		}
	}

	public unsafe static int cmdBarCenterW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarCenterW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarCenterW, (void*)(&num));
		}
	}

	public unsafe static int hpBarX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarX, (void*)(&num));
		}
	}

	public unsafe static int hpBarY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarY, (void*)(&num));
		}
	}

	public unsafe static int hpBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarW, (void*)(&num));
		}
	}

	public unsafe static int expBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_expBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_expBarW, (void*)(&num));
		}
	}

	public unsafe static int lvPosX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lvPosX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lvPosX, (void*)(&num));
		}
	}

	public unsafe static int moneyPosX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_moneyPosX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_moneyPosX, (void*)(&num));
		}
	}

	public unsafe static int hpBarH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarH, (void*)(&num));
		}
	}

	public unsafe static int girlHPBarY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_girlHPBarY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_girlHPBarY, (void*)(&num));
		}
	}

	public unsafe int timeOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOut);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeOut)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> dustX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dustX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dustX)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> dustY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dustY);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dustY)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> dustState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dustState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dustState)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> wsX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wsX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wsX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> wsY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wsY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wsY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> wsState
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wsState, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wsState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> wsF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wsF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wsF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgWS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgWS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgWS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgShuriken
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgShuriken, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgShuriken, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppReferenceArray<Image>> imgDust
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgDust, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Image>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgDust, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
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

	public unsafe static ServerListScreen serverScreen
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverScreen, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ServerListScreen>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverScreen, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serverListScreen));
		}
	}

	public unsafe static ServerScr serverScr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverScr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ServerScr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverScr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)serverScr));
		}
	}

	public unsafe bool resetToLoginScr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetToLoginScr);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resetToLoginScr)) = flag;
		}
	}

	public unsafe long lastSend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSend);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSend)) = num;
		}
	}

	static GameCanvas()
	{
		Il2CppClassPointerStore<GameCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameCanvas");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr);
		NativeFieldInfoPtr_timeNow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "timeNow");
		NativeFieldInfoPtr_open3Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "open3Hour");
		NativeFieldInfoPtr_lowGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "lowGraphic");
		NativeFieldInfoPtr_serverchat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "serverchat");
		NativeFieldInfoPtr_isMoveNumberPad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isMoveNumberPad");
		NativeFieldInfoPtr_isLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isLoading");
		NativeFieldInfoPtr_isTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isTouch");
		NativeFieldInfoPtr_isTouchControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isTouchControl");
		NativeFieldInfoPtr_isTouchControlSmallScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isTouchControlSmallScreen");
		NativeFieldInfoPtr_isTouchControlLargeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isTouchControlLargeScreen");
		NativeFieldInfoPtr_isConnectFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isConnectFail");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_gameStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "gameStarted");
		NativeFieldInfoPtr_bRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bRun");
		NativeFieldInfoPtr_keyPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "keyPressed");
		NativeFieldInfoPtr_keyReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "keyReleased");
		NativeFieldInfoPtr_keyHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "keyHold");
		NativeFieldInfoPtr_isPointerDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isPointerDown");
		NativeFieldInfoPtr_isPointerClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isPointerClick");
		NativeFieldInfoPtr_isPointerJustRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isPointerJustRelease");
		NativeFieldInfoPtr_isPointerMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isPointerMove");
		NativeFieldInfoPtr_px = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "px");
		NativeFieldInfoPtr_py = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "py");
		NativeFieldInfoPtr_pxFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "pxFirst");
		NativeFieldInfoPtr_pyFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "pyFirst");
		NativeFieldInfoPtr_pxLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "pxLast");
		NativeFieldInfoPtr_pyLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "pyLast");
		NativeFieldInfoPtr_pxMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "pxMouse");
		NativeFieldInfoPtr_pyMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "pyMouse");
		NativeFieldInfoPtr_arrPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "arrPos");
		NativeFieldInfoPtr_gameTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "gameTick");
		NativeFieldInfoPtr_taskTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "taskTick");
		NativeFieldInfoPtr_isEff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isEff1");
		NativeFieldInfoPtr_isEff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isEff2");
		NativeFieldInfoPtr_timeTickEff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "timeTickEff1");
		NativeFieldInfoPtr_timeTickEff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "timeTickEff2");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "w");
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "h");
		NativeFieldInfoPtr_hw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hw");
		NativeFieldInfoPtr_hh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hh");
		NativeFieldInfoPtr_wd3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "wd3");
		NativeFieldInfoPtr_hd3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hd3");
		NativeFieldInfoPtr_w2d3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "w2d3");
		NativeFieldInfoPtr_h2d3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "h2d3");
		NativeFieldInfoPtr_w3d4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "w3d4");
		NativeFieldInfoPtr_h3d4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "h3d4");
		NativeFieldInfoPtr_wd6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "wd6");
		NativeFieldInfoPtr_hd6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hd6");
		NativeFieldInfoPtr_currentScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "currentScreen");
		NativeFieldInfoPtr_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "menu");
		NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "panel");
		NativeFieldInfoPtr_panel2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "panel2");
		NativeFieldInfoPtr_loginScr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "loginScr");
		NativeFieldInfoPtr_registerScr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "registerScr");
		NativeFieldInfoPtr_currentDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "currentDialog");
		NativeFieldInfoPtr_msgdlg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "msgdlg");
		NativeFieldInfoPtr_inputDlg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "inputDlg");
		NativeFieldInfoPtr_currentPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "currentPopup");
		NativeFieldInfoPtr_requestLoseCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "requestLoseCount");
		NativeFieldInfoPtr_listPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "listPoint");
		NativeFieldInfoPtr_paintz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "paintz");
		NativeFieldInfoPtr_isGetResFromServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isGetResFromServer");
		NativeFieldInfoPtr_imgBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgBG");
		NativeFieldInfoPtr_skyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "skyColor");
		NativeFieldInfoPtr_curPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "curPos");
		NativeFieldInfoPtr_bgW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bgW");
		NativeFieldInfoPtr_bgH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bgH");
		NativeFieldInfoPtr_planet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "planet");
		NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "g");
		NativeFieldInfoPtr_img12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "img12");
		NativeFieldInfoPtr_imgBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgBlue");
		NativeFieldInfoPtr_imgViolet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgViolet");
		NativeFieldInfoPtr_isPlaySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isPlaySound");
		NativeFieldInfoPtr_clearOldData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "clearOldData");
		NativeFieldInfoPtr_timeOpenKeyBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "timeOpenKeyBoard");
		NativeFieldInfoPtr_isFocusPanel2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isFocusPanel2");
		NativeFieldInfoPtr_isPaintCarret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isPaintCarret");
		NativeFieldInfoPtr_debugUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "debugUpdate");
		NativeFieldInfoPtr_debugPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "debugPaint");
		NativeFieldInfoPtr_debugSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "debugSession");
		NativeFieldInfoPtr_isShowErrorForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isShowErrorForm");
		NativeFieldInfoPtr_paintBG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "paintBG");
		NativeFieldInfoPtr_gsskyHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "gsskyHeight");
		NativeFieldInfoPtr_gsgreenField1Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "gsgreenField1Y");
		NativeFieldInfoPtr_gsgreenField2Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "gsgreenField2Y");
		NativeFieldInfoPtr_gshouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "gshouseY");
		NativeFieldInfoPtr_gsmountainY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "gsmountainY");
		NativeFieldInfoPtr_bgLayer0y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bgLayer0y");
		NativeFieldInfoPtr_bgLayer1y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bgLayer1y");
		NativeFieldInfoPtr_imgCloud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgCloud");
		NativeFieldInfoPtr_imgSun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgSun");
		NativeFieldInfoPtr_imgSun2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgSun2");
		NativeFieldInfoPtr_imgClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgClear");
		NativeFieldInfoPtr_imgBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgBorder");
		NativeFieldInfoPtr_imgSunSpec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgSunSpec");
		NativeFieldInfoPtr_borderConnerW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "borderConnerW");
		NativeFieldInfoPtr_borderConnerH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "borderConnerH");
		NativeFieldInfoPtr_borderCenterW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "borderCenterW");
		NativeFieldInfoPtr_borderCenterH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "borderCenterH");
		NativeFieldInfoPtr_cloudX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cloudX");
		NativeFieldInfoPtr_cloudY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cloudY");
		NativeFieldInfoPtr_sunX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "sunX");
		NativeFieldInfoPtr_sunY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "sunY");
		NativeFieldInfoPtr_sunX2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "sunX2");
		NativeFieldInfoPtr_sunY2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "sunY2");
		NativeFieldInfoPtr_layerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "layerSpeed");
		NativeFieldInfoPtr_moveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "moveX");
		NativeFieldInfoPtr_moveXSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "moveXSpeed");
		NativeFieldInfoPtr_isBoltEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isBoltEff");
		NativeFieldInfoPtr_boltActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "boltActive");
		NativeFieldInfoPtr_tBolt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "tBolt");
		NativeFieldInfoPtr_typeBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "typeBg");
		NativeFieldInfoPtr_transY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "transY");
		NativeFieldInfoPtr_yb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "yb");
		NativeFieldInfoPtr_colorTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "colorTop");
		NativeFieldInfoPtr_colorBotton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "colorBotton");
		NativeFieldInfoPtr_yb1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "yb1");
		NativeFieldInfoPtr_yb2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "yb2");
		NativeFieldInfoPtr_yb3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "yb3");
		NativeFieldInfoPtr_nBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "nBg");
		NativeFieldInfoPtr_lastBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "lastBg");
		NativeFieldInfoPtr_bgRain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bgRain");
		NativeFieldInfoPtr_bgRainFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bgRainFont");
		NativeFieldInfoPtr_imgCaycot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgCaycot");
		NativeFieldInfoPtr_tam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "tam");
		NativeFieldInfoPtr_typeBackGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "typeBackGround");
		NativeFieldInfoPtr_saveIDBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "saveIDBg");
		NativeFieldInfoPtr_isLoadBGok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isLoadBGok");
		NativeFieldInfoPtr_lastTimePress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "lastTimePress");
		NativeFieldInfoPtr_keyAsciiPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "keyAsciiPress");
		NativeFieldInfoPtr_pXYScrollMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "pXYScrollMouse");
		NativeFieldInfoPtr_imgSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgSignal");
		NativeFieldInfoPtr_flyTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "flyTexts");
		NativeFieldInfoPtr_longTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "longTime");
		NativeFieldInfoPtr_isPointerJustDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isPointerJustDown");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "count");
		NativeFieldInfoPtr_csWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "csWait");
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "r");
		NativeFieldInfoPtr_isBlackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isBlackScreen");
		NativeFieldInfoPtr_bgSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "bgSpeed");
		NativeFieldInfoPtr_cmdBarX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cmdBarX");
		NativeFieldInfoPtr_cmdBarY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cmdBarY");
		NativeFieldInfoPtr_cmdBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cmdBarW");
		NativeFieldInfoPtr_cmdBarH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cmdBarH");
		NativeFieldInfoPtr_cmdBarLeftW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cmdBarLeftW");
		NativeFieldInfoPtr_cmdBarRightW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cmdBarRightW");
		NativeFieldInfoPtr_cmdBarCenterW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "cmdBarCenterW");
		NativeFieldInfoPtr_hpBarX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hpBarX");
		NativeFieldInfoPtr_hpBarY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hpBarY");
		NativeFieldInfoPtr_hpBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hpBarW");
		NativeFieldInfoPtr_expBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "expBarW");
		NativeFieldInfoPtr_lvPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "lvPosX");
		NativeFieldInfoPtr_moneyPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "moneyPosX");
		NativeFieldInfoPtr_hpBarH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "hpBarH");
		NativeFieldInfoPtr_girlHPBarY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "girlHPBarY");
		NativeFieldInfoPtr_timeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "timeOut");
		NativeFieldInfoPtr_dustX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "dustX");
		NativeFieldInfoPtr_dustY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "dustY");
		NativeFieldInfoPtr_dustState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "dustState");
		NativeFieldInfoPtr_wsX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "wsX");
		NativeFieldInfoPtr_wsY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "wsY");
		NativeFieldInfoPtr_wsState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "wsState");
		NativeFieldInfoPtr_wsF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "wsF");
		NativeFieldInfoPtr_imgWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgWS");
		NativeFieldInfoPtr_imgShuriken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgShuriken");
		NativeFieldInfoPtr_imgDust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "imgDust");
		NativeFieldInfoPtr_isResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "isResume");
		NativeFieldInfoPtr_serverScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "serverScreen");
		NativeFieldInfoPtr_serverScr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "serverScr");
		NativeFieldInfoPtr_resetToLoginScr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "resetToLoginScr");
		NativeFieldInfoPtr_lastSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, "lastSend");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr_getPlatformName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664014);
		NativeMethodInfoPtr_initGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664015);
		NativeMethodInfoPtr_gI_Public_Static_GameCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664016);
		NativeMethodInfoPtr_initPaint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664017);
		NativeMethodInfoPtr_closeKeyBoard_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664018);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664019);
		NativeMethodInfoPtr_onDisconnected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664020);
		NativeMethodInfoPtr_onConnectionFail_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664021);
		NativeMethodInfoPtr_isWaiting_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664022);
		NativeMethodInfoPtr_connect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664023);
		NativeMethodInfoPtr_connect2_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664024);
		NativeMethodInfoPtr_resetTrans_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664025);
		NativeMethodInfoPtr_resetTransGameScr_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664026);
		NativeMethodInfoPtr_initGameCanvas_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664027);
		NativeMethodInfoPtr_start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664028);
		NativeMethodInfoPtr_getWidth_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_getHeight_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_debug_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_doResetToLoginScr_Public_Void_mScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_showErrorForm_Public_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_paintCloud_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_updateBG_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_fillRect_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_paintBackgroundtLayer_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_drawSun1_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_drawSun2_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr_isHDVersion_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_paintBGGameScr_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_resetBg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_getYBackground_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_loadBG_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_randomRaintEff_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_keyPressedz_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_mapKeyPress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_keyReleasedz_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_mapKeyRelease_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_pointerMouse_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_scrollMouse_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_pointerDragged_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_isHoldPress_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_pointerPressed_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_pointerReleased_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_isPointerIn_Public_Static_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr_isPointerHoldIn_Public_Static_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664057);
		NativeMethodInfoPtr_isMouseFocus_Public_Static_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664058);
		NativeMethodInfoPtr_clearKeyPressed_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_clearKeyHold_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664060);
		NativeMethodInfoPtr_checkBackButton_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr_paintBlack_Public_Void_mGraphics_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr_paintChangeMap_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664063);
		NativeMethodInfoPtr_paint_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664064);
		NativeMethodInfoPtr_endDlg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664065);
		NativeMethodInfoPtr_startOKDlg_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664066);
		NativeMethodInfoPtr_startWaitDlg_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664067);
		NativeMethodInfoPtr_startOKDlg_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664068);
		NativeMethodInfoPtr_startWaitDlg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664069);
		NativeMethodInfoPtr_openWeb_Public_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_startOK_Public_Static_Void_String_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664071);
		NativeMethodInfoPtr_startYesNoDlg_Public_Static_Void_String_Int32_Object_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664072);
		NativeMethodInfoPtr_startYesNoDlg_Public_Static_Void_String_Command_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664073);
		NativeMethodInfoPtr_getMoneys_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr_getX_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664075);
		NativeMethodInfoPtr_getY_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr_sizeChanged_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_isGetResourceFromServer_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664078);
		NativeMethodInfoPtr_loadImageRMS_Public_Static_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664079);
		NativeMethodInfoPtr_Resize_Public_Static_Texture2D_Texture2D_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr_resizeImage_Public_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664081);
		NativeMethodInfoPtr_loadImage_Public_Static_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr_cutPng_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664083);
		NativeMethodInfoPtr_random_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664084);
		NativeMethodInfoPtr_startDust_Public_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_loadWaterSplash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_startWaterSplash_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr_updateWaterSplash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_updateDust_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr_isPaint_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664090);
		NativeMethodInfoPtr_paintDust_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664091);
		NativeMethodInfoPtr_loadDust_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664092);
		NativeMethodInfoPtr_paintShukiren_Public_Static_Void_Int32_Int32_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664093);
		NativeMethodInfoPtr_resetToLoginScrz_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664094);
		NativeMethodInfoPtr_isPointer_Public_Static_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664095);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664096);
		NativeMethodInfoPtr_clearAllPointerEvent_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_backToRegister_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr, 100664098);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34781, RefRangeEnd = 34782, XrefRangeStart = 34741, XrefRangeEnd = 34781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameCanvas()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCanvas>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34782, XrefRangeEnd = 34784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getPlatformName()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPlatformName_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35135, RefRangeEnd = 35136, XrefRangeStart = 34784, XrefRangeEnd = 35135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35136, XrefRangeEnd = 35140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameCanvas gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_GameCanvas_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCanvas>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35140, XrefRangeEnd = 35150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initPaint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initPaint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 35162, RefRangeEnd = 35170, XrefRangeStart = 35150, XrefRangeEnd = 35162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void closeKeyBoard()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_closeKeyBoard_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35580, RefRangeEnd = 35581, XrefRangeStart = 35170, XrefRangeEnd = 35580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35653, RefRangeEnd = 35655, XrefRangeStart = 35581, XrefRangeEnd = 35653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onDisconnected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35750, RefRangeEnd = 35752, XrefRangeStart = 35655, XrefRangeEnd = 35750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onConnectionFail()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onConnectionFail_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35772, RefRangeEnd = 35773, XrefRangeStart = 35752, XrefRangeEnd = 35772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isWaiting()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isWaiting_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 35796, RefRangeEnd = 35810, XrefRangeStart = 35773, XrefRangeEnd = 35796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void connect()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_connect_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35845, RefRangeEnd = 35847, XrefRangeStart = 35810, XrefRangeEnd = 35845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void connect2()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_connect2_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 35855, RefRangeEnd = 35867, XrefRangeStart = 35847, XrefRangeEnd = 35855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetTrans(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetTrans_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35882, RefRangeEnd = 35883, XrefRangeStart = 35867, XrefRangeEnd = 35882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetTransGameScr(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetTransGameScr_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35883, XrefRangeEnd = 35929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initGameCanvas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initGameCanvas_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35929, XrefRangeEnd = 35933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getWidth_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35933, XrefRangeEnd = 35937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeight_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void debug(string s, int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_debug_Public_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 36057, RefRangeEnd = 36061, XrefRangeStart = 35937, XrefRangeEnd = 36057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doResetToLoginScr(mScreen screen)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screen);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doResetToLoginScr_Public_Void_mScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showErrorForm(int type, string moreInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(moreInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showErrorForm_Public_Static_Void_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintCloud(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCloud_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateBG()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateBG_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 36075, RefRangeEnd = 36082, XrefRangeStart = 36061, XrefRangeEnd = 36075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void fillRect(mGraphics g, int color, int x, int y, int w, int h, int detalY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &detalY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fillRect_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 36272, RefRangeEnd = 36325, XrefRangeStart = 36082, XrefRangeEnd = 36272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintBackgroundtLayer(mGraphics g, int layer, int deltaY, int color1, int color2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deltaY;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &color1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBackgroundtLayer_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 36356, RefRangeEnd = 36365, XrefRangeStart = 36325, XrefRangeEnd = 36356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawSun1(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawSun1_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 36368, RefRangeEnd = 36375, XrefRangeStart = 36365, XrefRangeEnd = 36368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void drawSun2(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawSun2_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36375, XrefRangeEnd = 36379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isHDVersion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHDVersion_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 36787, RefRangeEnd = 36793, XrefRangeStart = 36379, XrefRangeEnd = 36787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintBGGameScr(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBGGameScr_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetBg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetBg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 36929, RefRangeEnd = 36930, XrefRangeStart = 36793, XrefRangeEnd = 36929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getYBackground(int typeBg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeBg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getYBackground_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 37920, RefRangeEnd = 37925, XrefRangeStart = 36930, XrefRangeEnd = 37920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadBG(int typeBG)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeBG);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadBG_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37925, XrefRangeEnd = 37941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void randomRaintEff(int typeBG)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeBG);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_randomRaintEff_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 37953, RefRangeEnd = 37955, XrefRangeStart = 37941, XrefRangeEnd = 37953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void keyPressedz(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keyPressedz_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37968, RefRangeEnd = 37969, XrefRangeStart = 37955, XrefRangeEnd = 37968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void mapKeyPress(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mapKeyPress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 37974, RefRangeEnd = 37976, XrefRangeStart = 37969, XrefRangeEnd = 37974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void keyReleasedz(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keyReleasedz_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37983, RefRangeEnd = 37984, XrefRangeStart = 37976, XrefRangeEnd = 37983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void mapKeyRelease(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mapKeyRelease_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 37989, RefRangeEnd = 37990, XrefRangeStart = 37984, XrefRangeEnd = 37989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pointerMouse(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pointerMouse_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38000, RefRangeEnd = 38001, XrefRangeStart = 37990, XrefRangeEnd = 38000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void scrollMouse(int a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scrollMouse_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38041, RefRangeEnd = 38043, XrefRangeStart = 38001, XrefRangeEnd = 38041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pointerDragged(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pointerDragged_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38043, XrefRangeEnd = 38051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isHoldPress()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHoldPress_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38070, RefRangeEnd = 38072, XrefRangeStart = 38051, XrefRangeEnd = 38070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pointerPressed(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pointerPressed_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38084, RefRangeEnd = 38086, XrefRangeStart = 38072, XrefRangeEnd = 38084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pointerReleased(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pointerReleased_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38097, RefRangeEnd = 38098, XrefRangeStart = 38086, XrefRangeEnd = 38097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPointerIn(int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPointerIn_Public_Static_Boolean_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(61)]
	[CachedScanResults(RefRangeStart = 38113, RefRangeEnd = 38174, XrefRangeStart = 38098, XrefRangeEnd = 38113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPointerHoldIn(int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPointerHoldIn_Public_Static_Boolean_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 38185, RefRangeEnd = 38189, XrefRangeStart = 38174, XrefRangeEnd = 38185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMouseFocus(int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMouseFocus_Public_Static_Boolean_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 38198, RefRangeEnd = 38227, XrefRangeStart = 38189, XrefRangeEnd = 38198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearKeyPressed()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearKeyPressed_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 38234, RefRangeEnd = 38254, XrefRangeStart = 38227, XrefRangeEnd = 38234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearKeyHold()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearKeyHold_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38254, XrefRangeEnd = 38284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void checkBackButton()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkBackButton_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38313, RefRangeEnd = 38315, XrefRangeStart = 38284, XrefRangeEnd = 38313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintBlack(mGraphics g, string info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBlack_Public_Void_mGraphics_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38363, RefRangeEnd = 38364, XrefRangeStart = 38315, XrefRangeEnd = 38363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintChangeMap(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintChangeMap_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 38550, RefRangeEnd = 38552, XrefRangeStart = 38364, XrefRangeEnd = 38550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint(mGraphics gx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 38565, RefRangeEnd = 38616, XrefRangeStart = 38552, XrefRangeEnd = 38565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void endDlg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_endDlg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 38648, RefRangeEnd = 38662, XrefRangeStart = 38616, XrefRangeEnd = 38648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startOKDlg(string info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startOKDlg_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 38681, RefRangeEnd = 38686, XrefRangeStart = 38662, XrefRangeEnd = 38681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startWaitDlg(string info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startWaitDlg_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38686, XrefRangeEnd = 38705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startOKDlg(string info, bool isError)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isError;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startOKDlg_Public_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 38719, RefRangeEnd = 38725, XrefRangeStart = 38705, XrefRangeEnd = 38719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startWaitDlg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startWaitDlg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38725, XrefRangeEnd = 38741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openWeb(string strLeft, string strRight, string url, string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strRight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openWeb_Public_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 38758, RefRangeEnd = 38768, XrefRangeStart = 38741, XrefRangeEnd = 38758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startOK(string info, int actionID, Il2CppSystem.Object p)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startOK_Public_Static_Void_String_Int32_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38768, XrefRangeEnd = 38796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startYesNoDlg(string info, int iYes, Il2CppSystem.Object pYes, int iNo, Il2CppSystem.Object pNo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &iYes;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pYes);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &iNo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pNo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startYesNoDlg_Public_Static_Void_String_Int32_Object_Int32_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 38804, RefRangeEnd = 38815, XrefRangeStart = 38796, XrefRangeEnd = 38804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startYesNoDlg(string info, Command cmdYes, Command cmdNo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdYes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdNo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startYesNoDlg_Public_Static_Void_String_Command_Command_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38835, RefRangeEnd = 38836, XrefRangeStart = 38815, XrefRangeEnd = 38835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getMoneys(int m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMoneys_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38836, XrefRangeEnd = 38840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getX(int start, int w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getX_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38840, XrefRangeEnd = 38844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getY(int start, int w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getY_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sizeChanged(int w, int h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&w);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sizeChanged_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 38844, RefRangeEnd = 38851, XrefRangeStart = 38844, XrefRangeEnd = 38844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isGetResourceFromServer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isGetResourceFromServer_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(40)]
	[CachedScanResults(RefRangeStart = 38892, RefRangeEnd = 38932, XrefRangeStart = 38851, XrefRangeEnd = 38892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image loadImageRMS(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadImageRMS_Public_Static_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38932, XrefRangeEnd = 38947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D Resize(Texture2D texture2D, int targetX, int targetY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetX;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resize_Public_Static_Texture2D_Texture2D_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 38972, RefRangeEnd = 38973, XrefRangeStart = 38947, XrefRangeEnd = 38972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resizeImage(Image img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resizeImage_Public_Static_Void_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(714)]
	[CachedScanResults(RefRangeStart = 38999, RefRangeEnd = 39713, XrefRangeStart = 38973, XrefRangeEnd = 38999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image loadImage(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadImage_Public_Static_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39713, XrefRangeEnd = 39720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string cutPng(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cutPng_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39720, XrefRangeEnd = 39725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int random(int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_random_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 39730, RefRangeEnd = 39739, XrefRangeStart = 39725, XrefRangeEnd = 39730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool startDust(int dir, int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&dir);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startDust_Public_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39787, RefRangeEnd = 39788, XrefRangeStart = 39739, XrefRangeEnd = 39787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadWaterSplash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadWaterSplash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39788, XrefRangeEnd = 39801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool startWaterSplash(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startWaterSplash_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39801, XrefRangeEnd = 39819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateWaterSplash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateWaterSplash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39824, RefRangeEnd = 39825, XrefRangeStart = 39819, XrefRangeEnd = 39824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateDust()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateDust_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 39835, RefRangeEnd = 39838, XrefRangeStart = 39825, XrefRangeEnd = 39835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPaint(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPaint_Public_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39838, XrefRangeEnd = 39849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintDust(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintDust_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39900, RefRangeEnd = 39901, XrefRangeStart = 39849, XrefRangeEnd = 39900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadDust()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadDust_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 39914, RefRangeEnd = 39918, XrefRangeStart = 39901, XrefRangeEnd = 39914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintShukiren(int x, int y, mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintShukiren_Public_Static_Void_Int32_Int32_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void resetToLoginScrz()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetToLoginScrz_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 39933, RefRangeEnd = 39942, XrefRangeStart = 39918, XrefRangeEnd = 39933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPointer(int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPointer_Public_Static_Boolean_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39942, XrefRangeEnd = 40086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void perform(int idAction, Il2CppSystem.Object p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 40098, RefRangeEnd = 40131, XrefRangeStart = 40086, XrefRangeEnd = 40098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearAllPointerEvent()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearAllPointerEvent_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void backToRegister()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_backToRegister_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameCanvas(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
