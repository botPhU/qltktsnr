using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

public class CrossTalkDetector : BaseDetector
{
	private static readonly IntPtr NativeMethodInfoPtr_Detect_Public_Virtual_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalculateCrossTalkRatio_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static CrossTalkDetector()
	{
		Il2CppClassPointerStore<CrossTalkDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "CrossTalkDetector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossTalkDetector>.NativeClassPtr);
		NativeMethodInfoPtr_Detect_Public_Virtual_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossTalkDetector>.NativeClassPtr, 100667027);
		NativeMethodInfoPtr_CalculateCrossTalkRatio_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossTalkDetector>.NativeClassPtr, 100667028);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossTalkDetector>.NativeClassPtr, 100667029);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125185, XrefRangeEnd = 125193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 125201, RefRangeEnd = 125202, XrefRangeStart = 125193, XrefRangeEnd = 125201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateCrossTalkRatio(Il2CppStructArray<float> x, Il2CppStructArray<float> y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateCrossTalkRatio_Private_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125183, RefRangeEnd = 125185, XrefRangeStart = 125183, XrefRangeEnd = 125185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CrossTalkDetector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossTalkDetector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public CrossTalkDetector(IntPtr pointer)
		: base(pointer)
	{
	}
}
