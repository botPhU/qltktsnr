using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

[System.Serializable]
public class EchoCancellationSettingsData : Il2CppSystem.Object
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

	static EchoCancellationSettingsData()
	{
		Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EchoCancellationSettingsData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr);
		NativeFieldInfoPtr_enableEchoCancellation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableEchoCancellation");
		NativeFieldInfoPtr_enableAdaptiveLearning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableAdaptiveLearning");
		NativeFieldInfoPtr_enableRealTimeMonitoring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableRealTimeMonitoring");
		NativeFieldInfoPtr_filterLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "filterLength");
		NativeFieldInfoPtr_learningRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "learningRate");
		NativeFieldInfoPtr_regularization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "regularization");
		NativeFieldInfoPtr_echoThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "echoThreshold");
		NativeFieldInfoPtr_correlationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "correlationThreshold");
		NativeFieldInfoPtr_spectralThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "spectralThreshold");
		NativeFieldInfoPtr_energyThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "energyThreshold");
		NativeFieldInfoPtr_frameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "frameSize");
		NativeFieldInfoPtr_bufferCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "bufferCapacity");
		NativeFieldInfoPtr_enableFrameAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableFrameAlignment");
		NativeFieldInfoPtr_enableCircularBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableCircularBuffer");
		NativeFieldInfoPtr_updateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "updateInterval");
		NativeFieldInfoPtr_maxHistorySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "maxHistorySize");
		NativeFieldInfoPtr_enablePerformanceLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enablePerformanceLogging");
		NativeFieldInfoPtr_enableCrossTalkDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableCrossTalkDetection");
		NativeFieldInfoPtr_enableSpectralAnalysis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableSpectralAnalysis");
		NativeFieldInfoPtr_enableEnergyAnalysis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableEnergyAnalysis");
		NativeFieldInfoPtr_enableCorrelationAnalysis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, "enableCorrelationAnalysis");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr, 100667000);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EchoCancellationSettingsData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EchoCancellationSettingsData>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EchoCancellationSettingsData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
