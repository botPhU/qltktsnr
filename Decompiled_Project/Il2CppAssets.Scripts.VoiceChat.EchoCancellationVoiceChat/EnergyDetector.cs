using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

public class EnergyDetector : BaseDetector
{
	private static readonly IntPtr NativeMethodInfoPtr_Detect_Public_Virtual_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateEnergyRatio_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static EnergyDetector()
	{
		Il2CppClassPointerStore<EnergyDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EnergyDetector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnergyDetector>.NativeClassPtr);
		NativeMethodInfoPtr_Detect_Public_Virtual_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyDetector>.NativeClassPtr, 100667024);
		NativeMethodInfoPtr_CalculateEnergyRatio_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyDetector>.NativeClassPtr, 100667025);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyDetector>.NativeClassPtr, 100667026);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125164, XrefRangeEnd = 125172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override DetectionResult Detect(Il2CppStructArray<float> input1, Il2CppStructArray<float> input2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input1);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input2);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Detect_Public_Virtual_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DetectionResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125181, RefRangeEnd = 125182, XrefRangeStart = 125172, XrefRangeEnd = 125181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateEnergyRatio(Il2CppStructArray<float> x, Il2CppStructArray<float> y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateEnergyRatio_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125183, RefRangeEnd = 125185, XrefRangeStart = 125182, XrefRangeEnd = 125183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EnergyDetector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnergyDetector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EnergyDetector(IntPtr pointer)
		: base(pointer)
	{
	}
}
