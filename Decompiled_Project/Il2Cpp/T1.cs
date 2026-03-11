using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2Cpp;

public class T1 : mResources
{
	private static readonly IntPtr NativeMethodInfoPtr_load_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static T1()
	{
		Il2CppClassPointerStore<T1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "T1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<T1>.NativeClassPtr);
		NativeMethodInfoPtr_load_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<T1>.NativeClassPtr, 100666314);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<T1>.NativeClassPtr, 100666315);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 102021, RefRangeEnd = 102022, XrefRangeStart = 98848, XrefRangeEnd = 102021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void load()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_load_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102022, XrefRangeEnd = 102026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T1()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<T1>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public T1(IntPtr pointer)
		: base(pointer)
	{
	}
}
