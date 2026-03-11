using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class MobCapcha : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_imgMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmxLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_explode;

	private static readonly System.IntPtr NativeFieldInfoPtr_delay;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCreateMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_tF;

	private static readonly System.IntPtr NativeFieldInfoPtr_f;

	private static readonly System.IntPtr NativeFieldInfoPtr_dir;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAttack;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveCamera_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Image imgMob
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMob, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMob, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int cmtoY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmtoY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmtoY, (void*)(&num));
		}
	}

	public unsafe static int cmy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmy, (void*)(&num));
		}
	}

	public unsafe static int cmdy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdy, (void*)(&num));
		}
	}

	public unsafe static int cmvy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmvy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmvy, (void*)(&num));
		}
	}

	public unsafe static int cmyLim
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmyLim, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmyLim, (void*)(&num));
		}
	}

	public unsafe static int cmtoX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmtoX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmtoX, (void*)(&num));
		}
	}

	public unsafe static int cmx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmx, (void*)(&num));
		}
	}

	public unsafe static int cmdx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdx, (void*)(&num));
		}
	}

	public unsafe static int cmvx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmvx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmvx, (void*)(&num));
		}
	}

	public unsafe static int cmxLim
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmxLim, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmxLim, (void*)(&num));
		}
	}

	public unsafe static bool explode
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_explode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_explode, (void*)(&flag));
		}
	}

	public unsafe static int delay
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_delay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_delay, (void*)(&num));
		}
	}

	public unsafe static bool isCreateMob
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isCreateMob, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isCreateMob, (void*)(&flag));
		}
	}

	public unsafe static int tF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tF, (void*)(&num));
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

	public unsafe static int dir
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dir, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dir, (void*)(&num));
		}
	}

	public unsafe static bool isAttack
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAttack, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAttack, (void*)(&flag));
		}
	}

	static MobCapcha()
	{
		Il2CppClassPointerStore<MobCapcha>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MobCapcha");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr);
		NativeFieldInfoPtr_imgMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "imgMob");
		NativeFieldInfoPtr_cmtoY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmtoY");
		NativeFieldInfoPtr_cmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmy");
		NativeFieldInfoPtr_cmdy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmdy");
		NativeFieldInfoPtr_cmvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmvy");
		NativeFieldInfoPtr_cmyLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmyLim");
		NativeFieldInfoPtr_cmtoX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmtoX");
		NativeFieldInfoPtr_cmx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmx");
		NativeFieldInfoPtr_cmdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmdx");
		NativeFieldInfoPtr_cmvx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmvx");
		NativeFieldInfoPtr_cmxLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "cmxLim");
		NativeFieldInfoPtr_explode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "explode");
		NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "delay");
		NativeFieldInfoPtr_isCreateMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "isCreateMob");
		NativeFieldInfoPtr_tF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "tF");
		NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "f");
		NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "dir");
		NativeFieldInfoPtr_isAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, "isAttack");
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, 100664886);
		NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, 100664887);
		NativeMethodInfoPtr_moveCamera_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, 100664888);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr, 100664889);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61785, RefRangeEnd = 61786, XrefRangeStart = 61775, XrefRangeEnd = 61785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61897, RefRangeEnd = 61898, XrefRangeStart = 61786, XrefRangeEnd = 61897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paint(mGraphics g, int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61898, XrefRangeEnd = 61911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void moveCamera()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveCamera_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobCapcha()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobCapcha>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MobCapcha(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
