using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAssets.Scripts.Assembly_CSharp.HSNR;

public class AutoTrainVIP : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAvoidSuperMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGoBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGobackCoordinate;

	private static readonly System.IntPtr NativeFieldInfoPtr_currTimeAK;

	private static readonly System.IntPtr NativeFieldInfoPtr_gobackX;

	private static readonly System.IntPtr NativeFieldInfoPtr_gobackY;

	private static readonly System.IntPtr NativeFieldInfoPtr_gobackMapID;

	private static readonly System.IntPtr NativeFieldInfoPtr_gobackZoneID;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoTrain;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTanSatNguoi;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumMPGoHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMPPercentGoHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_listMobIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeAddNewMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeTeleportToMob;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInstance_Public_Static_AutoTrainVIP_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenuGoback_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMeCanAttack_Private_Static_Boolean_Mob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMeOutOfMP_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextCharTarget_Private_Static_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSkill_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTimeSkill_Public_Static_Int64_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoTanSatNguoi_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoIt_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ak_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AkChar_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AkMob_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseGrape_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AutoTrainVIP _Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoTrainVIP>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoTrainVIP));
		}
	}

	public unsafe static bool isAvoidSuperMob
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAvoidSuperMob, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAvoidSuperMob, (void*)(&flag));
		}
	}

	public unsafe static bool isGoBack
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isGoBack, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isGoBack, (void*)(&flag));
		}
	}

	public unsafe static bool isGobackCoordinate
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isGobackCoordinate, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isGobackCoordinate, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStructArray<long> currTimeAK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currTimeAK, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currTimeAK, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int gobackX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gobackX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gobackX, (void*)(&num));
		}
	}

	public unsafe static int gobackY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gobackY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gobackY, (void*)(&num));
		}
	}

	public unsafe static int gobackMapID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gobackMapID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gobackMapID, (void*)(&num));
		}
	}

	public unsafe static int gobackZoneID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gobackZoneID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gobackZoneID, (void*)(&num));
		}
	}

	public unsafe static bool isAutoTrain
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoTrain, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoTrain, (void*)(&flag));
		}
	}

	public unsafe static bool isTanSatNguoi
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTanSatNguoi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTanSatNguoi, (void*)(&flag));
		}
	}

	public unsafe static int minimumMPGoHome
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minimumMPGoHome, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minimumMPGoHome, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray inputMPPercentGoHome
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputMPPercentGoHome, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputMPPercentGoHome, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static List<int> listMobIds
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listMobIds, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listMobIds, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static long lastTimeAddNewMob
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeAddNewMob, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeAddNewMob, (void*)(&num));
		}
	}

	public unsafe static long lastTimeTeleportToMob
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeTeleportToMob, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeTeleportToMob, (void*)(&num));
		}
	}

	static AutoTrainVIP()
	{
		Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.Assembly_CSharp.HSNR", "AutoTrainVIP");
		NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "_Instance");
		NativeFieldInfoPtr_isAvoidSuperMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "isAvoidSuperMob");
		NativeFieldInfoPtr_isGoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "isGoBack");
		NativeFieldInfoPtr_isGobackCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "isGobackCoordinate");
		NativeFieldInfoPtr_currTimeAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "currTimeAK");
		NativeFieldInfoPtr_gobackX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "gobackX");
		NativeFieldInfoPtr_gobackY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "gobackY");
		NativeFieldInfoPtr_gobackMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "gobackMapID");
		NativeFieldInfoPtr_gobackZoneID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "gobackZoneID");
		NativeFieldInfoPtr_isAutoTrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "isAutoTrain");
		NativeFieldInfoPtr_isTanSatNguoi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "isTanSatNguoi");
		NativeFieldInfoPtr_minimumMPGoHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "minimumMPGoHome");
		NativeFieldInfoPtr_inputMPPercentGoHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "inputMPPercentGoHome");
		NativeFieldInfoPtr_listMobIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "listMobIds");
		NativeFieldInfoPtr_lastTimeAddNewMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "lastTimeAddNewMob");
		NativeFieldInfoPtr_lastTimeTeleportToMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, "lastTimeTeleportToMob");
		NativeMethodInfoPtr_getInstance_Public_Static_AutoTrainVIP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667206);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667207);
		NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667208);
		NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667209);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667210);
		NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667211);
		NativeMethodInfoPtr_ShowMenuGoback_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667212);
		NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667213);
		NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667214);
		NativeMethodInfoPtr_isMeCanAttack_Private_Static_Boolean_Mob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667215);
		NativeMethodInfoPtr_isMeOutOfMP_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667216);
		NativeMethodInfoPtr_GetNextCharTarget_Private_Static_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667217);
		NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667218);
		NativeMethodInfoPtr_getSkill_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667219);
		NativeMethodInfoPtr_getTimeSkill_Public_Static_Int64_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667220);
		NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667221);
		NativeMethodInfoPtr_DoTanSatNguoi_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667223);
		NativeMethodInfoPtr_DoIt_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667224);
		NativeMethodInfoPtr_Ak_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667225);
		NativeMethodInfoPtr_AkChar_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667226);
		NativeMethodInfoPtr_AkMob_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667227);
		NativeMethodInfoPtr_UseGrape_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667228);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr, 100667229);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 130005, RefRangeEnd = 130017, XrefRangeStart = 129991, XrefRangeEnd = 130005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AutoTrainVIP getInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInstance_Public_Static_AutoTrainVIP_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoTrainVIP>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130150, RefRangeEnd = 130151, XrefRangeStart = 130017, XrefRangeEnd = 130150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130151, XrefRangeEnd = 130188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onCancelChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130188, XrefRangeEnd = 130265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 130438, RefRangeEnd = 130441, XrefRangeStart = 130265, XrefRangeEnd = 130438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130441, XrefRangeEnd = 130539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenuGoback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenuGoback_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130539, XrefRangeEnd = 130550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetChatTextField()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 129530, RefRangeEnd = 129538, XrefRangeStart = 129530, XrefRangeEnd = 129538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TeleportTo(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 38844, RefRangeEnd = 38851, XrefRangeStart = 38844, XrefRangeEnd = 38851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMeCanAttack(Mob mob)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeCanAttack_Private_Static_Boolean_Mob_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 130559, RefRangeEnd = 130561, XrefRangeStart = 130550, XrefRangeEnd = 130559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMeOutOfMP()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeOutOfMP_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130561, XrefRangeEnd = 130573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2Cpp.Char GetNextCharTarget()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextCharTarget_Private_Static_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2Cpp.Char>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 130598, RefRangeEnd = 130600, XrefRangeStart = 130573, XrefRangeEnd = 130598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mob GetNextMob(int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130600, XrefRangeEnd = 130611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getSkill()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSkill_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static long getTimeSkill(Skill s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTimeSkill_Public_Static_Int64_Skill_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130620, RefRangeEnd = 130621, XrefRangeStart = 130611, XrefRangeEnd = 130620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TurnOnAutoTrain()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 130784, RefRangeEnd = 130785, XrefRangeStart = 130621, XrefRangeEnd = 130784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoTanSatNguoi()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoTanSatNguoi_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131011, RefRangeEnd = 131012, XrefRangeStart = 130785, XrefRangeEnd = 131011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoIt()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoIt_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131012, XrefRangeEnd = 131116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Ak()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ak_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131136, RefRangeEnd = 131137, XrefRangeStart = 131116, XrefRangeEnd = 131136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AkChar()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AkChar_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131157, RefRangeEnd = 131158, XrefRangeStart = 131137, XrefRangeEnd = 131157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AkMob()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AkMob_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131178, RefRangeEnd = 131179, XrefRangeStart = 131158, XrefRangeEnd = 131178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseGrape()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseGrape_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoTrainVIP()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoTrainVIP>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AutoTrainVIP(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
