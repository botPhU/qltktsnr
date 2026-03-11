using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

public class CorrelationDetector : BaseDetector
{
	private static readonly IntPtr NativeMethodInfoPtr_Detect_Public_Virtual_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateCorrelation_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CorrelationDetector()
	{
		Il2CppClassPointerStore<CorrelationDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "CorrelationDetector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CorrelationDetector>.NativeClassPtr);
		NativeMethodInfoPtr_Detect_Public_Virtual_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorrelationDetector>.NativeClassPtr, 100667018);
		NativeMethodInfoPtr_CalculateCorrelation_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorrelationDetector>.NativeClassPtr, 100667019);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CorrelationDetector>.NativeClassPtr, 100667020);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125125, XrefRangeEnd = 125133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 125144, RefRangeEnd = 125145, XrefRangeStart = 125133, XrefRangeEnd = 125144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateCorrelation(Il2CppStructArray<float> x, Il2CppStructArray<float> y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateCorrelation_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125145, XrefRangeEnd = 125146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CorrelationDetector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CorrelationDetector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CorrelationDetector(IntPtr pointer)
		: base(pointer)
	{
	}
}
