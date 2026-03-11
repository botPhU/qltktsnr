using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

public class EchoDetectionEngine : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_echoThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_correlationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_spectralThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_energyThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_correlationDetector;

	private static readonly System.IntPtr NativeFieldInfoPtr_spectralDetector;

	private static readonly System.IntPtr NativeFieldInfoPtr_energyDetector;

	private static readonly System.IntPtr NativeFieldInfoPtr_crossTalkDetector;

	private static readonly System.IntPtr NativeFieldInfoPtr_detectionHistory;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHistorySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalDetections;

	private static readonly System.IntPtr NativeFieldInfoPtr_truePositives;

	private static readonly System.IntPtr NativeFieldInfoPtr_falsePositives;

	private static readonly System.IntPtr NativeFieldInfoPtr_detectionAccuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDetectionEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastDetectionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_adaptiveEchoThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_adaptiveCorrelationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableAdaptiveThresholds;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDetectionEngine_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetectEcho_Public_EchoDetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateConfidenceScore_Private_Single_EchoDetectionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetermineEchoDetection_Private_Boolean_EchoDetectionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDetectionHistory_Private_Void_EchoDetectionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAdaptiveThresholds_Private_Void_EchoDetectionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFalsePositiveRate_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePerformanceMetrics_Private_Void_EchoDetectionResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDetectionEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEchoThreshold_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAdaptiveThresholdsEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetEngine_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDetectionStatistics_Public_EchoDetectionStatistics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	public unsafe float echoThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echoThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_echoThreshold)) = num;
		}
	}

	public unsafe float correlationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_correlationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_correlationThreshold)) = num;
		}
	}

	public unsafe float spectralThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spectralThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spectralThreshold)) = num;
		}
	}

	public unsafe float energyThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyThreshold)) = num;
		}
	}

	public unsafe CorrelationDetector correlationDetector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_correlationDetector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CorrelationDetector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_correlationDetector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)correlationDetector));
		}
	}

	public unsafe SpectralDetector spectralDetector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spectralDetector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpectralDetector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spectralDetector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spectralDetector));
		}
	}

	public unsafe EnergyDetector energyDetector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyDetector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnergyDetector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_energyDetector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)energyDetector));
		}
	}

	public unsafe CrossTalkDetector crossTalkDetector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crossTalkDetector);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CrossTalkDetector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_crossTalkDetector)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)crossTalkDetector));
		}
	}

	public unsafe Queue<EchoDetectionResult> detectionHistory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detectionHistory);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<EchoDetectionResult>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detectionHistory)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe int maxHistorySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHistorySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHistorySize)) = num;
		}
	}

	public unsafe int totalDetections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalDetections);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalDetections)) = num;
		}
	}

	public unsafe int truePositives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_truePositives);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_truePositives)) = num;
		}
	}

	public unsafe int falsePositives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_falsePositives);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_falsePositives)) = num;
		}
	}

	public unsafe float detectionAccuracy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detectionAccuracy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_detectionAccuracy)) = num;
		}
	}

	public unsafe bool isInitialized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitialized)) = flag;
		}
	}

	public unsafe bool isDetectionEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDetectionEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDetectionEnabled)) = flag;
		}
	}

	public unsafe float lastDetectionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDetectionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDetectionTime)) = num;
		}
	}

	public unsafe float adaptiveEchoThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adaptiveEchoThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adaptiveEchoThreshold)) = num;
		}
	}

	public unsafe float adaptiveCorrelationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adaptiveCorrelationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adaptiveCorrelationThreshold)) = num;
		}
	}

	public unsafe bool enableAdaptiveThresholds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAdaptiveThresholds);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAdaptiveThresholds)) = flag;
		}
	}

	static EchoDetectionEngine()
	{
		Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EchoDetectionEngine");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr);
		NativeFieldInfoPtr_echoThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "echoThreshold");
		NativeFieldInfoPtr_correlationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "correlationThreshold");
		NativeFieldInfoPtr_spectralThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "spectralThreshold");
		NativeFieldInfoPtr_energyThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "energyThreshold");
		NativeFieldInfoPtr_correlationDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "correlationDetector");
		NativeFieldInfoPtr_spectralDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "spectralDetector");
		NativeFieldInfoPtr_energyDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "energyDetector");
		NativeFieldInfoPtr_crossTalkDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "crossTalkDetector");
		NativeFieldInfoPtr_detectionHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "detectionHistory");
		NativeFieldInfoPtr_maxHistorySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "maxHistorySize");
		NativeFieldInfoPtr_totalDetections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "totalDetections");
		NativeFieldInfoPtr_truePositives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "truePositives");
		NativeFieldInfoPtr_falsePositives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "falsePositives");
		NativeFieldInfoPtr_detectionAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "detectionAccuracy");
		NativeFieldInfoPtr_isInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "isInitialized");
		NativeFieldInfoPtr_isDetectionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "isDetectionEnabled");
		NativeFieldInfoPtr_lastDetectionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "lastDetectionTime");
		NativeFieldInfoPtr_adaptiveEchoThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "adaptiveEchoThreshold");
		NativeFieldInfoPtr_adaptiveCorrelationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "adaptiveCorrelationThreshold");
		NativeFieldInfoPtr_enableAdaptiveThresholds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, "enableAdaptiveThresholds");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667001);
		NativeMethodInfoPtr_InitializeDetectionEngine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667002);
		NativeMethodInfoPtr_DetectEcho_Public_EchoDetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667003);
		NativeMethodInfoPtr_CalculateConfidenceScore_Private_Single_EchoDetectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667004);
		NativeMethodInfoPtr_DetermineEchoDetection_Private_Boolean_EchoDetectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667005);
		NativeMethodInfoPtr_UpdateDetectionHistory_Private_Void_EchoDetectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667006);
		NativeMethodInfoPtr_UpdateAdaptiveThresholds_Private_Void_EchoDetectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667007);
		NativeMethodInfoPtr_CalculateFalsePositiveRate_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667008);
		NativeMethodInfoPtr_UpdatePerformanceMetrics_Private_Void_EchoDetectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667009);
		NativeMethodInfoPtr_SetDetectionEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667010);
		NativeMethodInfoPtr_SetEchoThreshold_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667011);
		NativeMethodInfoPtr_SetAdaptiveThresholdsEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667012);
		NativeMethodInfoPtr_ResetEngine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667013);
		NativeMethodInfoPtr_GetDetectionStatistics_Public_EchoDetectionStatistics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667014);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr, 100667015);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124908, XrefRangeEnd = 124910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EchoDetectionEngine(float echoThreshold = 0.3f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EchoDetectionEngine>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&echoThreshold);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 124953, RefRangeEnd = 124955, XrefRangeStart = 124910, XrefRangeEnd = 124953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeDetectionEngine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeDetectionEngine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124955, XrefRangeEnd = 124968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EchoDetectionResult DetectEcho(Il2CppStructArray<float> microphoneInput, Il2CppStructArray<float> speakerOutput, Il2CppStructArray<float> processedOutput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)microphoneInput);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)speakerOutput);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)processedOutput);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetectEcho_Public_EchoDetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EchoDetectionResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124975, RefRangeEnd = 124976, XrefRangeStart = 124968, XrefRangeEnd = 124975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateConfidenceScore(EchoDetectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateConfidenceScore_Private_Single_EchoDetectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124984, RefRangeEnd = 124985, XrefRangeStart = 124976, XrefRangeEnd = 124984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DetermineEchoDetection(EchoDetectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineEchoDetection_Private_Boolean_EchoDetectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 124999, RefRangeEnd = 125000, XrefRangeStart = 124985, XrefRangeEnd = 124999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDetectionHistory(EchoDetectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDetectionHistory_Private_Void_EchoDetectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125008, RefRangeEnd = 125009, XrefRangeStart = 125000, XrefRangeEnd = 125008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAdaptiveThresholds(EchoDetectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAdaptiveThresholds_Private_Void_EchoDetectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 125034, RefRangeEnd = 125036, XrefRangeStart = 125009, XrefRangeEnd = 125034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateFalsePositiveRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFalsePositiveRate_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 125043, RefRangeEnd = 125044, XrefRangeStart = 125036, XrefRangeEnd = 125043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePerformanceMetrics(EchoDetectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&result);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePerformanceMetrics_Private_Void_EchoDetectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125044, XrefRangeEnd = 125055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDetectionEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDetectionEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125055, XrefRangeEnd = 125065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEchoThreshold(float newThreshold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newThreshold);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEchoThreshold_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125065, XrefRangeEnd = 125076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAdaptiveThresholdsEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAdaptiveThresholdsEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125076, XrefRangeEnd = 125091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetEngine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetEngine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125091, XrefRangeEnd = 125093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EchoDetectionStatistics GetDetectionStatistics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDetectionStatistics_Public_EchoDetectionStatistics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(EchoDetectionStatistics*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125093, XrefRangeEnd = 125109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EchoDetectionEngine(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
