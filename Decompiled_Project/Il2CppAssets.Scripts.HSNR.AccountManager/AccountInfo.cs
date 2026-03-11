using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.HSNR.AccountManager;

public class AccountInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_username;

	private static readonly System.IntPtr NativeFieldInfoPtr_password;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkCPU;

	private static readonly System.IntPtr NativeFieldInfoPtr_myAccount;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoAccount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoadAccount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLogin;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastOpenGame;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isLowCPU_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_canGetAccount_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadAccount_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Login_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_mScreen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_turnONLowCPU_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_turnONHIGHCPU_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string username
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_username);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_username)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string password
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int indexServer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexServer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexServer)) = num;
		}
	}

	public unsafe string checkCPU
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkCPU);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkCPU)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static AccountInfo myAccount
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_myAccount, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccountInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_myAccount, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accountInfo));
		}
	}

	public unsafe static Il2CppStringArray infoAccount
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_infoAccount, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_infoAccount, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool isLoadAccount
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoadAccount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoadAccount, (void*)(&flag));
		}
	}

	public unsafe static bool isLogin
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLogin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLogin, (void*)(&flag));
		}
	}

	public unsafe static int status
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_status, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_status, (void*)(&num));
		}
	}

	public unsafe static long lastOpenGame
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastOpenGame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastOpenGame, (void*)(&num));
		}
	}

	public unsafe bool isLowCPU
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133810, XrefRangeEnd = 133813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isLowCPU_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static AccountInfo()
	{
		Il2CppClassPointerStore<AccountInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.HSNR.AccountManager", "AccountInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "id");
		NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "username");
		NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "password");
		NativeFieldInfoPtr_indexServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "indexServer");
		NativeFieldInfoPtr_checkCPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "checkCPU");
		NativeFieldInfoPtr_myAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "myAccount");
		NativeFieldInfoPtr_infoAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "infoAccount");
		NativeFieldInfoPtr_isLoadAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "isLoadAccount");
		NativeFieldInfoPtr_isLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "isLogin");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "status");
		NativeFieldInfoPtr_lastOpenGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, "lastOpenGame");
		NativeMethodInfoPtr_get_isLowCPU_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667312);
		NativeMethodInfoPtr_canGetAccount_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667313);
		NativeMethodInfoPtr_loadAccount_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667314);
		NativeMethodInfoPtr_Login_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667315);
		NativeMethodInfoPtr_update_Public_Static_Void_mScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667316);
		NativeMethodInfoPtr_turnONLowCPU_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667317);
		NativeMethodInfoPtr_turnONHIGHCPU_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667318);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr, 100667319);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 133818, RefRangeEnd = 133821, XrefRangeStart = 133813, XrefRangeEnd = 133818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool canGetAccount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_canGetAccount_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133873, RefRangeEnd = 133874, XrefRangeStart = 133821, XrefRangeEnd = 133873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadAccount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadAccount_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133902, RefRangeEnd = 133903, XrefRangeStart = 133874, XrefRangeEnd = 133902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Login()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Login_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 133935, RefRangeEnd = 133936, XrefRangeStart = 133903, XrefRangeEnd = 133935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update(mScreen screen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)screen);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_mScreen_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133936, XrefRangeEnd = 133955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void turnONLowCPU()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_turnONLowCPU_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133955, XrefRangeEnd = 133966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void turnONHIGHCPU()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_turnONHIGHCPU_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AccountInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccountInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AccountInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
