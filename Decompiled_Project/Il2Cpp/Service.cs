using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Service : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_session;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_curCheckController;

	private static readonly System.IntPtr NativeFieldInfoPtr_curCheckMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_logController;

	private static readonly System.IntPtr NativeFieldInfoPtr_logMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_eccAuth;

	private static readonly System.IntPtr NativeFieldInfoPtr_demGui;

	private static readonly System.IntPtr NativeFieldInfoPtr_reciveFromMainSession;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPing;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayPing;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastRequestPing;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_Service_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gotoPlayer_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_androidPack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_charInfo_Public_Void_String_String_String_String_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_androidPack2_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkAd_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_combine_Public_Void_SByte_MyVector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_giaodich_Public_Void_SByte_Int32_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendClientInput_Public_Void_Il2CppReferenceArray_1_TField_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_speacialSkill_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_test_Public_Void_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_test2_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_testJoint_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mobCapcha_Public_Void_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_friend_Public_Void_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getArchivemnt_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPlayerMenu_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clanImage_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_skill_not_focus_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clanDonate_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clanMessage_Public_Void_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_useItem_Public_Void_SByte_SByte_SByte_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_joinClan_Public_Void_Int32_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clanMember_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_searchClan_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestClan_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clanRemote_Public_Void_Int32_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_leaveClan_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clanInvite_Public_Void_SByte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getClan_Public_Void_SByte_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCaption_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getItem_Public_Void_SByte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTask_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_messageNotLogin_Public_Message_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_messageNotMap_Public_Message_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_messageSubCommand_Public_Static_Message_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setClientType_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setClientType2_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendCheckController_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendCheckMap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_login_Public_Void_String_String_String_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestRegister_Public_Void_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestChangeMap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_magicTree_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestChangeZone_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkMMove_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_charMove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_selectCharToPlay_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_selectZone_Public_Void_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createChar_Public_Void_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestModTemplate_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestNpcTemplate_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestSkill_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestItemInfo_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestItemPlayer_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upSkill_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saleItem_Public_Void_SByte_SByte_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buyItem_Public_Void_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_selectSkill_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEffData_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openUIZone_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_confirmMenu_Public_Void_Int16_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openMenu_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_menu_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_menuId_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_textBoxId_Public_Void_Int16_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestItem_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_boxSort_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_boxCoinOut_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upgradeItem_Public_Void_Item_Il2CppReferenceArray_1_Item_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_crystalCollectLock_Public_Void_Il2CppReferenceArray_1_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_acceptInviteTrade_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancelInviteTrade_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tradeAccept_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tradeItemLock_Public_Void_Int32_Il2CppReferenceArray_1_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendPlayerAttack_Public_Void_MyVector_MyVector_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pickItem_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_throwItem_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_returnTownFromDead_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_wakeUpFromDead_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chat_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clientOk_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tradeInvite_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addFriend_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addPartyAccept_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addPartyCancel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_testInvite_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addCuuSat_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addParty_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_player_vs_player_Public_Void_SByte_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestMaptemplate_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_outParty_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestPlayerInfo_Public_Void_MyVector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pleaseInputParty_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_acceptPleaseParty_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chatPlayer_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chatGlobal_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chatPrivate_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendCardInfo_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRms_Public_Void_String_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadRMS_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearTask_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_changeName_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestIcon_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doConvertUpgrade_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inviteClanDun_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inputNumSplit_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_activeAccProtect_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearAccProtect_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateActive_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openLockAccProtect_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBgTemplate_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMapOffline_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_finishUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_finishLoadMap_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getChest_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestBagImage_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBag_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBody_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_login2_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMagicTree_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upPotential_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getResource_Public_Void_SByte_MyVector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestMapSelect_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_petInfo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendTop_Public_Void_String_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_enemy_Public_Void_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_kigui_Public_Void_SByte_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFlag_Public_Void_SByte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setLockInventory_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_petStatus_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_transportNow_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_funsion_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_imageSource_Public_Void_MyVector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getQuayso_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendServerData_Public_Void_SByte_Int32_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_changeOnKeyScr_Public_Void_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestPean_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendThachDau_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_messagePlayerMenu_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playerMenuAction_Public_Void_Int32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getImgByName_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendCrackBall_Public_Void_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendRada_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendOptHat_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendDelAcc_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_new_skill_not_focus_Public_Void_SByte_SByte_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortItemBag_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestBoss_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pingToServer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendMatrixChallengeResponse_Public_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_detectHacking_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadMap_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendVoiceChat_Public_Void_Il2CppStructArray_1_Byte_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendSettingVoiceChat_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestVoiceChatId_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ISession session
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_session);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ISession>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_session)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)session));
		}
	}

	public unsafe static Service instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Service>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)service));
		}
	}

	public unsafe static long curCheckController
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curCheckController, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curCheckController, (void*)(&num));
		}
	}

	public unsafe static long curCheckMap
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curCheckMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curCheckMap, (void*)(&num));
		}
	}

	public unsafe static long logController
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logController, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logController, (void*)(&num));
		}
	}

	public unsafe static long logMap
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logMap, (void*)(&num));
		}
	}

	public unsafe static ECCAuth eccAuth
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_eccAuth, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ECCAuth>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_eccAuth, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eCCAuth));
		}
	}

	public unsafe int demGui
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demGui);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demGui)) = num;
		}
	}

	public unsafe static bool reciveFromMainSession
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reciveFromMainSession, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reciveFromMainSession, (void*)(&flag));
		}
	}

	public unsafe long lastPing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPing);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastPing)) = num;
		}
	}

	public unsafe long delayPing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayPing);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayPing)) = num;
		}
	}

	public unsafe long lastRequestPing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRequestPing);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastRequestPing)) = num;
		}
	}

	static Service()
	{
		Il2CppClassPointerStore<Service>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Service");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Service>.NativeClassPtr);
		NativeFieldInfoPtr_session = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "session");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_curCheckController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "curCheckController");
		NativeFieldInfoPtr_curCheckMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "curCheckMap");
		NativeFieldInfoPtr_logController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "logController");
		NativeFieldInfoPtr_logMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "logMap");
		NativeFieldInfoPtr_eccAuth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "eccAuth");
		NativeFieldInfoPtr_demGui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "demGui");
		NativeFieldInfoPtr_reciveFromMainSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "reciveFromMainSession");
		NativeFieldInfoPtr_lastPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "lastPing");
		NativeFieldInfoPtr_delayPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "delayPing");
		NativeFieldInfoPtr_lastRequestPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Service>.NativeClassPtr, "lastRequestPing");
		NativeMethodInfoPtr_gI_Public_Static_Service_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665837);
		NativeMethodInfoPtr_gotoPlayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665838);
		NativeMethodInfoPtr_androidPack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665839);
		NativeMethodInfoPtr_charInfo_Public_Void_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665840);
		NativeMethodInfoPtr_androidPack2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665841);
		NativeMethodInfoPtr_checkAd_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665842);
		NativeMethodInfoPtr_combine_Public_Void_SByte_MyVector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665843);
		NativeMethodInfoPtr_giaodich_Public_Void_SByte_Int32_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665844);
		NativeMethodInfoPtr_sendClientInput_Public_Void_Il2CppReferenceArray_1_TField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665845);
		NativeMethodInfoPtr_speacialSkill_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665846);
		NativeMethodInfoPtr_test_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665847);
		NativeMethodInfoPtr_test2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665848);
		NativeMethodInfoPtr_testJoint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665849);
		NativeMethodInfoPtr_mobCapcha_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665850);
		NativeMethodInfoPtr_friend_Public_Void_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665851);
		NativeMethodInfoPtr_getArchivemnt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665852);
		NativeMethodInfoPtr_getPlayerMenu_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665853);
		NativeMethodInfoPtr_clanImage_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665854);
		NativeMethodInfoPtr_skill_not_focus_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665855);
		NativeMethodInfoPtr_clanDonate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665856);
		NativeMethodInfoPtr_clanMessage_Public_Void_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665857);
		NativeMethodInfoPtr_useItem_Public_Void_SByte_SByte_SByte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665858);
		NativeMethodInfoPtr_joinClan_Public_Void_Int32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665859);
		NativeMethodInfoPtr_clanMember_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665860);
		NativeMethodInfoPtr_searchClan_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665861);
		NativeMethodInfoPtr_requestClan_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665862);
		NativeMethodInfoPtr_clanRemote_Public_Void_Int32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665863);
		NativeMethodInfoPtr_leaveClan_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665864);
		NativeMethodInfoPtr_clanInvite_Public_Void_SByte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665865);
		NativeMethodInfoPtr_getClan_Public_Void_SByte_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665866);
		NativeMethodInfoPtr_updateCaption_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665867);
		NativeMethodInfoPtr_getItem_Public_Void_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665868);
		NativeMethodInfoPtr_getTask_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665869);
		NativeMethodInfoPtr_messageNotLogin_Public_Message_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665870);
		NativeMethodInfoPtr_messageNotMap_Public_Message_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665871);
		NativeMethodInfoPtr_messageSubCommand_Public_Static_Message_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665872);
		NativeMethodInfoPtr_setClientType_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665873);
		NativeMethodInfoPtr_setClientType2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665874);
		NativeMethodInfoPtr_sendCheckController_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665875);
		NativeMethodInfoPtr_sendCheckMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665876);
		NativeMethodInfoPtr_login_Public_Void_String_String_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665877);
		NativeMethodInfoPtr_requestRegister_Public_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665878);
		NativeMethodInfoPtr_requestChangeMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665879);
		NativeMethodInfoPtr_magicTree_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665880);
		NativeMethodInfoPtr_requestChangeZone_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665881);
		NativeMethodInfoPtr_checkMMove_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665882);
		NativeMethodInfoPtr_charMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665883);
		NativeMethodInfoPtr_selectCharToPlay_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665884);
		NativeMethodInfoPtr_selectZone_Public_Void_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665885);
		NativeMethodInfoPtr_createChar_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665886);
		NativeMethodInfoPtr_requestModTemplate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665887);
		NativeMethodInfoPtr_requestNpcTemplate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665888);
		NativeMethodInfoPtr_requestSkill_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665889);
		NativeMethodInfoPtr_requestItemInfo_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665890);
		NativeMethodInfoPtr_requestItemPlayer_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665891);
		NativeMethodInfoPtr_upSkill_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665892);
		NativeMethodInfoPtr_saleItem_Public_Void_SByte_SByte_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665893);
		NativeMethodInfoPtr_buyItem_Public_Void_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665894);
		NativeMethodInfoPtr_selectSkill_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665895);
		NativeMethodInfoPtr_getEffData_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665896);
		NativeMethodInfoPtr_openUIZone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665897);
		NativeMethodInfoPtr_confirmMenu_Public_Void_Int16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665898);
		NativeMethodInfoPtr_openMenu_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665899);
		NativeMethodInfoPtr_menu_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665900);
		NativeMethodInfoPtr_menuId_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665901);
		NativeMethodInfoPtr_textBoxId_Public_Void_Int16_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665902);
		NativeMethodInfoPtr_requestItem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665903);
		NativeMethodInfoPtr_boxSort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665904);
		NativeMethodInfoPtr_boxCoinOut_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665905);
		NativeMethodInfoPtr_upgradeItem_Public_Void_Item_Il2CppReferenceArray_1_Item_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665906);
		NativeMethodInfoPtr_crystalCollectLock_Public_Void_Il2CppReferenceArray_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665907);
		NativeMethodInfoPtr_acceptInviteTrade_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665908);
		NativeMethodInfoPtr_cancelInviteTrade_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665909);
		NativeMethodInfoPtr_tradeAccept_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665910);
		NativeMethodInfoPtr_tradeItemLock_Public_Void_Int32_Il2CppReferenceArray_1_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665911);
		NativeMethodInfoPtr_sendPlayerAttack_Public_Void_MyVector_MyVector_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665912);
		NativeMethodInfoPtr_pickItem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665913);
		NativeMethodInfoPtr_throwItem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665914);
		NativeMethodInfoPtr_returnTownFromDead_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665915);
		NativeMethodInfoPtr_wakeUpFromDead_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665916);
		NativeMethodInfoPtr_chat_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665917);
		NativeMethodInfoPtr_updateData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665918);
		NativeMethodInfoPtr_updateMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665919);
		NativeMethodInfoPtr_updateSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665920);
		NativeMethodInfoPtr_updateItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665921);
		NativeMethodInfoPtr_clientOk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665922);
		NativeMethodInfoPtr_tradeInvite_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665923);
		NativeMethodInfoPtr_addFriend_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665924);
		NativeMethodInfoPtr_addPartyAccept_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665925);
		NativeMethodInfoPtr_addPartyCancel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665926);
		NativeMethodInfoPtr_testInvite_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665927);
		NativeMethodInfoPtr_addCuuSat_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665928);
		NativeMethodInfoPtr_addParty_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665929);
		NativeMethodInfoPtr_player_vs_player_Public_Void_SByte_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665930);
		NativeMethodInfoPtr_requestMaptemplate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665931);
		NativeMethodInfoPtr_outParty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665932);
		NativeMethodInfoPtr_requestPlayerInfo_Public_Void_MyVector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665933);
		NativeMethodInfoPtr_pleaseInputParty_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665934);
		NativeMethodInfoPtr_acceptPleaseParty_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665935);
		NativeMethodInfoPtr_chatPlayer_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665936);
		NativeMethodInfoPtr_chatGlobal_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665937);
		NativeMethodInfoPtr_chatPrivate_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665938);
		NativeMethodInfoPtr_sendCardInfo_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665939);
		NativeMethodInfoPtr_saveRms_Public_Void_String_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665940);
		NativeMethodInfoPtr_loadRMS_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665941);
		NativeMethodInfoPtr_clearTask_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665942);
		NativeMethodInfoPtr_changeName_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665943);
		NativeMethodInfoPtr_requestIcon_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665944);
		NativeMethodInfoPtr_doConvertUpgrade_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665945);
		NativeMethodInfoPtr_inviteClanDun_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665946);
		NativeMethodInfoPtr_inputNumSplit_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665947);
		NativeMethodInfoPtr_activeAccProtect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665948);
		NativeMethodInfoPtr_clearAccProtect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665949);
		NativeMethodInfoPtr_updateActive_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665950);
		NativeMethodInfoPtr_openLockAccProtect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665951);
		NativeMethodInfoPtr_getBgTemplate_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665952);
		NativeMethodInfoPtr_getMapOffline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665953);
		NativeMethodInfoPtr_finishUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665954);
		NativeMethodInfoPtr_finishLoadMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665955);
		NativeMethodInfoPtr_getChest_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665956);
		NativeMethodInfoPtr_requestBagImage_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665957);
		NativeMethodInfoPtr_getBag_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665958);
		NativeMethodInfoPtr_getBody_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665959);
		NativeMethodInfoPtr_login2_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665960);
		NativeMethodInfoPtr_getMagicTree_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665961);
		NativeMethodInfoPtr_upPotential_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665962);
		NativeMethodInfoPtr_getResource_Public_Void_SByte_MyVector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665963);
		NativeMethodInfoPtr_requestMapSelect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665964);
		NativeMethodInfoPtr_petInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665965);
		NativeMethodInfoPtr_sendTop_Public_Void_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665966);
		NativeMethodInfoPtr_enemy_Public_Void_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665967);
		NativeMethodInfoPtr_kigui_Public_Void_SByte_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665968);
		NativeMethodInfoPtr_getFlag_Public_Void_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665969);
		NativeMethodInfoPtr_setLockInventory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665970);
		NativeMethodInfoPtr_petStatus_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665971);
		NativeMethodInfoPtr_transportNow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665972);
		NativeMethodInfoPtr_funsion_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665973);
		NativeMethodInfoPtr_imageSource_Public_Void_MyVector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665974);
		NativeMethodInfoPtr_getQuayso_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665975);
		NativeMethodInfoPtr_sendServerData_Public_Void_SByte_Int32_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665976);
		NativeMethodInfoPtr_changeOnKeyScr_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665977);
		NativeMethodInfoPtr_requestPean_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665978);
		NativeMethodInfoPtr_sendThachDau_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665979);
		NativeMethodInfoPtr_messagePlayerMenu_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665980);
		NativeMethodInfoPtr_playerMenuAction_Public_Void_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665981);
		NativeMethodInfoPtr_getImgByName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665982);
		NativeMethodInfoPtr_SendCrackBall_Public_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665983);
		NativeMethodInfoPtr_SendRada_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665984);
		NativeMethodInfoPtr_sendOptHat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665985);
		NativeMethodInfoPtr_sendDelAcc_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665986);
		NativeMethodInfoPtr_new_skill_not_focus_Public_Void_SByte_SByte_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665987);
		NativeMethodInfoPtr_SortItemBag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665988);
		NativeMethodInfoPtr_requestBoss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665989);
		NativeMethodInfoPtr_pingToServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665990);
		NativeMethodInfoPtr_sendMatrixChallengeResponse_Public_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665991);
		NativeMethodInfoPtr_detectHacking_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665992);
		NativeMethodInfoPtr_loadMap_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665993);
		NativeMethodInfoPtr_sendVoiceChat_Public_Void_Il2CppStructArray_1_Byte_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665994);
		NativeMethodInfoPtr_sendSettingVoiceChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665995);
		NativeMethodInfoPtr_requestVoiceChatId_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665996);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Service>.NativeClassPtr, 100665997);
	}

	[CallerCount(351)]
	[CachedScanResults(RefRangeStart = 88911, RefRangeEnd = 89262, XrefRangeStart = 88888, XrefRangeEnd = 88911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Service gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_Service_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Service>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89275, RefRangeEnd = 89276, XrefRangeStart = 89262, XrefRangeEnd = 89275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gotoPlayer(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gotoPlayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 89296, RefRangeEnd = 89300, XrefRangeStart = 89276, XrefRangeEnd = 89296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void androidPack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_androidPack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89300, XrefRangeEnd = 89321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void charInfo(string day, string month, string year, string address, string cmnd, string dayCmnd, string noiCapCmnd, string sdt, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(day);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(month);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(year);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(address);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cmnd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(dayCmnd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(noiCapCmnd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sdt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_charInfo_Public_Void_String_String_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89321, XrefRangeEnd = 89322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void androidPack2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_androidPack2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89322, XrefRangeEnd = 89335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkAd(sbyte status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkAd_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89335, XrefRangeEnd = 89379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void combine(sbyte action, MyVector id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_combine_Public_Void_SByte_MyVector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 89425, RefRangeEnd = 89437, XrefRangeStart = 89379, XrefRangeEnd = 89425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void giaodich(sbyte action, int playerID, sbyte index, int num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerID;
		*(sbyte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_giaodich_Public_Void_SByte_Int32_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89437, XrefRangeEnd = 89463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendClientInput(Il2CppReferenceArray<TField> t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendClientInput_Public_Void_Il2CppReferenceArray_1_TField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89463, XrefRangeEnd = 89476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void speacialSkill(sbyte index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_speacialSkill_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89476, XrefRangeEnd = 89501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void test(short x, short y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_test_Public_Void_Int16_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89501, XrefRangeEnd = 89519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void test2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_test2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void testJoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_testJoint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89543, RefRangeEnd = 89544, XrefRangeStart = 89519, XrefRangeEnd = 89543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void mobCapcha(char ch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mobCapcha_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 89566, RefRangeEnd = 89571, XrefRangeStart = 89544, XrefRangeEnd = 89566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void friend(sbyte action, int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_friend_Public_Void_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89592, RefRangeEnd = 89593, XrefRangeStart = 89571, XrefRangeEnd = 89592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getArchivemnt(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getArchivemnt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89606, RefRangeEnd = 89608, XrefRangeStart = 89593, XrefRangeEnd = 89606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getPlayerMenu(int playerID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPlayerMenu_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89623, RefRangeEnd = 89624, XrefRangeStart = 89608, XrefRangeEnd = 89623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clanImage(sbyte id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clanImage_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 89648, RefRangeEnd = 89659, XrefRangeStart = 89624, XrefRangeEnd = 89648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void skill_not_focus(sbyte status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_skill_not_focus_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 89674, RefRangeEnd = 89678, XrefRangeStart = 89659, XrefRangeEnd = 89674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clanDonate(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clanDonate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 89696, RefRangeEnd = 89700, XrefRangeStart = 89678, XrefRangeEnd = 89696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clanMessage(int type, string text, int clanID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clanID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clanMessage_Public_Void_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 89726, RefRangeEnd = 89743, XrefRangeStart = 89700, XrefRangeEnd = 89726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void useItem(sbyte type, sbyte where, sbyte index, short template)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&type);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &where;
		*(sbyte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(short**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &template;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_useItem_Public_Void_SByte_SByte_SByte_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 89759, RefRangeEnd = 89761, XrefRangeStart = 89743, XrefRangeEnd = 89759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void joinClan(int id, sbyte action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &action;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_joinClan_Public_Void_Int32_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89776, RefRangeEnd = 89777, XrefRangeStart = 89761, XrefRangeEnd = 89776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clanMember(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clanMember_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 89792, RefRangeEnd = 89795, XrefRangeStart = 89777, XrefRangeEnd = 89792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void searchClan(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_searchClan_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89795, XrefRangeEnd = 89810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestClan(short id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestClan_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 89826, RefRangeEnd = 89830, XrefRangeStart = 89810, XrefRangeEnd = 89826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clanRemote(int id, sbyte role)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &role;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clanRemote_Public_Void_Int32_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89844, RefRangeEnd = 89845, XrefRangeStart = 89830, XrefRangeEnd = 89844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void leaveClan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_leaveClan_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 89863, RefRangeEnd = 89867, XrefRangeStart = 89845, XrefRangeEnd = 89863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clanInvite(sbyte action, int playerID, int clanID, int code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clanID;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &code;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clanInvite_Public_Void_SByte_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 89884, RefRangeEnd = 89889, XrefRangeStart = 89867, XrefRangeEnd = 89884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getClan(sbyte action, sbyte id, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&action);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getClan_Public_Void_SByte_SByte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89904, RefRangeEnd = 89905, XrefRangeStart = 89889, XrefRangeEnd = 89904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCaption(sbyte gender)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&gender);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCaption_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 89921, RefRangeEnd = 89930, XrefRangeStart = 89905, XrefRangeEnd = 89921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getItem(sbyte type, sbyte id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getItem_Public_Void_SByte_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 89947, RefRangeEnd = 89948, XrefRangeStart = 89930, XrefRangeEnd = 89947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getTask(int npcTemplateId, int menuId, int optionId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&npcTemplateId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &menuId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &optionId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTask_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 89953, RefRangeEnd = 89956, XrefRangeStart = 89948, XrefRangeEnd = 89953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Message messageNotLogin(sbyte command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&command);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_messageNotLogin_Public_Message_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Message>(intPtr) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 89961, RefRangeEnd = 89978, XrefRangeStart = 89956, XrefRangeEnd = 89961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Message messageNotMap(sbyte command)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&command);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_messageNotMap_Public_Message_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Message>(intPtr) : null;
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 89983, RefRangeEnd = 89997, XrefRangeStart = 89978, XrefRangeEnd = 89983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Message messageSubCommand(sbyte command)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&command);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_messageSubCommand_Public_Static_Message_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Message>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 90029, RefRangeEnd = 90035, XrefRangeStart = 89997, XrefRangeEnd = 90029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setClientType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setClientType_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90035, XrefRangeEnd = 90036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setClientType2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setClientType2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90050, RefRangeEnd = 90051, XrefRangeStart = 90036, XrefRangeEnd = 90050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendCheckController()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendCheckController_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90065, RefRangeEnd = 90066, XrefRangeStart = 90051, XrefRangeEnd = 90065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendCheckMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendCheckMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 90077, RefRangeEnd = 90082, XrefRangeStart = 90066, XrefRangeEnd = 90077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void login(string username, string pass, string version, sbyte type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(version);
		*(sbyte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_login_Public_Void_String_String_String_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90099, RefRangeEnd = 90100, XrefRangeStart = 90082, XrefRangeEnd = 90099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestRegister(string username, string pass, string usernameAo, string passAo, string version)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(usernameAo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(passAo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(version);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestRegister_Public_Void_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 90111, RefRangeEnd = 90116, XrefRangeStart = 90100, XrefRangeEnd = 90111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestChangeMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestChangeMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 90127, RefRangeEnd = 90129, XrefRangeStart = 90116, XrefRangeEnd = 90127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void magicTree(sbyte type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_magicTree_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 90140, RefRangeEnd = 90144, XrefRangeStart = 90129, XrefRangeEnd = 90140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestChangeZone(int zoneId, int indexUI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&zoneId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexUI;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestChangeZone_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90154, RefRangeEnd = 90155, XrefRangeStart = 90144, XrefRangeEnd = 90154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkMMove(int second)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&second);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkMMove_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 90219, RefRangeEnd = 90261, XrefRangeStart = 90155, XrefRangeEnd = 90219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void charMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_charMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90261, XrefRangeEnd = 90279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void selectCharToPlay(string charname)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(charname);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_selectCharToPlay_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void selectZone(sbyte sub, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sub);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_selectZone_Public_Void_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90279, XrefRangeEnd = 90305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createChar(string name, int gender, int hair)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &gender;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hair;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createChar_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 90320, RefRangeEnd = 90327, XrefRangeStart = 90305, XrefRangeEnd = 90320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestModTemplate(int modTemplateId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&modTemplateId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestModTemplate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90327, XrefRangeEnd = 90339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestNpcTemplate(int npcTemplateId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcTemplateId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestNpcTemplate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90339, XrefRangeEnd = 90351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestSkill(int skillId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestSkill_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90351, XrefRangeEnd = 90367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestItemInfo(int typeUI, int indexUI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&typeUI);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexUI;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestItemInfo_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90367, XrefRangeEnd = 90383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestItemPlayer(int charId, int indexUI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&charId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexUI;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestItemPlayer_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90383, XrefRangeEnd = 90399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upSkill(int skillTemplateId, int point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&skillTemplateId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upSkill_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 90416, RefRangeEnd = 90420, XrefRangeStart = 90399, XrefRangeEnd = 90416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void saleItem(sbyte action, sbyte type, short id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&action);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saleItem_Public_Void_SByte_SByte_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 90437, RefRangeEnd = 90447, XrefRangeStart = 90420, XrefRangeEnd = 90437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buyItem(sbyte type, int id, int quantity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &quantity;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buyItem_Public_Void_SByte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 90471, RefRangeEnd = 90481, XrefRangeStart = 90447, XrefRangeEnd = 90471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void selectSkill(int skillTemplateId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillTemplateId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_selectSkill_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 90496, RefRangeEnd = 90498, XrefRangeStart = 90481, XrefRangeEnd = 90496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getEffData(short id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEffData_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 90512, RefRangeEnd = 90516, XrefRangeStart = 90498, XrefRangeEnd = 90512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openUIZone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openUIZone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90516, XrefRangeEnd = 90540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void confirmMenu(short npcID, sbyte select)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&npcID);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &select;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_confirmMenu_Public_Void_Int16_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 90555, RefRangeEnd = 90558, XrefRangeStart = 90540, XrefRangeEnd = 90555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openMenu(int npcId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openMenu_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 90580, RefRangeEnd = 90584, XrefRangeStart = 90558, XrefRangeEnd = 90580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void menu(int npcId, int menuId, int optionId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&npcId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &menuId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &optionId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_menu_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90584, XrefRangeEnd = 90599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void menuId(short menuId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&menuId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_menuId_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90615, RefRangeEnd = 90616, XrefRangeStart = 90599, XrefRangeEnd = 90615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void textBoxId(short menuId, string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&menuId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_textBoxId_Public_Void_Int16_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90616, XrefRangeEnd = 90631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestItem(int typeUI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeUI);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestItem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90631, XrefRangeEnd = 90645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void boxSort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_boxSort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90645, XrefRangeEnd = 90660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void boxCoinOut(int coinOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&coinOut);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_boxCoinOut_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90660, XrefRangeEnd = 90683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upgradeItem(Item item, Il2CppReferenceArray<Item> items, bool isGold)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isGold;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upgradeItem_Public_Void_Item_Il2CppReferenceArray_1_Item_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90704, RefRangeEnd = 90705, XrefRangeStart = 90683, XrefRangeEnd = 90704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void crystalCollectLock(Il2CppReferenceArray<Item> items)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_crystalCollectLock_Public_Void_Il2CppReferenceArray_1_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90720, RefRangeEnd = 90721, XrefRangeStart = 90705, XrefRangeEnd = 90720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void acceptInviteTrade(int playerMapId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerMapId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_acceptInviteTrade_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 90735, RefRangeEnd = 90736, XrefRangeStart = 90721, XrefRangeEnd = 90735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void cancelInviteTrade()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancelInviteTrade_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90736, XrefRangeEnd = 90750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void tradeAccept()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tradeAccept_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90750, XrefRangeEnd = 90769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void tradeItemLock(int coin, Il2CppReferenceArray<Item> items)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&coin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)items);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tradeItemLock_Public_Void_Int32_Il2CppReferenceArray_1_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 90850, RefRangeEnd = 90860, XrefRangeStart = 90769, XrefRangeEnd = 90850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendPlayerAttack(MyVector vMob, MyVector vChar, int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vMob);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vChar);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendPlayerAttack_Public_Void_MyVector_MyVector_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 90875, RefRangeEnd = 90882, XrefRangeStart = 90860, XrefRangeEnd = 90875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pickItem(int itemMapId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemMapId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pickItem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90882, XrefRangeEnd = 90897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void throwItem(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_throwItem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 90914, RefRangeEnd = 90917, XrefRangeStart = 90897, XrefRangeEnd = 90914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void returnTownFromDead()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_returnTownFromDead_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 90934, RefRangeEnd = 90938, XrefRangeStart = 90917, XrefRangeEnd = 90934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void wakeUpFromDead()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_wakeUpFromDead_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 90958, RefRangeEnd = 90961, XrefRangeStart = 90938, XrefRangeEnd = 90958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chat(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chat_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 91002, RefRangeEnd = 91005, XrefRangeStart = 90961, XrefRangeEnd = 91002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91037, RefRangeEnd = 91039, XrefRangeStart = 91005, XrefRangeEnd = 91037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91069, RefRangeEnd = 91071, XrefRangeStart = 91039, XrefRangeEnd = 91069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 91101, RefRangeEnd = 91105, XrefRangeStart = 91071, XrefRangeEnd = 91101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 91116, RefRangeEnd = 91121, XrefRangeStart = 91105, XrefRangeEnd = 91116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clientOk()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clientOk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91121, XrefRangeEnd = 91136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void tradeInvite(int charId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tradeInvite_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91136, XrefRangeEnd = 91151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addFriend(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addFriend_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91151, XrefRangeEnd = 91166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addPartyAccept(int charId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addPartyAccept_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91166, XrefRangeEnd = 91181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addPartyCancel(int charId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addPartyCancel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91181, XrefRangeEnd = 91196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void testInvite(int charId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_testInvite_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91196, XrefRangeEnd = 91211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addCuuSat(int charId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addCuuSat_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91211, XrefRangeEnd = 91226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addParty(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addParty_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91226, XrefRangeEnd = 91243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void player_vs_player(sbyte action, sbyte type, int playerId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&action);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &playerId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_player_vs_player_Public_Void_SByte_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91265, RefRangeEnd = 91266, XrefRangeStart = 91243, XrefRangeEnd = 91265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestMaptemplate(int maptemplateId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maptemplateId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestMaptemplate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91266, XrefRangeEnd = 91280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void outParty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_outParty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91280, XrefRangeEnd = 91314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestPlayerInfo(MyVector chars)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chars);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestPlayerInfo_Public_Void_MyVector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91314, XrefRangeEnd = 91329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pleaseInputParty(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pleaseInputParty_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91329, XrefRangeEnd = 91344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void acceptPleaseParty(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_acceptPleaseParty_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91344, XrefRangeEnd = 91367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chatPlayer(string text, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatPlayer_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91382, RefRangeEnd = 91384, XrefRangeStart = 91367, XrefRangeEnd = 91382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chatGlobal(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatGlobal_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91384, XrefRangeEnd = 91400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chatPrivate(string to, string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatPrivate_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91400, XrefRangeEnd = 91413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendCardInfo(string NAP, string PIN)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(NAP);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(PIN);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendCardInfo_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91413, XrefRangeEnd = 91430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void saveRms(string key, Il2CppStructArray<sbyte> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRms_Public_Void_String_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91430, XrefRangeEnd = 91448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadRMS(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadRMS_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91459, RefRangeEnd = 91460, XrefRangeStart = 91448, XrefRangeEnd = 91459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearTask()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearTask_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91460, XrefRangeEnd = 91473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void changeName(string name, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_changeName_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91473, XrefRangeEnd = 91492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestIcon(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestIcon_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91492, XrefRangeEnd = 91506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doConvertUpgrade(int index1, int index2, int index3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&index1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index2;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index3;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doConvertUpgrade_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91506, XrefRangeEnd = 91518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void inviteClanDun(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inviteClanDun_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91518, XrefRangeEnd = 91531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void inputNumSplit(int indexItem, int numSplit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&indexItem);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numSplit;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inputNumSplit_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91543, RefRangeEnd = 91544, XrefRangeStart = 91531, XrefRangeEnd = 91543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void activeAccProtect(int pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pass);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_activeAccProtect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91556, RefRangeEnd = 91557, XrefRangeStart = 91544, XrefRangeEnd = 91556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearAccProtect(int pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pass);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearAccProtect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91557, XrefRangeEnd = 91570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateActive(int passOld, int passNew)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&passOld);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &passNew;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateActive_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91570, XrefRangeEnd = 91582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openLockAccProtect(int pass2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pass2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openLockAccProtect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 91618, RefRangeEnd = 91622, XrefRangeStart = 91582, XrefRangeEnd = 91618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getBgTemplate(short id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBgTemplate_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 91636, RefRangeEnd = 91642, XrefRangeStart = 91622, XrefRangeEnd = 91636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getMapOffline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMapOffline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 91665, RefRangeEnd = 91668, XrefRangeStart = 91642, XrefRangeEnd = 91665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void finishUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_finishUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91682, RefRangeEnd = 91683, XrefRangeStart = 91668, XrefRangeEnd = 91682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void finishLoadMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_finishLoadMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91683, XrefRangeEnd = 91698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getChest(sbyte action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getChest_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91713, RefRangeEnd = 91714, XrefRangeStart = 91698, XrefRangeEnd = 91713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestBagImage(sbyte ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestBagImage_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91714, XrefRangeEnd = 91729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getBag(sbyte action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBag_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91729, XrefRangeEnd = 91744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getBody(sbyte action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBody_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 91764, RefRangeEnd = 91767, XrefRangeStart = 91744, XrefRangeEnd = 91764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void login2(string user)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(user);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_login2_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 91783, RefRangeEnd = 91784, XrefRangeStart = 91767, XrefRangeEnd = 91783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getMagicTree(sbyte action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMagicTree_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91800, RefRangeEnd = 91802, XrefRangeStart = 91784, XrefRangeEnd = 91800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upPotential(int typePotential, int num)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&typePotential);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &num;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upPotential_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 91871, RefRangeEnd = 91875, XrefRangeStart = 91802, XrefRangeEnd = 91871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getResource(sbyte action, MyVector vResourceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vResourceIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getResource_Public_Void_SByte_MyVector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 91894, RefRangeEnd = 91896, XrefRangeStart = 91875, XrefRangeEnd = 91894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestMapSelect(int selected)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&selected);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestMapSelect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 91909, RefRangeEnd = 91914, XrefRangeStart = 91896, XrefRangeEnd = 91909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void petInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_petInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91914, XrefRangeEnd = 91928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendTop(string topName, sbyte selected)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(topName);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &selected;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendTop_Public_Void_String_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 91948, RefRangeEnd = 91951, XrefRangeStart = 91928, XrefRangeEnd = 91948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void enemy(sbyte b, int charID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&b);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &charID;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_enemy_Public_Void_SByte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 91976, RefRangeEnd = 91979, XrefRangeStart = 91951, XrefRangeEnd = 91976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void kigui(sbyte action, int itemId, int quantity, int price)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &itemId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &quantity;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &price;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_kigui_Public_Void_SByte_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92004, RefRangeEnd = 92006, XrefRangeStart = 91979, XrefRangeEnd = 92004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getFlag(sbyte action, sbyte flagType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&action);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flagType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFlag_Public_Void_SByte_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92006, XrefRangeEnd = 92027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setLockInventory(int pass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pass);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setLockInventory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 92040, RefRangeEnd = 92043, XrefRangeStart = 92027, XrefRangeEnd = 92040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void petStatus(sbyte status)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_petStatus_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92061, RefRangeEnd = 92062, XrefRangeStart = 92043, XrefRangeEnd = 92061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void transportNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_transportNow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92081, RefRangeEnd = 92082, XrefRangeStart = 92062, XrefRangeEnd = 92081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void funsion(sbyte type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_funsion_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92152, RefRangeEnd = 92153, XrefRangeStart = 92082, XrefRangeEnd = 92152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void imageSource(MyVector vID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_imageSource_Public_Void_MyVector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92153, XrefRangeEnd = 92165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getQuayso()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getQuayso_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92187, RefRangeEnd = 92189, XrefRangeStart = 92165, XrefRangeEnd = 92187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendServerData(sbyte action, int id, Il2CppStructArray<sbyte> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendServerData_Public_Void_SByte_Int32_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92205, RefRangeEnd = 92207, XrefRangeStart = 92189, XrefRangeEnd = 92205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void changeOnKeyScr(Il2CppStructArray<sbyte> skill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_changeOnKeyScr_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92219, RefRangeEnd = 92220, XrefRangeStart = 92207, XrefRangeEnd = 92219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestPean()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestPean_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92239, RefRangeEnd = 92241, XrefRangeStart = 92220, XrefRangeEnd = 92239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendThachDau(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendThachDau_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92255, RefRangeEnd = 92256, XrefRangeStart = 92241, XrefRangeEnd = 92255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void messagePlayerMenu(int charId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_messagePlayerMenu_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92271, RefRangeEnd = 92272, XrefRangeStart = 92256, XrefRangeEnd = 92271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void playerMenuAction(int charId, short select)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&charId);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &select;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playerMenuAction_Public_Void_Int32_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92285, RefRangeEnd = 92286, XrefRangeStart = 92272, XrefRangeEnd = 92285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getImgByName(string nameImg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(nameImg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getImgByName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92300, RefRangeEnd = 92302, XrefRangeStart = 92286, XrefRangeEnd = 92300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendCrackBall(byte type, byte soluong)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &soluong;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendCrackBall_Public_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 92316, RefRangeEnd = 92319, XrefRangeStart = 92302, XrefRangeEnd = 92316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendRada(int i, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendRada_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92336, RefRangeEnd = 92337, XrefRangeStart = 92319, XrefRangeEnd = 92336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendOptHat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendOptHat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92349, RefRangeEnd = 92350, XrefRangeStart = 92337, XrefRangeEnd = 92349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendDelAcc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendDelAcc_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92377, RefRangeEnd = 92378, XrefRangeStart = 92350, XrefRangeEnd = 92377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void new_skill_not_focus(sbyte idTemplateSkill, sbyte dir, short x, short y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&idTemplateSkill);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(short**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_new_skill_not_focus_Public_Void_SByte_SByte_Int16_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92378, XrefRangeEnd = 92394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SortItemBag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortItemBag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92409, RefRangeEnd = 92410, XrefRangeStart = 92394, XrefRangeEnd = 92409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestBoss()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestBoss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92430, RefRangeEnd = 92432, XrefRangeStart = 92410, XrefRangeEnd = 92430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pingToServer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pingToServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92450, RefRangeEnd = 92451, XrefRangeStart = 92432, XrefRangeEnd = 92450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendMatrixChallengeResponse(Il2CppReferenceArray<Il2CppStructArray<ulong>> response)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)response);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendMatrixChallengeResponse_Public_Void_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92468, RefRangeEnd = 92469, XrefRangeStart = 92451, XrefRangeEnd = 92468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void detectHacking(string who, string details)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(who);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(details);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_detectHacking_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92494, RefRangeEnd = 92495, XrefRangeStart = 92469, XrefRangeEnd = 92494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadMap(int map)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&map);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadMap_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 92526, RefRangeEnd = 92529, XrefRangeStart = 92495, XrefRangeEnd = 92526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendVoiceChat(Il2CppStructArray<byte> data, byte type = 0, string time = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(time);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendVoiceChat_Public_Void_Il2CppStructArray_1_Byte_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 92578, RefRangeEnd = 92582, XrefRangeStart = 92529, XrefRangeEnd = 92578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendSettingVoiceChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendSettingVoiceChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 92599, RefRangeEnd = 92601, XrefRangeStart = 92582, XrefRangeEnd = 92599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestVoiceChatId(int messID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&messID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestVoiceChatId_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92601, XrefRangeEnd = 92611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Service()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Service>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Service(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
