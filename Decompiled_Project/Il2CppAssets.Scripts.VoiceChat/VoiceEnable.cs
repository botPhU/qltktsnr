using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.VoiceChat;

public static class VoiceEnable : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_enableLoaMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableLoaBang;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableMICMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_enableMICBang;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTypeMIC_Public_Static_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsVoiceChatEnabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaybackEnabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRecordingEnabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAll_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableMapVoiceChat_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableBangVoiceChat_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableAllVoiceChat_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStatusInfo_Public_Static_String_0;

	public unsafe static bool enableLoaMap
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enableLoaMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enableLoaMap, (void*)(&flag));
		}
	}

	public unsafe static bool enableLoaBang
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enableLoaBang, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enableLoaBang, (void*)(&flag));
		}
	}

	public unsafe static bool enableMICMap
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enableMICMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enableMICMap, (void*)(&flag));
		}
	}

	public unsafe static bool enableMICBang
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enableMICBang, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enableMICBang, (void*)(&flag));
		}
	}

	public unsafe static bool IsVoiceChatEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123147, XrefRangeEnd = 123149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsVoiceChatEnabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static bool IsPlaybackEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123149, XrefRangeEnd = 123151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPlaybackEnabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	public unsafe static bool IsRecordingEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123151, XrefRangeEnd = 123153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsRecordingEnabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static VoiceEnable()
	{
		Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.VoiceChat", "VoiceEnable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr);
		NativeFieldInfoPtr_enableLoaMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, "enableLoaMap");
		NativeFieldInfoPtr_enableLoaBang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, "enableLoaBang");
		NativeFieldInfoPtr_enableMICMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, "enableMICMap");
		NativeFieldInfoPtr_enableMICBang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, "enableMICBang");
		NativeMethodInfoPtr_getTypeMIC_Public_Static_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666891);
		NativeMethodInfoPtr_get_IsVoiceChatEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666892);
		NativeMethodInfoPtr_get_IsPlaybackEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666893);
		NativeMethodInfoPtr_get_IsRecordingEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666894);
		NativeMethodInfoPtr_ResetAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666895);
		NativeMethodInfoPtr_EnableMapVoiceChat_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666896);
		NativeMethodInfoPtr_EnableBangVoiceChat_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666897);
		NativeMethodInfoPtr_EnableAllVoiceChat_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666898);
		NativeMethodInfoPtr_GetStatusInfo_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceEnable>.NativeClassPtr, 100666899);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 123146, RefRangeEnd = 123147, XrefRangeStart = 123144, XrefRangeEnd = 123146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte getTypeMIC()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTypeMIC_Public_Static_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123153, XrefRangeEnd = 123164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetAll()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAll_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123164, XrefRangeEnd = 123178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableMapVoiceChat(bool enable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableMapVoiceChat_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123178, XrefRangeEnd = 123192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableBangVoiceChat(bool enable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableBangVoiceChat_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123192, XrefRangeEnd = 123208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableAllVoiceChat(bool enable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableAllVoiceChat_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123208, XrefRangeEnd = 123254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStatusInfo()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStatusInfo_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public VoiceEnable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
