using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public static class FileLogger : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__logPath;

	private static readonly System.IntPtr NativeFieldInfoPtr__initState;

	private static readonly System.IntPtr NativeFieldInfoPtr__logPrefix;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateLogPrefix_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BuildFileName_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLogPath_Public_Static_String_0;

	public unsafe static string _logPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__logPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__logPath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool _initState
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__initState, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__initState, (void*)(&flag));
		}
	}

	public unsafe static string _logPrefix
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__logPrefix, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__logPrefix, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static FileLogger()
	{
		Il2CppClassPointerStore<FileLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FileLogger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileLogger>.NativeClassPtr);
		NativeFieldInfoPtr__logPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, "_logPath");
		NativeFieldInfoPtr__initState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, "_initState");
		NativeFieldInfoPtr__logPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, "_logPrefix");
		NativeMethodInfoPtr_GenerateLogPrefix_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, 100666071);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, 100666072);
		NativeMethodInfoPtr_BuildFileName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, 100666073);
		NativeMethodInfoPtr_Log_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, 100666074);
		NativeMethodInfoPtr_LogError_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, 100666075);
		NativeMethodInfoPtr_GetLogPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileLogger>.NativeClassPtr, 100666076);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95136, XrefRangeEnd = 95143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GenerateLogPrefix()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateLogPrefix_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95196, RefRangeEnd = 95198, XrefRangeStart = 95143, XrefRangeEnd = 95196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95198, XrefRangeEnd = 95207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string BuildFileName()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BuildFileName_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95207, XrefRangeEnd = 95233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95233, XrefRangeEnd = 95271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogError(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogError_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95271, XrefRangeEnd = 95275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetLogPath()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLogPath_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public FileLogger(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
