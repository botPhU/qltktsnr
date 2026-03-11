using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2Cpp;

public class T2 : mResources
{
	private static readonly IntPtr NativeMethodInfoPtr_load_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static T2()
	{
		Il2CppClassPointerStore<T2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "T2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<T2>.NativeClassPtr);
		NativeMethodInfoPtr_load_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<T2>.NativeClassPtr, 100666316);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<T2>.NativeClassPtr, 100666317);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 105152, RefRangeEnd = 105153, XrefRangeStart = 102026, XrefRangeEnd = 105152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void load()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_load_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105153, XrefRangeEnd = 105157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T2()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<T2>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public T2(IntPtr pointer)
		: base(pointer)
	{
	}
}
