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

public class AutoTrain : Il2CppSystem.Object
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

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumMPGoHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMPPercentGoHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_listMobIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeAddNewMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeTeleportToMob;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInstance_Public_Static_AutoTrain_0;

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

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSkill_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTimeSkill_Public_Static_Int64_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoIt_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Ak_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AkChar_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AkMob_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseGrape_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AutoTrain _Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoTrain>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoTrain));
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

	static AutoTrain()
	{
		Il2CppClassPointerStore<AutoTrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.Assembly_CSharp.HSNR", "AutoTrain");
		NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "_Instance");
		NativeFieldInfoPtr_isAvoidSuperMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "isAvoidSuperMob");
		NativeFieldInfoPtr_isGoBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "isGoBack");
		NativeFieldInfoPtr_isGobackCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "isGobackCoordinate");
		NativeFieldInfoPtr_currTimeAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "currTimeAK");
		NativeFieldInfoPtr_gobackX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "gobackX");
		NativeFieldInfoPtr_gobackY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "gobackY");
		NativeFieldInfoPtr_gobackMapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "gobackMapID");
		NativeFieldInfoPtr_gobackZoneID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "gobackZoneID");
		NativeFieldInfoPtr_isAutoTrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "isAutoTrain");
		NativeFieldInfoPtr_minimumMPGoHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "minimumMPGoHome");
		NativeFieldInfoPtr_inputMPPercentGoHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "inputMPPercentGoHome");
		NativeFieldInfoPtr_listMobIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "listMobIds");
		NativeFieldInfoPtr_lastTimeAddNewMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "lastTimeAddNewMob");
		NativeFieldInfoPtr_lastTimeTeleportToMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "lastTimeTeleportToMob");
		NativeMethodInfoPtr_getInstance_Public_Static_AutoTrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667184);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667185);
		NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667186);
		NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667187);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667188);
		NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667189);
		NativeMethodInfoPtr_ShowMenuGoback_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667190);
		NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667191);
		NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667192);
		NativeMethodInfoPtr_isMeCanAttack_Private_Static_Boolean_Mob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667193);
		NativeMethodInfoPtr_isMeOutOfMP_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667194);
		NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667195);
		NativeMethodInfoPtr_getSkill_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667196);
		NativeMethodInfoPtr_getTimeSkill_Public_Static_Int64_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667197);
		NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667198);
		NativeMethodInfoPtr_DoIt_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667200);
		NativeMethodInfoPtr_Ak_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667201);
		NativeMethodInfoPtr_AkChar_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667202);
		NativeMethodInfoPtr_AkMob_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667203);
		NativeMethodInfoPtr_UseGrape_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667204);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100667205);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 129013, RefRangeEnd = 129024, XrefRangeStart = 128999, XrefRangeEnd = 129013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AutoTrain getInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInstance_Public_Static_AutoTrain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoTrain>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129024, XrefRangeEnd = 129145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129145, XrefRangeEnd = 129182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129182, XrefRangeEnd = 129258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129258, XrefRangeEnd = 129418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129418, XrefRangeEnd = 129516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenuGoback()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenuGoback_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129516, XrefRangeEnd = 129527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetChatTextField()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 129530, RefRangeEnd = 129538, XrefRangeStart = 129527, XrefRangeEnd = 129530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 129547, RefRangeEnd = 129549, XrefRangeStart = 129538, XrefRangeEnd = 129547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMeOutOfMP()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeOutOfMP_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 129574, RefRangeEnd = 129576, XrefRangeStart = 129549, XrefRangeEnd = 129574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129576, XrefRangeEnd = 129587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 129596, RefRangeEnd = 129597, XrefRangeStart = 129587, XrefRangeEnd = 129596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TurnOnAutoTrain()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129823, RefRangeEnd = 129824, XrefRangeStart = 129597, XrefRangeEnd = 129823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoIt()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoIt_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129824, XrefRangeEnd = 129928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Ak()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Ak_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129948, RefRangeEnd = 129949, XrefRangeStart = 129928, XrefRangeEnd = 129948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AkChar()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AkChar_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129969, RefRangeEnd = 129970, XrefRangeStart = 129949, XrefRangeEnd = 129969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AkMob()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AkMob_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 129990, RefRangeEnd = 129991, XrefRangeStart = 129970, XrefRangeEnd = 129990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseGrape()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseGrape_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoTrain()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AutoTrain(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
