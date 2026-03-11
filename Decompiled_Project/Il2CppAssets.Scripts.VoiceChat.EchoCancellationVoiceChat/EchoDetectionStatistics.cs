using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct EchoDetectionStatistics
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TotalDetections;

	private static readonly System.IntPtr NativeFieldInfoPtr_TruePositives;

	private static readonly System.IntPtr NativeFieldInfoPtr_FalsePositives;

	private static readonly System.IntPtr NativeFieldInfoPtr_DetectionAccuracy;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentEchoThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCorrelationThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_FalsePositiveRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_HistorySize;

	[FieldOffset(0)]
	public int TotalDetections;

	[FieldOffset(4)]
	public int TruePositives;

	[FieldOffset(8)]
	public int FalsePositives;

	[FieldOffset(12)]
	public float DetectionAccuracy;

	[FieldOffset(16)]
	public float CurrentEchoThreshold;

	[FieldOffset(20)]
	public float CurrentCorrelationThreshold;

	[FieldOffset(24)]
	public float FalsePositiveRate;

	[FieldOffset(28)]
	public int HistorySize;

	static EchoDetectionStatistics()
	{
		Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EchoDetectionStatistics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr);
		NativeFieldInfoPtr_TotalDetections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "TotalDetections");
		NativeFieldInfoPtr_TruePositives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "TruePositives");
		NativeFieldInfoPtr_FalsePositives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "FalsePositives");
		NativeFieldInfoPtr_DetectionAccuracy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "DetectionAccuracy");
		NativeFieldInfoPtr_CurrentEchoThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "CurrentEchoThreshold");
		NativeFieldInfoPtr_CurrentCorrelationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "CurrentCorrelationThreshold");
		NativeFieldInfoPtr_FalsePositiveRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "FalsePositiveRate");
		NativeFieldInfoPtr_HistorySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, "HistorySize");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EchoDetectionStatistics>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
