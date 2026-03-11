using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct EchoDetectionResult
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsEchoDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr_Confidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_CorrelationDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr_CorrelationScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpectralDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpectralScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnergyDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnergyScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_CrossTalkDetected;

	private static readonly System.IntPtr NativeFieldInfoPtr_CrossTalkScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_DetectionTime;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool IsEchoDetected;

	[FieldOffset(4)]
	public float Confidence;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool CorrelationDetected;

	[FieldOffset(12)]
	public float CorrelationScore;

	[FieldOffset(16)]
	[MarshalAs(UnmanagedType.U1)]
	public bool SpectralDetected;

	[FieldOffset(20)]
	public float SpectralScore;

	[FieldOffset(24)]
	[MarshalAs(UnmanagedType.U1)]
	public bool EnergyDetected;

	[FieldOffset(28)]
	public float EnergyScore;

	[FieldOffset(32)]
	[MarshalAs(UnmanagedType.U1)]
	public bool CrossTalkDetected;

	[FieldOffset(36)]
	public float CrossTalkScore;

	[FieldOffset(40)]
	public float DetectionTime;

	static EchoDetectionResult()
	{
		Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "EchoDetectionResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr);
		NativeFieldInfoPtr_IsEchoDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "IsEchoDetected");
		NativeFieldInfoPtr_Confidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "Confidence");
		NativeFieldInfoPtr_CorrelationDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "CorrelationDetected");
		NativeFieldInfoPtr_CorrelationScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "CorrelationScore");
		NativeFieldInfoPtr_SpectralDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "SpectralDetected");
		NativeFieldInfoPtr_SpectralScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "SpectralScore");
		NativeFieldInfoPtr_EnergyDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "EnergyDetected");
		NativeFieldInfoPtr_EnergyScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "EnergyScore");
		NativeFieldInfoPtr_CrossTalkDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "CrossTalkDetected");
		NativeFieldInfoPtr_CrossTalkScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "CrossTalkScore");
		NativeFieldInfoPtr_DetectionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, "DetectionTime");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EchoDetectionResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
