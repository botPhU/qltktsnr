using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public static class MultiLayerLogger : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EnableLogging;

	private static readonly System.IntPtr NativeFieldInfoPtr_fileLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_logPath;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_0;

	public unsafe static bool EnableLogging
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnableLogging, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnableLogging, (void*)(&flag));
		}
	}

	public unsafe static Il2CppSystem.Object fileLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fileLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fileLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static string logPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logPath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static MultiLayerLogger()
	{
		Il2CppClassPointerStore<MultiLayerLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MultiLayerLogger");
		NativeFieldInfoPtr_EnableLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerLogger>.NativeClassPtr, "EnableLogging");
		NativeFieldInfoPtr_fileLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerLogger>.NativeClassPtr, "fileLock");
		NativeFieldInfoPtr_logPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiLayerLogger>.NativeClassPtr, "logPath");
		NativeMethodInfoPtr_Log_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiLayerLogger>.NativeClassPtr, 100665099);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 65014, RefRangeEnd = 65053, XrefRangeStart = 64987, XrefRangeEnd = 65014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MultiLayerLogger(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
