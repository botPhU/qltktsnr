using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Numerics;

namespace Il2Cpp;

[System.Serializable]
public class PairingResponse : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pairingResult;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PairingResult_Public_get_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string pairingResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingResult);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingResult)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe BigInteger PairingResult
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64959, XrefRangeEnd = 64963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PairingResult_Public_get_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new BigInteger(pointer);
		}
	}

	static PairingResponse()
	{
		Il2CppClassPointerStore<PairingResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PairingResponse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PairingResponse>.NativeClassPtr);
		NativeFieldInfoPtr_pairingResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PairingResponse>.NativeClassPtr, "pairingResult");
		NativeMethodInfoPtr_get_PairingResult_Public_get_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PairingResponse>.NativeClassPtr, 100665089);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PairingResponse>.NativeClassPtr, 100665090);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PairingResponse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PairingResponse>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PairingResponse(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
