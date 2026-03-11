using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat.EchoCancellationVoiceChat;

public class BaseDetector : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DetectionResult
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_IsDetected;

		private static readonly System.IntPtr NativeFieldInfoPtr_Score;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool IsDetected;

		[FieldOffset(4)]
		public float Score;

		static DetectionResult()
		{
			Il2CppClassPointerStore<DetectionResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseDetector>.NativeClassPtr, "DetectionResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr);
			NativeFieldInfoPtr_IsDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, "IsDetected");
			NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, "Score");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DetectionResult>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_threshold;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Detect_Public_Abstract_Virtual_New_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0;

	public unsafe float threshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_threshold)) = num;
		}
	}

	static BaseDetector()
	{
		Il2CppClassPointerStore<BaseDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat.EchoCancellationVoiceChat", "BaseDetector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseDetector>.NativeClassPtr);
		NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDetector>.NativeClassPtr, "threshold");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDetector>.NativeClassPtr, 100667016);
		NativeMethodInfoPtr_Detect_Public_Abstract_Virtual_New_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDetector>.NativeClassPtr, 100667017);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 125110, RefRangeEnd = 125125, XrefRangeStart = 125109, XrefRangeEnd = 125110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseDetector(float threshold = 0.5f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseDetector>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&threshold);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual DetectionResult Detect(Il2CppStructArray<float> input1, Il2CppStructArray<float> input2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Detect_Public_Abstract_Virtual_New_DetectionResult_Il2CppStructArray_1_Single_Il2CppStructArray_1_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(DetectionResult*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public BaseDetector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
