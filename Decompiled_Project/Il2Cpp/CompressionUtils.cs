using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public static class CompressionUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Decompress_Public_Static_Il2CppStructArray_1_SByte_Il2CppStructArray_1_SByte_0;

	static CompressionUtils()
	{
		Il2CppClassPointerStore<CompressionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CompressionUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompressionUtils>.NativeClassPtr);
		NativeMethodInfoPtr_Decompress_Public_Static_Il2CppStructArray_1_SByte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompressionUtils>.NativeClassPtr, 100663752);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17511, XrefRangeEnd = 17539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> Decompress(Il2CppStructArray<sbyte> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decompress_Public_Static_Il2CppStructArray_1_SByte_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	public CompressionUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
