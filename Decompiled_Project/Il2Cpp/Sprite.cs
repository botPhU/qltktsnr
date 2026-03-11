using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class Sprite : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_MIRROR;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_MIRROR_ROT180;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_MIRROR_ROT270;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_MIRROR_ROT90;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_NONE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_ROT180;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_ROT270;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANS_ROT90;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int TRANS_MIRROR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_MIRROR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_MIRROR, (void*)(&num));
		}
	}

	public unsafe static int TRANS_MIRROR_ROT180
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_MIRROR_ROT180, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_MIRROR_ROT180, (void*)(&num));
		}
	}

	public unsafe static int TRANS_MIRROR_ROT270
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_MIRROR_ROT270, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_MIRROR_ROT270, (void*)(&num));
		}
	}

	public unsafe static int TRANS_MIRROR_ROT90
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_MIRROR_ROT90, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_MIRROR_ROT90, (void*)(&num));
		}
	}

	public unsafe static int TRANS_NONE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_NONE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_NONE, (void*)(&num));
		}
	}

	public unsafe static int TRANS_ROT180
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_ROT180, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_ROT180, (void*)(&num));
		}
	}

	public unsafe static int TRANS_ROT270
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_ROT270, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_ROT270, (void*)(&num));
		}
	}

	public unsafe static int TRANS_ROT90
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANS_ROT90, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANS_ROT90, (void*)(&num));
		}
	}

	static Sprite()
	{
		Il2CppClassPointerStore<Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Sprite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprite>.NativeClassPtr);
		NativeFieldInfoPtr_TRANS_MIRROR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_MIRROR");
		NativeFieldInfoPtr_TRANS_MIRROR_ROT180 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_MIRROR_ROT180");
		NativeFieldInfoPtr_TRANS_MIRROR_ROT270 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_MIRROR_ROT270");
		NativeFieldInfoPtr_TRANS_MIRROR_ROT90 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_MIRROR_ROT90");
		NativeFieldInfoPtr_TRANS_NONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_NONE");
		NativeFieldInfoPtr_TRANS_ROT180 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_ROT180");
		NativeFieldInfoPtr_TRANS_ROT270 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_ROT270");
		NativeFieldInfoPtr_TRANS_ROT90 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprite>.NativeClassPtr, "TRANS_ROT90");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100666311);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprite>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Sprite(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
