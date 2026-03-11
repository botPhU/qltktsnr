using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class Hint : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_t;

	private static readonly System.IntPtr NativeFieldInfoPtr_xF;

	private static readonly System.IntPtr NativeFieldInfoPtr_yF;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShow;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_isViewMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCloseMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_isViewPotential;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_trans;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintFlare;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_s;

	private static readonly System.IntPtr NativeMethodInfoPtr_isOnTask_Public_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPaintz_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clickNpc_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_nextMap_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clickMob_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHaveItem_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintArrowPointToHint_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hint_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int x
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_x, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_x, (void*)(&num));
		}
	}

	public unsafe static int y
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_y, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_y, (void*)(&num));
		}
	}

	public unsafe static int type
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_type, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_type, (void*)(&num));
		}
	}

	public unsafe static int t
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_t, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_t, (void*)(&num));
		}
	}

	public unsafe static int xF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xF, (void*)(&num));
		}
	}

	public unsafe static int yF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yF, (void*)(&num));
		}
	}

	public unsafe static bool isShow
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isShow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isShow, (void*)(&flag));
		}
	}

	public unsafe static bool activeClick
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeClick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeClick, (void*)(&flag));
		}
	}

	public unsafe static bool isViewMap
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isViewMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isViewMap, (void*)(&flag));
		}
	}

	public unsafe static bool isCloseMap
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isCloseMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isCloseMap, (void*)(&flag));
		}
	}

	public unsafe static bool isViewPotential
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isViewPotential, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isViewPotential, (void*)(&flag));
		}
	}

	public unsafe static bool isPaint
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaint, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaint, (void*)(&flag));
		}
	}

	public unsafe static bool isCamera
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isCamera, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isCamera, (void*)(&flag));
		}
	}

	public unsafe static int trans
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trans, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trans, (void*)(&num));
		}
	}

	public unsafe static bool paintFlare
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_paintFlare, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_paintFlare, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintArrow
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintArrow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintArrow, (void*)(&flag));
		}
	}

	public unsafe int s
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s)) = num;
		}
	}

	static Hint()
	{
		Il2CppClassPointerStore<Hint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Hint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hint>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "y");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "type");
		NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "t");
		NativeFieldInfoPtr_xF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "xF");
		NativeFieldInfoPtr_yF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "yF");
		NativeFieldInfoPtr_isShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "isShow");
		NativeFieldInfoPtr_activeClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "activeClick");
		NativeFieldInfoPtr_isViewMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "isViewMap");
		NativeFieldInfoPtr_isCloseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "isCloseMap");
		NativeFieldInfoPtr_isViewPotential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "isViewPotential");
		NativeFieldInfoPtr_isPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "isPaint");
		NativeFieldInfoPtr_isCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "isCamera");
		NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "trans");
		NativeFieldInfoPtr_paintFlare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "paintFlare");
		NativeFieldInfoPtr_isPaintArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "isPaintArrow");
		NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hint>.NativeClassPtr, "s");
		NativeMethodInfoPtr_isOnTask_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664350);
		NativeMethodInfoPtr_isPaintz_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664351);
		NativeMethodInfoPtr_clickNpc_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664352);
		NativeMethodInfoPtr_nextMap_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664353);
		NativeMethodInfoPtr_clickMob_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664354);
		NativeMethodInfoPtr_isHaveItem_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664355);
		NativeMethodInfoPtr_paintArrowPointToHint_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664356);
		NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664357);
		NativeMethodInfoPtr_hint_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664358);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664359);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100664360);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 51186, RefRangeEnd = 51190, XrefRangeStart = 51176, XrefRangeEnd = 51186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isOnTask(int tastId, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tastId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isOnTask_Public_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51190, XrefRangeEnd = 51205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPaintz()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPaintz_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 51227, RefRangeEnd = 51230, XrefRangeStart = 51205, XrefRangeEnd = 51227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clickNpc()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clickNpc_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51230, XrefRangeEnd = 51257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void nextMap(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_nextMap_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51286, RefRangeEnd = 51287, XrefRangeStart = 51257, XrefRangeEnd = 51286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clickMob()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clickMob_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51287, XrefRangeEnd = 51313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isHaveItem()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHaveItem_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51426, RefRangeEnd = 51427, XrefRangeStart = 51313, XrefRangeEnd = 51426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintArrowPointToHint(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintArrowPointToHint_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51492, RefRangeEnd = 51493, XrefRangeStart = 51427, XrefRangeEnd = 51492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paint(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51544, RefRangeEnd = 51545, XrefRangeStart = 51493, XrefRangeEnd = 51544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void hint()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hint_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51592, RefRangeEnd = 51593, XrefRangeStart = 51545, XrefRangeEnd = 51592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51593, XrefRangeEnd = 51594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hint>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Hint(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
