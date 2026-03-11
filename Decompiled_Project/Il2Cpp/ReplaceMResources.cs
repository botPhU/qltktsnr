using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2Cpp;

public class ReplaceMResources : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_ReplaceAllMResources_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ReplaceMResources()
	{
		Il2CppClassPointerStore<ReplaceMResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ReplaceMResources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceMResources>.NativeClassPtr);
		NativeMethodInfoPtr_ReplaceAllMResources_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMResources>.NativeClassPtr, 100665715);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMResources>.NativeClassPtr, 100665716);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84094, XrefRangeEnd = 84149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplaceAllMResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceAllMResources_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 56616, RefRangeEnd = 56631, XrefRangeStart = 56616, XrefRangeEnd = 56631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReplaceMResources()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceMResources>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ReplaceMResources(IntPtr pointer)
		: base(pointer)
	{
	}
}
