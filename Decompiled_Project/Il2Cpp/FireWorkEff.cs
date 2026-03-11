using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class FireWorkEff : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_mg;

	private static readonly System.IntPtr NativeFieldInfoPtr_f;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_ag;

	private static readonly System.IntPtr NativeFieldInfoPtr_x0;

	private static readonly System.IntPtr NativeFieldInfoPtr_y0;

	private static readonly System.IntPtr NativeFieldInfoPtr_t;

	private static readonly System.IntPtr NativeFieldInfoPtr_v;

	private static readonly System.IntPtr NativeFieldInfoPtr_ymax;

	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_mang_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_mang_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_st;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeFieldInfoPtr_delay;

	private static readonly System.IntPtr NativeMethodInfoPtr_preDraw_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyPressed_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_animate_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_time_Public_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe static MyVector mg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mg, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mg, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
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

	public unsafe static int ag
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ag, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ag, (void*)(&num));
		}
	}

	public unsafe static int x0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_x0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_x0, (void*)(&num));
		}
	}

	public unsafe static int y0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_y0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_y0, (void*)(&num));
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

	public unsafe static int v
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_v, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_v, (void*)(&num));
		}
	}

	public unsafe static int ymax
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ymax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ymax, (void*)(&num));
		}
	}

	public unsafe static float a
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_a, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_a, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> mang_x
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mang_x, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mang_x, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> mang_y
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mang_y, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mang_y, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool st
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_st, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_st, (void*)(&flag));
		}
	}

	public unsafe static long last
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_last, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_last, (void*)(&num));
		}
	}

	public unsafe static long delay
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_delay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_delay, (void*)(&num));
		}
	}

	static FireWorkEff()
	{
		Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FireWorkEff");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr);
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "w");
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "h");
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "r");
		NativeFieldInfoPtr_mg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "mg");
		NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "f");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "y");
		NativeFieldInfoPtr_ag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "ag");
		NativeFieldInfoPtr_x0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "x0");
		NativeFieldInfoPtr_y0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "y0");
		NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "t");
		NativeFieldInfoPtr_v = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "v");
		NativeFieldInfoPtr_ymax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "ymax");
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "a");
		NativeFieldInfoPtr_mang_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "mang_x");
		NativeFieldInfoPtr_mang_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "mang_y");
		NativeFieldInfoPtr_st = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "st");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "last");
		NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, "delay");
		NativeMethodInfoPtr_preDraw_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_keyPressed_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_add_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, 100663999);
		NativeMethodInfoPtr_animate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_time_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr, 100664002);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34469, RefRangeEnd = 34470, XrefRangeStart = 34438, XrefRangeEnd = 34469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void preDraw()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_preDraw_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34526, RefRangeEnd = 34527, XrefRangeStart = 34470, XrefRangeEnd = 34526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paint(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34527, XrefRangeEnd = 34550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void keyPressed(int k)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&k);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keyPressed_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 34564, RefRangeEnd = 34566, XrefRangeStart = 34550, XrefRangeEnd = 34564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34596, RefRangeEnd = 34597, XrefRangeStart = 34566, XrefRangeEnd = 34596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void animate()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_animate_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34597, XrefRangeEnd = 34601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long time()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_time_Public_Static_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FireWorkEff()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireWorkEff>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FireWorkEff(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
