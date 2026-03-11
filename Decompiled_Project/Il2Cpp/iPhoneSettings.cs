using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class iPhoneSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_generation;

	private static readonly System.IntPtr NativeFieldInfoPtr_iPhone;

	private static readonly System.IntPtr NativeFieldInfoPtr_iPhone3G;

	private static readonly System.IntPtr NativeFieldInfoPtr_iPodTouch1Gen;

	private static readonly System.IntPtr NativeFieldInfoPtr_iPodTouch2Gen;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static iPhoneGeneration generation
	{
		get
		{
			Unsafe.SkipInit(out iPhoneGeneration result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_generation, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_generation, (void*)(&iPhoneGeneration2));
		}
	}

	public unsafe static iPhoneGeneration iPhone
	{
		get
		{
			Unsafe.SkipInit(out iPhoneGeneration result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iPhone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iPhone, (void*)(&iPhoneGeneration2));
		}
	}

	public unsafe static iPhoneGeneration iPhone3G
	{
		get
		{
			Unsafe.SkipInit(out iPhoneGeneration result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iPhone3G, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iPhone3G, (void*)(&iPhoneGeneration2));
		}
	}

	public unsafe static iPhoneGeneration iPodTouch1Gen
	{
		get
		{
			Unsafe.SkipInit(out iPhoneGeneration result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iPodTouch1Gen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iPodTouch1Gen, (void*)(&iPhoneGeneration2));
		}
	}

	public unsafe static iPhoneGeneration iPodTouch2Gen
	{
		get
		{
			Unsafe.SkipInit(out iPhoneGeneration result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iPodTouch2Gen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iPodTouch2Gen, (void*)(&iPhoneGeneration2));
		}
	}

	static iPhoneSettings()
	{
		Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "iPhoneSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr);
		NativeFieldInfoPtr_generation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr, "generation");
		NativeFieldInfoPtr_iPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr, "iPhone");
		NativeFieldInfoPtr_iPhone3G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr, "iPhone3G");
		NativeFieldInfoPtr_iPodTouch1Gen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr, "iPodTouch1Gen");
		NativeFieldInfoPtr_iPodTouch2Gen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr, "iPodTouch2Gen");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr, 100664538);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe iPhoneSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<iPhoneSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public iPhoneSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
