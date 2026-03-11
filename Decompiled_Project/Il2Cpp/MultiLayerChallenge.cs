using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[System.Serializable]
public class MultiLayerChallenge : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_challengeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_timestamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_vrfChallenge;

	private static readonly System.IntPtr NativeFieldInfoPtr_commitmentChallenge;

	private static readonly System.IntPtr NativeFieldInfoPtr_eccChallenge;

	private static readonly System.IntPtr NativeFieldInfoPtr_pairingChallenge;

	private static readonly System.IntPtr NativeFieldInfoPtr_zkChallenge;

	private static readonly System.IntPtr NativeFieldInfoPtr_vrfResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_commitmentResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_eccResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_pairingResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_zkResponse;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string challengeId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_challengeId);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_challengeId)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe long timestamp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timestamp);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timestamp)) = num;
		}
	}

	public unsafe VRFChallenge vrfChallenge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vrfChallenge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VRFChallenge>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vrfChallenge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vRFChallenge));
		}
	}

	public unsafe CommitmentChallenge commitmentChallenge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commitmentChallenge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommitmentChallenge>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commitmentChallenge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commitmentChallenge));
		}
	}

	public unsafe ECCChallenge eccChallenge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eccChallenge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ECCChallenge>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eccChallenge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eCCChallenge));
		}
	}

	public unsafe PairingChallenge pairingChallenge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingChallenge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PairingChallenge>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingChallenge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairingChallenge));
		}
	}

	public unsafe ZKChallenge zkChallenge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zkChallenge);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ZKChallenge>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zkChallenge)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zKChallenge));
		}
	}

	public unsafe VRFResponse vrfResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vrfResponse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VRFResponse>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vrfResponse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vRFResponse));
		}
	}

	public unsafe CommitmentResponse commitmentResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commitmentResponse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CommitmentResponse>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commitmentResponse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)commitmentResponse));
		}
	}

	public unsafe ECCResponse eccResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eccResponse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ECCResponse>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eccResponse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eCCResponse));
		}
	}

	public unsafe PairingResponse pairingResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingResponse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PairingResponse>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pairingResponse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pairingResponse));
		}
	}

	public unsafe ZKResponse zkResponse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zkResponse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ZKResponse>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zkResponse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)zKResponse));
		}
	}

	static MultiLayerChallenge()
	{
		Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MultiLayerChallenge");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr);
		NativeFieldInfoPtr_challengeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "challengeId");
		NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "timestamp");
		NativeFieldInfoPtr_vrfChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "vrfChallenge");
		NativeFieldInfoPtr_commitmentChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "commitmentChallenge");
		NativeFieldInfoPtr_eccChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "eccChallenge");
		NativeFieldInfoPtr_pairingChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "pairingChallenge");
		NativeFieldInfoPtr_zkChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "zkChallenge");
		NativeFieldInfoPtr_vrfResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "vrfResponse");
		NativeFieldInfoPtr_commitmentResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "commitmentResponse");
		NativeFieldInfoPtr_eccResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "eccResponse");
		NativeFieldInfoPtr_pairingResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "pairingResponse");
		NativeFieldInfoPtr_zkResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, "zkResponse");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr, 100665053);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultiLayerChallenge()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiLayerChallenge>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MultiLayerChallenge(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
