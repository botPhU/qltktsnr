using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class ServerListScreen : mScreen
{
	[System.Serializable]
	[ObfuscatedName("ServerListScreen+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__47_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__47_0_Internal_Void_String_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
			}
		}

		public unsafe static ActionChat __9__47_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ActionChat>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__47_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionChat));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__47_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665829);
			NativeMethodInfoPtr___ctor_b__47_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665830);
		}

		[CallerCount(707)]
		[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86919, XrefRangeEnd = 86925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__47_0(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__47_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_nameServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_address;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverPriority;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_port;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWait;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdUpdateServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_language;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdCallHotline;

	private static readonly System.IntPtr NativeFieldInfoPtr_nCmdPlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdDeleteRMS;

	private static readonly System.IntPtr NativeFieldInfoPtr_lY;

	private static readonly System.IntPtr NativeFieldInfoPtr_testIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_testIP2;

	private static readonly System.IntPtr NativeFieldInfoPtr_testMain;

	private static readonly System.IntPtr NativeFieldInfoPtr_localIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_smartPhoneVN;

	private static readonly System.IntPtr NativeFieldInfoPtr_languageVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyTouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_tam;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopDownload;

	private static readonly System.IntPtr NativeFieldInfoPtr_listgetServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkDefault;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkweb;

	private static readonly System.IntPtr NativeFieldInfoPtr_waitToLogin;

	private static readonly System.IntPtr NativeFieldInfoPtr_tWaitToLogin;

	private static readonly System.IntPtr NativeFieldInfoPtr_lengthServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_ipSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_flagServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigOk;

	private static readonly System.IntPtr NativeFieldInfoPtr_percent;

	private static readonly System.IntPtr NativeFieldInfoPtr_strWait;

	private static readonly System.IntPtr NativeFieldInfoPtr_nBig;

	private static readonly System.IntPtr NativeFieldInfoPtr_nBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_demPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGetData;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdDownload;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_p;

	private static readonly System.IntPtr NativeFieldInfoPtr_testConnect;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadScreen;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decrypt_Public_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createDeleteRMS_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initCommand_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doUpdateServer_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getServerList_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_selectServer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_processInput_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateDeleteData_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveIP_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_allServerConnected_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadIP_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_switchToMe2_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_connectOk_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_show2_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLinkDefault_Public_Void_SByte_0;

	public unsafe static Il2CppStringArray nameServer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nameServer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nameServer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray address
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_address, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_address, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static sbyte serverPriority
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverPriority, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverPriority, (void*)(&b));
		}
	}

	public unsafe static Il2CppStructArray<bool> hasConnected
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasConnected, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasConnected, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<short> port
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_port, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_port, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int selected
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_selected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_selected, (void*)(&num));
		}
	}

	public unsafe static bool isWait
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isWait, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isWait, (void*)(&flag));
		}
	}

	public unsafe static Command cmdUpdateServer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdUpdateServer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdUpdateServer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> language
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_language, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_language, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Command> cmd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Command>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Command cmdCallHotline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdCallHotline);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdCallHotline)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe int nCmdPlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nCmdPlay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nCmdPlay)) = num;
		}
	}

	public unsafe static Command cmdDeleteRMS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdDeleteRMS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdDeleteRMS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe int lY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lY)) = num;
		}
	}

	public unsafe static string testIP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_testIP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_testIP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string testIP2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_testIP2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_testIP2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string testMain
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_testMain, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_testMain, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string localIP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_localIP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_localIP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string mainIP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainIP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainIP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string smartPhoneVN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_smartPhoneVN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_smartPhoneVN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static sbyte languageVersion
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_languageVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_languageVersion, (void*)(&b));
		}
	}

	public new unsafe int keyTouch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyTouch);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyTouch)) = num;
		}
	}

	public unsafe int tam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tam);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tam)) = num;
		}
	}

	public unsafe static bool stopDownload
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stopDownload, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stopDownload, (void*)(&flag));
		}
	}

	public unsafe static string listgetServer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listgetServer, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listgetServer, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string linkDefault
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_linkDefault, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_linkDefault, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string linkweb
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_linkweb, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_linkweb, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool waitToLogin
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_waitToLogin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_waitToLogin, (void*)(&flag));
		}
	}

	public unsafe static int tWaitToLogin
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tWaitToLogin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tWaitToLogin, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> lengthServer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lengthServer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lengthServer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int ipSelect
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ipSelect, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ipSelect, (void*)(&num));
		}
	}

	public unsafe static int flagServer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flagServer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flagServer, (void*)(&num));
		}
	}

	public unsafe static bool bigOk
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigOk, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigOk, (void*)(&flag));
		}
	}

	public unsafe static int percent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_percent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_percent, (void*)(&num));
		}
	}

	public unsafe static string strWait
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_strWait, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_strWait, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int nBig
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nBig, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nBig, (void*)(&num));
		}
	}

	public unsafe static int nBg
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nBg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nBg, (void*)(&num));
		}
	}

	public unsafe static int demPercent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_demPercent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_demPercent, (void*)(&num));
		}
	}

	public unsafe static int maxBg
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxBg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxBg, (void*)(&num));
		}
	}

	public unsafe static bool isGetData
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isGetData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isGetData, (void*)(&flag));
		}
	}

	public unsafe static Command cmdDownload
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdDownload, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdDownload, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdStart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdStart)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe string dataSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSize);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataSize)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int p
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_p, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_p, (void*)(&num));
		}
	}

	public unsafe static int testConnect
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_testConnect, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_testConnect, (void*)(&num));
		}
	}

	public unsafe static bool loadScreen
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_loadScreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_loadScreen, (void*)(&flag));
		}
	}

	static ServerListScreen()
	{
		Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ServerListScreen");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr);
		NativeFieldInfoPtr_nameServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "nameServer");
		NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "address");
		NativeFieldInfoPtr_serverPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "serverPriority");
		NativeFieldInfoPtr_hasConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "hasConnected");
		NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "port");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "selected");
		NativeFieldInfoPtr_isWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "isWait");
		NativeFieldInfoPtr_cmdUpdateServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "cmdUpdateServer");
		NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "language");
		NativeFieldInfoPtr_cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "cmd");
		NativeFieldInfoPtr_cmdCallHotline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "cmdCallHotline");
		NativeFieldInfoPtr_nCmdPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "nCmdPlay");
		NativeFieldInfoPtr_cmdDeleteRMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "cmdDeleteRMS");
		NativeFieldInfoPtr_lY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "lY");
		NativeFieldInfoPtr_testIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "testIP");
		NativeFieldInfoPtr_testIP2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "testIP2");
		NativeFieldInfoPtr_testMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "testMain");
		NativeFieldInfoPtr_localIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "localIP");
		NativeFieldInfoPtr_mainIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "mainIP");
		NativeFieldInfoPtr_smartPhoneVN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "smartPhoneVN");
		NativeFieldInfoPtr_languageVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "languageVersion");
		NativeFieldInfoPtr_keyTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "keyTouch");
		NativeFieldInfoPtr_tam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "tam");
		NativeFieldInfoPtr_stopDownload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "stopDownload");
		NativeFieldInfoPtr_listgetServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "listgetServer");
		NativeFieldInfoPtr_linkDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "linkDefault");
		NativeFieldInfoPtr_linkweb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "linkweb");
		NativeFieldInfoPtr_waitToLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "waitToLogin");
		NativeFieldInfoPtr_tWaitToLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "tWaitToLogin");
		NativeFieldInfoPtr_lengthServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "lengthServer");
		NativeFieldInfoPtr_ipSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "ipSelect");
		NativeFieldInfoPtr_flagServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "flagServer");
		NativeFieldInfoPtr_bigOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "bigOk");
		NativeFieldInfoPtr_percent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "percent");
		NativeFieldInfoPtr_strWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "strWait");
		NativeFieldInfoPtr_nBig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "nBig");
		NativeFieldInfoPtr_nBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "nBg");
		NativeFieldInfoPtr_demPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "demPercent");
		NativeFieldInfoPtr_maxBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "maxBg");
		NativeFieldInfoPtr_isGetData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "isGetData");
		NativeFieldInfoPtr_cmdDownload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "cmdDownload");
		NativeFieldInfoPtr_cmdStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "cmdStart");
		NativeFieldInfoPtr_dataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "dataSize");
		NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "p");
		NativeFieldInfoPtr_testConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "testConnect");
		NativeFieldInfoPtr_loadScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, "loadScreen");
		NativeMethodInfoPtr_Decrypt_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665804);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665805);
		NativeMethodInfoPtr_createDeleteRMS_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665806);
		NativeMethodInfoPtr_initCommand_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665807);
		NativeMethodInfoPtr_doUpdateServer_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665808);
		NativeMethodInfoPtr_getServerList_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665809);
		NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665810);
		NativeMethodInfoPtr_selectServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665811);
		NativeMethodInfoPtr_update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_processInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_updateDeleteData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_saveIP_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_allServerConnected_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_loadIP_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_switchToMe2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_connectOk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_show2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_setLinkDefault_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr, 100665826);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86925, XrefRangeEnd = 87008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Decrypt(string encryptedText, int key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(encryptedText);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decrypt_Public_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 87087, RefRangeEnd = 87091, XrefRangeStart = 87008, XrefRangeEnd = 87087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ServerListScreen()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerListScreen>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87125, RefRangeEnd = 87126, XrefRangeStart = 87091, XrefRangeEnd = 87125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void createDeleteRMS()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createDeleteRMS_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 87259, RefRangeEnd = 87265, XrefRangeStart = 87126, XrefRangeEnd = 87259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initCommand_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 87281, RefRangeEnd = 87283, XrefRangeStart = 87265, XrefRangeEnd = 87281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void doUpdateServer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doUpdateServer_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 87381, RefRangeEnd = 87385, XrefRangeStart = 87283, XrefRangeEnd = 87381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getServerList(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getServerList_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87385, XrefRangeEnd = 87630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 87703, RefRangeEnd = 87707, XrefRangeStart = 87630, XrefRangeEnd = 87703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void selectServer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_selectServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87707, XrefRangeEnd = 87779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 87797, RefRangeEnd = 87801, XrefRangeStart = 87779, XrefRangeEnd = 87797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void processInput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_processInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87812, RefRangeEnd = 87813, XrefRangeStart = 87801, XrefRangeEnd = 87812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateDeleteData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateDeleteData_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87813, XrefRangeEnd = 87858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void updateKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87898, RefRangeEnd = 87899, XrefRangeStart = 87858, XrefRangeEnd = 87898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveIP()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveIP_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87899, XrefRangeEnd = 87903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool allServerConnected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_allServerConnected_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87987, RefRangeEnd = 87988, XrefRangeStart = 87903, XrefRangeEnd = 87987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadIP()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadIP_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87988, XrefRangeEnd = 88054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void switchToMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88054, XrefRangeEnd = 88121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void switchToMe2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_switchToMe2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void connectOk()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_connectOk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 88176, RefRangeEnd = 88179, XrefRangeStart = 88121, XrefRangeEnd = 88176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void cancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88179, XrefRangeEnd = 88649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void perform(int idAction, Il2CppSystem.Object p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 88693, RefRangeEnd = 88695, XrefRangeStart = 88649, XrefRangeEnd = 88693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88719, RefRangeEnd = 88720, XrefRangeStart = 88695, XrefRangeEnd = 88719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void show2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_show2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88720, XrefRangeEnd = 88726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setLinkDefault(sbyte language)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&language);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLinkDefault_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ServerListScreen(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
