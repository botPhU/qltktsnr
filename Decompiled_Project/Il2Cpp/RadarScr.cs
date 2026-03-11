using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2Cpp;

public class RadarScr : mScreen
{
	private static readonly IntPtr NativeFieldInfoPtr_SUBCMD_ALL;

	private static readonly IntPtr NativeFieldInfoPtr_SUBCMD_USE;

	private static readonly IntPtr NativeFieldInfoPtr_SUBCMD_LEVEL;

	private static readonly IntPtr NativeFieldInfoPtr_SUBCMD_AMOUNT;

	private static readonly IntPtr NativeFieldInfoPtr_SUBCMD_AURA;

	private static readonly IntPtr NativeFieldInfoPtr_instance;

	private static readonly IntPtr NativeFieldInfoPtr_TYPE_UI;

	private static readonly IntPtr NativeFieldInfoPtr_fraImgFocus;

	private static readonly IntPtr NativeFieldInfoPtr_fraImgFocusNone;

	private static readonly IntPtr NativeFieldInfoPtr_fraEff;

	private static readonly IntPtr NativeFieldInfoPtr_imgUI;

	private static readonly IntPtr NativeFieldInfoPtr_imgUIText;

	private static readonly IntPtr NativeFieldInfoPtr_imgArrow_Left;

	private static readonly IntPtr NativeFieldInfoPtr_imgArrow_Right;

	private static readonly IntPtr NativeFieldInfoPtr_imgArrow_Down;

	private static readonly IntPtr NativeFieldInfoPtr_imgLock;

	private static readonly IntPtr NativeFieldInfoPtr_imgUse_0;

	private static readonly IntPtr NativeFieldInfoPtr_imgUse;

	private static readonly IntPtr NativeFieldInfoPtr_imgBack;

	private static readonly IntPtr NativeFieldInfoPtr_imgChange;

	private static readonly IntPtr NativeFieldInfoPtr_imgBar_0;

	private static readonly IntPtr NativeFieldInfoPtr_imgBar_1;

	private static readonly IntPtr NativeFieldInfoPtr_imgPro_0;

	private static readonly IntPtr NativeFieldInfoPtr_imgPro_1;

	private static readonly IntPtr NativeFieldInfoPtr_imgRank;

	private static readonly IntPtr NativeFieldInfoPtr_xUi;

	private static readonly IntPtr NativeFieldInfoPtr_yUi;

	private static readonly IntPtr NativeFieldInfoPtr_wUi;

	private static readonly IntPtr NativeFieldInfoPtr_hUi;

	private static readonly IntPtr NativeFieldInfoPtr_xMon;

	private static readonly IntPtr NativeFieldInfoPtr_yMon;

	private static readonly IntPtr NativeFieldInfoPtr_xText;

	private static readonly IntPtr NativeFieldInfoPtr_yText;

	private static readonly IntPtr NativeFieldInfoPtr_wText;

	private static readonly IntPtr NativeFieldInfoPtr_cmyText;

	private static readonly IntPtr NativeFieldInfoPtr_hText;

	private static readonly IntPtr NativeFieldInfoPtr_yCmd;

	private static readonly IntPtr NativeFieldInfoPtr_xCmd;

	private static readonly IntPtr NativeFieldInfoPtr_dxCmd;

	private static readonly IntPtr NativeFieldInfoPtr_xyArrow;

	private static readonly IntPtr NativeFieldInfoPtr_xyItem;

	private static readonly IntPtr NativeFieldInfoPtr_index;

	private static readonly IntPtr NativeFieldInfoPtr_dyArrow;

	private static readonly IntPtr NativeFieldInfoPtr_dxArrow;

	private static readonly IntPtr NativeFieldInfoPtr_page;

	private static readonly IntPtr NativeFieldInfoPtr_maxpage;

	private static readonly IntPtr NativeFieldInfoPtr_indexFocus;

	private static readonly IntPtr NativeFieldInfoPtr_list;

	private static readonly IntPtr NativeFieldInfoPtr_listUse;

	private static readonly IntPtr NativeFieldInfoPtr_num;

