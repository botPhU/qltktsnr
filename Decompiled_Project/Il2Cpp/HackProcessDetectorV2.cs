using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2Cpp;

public static class HackProcessDetectorV2 : Il2CppSystem.Object
{
	public sealed class EnumWindowsProc : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;

		static EnumWindowsProc()
		{
			Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "EnumWindowsProc");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664345);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664346);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664347);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664348);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumWindowsProc(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual bool Invoke(System.IntPtr hWnd, System.IntPtr lParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&hWnd);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lParam;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51048, XrefRangeEnd = 51054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(System.IntPtr hWnd, System.IntPtr lParam, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&hWnd);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lParam;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EndInvoke(Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public EnumWindowsProc(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator EnumWindowsProc(System.Func<System.IntPtr, System.IntPtr, bool> P_0)
		{
			return DelegateSupport.ConvertDelegate<EnumWindowsProc>((System.Delegate)P_0);
		}

		public static EnumWindowsProc operator +(EnumWindowsProc P_0, EnumWindowsProc P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<EnumWindowsProc>();
		}

		public static EnumWindowsProc operator -(EnumWindowsProc P_0, EnumWindowsProc P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<EnumWindowsProc>();
			}
			return (EnumWindowsProc)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_BL;

	private static readonly System.IntPtr NativeFieldInfoPtr_FIRST_DELAY_MS;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERVAL_MS;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWork;

	private static readonly System.IntPtr NativeFieldInfoPtr__enumCb;

	private static readonly System.IntPtr NativeFieldInfoPtr__windowTitles;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDetect;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Worker_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanProcesses_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumWindows_Private_Static_Boolean_EnumWindowsProc_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWindowText_Private_Static_Int32_IntPtr_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWindowVisible_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumWindowsCallback_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckProcess_Public_Static_Boolean_0;

	public unsafe static List<string> BL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BL, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BL, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int FIRST_DELAY_MS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FIRST_DELAY_MS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FIRST_DELAY_MS, (void*)(&num));
		}
	}

	public unsafe static int INTERVAL_MS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERVAL_MS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERVAL_MS, (void*)(&num));
		}
	}

	public unsafe static bool isWork
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isWork, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isWork, (void*)(&flag));
		}
	}

	public unsafe static EnumWindowsProc _enumCb
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__enumCb, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumWindowsProc>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__enumCb, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumWindowsProc));
		}
	}

	public unsafe static List<string> _windowTitles
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__windowTitles, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__windowTitles, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static string isDetect
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isDetect, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isDetect, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static HackProcessDetectorV2()
	{
		Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HackProcessDetectorV2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr);
		NativeFieldInfoPtr_BL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "BL");
		NativeFieldInfoPtr_FIRST_DELAY_MS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "FIRST_DELAY_MS");
		NativeFieldInfoPtr_INTERVAL_MS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "INTERVAL_MS");
		NativeFieldInfoPtr_isWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "isWork");
		NativeFieldInfoPtr__enumCb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "_enumCb");
		NativeFieldInfoPtr__windowTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "_windowTitles");
		NativeFieldInfoPtr_isDetect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, "isDetect");
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664336);
		NativeMethodInfoPtr_Worker_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664337);
		NativeMethodInfoPtr_ScanProcesses_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664338);
		NativeMethodInfoPtr_EnumWindows_Private_Static_Boolean_EnumWindowsProc_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664339);
		NativeMethodInfoPtr_GetWindowText_Private_Static_Int32_IntPtr_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664340);
		NativeMethodInfoPtr_IsWindowVisible_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664341);
		NativeMethodInfoPtr_EnumWindowsCallback_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664342);
		NativeMethodInfoPtr_CheckProcess_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetectorV2>.NativeClassPtr, 100664343);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51077, RefRangeEnd = 51078, XrefRangeStart = 51054, XrefRangeEnd = 51077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51078, XrefRangeEnd = 51091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Worker()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Worker_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51096, RefRangeEnd = 51097, XrefRangeStart = 51091, XrefRangeEnd = 51096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ScanProcesses()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanProcesses_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51097, XrefRangeEnd = 51101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EnumWindows(EnumWindowsProc lpEnumFunc, System.IntPtr lParam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpEnumFunc);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lParam;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumWindows_Private_Static_Boolean_EnumWindowsProc_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51101, XrefRangeEnd = 51107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetWindowText(System.IntPtr hWnd, StringBuilder lpString, int nMaxCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hWnd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lpString);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxCount;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWindowText_Private_Static_Int32_IntPtr_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51107, XrefRangeEnd = 51109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWindowVisible(System.IntPtr hWnd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hWnd);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWindowVisible_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51109, XrefRangeEnd = 51135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EnumWindowsCallback(System.IntPtr hWnd, System.IntPtr lParam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hWnd);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lParam;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnumWindowsCallback_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51175, RefRangeEnd = 51176, XrefRangeStart = 51135, XrefRangeEnd = 51175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckProcess()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckProcess_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public HackProcessDetectorV2(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
