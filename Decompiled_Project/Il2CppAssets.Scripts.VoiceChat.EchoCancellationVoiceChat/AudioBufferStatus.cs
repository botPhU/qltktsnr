using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct AudioBufferStatus
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AvailableSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_BufferCapacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_BufferUsage;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsBufferFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsBufferEmpty;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReadIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_WriteIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrameAlignmentOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalSamplesWritten;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalSamplesRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_BufferOverflows;

	private static readonly System.IntPtr NativeFieldInfoPtr_BufferUnderflows;

	[FieldOffset(0)]
	public int AvailableSamples;

	[FieldOffset(4)]
	public int BufferCapacity;

	[FieldOffset(8)]
	public float BufferUsage;

	[FieldOffset(12)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsBufferFull;

	[FieldOffset(13)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsBufferEmpty;

	[FieldOffset(16)]
	public int ReadIndex;

	[FieldOffset(20)]
	public int WriteIndex;

	[FieldOffset(24)]
	public int FrameAlignmentOffset;

	[FieldOffset(28)]
	public int TotalSamplesWritten;

	[FieldOffset(32)]
	public int TotalSamplesRead;

	[FieldOffset(36)]
	public int BufferOverflows;

	[FieldOffset(40)]
	public int BufferUnderflows;

	static AudioBufferStatus()
	{
		Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "AudioBufferStatus");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr);
		NativeFieldInfoPtr_AvailableSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "AvailableSamples");
		NativeFieldInfoPtr_BufferCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "BufferCapacity");
		NativeFieldInfoPtr_BufferUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "BufferUsage");
		NativeFieldInfoPtr_IsBufferFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "IsBufferFull");
		NativeFieldInfoPtr_IsBufferEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "IsBufferEmpty");
		NativeFieldInfoPtr_ReadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "ReadIndex");
		NativeFieldInfoPtr_WriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "WriteIndex");
		NativeFieldInfoPtr_FrameAlignmentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "FrameAlignmentOffset");
		NativeFieldInfoPtr_TotalSamplesWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "TotalSamplesWritten");
		NativeFieldInfoPtr_TotalSamplesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "TotalSamplesRead");
		NativeFieldInfoPtr_BufferOverflows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "BufferOverflows");
		NativeFieldInfoPtr_BufferUnderflows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, "BufferUnderflows");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioBufferStatus>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
