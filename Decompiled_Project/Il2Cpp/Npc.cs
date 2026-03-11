using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2Cpp;

public class Npc : Char
{
	private static readonly IntPtr NativeFieldInfoPtr_BINH_KHI;

	private static readonly IntPtr NativeFieldInfoPtr_PHONG_CU;

	private static readonly IntPtr NativeFieldInfoPtr_TRANG_SUC;

	private static readonly IntPtr NativeFieldInfoPtr_DUOC_PHAM;

	private static readonly IntPtr NativeFieldInfoPtr_TAP_HOA;

	private static readonly IntPtr NativeFieldInfoPtr_THU_KHO;

	private static readonly IntPtr NativeFieldInfoPtr_DA_LUYEN;

	private static readonly IntPtr NativeFieldInfoPtr_template;

	private static readonly IntPtr NativeFieldInfoPtr_npcId;

	private static readonly IntPtr NativeFieldInfoPtr_isFocus;

	private static readonly IntPtr NativeFieldInfoPtr_arrNpcTemplate;

	private static readonly IntPtr NativeFieldInfoPtr_sys;

	private static readonly IntPtr NativeFieldInfoPtr_isHide;

	private static readonly IntPtr NativeFieldInfoPtr_duaHauIndex;

	private static readonly IntPtr NativeFieldInfoPtr_dyEff;

	private static readonly IntPtr NativeFieldInfoPtr_mabuEff;

	private static readonly IntPtr NativeFieldInfoPtr_tMabuEff;

	private static readonly IntPtr NativeFieldInfoPtr_shock_x;

	private static readonly IntPtr NativeFieldInfoPtr_shock_y;

	private static readonly IntPtr NativeFieldInfoPtr_shock_scr;

	private static readonly IntPtr NativeFieldInfoPtr_duahau;

	private static readonly IntPtr NativeFieldInfoPtr_seconds;

	private static readonly IntPtr NativeFieldInfoPtr_last;

	private static readonly IntPtr NativeFieldInfoPtr_cur;

	private static readonly IntPtr NativeFieldInfoPtr_idItem;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_setStatus_Public_Void_SByte_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_clearEffTask_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_update_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_paintHead_Public_Void_mGraphics_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0;

	private static readonly IntPtr NativeMethodInfoPtr_paintName_Public_Void_mGraphics_0;

	private static readonly IntPtr NativeMethodInfoPtr_hide_Public_Void_0;

