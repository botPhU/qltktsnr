using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Numerics;

namespace Il2Cpp;

public class ECCAuth : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__cryptoEngine;

	private static readonly System.IntPtr NativeFieldInfoPtr__serverChallenge;

	private static readonly System.IntPtr NativeFieldInfoPtr__fieldValidator;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildValidationString_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeResponse_Public_ValueTuple_2_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRandomScalar_Private_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SimpleECC _cryptoEngine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cryptoEngine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SimpleECC>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cryptoEngine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)simpleECC));
		}
	}

	public unsafe SimpleECC.Point _serverChallenge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverChallenge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SimpleECC.Point>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__serverChallenge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point));
		}
	}

	public unsafe string _fieldValidator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fieldValidator);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fieldValidator)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static ECCAuth()
	{
		Il2CppClassPointerStore<ECCAuth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ECCAuth");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr);
		NativeFieldInfoPtr__cryptoEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, "_cryptoEngine");
		NativeFieldInfoPtr__serverChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, "_serverChallenge");
		NativeFieldInfoPtr__fieldValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, "_fieldValidator");
		NativeMethodInfoPtr_BuildValidationString_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_Init_Public_Void_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_ComputeResponse_Public_ValueTuple_2_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, 100663861);
		NativeMethodInfoPtr_GenerateRandomScalar_Private_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr, 100663863);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32108, XrefRangeEnd = 32115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string BuildValidationString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildValidationString_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32134, RefRangeEnd = 32135, XrefRangeStart = 32115, XrefRangeEnd = 32134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(BigInteger p, BigInteger a, BigInteger b, BigInteger gx, BigInteger gy, BigInteger cx, BigInteger cy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)p));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gx));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gy));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cx));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cy));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32141, RefRangeEnd = 32142, XrefRangeStart = 32135, XrefRangeEnd = 32141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<SimpleECC.Point, SimpleECC.Point> ComputeResponse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeResponse_Public_ValueTuple_2_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<SimpleECC.Point, SimpleECC.Point>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32172, RefRangeEnd = 32173, XrefRangeStart = 32142, XrefRangeEnd = 32172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger GenerateRandomScalar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateRandomScalar_Private_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32173, XrefRangeEnd = 32190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ECCAuth()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ECCAuth>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ECCAuth(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
