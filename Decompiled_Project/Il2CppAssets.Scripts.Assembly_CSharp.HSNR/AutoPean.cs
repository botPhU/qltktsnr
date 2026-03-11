using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.Assembly_CSharp.HSNR;

public class AutoPean : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoRequestPean;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoBuffPean;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeRequestedPean;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoDonatePean;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoHarvestPean;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumHPPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumMPPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSaveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputHPPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMPPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMP;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInstance_Public_Static_AutoPean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updatePetPean_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveData_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestPean_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DonatePean_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HarvestPean_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoUsePean_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MyHPPercent_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MyMPPercent_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMyHPLowerThan_Private_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMyMPLowerThan_Private_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AutoPean _Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoPean>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoPean));
		}
	}

	public unsafe static bool isAutoRequestPean
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoRequestPean, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoRequestPean, (void*)(&flag));
		}
	}

	public unsafe static bool isAutoBuffPean
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoBuffPean, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoBuffPean, (void*)(&flag));
		}
	}

	public unsafe static long lastTimeRequestedPean
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeRequestedPean, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeRequestedPean, (void*)(&num));
		}
	}

	public unsafe static bool isAutoDonatePean
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoDonatePean, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoDonatePean, (void*)(&flag));
		}
	}

	public unsafe static bool isAutoHarvestPean
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoHarvestPean, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoHarvestPean, (void*)(&flag));
		}
	}

	public unsafe static int minimumHPPercent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minimumHPPercent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minimumHPPercent, (void*)(&num));
		}
	}

	public unsafe static int minimumMPPercent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minimumMPPercent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minimumMPPercent, (void*)(&num));
		}
	}

	public unsafe static int minimumHP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minimumHP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minimumHP, (void*)(&num));
		}
	}

	public unsafe static int minimumMP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minimumMP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minimumMP, (void*)(&num));
		}
	}

	public unsafe static bool isSaveData
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isSaveData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isSaveData, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStringArray inputHPPercent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputHPPercent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputHPPercent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray inputMPPercent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputMPPercent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputMPPercent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray inputHP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputHP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputHP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray inputMP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputMP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputMP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static AutoPean()
	{
		Il2CppClassPointerStore<AutoPean>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.Assembly_CSharp.HSNR", "AutoPean");
		NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "_Instance");
		NativeFieldInfoPtr_isAutoRequestPean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "isAutoRequestPean");
		NativeFieldInfoPtr_isAutoBuffPean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "isAutoBuffPean");
		NativeFieldInfoPtr_lastTimeRequestedPean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "lastTimeRequestedPean");
		NativeFieldInfoPtr_isAutoDonatePean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "isAutoDonatePean");
		NativeFieldInfoPtr_isAutoHarvestPean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "isAutoHarvestPean");
		NativeFieldInfoPtr_minimumHPPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "minimumHPPercent");
		NativeFieldInfoPtr_minimumMPPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "minimumMPPercent");
		NativeFieldInfoPtr_minimumHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "minimumHP");
		NativeFieldInfoPtr_minimumMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "minimumMP");
		NativeFieldInfoPtr_isSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "isSaveData");
		NativeFieldInfoPtr_inputHPPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "inputHPPercent");
		NativeFieldInfoPtr_inputMPPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "inputMPPercent");
		NativeFieldInfoPtr_inputHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "inputHP");
		NativeFieldInfoPtr_inputMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, "inputMP");
		NativeMethodInfoPtr_getInstance_Public_Static_AutoPean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667119);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667120);
		NativeMethodInfoPtr_updatePetPean_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667121);
		NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667122);
		NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667123);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667124);
		NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667125);
		NativeMethodInfoPtr_LoadData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667126);
		NativeMethodInfoPtr_SaveData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667127);
		NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667128);
		NativeMethodInfoPtr_RequestPean_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667129);
		NativeMethodInfoPtr_DonatePean_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667130);
		NativeMethodInfoPtr_HarvestPean_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667131);
		NativeMethodInfoPtr_AutoUsePean_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667132);
		NativeMethodInfoPtr_MyHPPercent_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667133);
		NativeMethodInfoPtr_MyMPPercent_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667134);
		NativeMethodInfoPtr_isMyHPLowerThan_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667135);
		NativeMethodInfoPtr_isMyMPLowerThan_Private_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667136);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPean>.NativeClassPtr, 100667138);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 126773, RefRangeEnd = 126782, XrefRangeStart = 126759, XrefRangeEnd = 126773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AutoPean getInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInstance_Public_Static_AutoPean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoPean>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126851, RefRangeEnd = 126852, XrefRangeStart = 126782, XrefRangeEnd = 126851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 126880, RefRangeEnd = 126881, XrefRangeStart = 126852, XrefRangeEnd = 126880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updatePetPean()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updatePetPean_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126881, XrefRangeEnd = 127018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onChatFromMe(string text, string to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(to);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127018, XrefRangeEnd = 127021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onCancelChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127021, XrefRangeEnd = 127063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127192, RefRangeEnd = 127193, XrefRangeStart = 127063, XrefRangeEnd = 127192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127265, RefRangeEnd = 127266, XrefRangeStart = 127193, XrefRangeEnd = 127265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127266, XrefRangeEnd = 127305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveData_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127305, XrefRangeEnd = 127316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetChatTextField()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127316, XrefRangeEnd = 127337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestPean()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestPean_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127337, XrefRangeEnd = 127358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DonatePean()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DonatePean_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127415, RefRangeEnd = 127416, XrefRangeStart = 127358, XrefRangeEnd = 127415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HarvestPean()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HarvestPean_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127460, RefRangeEnd = 127461, XrefRangeStart = 127416, XrefRangeEnd = 127460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AutoUsePean()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoUsePean_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127461, XrefRangeEnd = 127466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MyHPPercent()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MyHPPercent_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127466, XrefRangeEnd = 127471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MyMPPercent()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MyMPPercent_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127471, XrefRangeEnd = 127486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMyHPLowerThan(int minHP, int minHPPercent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minHP);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minHPPercent;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMyHPLowerThan_Private_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127486, XrefRangeEnd = 127501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMyMPLowerThan(int minMP, int minMPPercent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minMP);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minMPPercent;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMyMPLowerThan_Private_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoPean()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoPean>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AutoPean(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
