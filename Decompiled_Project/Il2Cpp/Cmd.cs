using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class Cmd : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LOGIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_REGISTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLIENT_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_SEND_SMS;

	private static readonly System.IntPtr NativeFieldInfoPtr_REGISTER_IMAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MESSAGE_TIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOGOUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_SELECT_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CREATE_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_DELETE_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_VERSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_MAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_MAPTEMPLATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_NPCTEMPLATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_NPCPLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_TYPE_PK;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_ATTACK_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_VS_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_PARTY;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_INVITE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_REMOTE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_LEAVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_DONATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_JOIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_MEMBER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_SEARCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_CREATE_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLIENT_OK;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLIENT_OK_INMAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_VERSION_OK;

	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_CARD;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLEAR_TASK;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHANGE_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_PK;

	private static readonly System.IntPtr NativeFieldInfoPtr_CREATE_CLAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONVERT_UPGRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_INVITE_CLANDUN;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOT_USEACC;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_ACTIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_ACTIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_UPDATE_ACTIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_OPEN_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_SPLIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_CLEAR_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_IMG_BY_NAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_ALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_CLASS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_HP;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_MP;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_ALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_SPEED;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_LEVEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_VUKHI;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_AO;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_QUAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_BODY;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_HP;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LOAD_LIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_GOTO_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_POTENTIAL_UP;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_UP;

	private static readonly System.IntPtr NativeFieldInfoPtr_BAG_SORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOX_SORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOX_COIN_OUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_ADD_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_UPDATE_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_PLAYER_MENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_MENU_ACTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_RMS;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOAD_RMS;

	private static readonly System.IntPtr NativeFieldInfoPtr_USE_BOOK_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOCK_INVENTORY;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHANGE_FLAG;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOGINFAIL;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOGIN2;

	private static readonly System.IntPtr NativeFieldInfoPtr_KIGUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENEMY_LIST;

	private static readonly System.IntPtr NativeFieldInfoPtr_ANDROID_IAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_ACTIVEPOINT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOB_ME_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_COOLDOWN;

	private static readonly System.IntPtr NativeFieldInfoPtr_BGITEM_VERSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_SET_CLIENTTYPE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAP_TRASPORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_BODY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SERVERSCREEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_GIAO_DICH;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOB_CAPCHA;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOB_MAX_HP;

	private static readonly System.IntPtr NativeFieldInfoPtr_CALL_DRAGON;

	private static readonly System.IntPtr NativeFieldInfoPtr_TILE_SET;

	private static readonly System.IntPtr NativeFieldInfoPtr_COMBINNE;

	private static readonly System.IntPtr NativeFieldInfoPtr_FRIEND;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_MENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHECK_MOVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SMALLIMAGE_VERSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_ARCHIVEMENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_BOSS;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_IMAGE_SOURCE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_ADD_REMOVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_THEGIOI_CLIENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_BIG_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXSTAMINA;

	private static readonly System.IntPtr NativeFieldInfoPtr_STAMINA;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_ICON;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_EFFDATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_TELEPORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_BAG;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_BAG;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLAN_IMAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_CLANID;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_NOT_FOCUS;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHOP;

	private static readonly System.IntPtr NativeFieldInfoPtr_USE_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LOAD_POINT;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_CAPTION;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_FINISH_LOADMAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_FINISH_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_BODY;

	private static readonly System.IntPtr NativeFieldInfoPtr_BAG;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOX;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAGIC_TREE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAP_OFFLINE;

	private static readonly System.IntPtr NativeFieldInfoPtr_BACKGROUND_TEMPLATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_BACKGROUND;

	private static readonly System.IntPtr NativeFieldInfoPtr_SUB_COMMAND;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOT_LOGIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOT_MAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_SESSION_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_DIALOG_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAP_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAP_CHANGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAP_CLEAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEMMAP_REMOVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEMMAP_MYPICK;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEMMAP_PLAYERPICK;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_THROW;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_DIE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_LIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_BACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_THROW;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_LIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_DIE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_ATTACK_ME;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_ATTACK_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOB_HP;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_DIE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_MOVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_REMOVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_ADD;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_ATTACK_N_P;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_UP_EXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_UP_COIN_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_CHANGE_COIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_BUY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_SALE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPPEARL_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPGRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLEASE_INPUT_PARTY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACCEPT_PLEASE_PARTY;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_PLAYERS;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE_ACHIEVEMENT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHUBANG_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZONE_CHANGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPTION_HAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_PT;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_SHOP;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_MENU_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_COLLECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_ZONE;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_TRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_SAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_CONFIRM;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_MENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_SELECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_ITEM_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRADE_INVITE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRADE_INVITE_ACCEPT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRADE_LOCK_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRADE_ACCEPT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TASK_GET;

	private static readonly System.IntPtr NativeFieldInfoPtr_TASK_NEXT;

	private static readonly System.IntPtr NativeFieldInfoPtr_GAME_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_TASK_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_MAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_MISS;

	private static readonly System.IntPtr NativeFieldInfoPtr_RESET_POINT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALERT_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_AUTO_SERVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALERT_SEND_SMS;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRADE_INVITE_CANCEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOSS_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MABU_HOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_FRIEND_INVITE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_ATTACK_NPC;

	private static readonly System.IntPtr NativeFieldInfoPtr_HAVE_ATTACK_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_UI_NEWMENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOVE_FAST;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEST_INVITE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ADD_CUU_SAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_CUU_SAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLEAR_CUU_SAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_UP_EXPDOWN;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_DIE_EXP_DOWN;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_ATTACK_P_N;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEMMAP_ADD;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEL_ACC;

	private static readonly System.IntPtr NativeFieldInfoPtr_USE_SKILL_MY_BUFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_CHANGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PARTY_INVITE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PARTY_ACCEPT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PARTY_CANCEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_IN_PARTY;

	private static readonly System.IntPtr NativeFieldInfoPtr_PARTY_OUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_FRIEND_ADD;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_IS_DISABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_IS_MOVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SUMON_ATTACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_RETURN_POINT_MAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_IS_FIRE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_IS_ICE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_IS_WIND;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_TEXT_BOX_ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_ITEM_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_PRIVATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_THEGIOI_SERVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT_VIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_ALERT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ME_UP_COIN_BAG;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_TASK_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_TASK_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLEAR_TASK_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_ADD_ITEM_MAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MATRIX_CHALLENGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ECC_CHALLENGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANSPORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_TIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_PET_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_PET_STATUS;

	private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_DATA;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLIENT_INPUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHOW_ADS;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOGIN_DE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SET_POS;

	private static readonly System.IntPtr NativeFieldInfoPtr_NPC_CHAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_FUSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_ANDROID_PACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_IMAGE_SOURCE2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAGE_MOD_BODY;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHANGE_ONSKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_REQUEST_PEAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_POWER_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_AUTOPLAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MABU;

	private static readonly System.IntPtr NativeFieldInfoPtr_THACHDAU;

	private static readonly System.IntPtr NativeFieldInfoPtr_THELUC;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATECHAR_MP;

	private static readonly System.IntPtr NativeFieldInfoPtr_REFRESH_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHECK_CONTROLLER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHECK_MAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_BIG_BOSS;

	private static readonly System.IntPtr NativeFieldInfoPtr_BIG_BOSS_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_DUAHAU;

	private static readonly System.IntPtr NativeFieldInfoPtr_QUAYSO;

	private static readonly System.IntPtr NativeFieldInfoPtr_USER_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN3HOUR;

	private static readonly System.IntPtr NativeFieldInfoPtr_STATUS_PET;

	private static readonly System.IntPtr NativeFieldInfoPtr_SPEACIAL_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_SERVER_EFFECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_INAPP;

	private static readonly System.IntPtr NativeFieldInfoPtr_BATCH_MESSAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LUCKY_ROUND;

	private static readonly System.IntPtr NativeFieldInfoPtr_RADA_CARD;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAR_EFFECT;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static sbyte LOGIN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOGIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOGIN, (void*)(&b));
		}
	}

	public unsafe static sbyte REGISTER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REGISTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REGISTER, (void*)(&b));
		}
	}

	public unsafe static sbyte CLIENT_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLIENT_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLIENT_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte SEND_SMS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SEND_SMS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SEND_SMS, (void*)(&b));
		}
	}

	public unsafe static sbyte REGISTER_IMAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REGISTER_IMAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REGISTER_IMAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte MESSAGE_TIME
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MESSAGE_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MESSAGE_TIME, (void*)(&b));
		}
	}

	public unsafe static sbyte LOGOUT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOGOUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOGOUT, (void*)(&b));
		}
	}

	public unsafe static sbyte SELECT_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SELECT_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SELECT_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte CREATE_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CREATE_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CREATE_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte DELETE_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DELETE_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DELETE_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_VERSION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_VERSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_VERSION, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_MAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_MAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_MAP, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_ITEM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_ITEM, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_MAPTEMPLATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_MAPTEMPLATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_MAPTEMPLATE, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_NPCTEMPLATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_NPCTEMPLATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_NPCTEMPLATE, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_NPCPLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_NPCPLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_NPCPLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_TYPE_PK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_TYPE_PK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_TYPE_PK, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_ATTACK_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_ATTACK_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_ATTACK_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_VS_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_VS_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_VS_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_PARTY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_PARTY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_PARTY, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_INVITE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_INVITE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_INVITE, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_REMOTE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_REMOTE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_REMOTE, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_LEAVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_LEAVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_LEAVE, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_DONATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_DONATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_DONATE, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_MESSAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_UPDATE, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_JOIN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_JOIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_JOIN, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_MEMBER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_MEMBER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_MEMBER, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_SEARCH
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_SEARCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_SEARCH, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_CREATE_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_CREATE_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_CREATE_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte CLIENT_OK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLIENT_OK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLIENT_OK, (void*)(&b));
		}
	}

	public unsafe static sbyte CLIENT_OK_INMAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLIENT_OK_INMAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLIENT_OK_INMAP, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_VERSION_OK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_VERSION_OK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_VERSION_OK, (void*)(&b));
		}
	}

	public unsafe static sbyte INPUT_CARD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_CARD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_CARD, (void*)(&b));
		}
	}

	public unsafe static sbyte CLEAR_TASK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLEAR_TASK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLEAR_TASK, (void*)(&b));
		}
	}

	public unsafe static sbyte CHANGE_NAME
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHANGE_NAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHANGE_NAME, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_PK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_PK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_PK, (void*)(&b));
		}
	}

	public unsafe static sbyte CREATE_CLAN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CREATE_CLAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CREATE_CLAN, (void*)(&b));
		}
	}

	public unsafe static sbyte CONVERT_UPGRADE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONVERT_UPGRADE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONVERT_UPGRADE, (void*)(&b));
		}
	}

	public unsafe static sbyte INVITE_CLANDUN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INVITE_CLANDUN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INVITE_CLANDUN, (void*)(&b));
		}
	}

	public unsafe static sbyte NOT_USEACC
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOT_USEACC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOT_USEACC, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_ACTIVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_ACTIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_ACTIVE, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_ACTIVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_ACTIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_ACTIVE, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_UPDATE_ACTIVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_UPDATE_ACTIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_UPDATE_ACTIVE, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_OPEN_LOCK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_OPEN_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_OPEN_LOCK, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEM_SPLIT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_SPLIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_SPLIT, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_CLEAR_LOCK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_CLEAR_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_CLEAR_LOCK, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_IMG_BY_NAME
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_IMG_BY_NAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_IMG_BY_NAME, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_ALL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_ALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_ALL, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_CLASS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_CLASS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_CLASS, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_HP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_HP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_HP, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_MP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_MP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_MP, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_ALL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_ALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_ALL, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_SPEED
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_SPEED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_SPEED, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_LEVEL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_LEVEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_LEVEL, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_VUKHI
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_VUKHI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_VUKHI, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_AO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_AO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_AO, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_QUAN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_QUAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_QUAN, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_BODY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_BODY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_BODY, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_HP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_HP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_HP, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_LOAD_LIVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_LOAD_LIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_LOAD_LIVE, (void*)(&b));
		}
	}

	public unsafe static sbyte GOTO_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GOTO_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GOTO_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte POTENTIAL_UP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POTENTIAL_UP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POTENTIAL_UP, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_UP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_UP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_UP, (void*)(&b));
		}
	}

	public unsafe static sbyte BAG_SORT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BAG_SORT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BAG_SORT, (void*)(&b));
		}
	}

	public unsafe static sbyte BOX_SORT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOX_SORT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOX_SORT, (void*)(&b));
		}
	}

	public unsafe static sbyte BOX_COIN_OUT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOX_COIN_OUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOX_COIN_OUT, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_ITEM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_ITEM, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_ADD_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_ADD_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_ADD_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_UPDATE_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_UPDATE_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_UPDATE_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_PLAYER_MENU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_PLAYER_MENU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_PLAYER_MENU, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_MENU_ACTION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_MENU_ACTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_MENU_ACTION, (void*)(&b));
		}
	}

	public unsafe static sbyte SAVE_RMS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAVE_RMS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAVE_RMS, (void*)(&b));
		}
	}

	public unsafe static sbyte LOAD_RMS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOAD_RMS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOAD_RMS, (void*)(&b));
		}
	}

	public unsafe static sbyte USE_BOOK_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_BOOK_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_BOOK_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte LOCK_INVENTORY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOCK_INVENTORY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOCK_INVENTORY, (void*)(&b));
		}
	}

	public unsafe static sbyte CHANGE_FLAG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHANGE_FLAG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHANGE_FLAG, (void*)(&b));
		}
	}

	public unsafe static sbyte LOGINFAIL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOGINFAIL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOGINFAIL, (void*)(&b));
		}
	}

	public unsafe static sbyte LOGIN2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOGIN2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOGIN2, (void*)(&b));
		}
	}

	public unsafe static sbyte KIGUI
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KIGUI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KIGUI, (void*)(&b));
		}
	}

	public unsafe static sbyte ENEMY_LIST
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENEMY_LIST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENEMY_LIST, (void*)(&b));
		}
	}

	public unsafe static sbyte ANDROID_IAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ANDROID_IAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ANDROID_IAP, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_ACTIVEPOINT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_ACTIVEPOINT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_ACTIVEPOINT, (void*)(&b));
		}
	}

	public unsafe static sbyte TOP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOP, (void*)(&b));
		}
	}

	public unsafe static sbyte MOB_ME_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOB_ME_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOB_ME_UPDATE, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_COOLDOWN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_COOLDOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_COOLDOWN, (void*)(&b));
		}
	}

	public unsafe static sbyte BGITEM_VERSION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BGITEM_VERSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BGITEM_VERSION, (void*)(&b));
		}
	}

	public unsafe static sbyte SET_CLIENTTYPE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SET_CLIENTTYPE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SET_CLIENTTYPE, (void*)(&b));
		}
	}

	public unsafe static sbyte MAP_TRASPORT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAP_TRASPORT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAP_TRASPORT, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_BODY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_BODY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_BODY, (void*)(&b));
		}
	}

	public unsafe static sbyte SERVERSCREEN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SERVERSCREEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SERVERSCREEN, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_DATA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_DATA, (void*)(&b));
		}
	}

	public unsafe static sbyte GIAO_DICH
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GIAO_DICH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GIAO_DICH, (void*)(&b));
		}
	}

	public unsafe static sbyte MOB_CAPCHA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOB_CAPCHA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOB_CAPCHA, (void*)(&b));
		}
	}

	public unsafe static sbyte MOB_MAX_HP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOB_MAX_HP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOB_MAX_HP, (void*)(&b));
		}
	}

	public unsafe static sbyte CALL_DRAGON
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CALL_DRAGON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CALL_DRAGON, (void*)(&b));
		}
	}

	public unsafe static sbyte TILE_SET
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TILE_SET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TILE_SET, (void*)(&b));
		}
	}

	public unsafe static sbyte COMBINNE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COMBINNE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COMBINNE, (void*)(&b));
		}
	}

	public unsafe static sbyte FRIEND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FRIEND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FRIEND, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_MENU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_MENU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_MENU, (void*)(&b));
		}
	}

	public unsafe static sbyte CHECK_MOVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHECK_MOVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHECK_MOVE, (void*)(&b));
		}
	}

	public unsafe static sbyte SMALLIMAGE_VERSION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SMALLIMAGE_VERSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SMALLIMAGE_VERSION, (void*)(&b));
		}
	}

	public unsafe static sbyte ARCHIVEMENT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ARCHIVEMENT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ARCHIVEMENT, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_BOSS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_BOSS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_BOSS, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_IMAGE_SOURCE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_IMAGE_SOURCE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_IMAGE_SOURCE, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_ADD_REMOVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_ADD_REMOVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_ADD_REMOVE, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAT_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAT_THEGIOI_CLIENT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT_THEGIOI_CLIENT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT_THEGIOI_CLIENT, (void*)(&b));
		}
	}

	public unsafe static sbyte BIG_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BIG_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BIG_MESSAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte MAXSTAMINA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXSTAMINA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXSTAMINA, (void*)(&b));
		}
	}

	public unsafe static sbyte STAMINA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STAMINA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STAMINA, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_ICON
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_ICON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_ICON, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_EFFDATA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_EFFDATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_EFFDATA, (void*)(&b));
		}
	}

	public unsafe static sbyte TELEPORT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TELEPORT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TELEPORT, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_BAG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_BAG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_BAG, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_BAG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_BAG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_BAG, (void*)(&b));
		}
	}

	public unsafe static sbyte CLAN_IMAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLAN_IMAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLAN_IMAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_CLANID
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_CLANID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_CLANID, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_NOT_FOCUS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_NOT_FOCUS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_NOT_FOCUS, (void*)(&b));
		}
	}

	public unsafe static sbyte SHOP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHOP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHOP, (void*)(&b));
		}
	}

	public unsafe static sbyte USE_ITEM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_ITEM, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LOAD_POINT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LOAD_POINT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LOAD_POINT, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_CAPTION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_CAPTION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_CAPTION, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_ITEM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_ITEM, (void*)(&b));
		}
	}

	public unsafe static sbyte FINISH_LOADMAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FINISH_LOADMAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FINISH_LOADMAP, (void*)(&b));
		}
	}

	public unsafe static sbyte FINISH_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FINISH_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FINISH_UPDATE, (void*)(&b));
		}
	}

	public unsafe static sbyte BODY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BODY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BODY, (void*)(&b));
		}
	}

	public unsafe static sbyte BAG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BAG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BAG, (void*)(&b));
		}
	}

	public unsafe static sbyte BOX
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOX, (void*)(&b));
		}
	}

	public unsafe static sbyte MAGIC_TREE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAGIC_TREE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAGIC_TREE, (void*)(&b));
		}
	}

	public unsafe static sbyte MAP_OFFLINE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAP_OFFLINE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAP_OFFLINE, (void*)(&b));
		}
	}

	public unsafe static sbyte BACKGROUND_TEMPLATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BACKGROUND_TEMPLATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BACKGROUND_TEMPLATE, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEM_BACKGROUND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_BACKGROUND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_BACKGROUND, (void*)(&b));
		}
	}

	public unsafe static sbyte SUB_COMMAND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUB_COMMAND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUB_COMMAND, (void*)(&b));
		}
	}

	public unsafe static sbyte NOT_LOGIN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOT_LOGIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOT_LOGIN, (void*)(&b));
		}
	}

	public unsafe static sbyte NOT_MAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOT_MAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOT_MAP, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_SESSION_ID
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_SESSION_ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_SESSION_ID, (void*)(&b));
		}
	}

	public unsafe static sbyte DIALOG_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DIALOG_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DIALOG_MESSAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte SERVER_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SERVER_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SERVER_MESSAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte MAP_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAP_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAP_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte MAP_CHANGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAP_CHANGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAP_CHANGE, (void*)(&b));
		}
	}

	public unsafe static sbyte MAP_CLEAR
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAP_CLEAR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAP_CLEAR, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEMMAP_REMOVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEMMAP_REMOVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEMMAP_REMOVE, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEMMAP_MYPICK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEMMAP_MYPICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEMMAP_MYPICK, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEMMAP_PLAYERPICK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEMMAP_PLAYERPICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEMMAP_PLAYERPICK, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_THROW
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_THROW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_THROW, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_DIE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_DIE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_DIE, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_LIVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_LIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_LIVE, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_BACK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_BACK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_BACK, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_THROW
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_THROW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_THROW, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_LIVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_LIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_LIVE, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_DIE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_DIE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_DIE, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_ATTACK_ME
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_ATTACK_ME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_ATTACK_ME, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_ATTACK_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_ATTACK_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_ATTACK_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte MOB_HP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOB_HP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOB_HP, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_DIE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_DIE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_DIE, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_MOVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_MOVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_MOVE, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_REMOVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_REMOVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_REMOVE, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_ADD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_ADD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_ADD, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_ATTACK_N_P
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_ATTACK_N_P, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_ATTACK_N_P, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_UP_EXP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_UP_EXP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_UP_EXP, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_UP_COIN_LOCK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_UP_COIN_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_UP_COIN_LOCK, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_CHANGE_COIN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_CHANGE_COIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_CHANGE_COIN, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEM_BUY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_BUY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_BUY, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEM_SALE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_SALE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_SALE, (void*)(&b));
		}
	}

	public unsafe static sbyte UPPEARL_LOCK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPPEARL_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPPEARL_LOCK, (void*)(&b));
		}
	}

	public unsafe static sbyte UPGRADE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPGRADE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPGRADE, (void*)(&b));
		}
	}

	public unsafe static sbyte PLEASE_INPUT_PARTY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLEASE_INPUT_PARTY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLEASE_INPUT_PARTY, (void*)(&b));
		}
	}

	public unsafe static sbyte ACCEPT_PLEASE_PARTY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACCEPT_PLEASE_PARTY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACCEPT_PLEASE_PARTY, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_PLAYERS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_PLAYERS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_PLAYERS, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATE_ACHIEVEMENT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE_ACHIEVEMENT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE_ACHIEVEMENT, (void*)(&b));
		}
	}

	public unsafe static sbyte PHUBANG_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHUBANG_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHUBANG_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte ZONE_CHANGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ZONE_CHANGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ZONE_CHANGE, (void*)(&b));
		}
	}

	public unsafe static sbyte MENU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MENU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MENU, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI, (void*)(&b));
		}
	}

	public unsafe static sbyte OPTION_HAT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPTION_HAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPTION_HAT, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_PT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_PT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_PT, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_SHOP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_SHOP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_SHOP, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_MENU_ID
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_MENU_ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_MENU_ID, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_COLLECT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_COLLECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_COLLECT, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_ZONE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_ZONE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_ZONE, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_TRADE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_TRADE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_TRADE, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_SAY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_SAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_SAY, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_CONFIRM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_CONFIRM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_CONFIRM, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_MENU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_MENU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_MENU, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_SELECT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_SELECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_SELECT, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_ITEM_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_ITEM_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_ITEM_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte TRADE_INVITE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRADE_INVITE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRADE_INVITE, (void*)(&b));
		}
	}

	public unsafe static sbyte TRADE_INVITE_ACCEPT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRADE_INVITE_ACCEPT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRADE_INVITE_ACCEPT, (void*)(&b));
		}
	}

	public unsafe static sbyte TRADE_LOCK_ITEM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRADE_LOCK_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRADE_LOCK_ITEM, (void*)(&b));
		}
	}

	public unsafe static sbyte TRADE_ACCEPT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRADE_ACCEPT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRADE_ACCEPT, (void*)(&b));
		}
	}

	public unsafe static sbyte TASK_GET
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TASK_GET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TASK_GET, (void*)(&b));
		}
	}

	public unsafe static sbyte TASK_NEXT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TASK_NEXT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TASK_NEXT, (void*)(&b));
		}
	}

	public unsafe static sbyte GAME_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GAME_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GAME_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte TASK_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TASK_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TASK_UPDATE, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAT_MAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT_MAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT_MAP, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_MISS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_MISS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_MISS, (void*)(&b));
		}
	}

	public unsafe static sbyte RESET_POINT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RESET_POINT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RESET_POINT, (void*)(&b));
		}
	}

	public unsafe static sbyte ALERT_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALERT_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALERT_MESSAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte AUTO_SERVER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AUTO_SERVER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AUTO_SERVER, (void*)(&b));
		}
	}

	public unsafe static sbyte ALERT_SEND_SMS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALERT_SEND_SMS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALERT_SEND_SMS, (void*)(&b));
		}
	}

	public unsafe static sbyte TRADE_INVITE_CANCEL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRADE_INVITE_CANCEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRADE_INVITE_CANCEL, (void*)(&b));
		}
	}

	public unsafe static sbyte BOSS_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOSS_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOSS_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte MABU_HOLD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MABU_HOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MABU_HOLD, (void*)(&b));
		}
	}

	public unsafe static sbyte FRIEND_INVITE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FRIEND_INVITE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FRIEND_INVITE, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_ATTACK_NPC
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_ATTACK_NPC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_ATTACK_NPC, (void*)(&b));
		}
	}

	public unsafe static sbyte HAVE_ATTACK_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HAVE_ATTACK_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HAVE_ATTACK_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_UI_NEWMENU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_UI_NEWMENU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_UI_NEWMENU, (void*)(&b));
		}
	}

	public unsafe static sbyte MOVE_FAST
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOVE_FAST, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOVE_FAST, (void*)(&b));
		}
	}

	public unsafe static sbyte TEST_INVITE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEST_INVITE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEST_INVITE, (void*)(&b));
		}
	}

	public unsafe static sbyte ADD_CUU_SAT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ADD_CUU_SAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ADD_CUU_SAT, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_CUU_SAT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_CUU_SAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_CUU_SAT, (void*)(&b));
		}
	}

	public unsafe static sbyte CLEAR_CUU_SAT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLEAR_CUU_SAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLEAR_CUU_SAT, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_UP_EXPDOWN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_UP_EXPDOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_UP_EXPDOWN, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_DIE_EXP_DOWN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_DIE_EXP_DOWN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_DIE_EXP_DOWN, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_ATTACK_P_N
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_ATTACK_P_N, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_ATTACK_P_N, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEMMAP_ADD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEMMAP_ADD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEMMAP_ADD, (void*)(&b));
		}
	}

	public unsafe static sbyte DEL_ACC
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEL_ACC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEL_ACC, (void*)(&b));
		}
	}

	public unsafe static sbyte USE_SKILL_MY_BUFF
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE_SKILL_MY_BUFF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE_SKILL_MY_BUFF, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_CHANGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_CHANGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_CHANGE, (void*)(&b));
		}
	}

	public unsafe static sbyte PARTY_INVITE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PARTY_INVITE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PARTY_INVITE, (void*)(&b));
		}
	}

	public unsafe static sbyte PARTY_ACCEPT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PARTY_ACCEPT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PARTY_ACCEPT, (void*)(&b));
		}
	}

	public unsafe static sbyte PARTY_CANCEL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PARTY_CANCEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PARTY_CANCEL, (void*)(&b));
		}
	}

	public unsafe static sbyte PLAYER_IN_PARTY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLAYER_IN_PARTY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLAYER_IN_PARTY, (void*)(&b));
		}
	}

	public unsafe static sbyte PARTY_OUT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PARTY_OUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PARTY_OUT, (void*)(&b));
		}
	}

	public unsafe static sbyte FRIEND_ADD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FRIEND_ADD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FRIEND_ADD, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_IS_DISABLE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_IS_DISABLE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_IS_DISABLE, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_IS_MOVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_IS_MOVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_IS_MOVE, (void*)(&b));
		}
	}

	public unsafe static sbyte SUMON_ATTACK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SUMON_ATTACK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SUMON_ATTACK, (void*)(&b));
		}
	}

	public unsafe static sbyte RETURN_POINT_MAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RETURN_POINT_MAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RETURN_POINT_MAP, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_IS_FIRE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_IS_FIRE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_IS_FIRE, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_IS_ICE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_IS_ICE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_IS_ICE, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_IS_WIND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_IS_WIND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_IS_WIND, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN_TEXT_BOX_ID
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_TEXT_BOX_ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_TEXT_BOX_ID, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_ITEM_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_ITEM_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_ITEM_PLAYER, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAT_PRIVATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT_PRIVATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT_PRIVATE, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAT_THEGIOI_SERVER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT_THEGIOI_SERVER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT_THEGIOI_SERVER, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAT_VIP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT_VIP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT_VIP, (void*)(&b));
		}
	}

	public unsafe static sbyte SERVER_ALERT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SERVER_ALERT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SERVER_ALERT, (void*)(&b));
		}
	}

	public unsafe static sbyte ME_UP_COIN_BAG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ME_UP_COIN_BAG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ME_UP_COIN_BAG, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_TASK_ORDER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_TASK_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_TASK_ORDER, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_TASK_UPDATE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_TASK_UPDATE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_TASK_UPDATE, (void*)(&b));
		}
	}

	public unsafe static sbyte CLEAR_TASK_ORDER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLEAR_TASK_ORDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLEAR_TASK_ORDER, (void*)(&b));
		}
	}

	public unsafe static sbyte ADD_ITEM_MAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ADD_ITEM_MAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ADD_ITEM_MAP, (void*)(&b));
		}
	}

	public unsafe static sbyte MATRIX_CHALLENGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MATRIX_CHALLENGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MATRIX_CHALLENGE, (void*)(&b));
		}
	}

	public unsafe static sbyte ECC_CHALLENGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ECC_CHALLENGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ECC_CHALLENGE, (void*)(&b));
		}
	}

	public unsafe static sbyte TRANSPORT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANSPORT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANSPORT, (void*)(&b));
		}
	}

	public unsafe static sbyte ITEM_TIME
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ITEM_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ITEM_TIME, (void*)(&b));
		}
	}

	public unsafe static sbyte PET_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PET_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PET_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte PET_STATUS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PET_STATUS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PET_STATUS, (void*)(&b));
		}
	}

	public unsafe static sbyte SERVER_DATA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SERVER_DATA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SERVER_DATA, (void*)(&b));
		}
	}

	public unsafe static sbyte CLIENT_INPUT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLIENT_INPUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLIENT_INPUT, (void*)(&b));
		}
	}

	public unsafe static sbyte HOLD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOLD, (void*)(&b));
		}
	}

	public unsafe static sbyte SHOW_ADS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHOW_ADS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHOW_ADS, (void*)(&b));
		}
	}

	public unsafe static sbyte LOGIN_DE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOGIN_DE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOGIN_DE, (void*)(&b));
		}
	}

	public unsafe static sbyte SET_POS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SET_POS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SET_POS, (void*)(&b));
		}
	}

	public unsafe static sbyte NPC_CHAT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NPC_CHAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NPC_CHAT, (void*)(&b));
		}
	}

	public unsafe static sbyte FUSION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FUSION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FUSION, (void*)(&b));
		}
	}

	public unsafe static sbyte ANDROID_PACK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ANDROID_PACK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ANDROID_PACK, (void*)(&b));
		}
	}

	public unsafe static sbyte GET_IMAGE_SOURCE2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_IMAGE_SOURCE2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_IMAGE_SOURCE2, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAGE_MOD_BODY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAGE_MOD_BODY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAGE_MOD_BODY, (void*)(&b));
		}
	}

	public unsafe static sbyte CHANGE_ONSKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHANGE_ONSKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHANGE_ONSKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte REQUEST_PEAN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REQUEST_PEAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REQUEST_PEAN, (void*)(&b));
		}
	}

	public unsafe static sbyte POWER_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POWER_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POWER_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte AUTOPLAY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AUTOPLAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AUTOPLAY, (void*)(&b));
		}
	}

	public unsafe static sbyte MABU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MABU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MABU, (void*)(&b));
		}
	}

	public unsafe static sbyte THACHDAU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THACHDAU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THACHDAU, (void*)(&b));
		}
	}

	public unsafe static sbyte THELUC
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THELUC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THELUC, (void*)(&b));
		}
	}

	public unsafe static sbyte UPDATECHAR_MP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATECHAR_MP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATECHAR_MP, (void*)(&b));
		}
	}

	public unsafe static sbyte REFRESH_ITEM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REFRESH_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REFRESH_ITEM, (void*)(&b));
		}
	}

	public unsafe static sbyte CHECK_CONTROLLER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHECK_CONTROLLER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHECK_CONTROLLER, (void*)(&b));
		}
	}

	public unsafe static sbyte CHECK_MAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHECK_MAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHECK_MAP, (void*)(&b));
		}
	}

	public unsafe static sbyte BIG_BOSS
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BIG_BOSS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BIG_BOSS, (void*)(&b));
		}
	}

	public unsafe static sbyte BIG_BOSS_2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BIG_BOSS_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BIG_BOSS_2, (void*)(&b));
		}
	}

	public unsafe static sbyte DUAHAU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DUAHAU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DUAHAU, (void*)(&b));
		}
	}

	public unsafe static sbyte QUAYSO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QUAYSO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QUAYSO, (void*)(&b));
		}
	}

	public unsafe static sbyte USER_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USER_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USER_INFO, (void*)(&b));
		}
	}

	public unsafe static sbyte OPEN3HOUR
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN3HOUR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN3HOUR, (void*)(&b));
		}
	}

	public unsafe static sbyte STATUS_PET
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STATUS_PET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STATUS_PET, (void*)(&b));
		}
	}

	public unsafe static sbyte SPEACIAL_SKILL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SPEACIAL_SKILL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SPEACIAL_SKILL, (void*)(&b));
		}
	}

	public unsafe static sbyte SERVER_EFFECT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SERVER_EFFECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SERVER_EFFECT, (void*)(&b));
		}
	}

	public unsafe static sbyte INAPP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INAPP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INAPP, (void*)(&b));
		}
	}

	public unsafe static sbyte BATCH_MESSAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BATCH_MESSAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BATCH_MESSAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte LUCKY_ROUND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LUCKY_ROUND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LUCKY_ROUND, (void*)(&b));
		}
	}

	public unsafe static sbyte RADA_CARD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RADA_CARD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RADA_CARD, (void*)(&b));
		}
	}

	public unsafe static sbyte CHAR_EFFECT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAR_EFFECT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAR_EFFECT, (void*)(&b));
		}
	}

	static Cmd()
	{
		Il2CppClassPointerStore<Cmd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Cmd");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cmd>.NativeClassPtr);
		NativeFieldInfoPtr_LOGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LOGIN");
		NativeFieldInfoPtr_REGISTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REGISTER");
		NativeFieldInfoPtr_CLIENT_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLIENT_INFO");
		NativeFieldInfoPtr_SEND_SMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SEND_SMS");
		NativeFieldInfoPtr_REGISTER_IMAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REGISTER_IMAGE");
		NativeFieldInfoPtr_MESSAGE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MESSAGE_TIME");
		NativeFieldInfoPtr_LOGOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LOGOUT");
		NativeFieldInfoPtr_SELECT_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SELECT_PLAYER");
		NativeFieldInfoPtr_CREATE_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CREATE_PLAYER");
		NativeFieldInfoPtr_DELETE_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "DELETE_PLAYER");
		NativeFieldInfoPtr_UPDATE_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_VERSION");
		NativeFieldInfoPtr_UPDATE_MAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_MAP");
		NativeFieldInfoPtr_UPDATE_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_SKILL");
		NativeFieldInfoPtr_UPDATE_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_ITEM");
		NativeFieldInfoPtr_REQUEST_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_SKILL");
		NativeFieldInfoPtr_REQUEST_MAPTEMPLATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_MAPTEMPLATE");
		NativeFieldInfoPtr_REQUEST_NPCTEMPLATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_NPCTEMPLATE");
		NativeFieldInfoPtr_REQUEST_NPCPLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_NPCPLAYER");
		NativeFieldInfoPtr_UPDATE_TYPE_PK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_TYPE_PK");
		NativeFieldInfoPtr_PLAYER_ATTACK_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_ATTACK_PLAYER");
		NativeFieldInfoPtr_PLAYER_VS_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_VS_PLAYER");
		NativeFieldInfoPtr_CLAN_PARTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_PARTY");
		NativeFieldInfoPtr_CLAN_INVITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_INVITE");
		NativeFieldInfoPtr_CLAN_REMOTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_REMOTE");
		NativeFieldInfoPtr_CLAN_LEAVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_LEAVE");
		NativeFieldInfoPtr_CLAN_DONATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_DONATE");
		NativeFieldInfoPtr_CLAN_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_MESSAGE");
		NativeFieldInfoPtr_CLAN_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_UPDATE");
		NativeFieldInfoPtr_CLAN_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_INFO");
		NativeFieldInfoPtr_CLAN_JOIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_JOIN");
		NativeFieldInfoPtr_CLAN_MEMBER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_MEMBER");
		NativeFieldInfoPtr_CLAN_SEARCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_SEARCH");
		NativeFieldInfoPtr_CLAN_CREATE_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_CREATE_INFO");
		NativeFieldInfoPtr_CLIENT_OK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLIENT_OK");
		NativeFieldInfoPtr_CLIENT_OK_INMAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLIENT_OK_INMAP");
		NativeFieldInfoPtr_UPDATE_VERSION_OK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_VERSION_OK");
		NativeFieldInfoPtr_INPUT_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "INPUT_CARD");
		NativeFieldInfoPtr_CLEAR_TASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLEAR_TASK");
		NativeFieldInfoPtr_CHANGE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHANGE_NAME");
		NativeFieldInfoPtr_UPDATE_PK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_PK");
		NativeFieldInfoPtr_CREATE_CLAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CREATE_CLAN");
		NativeFieldInfoPtr_CONVERT_UPGRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CONVERT_UPGRADE");
		NativeFieldInfoPtr_INVITE_CLANDUN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "INVITE_CLANDUN");
		NativeFieldInfoPtr_NOT_USEACC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NOT_USEACC");
		NativeFieldInfoPtr_ME_LOAD_ACTIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_ACTIVE");
		NativeFieldInfoPtr_ME_ACTIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_ACTIVE");
		NativeFieldInfoPtr_ME_UPDATE_ACTIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_UPDATE_ACTIVE");
		NativeFieldInfoPtr_ME_OPEN_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_OPEN_LOCK");
		NativeFieldInfoPtr_ITEM_SPLIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEM_SPLIT");
		NativeFieldInfoPtr_ME_CLEAR_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_CLEAR_LOCK");
		NativeFieldInfoPtr_GET_IMG_BY_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_IMG_BY_NAME");
		NativeFieldInfoPtr_ME_LOAD_ALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_ALL");
		NativeFieldInfoPtr_ME_LOAD_CLASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_CLASS");
		NativeFieldInfoPtr_ME_LOAD_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_SKILL");
		NativeFieldInfoPtr_ME_LOAD_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_INFO");
		NativeFieldInfoPtr_ME_LOAD_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_HP");
		NativeFieldInfoPtr_ME_LOAD_MP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_MP");
		NativeFieldInfoPtr_PLAYER_LOAD_ALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_ALL");
		NativeFieldInfoPtr_PLAYER_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_SPEED");
		NativeFieldInfoPtr_PLAYER_LOAD_LEVEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_LEVEL");
		NativeFieldInfoPtr_PLAYER_LOAD_VUKHI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_VUKHI");
		NativeFieldInfoPtr_PLAYER_LOAD_AO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_AO");
		NativeFieldInfoPtr_PLAYER_LOAD_QUAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_QUAN");
		NativeFieldInfoPtr_PLAYER_LOAD_BODY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_BODY");
		NativeFieldInfoPtr_PLAYER_LOAD_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_HP");
		NativeFieldInfoPtr_PLAYER_LOAD_LIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_LOAD_LIVE");
		NativeFieldInfoPtr_GOTO_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GOTO_PLAYER");
		NativeFieldInfoPtr_POTENTIAL_UP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "POTENTIAL_UP");
		NativeFieldInfoPtr_SKILL_UP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SKILL_UP");
		NativeFieldInfoPtr_BAG_SORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BAG_SORT");
		NativeFieldInfoPtr_BOX_SORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BOX_SORT");
		NativeFieldInfoPtr_BOX_COIN_OUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BOX_COIN_OUT");
		NativeFieldInfoPtr_REQUEST_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_ITEM");
		NativeFieldInfoPtr_ME_ADD_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_ADD_SKILL");
		NativeFieldInfoPtr_ME_UPDATE_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_UPDATE_SKILL");
		NativeFieldInfoPtr_GET_PLAYER_MENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_PLAYER_MENU");
		NativeFieldInfoPtr_PLAYER_MENU_ACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_MENU_ACTION");
		NativeFieldInfoPtr_SAVE_RMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SAVE_RMS");
		NativeFieldInfoPtr_LOAD_RMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LOAD_RMS");
		NativeFieldInfoPtr_USE_BOOK_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "USE_BOOK_SKILL");
		NativeFieldInfoPtr_LOCK_INVENTORY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LOCK_INVENTORY");
		NativeFieldInfoPtr_CHANGE_FLAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHANGE_FLAG");
		NativeFieldInfoPtr_LOGINFAIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LOGINFAIL");
		NativeFieldInfoPtr_LOGIN2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LOGIN2");
		NativeFieldInfoPtr_KIGUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "KIGUI");
		NativeFieldInfoPtr_ENEMY_LIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ENEMY_LIST");
		NativeFieldInfoPtr_ANDROID_IAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ANDROID_IAP");
		NativeFieldInfoPtr_UPDATE_ACTIVEPOINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_ACTIVEPOINT");
		NativeFieldInfoPtr_TOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TOP");
		NativeFieldInfoPtr_MOB_ME_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MOB_ME_UPDATE");
		NativeFieldInfoPtr_UPDATE_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_COOLDOWN");
		NativeFieldInfoPtr_BGITEM_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BGITEM_VERSION");
		NativeFieldInfoPtr_SET_CLIENTTYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SET_CLIENTTYPE");
		NativeFieldInfoPtr_MAP_TRASPORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MAP_TRASPORT");
		NativeFieldInfoPtr_UPDATE_BODY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_BODY");
		NativeFieldInfoPtr_SERVERSCREEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SERVERSCREEN");
		NativeFieldInfoPtr_UPDATE_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_DATA");
		NativeFieldInfoPtr_GIAO_DICH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GIAO_DICH");
		NativeFieldInfoPtr_MOB_CAPCHA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MOB_CAPCHA");
		NativeFieldInfoPtr_MOB_MAX_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MOB_MAX_HP");
		NativeFieldInfoPtr_CALL_DRAGON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CALL_DRAGON");
		NativeFieldInfoPtr_TILE_SET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TILE_SET");
		NativeFieldInfoPtr_COMBINNE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "COMBINNE");
		NativeFieldInfoPtr_FRIEND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "FRIEND");
		NativeFieldInfoPtr_PLAYER_MENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_MENU");
		NativeFieldInfoPtr_CHECK_MOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHECK_MOVE");
		NativeFieldInfoPtr_SMALLIMAGE_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SMALLIMAGE_VERSION");
		NativeFieldInfoPtr_ARCHIVEMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ARCHIVEMENT");
		NativeFieldInfoPtr_NPC_BOSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_BOSS");
		NativeFieldInfoPtr_GET_IMAGE_SOURCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_IMAGE_SOURCE");
		NativeFieldInfoPtr_NPC_ADD_REMOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_ADD_REMOVE");
		NativeFieldInfoPtr_CHAT_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAT_PLAYER");
		NativeFieldInfoPtr_CHAT_THEGIOI_CLIENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAT_THEGIOI_CLIENT");
		NativeFieldInfoPtr_BIG_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BIG_MESSAGE");
		NativeFieldInfoPtr_MAXSTAMINA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MAXSTAMINA");
		NativeFieldInfoPtr_STAMINA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "STAMINA");
		NativeFieldInfoPtr_REQUEST_ICON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_ICON");
		NativeFieldInfoPtr_GET_EFFDATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_EFFDATA");
		NativeFieldInfoPtr_TELEPORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TELEPORT");
		NativeFieldInfoPtr_UPDATE_BAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_BAG");
		NativeFieldInfoPtr_GET_BAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_BAG");
		NativeFieldInfoPtr_CLAN_IMAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLAN_IMAGE");
		NativeFieldInfoPtr_UPDATE_CLANID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_CLANID");
		NativeFieldInfoPtr_SKILL_NOT_FOCUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SKILL_NOT_FOCUS");
		NativeFieldInfoPtr_SHOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SHOP");
		NativeFieldInfoPtr_USE_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "USE_ITEM");
		NativeFieldInfoPtr_ME_LOAD_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LOAD_POINT");
		NativeFieldInfoPtr_UPDATE_CAPTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_CAPTION");
		NativeFieldInfoPtr_GET_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_ITEM");
		NativeFieldInfoPtr_FINISH_LOADMAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "FINISH_LOADMAP");
		NativeFieldInfoPtr_FINISH_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "FINISH_UPDATE");
		NativeFieldInfoPtr_BODY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BODY");
		NativeFieldInfoPtr_BAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BAG");
		NativeFieldInfoPtr_BOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BOX");
		NativeFieldInfoPtr_MAGIC_TREE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MAGIC_TREE");
		NativeFieldInfoPtr_MAP_OFFLINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MAP_OFFLINE");
		NativeFieldInfoPtr_BACKGROUND_TEMPLATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BACKGROUND_TEMPLATE");
		NativeFieldInfoPtr_ITEM_BACKGROUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEM_BACKGROUND");
		NativeFieldInfoPtr_SUB_COMMAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SUB_COMMAND");
		NativeFieldInfoPtr_NOT_LOGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NOT_LOGIN");
		NativeFieldInfoPtr_NOT_MAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NOT_MAP");
		NativeFieldInfoPtr_GET_SESSION_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_SESSION_ID");
		NativeFieldInfoPtr_DIALOG_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "DIALOG_MESSAGE");
		NativeFieldInfoPtr_SERVER_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SERVER_MESSAGE");
		NativeFieldInfoPtr_MAP_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MAP_INFO");
		NativeFieldInfoPtr_MAP_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MAP_CHANGE");
		NativeFieldInfoPtr_MAP_CLEAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MAP_CLEAR");
		NativeFieldInfoPtr_ITEMMAP_REMOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEMMAP_REMOVE");
		NativeFieldInfoPtr_ITEMMAP_MYPICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEMMAP_MYPICK");
		NativeFieldInfoPtr_ITEMMAP_PLAYERPICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEMMAP_PLAYERPICK");
		NativeFieldInfoPtr_ME_THROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_THROW");
		NativeFieldInfoPtr_ME_DIE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_DIE");
		NativeFieldInfoPtr_ME_LIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_LIVE");
		NativeFieldInfoPtr_ME_BACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_BACK");
		NativeFieldInfoPtr_PLAYER_THROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_THROW");
		NativeFieldInfoPtr_NPC_LIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_LIVE");
		NativeFieldInfoPtr_NPC_DIE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_DIE");
		NativeFieldInfoPtr_NPC_ATTACK_ME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_ATTACK_ME");
		NativeFieldInfoPtr_NPC_ATTACK_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_ATTACK_PLAYER");
		NativeFieldInfoPtr_MOB_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MOB_HP");
		NativeFieldInfoPtr_PLAYER_DIE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_DIE");
		NativeFieldInfoPtr_PLAYER_MOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_MOVE");
		NativeFieldInfoPtr_PLAYER_REMOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_REMOVE");
		NativeFieldInfoPtr_PLAYER_ADD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_ADD");
		NativeFieldInfoPtr_PLAYER_ATTACK_N_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_ATTACK_N_P");
		NativeFieldInfoPtr_PLAYER_UP_EXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_UP_EXP");
		NativeFieldInfoPtr_ME_UP_COIN_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_UP_COIN_LOCK");
		NativeFieldInfoPtr_ME_CHANGE_COIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_CHANGE_COIN");
		NativeFieldInfoPtr_ITEM_BUY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEM_BUY");
		NativeFieldInfoPtr_ITEM_SALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEM_SALE");
		NativeFieldInfoPtr_UPPEARL_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPPEARL_LOCK");
		NativeFieldInfoPtr_UPGRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPGRADE");
		NativeFieldInfoPtr_PLEASE_INPUT_PARTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLEASE_INPUT_PARTY");
		NativeFieldInfoPtr_ACCEPT_PLEASE_PARTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ACCEPT_PLEASE_PARTY");
		NativeFieldInfoPtr_REQUEST_PLAYERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_PLAYERS");
		NativeFieldInfoPtr_UPDATE_ACHIEVEMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATE_ACHIEVEMENT");
		NativeFieldInfoPtr_PHUBANG_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PHUBANG_INFO");
		NativeFieldInfoPtr_ZONE_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ZONE_CHANGE");
		NativeFieldInfoPtr_MENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MENU");
		NativeFieldInfoPtr_OPEN_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI");
		NativeFieldInfoPtr_OPTION_HAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPTION_HAT");
		NativeFieldInfoPtr_OPEN_UI_PT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_PT");
		NativeFieldInfoPtr_OPEN_UI_SHOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_SHOP");
		NativeFieldInfoPtr_OPEN_MENU_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_MENU_ID");
		NativeFieldInfoPtr_OPEN_UI_COLLECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_COLLECT");
		NativeFieldInfoPtr_OPEN_UI_ZONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_ZONE");
		NativeFieldInfoPtr_OPEN_UI_TRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_TRADE");
		NativeFieldInfoPtr_OPEN_UI_SAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_SAY");
		NativeFieldInfoPtr_OPEN_UI_CONFIRM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_CONFIRM");
		NativeFieldInfoPtr_OPEN_UI_MENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_MENU");
		NativeFieldInfoPtr_SKILL_SELECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SKILL_SELECT");
		NativeFieldInfoPtr_REQUEST_ITEM_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_ITEM_INFO");
		NativeFieldInfoPtr_TRADE_INVITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TRADE_INVITE");
		NativeFieldInfoPtr_TRADE_INVITE_ACCEPT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TRADE_INVITE_ACCEPT");
		NativeFieldInfoPtr_TRADE_LOCK_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TRADE_LOCK_ITEM");
		NativeFieldInfoPtr_TRADE_ACCEPT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TRADE_ACCEPT");
		NativeFieldInfoPtr_TASK_GET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TASK_GET");
		NativeFieldInfoPtr_TASK_NEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TASK_NEXT");
		NativeFieldInfoPtr_GAME_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GAME_INFO");
		NativeFieldInfoPtr_TASK_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TASK_UPDATE");
		NativeFieldInfoPtr_CHAT_MAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAT_MAP");
		NativeFieldInfoPtr_NPC_MISS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_MISS");
		NativeFieldInfoPtr_RESET_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "RESET_POINT");
		NativeFieldInfoPtr_ALERT_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ALERT_MESSAGE");
		NativeFieldInfoPtr_AUTO_SERVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "AUTO_SERVER");
		NativeFieldInfoPtr_ALERT_SEND_SMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ALERT_SEND_SMS");
		NativeFieldInfoPtr_TRADE_INVITE_CANCEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TRADE_INVITE_CANCEL");
		NativeFieldInfoPtr_BOSS_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BOSS_SKILL");
		NativeFieldInfoPtr_MABU_HOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MABU_HOLD");
		NativeFieldInfoPtr_FRIEND_INVITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "FRIEND_INVITE");
		NativeFieldInfoPtr_PLAYER_ATTACK_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_ATTACK_NPC");
		NativeFieldInfoPtr_HAVE_ATTACK_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "HAVE_ATTACK_PLAYER");
		NativeFieldInfoPtr_OPEN_UI_NEWMENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_UI_NEWMENU");
		NativeFieldInfoPtr_MOVE_FAST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MOVE_FAST");
		NativeFieldInfoPtr_TEST_INVITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TEST_INVITE");
		NativeFieldInfoPtr_ADD_CUU_SAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ADD_CUU_SAT");
		NativeFieldInfoPtr_ME_CUU_SAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_CUU_SAT");
		NativeFieldInfoPtr_CLEAR_CUU_SAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLEAR_CUU_SAT");
		NativeFieldInfoPtr_PLAYER_UP_EXPDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_UP_EXPDOWN");
		NativeFieldInfoPtr_ME_DIE_EXP_DOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_DIE_EXP_DOWN");
		NativeFieldInfoPtr_PLAYER_ATTACK_P_N = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_ATTACK_P_N");
		NativeFieldInfoPtr_ITEMMAP_ADD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEMMAP_ADD");
		NativeFieldInfoPtr_DEL_ACC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "DEL_ACC");
		NativeFieldInfoPtr_USE_SKILL_MY_BUFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "USE_SKILL_MY_BUFF");
		NativeFieldInfoPtr_NPC_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_CHANGE");
		NativeFieldInfoPtr_PARTY_INVITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PARTY_INVITE");
		NativeFieldInfoPtr_PARTY_ACCEPT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PARTY_ACCEPT");
		NativeFieldInfoPtr_PARTY_CANCEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PARTY_CANCEL");
		NativeFieldInfoPtr_PLAYER_IN_PARTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PLAYER_IN_PARTY");
		NativeFieldInfoPtr_PARTY_OUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PARTY_OUT");
		NativeFieldInfoPtr_FRIEND_ADD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "FRIEND_ADD");
		NativeFieldInfoPtr_NPC_IS_DISABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_IS_DISABLE");
		NativeFieldInfoPtr_NPC_IS_MOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_IS_MOVE");
		NativeFieldInfoPtr_SUMON_ATTACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SUMON_ATTACK");
		NativeFieldInfoPtr_RETURN_POINT_MAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "RETURN_POINT_MAP");
		NativeFieldInfoPtr_NPC_IS_FIRE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_IS_FIRE");
		NativeFieldInfoPtr_NPC_IS_ICE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_IS_ICE");
		NativeFieldInfoPtr_NPC_IS_WIND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_IS_WIND");
		NativeFieldInfoPtr_OPEN_TEXT_BOX_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN_TEXT_BOX_ID");
		NativeFieldInfoPtr_REQUEST_ITEM_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_ITEM_PLAYER");
		NativeFieldInfoPtr_CHAT_PRIVATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAT_PRIVATE");
		NativeFieldInfoPtr_CHAT_THEGIOI_SERVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAT_THEGIOI_SERVER");
		NativeFieldInfoPtr_CHAT_VIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAT_VIP");
		NativeFieldInfoPtr_SERVER_ALERT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SERVER_ALERT");
		NativeFieldInfoPtr_ME_UP_COIN_BAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ME_UP_COIN_BAG");
		NativeFieldInfoPtr_GET_TASK_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_TASK_ORDER");
		NativeFieldInfoPtr_GET_TASK_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_TASK_UPDATE");
		NativeFieldInfoPtr_CLEAR_TASK_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLEAR_TASK_ORDER");
		NativeFieldInfoPtr_ADD_ITEM_MAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ADD_ITEM_MAP");
		NativeFieldInfoPtr_MATRIX_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MATRIX_CHALLENGE");
		NativeFieldInfoPtr_ECC_CHALLENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ECC_CHALLENGE");
		NativeFieldInfoPtr_TRANSPORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "TRANSPORT");
		NativeFieldInfoPtr_ITEM_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ITEM_TIME");
		NativeFieldInfoPtr_PET_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PET_INFO");
		NativeFieldInfoPtr_PET_STATUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "PET_STATUS");
		NativeFieldInfoPtr_SERVER_DATA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SERVER_DATA");
		NativeFieldInfoPtr_CLIENT_INPUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CLIENT_INPUT");
		NativeFieldInfoPtr_HOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "HOLD");
		NativeFieldInfoPtr_SHOW_ADS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SHOW_ADS");
		NativeFieldInfoPtr_LOGIN_DE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LOGIN_DE");
		NativeFieldInfoPtr_SET_POS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SET_POS");
		NativeFieldInfoPtr_NPC_CHAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "NPC_CHAT");
		NativeFieldInfoPtr_FUSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "FUSION");
		NativeFieldInfoPtr_ANDROID_PACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "ANDROID_PACK");
		NativeFieldInfoPtr_GET_IMAGE_SOURCE2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "GET_IMAGE_SOURCE2");
		NativeFieldInfoPtr_CHAGE_MOD_BODY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAGE_MOD_BODY");
		NativeFieldInfoPtr_CHANGE_ONSKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHANGE_ONSKILL");
		NativeFieldInfoPtr_REQUEST_PEAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REQUEST_PEAN");
		NativeFieldInfoPtr_POWER_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "POWER_INFO");
		NativeFieldInfoPtr_AUTOPLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "AUTOPLAY");
		NativeFieldInfoPtr_MABU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "MABU");
		NativeFieldInfoPtr_THACHDAU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "THACHDAU");
		NativeFieldInfoPtr_THELUC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "THELUC");
		NativeFieldInfoPtr_UPDATECHAR_MP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "UPDATECHAR_MP");
		NativeFieldInfoPtr_REFRESH_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "REFRESH_ITEM");
		NativeFieldInfoPtr_CHECK_CONTROLLER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHECK_CONTROLLER");
		NativeFieldInfoPtr_CHECK_MAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHECK_MAP");
		NativeFieldInfoPtr_BIG_BOSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BIG_BOSS");
		NativeFieldInfoPtr_BIG_BOSS_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BIG_BOSS_2");
		NativeFieldInfoPtr_DUAHAU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "DUAHAU");
		NativeFieldInfoPtr_QUAYSO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "QUAYSO");
		NativeFieldInfoPtr_USER_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "USER_INFO");
		NativeFieldInfoPtr_OPEN3HOUR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "OPEN3HOUR");
		NativeFieldInfoPtr_STATUS_PET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "STATUS_PET");
		NativeFieldInfoPtr_SPEACIAL_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SPEACIAL_SKILL");
		NativeFieldInfoPtr_SERVER_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "SERVER_EFFECT");
		NativeFieldInfoPtr_INAPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "INAPP");
		NativeFieldInfoPtr_BATCH_MESSAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "BATCH_MESSAGE");
		NativeFieldInfoPtr_LUCKY_ROUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "LUCKY_ROUND");
		NativeFieldInfoPtr_RADA_CARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "RADA_CARD");
		NativeFieldInfoPtr_CHAR_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cmd>.NativeClassPtr, "CHAR_EFFECT");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cmd>.NativeClassPtr, 100663736);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Cmd()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cmd>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Cmd(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
