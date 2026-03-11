using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

public class AudioBufferManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frameSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferCapacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_readIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_writeIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_availableSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_microphoneBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_speakerBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_processedBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBufferFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBufferEmpty;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalSamplesWritten;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalSamplesRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferOverflows;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferUnderflows;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameAlignmentOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableFrameAlignment;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteMicrophoneData_Public_Boolean_Il2CppStructArray_1_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteSpeakerData_Public_Boolean_Il2CppStructArray_1_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadMicrophoneData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadSpeakerData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMicrophoneFrame_Public_Boolean_Il2CppStructArray_1_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpeakerFrame_Public_Boolean_Il2CppStructArray_1_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindFrameBoundary_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFrameBoundaryScore_Private_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferStatus_Public_AudioBufferStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetBuffer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFrameSize_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFrameAlignmentEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

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

	public unsafe int readIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readIndex)) = num;
		}
	}

	public unsafe int writeIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_writeIndex)) = num;
		}
	}

	public unsafe int availableSamples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableSamples);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_availableSamples)) = num;
		}
	}

	public unsafe Il2CppStructArray<float> microphoneBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_microphoneBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_microphoneBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<float> speakerBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speakerBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speakerBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<float> processedBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processedBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processedBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppSystem.Object bufferLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferLock);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferLock)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe bool isBufferFull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBufferFull);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBufferFull)) = flag;
		}
	}

	public unsafe bool isBufferEmpty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBufferEmpty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBufferEmpty)) = flag;
		}
	}

	public unsafe int totalSamplesWritten
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSamplesWritten);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSamplesWritten)) = num;
		}
	}

	public unsafe int totalSamplesRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSamplesRead);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalSamplesRead)) = num;
		}
	}

	public unsafe int bufferOverflows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferOverflows);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferOverflows)) = num;
		}
	}

	public unsafe int bufferUnderflows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferUnderflows);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferUnderflows)) = num;
		}
	}

	public unsafe int frameAlignmentOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameAlignmentOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameAlignmentOffset)) = num;
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

	static AudioBufferManager()
	{
		Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "AudioBufferManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr);
		NativeFieldInfoPtr_frameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "frameSize");
		NativeFieldInfoPtr_bufferCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "bufferCapacity");
		NativeFieldInfoPtr_readIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "readIndex");
		NativeFieldInfoPtr_writeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "writeIndex");
		NativeFieldInfoPtr_availableSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "availableSamples");
		NativeFieldInfoPtr_microphoneBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "microphoneBuffer");
		NativeFieldInfoPtr_speakerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "speakerBuffer");
		NativeFieldInfoPtr_processedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "processedBuffer");
		NativeFieldInfoPtr_bufferLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "bufferLock");
		NativeFieldInfoPtr_isBufferFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "isBufferFull");
		NativeFieldInfoPtr_isBufferEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "isBufferEmpty");
		NativeFieldInfoPtr_totalSamplesWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "totalSamplesWritten");
		NativeFieldInfoPtr_totalSamplesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "totalSamplesRead");
		NativeFieldInfoPtr_bufferOverflows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "bufferOverflows");
		NativeFieldInfoPtr_bufferUnderflows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "bufferUnderflows");
		NativeFieldInfoPtr_frameAlignmentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "frameAlignmentOffset");
		NativeFieldInfoPtr_enableFrameAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, "enableFrameAlignment");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666925);
		NativeMethodInfoPtr_InitializeBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666926);
		NativeMethodInfoPtr_WriteMicrophoneData_Public_Boolean_Il2CppStructArray_1_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666927);
		NativeMethodInfoPtr_WriteSpeakerData_Public_Boolean_Il2CppStructArray_1_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666928);
		NativeMethodInfoPtr_ReadMicrophoneData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666929);
		NativeMethodInfoPtr_ReadSpeakerData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666930);
		NativeMethodInfoPtr_GetMicrophoneFrame_Public_Boolean_Il2CppStructArray_1_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666931);
		NativeMethodInfoPtr_GetSpeakerFrame_Public_Boolean_Il2CppStructArray_1_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666932);
		NativeMethodInfoPtr_FindFrameBoundary_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666933);
		NativeMethodInfoPtr_CalculateFrameBoundaryScore_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666934);
		NativeMethodInfoPtr_GetBufferStatus_Public_AudioBufferStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666935);
		NativeMethodInfoPtr_ResetBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666936);
		NativeMethodInfoPtr_SetFrameSize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666937);
		NativeMethodInfoPtr_SetFrameAlignmentEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666938);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr, 100666939);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123748, XrefRangeEnd = 123755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioBufferManager(int frameSize = 512, int bufferCapacity = 10)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioBufferManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frameSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferCapacity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 123788, RefRangeEnd = 123791, XrefRangeStart = 123755, XrefRangeEnd = 123788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123791, XrefRangeEnd = 123818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WriteMicrophoneData(Il2CppStructArray<float> data, int offset = 0, int length = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteMicrophoneData_Public_Boolean_Il2CppStructArray_1_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123818, XrefRangeEnd = 123845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WriteSpeakerData(Il2CppStructArray<float> data, int offset = 0, int length = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteSpeakerData_Public_Boolean_Il2CppStructArray_1_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123845, XrefRangeEnd = 123860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReadMicrophoneData(Il2CppStructArray<float> output, int offset = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadMicrophoneData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123860, XrefRangeEnd = 123875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReadSpeakerData(Il2CppStructArray<float> output, int offset = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadSpeakerData_Public_Boolean_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123875, XrefRangeEnd = 123891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetMicrophoneFrame(Il2CppStructArray<float> output, bool enableAlignment = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlignment;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMicrophoneFrame_Public_Boolean_Il2CppStructArray_1_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123891, XrefRangeEnd = 123907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetSpeakerFrame(Il2CppStructArray<float> output, bool enableAlignment = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)output);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableAlignment;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpeakerFrame_Public_Boolean_Il2CppStructArray_1_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 123915, RefRangeEnd = 123917, XrefRangeStart = 123907, XrefRangeEnd = 123915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindFrameBoundary(int currentIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindFrameBoundary_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123926, RefRangeEnd = 123927, XrefRangeStart = 123917, XrefRangeEnd = 123926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateFrameBoundaryScore(int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&startIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFrameBoundaryScore_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123927, XrefRangeEnd = 123931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioBufferStatus GetBufferStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferStatus_Public_AudioBufferStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(AudioBufferStatus*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123931, XrefRangeEnd = 123951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetBuffer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123951, XrefRangeEnd = 123973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFrameSize(int newFrameSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newFrameSize);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrameSize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123973, XrefRangeEnd = 123984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFrameAlignmentEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrameAlignmentEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123984, XrefRangeEnd = 123999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AudioBufferManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
