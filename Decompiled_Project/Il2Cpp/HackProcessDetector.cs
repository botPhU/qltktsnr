using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Il2Cpp;

public static class HackProcessDetector : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
	public sealed class PROCESSENTRY32 : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dwSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_cntUsage;

		private static readonly System.IntPtr NativeFieldInfoPtr_th32ProcessID;

		private static readonly System.IntPtr NativeFieldInfoPtr_th32DefaultHeapID;

		private static readonly System.IntPtr NativeFieldInfoPtr_th32ModuleID;

		private static readonly System.IntPtr NativeFieldInfoPtr_cntThreads;

		private static readonly System.IntPtr NativeFieldInfoPtr_th32ParentProcessID;

		private static readonly System.IntPtr NativeFieldInfoPtr_pcPriClassBase;

		private static readonly System.IntPtr NativeFieldInfoPtr_dwFlags;

		private static readonly System.IntPtr NativeFieldInfoPtr_szExeFile;

		public unsafe uint dwSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwSize);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwSize)) = num;
			}
		}

		public unsafe uint cntUsage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cntUsage);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cntUsage)) = num;
			}
		}

		public unsafe uint th32ProcessID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32ProcessID);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32ProcessID)) = num;
			}
		}

		public unsafe System.IntPtr th32DefaultHeapID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32DefaultHeapID);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32DefaultHeapID)) = intPtr;
			}
		}

		public unsafe uint th32ModuleID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32ModuleID);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32ModuleID)) = num;
			}
		}

		public unsafe uint cntThreads
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cntThreads);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cntThreads)) = num;
			}
		}

		public unsafe uint th32ParentProcessID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32ParentProcessID);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_th32ParentProcessID)) = num;
			}
		}

		public unsafe int pcPriClassBase
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pcPriClassBase);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pcPriClassBase)) = num;
			}
		}

		public unsafe uint dwFlags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFlags);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dwFlags)) = num;
			}
		}

		public unsafe string szExeFile
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_szExeFile);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_szExeFile)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		static PROCESSENTRY32()
		{
			Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "PROCESSENTRY32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr);
			NativeFieldInfoPtr_dwSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "dwSize");
			NativeFieldInfoPtr_cntUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "cntUsage");
			NativeFieldInfoPtr_th32ProcessID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "th32ProcessID");
			NativeFieldInfoPtr_th32DefaultHeapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "th32DefaultHeapID");
			NativeFieldInfoPtr_th32ModuleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "th32ModuleID");
			NativeFieldInfoPtr_cntThreads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "cntThreads");
			NativeFieldInfoPtr_th32ParentProcessID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "th32ParentProcessID");
			NativeFieldInfoPtr_pcPriClassBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "pcPriClassBase");
			NativeFieldInfoPtr_dwFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "dwFlags");
			NativeFieldInfoPtr_szExeFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr, "szExeFile");
		}

		public PROCESSENTRY32(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public PROCESSENTRY32()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PROCESSENTRY32>.NativeClassPtr))
		{
		}
	}

	public sealed class EnumWindowsProc : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;

		static EnumWindowsProc()
		{
			Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "EnumWindowsProc");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664332);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664333);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664334);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumWindowsProc>.NativeClassPtr, 100664335);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50856, XrefRangeEnd = 50859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50859, XrefRangeEnd = 50865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50865, XrefRangeEnd = 50867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	private static readonly System.IntPtr NativeFieldInfoPtr_HEX_B64;

	private static readonly System.IntPtr NativeFieldInfoPtr_BL;

	private static readonly System.IntPtr NativeFieldInfoPtr_SNAP_PROC;

	private static readonly System.IntPtr NativeFieldInfoPtr_FIRST_DELAY_MS;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERVAL_MS;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWork;

	private static readonly System.IntPtr NativeFieldInfoPtr__enumCb;

	private static readonly System.IntPtr NativeFieldInfoPtr__windowTitles;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateToolhelp32Snapshot_Private_Static_IntPtr_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Process32First_Private_Static_Boolean_IntPtr_byref_PROCESSENTRY32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Process32Next_Private_Static_Boolean_IntPtr_byref_PROCESSENTRY32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseHandle_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Worker_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanProcesses_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumWindows_Private_Static_Boolean_EnumWindowsProc_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWindowText_Private_Static_Int32_IntPtr_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWindowVisible_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumWindowsCallback_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckProcess_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexToBytes_Private_Static_Il2CppStructArray_1_Byte_String_0;

	public unsafe static Il2CppStringArray HEX_B64
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HEX_B64, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HEX_B64, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static HashSet<string> BL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BL, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BL, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashSet));
		}
	}

	public unsafe static uint SNAP_PROC
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SNAP_PROC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SNAP_PROC, (void*)(&num));
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

	static HackProcessDetector()
	{
		Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "HackProcessDetector");
		NativeFieldInfoPtr_HEX_B64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "HEX_B64");
		NativeFieldInfoPtr_BL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "BL");
		NativeFieldInfoPtr_SNAP_PROC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "SNAP_PROC");
		NativeFieldInfoPtr_FIRST_DELAY_MS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "FIRST_DELAY_MS");
		NativeFieldInfoPtr_INTERVAL_MS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "INTERVAL_MS");
		NativeFieldInfoPtr_isWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "isWork");
		NativeFieldInfoPtr__enumCb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "_enumCb");
		NativeFieldInfoPtr__windowTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, "_windowTitles");
		NativeMethodInfoPtr_CreateToolhelp32Snapshot_Private_Static_IntPtr_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664318);
		NativeMethodInfoPtr_Process32First_Private_Static_Boolean_IntPtr_byref_PROCESSENTRY32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_Process32Next_Private_Static_Boolean_IntPtr_byref_PROCESSENTRY32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr_CloseHandle_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_Worker_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_ScanProcesses_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_EnumWindows_Private_Static_Boolean_EnumWindowsProc_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr_GetWindowText_Private_Static_Int32_IntPtr_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664327);
		NativeMethodInfoPtr_IsWindowVisible_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664328);
		NativeMethodInfoPtr_EnumWindowsCallback_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664329);
		NativeMethodInfoPtr_CheckProcess_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr_HexToBytes_Private_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HackProcessDetector>.NativeClassPtr, 100664331);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50867, XrefRangeEnd = 50869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateToolhelp32Snapshot(uint dwFlags, uint th32ProcessId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dwFlags);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &th32ProcessId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateToolhelp32Snapshot_Private_Static_IntPtr_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50869, XrefRangeEnd = 50877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Process32First(System.IntPtr hSnapshot, ref PROCESSENTRY32 lppe)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hSnapshot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lppe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process32First_Private_Static_Boolean_IntPtr_byref_PROCESSENTRY32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50877, XrefRangeEnd = 50885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Process32Next(System.IntPtr hSnapshot, ref PROCESSENTRY32 lppe)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hSnapshot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lppe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Process32Next_Private_Static_Boolean_IntPtr_byref_PROCESSENTRY32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50885, XrefRangeEnd = 50887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CloseHandle(System.IntPtr hObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hObject);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseHandle_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50935, RefRangeEnd = 50936, XrefRangeStart = 50887, XrefRangeEnd = 50935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50936, XrefRangeEnd = 50949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Worker()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Worker_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50954, RefRangeEnd = 50955, XrefRangeStart = 50949, XrefRangeEnd = 50954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ScanProcesses()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanProcesses_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50955, XrefRangeEnd = 50959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50959, XrefRangeEnd = 50965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50965, XrefRangeEnd = 50967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50967, XrefRangeEnd = 50993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 51037, RefRangeEnd = 51038, XrefRangeStart = 50993, XrefRangeEnd = 51037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckProcess()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckProcess_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51047, RefRangeEnd = 51048, XrefRangeStart = 51038, XrefRangeEnd = 51047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> HexToBytes(string h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(h);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexToBytes_Private_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	public HackProcessDetector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
