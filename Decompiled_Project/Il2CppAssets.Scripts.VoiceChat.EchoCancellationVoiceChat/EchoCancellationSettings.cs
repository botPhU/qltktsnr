using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

public class EchoCancellationSettings : ScriptableObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enableEchoCancellation;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableAdaptiveLearning;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableRealTimeMonitoring;

	private static readonly System.IntPtr NativeFieldInfoPtr_filterLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_learningRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_regularization;

	private static readonly System.IntPtr NativeFieldInfoPtr_echoThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_correlationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_spectralThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_energyThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableAdaptiveThresholds;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferCapacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFrameAlignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCircularBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_updateInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHistorySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_enablePerformanceLogging;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCrossTalkDetection;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableSpectralAnalysis;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableEnergyAnalysis;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableCorrelationAnalysis;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSettingsChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_FILTER_LENGTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_LEARNING_RATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ECHO_THRESHOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_FRAME_SIZE;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateSettings_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetToDefaults_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromPlayerPrefs_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveToPlayerPrefs_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExportToJSON_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportFromJSON_Public_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateSettingsWithErrors_Public_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSettingsSummary_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableEchoCancellation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableEchoCancellation_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableAdaptiveLearning_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableAdaptiveLearning_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FilterLength_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FilterLength_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LearningRate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LearningRate_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EchoThreshold_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EchoThreshold_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FrameSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FrameSize_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UpdateInterval_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UpdateInterval_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool enableEchoCancellation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableEchoCancellation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableEchoCancellation)) = flag;
		}
	}

	public unsafe bool enableAdaptiveLearning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAdaptiveLearning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableAdaptiveLearning)) = flag;
		}
	}

	public unsafe bool enableRealTimeMonitoring
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRealTimeMonitoring);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableRealTimeMonitoring)) = flag;
		}
	}

	public unsafe int filterLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filterLength)) = num;
		}
	}

	public unsafe float learningRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_learningRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_learningRate)) = num;
		}
	}

	public unsafe float regularization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularization);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regularization)) = num;
		}
	}

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

	public unsafe int frameSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameSize)) = num;
		}
	}

	public unsafe int bufferCapacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferCapacity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferCapacity)) = num;
		}
	}

	public unsafe bool enableFrameAlignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFrameAlignment);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableFrameAlignment)) = flag;
		}
	}

	public unsafe bool enableCircularBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCircularBuffer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCircularBuffer)) = flag;
		}
	}

	public unsafe float updateInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateInterval)) = num;
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

	public unsafe bool enablePerformanceLogging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enablePerformanceLogging);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enablePerformanceLogging)) = flag;
		}
	}

	public unsafe bool enableCrossTalkDetection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCrossTalkDetection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCrossTalkDetection)) = flag;
		}
	}

	public unsafe bool enableSpectralAnalysis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSpectralAnalysis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableSpectralAnalysis)) = flag;
		}
	}

	public unsafe bool enableEnergyAnalysis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableEnergyAnalysis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableEnergyAnalysis)) = flag;
		}
	}

	public unsafe bool enableCorrelationAnalysis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCorrelationAnalysis);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableCorrelationAnalysis)) = flag;
		}
	}

	public unsafe static Il2CppSystem.Action<EchoCancellationSettings> OnSettingsChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnSettingsChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<EchoCancellationSettings>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnSettingsChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
		}
	}

	public unsafe static int DEFAULT_FILTER_LENGTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_FILTER_LENGTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_FILTER_LENGTH, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_LEARNING_RATE
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_LEARNING_RATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_LEARNING_RATE, (void*)(&num));
		}
	}

	public unsafe static float DEFAULT_ECHO_THRESHOLD
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ECHO_THRESHOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ECHO_THRESHOLD, (void*)(&num));
		}
	}

	public unsafe static int DEFAULT_FRAME_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_FRAME_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_FRAME_SIZE, (void*)(&num));
		}
	}

	public unsafe bool EnableEchoCancellation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnableEchoCancellation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124886, XrefRangeEnd = 124888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnableEchoCancellation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe bool EnableAdaptiveLearning
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnableAdaptiveLearning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124888, XrefRangeEnd = 124890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnableAdaptiveLearning_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int FilterLength
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FilterLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124890, XrefRangeEnd = 124894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FilterLength_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float LearningRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LearningRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124894, XrefRangeEnd = 124897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LearningRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float EchoThreshold
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EchoThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124897, XrefRangeEnd = 124900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EchoThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe int FrameSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FrameSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124900, XrefRangeEnd = 124904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FrameSize_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe float UpdateInterval
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpdateInterval_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124904, XrefRangeEnd = 124907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UpdateInterval_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	static EchoCancellationSettings()
	{
		Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EchoCancellationSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr);
		NativeFieldInfoPtr_enableEchoCancellation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableEchoCancellation");
		NativeFieldInfoPtr_enableAdaptiveLearning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableAdaptiveLearning");
		NativeFieldInfoPtr_enableRealTimeMonitoring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableRealTimeMonitoring");
		NativeFieldInfoPtr_filterLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "filterLength");
		NativeFieldInfoPtr_learningRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "learningRate");
		NativeFieldInfoPtr_regularization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "regularization");
		NativeFieldInfoPtr_echoThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "echoThreshold");
		NativeFieldInfoPtr_correlationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "correlationThreshold");
		NativeFieldInfoPtr_spectralThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "spectralThreshold");
		NativeFieldInfoPtr_energyThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "energyThreshold");
		NativeFieldInfoPtr_enableAdaptiveThresholds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableAdaptiveThresholds");
		NativeFieldInfoPtr_frameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "frameSize");
		NativeFieldInfoPtr_bufferCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "bufferCapacity");
		NativeFieldInfoPtr_enableFrameAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableFrameAlignment");
		NativeFieldInfoPtr_enableCircularBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableCircularBuffer");
		NativeFieldInfoPtr_updateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "updateInterval");
		NativeFieldInfoPtr_maxHistorySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "maxHistorySize");
		NativeFieldInfoPtr_enablePerformanceLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enablePerformanceLogging");
		NativeFieldInfoPtr_enableCrossTalkDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableCrossTalkDetection");
		NativeFieldInfoPtr_enableSpectralAnalysis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableSpectralAnalysis");
		NativeFieldInfoPtr_enableEnergyAnalysis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableEnergyAnalysis");
		NativeFieldInfoPtr_enableCorrelationAnalysis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "enableCorrelationAnalysis");
		NativeFieldInfoPtr_OnSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "OnSettingsChanged");
		NativeFieldInfoPtr_DEFAULT_FILTER_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "DEFAULT_FILTER_LENGTH");
		NativeFieldInfoPtr_DEFAULT_LEARNING_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "DEFAULT_LEARNING_RATE");
		NativeFieldInfoPtr_DEFAULT_ECHO_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "DEFAULT_ECHO_THRESHOLD");
		NativeFieldInfoPtr_DEFAULT_FRAME_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, "DEFAULT_FRAME_SIZE");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666976);
		NativeMethodInfoPtr_ValidateSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666977);
		NativeMethodInfoPtr_ResetToDefaults_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666978);
		NativeMethodInfoPtr_LoadFromPlayerPrefs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666979);
		NativeMethodInfoPtr_SaveToPlayerPrefs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666980);
		NativeMethodInfoPtr_ExportToJSON_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666981);
		NativeMethodInfoPtr_ImportFromJSON_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666982);
		NativeMethodInfoPtr_ValidateSettingsWithErrors_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666983);
		NativeMethodInfoPtr_GetSettingsSummary_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666984);
		NativeMethodInfoPtr_get_EnableEchoCancellation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666985);
		NativeMethodInfoPtr_set_EnableEchoCancellation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666986);
		NativeMethodInfoPtr_get_EnableAdaptiveLearning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666987);
		NativeMethodInfoPtr_set_EnableAdaptiveLearning_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666988);
		NativeMethodInfoPtr_get_FilterLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666989);
		NativeMethodInfoPtr_set_FilterLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666990);
		NativeMethodInfoPtr_get_LearningRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666991);
		NativeMethodInfoPtr_set_LearningRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666992);
		NativeMethodInfoPtr_get_EchoThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666993);
		NativeMethodInfoPtr_set_EchoThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666994);
		NativeMethodInfoPtr_get_FrameSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666995);
		NativeMethodInfoPtr_set_FrameSize_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666996);
		NativeMethodInfoPtr_get_UpdateInterval_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666997);
		NativeMethodInfoPtr_set_UpdateInterval_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666998);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr, 100666999);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124478, XrefRangeEnd = 124479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 124495, RefRangeEnd = 124504, XrefRangeStart = 124479, XrefRangeEnd = 124495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124504, XrefRangeEnd = 124519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetToDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetToDefaults_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124519, XrefRangeEnd = 124595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadFromPlayerPrefs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFromPlayerPrefs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124595, XrefRangeEnd = 124671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveToPlayerPrefs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveToPlayerPrefs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124671, XrefRangeEnd = 124692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ExportToJSON()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExportToJSON_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124692, XrefRangeEnd = 124713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ImportFromJSON(string jsonData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(jsonData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportFromJSON_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124713, XrefRangeEnd = 124815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray ValidateSettingsWithErrors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateSettingsWithErrors_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124815, XrefRangeEnd = 124886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetSettingsSummary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSettingsSummary_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124907, XrefRangeEnd = 124908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EchoCancellationSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EchoCancellationSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EchoCancellationSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
