using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Numerics;

namespace Il2Cpp;

public static class BigIntIO : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ReadBigInt_Public_Static_BigInteger_myReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteBigInt_Public_Static_Void_myWriter_BigInteger_0;

	static BigIntIO()
	{
		Il2CppClassPointerStore<BigIntIO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BigIntIO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigIntIO>.NativeClassPtr);
		NativeMethodInfoPtr_ReadBigInt_Public_Static_BigInteger_myReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntIO>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_WriteBigInt_Public_Static_Void_myWriter_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigIntIO>.NativeClassPtr, 100663493);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 8205, RefRangeEnd = 8212, XrefRangeStart = 8195, XrefRangeEnd = 8205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BigInteger ReadBigInt(myReader r)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)r);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadBigInt_Public_Static_BigInteger_myReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 8226, RefRangeEnd = 8230, XrefRangeStart = 8212, XrefRangeEnd = 8226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteBigInt(myWriter w, BigInteger value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)w);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteBigInt_Public_Static_Void_myWriter_BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BigIntIO(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
