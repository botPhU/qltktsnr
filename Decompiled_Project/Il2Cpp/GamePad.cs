using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class GamePad : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xC;

	private static readonly System.IntPtr NativeFieldInfoPtr_yC;

	private static readonly System.IntPtr NativeFieldInfoPtr_xM;

	private static readonly System.IntPtr NativeFieldInfoPtr_yM;

	private static readonly System.IntPtr NativeFieldInfoPtr_xMLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMLast;

	private static readonly System.IntPtr NativeFieldInfoPtr_R;

	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_d;

	private static readonly System.IntPtr NativeFieldInfoPtr_xTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_yTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaX;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaY;

	private static readonly System.IntPtr NativeFieldInfoPtr_delta;

	private static readonly System.IntPtr NativeFieldInfoPtr_angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_xZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_yZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_wZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_hZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGamePad;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSmallGamePad;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMediumGamePad;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLargeGamePad;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkPointerMove_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetHold_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_disableCheckDrag_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_disableClickMove_Public_Boolean_0;

	public unsafe int xC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xC);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xC)) = num;
		}
	}

	public unsafe int yC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yC);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yC)) = num;
		}
	}

	public unsafe int xM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xM);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xM)) = num;
		}
	}

	public unsafe int yM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yM);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yM)) = num;
		}
	}

	public unsafe int xMLast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMLast);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMLast)) = num;
		}
	}

	public unsafe int yMLast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMLast);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMLast)) = num;
		}
	}

	public unsafe int R
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_R);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_R)) = num;
		}
	}

	public unsafe int r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r)) = num;
		}
	}

	public unsafe int d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d)) = num;
		}
	}

	public unsafe int xTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xTemp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xTemp)) = num;
		}
	}

	public unsafe int yTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yTemp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yTemp)) = num;
		}
	}

	public unsafe int deltaX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaX)) = num;
		}
	}

	public unsafe int deltaY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaY)) = num;
		}
	}

	public unsafe int delta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delta);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delta)) = num;
		}
	}

	public unsafe int angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angle)) = num;
		}
	}

	public unsafe int xZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xZone);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xZone)) = num;
		}
	}

	public unsafe int yZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yZone);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yZone)) = num;
		}
	}

	public unsafe int wZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wZone);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wZone)) = num;
		}
	}

	public unsafe int hZone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hZone);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hZone)) = num;
		}
	}

	public unsafe bool isGamePad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGamePad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGamePad)) = flag;
		}
	}

	public unsafe bool isSmallGamePad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSmallGamePad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSmallGamePad)) = flag;
		}
	}

	public unsafe bool isMediumGamePad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMediumGamePad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMediumGamePad)) = flag;
		}
	}

	public unsafe bool isLargeGamePad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLargeGamePad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLargeGamePad)) = flag;
		}
	}

	static GamePad()
	{
		Il2CppClassPointerStore<GamePad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamePad");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePad>.NativeClassPtr);
		NativeFieldInfoPtr_xC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "xC");
		NativeFieldInfoPtr_yC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "yC");
		NativeFieldInfoPtr_xM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "xM");
		NativeFieldInfoPtr_yM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "yM");
		NativeFieldInfoPtr_xMLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "xMLast");
		NativeFieldInfoPtr_yMLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "yMLast");
		NativeFieldInfoPtr_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "R");
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "r");
		NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "d");
		NativeFieldInfoPtr_xTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "xTemp");
		NativeFieldInfoPtr_yTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "yTemp");
		NativeFieldInfoPtr_deltaX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "deltaX");
		NativeFieldInfoPtr_deltaY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "deltaY");
		NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "delta");
		NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "angle");
		NativeFieldInfoPtr_xZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "xZone");
		NativeFieldInfoPtr_yZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "yZone");
		NativeFieldInfoPtr_wZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "wZone");
		NativeFieldInfoPtr_hZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "hZone");
		NativeFieldInfoPtr_isGamePad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "isGamePad");
		NativeFieldInfoPtr_isSmallGamePad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "isSmallGamePad");
		NativeFieldInfoPtr_isMediumGamePad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "isMediumGamePad");
		NativeFieldInfoPtr_isLargeGamePad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePad>.NativeClassPtr, "isLargeGamePad");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100664123);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100664124);
		NativeMethodInfoPtr_checkPointerMove_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100664125);
		NativeMethodInfoPtr_resetHold_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100664126);
		NativeMethodInfoPtr_paint_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100664127);
		NativeMethodInfoPtr_disableCheckDrag_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100664128);
		NativeMethodInfoPtr_disableClickMove_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100664129);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40550, RefRangeEnd = 40551, XrefRangeStart = 40532, XrefRangeEnd = 40550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GamePad()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamePad>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40751, RefRangeEnd = 40752, XrefRangeStart = 40551, XrefRangeEnd = 40751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40775, RefRangeEnd = 40776, XrefRangeStart = 40752, XrefRangeEnd = 40775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkPointerMove(int distance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&distance);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkPointerMove_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 40780, RefRangeEnd = 40782, XrefRangeStart = 40776, XrefRangeEnd = 40780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resetHold()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetHold_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40796, RefRangeEnd = 40797, XrefRangeStart = 40782, XrefRangeEnd = 40796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40801, RefRangeEnd = 40802, XrefRangeStart = 40797, XrefRangeEnd = 40801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool disableCheckDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_disableCheckDrag_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40821, RefRangeEnd = 40822, XrefRangeStart = 40802, XrefRangeEnd = 40821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool disableClickMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_disableClickMove_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public GamePad(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