	private static readonly IntPtr NativeFieldInfoPtr_numMax;

	private static readonly IntPtr NativeFieldInfoPtr_focus_card;

	private static readonly IntPtr NativeFieldInfoPtr_pxx;

	private static readonly IntPtr NativeFieldInfoPtr_pyy;

	private static readonly IntPtr NativeFieldInfoPtr_xClip;

	private static readonly IntPtr NativeFieldInfoPtr_wClip;

	private static readonly IntPtr NativeFieldInfoPtr_yClip;

	private static readonly IntPtr NativeFieldInfoPtr_hClip;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_gI_Public_Static_RadarScr_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetRadarScr_Public_Void_MyVector_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetNum_Public_Static_Void_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetListUse_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_listIndex_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_update_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_doChangeUI_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_updateKeyTouchControl_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_doClickUse_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_doClickArrow_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_doClickItem_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_doKeyText_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_doKeyItem_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0;

	private static readonly IntPtr NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0;

	public unsafe static sbyte SUBCMD_ALL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUBCMD_ALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUBCMD_ALL, (void*)(&b));
		}
	}

	public unsafe static sbyte SUBCMD_USE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUBCMD_USE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUBCMD_USE, (void*)(&b));
		}
	}

	public unsafe static sbyte SUBCMD_LEVEL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUBCMD_LEVEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUBCMD_LEVEL, (void*)(&b));
		}
	}

	public unsafe static sbyte SUBCMD_AMOUNT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUBCMD_AMOUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUBCMD_AMOUNT, (void*)(&b));
		}
	}

	public unsafe static sbyte SUBCMD_AURA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUBCMD_AURA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUBCMD_AURA, (void*)(&b));
		}
	}

	public unsafe static RadarScr instance
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RadarScr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)radarScr));
		}
	}

	public unsafe static bool TYPE_UI
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_UI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_UI, (void*)(&flag));
		}
	}

	public unsafe static FrameImage fraImgFocus
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fraImgFocus, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fraImgFocus, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe static FrameImage fraImgFocusNone
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fraImgFocusNone, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fraImgFocusNone, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe static FrameImage fraEff
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fraEff, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fraEff, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe static Image imgUI
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgUI, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgUI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgUIText
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgUIText, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgUIText, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgArrow_Left
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgArrow_Left, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgArrow_Left, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgArrow_Right
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgArrow_Right, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgArrow_Right, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgArrow_Down
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgArrow_Down, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgArrow_Down, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgLock
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLock, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgUse_0
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgUse_0, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgUse_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgUse
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgUse, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgUse, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgBack
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgBack, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgBack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgChange
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgChange, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgChange, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgBar_0
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgBar_0, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgBar_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgBar_1
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgBar_1, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgBar_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgPro_0
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgPro_0, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgPro_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgPro_1
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgPro_1, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgPro_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgRank
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgRank, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgRank, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int xUi
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xUi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xUi, (void*)(&num));
		}
	}

	public unsafe static int yUi
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yUi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yUi, (void*)(&num));
		}
	}

	public unsafe static int wUi
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wUi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wUi, (void*)(&num));
		}
	}

	public unsafe static int hUi
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hUi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hUi, (void*)(&num));
		}
	}

	public unsafe static int xMon
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xMon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xMon, (void*)(&num));
		}
	}

	public unsafe static int yMon
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yMon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yMon, (void*)(&num));
		}
	}

	public unsafe static int xText
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xText, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xText, (void*)(&num));
		}
	}

	public unsafe static int yText
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yText, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yText, (void*)(&num));
		}
	}

	public unsafe static int wText
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wText, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wText, (void*)(&num));
		}
	}

	public unsafe static int cmyText
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmyText, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmyText, (void*)(&num));
		}
	}

	public unsafe static int hText
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hText, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hText, (void*)(&num));
		}
	}

	public unsafe static int yCmd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yCmd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yCmd, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> xCmd
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xCmd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xCmd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> dxCmd
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dxCmd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dxCmd, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> xyArrow
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xyArrow, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xyArrow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> xyItem
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xyItem, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xyItem, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> index
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_index, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_index, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int dyArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyArrow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyArrow)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> dxArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dxArrow);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dxArrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int page
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_page)) = num;
		}
	}

	public unsafe int maxpage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxpage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxpage)) = num;
		}
	}

	public unsafe int indexFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexFocus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexFocus)) = num;
		}
	}

	public unsafe static MyVector list
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_list, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_list, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector listUse
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listUse, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listUse, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static int num
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_num, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_num, (void*)(&num));
		}
	}

	public unsafe static int numMax
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numMax, (void*)(&num));
		}
	}

	public unsafe Info_RadaScr focus_card
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focus_card);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Info_RadaScr>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focus_card)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info_RadaScr));
		}
	}

	public unsafe int pxx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pxx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pxx)) = num;
		}
	}

	public unsafe int pyy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pyy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pyy)) = num;
		}
	}

	public unsafe int xClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xClip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xClip)) = num;
		}
	}

	public unsafe int wClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wClip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wClip)) = num;
		}
	}

	public unsafe int yClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yClip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yClip)) = num;
		}
	}

	public unsafe int hClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hClip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hClip)) = num;
		}
	}

	static RadarScr()
	{
		Il2CppClassPointerStore<RadarScr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RadarScr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadarScr>.NativeClassPtr);
		NativeFieldInfoPtr_SUBCMD_ALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "SUBCMD_ALL");
		NativeFieldInfoPtr_SUBCMD_USE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "SUBCMD_USE");
		NativeFieldInfoPtr_SUBCMD_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "SUBCMD_LEVEL");
		NativeFieldInfoPtr_SUBCMD_AMOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "SUBCMD_AMOUNT");
		NativeFieldInfoPtr_SUBCMD_AURA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "SUBCMD_AURA");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_TYPE_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "TYPE_UI");
		NativeFieldInfoPtr_fraImgFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "fraImgFocus");
		NativeFieldInfoPtr_fraImgFocusNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "fraImgFocusNone");
		NativeFieldInfoPtr_fraEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "fraEff");
		NativeFieldInfoPtr_imgUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgUI");
		NativeFieldInfoPtr_imgUIText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgUIText");
		NativeFieldInfoPtr_imgArrow_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgArrow_Left");
		NativeFieldInfoPtr_imgArrow_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgArrow_Right");
		NativeFieldInfoPtr_imgArrow_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgArrow_Down");
		NativeFieldInfoPtr_imgLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgLock");
		NativeFieldInfoPtr_imgUse_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgUse_0");
		NativeFieldInfoPtr_imgUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgUse");
		NativeFieldInfoPtr_imgBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgBack");
		NativeFieldInfoPtr_imgChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgChange");
		NativeFieldInfoPtr_imgBar_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgBar_0");
		NativeFieldInfoPtr_imgBar_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgBar_1");
		NativeFieldInfoPtr_imgPro_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgPro_0");
		NativeFieldInfoPtr_imgPro_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgPro_1");
		NativeFieldInfoPtr_imgRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "imgRank");
		NativeFieldInfoPtr_xUi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "xUi");
		NativeFieldInfoPtr_yUi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "yUi");
		NativeFieldInfoPtr_wUi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "wUi");
		NativeFieldInfoPtr_hUi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "hUi");
		NativeFieldInfoPtr_xMon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "xMon");
		NativeFieldInfoPtr_yMon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "yMon");
		NativeFieldInfoPtr_xText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "xText");
		NativeFieldInfoPtr_yText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "yText");
		NativeFieldInfoPtr_wText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "wText");
		NativeFieldInfoPtr_cmyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "cmyText");
		NativeFieldInfoPtr_hText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "hText");
		NativeFieldInfoPtr_yCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "yCmd");
		NativeFieldInfoPtr_xCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "xCmd");
		NativeFieldInfoPtr_dxCmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "dxCmd");
		NativeFieldInfoPtr_xyArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "xyArrow");
		NativeFieldInfoPtr_xyItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "xyItem");
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "index");
		NativeFieldInfoPtr_dyArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "dyArrow");
		NativeFieldInfoPtr_dxArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "dxArrow");
		NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "page");
		NativeFieldInfoPtr_maxpage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "maxpage");
		NativeFieldInfoPtr_indexFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "indexFocus");
		NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "list");
		NativeFieldInfoPtr_listUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "listUse");
		NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "num");
		NativeFieldInfoPtr_numMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "numMax");
		NativeFieldInfoPtr_focus_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "focus_card");
		NativeFieldInfoPtr_pxx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "pxx");
		NativeFieldInfoPtr_pyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "pyy");
		NativeFieldInfoPtr_xClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "xClip");
		NativeFieldInfoPtr_wClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "wClip");
		NativeFieldInfoPtr_yClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "yClip");
		NativeFieldInfoPtr_hClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, "hClip");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665697);
		NativeMethodInfoPtr_gI_Public_Static_RadarScr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665698);
		NativeMethodInfoPtr_SetRadarScr_Public_Void_MyVector_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665699);
		NativeMethodInfoPtr_SetNum_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665700);
		NativeMethodInfoPtr_SetListUse_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665701);
		NativeMethodInfoPtr_listIndex_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665702);
		NativeMethodInfoPtr_update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665703);
		NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665704);
		NativeMethodInfoPtr_doChangeUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665705);
		NativeMethodInfoPtr_updateKeyTouchControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665706);
		NativeMethodInfoPtr_doClickUse_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665707);
		NativeMethodInfoPtr_doClickArrow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665708);
		NativeMethodInfoPtr_doClickItem_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665709);
		NativeMethodInfoPtr_doKeyText_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665710);
		NativeMethodInfoPtr_doKeyItem_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665711);
		NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665712);
		NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RadarScr>.NativeClassPtr, 100665713);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83527, RefRangeEnd = 83528, XrefRangeStart = 83266, XrefRangeEnd = 83527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RadarScr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RadarScr>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 83542, RefRangeEnd = 83546, XrefRangeStart = 83528, XrefRangeEnd = 83542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RadarScr gI()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_RadarScr_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RadarScr>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83566, RefRangeEnd = 83567, XrefRangeStart = 83546, XrefRangeEnd = 83566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRadarScr(MyVector list, int num, int numMax)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &num;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &numMax;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRadarScr_Public_Void_MyVector_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83572, RefRangeEnd = 83573, XrefRangeStart = 83567, XrefRangeEnd = 83572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetNum(int num, int numMax)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&num);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &numMax;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNum_Public_Static_Void_Int32_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83602, RefRangeEnd = 83604, XrefRangeStart = 83573, XrefRangeEnd = 83602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetListUse()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetListUse_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 83633, RefRangeEnd = 83638, XrefRangeStart = 83604, XrefRangeEnd = 83633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void listIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_listIndex_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83638, XrefRangeEnd = 83681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83681, XrefRangeEnd = 83797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void updateKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83815, RefRangeEnd = 83817, XrefRangeStart = 83797, XrefRangeEnd = 83815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doChangeUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doChangeUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 83836, RefRangeEnd = 83837, XrefRangeStart = 83817, XrefRangeEnd = 83836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateKeyTouchControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKeyTouchControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83837, XrefRangeEnd = 83855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doClickUse(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doClickUse_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83855, XrefRangeEnd = 83871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doClickArrow(int dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&dir);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doClickArrow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83871, XrefRangeEnd = 83872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doClickItem(int focus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&focus);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doClickItem_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83884, RefRangeEnd = 83886, XrefRangeStart = 83872, XrefRangeEnd = 83884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doKeyText(int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doKeyText_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 83901, RefRangeEnd = 83903, XrefRangeStart = 83886, XrefRangeEnd = 83901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doKeyItem(int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doKeyItem_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83903, XrefRangeEnd = 84089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84089, XrefRangeEnd = 84094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void switchToMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public RadarScr(IntPtr pointer)
		: base(pointer)
	{
	}
}
