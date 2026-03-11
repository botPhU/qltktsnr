using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

[System.Serializable]
public class MultiLayerResponse : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_challengeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_vrfResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_commitmentResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_eccResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_pairingResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_zkResponse;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalProcessingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerTimings;

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

	public unsafe long totalProcessingTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalProcessingTime);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalProcessingTime)) = num;
		}
	}

	public unsafe Dictionary<string, long> layerTimings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerTimings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, long>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerTimings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	static MultiLayerResponse()
	{
		Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MultiLayerResponse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr);
		NativeFieldInfoPtr_challengeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "challengeId");
		NativeFieldInfoPtr_vrfResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "vrfResponse");
		NativeFieldInfoPtr_commitmentResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "commitmentResponse");
		NativeFieldInfoPtr_eccResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "eccResponse");
		NativeFieldInfoPtr_pairingResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "pairingResponse");
		NativeFieldInfoPtr_zkResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "zkResponse");
		NativeFieldInfoPtr_totalProcessingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "totalProcessingTime");
		NativeFieldInfoPtr_layerTimings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, "layerTimings");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr, 100665054);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MultiLayerResponse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiLayerResponse>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MultiLayerResponse(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
