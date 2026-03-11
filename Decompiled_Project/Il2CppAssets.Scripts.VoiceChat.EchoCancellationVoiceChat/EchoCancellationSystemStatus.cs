using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct EchoCancellationSystemStatus
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsInitialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsEnabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsProcessing;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalFramesProcessed;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroppedFrames;

	private static readonly System.IntPtr NativeFieldInfoPtr_AverageProcessingTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_MicrophoneBufferSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpeakerBufferSize;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsInitialized;

	[FieldOffset(1)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsEnabled;

	[FieldOffset(2)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsProcessing;

	[FieldOffset(4)]
	public int TotalFramesProcessed;

	[FieldOffset(8)]
	public int DroppedFrames;

	[FieldOffset(12)]
	public float AverageProcessingTime;

	[FieldOffset(16)]
	public int MicrophoneBufferSize;

	[FieldOffset(20)]
	public int SpeakerBufferSize;

	static EchoCancellationSystemStatus()
	{
		Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EchoCancellationSystemStatus");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr);
		NativeFieldInfoPtr_IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "IsInitialized");
		NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "IsEnabled");
		NativeFieldInfoPtr_IsProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "IsProcessing");
		NativeFieldInfoPtr_TotalFramesProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "TotalFramesProcessed");
		NativeFieldInfoPtr_DroppedFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "DroppedFrames");
		NativeFieldInfoPtr_AverageProcessingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "AverageProcessingTime");
		NativeFieldInfoPtr_MicrophoneBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "MicrophoneBufferSize");
		NativeFieldInfoPtr_SpeakerBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, "SpeakerBufferSize");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EchoCancellationSystemStatus>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
