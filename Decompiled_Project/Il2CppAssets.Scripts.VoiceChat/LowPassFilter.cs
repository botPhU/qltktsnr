using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat;

public class LowPassFilter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cutoffFrequency;

	private static readonly System.IntPtr NativeFieldInfoPtr_sampleRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_x1;

	private static readonly System.IntPtr NativeFieldInfoPtr_x2;

	private static readonly System.IntPtr NativeFieldInfoPtr_y1;

	private static readonly System.IntPtr NativeFieldInfoPtr_y2;

	private static readonly System.IntPtr NativeFieldInfoPtr_a0;

	private static readonly System.IntPtr NativeFieldInfoPtr_a1;

	private static readonly System.IntPtr NativeFieldInfoPtr_a2;

	private static readonly System.IntPtr NativeFieldInfoPtr_b1;

	private static readonly System.IntPtr NativeFieldInfoPtr_b2;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateCoefficients_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSamples_Public_Void_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCutoffFrequency_Public_Void_Single_0;

	public unsafe float cutoffFrequency
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutoffFrequency);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cutoffFrequency)) = num;
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

	public unsafe float x1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x1)) = num;
		}
	}

	public unsafe float x2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x2)) = num;
		}
	}

	public unsafe float y1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y1)) = num;
		}
	}

	public unsafe float y2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y2)) = num;
		}
	}

	public unsafe float a0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a0);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a0)) = num;
		}
	}

	public unsafe float a1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a1)) = num;
		}
	}

	public unsafe float a2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a2)) = num;
		}
	}

	public unsafe float b1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b1);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b1)) = num;
		}
	}

	public unsafe float b2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b2)) = num;
		}
	}

	static LowPassFilter()
	{
		Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat", "LowPassFilter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr);
		NativeFieldInfoPtr_cutoffFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "cutoffFrequency");
		NativeFieldInfoPtr_sampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "sampleRate");
		NativeFieldInfoPtr_x1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "x1");
		NativeFieldInfoPtr_x2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "x2");
		NativeFieldInfoPtr_y1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "y1");
		NativeFieldInfoPtr_y2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "y2");
		NativeFieldInfoPtr_a0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "a0");
		NativeFieldInfoPtr_a1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "a1");
		NativeFieldInfoPtr_a2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "a2");
		NativeFieldInfoPtr_b1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "b1");
		NativeFieldInfoPtr_b2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, "b2");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, 100666837);
		NativeMethodInfoPtr_CalculateCoefficients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, 100666838);
		NativeMethodInfoPtr_ProcessSamples_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, 100666839);
		NativeMethodInfoPtr_SetCutoffFrequency_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr, 100666840);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 122159, RefRangeEnd = 122164, XrefRangeStart = 122157, XrefRangeEnd = 122159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LowPassFilter(float cutoffFrequency, float sampleRate)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowPassFilter>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cutoffFrequency);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleRate;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 122166, RefRangeEnd = 122169, XrefRangeStart = 122164, XrefRangeEnd = 122166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateCoefficients()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateCoefficients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 122152, RefRangeEnd = 122156, XrefRangeStart = 122152, XrefRangeEnd = 122156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122169, XrefRangeEnd = 122170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCutoffFrequency(float newCutoff)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newCutoff);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCutoffFrequency_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public LowPassFilter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
