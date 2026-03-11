using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat;

public class AdaptiveNoiseGate : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_threshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_sampleRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_releaseTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentGain;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetGain;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSamples_Public_Void_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetThreshold_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAttackTime_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReleaseTime_Public_Void_Single_0;

	public unsafe float threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threshold)) = num;
		}
	}

	public unsafe float sampleRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleRate)) = num;
		}
	}

	public unsafe float attackTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackTime)) = num;
		}
	}

	public unsafe float releaseTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releaseTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_releaseTime)) = num;
		}
	}

	public unsafe float currentGain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGain);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGain)) = num;
		}
	}

	public unsafe float targetGain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetGain);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetGain)) = num;
		}
	}

	static AdaptiveNoiseGate()
	{
		Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat", "AdaptiveNoiseGate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr);
		NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, "threshold");
		NativeFieldInfoPtr_sampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, "sampleRate");
		NativeFieldInfoPtr_attackTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, "attackTime");
		NativeFieldInfoPtr_releaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, "releaseTime");
		NativeFieldInfoPtr_currentGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, "currentGain");
		NativeFieldInfoPtr_targetGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, "targetGain");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, 100666821);
		NativeMethodInfoPtr_ProcessSamples_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, 100666822);
		NativeMethodInfoPtr_SetThreshold_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, 100666823);
		NativeMethodInfoPtr_SetAttackTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, 100666824);
		NativeMethodInfoPtr_SetReleaseTime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr, 100666825);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 122060, RefRangeEnd = 122065, XrefRangeStart = 122059, XrefRangeEnd = 122060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdaptiveNoiseGate(float threshold, float sampleRate)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdaptiveNoiseGate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&threshold);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 122068, RefRangeEnd = 122070, XrefRangeStart = 122065, XrefRangeEnd = 122068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessSamples(Il2CppStructArray<float> samples)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)samples);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessSamples_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetThreshold(float newThreshold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newThreshold);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetThreshold_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetAttackTime(float attackTimeMs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&attackTimeMs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAttackTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetReleaseTime(float releaseTimeMs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&releaseTimeMs);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReleaseTime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AdaptiveNoiseGate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
