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

public class AutoSkill : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoadKeySkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoSendAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeSendAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTrainPet;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPetAskedForUseSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoUseSkills;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeUseSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeAutoSkills;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexSkillAuto;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoChangeFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_cooldownAutoChangeFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeChangeFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_listTargetAutoChangeFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoShield;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSaveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeAutoUseSkill;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInstance_Public_Static_AutoSkill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAK_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenuAutoSkill_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_smethod_6_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadKeySkills_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoSendAttack_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSkillAttack_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoSkillForPet_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoUseSkill_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMeCanAttackChar_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMeHasEnoughMP_Private_Static_Boolean_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAttackToCharFocus_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendAttackToMobFocus_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCoolDown_Private_Static_Int64_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMySkillIndex_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AutoChangeFocus_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCooldownAutoChangeFocus_Private_Static_Int64_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_smethod_0_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreezeSelectedSkill_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AutoSkill _Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoSkill>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoSkill));
		}
	}

	public unsafe static bool isLoadKeySkill
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoadKeySkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoadKeySkill, (void*)(&flag));
		}
	}

	public unsafe static byte isAutoSendAttack
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoSendAttack, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoSendAttack, (void*)(&b));
		}
	}

	public unsafe static Il2CppStructArray<long> lastTimeSendAttack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeSendAttack, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeSendAttack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool isTrainPet
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTrainPet, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTrainPet, (void*)(&flag));
		}
	}

	public unsafe static bool isPetAskedForUseSkill
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPetAskedForUseSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPetAskedForUseSkill, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStructArray<bool> isAutoUseSkills
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoUseSkills, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoUseSkills, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<long> lastTimeUseSkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeUseSkill, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeUseSkill, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<long> timeAutoSkills
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeAutoSkills, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeAutoSkills, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int indexSkillAuto
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexSkillAuto, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexSkillAuto, (void*)(&num));
		}
	}

	public unsafe static bool isAutoChangeFocus
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoChangeFocus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoChangeFocus, (void*)(&flag));
		}
	}

	public unsafe static long cooldownAutoChangeFocus
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cooldownAutoChangeFocus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cooldownAutoChangeFocus, (void*)(&num));
		}
	}

	public unsafe static long lastTimeChangeFocus
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeChangeFocus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeChangeFocus, (void*)(&num));
		}
	}

	public unsafe static List<Il2Cpp.Char> listTargetAutoChangeFocus
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listTargetAutoChangeFocus, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2Cpp.Char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listTargetAutoChangeFocus, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static int targetIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_targetIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_targetIndex, (void*)(&num));
		}
	}

	public unsafe static bool isAutoShield
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoShield, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoShield, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStringArray inputDelay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputDelay, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputDelay, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
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

	public unsafe static long lastTimeAutoUseSkill
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeAutoUseSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeAutoUseSkill, (void*)(&num));
		}
	}

	static AutoSkill()
	{
		Il2CppClassPointerStore<AutoSkill>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.Assembly_CSharp.HSNR", "AutoSkill");
		NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "_Instance");
		NativeFieldInfoPtr_isLoadKeySkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isLoadKeySkill");
		NativeFieldInfoPtr_isAutoSendAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isAutoSendAttack");
		NativeFieldInfoPtr_lastTimeSendAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "lastTimeSendAttack");
		NativeFieldInfoPtr_isTrainPet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isTrainPet");
		NativeFieldInfoPtr_isPetAskedForUseSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isPetAskedForUseSkill");
		NativeFieldInfoPtr_isAutoUseSkills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isAutoUseSkills");
		NativeFieldInfoPtr_lastTimeUseSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "lastTimeUseSkill");
		NativeFieldInfoPtr_timeAutoSkills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "timeAutoSkills");
		NativeFieldInfoPtr_indexSkillAuto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "indexSkillAuto");
		NativeFieldInfoPtr_isAutoChangeFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isAutoChangeFocus");
		NativeFieldInfoPtr_cooldownAutoChangeFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "cooldownAutoChangeFocus");
		NativeFieldInfoPtr_lastTimeChangeFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "lastTimeChangeFocus");
		NativeFieldInfoPtr_listTargetAutoChangeFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "listTargetAutoChangeFocus");
		NativeFieldInfoPtr_targetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "targetIndex");
		NativeFieldInfoPtr_isAutoShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isAutoShield");
		NativeFieldInfoPtr_inputDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "inputDelay");
		NativeFieldInfoPtr_isSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "isSaveData");
		NativeFieldInfoPtr_lastTimeAutoUseSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, "lastTimeAutoUseSkill");
		NativeMethodInfoPtr_getInstance_Public_Static_AutoSkill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667156);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667157);
		NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667158);
		NativeMethodInfoPtr_setAK_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667159);
		NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667160);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667161);
		NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667162);
		NativeMethodInfoPtr_ShowMenuAutoSkill_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667163);
		NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667164);
		NativeMethodInfoPtr_LoadData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667165);
		NativeMethodInfoPtr_smethod_6_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667166);
		NativeMethodInfoPtr_LoadKeySkills_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667167);
		NativeMethodInfoPtr_AutoSendAttack_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667168);
		NativeMethodInfoPtr_getSkillAttack_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667169);
		NativeMethodInfoPtr_AutoSkillForPet_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667170);
		NativeMethodInfoPtr_AutoUseSkill_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667171);
		NativeMethodInfoPtr_isMeCanAttackChar_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667172);
		NativeMethodInfoPtr_isMeHasEnoughMP_Private_Static_Boolean_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667173);
		NativeMethodInfoPtr_SendAttackToCharFocus_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667174);
		NativeMethodInfoPtr_SendAttackToMobFocus_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667175);
		NativeMethodInfoPtr_GetCoolDown_Private_Static_Int64_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667176);
		NativeMethodInfoPtr_GetMySkillIndex_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667177);
		NativeMethodInfoPtr_AutoChangeFocus_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667178);
		NativeMethodInfoPtr_GetCooldownAutoChangeFocus_Private_Static_Int64_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667179);
		NativeMethodInfoPtr_smethod_0_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667180);
		NativeMethodInfoPtr_FreezeSelectedSkill_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667182);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr, 100667183);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 128030, RefRangeEnd = 128041, XrefRangeStart = 128016, XrefRangeEnd = 128030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AutoSkill getInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInstance_Public_Static_AutoSkill_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoSkill>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128083, RefRangeEnd = 128084, XrefRangeStart = 128041, XrefRangeEnd = 128083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128084, XrefRangeEnd = 128134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128134, XrefRangeEnd = 128157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setAK()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAK_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128269, RefRangeEnd = 128270, XrefRangeStart = 128157, XrefRangeEnd = 128269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 128357, RefRangeEnd = 128358, XrefRangeStart = 128270, XrefRangeEnd = 128357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128358, XrefRangeEnd = 128419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenuAutoSkill(int skillIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenuAutoSkill_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128419, XrefRangeEnd = 128430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetChatTextField()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void smethod_6()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_smethod_6_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128450, RefRangeEnd = 128451, XrefRangeStart = 128430, XrefRangeEnd = 128450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadKeySkills()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadKeySkills_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128580, RefRangeEnd = 128581, XrefRangeStart = 128451, XrefRangeEnd = 128580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AutoSendAttack()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoSendAttack_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128641, RefRangeEnd = 128642, XrefRangeStart = 128581, XrefRangeEnd = 128641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getSkillAttack()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSkillAttack_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128705, RefRangeEnd = 128706, XrefRangeStart = 128642, XrefRangeEnd = 128705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AutoSkillForPet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoSkillForPet_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128789, RefRangeEnd = 128790, XrefRangeStart = 128706, XrefRangeEnd = 128789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AutoUseSkill(int skillIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoUseSkill_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 128828, RefRangeEnd = 128831, XrefRangeStart = 128790, XrefRangeEnd = 128828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMeCanAttackChar(Il2Cpp.Char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeCanAttackChar_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128831, XrefRangeEnd = 128836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMeHasEnoughMP(Skill skillToUse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillToUse);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeHasEnoughMP_Private_Static_Boolean_Skill_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 128854, RefRangeEnd = 128856, XrefRangeStart = 128836, XrefRangeEnd = 128854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendAttackToCharFocus()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAttackToCharFocus_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 128874, RefRangeEnd = 128876, XrefRangeStart = 128856, XrefRangeEnd = 128874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendAttackToMobFocus()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendAttackToMobFocus_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long GetCoolDown(Skill skill)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCoolDown_Private_Static_Int64_Skill_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 128887, RefRangeEnd = 128890, XrefRangeStart = 128876, XrefRangeEnd = 128887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMySkillIndex()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMySkillIndex_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128981, RefRangeEnd = 128982, XrefRangeStart = 128890, XrefRangeEnd = 128981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AutoChangeFocus()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoChangeFocus_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static long GetCooldownAutoChangeFocus(Skill skill)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCooldownAutoChangeFocus_Private_Static_Int64_Skill_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void smethod_0()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_smethod_0_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 128998, RefRangeEnd = 128999, XrefRangeStart = 128982, XrefRangeEnd = 128998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreezeSelectedSkill()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreezeSelectedSkill_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoSkill()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoSkill>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AutoSkill(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
