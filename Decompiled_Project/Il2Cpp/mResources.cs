using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class mResources : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_learnSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_updSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_proficiency;

	private static readonly System.IntPtr NativeFieldInfoPtr_delacc;

	private static readonly System.IntPtr NativeFieldInfoPtr_notiINAPP;

	private static readonly System.IntPtr NativeFieldInfoPtr_notiRuby;

	private static readonly System.IntPtr NativeFieldInfoPtr_equip;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_radaCard;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_enough_money_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_napngoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_functionMaintain1;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_quantity_to_buy;

	private static readonly System.IntPtr NativeFieldInfoPtr_tang;

	private static readonly System.IntPtr NativeFieldInfoPtr_kquaVongQuay;

	private static readonly System.IntPtr NativeFieldInfoPtr_useGem;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr_choitiep;

	private static readonly System.IntPtr NativeFieldInfoPtr_attack;

	private static readonly System.IntPtr NativeFieldInfoPtr_defend;

	private static readonly System.IntPtr NativeFieldInfoPtr_follow;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_gohome;

	private static readonly System.IntPtr NativeFieldInfoPtr_pet;

	private static readonly System.IntPtr NativeFieldInfoPtr_maychutathoacmatsong;

	private static readonly System.IntPtr NativeFieldInfoPtr_cauhinhthap;

	private static readonly System.IntPtr NativeFieldInfoPtr_cauhinhcao;

	private static readonly System.IntPtr NativeFieldInfoPtr_combineSpell;

	private static readonly System.IntPtr NativeFieldInfoPtr_combineFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_combineSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnOnAnalog;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnOffAnalog;

	private static readonly System.IntPtr NativeFieldInfoPtr_analog;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventory_Pass;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_Inventory_Pass;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_Inventory_Pass_wrong;

	private static readonly System.IntPtr NativeFieldInfoPtr_REGISTOPROTECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnOnSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnOffSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_REGISTERING;

	private static readonly System.IntPtr NativeFieldInfoPtr_SENDINGMSG;

	private static readonly System.IntPtr NativeFieldInfoPtr_SENTMSG;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOSENDMSG;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendMsgSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_cannotSendMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendGuessMsgSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendMsgFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALERT_PRIVATE_PASS_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_ALERT_PRIVATE_PASS_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_PRIVATE_PASS;

	private static readonly System.IntPtr NativeFieldInfoPtr_change_account;

	private static readonly System.IntPtr NativeFieldInfoPtr_alreadyHadAccount1;

	private static readonly System.IntPtr NativeFieldInfoPtr_alreadyHadAccount2;

	private static readonly System.IntPtr NativeFieldInfoPtr_userBlank;

	private static readonly System.IntPtr NativeFieldInfoPtr_passwordBlank;

	private static readonly System.IntPtr NativeFieldInfoPtr_accTooShort;

	private static readonly System.IntPtr NativeFieldInfoPtr_phoneInvalid;

	private static readonly System.IntPtr NativeFieldInfoPtr_emailInvalid;

	private static readonly System.IntPtr NativeFieldInfoPtr_registerNewAcc;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectServer2;

	private static readonly System.IntPtr NativeFieldInfoPtr_forgetPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_password;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOGINLABELS;

	private static readonly System.IntPtr NativeFieldInfoPtr_msg;

	private static readonly System.IntPtr NativeFieldInfoPtr_msgg;

	private static readonly System.IntPtr NativeFieldInfoPtr_no_msg;

	private static readonly System.IntPtr NativeFieldInfoPtr_cancelAccountProtection;

	private static readonly System.IntPtr NativeFieldInfoPtr_plsCheckAcc;

	private static readonly System.IntPtr NativeFieldInfoPtr_phone;

	private static readonly System.IntPtr NativeFieldInfoPtr_email;

	private static readonly System.IntPtr NativeFieldInfoPtr_acc;

	private static readonly System.IntPtr NativeFieldInfoPtr_pwd;

	private static readonly System.IntPtr NativeFieldInfoPtr_goToWebForPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_dragon_ball;

	private static readonly System.IntPtr NativeFieldInfoPtr_character;

	private static readonly System.IntPtr NativeFieldInfoPtr_account;

	private static readonly System.IntPtr NativeFieldInfoPtr_account_server;

	private static readonly System.IntPtr NativeFieldInfoPtr_char_name_blank;

	private static readonly System.IntPtr NativeFieldInfoPtr_char_name_short;

	private static readonly System.IntPtr NativeFieldInfoPtr_char_name_long;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeNameChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_char_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_login;

	private static readonly System.IntPtr NativeFieldInfoPtr_login2;

	private static readonly System.IntPtr NativeFieldInfoPtr_register;

	private static readonly System.IntPtr NativeFieldInfoPtr_WAIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PLEASEWAIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONNECTING;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOGGING;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOADING;

	private static readonly System.IntPtr NativeFieldInfoPtr_downloading_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_select_server;

	private static readonly System.IntPtr NativeFieldInfoPtr_pls_restart_game_error;

	private static readonly System.IntPtr NativeFieldInfoPtr_lost_connection;

	private static readonly System.IntPtr NativeFieldInfoPtr_check_3G;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_change_zone;

	private static readonly System.IntPtr NativeFieldInfoPtr_select_zone;

	private static readonly System.IntPtr NativeFieldInfoPtr_website;

	private static readonly System.IntPtr NativeFieldInfoPtr_server;

	private static readonly System.IntPtr NativeFieldInfoPtr_planet;

	private static readonly System.IntPtr NativeFieldInfoPtr_MENUME;

	private static readonly System.IntPtr NativeFieldInfoPtr_MENUNEWCHAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_MENUGENDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAR_ORDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainTab1;

	private static readonly System.IntPtr NativeFieldInfoPtr_mainTab2;

	private static readonly System.IntPtr NativeFieldInfoPtr_petMainTab;

	private static readonly System.IntPtr NativeFieldInfoPtr_petMainTab2;

	private static readonly System.IntPtr NativeFieldInfoPtr_key_skill_qwerty;

	private static readonly System.IntPtr NativeFieldInfoPtr_key_skill;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_FAIL;

	private static readonly System.IntPtr NativeFieldInfoPtr_HP_EMPTY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZONE_HERE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DES_TASK;

	private static readonly System.IntPtr NativeFieldInfoPtr_DIES;

	private static readonly System.IntPtr NativeFieldInfoPtr_SYNTHESIS;

	private static readonly System.IntPtr NativeFieldInfoPtr_tips;

	private static readonly System.IntPtr NativeFieldInfoPtr_TASK_INPUT_CLASS;

	private static readonly System.IntPtr NativeFieldInfoPtr_SERI_NUM;

	private static readonly System.IntPtr NativeFieldInfoPtr_CARD_CODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_pay_card;

	private static readonly System.IntPtr NativeFieldInfoPtr_pay_card2;

	private static readonly System.IntPtr NativeFieldInfoPtr_serial_blank;

	private static readonly System.IntPtr NativeFieldInfoPtr_card_code_blank;

	private static readonly System.IntPtr NativeFieldInfoPtr_billion;

	private static readonly System.IntPtr NativeFieldInfoPtr_million;

	private static readonly System.IntPtr NativeFieldInfoPtr_MENU;

	private static readonly System.IntPtr NativeFieldInfoPtr_CLOSE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ON;

	private static readonly System.IntPtr NativeFieldInfoPtr_OFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_DELETE;

	private static readonly System.IntPtr NativeFieldInfoPtr_VIEW;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONTINUE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEXTSTEP;

	private static readonly System.IntPtr NativeFieldInfoPtr_USE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_YES;

	private static readonly System.IntPtr NativeFieldInfoPtr_NO;

	private static readonly System.IntPtr NativeFieldInfoPtr_EXIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_REVENGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_OK;

	private static readonly System.IntPtr NativeFieldInfoPtr_retry;

	private static readonly System.IntPtr NativeFieldInfoPtr_uncheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_remember;

	private static readonly System.IntPtr NativeFieldInfoPtr_ACCEPT;

	private static readonly System.IntPtr NativeFieldInfoPtr_CANCEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_SELECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_enter;

	private static readonly System.IntPtr NativeFieldInfoPtr_open_link;

	private static readonly System.IntPtr NativeFieldInfoPtr_DOYOUWANTEXIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEWCHAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_BACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOCKED;

	private static readonly System.IntPtr NativeFieldInfoPtr_KILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_KILLBOSS;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOLOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_XU;

	private static readonly System.IntPtr NativeFieldInfoPtr_LUONG;

	private static readonly System.IntPtr NativeFieldInfoPtr_RUBY;

	private static readonly System.IntPtr NativeFieldInfoPtr_PK_NOW;

	private static readonly System.IntPtr NativeFieldInfoPtr_CUU_SAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOT_ENOUGH_MP;

	private static readonly System.IntPtr NativeFieldInfoPtr_you_receive;

	private static readonly System.IntPtr NativeFieldInfoPtr_MONTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_WEEK;

	private static readonly System.IntPtr NativeFieldInfoPtr_DAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOUR;

	private static readonly System.IntPtr NativeFieldInfoPtr_SECOND;

	private static readonly System.IntPtr NativeFieldInfoPtr_MINUTE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LEARN_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_rank;

	private static readonly System.IntPtr NativeFieldInfoPtr_active_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_friend;

	private static readonly System.IntPtr NativeFieldInfoPtr_enemy;

	private static readonly System.IntPtr NativeFieldInfoPtr_no_friend;

	private static readonly System.IntPtr NativeFieldInfoPtr_chat_world;

	private static readonly System.IntPtr NativeFieldInfoPtr_change_flag;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_quayso;

	private static readonly System.IntPtr NativeFieldInfoPtr_option;

	private static readonly System.IntPtr NativeFieldInfoPtr_high;

	private static readonly System.IntPtr NativeFieldInfoPtr_medium;

	private static readonly System.IntPtr NativeFieldInfoPtr_low;

	private static readonly System.IntPtr NativeFieldInfoPtr_increase_vga;

	private static readonly System.IntPtr NativeFieldInfoPtr_decrease_vga;

	private static readonly System.IntPtr NativeFieldInfoPtr_voice_chat_config;

	private static readonly System.IntPtr NativeFieldInfoPtr_voice_autoplay_world;

	private static readonly System.IntPtr NativeFieldInfoPtr_voice_autoplay_private;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverchat_off;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverchat_on;

	private static readonly System.IntPtr NativeFieldInfoPtr_x2Screen;

	private static readonly System.IntPtr NativeFieldInfoPtr_x1Screen;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeSizeScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_aura_off;

	private static readonly System.IntPtr NativeFieldInfoPtr_aura_on;

	private static readonly System.IntPtr NativeFieldInfoPtr_aura_off_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_aura_on_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_hat_off;

	private static readonly System.IntPtr NativeFieldInfoPtr_hat_on;

	private static readonly System.IntPtr NativeFieldInfoPtr_chest;

	private static readonly System.IntPtr NativeFieldInfoPtr_chestt;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventory;

	private static readonly System.IntPtr NativeFieldInfoPtr_combine;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapp;

	private static readonly System.IntPtr NativeFieldInfoPtr_item_give;

	private static readonly System.IntPtr NativeFieldInfoPtr_item_receive;

	private static readonly System.IntPtr NativeFieldInfoPtr_zonee;

	private static readonly System.IntPtr NativeFieldInfoPtr_zone;

	private static readonly System.IntPtr NativeFieldInfoPtr_map;

	private static readonly System.IntPtr NativeFieldInfoPtr_item_receive2;

	private static readonly System.IntPtr NativeFieldInfoPtr_item;

	private static readonly System.IntPtr NativeFieldInfoPtr_give_upper;

	private static readonly System.IntPtr NativeFieldInfoPtr_receive_upper;

	private static readonly System.IntPtr NativeFieldInfoPtr_receive_all;

	private static readonly System.IntPtr NativeFieldInfoPtr_no_map;

	private static readonly System.IntPtr NativeFieldInfoPtr_go_to_quest;

	private static readonly System.IntPtr NativeFieldInfoPtr_from_earth;

	private static readonly System.IntPtr NativeFieldInfoPtr_from_namec;

	private static readonly System.IntPtr NativeFieldInfoPtr_from_sayda;

	private static readonly System.IntPtr NativeFieldInfoPtr_expire;

	private static readonly System.IntPtr NativeFieldInfoPtr_pow_request;

	private static readonly System.IntPtr NativeFieldInfoPtr_your_pow;

	private static readonly System.IntPtr NativeFieldInfoPtr_used;

	private static readonly System.IntPtr NativeFieldInfoPtr_place;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOREVER;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOUPGRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOTUPGRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPGRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPGRADING;

	private static readonly System.IntPtr NativeFieldInfoPtr_make_shortcut;

	private static readonly System.IntPtr NativeFieldInfoPtr_into_place;

	private static readonly System.IntPtr NativeFieldInfoPtr_move_to_chest;

	private static readonly System.IntPtr NativeFieldInfoPtr_move_to_chest2;

	private static readonly System.IntPtr NativeFieldInfoPtr_press_chat_querty;

	private static readonly System.IntPtr NativeFieldInfoPtr_press_chat;

	private static readonly System.IntPtr NativeFieldInfoPtr_saying;

	private static readonly System.IntPtr NativeFieldInfoPtr_miss;

	private static readonly System.IntPtr NativeFieldInfoPtr_donate;

	private static readonly System.IntPtr NativeFieldInfoPtr_receive;

	private static readonly System.IntPtr NativeFieldInfoPtr_press_twice;

	private static readonly System.IntPtr NativeFieldInfoPtr_can_harvest;

	private static readonly System.IntPtr NativeFieldInfoPtr_do_accept_qwerty;

	private static readonly System.IntPtr NativeFieldInfoPtr_do_accept;

	private static readonly System.IntPtr NativeFieldInfoPtr_plsRestartGame;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_online;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_offline;

	private static readonly System.IntPtr NativeFieldInfoPtr_make_friend;

	private static readonly System.IntPtr NativeFieldInfoPtr_chat_player;

	private static readonly System.IntPtr NativeFieldInfoPtr_chat_with;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_capsuledonate;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_capsuleself;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_give_pea;

	private static readonly System.IntPtr NativeFieldInfoPtr_receive_pea;

	private static readonly System.IntPtr NativeFieldInfoPtr_request_pea;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_received;

	private static readonly System.IntPtr NativeFieldInfoPtr_power;

	private static readonly System.IntPtr NativeFieldInfoPtr_join_date;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_leader;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_coleader;

	private static readonly System.IntPtr NativeFieldInfoPtr_power_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_member;

	private static readonly System.IntPtr NativeFieldInfoPtr_memberr;

	private static readonly System.IntPtr NativeFieldInfoPtr_chatClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_leaveClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_createClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_findClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_khau_hieuu;

	private static readonly System.IntPtr NativeFieldInfoPtr_bieu_tuongg;

	private static readonly System.IntPtr NativeFieldInfoPtr_request_pea2;

	private static readonly System.IntPtr NativeFieldInfoPtr_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_birthday;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_list;

	private static readonly System.IntPtr NativeFieldInfoPtr_create;

	private static readonly System.IntPtr NativeFieldInfoPtr_find;

	private static readonly System.IntPtr NativeFieldInfoPtr_leave;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_join_clan;

	private static readonly System.IntPtr NativeFieldInfoPtr_clanEmpty;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_clan_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_chat_clan;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_clan_name_to_create;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_clan_slogan;

	private static readonly System.IntPtr NativeFieldInfoPtr_do_u_want_join_clan;

	private static readonly System.IntPtr NativeFieldInfoPtr_select_clan_icon;

	private static readonly System.IntPtr NativeFieldInfoPtr_request_join_clan;

	private static readonly System.IntPtr NativeFieldInfoPtr_view_clan_member;

	private static readonly System.IntPtr NativeFieldInfoPtr_create_clan_co_leader;

	private static readonly System.IntPtr NativeFieldInfoPtr_create_clan_leader;

	private static readonly System.IntPtr NativeFieldInfoPtr_disable_clan_mastership;

	private static readonly System.IntPtr NativeFieldInfoPtr_kick_clan_mem;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_name_blank;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan_slogan_blank;

	private static readonly System.IntPtr NativeFieldInfoPtr_cannot_find_clan;

	private static readonly System.IntPtr NativeFieldInfoPtr_ago;

	private static readonly System.IntPtr NativeFieldInfoPtr_findingClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_lock_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_lock_trade_upper;

	private static readonly System.IntPtr NativeFieldInfoPtr_locked_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_locked_trade_upper;

	private static readonly System.IntPtr NativeFieldInfoPtr_lock_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_wait_opp_lock_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_press_done;

	private static readonly System.IntPtr NativeFieldInfoPtr_THROW;

	private static readonly System.IntPtr NativeFieldInfoPtr_SPLIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_done;

	private static readonly System.IntPtr NativeFieldInfoPtr_opponent;

	private static readonly System.IntPtr NativeFieldInfoPtr_you;

	private static readonly System.IntPtr NativeFieldInfoPtr_mlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_money_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_GETOUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOVEOUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOVEFORPET;

	private static readonly System.IntPtr NativeFieldInfoPtr_GETOUTMONEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_GETINMONEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SENDMONEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_GETIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_SALE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SALES;

	private static readonly System.IntPtr NativeFieldInfoPtr_SALEALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUY;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUYS;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_money_to_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_money;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_money_wrong;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_enough_money;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_quantity_to_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_quantity;

	private static readonly System.IntPtr NativeFieldInfoPtr_input_quantity_wrong;

	private static readonly System.IntPtr NativeFieldInfoPtr_already_has_item;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlock_item_to_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_root;

	private static readonly System.IntPtr NativeFieldInfoPtr_need;

	private static readonly System.IntPtr NativeFieldInfoPtr_need_upper;

	private static readonly System.IntPtr NativeFieldInfoPtr_free;

	private static readonly System.IntPtr NativeFieldInfoPtr_free1;

	private static readonly System.IntPtr NativeFieldInfoPtr_free2;

	private static readonly System.IntPtr NativeFieldInfoPtr_select_item;

	private static readonly System.IntPtr NativeFieldInfoPtr_random;

	private static readonly System.IntPtr NativeFieldInfoPtr_say_hello;

	private static readonly System.IntPtr NativeFieldInfoPtr_say_wat_do_u_want_to_buy;

	private static readonly System.IntPtr NativeFieldInfoPtr_say_wat_do_u_want_to_buy2;

	private static readonly System.IntPtr NativeFieldInfoPtr_do_u_sure_to_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_learn_with;

	private static readonly System.IntPtr NativeFieldInfoPtr_buy_with;

	private static readonly System.IntPtr NativeFieldInfoPtr_can_not_do_when_die;

	private static readonly System.IntPtr NativeFieldInfoPtr_use_for_combine;

	private static readonly System.IntPtr NativeFieldInfoPtr_use_for_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_enough_luong_world_channel;

	private static readonly System.IntPtr NativeFieldInfoPtr_world_channel_5_luong;

	private static readonly System.IntPtr NativeFieldInfoPtr_want_to_trade;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasJustUpgrade1;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasJustUpgrade2;

	private static readonly System.IntPtr NativeFieldInfoPtr_potential_to_learn;

	private static readonly System.IntPtr NativeFieldInfoPtr_potential_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_achievement_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_increase;

	private static readonly System.IntPtr NativeFieldInfoPtr_increase_upper;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_enough_potential_point1;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_enough_potential_point2;

	private static readonly System.IntPtr NativeFieldInfoPtr_use_potential_point_for1;

	private static readonly System.IntPtr NativeFieldInfoPtr_use_potential_point_for2;

	private static readonly System.IntPtr NativeFieldInfoPtr_for_HP;

	private static readonly System.IntPtr NativeFieldInfoPtr_for_KI;

	private static readonly System.IntPtr NativeFieldInfoPtr_for_hit_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_for_armor;

	private static readonly System.IntPtr NativeFieldInfoPtr_for_crit;

	private static readonly System.IntPtr NativeFieldInfoPtr_can_buy_from_Uron1;

	private static readonly System.IntPtr NativeFieldInfoPtr_can_buy_from_Uron2;

	private static readonly System.IntPtr NativeFieldInfoPtr_can_buy_from_Uron3;

	private static readonly System.IntPtr NativeFieldInfoPtr_HP;

	private static readonly System.IntPtr NativeFieldInfoPtr_KI;

	private static readonly System.IntPtr NativeFieldInfoPtr_hit_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_armor;

	private static readonly System.IntPtr NativeFieldInfoPtr_vitality;

	private static readonly System.IntPtr NativeFieldInfoPtr_critical;

	private static readonly System.IntPtr NativeFieldInfoPtr_cap_do;

	private static readonly System.IntPtr NativeFieldInfoPtr_KI_consume;

	private static readonly System.IntPtr NativeFieldInfoPtr_cooldown;

	private static readonly System.IntPtr NativeFieldInfoPtr_milisecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_max_level_reach;

	private static readonly System.IntPtr NativeFieldInfoPtr_next_level_require;

	private static readonly System.IntPtr NativeFieldInfoPtr_potential;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_learn;

	private static readonly System.IntPtr NativeFieldInfoPtr_learn_require;

	private static readonly System.IntPtr NativeFieldInfoPtr_learn;

	private static readonly System.IntPtr NativeFieldInfoPtr_to_gain_20hp;

	private static readonly System.IntPtr NativeFieldInfoPtr_to_gain_20mp;

	private static readonly System.IntPtr NativeFieldInfoPtr_to_gain_1pow;

	private static readonly System.IntPtr NativeFieldInfoPtr_hairStyleName;

	private static readonly System.IntPtr NativeFieldInfoPtr_hp_ki_full;

	private static readonly System.IntPtr NativeFieldInfoPtr_quest_place;

	private static readonly System.IntPtr NativeFieldInfoPtr_no_mission;

	private static readonly System.IntPtr NativeFieldInfoPtr_reward_mission;

	private static readonly System.IntPtr NativeFieldInfoPtr_achievement_mission;

	private static readonly System.IntPtr NativeFieldInfoPtr_trangbi;

	private static readonly System.IntPtr NativeFieldInfoPtr_wat_do_u_want;

	private static readonly System.IntPtr NativeFieldInfoPtr_off;

	private static readonly System.IntPtr NativeFieldInfoPtr_on;

	private static readonly System.IntPtr NativeFieldInfoPtr_select_map;

	private static readonly System.IntPtr NativeFieldInfoPtr_offPlease;

	private static readonly System.IntPtr NativeFieldInfoPtr_onPlease;

	private static readonly System.IntPtr NativeFieldInfoPtr_language;

	private static readonly System.IntPtr NativeFieldInfoPtr_VIETNAM;

	private static readonly System.IntPtr NativeFieldInfoPtr_ENGLISH;

	private static readonly System.IntPtr NativeFieldInfoPtr_INDONESIA;

	private static readonly System.IntPtr NativeFieldInfoPtr_choigame;

	private static readonly System.IntPtr NativeFieldInfoPtr_no_enemy;

	private static readonly System.IntPtr NativeFieldInfoPtr_kigui;

	private static readonly System.IntPtr NativeFieldInfoPtr_kiguiXu;

	private static readonly System.IntPtr NativeFieldInfoPtr_kiguiLuong;

	private static readonly System.IntPtr NativeFieldInfoPtr_kiguiXuchat;

	private static readonly System.IntPtr NativeFieldInfoPtr_kiguiLuongchat;

	private static readonly System.IntPtr NativeFieldInfoPtr_huykigui;

	private static readonly System.IntPtr NativeFieldInfoPtr_nhantien;

	private static readonly System.IntPtr NativeFieldInfoPtr_dangban;

	private static readonly System.IntPtr NativeFieldInfoPtr_daban;

	private static readonly System.IntPtr NativeFieldInfoPtr_num;

	private static readonly System.IntPtr NativeFieldInfoPtr_upTop;

	private static readonly System.IntPtr NativeFieldInfoPtr_page;

	private static readonly System.IntPtr NativeFieldInfoPtr_getDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_getUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_notYetSell;

	private static readonly System.IntPtr NativeFieldInfoPtr_charger;

	private static readonly System.IntPtr NativeFieldInfoPtr_finishBomong;

	private static readonly System.IntPtr NativeFieldInfoPtr_note;

	private static readonly System.IntPtr NativeFieldInfoPtr_regNote;

	private static readonly System.IntPtr NativeFieldInfoPtr_remain;

	private static readonly System.IntPtr NativeFieldInfoPtr_faster;

	private static readonly System.IntPtr NativeFieldInfoPtr_fasterQuestion;

	private static readonly System.IntPtr NativeFieldInfoPtr_chuacotaikhoan;

	private static readonly System.IntPtr NativeFieldInfoPtr_taidulieudechoi;

	private static readonly System.IntPtr NativeFieldInfoPtr_huy;

	private static readonly System.IntPtr NativeFieldInfoPtr_taidulieu;

	private static readonly System.IntPtr NativeFieldInfoPtr_xoadulieu;

	private static readonly System.IntPtr NativeFieldInfoPtr_deletaDataNote;

	private static readonly System.IntPtr NativeFieldInfoPtr_playNew;

	private static readonly System.IntPtr NativeFieldInfoPtr_playAcc;

	private static readonly System.IntPtr NativeFieldInfoPtr_vuilongnhapduthongtin;

	private static readonly System.IntPtr NativeFieldInfoPtr_not_register_yet;

	private static readonly System.IntPtr NativeFieldInfoPtr_nhanngoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_fusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_sure_fusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_fusionForever;

	private static readonly System.IntPtr NativeFieldInfoPtr_xinchucmung;

	private static readonly System.IntPtr NativeFieldInfoPtr_den;

	private static readonly System.IntPtr NativeFieldInfoPtr_nhatvatpham;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadLanguague_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadLanguague_Public_Static_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_replace_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string learnSkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_learnSkill, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_learnSkill, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string updSkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_updSkill, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_updSkill, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string proficiency
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_proficiency, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_proficiency, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string delacc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_delacc, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_delacc, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string notiINAPP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_notiINAPP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_notiINAPP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string notiRuby
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_notiRuby, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_notiRuby, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string equip
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_equip, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_equip, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string unlock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unlock, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unlock, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string radaCard
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_radaCard, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_radaCard, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_enough_money_1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_enough_money_1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_enough_money_1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string napngoc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_napngoc, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_napngoc, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string functionMaintain1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_functionMaintain1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_functionMaintain1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_quantity_to_buy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_quantity_to_buy, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_quantity_to_buy, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string tang
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tang, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tang, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string kquaVongQuay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kquaVongQuay, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kquaVongQuay, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string useGem
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useGem, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useGem, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string autoFunction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_autoFunction, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_autoFunction, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string choitiep
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_choitiep, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_choitiep, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string attack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_attack, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_attack, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string defend
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defend, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defend, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string follow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_follow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_follow, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string status
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_status, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_status, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string gohome
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gohome, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gohome, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string pet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pet, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pet, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string maychutathoacmatsong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maychutathoacmatsong, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maychutathoacmatsong, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cauhinhthap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cauhinhthap, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cauhinhthap, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cauhinhcao
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cauhinhcao, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cauhinhcao, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string combineSpell
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_combineSpell, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_combineSpell, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string combineFail
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_combineFail, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_combineFail, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string combineSuccess
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_combineSuccess, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_combineSuccess, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string turnOnAnalog
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_turnOnAnalog, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_turnOnAnalog, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string turnOffAnalog
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_turnOffAnalog, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_turnOffAnalog, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string analog
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_analog, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_analog, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string inventory_Pass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inventory_Pass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inventory_Pass, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_Inventory_Pass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_Inventory_Pass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_Inventory_Pass, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_Inventory_Pass_wrong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_Inventory_Pass_wrong, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_Inventory_Pass_wrong, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string REGISTOPROTECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REGISTOPROTECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REGISTOPROTECT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string turnOnSound
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_turnOnSound, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_turnOnSound, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string turnOffSound
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_turnOffSound, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_turnOffSound, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string REGISTERING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REGISTERING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REGISTERING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SENDINGMSG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SENDINGMSG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SENDINGMSG, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SENTMSG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SENTMSG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SENTMSG, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NOSENDMSG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOSENDMSG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOSENDMSG, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string sendMsgSuccess
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sendMsgSuccess, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sendMsgSuccess, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cannotSendMsg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cannotSendMsg, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cannotSendMsg, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string sendGuessMsgSuccess
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sendGuessMsgSuccess, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sendGuessMsgSuccess, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string sendMsgFail
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sendMsgFail, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sendMsgFail, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ALERT_PRIVATE_PASS_1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALERT_PRIVATE_PASS_1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALERT_PRIVATE_PASS_1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ALERT_PRIVATE_PASS_2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALERT_PRIVATE_PASS_2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALERT_PRIVATE_PASS_2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string INPUT_PRIVATE_PASS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_PRIVATE_PASS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_PRIVATE_PASS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string change_account
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_change_account, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_change_account, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string alreadyHadAccount1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_alreadyHadAccount1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_alreadyHadAccount1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string alreadyHadAccount2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_alreadyHadAccount2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_alreadyHadAccount2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string userBlank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_userBlank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_userBlank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string passwordBlank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_passwordBlank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_passwordBlank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string accTooShort
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_accTooShort, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_accTooShort, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string phoneInvalid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_phoneInvalid, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_phoneInvalid, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string emailInvalid
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_emailInvalid, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_emailInvalid, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string registerNewAcc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_registerNewAcc, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_registerNewAcc, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string selectServer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_selectServer, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_selectServer, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string selectServer2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_selectServer2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_selectServer2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string forgetPass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_forgetPass, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_forgetPass, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string password
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_password, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_password, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray LOGINLABELS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOGINLABELS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOGINLABELS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string msg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_msg, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_msg, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray msgg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_msgg, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_msgg, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string no_msg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_no_msg, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_no_msg, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cancelAccountProtection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cancelAccountProtection, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cancelAccountProtection, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string plsCheckAcc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_plsCheckAcc, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_plsCheckAcc, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string phone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_phone, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_phone, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string email
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_email, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_email, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string acc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_acc, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_acc, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string pwd
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pwd, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pwd, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string goToWebForPassword
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_goToWebForPassword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_goToWebForPassword, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string dragon_ball
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dragon_ball, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dragon_ball, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string character
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_character, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_character, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string account
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_account, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_account, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string account_server
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_account_server, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_account_server, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string char_name_blank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_char_name_blank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_char_name_blank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string char_name_short
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_char_name_short, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_char_name_short, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string char_name_long
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_char_name_long, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_char_name_long, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string changeNameChar
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_changeNameChar, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_changeNameChar, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string char_name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_char_name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_char_name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string login
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_login, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_login, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string login2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_login2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_login2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string register
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_register, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_register, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WAIT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WAIT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WAIT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PLEASEWAIT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PLEASEWAIT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PLEASEWAIT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CONNECTING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONNECTING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONNECTING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOGGING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOGGING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOGGING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOADING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOADING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOADING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string downloading_data
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_downloading_data, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_downloading_data, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string select_server
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_select_server, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_select_server, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string pls_restart_game_error
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pls_restart_game_error, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pls_restart_game_error, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string lost_connection
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lost_connection, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lost_connection, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string check_3G
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_check_3G, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_check_3G, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UPDATE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPDATE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPDATE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string change_zone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_change_zone, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_change_zone, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string select_zone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_select_zone, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_select_zone, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string website
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_website, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_website, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string server
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_server, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_server, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string planet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_planet, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_planet, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray MENUME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MENUME, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MENUME, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray MENUNEWCHAR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MENUNEWCHAR, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MENUNEWCHAR, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray MENUGENDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MENUGENDER, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MENUGENDER, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray CHAR_ORDER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAR_ORDER, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAR_ORDER, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> mainTab1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainTab1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainTab1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> mainTab2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mainTab2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mainTab2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> petMainTab
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_petMainTab, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_petMainTab, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> petMainTab2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_petMainTab2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_petMainTab2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray key_skill_qwerty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_key_skill_qwerty, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_key_skill_qwerty, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray key_skill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_key_skill, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_key_skill, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string SKILL_FAIL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_FAIL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_FAIL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HP_EMPTY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HP_EMPTY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HP_EMPTY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ZONE_HERE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ZONE_HERE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ZONE_HERE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray DES_TASK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DES_TASK, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DES_TASK, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray DIES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DIES, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DIES, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray SYNTHESIS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SYNTHESIS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SYNTHESIS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray tips
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tips, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tips, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string TASK_INPUT_CLASS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TASK_INPUT_CLASS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TASK_INPUT_CLASS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SERI_NUM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SERI_NUM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SERI_NUM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CARD_CODE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CARD_CODE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CARD_CODE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string pay_card
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pay_card, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pay_card, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string pay_card2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pay_card2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pay_card2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string serial_blank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serial_blank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serial_blank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string card_code_blank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_card_code_blank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_card_code_blank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string billion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_billion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_billion, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string million
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_million, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_million, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MENU
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MENU, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MENU, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CLOSE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CLOSE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CLOSE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ON
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ON, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ON, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OFF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OFF, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OFF, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ENABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENABLE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENABLE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DELETE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DELETE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DELETE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string VIEW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VIEW, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VIEW, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CONTINUE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONTINUE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONTINUE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEXTSTEP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEXTSTEP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEXTSTEP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string USE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_USE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_USE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SORT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SORT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SORT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string YES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_YES, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_YES, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NO
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NO, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NO, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string EXIT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EXIT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EXIT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CHAT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string REVENGE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_REVENGE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_REVENGE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string OK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OK, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OK, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string retry
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_retry, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_retry, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string uncheck
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_uncheck, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_uncheck, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string remember
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_remember, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_remember, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ACCEPT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ACCEPT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ACCEPT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CANCEL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CANCEL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CANCEL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SELECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SELECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SELECT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string enter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enter, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enter, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string open_link
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_open_link, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_open_link, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DOYOUWANTEXIT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DOYOUWANTEXIT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DOYOUWANTEXIT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NEWCHAR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEWCHAR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEWCHAR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BACK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BACK, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BACK, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LOCKED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOCKED, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOCKED, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KILL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KILL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KILL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KILLBOSS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KILLBOSS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KILLBOSS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NOLOCK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOLOCK, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOLOCK, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string XU
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XU, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XU, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LUONG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LUONG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LUONG, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string RUBY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RUBY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RUBY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string PK_NOW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PK_NOW, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PK_NOW, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string CUU_SAT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CUU_SAT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CUU_SAT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NOT_ENOUGH_MP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOT_ENOUGH_MP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOT_ENOUGH_MP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string you_receive
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_you_receive, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_you_receive, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MONTH
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MONTH, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MONTH, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string WEEK
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WEEK, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WEEK, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string DAY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DAY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DAY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HOUR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOUR, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOUR, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SECOND
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SECOND, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SECOND, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MINUTE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MINUTE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MINUTE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string LEARN_SKILL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LEARN_SKILL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LEARN_SKILL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string rank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string active_point
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_active_point, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_active_point, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string friend
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_friend, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_friend, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string enemy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_enemy, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_enemy, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string no_friend
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_no_friend, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_no_friend, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string chat_world
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chat_world, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chat_world, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string change_flag
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_change_flag, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_change_flag, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string gameInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gameInfo, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gameInfo, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string quayso
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_quayso, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_quayso, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string option
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_option, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_option, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string high
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_high, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_high, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string medium
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_medium, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_medium, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string low
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_low, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_low, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string increase_vga
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_increase_vga, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_increase_vga, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string decrease_vga
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_decrease_vga, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_decrease_vga, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string voice_chat_config
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_voice_chat_config, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_voice_chat_config, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string voice_autoplay_world
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_voice_autoplay_world, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_voice_autoplay_world, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string voice_autoplay_private
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_voice_autoplay_private, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_voice_autoplay_private, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string serverchat_off
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverchat_off, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverchat_off, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string serverchat_on
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverchat_on, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverchat_on, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string x2Screen
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_x2Screen, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_x2Screen, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string x1Screen
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_x1Screen, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_x1Screen, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string changeSizeScreen
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_changeSizeScreen, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_changeSizeScreen, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string aura_off
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_aura_off, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_aura_off, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string aura_on
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_aura_on, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_aura_on, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string aura_off_2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_aura_off_2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_aura_off_2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string aura_on_2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_aura_on_2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_aura_on_2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string hat_off
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hat_off, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hat_off, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string hat_on
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hat_on, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hat_on, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string chest
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chest, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chest, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray chestt
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chestt, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chestt, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray inventory
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inventory, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inventory, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray combine
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_combine, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_combine, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray mapp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mapp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mapp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray item_give
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_item_give, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_item_give, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray item_receive
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_item_receive, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_item_receive, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray zonee
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zonee, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zonee, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string zone
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zone, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zone, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string map
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_map, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_map, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string item_receive2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_item_receive2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_item_receive2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string item
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_item, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_item, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string give_upper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_give_upper, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_give_upper, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string receive_upper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_receive_upper, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_receive_upper, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string receive_all
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_receive_all, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_receive_all, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string no_map
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_no_map, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_no_map, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string go_to_quest
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_go_to_quest, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_go_to_quest, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string from_earth
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_from_earth, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_from_earth, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string from_namec
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_from_namec, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_from_namec, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string from_sayda
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_from_sayda, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_from_sayda, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string expire
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_expire, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_expire, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string pow_request
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pow_request, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pow_request, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string your_pow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_your_pow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_your_pow, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string used
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_used, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_used, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string place
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_place, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_place, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string FOREVER
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FOREVER, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FOREVER, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NOUPGRADE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOUPGRADE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOUPGRADE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string NOTUPGRADE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOTUPGRADE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOTUPGRADE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UPGRADE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPGRADE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPGRADE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string UPGRADING
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPGRADING, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPGRADING, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string make_shortcut
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_make_shortcut, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_make_shortcut, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string into_place
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_into_place, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_into_place, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string move_to_chest
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_move_to_chest, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_move_to_chest, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string move_to_chest2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_move_to_chest2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_move_to_chest2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string press_chat_querty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_press_chat_querty, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_press_chat_querty, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string press_chat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_press_chat, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_press_chat, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string saying
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_saying, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_saying, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string miss
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_miss, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_miss, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string donate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_donate, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_donate, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string receive
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_receive, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_receive, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string press_twice
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_press_twice, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_press_twice, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string can_harvest
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_can_harvest, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_can_harvest, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string do_accept_qwerty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_do_accept_qwerty, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_do_accept_qwerty, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string do_accept
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_do_accept, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_do_accept, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string plsRestartGame
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_plsRestartGame, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_plsRestartGame, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string is_online
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_is_online, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_is_online, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string is_offline
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_is_offline, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_is_offline, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string make_friend
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_make_friend, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_make_friend, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string chat_player
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chat_player, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chat_player, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string chat_with
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chat_with, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chat_with, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_capsuledonate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_capsuledonate, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_capsuledonate, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_capsuleself
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_capsuleself, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_capsuleself, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_point
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_point, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_point, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string give_pea
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_give_pea, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_give_pea, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string receive_pea
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_receive_pea, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_receive_pea, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string request_pea
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_request_pea, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_request_pea, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string time
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_time, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_time, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string received
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_received, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_received, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string power
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_power, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_power, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string join_date
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_join_date, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_join_date, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_leader
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_leader, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_leader, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_coleader
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_coleader, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_coleader, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string power_point
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_power_point, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_power_point, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string member
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_member, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_member, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray memberr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_memberr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_memberr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray chatClan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chatClan, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chatClan, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray leaveClan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_leaveClan, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_leaveClan, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray createClan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_createClan, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_createClan, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray findClan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_findClan, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_findClan, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray khau_hieuu
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_khau_hieuu, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_khau_hieuu, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray bieu_tuongg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bieu_tuongg, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bieu_tuongg, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray request_pea2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_request_pea2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_request_pea2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string level
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_level, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_level, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_birthday
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_birthday, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_birthday, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_list
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_list, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_list, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string create
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_create, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_create, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string find
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_find, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_find, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string leave
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_leave, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_leave, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_join_clan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_join_clan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_join_clan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStringArray clanEmpty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clanEmpty, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clanEmpty, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string input_clan_name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_clan_name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_clan_name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_name
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_name, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_name, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string chat_clan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chat_clan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chat_clan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_clan_name_to_create
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_clan_name_to_create, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_clan_name_to_create, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_clan_slogan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_clan_slogan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_clan_slogan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string do_u_want_join_clan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_do_u_want_join_clan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_do_u_want_join_clan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string select_clan_icon
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_select_clan_icon, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_select_clan_icon, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string request_join_clan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_request_join_clan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_request_join_clan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string view_clan_member
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_view_clan_member, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_view_clan_member, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string create_clan_co_leader
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_create_clan_co_leader, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_create_clan_co_leader, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string create_clan_leader
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_create_clan_leader, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_create_clan_leader, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string disable_clan_mastership
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_disable_clan_mastership, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_disable_clan_mastership, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string kick_clan_mem
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kick_clan_mem, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kick_clan_mem, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_name_blank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_name_blank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_name_blank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string clan_slogan_blank
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clan_slogan_blank, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clan_slogan_blank, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cannot_find_clan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cannot_find_clan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cannot_find_clan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string ago
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ago, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ago, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string findingClan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_findingClan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_findingClan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_lock_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_lock_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_lock_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_lock_trade_upper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_lock_trade_upper, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_lock_trade_upper, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string locked_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_locked_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_locked_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string locked_trade_upper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_locked_trade_upper, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_locked_trade_upper, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string lock_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lock_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lock_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string wait_opp_lock_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wait_opp_lock_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wait_opp_lock_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string press_done
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_press_done, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_press_done, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string THROW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THROW, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THROW, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SPLIT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SPLIT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SPLIT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string done
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_done, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_done, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string opponent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_opponent, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_opponent, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string you
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_you, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_you, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string mlock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mlock, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mlock, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string money_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_money_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_money_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GETOUT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GETOUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GETOUT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MOVEOUT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOVEOUT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOVEOUT, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string MOVEFORPET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOVEFORPET, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOVEFORPET, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GETOUTMONEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GETOUTMONEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GETOUTMONEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GETINMONEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GETINMONEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GETINMONEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SENDMONEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SENDMONEY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SENDMONEY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string GETIN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GETIN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GETIN, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SALE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SALE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SALE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SALES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SALES, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SALES, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SALEALL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SALEALL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SALEALL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BUY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUY, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUY, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string BUYS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUYS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUYS, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_money_to_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_money_to_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_money_to_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_money
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_money, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_money, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_money_wrong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_money_wrong, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_money_wrong, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_enough_money
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_enough_money, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_enough_money, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_quantity_to_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_quantity_to_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_quantity_to_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_quantity
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_quantity, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_quantity, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string input_quantity_wrong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input_quantity_wrong, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input_quantity_wrong, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string already_has_item
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_already_has_item, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_already_has_item, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string unlock_item_to_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_unlock_item_to_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_unlock_item_to_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string root
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_root, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_root, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string need
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_need, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_need, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string need_upper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_need_upper, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_need_upper, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string free
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_free, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_free, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string free1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_free1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_free1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string free2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_free2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_free2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string select_item
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_select_item, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_select_item, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string random
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_random, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_random, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string say_hello
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_say_hello, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_say_hello, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string say_wat_do_u_want_to_buy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_say_wat_do_u_want_to_buy, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_say_wat_do_u_want_to_buy, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string say_wat_do_u_want_to_buy2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_say_wat_do_u_want_to_buy2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_say_wat_do_u_want_to_buy2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string do_u_sure_to_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_do_u_sure_to_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_do_u_sure_to_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string learn_with
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_learn_with, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_learn_with, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string buy_with
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_buy_with, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_buy_with, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string can_not_do_when_die
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_can_not_do_when_die, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_can_not_do_when_die, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string use_for_combine
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_use_for_combine, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_use_for_combine, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string use_for_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_use_for_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_use_for_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_enough_luong_world_channel
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_enough_luong_world_channel, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_enough_luong_world_channel, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string world_channel_5_luong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_world_channel_5_luong, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_world_channel_5_luong, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string want_to_trade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_want_to_trade, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_want_to_trade, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string hasJustUpgrade1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasJustUpgrade1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasJustUpgrade1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string hasJustUpgrade2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hasJustUpgrade2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hasJustUpgrade2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string potential_to_learn
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_potential_to_learn, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_potential_to_learn, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string potential_point
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_potential_point, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_potential_point, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string achievement_point
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_achievement_point, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_achievement_point, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string increase
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_increase, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_increase, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string increase_upper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_increase_upper, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_increase_upper, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_enough_potential_point1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_enough_potential_point1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_enough_potential_point1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_enough_potential_point2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_enough_potential_point2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_enough_potential_point2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string use_potential_point_for1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_use_potential_point_for1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_use_potential_point_for1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string use_potential_point_for2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_use_potential_point_for2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_use_potential_point_for2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string for_HP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_for_HP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_for_HP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string for_KI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_for_KI, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_for_KI, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string for_hit_point
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_for_hit_point, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_for_hit_point, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string for_armor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_for_armor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_for_armor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string for_crit
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_for_crit, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_for_crit, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string can_buy_from_Uron1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_can_buy_from_Uron1, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_can_buy_from_Uron1, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string can_buy_from_Uron2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_can_buy_from_Uron2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_can_buy_from_Uron2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string can_buy_from_Uron3
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_can_buy_from_Uron3, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_can_buy_from_Uron3, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string HP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KI, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KI, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string hit_point
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hit_point, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hit_point, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string armor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_armor, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_armor, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string vitality
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vitality, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vitality, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string critical
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_critical, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_critical, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cap_do
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cap_do, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cap_do, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string KI_consume
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KI_consume, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KI_consume, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string cooldown
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cooldown, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cooldown, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string milisecond
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_milisecond, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_milisecond, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string max_level_reach
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_max_level_reach, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_max_level_reach, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string next_level_require
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_next_level_require, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_next_level_require, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string potential
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_potential, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_potential, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_learn
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_learn, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_learn, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string learn_require
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_learn_require, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_learn_require, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string learn
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_learn, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_learn, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string to_gain_20hp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_to_gain_20hp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_to_gain_20hp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string to_gain_20mp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_to_gain_20mp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_to_gain_20mp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string to_gain_1pow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_to_gain_1pow, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_to_gain_1pow, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> hairStyleName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hairStyleName, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hairStyleName, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string hp_ki_full
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hp_ki_full, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hp_ki_full, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string quest_place
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_quest_place, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_quest_place, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string no_mission
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_no_mission, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_no_mission, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string reward_mission
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reward_mission, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reward_mission, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string achievement_mission
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_achievement_mission, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_achievement_mission, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string trangbi
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trangbi, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trangbi, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string wat_do_u_want
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wat_do_u_want, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wat_do_u_want, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string off
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_off, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_off, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string on
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_on, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_on, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string select_map
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_select_map, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_select_map, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string offPlease
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_offPlease, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_offPlease, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string onPlease
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onPlease, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onPlease, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static sbyte language
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_language, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_language, (void*)(&b));
		}
	}

	public unsafe static sbyte VIETNAM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VIETNAM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VIETNAM, (void*)(&b));
		}
	}

	public unsafe static sbyte ENGLISH
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ENGLISH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ENGLISH, (void*)(&b));
		}
	}

	public unsafe static sbyte INDONESIA
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INDONESIA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INDONESIA, (void*)(&b));
		}
	}

	public unsafe static string choigame
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_choigame, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_choigame, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string no_enemy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_no_enemy, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_no_enemy, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string kigui
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kigui, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kigui, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string kiguiXu
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kiguiXu, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kiguiXu, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string kiguiLuong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kiguiLuong, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kiguiLuong, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string kiguiXuchat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kiguiXuchat, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kiguiXuchat, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string kiguiLuongchat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kiguiLuongchat, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kiguiLuongchat, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string huykigui
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_huykigui, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_huykigui, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string nhantien
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nhantien, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nhantien, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string dangban
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dangban, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dangban, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string daban
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_daban, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_daban, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string num
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_num, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_num, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string upTop
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_upTop, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_upTop, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string page
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_page, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_page, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string getDown
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getDown, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getDown, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string getUp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getUp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getUp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string notYetSell
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_notYetSell, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_notYetSell, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string charger
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_charger, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_charger, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string finishBomong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_finishBomong, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_finishBomong, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string note
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_note, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_note, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string regNote
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regNote, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regNote, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string remain
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_remain, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_remain, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string faster
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_faster, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_faster, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string fasterQuestion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fasterQuestion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fasterQuestion, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string chuacotaikhoan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chuacotaikhoan, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chuacotaikhoan, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string taidulieudechoi
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_taidulieudechoi, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_taidulieudechoi, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string huy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_huy, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_huy, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string taidulieu
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_taidulieu, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_taidulieu, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string xoadulieu
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xoadulieu, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xoadulieu, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string deletaDataNote
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deletaDataNote, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deletaDataNote, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string playNew
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playNew, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playNew, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string playAcc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_playAcc, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_playAcc, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string vuilongnhapduthongtin
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vuilongnhapduthongtin, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vuilongnhapduthongtin, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string not_register_yet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_not_register_yet, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_not_register_yet, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string nhanngoc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nhanngoc, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nhanngoc, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string fusion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fusion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fusion, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string sure_fusion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sure_fusion, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sure_fusion, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string fusionForever
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fusionForever, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fusionForever, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string xinchucmung
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xinchucmung, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xinchucmung, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string den
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_den, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_den, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string nhatvatpham
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nhatvatpham, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nhatvatpham, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static mResources()
	{
		Il2CppClassPointerStore<mResources>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "mResources");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<mResources>.NativeClassPtr);
		NativeFieldInfoPtr_learnSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "learnSkill");
		NativeFieldInfoPtr_updSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "updSkill");
		NativeFieldInfoPtr_proficiency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "proficiency");
		NativeFieldInfoPtr_delacc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "delacc");
		NativeFieldInfoPtr_notiINAPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "notiINAPP");
		NativeFieldInfoPtr_notiRuby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "notiRuby");
		NativeFieldInfoPtr_equip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "equip");
		NativeFieldInfoPtr_unlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "unlock");
		NativeFieldInfoPtr_radaCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "radaCard");
		NativeFieldInfoPtr_not_enough_money_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_enough_money_1");
		NativeFieldInfoPtr_napngoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "napngoc");
		NativeFieldInfoPtr_functionMaintain1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "functionMaintain1");
		NativeFieldInfoPtr_input_quantity_to_buy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_quantity_to_buy");
		NativeFieldInfoPtr_tang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "tang");
		NativeFieldInfoPtr_kquaVongQuay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "kquaVongQuay");
		NativeFieldInfoPtr_useGem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "useGem");
		NativeFieldInfoPtr_autoFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "autoFunction");
		NativeFieldInfoPtr_choitiep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "choitiep");
		NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "attack");
		NativeFieldInfoPtr_defend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "defend");
		NativeFieldInfoPtr_follow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "follow");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "status");
		NativeFieldInfoPtr_gohome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "gohome");
		NativeFieldInfoPtr_pet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "pet");
		NativeFieldInfoPtr_maychutathoacmatsong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "maychutathoacmatsong");
		NativeFieldInfoPtr_cauhinhthap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "cauhinhthap");
		NativeFieldInfoPtr_cauhinhcao = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "cauhinhcao");
		NativeFieldInfoPtr_combineSpell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "combineSpell");
		NativeFieldInfoPtr_combineFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "combineFail");
		NativeFieldInfoPtr_combineSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "combineSuccess");
		NativeFieldInfoPtr_turnOnAnalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "turnOnAnalog");
		NativeFieldInfoPtr_turnOffAnalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "turnOffAnalog");
		NativeFieldInfoPtr_analog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "analog");
		NativeFieldInfoPtr_inventory_Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "inventory_Pass");
		NativeFieldInfoPtr_input_Inventory_Pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_Inventory_Pass");
		NativeFieldInfoPtr_input_Inventory_Pass_wrong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_Inventory_Pass_wrong");
		NativeFieldInfoPtr_REGISTOPROTECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "REGISTOPROTECT");
		NativeFieldInfoPtr_turnOnSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "turnOnSound");
		NativeFieldInfoPtr_turnOffSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "turnOffSound");
		NativeFieldInfoPtr_REGISTERING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "REGISTERING");
		NativeFieldInfoPtr_SENDINGMSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SENDINGMSG");
		NativeFieldInfoPtr_SENTMSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SENTMSG");
		NativeFieldInfoPtr_NOSENDMSG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NOSENDMSG");
		NativeFieldInfoPtr_sendMsgSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "sendMsgSuccess");
		NativeFieldInfoPtr_cannotSendMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "cannotSendMsg");
		NativeFieldInfoPtr_sendGuessMsgSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "sendGuessMsgSuccess");
		NativeFieldInfoPtr_sendMsgFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "sendMsgFail");
		NativeFieldInfoPtr_ALERT_PRIVATE_PASS_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ALERT_PRIVATE_PASS_1");
		NativeFieldInfoPtr_ALERT_PRIVATE_PASS_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ALERT_PRIVATE_PASS_2");
		NativeFieldInfoPtr_INPUT_PRIVATE_PASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "INPUT_PRIVATE_PASS");
		NativeFieldInfoPtr_change_account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "change_account");
		NativeFieldInfoPtr_alreadyHadAccount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "alreadyHadAccount1");
		NativeFieldInfoPtr_alreadyHadAccount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "alreadyHadAccount2");
		NativeFieldInfoPtr_userBlank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "userBlank");
		NativeFieldInfoPtr_passwordBlank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "passwordBlank");
		NativeFieldInfoPtr_accTooShort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "accTooShort");
		NativeFieldInfoPtr_phoneInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "phoneInvalid");
		NativeFieldInfoPtr_emailInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "emailInvalid");
		NativeFieldInfoPtr_registerNewAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "registerNewAcc");
		NativeFieldInfoPtr_selectServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "selectServer");
		NativeFieldInfoPtr_selectServer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "selectServer2");
		NativeFieldInfoPtr_forgetPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "forgetPass");
		NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "password");
		NativeFieldInfoPtr_LOGINLABELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "LOGINLABELS");
		NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "msg");
		NativeFieldInfoPtr_msgg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "msgg");
		NativeFieldInfoPtr_no_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "no_msg");
		NativeFieldInfoPtr_cancelAccountProtection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "cancelAccountProtection");
		NativeFieldInfoPtr_plsCheckAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "plsCheckAcc");
		NativeFieldInfoPtr_phone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "phone");
		NativeFieldInfoPtr_email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "email");
		NativeFieldInfoPtr_acc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "acc");
		NativeFieldInfoPtr_pwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "pwd");
		NativeFieldInfoPtr_goToWebForPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "goToWebForPassword");
		NativeFieldInfoPtr_dragon_ball = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "dragon_ball");
		NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "character");
		NativeFieldInfoPtr_account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "account");
		NativeFieldInfoPtr_account_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "account_server");
		NativeFieldInfoPtr_char_name_blank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "char_name_blank");
		NativeFieldInfoPtr_char_name_short = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "char_name_short");
		NativeFieldInfoPtr_char_name_long = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "char_name_long");
		NativeFieldInfoPtr_changeNameChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "changeNameChar");
		NativeFieldInfoPtr_char_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "char_name");
		NativeFieldInfoPtr_login = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "login");
		NativeFieldInfoPtr_login2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "login2");
		NativeFieldInfoPtr_register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "register");
		NativeFieldInfoPtr_WAIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "WAIT");
		NativeFieldInfoPtr_PLEASEWAIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "PLEASEWAIT");
		NativeFieldInfoPtr_CONNECTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CONNECTING");
		NativeFieldInfoPtr_LOGGING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "LOGGING");
		NativeFieldInfoPtr_LOADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "LOADING");
		NativeFieldInfoPtr_downloading_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "downloading_data");
		NativeFieldInfoPtr_select_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "select_server");
		NativeFieldInfoPtr_pls_restart_game_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "pls_restart_game_error");
		NativeFieldInfoPtr_lost_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "lost_connection");
		NativeFieldInfoPtr_check_3G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "check_3G");
		NativeFieldInfoPtr_UPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "UPDATE");
		NativeFieldInfoPtr_change_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "change_zone");
		NativeFieldInfoPtr_select_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "select_zone");
		NativeFieldInfoPtr_website = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "website");
		NativeFieldInfoPtr_server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "server");
		NativeFieldInfoPtr_planet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "planet");
		NativeFieldInfoPtr_MENUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MENUME");
		NativeFieldInfoPtr_MENUNEWCHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MENUNEWCHAR");
		NativeFieldInfoPtr_MENUGENDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MENUGENDER");
		NativeFieldInfoPtr_CHAR_ORDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CHAR_ORDER");
		NativeFieldInfoPtr_mainTab1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "mainTab1");
		NativeFieldInfoPtr_mainTab2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "mainTab2");
		NativeFieldInfoPtr_petMainTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "petMainTab");
		NativeFieldInfoPtr_petMainTab2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "petMainTab2");
		NativeFieldInfoPtr_key_skill_qwerty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "key_skill_qwerty");
		NativeFieldInfoPtr_key_skill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "key_skill");
		NativeFieldInfoPtr_SKILL_FAIL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SKILL_FAIL");
		NativeFieldInfoPtr_HP_EMPTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "HP_EMPTY");
		NativeFieldInfoPtr_ZONE_HERE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ZONE_HERE");
		NativeFieldInfoPtr_DES_TASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "DES_TASK");
		NativeFieldInfoPtr_DIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "DIES");
		NativeFieldInfoPtr_SYNTHESIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SYNTHESIS");
		NativeFieldInfoPtr_tips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "tips");
		NativeFieldInfoPtr_TASK_INPUT_CLASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "TASK_INPUT_CLASS");
		NativeFieldInfoPtr_SERI_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SERI_NUM");
		NativeFieldInfoPtr_CARD_CODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CARD_CODE");
		NativeFieldInfoPtr_pay_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "pay_card");
		NativeFieldInfoPtr_pay_card2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "pay_card2");
		NativeFieldInfoPtr_serial_blank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "serial_blank");
		NativeFieldInfoPtr_card_code_blank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "card_code_blank");
		NativeFieldInfoPtr_billion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "billion");
		NativeFieldInfoPtr_million = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "million");
		NativeFieldInfoPtr_MENU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MENU");
		NativeFieldInfoPtr_CLOSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CLOSE");
		NativeFieldInfoPtr_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ON");
		NativeFieldInfoPtr_OFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "OFF");
		NativeFieldInfoPtr_ENABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ENABLE");
		NativeFieldInfoPtr_DELETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "DELETE");
		NativeFieldInfoPtr_VIEW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "VIEW");
		NativeFieldInfoPtr_CONTINUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CONTINUE");
		NativeFieldInfoPtr_NEXTSTEP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NEXTSTEP");
		NativeFieldInfoPtr_USE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "USE");
		NativeFieldInfoPtr_SORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SORT");
		NativeFieldInfoPtr_YES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "YES");
		NativeFieldInfoPtr_NO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NO");
		NativeFieldInfoPtr_EXIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "EXIT");
		NativeFieldInfoPtr_CHAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CHAT");
		NativeFieldInfoPtr_REVENGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "REVENGE");
		NativeFieldInfoPtr_OK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "OK");
		NativeFieldInfoPtr_retry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "retry");
		NativeFieldInfoPtr_uncheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "uncheck");
		NativeFieldInfoPtr_remember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "remember");
		NativeFieldInfoPtr_ACCEPT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ACCEPT");
		NativeFieldInfoPtr_CANCEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CANCEL");
		NativeFieldInfoPtr_SELECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SELECT");
		NativeFieldInfoPtr_enter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "enter");
		NativeFieldInfoPtr_open_link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "open_link");
		NativeFieldInfoPtr_DOYOUWANTEXIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "DOYOUWANTEXIT");
		NativeFieldInfoPtr_NEWCHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NEWCHAR");
		NativeFieldInfoPtr_BACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "BACK");
		NativeFieldInfoPtr_LOCKED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "LOCKED");
		NativeFieldInfoPtr_KILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "KILL");
		NativeFieldInfoPtr_KILLBOSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "KILLBOSS");
		NativeFieldInfoPtr_NOLOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NOLOCK");
		NativeFieldInfoPtr_XU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "XU");
		NativeFieldInfoPtr_LUONG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "LUONG");
		NativeFieldInfoPtr_RUBY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "RUBY");
		NativeFieldInfoPtr_PK_NOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "PK_NOW");
		NativeFieldInfoPtr_CUU_SAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "CUU_SAT");
		NativeFieldInfoPtr_NOT_ENOUGH_MP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NOT_ENOUGH_MP");
		NativeFieldInfoPtr_you_receive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "you_receive");
		NativeFieldInfoPtr_MONTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MONTH");
		NativeFieldInfoPtr_WEEK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "WEEK");
		NativeFieldInfoPtr_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "DAY");
		NativeFieldInfoPtr_HOUR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "HOUR");
		NativeFieldInfoPtr_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SECOND");
		NativeFieldInfoPtr_MINUTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MINUTE");
		NativeFieldInfoPtr_LEARN_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "LEARN_SKILL");
		NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "rank");
		NativeFieldInfoPtr_active_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "active_point");
		NativeFieldInfoPtr_friend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "friend");
		NativeFieldInfoPtr_enemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "enemy");
		NativeFieldInfoPtr_no_friend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "no_friend");
		NativeFieldInfoPtr_chat_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chat_world");
		NativeFieldInfoPtr_change_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "change_flag");
		NativeFieldInfoPtr_gameInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "gameInfo");
		NativeFieldInfoPtr_quayso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "quayso");
		NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "option");
		NativeFieldInfoPtr_high = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "high");
		NativeFieldInfoPtr_medium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "medium");
		NativeFieldInfoPtr_low = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "low");
		NativeFieldInfoPtr_increase_vga = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "increase_vga");
		NativeFieldInfoPtr_decrease_vga = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "decrease_vga");
		NativeFieldInfoPtr_voice_chat_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "voice_chat_config");
		NativeFieldInfoPtr_voice_autoplay_world = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "voice_autoplay_world");
		NativeFieldInfoPtr_voice_autoplay_private = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "voice_autoplay_private");
		NativeFieldInfoPtr_serverchat_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "serverchat_off");
		NativeFieldInfoPtr_serverchat_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "serverchat_on");
		NativeFieldInfoPtr_x2Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "x2Screen");
		NativeFieldInfoPtr_x1Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "x1Screen");
		NativeFieldInfoPtr_changeSizeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "changeSizeScreen");
		NativeFieldInfoPtr_aura_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "aura_off");
		NativeFieldInfoPtr_aura_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "aura_on");
		NativeFieldInfoPtr_aura_off_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "aura_off_2");
		NativeFieldInfoPtr_aura_on_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "aura_on_2");
		NativeFieldInfoPtr_hat_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "hat_off");
		NativeFieldInfoPtr_hat_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "hat_on");
		NativeFieldInfoPtr_chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chest");
		NativeFieldInfoPtr_chestt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chestt");
		NativeFieldInfoPtr_inventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "inventory");
		NativeFieldInfoPtr_combine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "combine");
		NativeFieldInfoPtr_mapp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "mapp");
		NativeFieldInfoPtr_item_give = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "item_give");
		NativeFieldInfoPtr_item_receive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "item_receive");
		NativeFieldInfoPtr_zonee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "zonee");
		NativeFieldInfoPtr_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "zone");
		NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "map");
		NativeFieldInfoPtr_item_receive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "item_receive2");
		NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "item");
		NativeFieldInfoPtr_give_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "give_upper");
		NativeFieldInfoPtr_receive_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "receive_upper");
		NativeFieldInfoPtr_receive_all = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "receive_all");
		NativeFieldInfoPtr_no_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "no_map");
		NativeFieldInfoPtr_go_to_quest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "go_to_quest");
		NativeFieldInfoPtr_from_earth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "from_earth");
		NativeFieldInfoPtr_from_namec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "from_namec");
		NativeFieldInfoPtr_from_sayda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "from_sayda");
		NativeFieldInfoPtr_expire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "expire");
		NativeFieldInfoPtr_pow_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "pow_request");
		NativeFieldInfoPtr_your_pow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "your_pow");
		NativeFieldInfoPtr_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "used");
		NativeFieldInfoPtr_place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "place");
		NativeFieldInfoPtr_FOREVER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "FOREVER");
		NativeFieldInfoPtr_NOUPGRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NOUPGRADE");
		NativeFieldInfoPtr_NOTUPGRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "NOTUPGRADE");
		NativeFieldInfoPtr_UPGRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "UPGRADE");
		NativeFieldInfoPtr_UPGRADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "UPGRADING");
		NativeFieldInfoPtr_make_shortcut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "make_shortcut");
		NativeFieldInfoPtr_into_place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "into_place");
		NativeFieldInfoPtr_move_to_chest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "move_to_chest");
		NativeFieldInfoPtr_move_to_chest2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "move_to_chest2");
		NativeFieldInfoPtr_press_chat_querty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "press_chat_querty");
		NativeFieldInfoPtr_press_chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "press_chat");
		NativeFieldInfoPtr_saying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "saying");
		NativeFieldInfoPtr_miss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "miss");
		NativeFieldInfoPtr_donate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "donate");
		NativeFieldInfoPtr_receive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "receive");
		NativeFieldInfoPtr_press_twice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "press_twice");
		NativeFieldInfoPtr_can_harvest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "can_harvest");
		NativeFieldInfoPtr_do_accept_qwerty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "do_accept_qwerty");
		NativeFieldInfoPtr_do_accept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "do_accept");
		NativeFieldInfoPtr_plsRestartGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "plsRestartGame");
		NativeFieldInfoPtr_is_online = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "is_online");
		NativeFieldInfoPtr_is_offline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "is_offline");
		NativeFieldInfoPtr_make_friend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "make_friend");
		NativeFieldInfoPtr_chat_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chat_player");
		NativeFieldInfoPtr_chat_with = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chat_with");
		NativeFieldInfoPtr_clan_capsuledonate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_capsuledonate");
		NativeFieldInfoPtr_clan_capsuleself = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_capsuleself");
		NativeFieldInfoPtr_clan_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_point");
		NativeFieldInfoPtr_give_pea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "give_pea");
		NativeFieldInfoPtr_receive_pea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "receive_pea");
		NativeFieldInfoPtr_request_pea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "request_pea");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "time");
		NativeFieldInfoPtr_received = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "received");
		NativeFieldInfoPtr_power = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "power");
		NativeFieldInfoPtr_join_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "join_date");
		NativeFieldInfoPtr_clan_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_leader");
		NativeFieldInfoPtr_clan_coleader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_coleader");
		NativeFieldInfoPtr_power_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "power_point");
		NativeFieldInfoPtr_member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "member");
		NativeFieldInfoPtr_memberr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "memberr");
		NativeFieldInfoPtr_chatClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chatClan");
		NativeFieldInfoPtr_leaveClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "leaveClan");
		NativeFieldInfoPtr_createClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "createClan");
		NativeFieldInfoPtr_findClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "findClan");
		NativeFieldInfoPtr_khau_hieuu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "khau_hieuu");
		NativeFieldInfoPtr_bieu_tuongg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "bieu_tuongg");
		NativeFieldInfoPtr_request_pea2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "request_pea2");
		NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "level");
		NativeFieldInfoPtr_clan_birthday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_birthday");
		NativeFieldInfoPtr_clan_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_list");
		NativeFieldInfoPtr_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "create");
		NativeFieldInfoPtr_find = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "find");
		NativeFieldInfoPtr_leave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "leave");
		NativeFieldInfoPtr_not_join_clan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_join_clan");
		NativeFieldInfoPtr_clanEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clanEmpty");
		NativeFieldInfoPtr_input_clan_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_clan_name");
		NativeFieldInfoPtr_clan_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_name");
		NativeFieldInfoPtr_chat_clan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chat_clan");
		NativeFieldInfoPtr_input_clan_name_to_create = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_clan_name_to_create");
		NativeFieldInfoPtr_input_clan_slogan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_clan_slogan");
		NativeFieldInfoPtr_do_u_want_join_clan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "do_u_want_join_clan");
		NativeFieldInfoPtr_select_clan_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "select_clan_icon");
		NativeFieldInfoPtr_request_join_clan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "request_join_clan");
		NativeFieldInfoPtr_view_clan_member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "view_clan_member");
		NativeFieldInfoPtr_create_clan_co_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "create_clan_co_leader");
		NativeFieldInfoPtr_create_clan_leader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "create_clan_leader");
		NativeFieldInfoPtr_disable_clan_mastership = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "disable_clan_mastership");
		NativeFieldInfoPtr_kick_clan_mem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "kick_clan_mem");
		NativeFieldInfoPtr_clan_name_blank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_name_blank");
		NativeFieldInfoPtr_clan_slogan_blank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "clan_slogan_blank");
		NativeFieldInfoPtr_cannot_find_clan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "cannot_find_clan");
		NativeFieldInfoPtr_ago = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ago");
		NativeFieldInfoPtr_findingClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "findingClan");
		NativeFieldInfoPtr_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "trade");
		NativeFieldInfoPtr_not_lock_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_lock_trade");
		NativeFieldInfoPtr_not_lock_trade_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_lock_trade_upper");
		NativeFieldInfoPtr_locked_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "locked_trade");
		NativeFieldInfoPtr_locked_trade_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "locked_trade_upper");
		NativeFieldInfoPtr_lock_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "lock_trade");
		NativeFieldInfoPtr_wait_opp_lock_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "wait_opp_lock_trade");
		NativeFieldInfoPtr_press_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "press_done");
		NativeFieldInfoPtr_THROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "THROW");
		NativeFieldInfoPtr_SPLIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SPLIT");
		NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "done");
		NativeFieldInfoPtr_opponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "opponent");
		NativeFieldInfoPtr_you = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "you");
		NativeFieldInfoPtr_mlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "mlock");
		NativeFieldInfoPtr_money_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "money_trade");
		NativeFieldInfoPtr_GETOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "GETOUT");
		NativeFieldInfoPtr_MOVEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MOVEOUT");
		NativeFieldInfoPtr_MOVEFORPET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "MOVEFORPET");
		NativeFieldInfoPtr_GETOUTMONEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "GETOUTMONEY");
		NativeFieldInfoPtr_GETINMONEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "GETINMONEY");
		NativeFieldInfoPtr_SENDMONEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SENDMONEY");
		NativeFieldInfoPtr_GETIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "GETIN");
		NativeFieldInfoPtr_SALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SALE");
		NativeFieldInfoPtr_SALES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SALES");
		NativeFieldInfoPtr_SALEALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "SALEALL");
		NativeFieldInfoPtr_BUY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "BUY");
		NativeFieldInfoPtr_BUYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "BUYS");
		NativeFieldInfoPtr_input_money_to_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_money_to_trade");
		NativeFieldInfoPtr_input_money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_money");
		NativeFieldInfoPtr_input_money_wrong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_money_wrong");
		NativeFieldInfoPtr_not_enough_money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_enough_money");
		NativeFieldInfoPtr_input_quantity_to_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_quantity_to_trade");
		NativeFieldInfoPtr_input_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_quantity");
		NativeFieldInfoPtr_input_quantity_wrong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "input_quantity_wrong");
		NativeFieldInfoPtr_already_has_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "already_has_item");
		NativeFieldInfoPtr_unlock_item_to_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "unlock_item_to_trade");
		NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "root");
		NativeFieldInfoPtr_need = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "need");
		NativeFieldInfoPtr_need_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "need_upper");
		NativeFieldInfoPtr_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "free");
		NativeFieldInfoPtr_free1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "free1");
		NativeFieldInfoPtr_free2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "free2");
		NativeFieldInfoPtr_select_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "select_item");
		NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "random");
		NativeFieldInfoPtr_say_hello = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "say_hello");
		NativeFieldInfoPtr_say_wat_do_u_want_to_buy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "say_wat_do_u_want_to_buy");
		NativeFieldInfoPtr_say_wat_do_u_want_to_buy2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "say_wat_do_u_want_to_buy2");
		NativeFieldInfoPtr_do_u_sure_to_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "do_u_sure_to_trade");
		NativeFieldInfoPtr_learn_with = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "learn_with");
		NativeFieldInfoPtr_buy_with = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "buy_with");
		NativeFieldInfoPtr_can_not_do_when_die = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "can_not_do_when_die");
		NativeFieldInfoPtr_use_for_combine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "use_for_combine");
		NativeFieldInfoPtr_use_for_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "use_for_trade");
		NativeFieldInfoPtr_not_enough_luong_world_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_enough_luong_world_channel");
		NativeFieldInfoPtr_world_channel_5_luong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "world_channel_5_luong");
		NativeFieldInfoPtr_want_to_trade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "want_to_trade");
		NativeFieldInfoPtr_hasJustUpgrade1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "hasJustUpgrade1");
		NativeFieldInfoPtr_hasJustUpgrade2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "hasJustUpgrade2");
		NativeFieldInfoPtr_potential_to_learn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "potential_to_learn");
		NativeFieldInfoPtr_potential_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "potential_point");
		NativeFieldInfoPtr_achievement_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "achievement_point");
		NativeFieldInfoPtr_increase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "increase");
		NativeFieldInfoPtr_increase_upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "increase_upper");
		NativeFieldInfoPtr_not_enough_potential_point1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_enough_potential_point1");
		NativeFieldInfoPtr_not_enough_potential_point2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_enough_potential_point2");
		NativeFieldInfoPtr_use_potential_point_for1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "use_potential_point_for1");
		NativeFieldInfoPtr_use_potential_point_for2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "use_potential_point_for2");
		NativeFieldInfoPtr_for_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "for_HP");
		NativeFieldInfoPtr_for_KI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "for_KI");
		NativeFieldInfoPtr_for_hit_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "for_hit_point");
		NativeFieldInfoPtr_for_armor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "for_armor");
		NativeFieldInfoPtr_for_crit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "for_crit");
		NativeFieldInfoPtr_can_buy_from_Uron1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "can_buy_from_Uron1");
		NativeFieldInfoPtr_can_buy_from_Uron2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "can_buy_from_Uron2");
		NativeFieldInfoPtr_can_buy_from_Uron3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "can_buy_from_Uron3");
		NativeFieldInfoPtr_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "HP");
		NativeFieldInfoPtr_KI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "KI");
		NativeFieldInfoPtr_hit_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "hit_point");
		NativeFieldInfoPtr_armor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "armor");
		NativeFieldInfoPtr_vitality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "vitality");
		NativeFieldInfoPtr_critical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "critical");
		NativeFieldInfoPtr_cap_do = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "cap_do");
		NativeFieldInfoPtr_KI_consume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "KI_consume");
		NativeFieldInfoPtr_cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "cooldown");
		NativeFieldInfoPtr_milisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "milisecond");
		NativeFieldInfoPtr_max_level_reach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "max_level_reach");
		NativeFieldInfoPtr_next_level_require = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "next_level_require");
		NativeFieldInfoPtr_potential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "potential");
		NativeFieldInfoPtr_not_learn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_learn");
		NativeFieldInfoPtr_learn_require = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "learn_require");
		NativeFieldInfoPtr_learn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "learn");
		NativeFieldInfoPtr_to_gain_20hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "to_gain_20hp");
		NativeFieldInfoPtr_to_gain_20mp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "to_gain_20mp");
		NativeFieldInfoPtr_to_gain_1pow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "to_gain_1pow");
		NativeFieldInfoPtr_hairStyleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "hairStyleName");
		NativeFieldInfoPtr_hp_ki_full = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "hp_ki_full");
		NativeFieldInfoPtr_quest_place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "quest_place");
		NativeFieldInfoPtr_no_mission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "no_mission");
		NativeFieldInfoPtr_reward_mission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "reward_mission");
		NativeFieldInfoPtr_achievement_mission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "achievement_mission");
		NativeFieldInfoPtr_trangbi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "trangbi");
		NativeFieldInfoPtr_wat_do_u_want = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "wat_do_u_want");
		NativeFieldInfoPtr_off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "off");
		NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "on");
		NativeFieldInfoPtr_select_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "select_map");
		NativeFieldInfoPtr_offPlease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "offPlease");
		NativeFieldInfoPtr_onPlease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "onPlease");
		NativeFieldInfoPtr_language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "language");
		NativeFieldInfoPtr_VIETNAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "VIETNAM");
		NativeFieldInfoPtr_ENGLISH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "ENGLISH");
		NativeFieldInfoPtr_INDONESIA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "INDONESIA");
		NativeFieldInfoPtr_choigame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "choigame");
		NativeFieldInfoPtr_no_enemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "no_enemy");
		NativeFieldInfoPtr_kigui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "kigui");
		NativeFieldInfoPtr_kiguiXu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "kiguiXu");
		NativeFieldInfoPtr_kiguiLuong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "kiguiLuong");
		NativeFieldInfoPtr_kiguiXuchat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "kiguiXuchat");
		NativeFieldInfoPtr_kiguiLuongchat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "kiguiLuongchat");
		NativeFieldInfoPtr_huykigui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "huykigui");
		NativeFieldInfoPtr_nhantien = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "nhantien");
		NativeFieldInfoPtr_dangban = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "dangban");
		NativeFieldInfoPtr_daban = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "daban");
		NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "num");
		NativeFieldInfoPtr_upTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "upTop");
		NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "page");
		NativeFieldInfoPtr_getDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "getDown");
		NativeFieldInfoPtr_getUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "getUp");
		NativeFieldInfoPtr_notYetSell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "notYetSell");
		NativeFieldInfoPtr_charger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "charger");
		NativeFieldInfoPtr_finishBomong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "finishBomong");
		NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "note");
		NativeFieldInfoPtr_regNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "regNote");
		NativeFieldInfoPtr_remain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "remain");
		NativeFieldInfoPtr_faster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "faster");
		NativeFieldInfoPtr_fasterQuestion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "fasterQuestion");
		NativeFieldInfoPtr_chuacotaikhoan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "chuacotaikhoan");
		NativeFieldInfoPtr_taidulieudechoi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "taidulieudechoi");
		NativeFieldInfoPtr_huy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "huy");
		NativeFieldInfoPtr_taidulieu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "taidulieu");
		NativeFieldInfoPtr_xoadulieu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "xoadulieu");
		NativeFieldInfoPtr_deletaDataNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "deletaDataNote");
		NativeFieldInfoPtr_playNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "playNew");
		NativeFieldInfoPtr_playAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "playAcc");
		NativeFieldInfoPtr_vuilongnhapduthongtin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "vuilongnhapduthongtin");
		NativeFieldInfoPtr_not_register_yet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "not_register_yet");
		NativeFieldInfoPtr_nhanngoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "nhanngoc");
		NativeFieldInfoPtr_fusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "fusion");
		NativeFieldInfoPtr_sure_fusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "sure_fusion");
		NativeFieldInfoPtr_fusionForever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "fusionForever");
		NativeFieldInfoPtr_xinchucmung = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "xinchucmung");
		NativeFieldInfoPtr_den = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "den");
		NativeFieldInfoPtr_nhatvatpham = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mResources>.NativeClassPtr, "nhatvatpham");
		NativeMethodInfoPtr_loadLanguague_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mResources>.NativeClassPtr, 100664945);
		NativeMethodInfoPtr_loadLanguague_Public_Static_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mResources>.NativeClassPtr, 100664946);
		NativeMethodInfoPtr_replace_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mResources>.NativeClassPtr, 100664947);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mResources>.NativeClassPtr, 100664948);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62850, XrefRangeEnd = 62854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadLanguague()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadLanguague_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 62916, RefRangeEnd = 62921, XrefRangeStart = 62854, XrefRangeEnd = 62916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadLanguague(sbyte newLanguage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&newLanguage);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadLanguague_Public_Static_Void_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62921, XrefRangeEnd = 62930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string replace(string str, string replacement)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(replacement);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_replace_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe mResources()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<mResources>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public mResources(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
