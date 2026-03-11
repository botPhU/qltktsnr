using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct EchoCancellationMetrics
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EchoSuppression;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConvergenceRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalSamplesProcessed;

	private static readonly System.IntPtr NativeFieldInfoPtr_EchoDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr_EchoDetectedLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_FilterLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_LearningRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAdapting;

	[FieldOffset(0)]
	public float EchoSuppression;

	[FieldOffset(4)]
	public float ConvergenceRate;

	[FieldOffset(8)]
	public int TotalSamplesProcessed;

	[FieldOffset(12)]
	[MarshalAs(UnmanagedType.U1)]
	public bool EchoDetected;

	[FieldOffset(16)]
	public float EchoDetectedLevel;

	[FieldOffset(20)]
	public int FilterLength;

	[FieldOffset(24)]
	public float LearningRate;

	[FieldOffset(28)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsAdapting;

	static EchoCancellationMetrics()
	{
		Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EchoCancellationMetrics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr);
		NativeFieldInfoPtr_EchoSuppression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "EchoSuppression");
		NativeFieldInfoPtr_ConvergenceRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "ConvergenceRate");
		NativeFieldInfoPtr_TotalSamplesProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "TotalSamplesProcessed");
		NativeFieldInfoPtr_EchoDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "EchoDetected");
		NativeFieldInfoPtr_EchoDetectedLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "EchoDetectedLevel");
		NativeFieldInfoPtr_FilterLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "FilterLength");
		NativeFieldInfoPtr_LearningRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "LearningRate");
		NativeFieldInfoPtr_IsAdapting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, "IsAdapting");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EchoCancellationMetrics>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