	public unsafe static sbyte BINH_KHI
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BINH_KHI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BINH_KHI, (void*)(&b));
		}
	}

	public unsafe static sbyte PHONG_CU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHONG_CU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHONG_CU, (void*)(&b));
		}
	}

	public unsafe static sbyte TRANG_SUC
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANG_SUC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANG_SUC, (void*)(&b));
		}
	}

	public unsafe static sbyte DUOC_PHAM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DUOC_PHAM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DUOC_PHAM, (void*)(&b));
		}
	}

	public unsafe static sbyte TAP_HOA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TAP_HOA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TAP_HOA, (void*)(&b));
		}
	}

	public unsafe static sbyte THU_KHO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THU_KHO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THU_KHO, (void*)(&b));
		}
	}

	public unsafe static sbyte DA_LUYEN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DA_LUYEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DA_LUYEN, (void*)(&b));
		}
	}

	public unsafe NpcTemplate template
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcTemplate>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npcTemplate));
		}
	}

	public unsafe int npcId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcId)) = num;
		}
	}

	public unsafe bool isFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFocus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFocus)) = flag;
		}
	}

	public unsafe static Il2CppReferenceArray<NpcTemplate> arrNpcTemplate
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrNpcTemplate, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NpcTemplate>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrNpcTemplate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int sys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sys);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sys)) = num;
		}
	}

	public new unsafe bool isHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHide)) = flag;
		}
	}

	public unsafe int duaHauIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duaHauIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duaHauIndex)) = num;
		}
	}

	public unsafe int dyEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyEff);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyEff)) = num;
		}
	}

	public unsafe static bool mabuEff
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mabuEff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mabuEff, (void*)(&flag));
		}
	}

	public unsafe static int tMabuEff
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tMabuEff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tMabuEff, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> shock_x
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shock_x, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shock_x, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> shock_y
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shock_y, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shock_y, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int shock_scr
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shock_scr, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shock_scr, (void*)(&num));
		}
	}

	public unsafe Il2CppStructArray<int> duahau
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duahau);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_duahau)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public new unsafe int seconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seconds);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seconds)) = num;
		}
	}

	public new unsafe long last
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last)) = num;
		}
	}

	public new unsafe long cur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cur);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cur)) = num;
		}
	}

	public unsafe int idItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idItem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idItem)) = num;
		}
	}

	static Npc()
	{
		Il2CppClassPointerStore<Npc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Npc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Npc>.NativeClassPtr);
		NativeFieldInfoPtr_BINH_KHI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "BINH_KHI");
		NativeFieldInfoPtr_PHONG_CU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "PHONG_CU");
		NativeFieldInfoPtr_TRANG_SUC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "TRANG_SUC");
		NativeFieldInfoPtr_DUOC_PHAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "DUOC_PHAM");
		NativeFieldInfoPtr_TAP_HOA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "TAP_HOA");
		NativeFieldInfoPtr_THU_KHO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "THU_KHO");
		NativeFieldInfoPtr_DA_LUYEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "DA_LUYEN");
		NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "template");
		NativeFieldInfoPtr_npcId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "npcId");
		NativeFieldInfoPtr_isFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "isFocus");
		NativeFieldInfoPtr_arrNpcTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "arrNpcTemplate");
		NativeFieldInfoPtr_sys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "sys");
		NativeFieldInfoPtr_isHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "isHide");
		NativeFieldInfoPtr_duaHauIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "duaHauIndex");
		NativeFieldInfoPtr_dyEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "dyEff");
		NativeFieldInfoPtr_mabuEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "mabuEff");
		NativeFieldInfoPtr_tMabuEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "tMabuEff");
		NativeFieldInfoPtr_shock_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "shock_x");
		NativeFieldInfoPtr_shock_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "shock_y");
		NativeFieldInfoPtr_shock_scr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "shock_scr");
		NativeFieldInfoPtr_duahau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "duahau");
		NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "seconds");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "last");
		NativeFieldInfoPtr_cur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "cur");
		NativeFieldInfoPtr_idItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Npc>.NativeClassPtr, "idItem");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665287);
		NativeMethodInfoPtr_setStatus_Public_Void_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665288);
		NativeMethodInfoPtr_clearEffTask_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665289);
		NativeMethodInfoPtr_update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665290);
		NativeMethodInfoPtr_paintHead_Public_Void_mGraphics_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665291);
		NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665292);
		NativeMethodInfoPtr_paintName_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665293);
		NativeMethodInfoPtr_hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Npc>.NativeClassPtr, 100665294);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 69311, RefRangeEnd = 69321, XrefRangeStart = 69294, XrefRangeEnd = 69311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Npc(int npcId, int status, int cx, int cy, int templateId, int avatar)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Npc>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = (nint)(&npcId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &status;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &cx;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &cy;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &templateId;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &avatar;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69325, RefRangeEnd = 69326, XrefRangeStart = 69321, XrefRangeEnd = 69325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setStatus(sbyte s, int sc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &sc;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setStatus_Public_Void_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 69338, RefRangeEnd = 69342, XrefRangeStart = 69326, XrefRangeEnd = 69338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearEffTask()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearEffTask_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69410, RefRangeEnd = 69411, XrefRangeStart = 69342, XrefRangeEnd = 69410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69411, XrefRangeEnd = 69429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintHead(mGraphics g, int xStart, int yStart)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &xStart;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &yStart;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintHead_Public_Void_mGraphics_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69429, XrefRangeEnd = 69655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69695, RefRangeEnd = 69696, XrefRangeStart = 69655, XrefRangeEnd = 69695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void paintName(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintName_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69696, XrefRangeEnd = 69702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Npc(IntPtr pointer)
		: base(pointer)
	{
	}
}
