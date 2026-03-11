using System;
using System.Runtime.CompilerServices;
using Il2CppAssets.src.g;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public class Char : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xuStr;

	private static readonly System.IntPtr NativeFieldInfoPtr_luongStr;

	private static readonly System.IntPtr NativeFieldInfoPtr_luongKhoaStr;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdateTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_meLive;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTeleport;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUsePlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowX;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowY;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowLife;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNhapThe;

	private static readonly System.IntPtr NativeFieldInfoPtr_petFollow;

	private static readonly System.IntPtr NativeFieldInfoPtr_rank;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_STAND;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_RUN;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_JUMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_FALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_DEADFLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_NOTHING;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_ATTK;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_INJURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_AUTOJUMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_FLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_STAND;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_FALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_DEAD;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_HIDE;

	private static readonly System.IntPtr NativeFieldInfoPtr_A_RESETPOINT;

	private static readonly System.IntPtr NativeFieldInfoPtr_chatPopup;

	private static readonly System.IntPtr NativeFieldInfoPtr_cPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_chatInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_petStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_cx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cvx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cvy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cp1;

	private static readonly System.IntPtr NativeFieldInfoPtr_cp2;

	private static readonly System.IntPtr NativeFieldInfoPtr_cp3;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusMe;

	private static readonly System.IntPtr NativeFieldInfoPtr_cdir;

	private static readonly System.IntPtr NativeFieldInfoPtr_charID;

	private static readonly System.IntPtr NativeFieldInfoPtr_cgender;

	private static readonly System.IntPtr NativeFieldInfoPtr_ctaskId;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_cBonusSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_cspeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_ccurrentAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_cDamFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_cDefull;

	private static readonly System.IntPtr NativeFieldInfoPtr_cCriticalFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_clevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_cMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_cHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_cHPNew;

	private static readonly System.IntPtr NativeFieldInfoPtr_cMaxEXP;

	private static readonly System.IntPtr NativeFieldInfoPtr_cHPShow;

	private static readonly System.IntPtr NativeFieldInfoPtr_xReload;

	private static readonly System.IntPtr NativeFieldInfoPtr_yReload;

	private static readonly System.IntPtr NativeFieldInfoPtr_cyStartFall;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_eff5BuffHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_eff5BuffMp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cHPFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_cMPFull;

	private static readonly System.IntPtr NativeFieldInfoPtr_cdameDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_cStr;

	private static readonly System.IntPtr NativeFieldInfoPtr_cLevelPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_cTiemNang;

	private static readonly System.IntPtr NativeFieldInfoPtr_cNangdong;

	private static readonly System.IntPtr NativeFieldInfoPtr_damHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_damMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCrit;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDie;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointUydanh;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointNon;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointVukhi;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointAo;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointLien;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointGangtay;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointNhan;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointQuan;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointNgocboi;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointGiay;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointPhu;

	private static readonly System.IntPtr NativeFieldInfoPtr_countFinishDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_countLoopBoos;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitTiemnangso;

	private static readonly System.IntPtr NativeFieldInfoPtr_limitKynangso;

	private static readonly System.IntPtr NativeFieldInfoPtr_potential;

	private static readonly System.IntPtr NativeFieldInfoPtr_cName;

	private static readonly System.IntPtr NativeFieldInfoPtr_clanID;

	private static readonly System.IntPtr NativeFieldInfoPtr_ctypeClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_clan;

	private static readonly System.IntPtr NativeFieldInfoPtr_role;

	private static readonly System.IntPtr NativeFieldInfoPtr_cw;

	private static readonly System.IntPtr NativeFieldInfoPtr_ch;

	private static readonly System.IntPtr NativeFieldInfoPtr_chw;

	private static readonly System.IntPtr NativeFieldInfoPtr_chh;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_canFly;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_me;

	private static readonly System.IntPtr NativeFieldInfoPtr_cFinishedAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_cchistlast;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAttFly;

	private static readonly System.IntPtr NativeFieldInfoPtr_cwpt;

	private static readonly System.IntPtr NativeFieldInfoPtr_cwplv;

	private static readonly System.IntPtr NativeFieldInfoPtr_cf;

	private static readonly System.IntPtr NativeFieldInfoPtr_tick;

	private static readonly System.IntPtr NativeFieldInfoPtr_fallAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_isJump;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoFall;

	private static readonly System.IntPtr NativeFieldInfoPtr_attack;

	private static readonly System.IntPtr NativeFieldInfoPtr_xu;

	private static readonly System.IntPtr NativeFieldInfoPtr_xuInBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_yen;

	private static readonly System.IntPtr NativeFieldInfoPtr_gold_lock;

	private static readonly System.IntPtr NativeFieldInfoPtr_luong;

	private static readonly System.IntPtr NativeFieldInfoPtr_luongKhoa;

	private static readonly System.IntPtr NativeFieldInfoPtr_nClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_endMovePointCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_vSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_vSkillFight;

	private static readonly System.IntPtr NativeFieldInfoPtr_vEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_myskill;

	private static readonly System.IntPtr NativeFieldInfoPtr_taskMaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintName;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrArchive;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrItemBag;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrItemBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrItemBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrPetSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrItemShop;

	private static readonly System.IntPtr NativeFieldInfoPtr_infoSpeacialSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSpeacialSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_cResFire;

	private static readonly System.IntPtr NativeFieldInfoPtr_cResIce;

	private static readonly System.IntPtr NativeFieldInfoPtr_cResWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_cMiss;

	private static readonly System.IntPtr NativeFieldInfoPtr_cExactly;

	private static readonly System.IntPtr NativeFieldInfoPtr_cFatal;

	private static readonly System.IntPtr NativeFieldInfoPtr_cPk;

	private static readonly System.IntPtr NativeFieldInfoPtr_cTypePk;

	private static readonly System.IntPtr NativeFieldInfoPtr_cReactDame;

	private static readonly System.IntPtr NativeFieldInfoPtr_sysUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_sysDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_avatar;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillTemplateId;

	private static readonly System.IntPtr NativeFieldInfoPtr_mobFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_mobMe;

	private static readonly System.IntPtr NativeFieldInfoPtr_tMobMeBorn;

	private static readonly System.IntPtr NativeFieldInfoPtr_npcFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_charFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_focus;

	private static readonly System.IntPtr NativeFieldInfoPtr_attMobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_attChars;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveFast;

	private static readonly System.IntPtr NativeFieldInfoPtr_testCharId;

	private static readonly System.IntPtr NativeFieldInfoPtr_killCharId;

	private static readonly System.IntPtr NativeFieldInfoPtr_resultTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_countKill;

	private static readonly System.IntPtr NativeFieldInfoPtr_countKillMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInvisiblez;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShadown;

	private static readonly System.IntPtr NativeFieldInfoPtr_PK_NORMAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_PK_PHE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PK_BANG;

	private static readonly System.IntPtr NativeFieldInfoPtr_PK_THIDAU;

	private static readonly System.IntPtr NativeFieldInfoPtr_PK_LUYENTAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_PK_TUDO;

	private static readonly System.IntPtr NativeFieldInfoPtr_taskOrders;

	private static readonly System.IntPtr NativeFieldInfoPtr_cStamina;

	private static readonly System.IntPtr NativeFieldInfoPtr_idHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_idAvatar;

	private static readonly System.IntPtr NativeFieldInfoPtr_exp;

	private static readonly System.IntPtr NativeFieldInfoPtr_strLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_currStrLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyeTraiDat;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyeNamek;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFreez;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCharge;

	private static readonly System.IntPtr NativeFieldInfoPtr_seconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_freezSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeFieldInfoPtr_cur;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastFreez;

	private static readonly System.IntPtr NativeFieldInfoPtr_currFreez;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFlyUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_vItemTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_ID_NEW_MOUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHaveMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMountVip;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEventMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSpeacialMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_TD;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_NM;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_NM_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_XD;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_TD_VIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_NM_VIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_NM_1_VIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMount_XD_VIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgEventMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgEventMountWing;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrameMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameNewMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_transMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_genderMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_idcharMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_xMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_dxMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_dyMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_xChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_xdis;

	private static readonly System.IntPtr NativeFieldInfoPtr_speedMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isStartMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEndMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_cFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_flagImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_x_hint;

	private static readonly System.IntPtr NativeFieldInfoPtr_y_hint;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAR_WEAPONX;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAR_WEAPONY;

	private static readonly System.IntPtr NativeFieldInfoPtr_myChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_myPet;

	private static readonly System.IntPtr NativeFieldInfoPtr_listAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_listIonC;

	private static readonly System.IntPtr NativeFieldInfoPtr_cvyJump;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexUseSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_cxSend;

	private static readonly System.IntPtr NativeFieldInfoPtr_cySend;

	private static readonly System.IntPtr NativeFieldInfoPtr_cdirSend;

	private static readonly System.IntPtr NativeFieldInfoPtr_cxFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_cyFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_cactFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_vMovePoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_inforClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_inforSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_flag;

	private static readonly System.IntPtr NativeFieldInfoPtr_ischangingMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLockKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoadingMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLockMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLockAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_strInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_powerPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPowerPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastS;

	private static readonly System.IntPtr NativeFieldInfoPtr_currS;

	private static readonly System.IntPtr NativeFieldInfoPtr_havePet;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentMovePoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_bom;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayFall;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSoundJump;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_eProtect;

	private static readonly System.IntPtr NativeFieldInfoPtr_twHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInjureHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_changePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHide;

	private static readonly System.IntPtr NativeFieldInfoPtr_wy;

	private static readonly System.IntPtr NativeFieldInfoPtr_wt;

	private static readonly System.IntPtr NativeFieldInfoPtr_fy;

	private static readonly System.IntPtr NativeFieldInfoPtr_ty;

	private static readonly System.IntPtr NativeFieldInfoPtr_t;

	private static readonly System.IntPtr NativeFieldInfoPtr_fM;

	private static readonly System.IntPtr NativeFieldInfoPtr_move;

	private static readonly System.IntPtr NativeFieldInfoPtr_strMount;

	private static readonly System.IntPtr NativeFieldInfoPtr_head;

	private static readonly System.IntPtr NativeFieldInfoPtr_leg;

	private static readonly System.IntPtr NativeFieldInfoPtr_body;

	private static readonly System.IntPtr NativeFieldInfoPtr_bag;

	private static readonly System.IntPtr NativeFieldInfoPtr_wp;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexEffTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_eff;

	private static readonly System.IntPtr NativeFieldInfoPtr_effTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_i0;

	private static readonly System.IntPtr NativeFieldInfoPtr_i1;

	private static readonly System.IntPtr NativeFieldInfoPtr_i2;

	private static readonly System.IntPtr NativeFieldInfoPtr_dx0;

	private static readonly System.IntPtr NativeFieldInfoPtr_dx1;

	private static readonly System.IntPtr NativeFieldInfoPtr_dx2;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy0;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy1;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy2;

	private static readonly System.IntPtr NativeFieldInfoPtr_eff0;

	private static readonly System.IntPtr NativeFieldInfoPtr_eff1;

	private static readonly System.IntPtr NativeFieldInfoPtr_eff2;

	private static readonly System.IntPtr NativeFieldInfoPtr_arr;

	private static readonly System.IntPtr NativeFieldInfoPtr_dart;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCreateDark;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillPaintRandomPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_effPaints;

	private static readonly System.IntPtr NativeFieldInfoPtr_sType;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInjure;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUseSkillAfterCharge;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFlyAndCharge;

	private static readonly System.IntPtr NativeFieldInfoPtr_isStandAndCharge;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFlying;

	private static readonly System.IntPtr NativeFieldInfoPtr_posDisY;

	private static readonly System.IntPtr NativeFieldInfoPtr_chargeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasSendAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMabuHold;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeBlue;

	private static readonly System.IntPtr NativeFieldInfoPtr_tBlue;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAddDust1;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAddDust2;

	private static readonly System.IntPtr NativeFieldInfoPtr_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_w_hp_bar;

	private static readonly System.IntPtr NativeFieldInfoPtr_per;

	private static readonly System.IntPtr NativeFieldInfoPtr_per_tem;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHPtem;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPet;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMiniPet;

	private static readonly System.IntPtr NativeFieldInfoPtr_xSd;

	private static readonly System.IntPtr NativeFieldInfoPtr_ySd;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOutMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_fBag;

	private static readonly System.IntPtr NativeFieldInfoPtr_ph;

	private static readonly System.IntPtr NativeFieldInfoPtr_pl;

	private static readonly System.IntPtr NativeFieldInfoPtr_pb;

	private static readonly System.IntPtr NativeFieldInfoPtr_cH_new;

	private static readonly System.IntPtr NativeFieldInfoPtr_statusBeforeNothing;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeFocusToMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_isManualFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_charHold;

	private static readonly System.IntPtr NativeFieldInfoPtr_mobHold;

	private static readonly System.IntPtr NativeFieldInfoPtr_nInjure;

	private static readonly System.IntPtr NativeFieldInfoPtr_wdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_wdy;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDirtyPostion;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastNormalSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentFireByShortcut;

	private static readonly System.IntPtr NativeFieldInfoPtr_cDamGoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_cHPGoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_cMPGoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_cDefGoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_cCriticalGoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpFrom1000TiemNang;

	private static readonly System.IntPtr NativeFieldInfoPtr_mpFrom1000TiemNang;

	private static readonly System.IntPtr NativeFieldInfoPtr_damFrom1000TiemNang;

	private static readonly System.IntPtr NativeFieldInfoPtr_defFrom1000TiemNang;

	private static readonly System.IntPtr NativeFieldInfoPtr_criticalFrom1000Tiemnang;

	private static readonly System.IntPtr NativeFieldInfoPtr_cMaxStamina;

	private static readonly System.IntPtr NativeFieldInfoPtr_expForOneAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMonkey;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCopy;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWaitMonkey;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFeetEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_meDead;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdEffID;

	private static readonly System.IntPtr NativeFieldInfoPtr_holder;

	private static readonly System.IntPtr NativeFieldInfoPtr_protectEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSetPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_tpos;

	private static readonly System.IntPtr NativeFieldInfoPtr_xPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_yPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_typePos;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMyFusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_tFusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_huytSao;

	private static readonly System.IntPtr NativeFieldInfoPtr_blindEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_telePortSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleepEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_stone;

	private static readonly System.IntPtr NativeFieldInfoPtr_perCentMp;

	private static readonly System.IntPtr NativeFieldInfoPtr_dHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_headTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_legTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_bagTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_wpTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_vEffChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraRedEye;

	private static readonly System.IntPtr NativeFieldInfoPtr_fChopmat;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAddChopMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeAddChopmat;

	private static readonly System.IntPtr NativeFieldInfoPtr_frChopNhanh;

	private static readonly System.IntPtr NativeFieldInfoPtr_frChopCham;

	private static readonly System.IntPtr NativeFieldInfoPtr_frEye;

	private static readonly System.IntPtr NativeFieldInfoPtr_Arr_Head_2Fr;

	private static readonly System.IntPtr NativeFieldInfoPtr_fHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_strEffAura;

	private static readonly System.IntPtr NativeFieldInfoPtr_idAuraEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintAura;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintAura2;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraEffSub;

	private static readonly System.IntPtr NativeFieldInfoPtr_strEff_Set_Item;

	private static readonly System.IntPtr NativeFieldInfoPtr_idEff_Set_Item;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraHat_behind;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraHat_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraHat_behind_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraHat_font_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_strHat_behind;

	private static readonly System.IntPtr NativeFieldInfoPtr_strHat_font;

	private static readonly System.IntPtr NativeFieldInfoPtr_strNgang;

	private static readonly System.IntPtr NativeFieldInfoPtr_idHat;

	private static readonly System.IntPtr NativeFieldInfoPtr_hatInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SKILL_KAMEX10;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SKILL_FINAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SKILL_MAFUBA;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SKILL_GENKI;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintNewSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFly;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeReset_newSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_idskillPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_fr_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_fr_atk;

	private static readonly System.IntPtr NativeFieldInfoPtr_fr_end;

	private static readonly System.IntPtr NativeFieldInfoPtr_count_NEW;

	private static readonly System.IntPtr NativeFieldInfoPtr_stt;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangeDame;

	private static readonly System.IntPtr NativeFieldInfoPtr_typePaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetDame;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeDame;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMafuba;

	private static readonly System.IntPtr NativeFieldInfoPtr_countMafuba;

	private static readonly System.IntPtr NativeFieldInfoPtr_xMFB;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMFB;

	private static readonly System.IntPtr NativeFieldInfoPtr_danhhieu;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_idVongChan;

	private static readonly System.IntPtr NativeMethodInfoPtr_subcName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyCharLevelPercent_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getdxSkill_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getdySkill_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_taskAction_Public_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getStrLevel_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_avatarz_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getAvatar_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPowerInfo_Public_Void_String_Int16_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addInfo_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSys_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_myCharz_Public_Static_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_myPetz_Public_Static_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearMyChar_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bagSort_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_boxSort_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_useItem_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSkill_Public_Skill_SkillTemplate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInEnterOfflinePoint_Public_Waypoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInEnterOnlinePoint_Public_Waypoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInWaypoint_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPunchKickSkill_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_soundUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateChargeSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isWaiting_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateEffect_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkPerformEndMovePointAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkHideCharName_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMobMe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSkillPaint_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveLoadPreviousSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setResetPoint_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharDeadFly_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateResetPoint_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSkillFall_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSkillStand_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharAutoJump_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getVx_Public_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hide_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_show_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getVy_Public_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_returnAct_Public_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAutoJump_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharStand_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSuperEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSoundVolumn_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharRun_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stop_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_abs_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharJump_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkInRangeJump_Public_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCharFallFromJump_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharFall_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharFly_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMount_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMount_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMountData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkFrameTick_Public_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintMount1_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintMount2_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMountIsStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMountIsEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkHaveMount_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkDelayFallIfTooHigh_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDefaultPart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDefaultWeapon_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDefaultBody_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDefaultLeg_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isSelectingSkillUseAlone_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isUseSkillSpec_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isSelectingSkillBuffToPlayer_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isUseChargeSkill_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSkillPaint_Public_Void_SkillPaint_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_useSkillNotFocus_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendUseChargeSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopUseChargeSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_useChargeSkill_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAutoSkillPaint_Public_Void_SkillPaint_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_skillInfoPaint_Public_Il2CppReferenceArray_1_SkillInfoPaint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAttack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isOutX_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPaint_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createShadow_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMabuHold_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintDanhHieu_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Virtual_New_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_map_line_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintEff_Pet_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintSuperEffBehind_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintSuperEffFront_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintEffect_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintArrowAttack_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintHp_Public_Void_mGraphics_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getClassColor_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintNameInSameParty_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCharName_HP_MP_Overhead_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintShadow_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateShadown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCharWithoutSkill_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBag_Public_Void_mGraphics_Il2CppStructArray_1_Int16_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isCharBodyImageID_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintHead_Public_Void_mGraphics_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintHeadWithXY_Public_Void_mGraphics_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCharBody_Public_Void_mGraphics_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCharWithSkill_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getIndexChar_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveTo_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getcharInjure_Public_Static_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMagicTree_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_searchItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_searchFocus_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearFocus_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isCharInScreen_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isAttacPlayerStatus_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setHoldChar_Public_Void_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setHoldMob_Public_Void_Mob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findNextFocusByKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_deFocusNPC_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCharInBridge_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sort_Public_Static_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setInsc_Public_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_kickOption_Public_Void_Item_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doInjure_Public_Void_Int64_Int64_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doInjure_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startDie_Public_Void_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_waitToDie_Public_Void_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_liveFromDead_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHavePean_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doUsePotion_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isLang_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMeCanAttackOtherPlayer_Public_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearTask_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getX_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getY_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getH_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getW_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_focusManualTo_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopMoving_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cancelAttack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInvisible_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_focusToAttack_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addDustEff_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isGetFlagImage_Public_Boolean_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintPKFlag_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeHoleEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeProtectEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeBlindEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeEffect_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPos_Public_Void_Int16_Int16_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeHuytSao_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_fusionComplete_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFusion_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeSleepEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPartOld_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPartTemp_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetPartTemp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEffById_Public_Effect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addEffChar_Public_Void_Effect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeEffChar_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintEffBehind_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintEffFront_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updEffChar_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkLuong_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateEye_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintRedEye_Private_Void_mGraphics_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHead_2Fr_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateFHead_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFHead_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintAuraBehind_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintAuraFront_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintEff_Lvup_behind_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintEff_Lvup_front_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintHat_behind_Public_Void_mGraphics_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintHat_front_Public_Void_mGraphics_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isFrNgang_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendNewAttack_Public_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkillPaint_NEW_Public_Void_Int16_Boolean_SByte_SByte_SByte_Int16_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSkillPaint_STT_Public_Void_Int32_Int16_Point_Int16_Int16_SByte_Il2CppReferenceArray_1_Point_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdSkillPaint_NEW_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGender_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updatePetPean_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isBuffPet_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getGender_Public_String_0;

	public unsafe string xuStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xuStr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xuStr)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string luongStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luongStr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luongStr)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string luongKhoaStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luongKhoaStr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luongKhoaStr)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe long lastUpdateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdateTime);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdateTime)) = num;
		}
	}

	public unsafe bool meLive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meLive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meLive)) = flag;
		}
	}

	public unsafe bool isMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMask);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMask)) = flag;
		}
	}

	public unsafe bool isTeleport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTeleport);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTeleport)) = flag;
		}
	}

	public unsafe bool isUsePlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUsePlane);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUsePlane)) = flag;
		}
	}

	public unsafe int shadowX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowX)) = num;
		}
	}

	public unsafe int shadowY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowY)) = num;
		}
	}

	public unsafe int shadowLife
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowLife);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowLife)) = num;
		}
	}

	public unsafe bool isNhapThe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNhapThe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNhapThe)) = flag;
		}
	}

	public unsafe PetFollow petFollow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_petFollow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PetFollow>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_petFollow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)petFollow));
		}
	}

	public unsafe int rank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank)) = num;
		}
	}

	public unsafe static sbyte A_STAND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_STAND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_STAND, (void*)(&b));
		}
	}

	public unsafe static sbyte A_RUN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_RUN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_RUN, (void*)(&b));
		}
	}

	public unsafe static sbyte A_JUMP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_JUMP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_JUMP, (void*)(&b));
		}
	}

	public unsafe static sbyte A_FALL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_FALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_FALL, (void*)(&b));
		}
	}

	public unsafe static sbyte A_DEADFLY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_DEADFLY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_DEADFLY, (void*)(&b));
		}
	}

	public unsafe static sbyte A_NOTHING
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_NOTHING, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_NOTHING, (void*)(&b));
		}
	}

	public unsafe static sbyte A_ATTK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_ATTK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_ATTK, (void*)(&b));
		}
	}

	public unsafe static sbyte A_INJURE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_INJURE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_INJURE, (void*)(&b));
		}
	}

	public unsafe static sbyte A_AUTOJUMP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_AUTOJUMP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_AUTOJUMP, (void*)(&b));
		}
	}

	public unsafe static sbyte A_FLY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_FLY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_FLY, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_STAND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_STAND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_STAND, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_FALL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_FALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_FALL, (void*)(&b));
		}
	}

	public unsafe static sbyte A_DEAD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_DEAD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_DEAD, (void*)(&b));
		}
	}

	public unsafe static sbyte A_HIDE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_HIDE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_HIDE, (void*)(&b));
		}
	}

	public unsafe static sbyte A_RESETPOINT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_A_RESETPOINT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_A_RESETPOINT, (void*)(&b));
		}
	}

	public unsafe static ChatPopup chatPopup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_chatPopup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatPopup>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_chatPopup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatPopup));
		}
	}

	public unsafe long cPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cPower);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cPower)) = num;
		}
	}

	public unsafe Info chatInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chatInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Info>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chatInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info));
		}
	}

	public unsafe sbyte petStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_petStatus);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_petStatus)) = b;
		}
	}

	public unsafe int cx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cx)) = num;
		}
	}

	public unsafe int cy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cy)) = num;
		}
	}

	public unsafe int cvx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cvx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cvx)) = num;
		}
	}

	public unsafe int cvy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cvy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cvy)) = num;
		}
	}

	public unsafe int cp1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cp1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cp1)) = num;
		}
	}

	public unsafe int cp2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cp2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cp2)) = num;
		}
	}

	public unsafe int cp3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cp3);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cp3)) = num;
		}
	}

	public unsafe int statusMe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusMe);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusMe)) = num;
		}
	}

	public unsafe int cdir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdir);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdir)) = num;
		}
	}

	public unsafe int charID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charID)) = num;
		}
	}

	public unsafe int cgender
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cgender);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cgender)) = num;
		}
	}

	public unsafe int ctaskId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctaskId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctaskId)) = num;
		}
	}

	public unsafe int menuSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuSelect);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuSelect)) = num;
		}
	}

	public unsafe int cBonusSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cBonusSpeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cBonusSpeed)) = num;
		}
	}

	public unsafe int cspeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cspeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cspeed)) = num;
		}
	}

	public unsafe int ccurrentAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ccurrentAttack);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ccurrentAttack)) = num;
		}
	}

	public unsafe long cDamFull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDamFull);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDamFull)) = num;
		}
	}

	public unsafe int cDefull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDefull);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDefull)) = num;
		}
	}

	public unsafe int cCriticalFull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cCriticalFull);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cCriticalFull)) = num;
		}
	}

	public unsafe int clevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clevel)) = num;
		}
	}

	public unsafe long cMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMP);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMP)) = num;
		}
	}

	public unsafe long cHP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHP);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHP)) = num;
		}
	}

	public unsafe long cHPNew
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPNew);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPNew)) = num;
		}
	}

	public unsafe int cMaxEXP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMaxEXP);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMaxEXP)) = num;
		}
	}

	public unsafe long cHPShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPShow);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPShow)) = num;
		}
	}

	public unsafe int xReload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xReload);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xReload)) = num;
		}
	}

	public unsafe int yReload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yReload);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yReload)) = num;
		}
	}

	public unsafe int cyStartFall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cyStartFall);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cyStartFall)) = num;
		}
	}

	public unsafe int saveStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveStatus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveStatus)) = num;
		}
	}

	public unsafe int eff5BuffHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff5BuffHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff5BuffHp)) = num;
		}
	}

	public unsafe int eff5BuffMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff5BuffMp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff5BuffMp)) = num;
		}
	}

	public unsafe long cHPFull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPFull);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPFull)) = num;
		}
	}

	public unsafe long cMPFull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMPFull);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMPFull)) = num;
		}
	}

	public unsafe int cdameDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdameDown);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdameDown)) = num;
		}
	}

	public unsafe int cStr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStr);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStr)) = num;
		}
	}

	public unsafe long cLevelPercent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cLevelPercent);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cLevelPercent)) = num;
		}
	}

	public unsafe long cTiemNang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cTiemNang);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cTiemNang)) = num;
		}
	}

	public unsafe long cNangdong
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cNangdong);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cNangdong)) = num;
		}
	}

	public unsafe long damHP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damHP);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damHP)) = num;
		}
	}

	public unsafe long damMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damMP);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damMP)) = num;
		}
	}

	public unsafe bool isMob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMob)) = flag;
		}
	}

	public unsafe bool isCrit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCrit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCrit)) = flag;
		}
	}

	public unsafe bool isDie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDie);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDie)) = flag;
		}
	}

	public unsafe int pointUydanh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointUydanh);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointUydanh)) = num;
		}
	}

	public unsafe int pointNon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointNon);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointNon)) = num;
		}
	}

	public unsafe int pointVukhi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointVukhi);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointVukhi)) = num;
		}
	}

	public unsafe int pointAo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointAo);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointAo)) = num;
		}
	}

	public unsafe int pointLien
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointLien);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointLien)) = num;
		}
	}

	public unsafe int pointGangtay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointGangtay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointGangtay)) = num;
		}
	}

	public unsafe int pointNhan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointNhan);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointNhan)) = num;
		}
	}

	public unsafe int pointQuan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointQuan);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointQuan)) = num;
		}
	}

	public unsafe int pointNgocboi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointNgocboi);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointNgocboi)) = num;
		}
	}

	public unsafe int pointGiay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointGiay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointGiay)) = num;
		}
	}

	public unsafe int pointPhu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointPhu);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointPhu)) = num;
		}
	}

	public unsafe int countFinishDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFinishDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countFinishDay)) = num;
		}
	}

	public unsafe int countLoopBoos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countLoopBoos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countLoopBoos)) = num;
		}
	}

	public unsafe int limitTiemnangso
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitTiemnangso);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitTiemnangso)) = num;
		}
	}

	public unsafe int limitKynangso
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitKynangso);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limitKynangso)) = num;
		}
	}

	public unsafe Il2CppStructArray<short> potential
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potential);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_potential)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string cName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int clanID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clanID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clanID)) = num;
		}
	}

	public unsafe sbyte ctypeClan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctypeClan);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ctypeClan)) = b;
		}
	}

	public unsafe Clan clan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clan);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Clan>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clan)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clan));
		}
	}

	public unsafe sbyte role
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_role);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_role)) = b;
		}
	}

	public unsafe int cw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cw);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cw)) = num;
		}
	}

	public unsafe int ch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ch);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ch)) = num;
		}
	}

	public unsafe int chw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chw);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chw)) = num;
		}
	}

	public unsafe int chh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chh);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chh)) = num;
		}
	}

	public unsafe Command cmdMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdMenu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdMenu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe bool canFly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canFly)) = flag;
		}
	}

	public unsafe bool cmtoChar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoChar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoChar)) = flag;
		}
	}

	public unsafe bool me
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_me);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_me)) = flag;
		}
	}

	public unsafe bool cFinishedAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFinishedAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFinishedAttack)) = flag;
		}
	}

	public unsafe bool cchistlast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cchistlast);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cchistlast)) = flag;
		}
	}

	public unsafe bool isAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttack)) = flag;
		}
	}

	public unsafe bool isAttFly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttFly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAttFly)) = flag;
		}
	}

	public unsafe int cwpt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cwpt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cwpt)) = num;
		}
	}

	public unsafe int cwplv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cwplv);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cwplv)) = num;
		}
	}

	public unsafe int cf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cf);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cf)) = num;
		}
	}

	public unsafe int tick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tick)) = num;
		}
	}

	public unsafe static bool fallAttack
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fallAttack, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fallAttack, (void*)(&flag));
		}
	}

	public unsafe bool isJump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJump)) = flag;
		}
	}

	public unsafe bool autoFall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFall);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoFall)) = flag;
		}
	}

	public unsafe bool attack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attack)) = flag;
		}
	}

	public unsafe long xu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xu);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xu)) = num;
		}
	}

	public unsafe int xuInBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xuInBox);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xuInBox)) = num;
		}
	}

	public unsafe int yen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yen);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yen)) = num;
		}
	}

	public unsafe int gold_lock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gold_lock);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gold_lock)) = num;
		}
	}

	public unsafe int luong
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luong);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luong)) = num;
		}
	}

	public unsafe int luongKhoa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luongKhoa);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luongKhoa)) = num;
		}
	}

	public unsafe NClass nClass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nClass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NClass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nClass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nClass));
		}
	}

	public unsafe Command endMovePointCommand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endMovePointCommand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endMovePointCommand)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe MyVector vSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe MyVector vSkillFight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vSkillFight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vSkillFight)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe MyVector vEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vEff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vEff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe Skill myskill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myskill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skill>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myskill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill));
		}
	}

	public unsafe Task taskMaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskMaint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskMaint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task));
		}
	}

	public unsafe bool paintName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintName)) = flag;
		}
	}

	public unsafe Il2CppReferenceArray<Archivement> arrArchive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrArchive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Archivement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrArchive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Item> arrItemBag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemBag);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Item>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemBag)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Item> arrItemBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemBox);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Item>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemBox)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Item> arrItemBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemBody);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Item>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemBody)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Skill> arrPetSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrPetSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Skill>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrPetSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppReferenceArray<Item>> arrItemShop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemShop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Item>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrItemShop)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStringArray> infoSpeacialSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoSpeacialSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infoSpeacialSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<short>> imgSpeacialSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgSpeacialSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<short>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgSpeacialSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe short cResFire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cResFire);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cResFire)) = num;
		}
	}

	public unsafe short cResIce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cResIce);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cResIce)) = num;
		}
	}

	public unsafe short cResWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cResWind);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cResWind)) = num;
		}
	}

	public unsafe short cMiss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMiss);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMiss)) = num;
		}
	}

	public unsafe short cExactly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cExactly);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cExactly)) = num;
		}
	}

	public unsafe short cFatal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFatal);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFatal)) = num;
		}
	}

	public unsafe sbyte cPk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cPk);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cPk)) = b;
		}
	}

	public unsafe sbyte cTypePk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cTypePk);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cTypePk)) = b;
		}
	}

	public unsafe short cReactDame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cReactDame);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cReactDame)) = num;
		}
	}

	public unsafe short sysUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sysUp);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sysUp)) = num;
		}
	}

	public unsafe short sysDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sysDown);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sysDown)) = num;
		}
	}

	public unsafe int avatar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avatar);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avatar)) = num;
		}
	}

	public unsafe int skillTemplateId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillTemplateId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillTemplateId)) = num;
		}
	}

	public unsafe Mob mobFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mob));
		}
	}

	public unsafe Mob mobMe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobMe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobMe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mob));
		}
	}

	public unsafe int tMobMeBorn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMobMeBorn);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMobMeBorn)) = num;
		}
	}

	public unsafe Npc npcFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Npc>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc));
		}
	}

	public unsafe Char charFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe ItemMap itemFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemMap>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemMap));
		}
	}

	public unsafe MyVector focus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe Il2CppReferenceArray<Mob> attMobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attMobs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Mob>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attMobs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Char> attChars
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attChars);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Char>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attChars)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<short> moveFast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveFast);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveFast)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int testCharId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testCharId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_testCharId)) = num;
		}
	}

	public unsafe int killCharId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killCharId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_killCharId)) = num;
		}
	}

	public unsafe sbyte resultTest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultTest);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resultTest)) = b;
		}
	}

	public unsafe int countKill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countKill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countKill)) = num;
		}
	}

	public unsafe int countKillMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countKillMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countKillMax)) = num;
		}
	}

	public unsafe bool isInvisiblez
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInvisiblez);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInvisiblez)) = flag;
		}
	}

	public unsafe bool isShadown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShadown);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShadown)) = flag;
		}
	}

	public unsafe static sbyte PK_NORMAL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PK_NORMAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PK_NORMAL, (void*)(&b));
		}
	}

	public unsafe static sbyte PK_PHE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PK_PHE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PK_PHE, (void*)(&b));
		}
	}

	public unsafe static sbyte PK_BANG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PK_BANG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PK_BANG, (void*)(&b));
		}
	}

	public unsafe static sbyte PK_THIDAU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PK_THIDAU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PK_THIDAU, (void*)(&b));
		}
	}

	public unsafe static sbyte PK_LUYENTAP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PK_LUYENTAP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PK_LUYENTAP, (void*)(&b));
		}
	}

	public unsafe static sbyte PK_TUDO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PK_TUDO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PK_TUDO, (void*)(&b));
		}
	}

	public unsafe MyVector taskOrders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskOrders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taskOrders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe int cStamina
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStamina);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cStamina)) = num;
		}
	}

	public unsafe static Il2CppStructArray<short> idHead
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idHead, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idHead, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<short> idAvatar
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idAvatar, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idAvatar, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int exp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exp)) = num;
		}
	}

	public unsafe Il2CppStringArray strLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strLevel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string currStrLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currStrLevel);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currStrLevel)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Image eyeTraiDat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_eyeTraiDat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_eyeTraiDat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image eyeNamek
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_eyeNamek, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_eyeNamek, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe bool isFreez
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFreez);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFreez)) = flag;
		}
	}

	public unsafe bool isCharge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCharge);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCharge)) = flag;
		}
	}

	public unsafe int seconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seconds);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seconds)) = num;
		}
	}

	public unsafe int freezSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezSeconds);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezSeconds)) = num;
		}
	}

	public unsafe long last
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last)) = num;
		}
	}

	public unsafe long cur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cur);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cur)) = num;
		}
	}

	public unsafe long lastFreez
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFreez);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFreez)) = num;
		}
	}

	public unsafe long currFreez
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currFreez);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currFreez)) = num;
		}
	}

	public unsafe bool isFlyUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFlyUp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFlyUp)) = flag;
		}
	}

	public unsafe static MyVector vItemTime
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vItemTime, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vItemTime, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static short ID_NEW_MOUNT
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ID_NEW_MOUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ID_NEW_MOUNT, (void*)(&num));
		}
	}

	public unsafe short idMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idMount);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idMount)) = num;
		}
	}

	public unsafe bool isHaveMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHaveMount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHaveMount)) = flag;
		}
	}

	public unsafe bool isMountVip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMountVip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMountVip)) = flag;
		}
	}

	public unsafe bool isEventMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEventMount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEventMount)) = flag;
		}
	}

	public unsafe bool isSpeacialMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpeacialMount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSpeacialMount)) = flag;
		}
	}

	public unsafe static Image imgMount_TD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_TD, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_TD, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMount_NM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_NM, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_NM, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMount_NM_1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_NM_1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_NM_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMount_XD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_XD, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_XD, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMount_TD_VIP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_TD_VIP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_TD_VIP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMount_NM_VIP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_NM_VIP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_NM_VIP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMount_NM_1_VIP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_NM_1_VIP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_NM_1_VIP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMount_XD_VIP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMount_XD_VIP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMount_XD_VIP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgEventMount
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgEventMount, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgEventMount, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgEventMountWing
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgEventMountWing, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgEventMountWing, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Il2CppStructArray<sbyte> FrameMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrameMount);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrameMount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int frameMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameMount)) = num;
		}
	}

	public unsafe int frameNewMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameNewMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameNewMount)) = num;
		}
	}

	public unsafe int transMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transMount)) = num;
		}
	}

	public unsafe int genderMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_genderMount)) = num;
		}
	}

	public unsafe int idcharMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idcharMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idcharMount)) = num;
		}
	}

	public unsafe int xMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMount)) = num;
		}
	}

	public unsafe int yMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMount)) = num;
		}
	}

	public unsafe int dxMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dxMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dxMount)) = num;
		}
	}

	public unsafe int dyMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dyMount)) = num;
		}
	}

	public unsafe int xChar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xChar);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xChar)) = num;
		}
	}

	public unsafe int xdis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xdis);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xdis)) = num;
		}
	}

	public unsafe int speedMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedMount)) = num;
		}
	}

	public unsafe bool isStartMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStartMount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStartMount)) = flag;
		}
	}

	public unsafe bool isMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMount)) = flag;
		}
	}

	public unsafe bool isEndMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEndMount);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEndMount)) = flag;
		}
	}

	public unsafe sbyte cFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFlag);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFlag)) = b;
		}
	}

	public unsafe int flagImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flagImage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flagImage)) = num;
		}
	}

	public unsafe short x_hint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x_hint);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x_hint)) = num;
		}
	}

	public unsafe short y_hint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y_hint);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y_hint)) = num;
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppReferenceArray<Il2CppStructArray<int>>> CharInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CharInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Il2CppStructArray<int>>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CharInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> CHAR_WEAPONX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAR_WEAPONX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAR_WEAPONX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> CHAR_WEAPONY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAR_WEAPONY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAR_WEAPONY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Char myChar
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_myChar, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_myChar, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static Char myPet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_myPet, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_myPet, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static Il2CppStructArray<int> listAttack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listAttack, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listAttack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> listIonC
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listIonC, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listIonC, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int cvyJump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cvyJump);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cvyJump)) = num;
		}
	}

	public unsafe int indexUseSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexUseSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexUseSkill)) = num;
		}
	}

	public unsafe int cxSend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cxSend);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cxSend)) = num;
		}
	}

	public unsafe int cySend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cySend);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cySend)) = num;
		}
	}

	public unsafe int cdirSend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdirSend);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cdirSend)) = num;
		}
	}

	public unsafe int cxFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cxFocus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cxFocus)) = num;
		}
	}

	public unsafe int cyFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cyFocus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cyFocus)) = num;
		}
	}

	public unsafe int cactFirst
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cactFirst);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cactFirst)) = num;
		}
	}

	public unsafe MyVector vMovePoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vMovePoints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vMovePoints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStringArray> inforClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inforClass, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inforClass, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> inforSkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inforSkill, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inforSkill, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool flag
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flag, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flag, (void*)(&flag));
		}
	}

	public unsafe static bool ischangingMap
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ischangingMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ischangingMap, (void*)(&flag));
		}
	}

	public unsafe static bool isLockKey
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLockKey, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLockKey, (void*)(&flag));
		}
	}

	public unsafe static bool isLoadingMap
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoadingMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoadingMap, (void*)(&flag));
		}
	}

	public unsafe bool isLockMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLockMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLockMove)) = flag;
		}
	}

	public unsafe bool isLockAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLockAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLockAttack)) = flag;
		}
	}

	public unsafe string strInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strInfo);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strInfo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe short powerPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerPoint);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerPoint)) = num;
		}
	}

	public unsafe short maxPowerPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPowerPoint);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPowerPoint)) = num;
		}
	}

	public unsafe short secondPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondPower);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondPower)) = num;
		}
	}

	public unsafe long lastS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastS);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastS)) = num;
		}
	}

	public unsafe long currS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currS);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currS)) = num;
		}
	}

	public unsafe bool havePet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_havePet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_havePet)) = flag;
		}
	}

	public unsafe MovePoint currentMovePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMovePoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MovePoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentMovePoint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)movePoint));
		}
	}

	public unsafe int bom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bom);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bom)) = num;
		}
	}

	public unsafe int delayFall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayFall);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayFall)) = num;
		}
	}

	public unsafe bool isSoundJump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSoundJump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSoundJump)) = flag;
		}
	}

	public unsafe int lastFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFrame)) = num;
		}
	}

	public unsafe Effect eProtect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eProtect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Effect>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eProtect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effect));
		}
	}

	public unsafe int twHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twHp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twHp)) = num;
		}
	}

	public unsafe bool isInjureHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInjureHp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInjureHp)) = flag;
		}
	}

	public unsafe bool changePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changePos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changePos)) = flag;
		}
	}

	public unsafe bool isHide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHide)) = flag;
		}
	}

	public unsafe bool wy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wy)) = flag;
		}
	}

	public unsafe int wt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wt)) = num;
		}
	}

	public unsafe int fy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fy)) = num;
		}
	}

	public unsafe int ty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ty)) = num;
		}
	}

	public unsafe int t
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t)) = num;
		}
	}

	public unsafe int fM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fM);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fM)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> move
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_move);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_move)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string strMount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strMount);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strMount)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_head);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_head)) = num;
		}
	}

	public unsafe int leg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leg)) = num;
		}
	}

	public unsafe int body
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_body);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_body)) = num;
		}
	}

	public unsafe int bag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bag)) = num;
		}
	}

	public unsafe int wp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wp)) = num;
		}
	}

	public unsafe int indexEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexEff);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexEff)) = num;
		}
	}

	public unsafe int indexEffTask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexEffTask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexEffTask)) = num;
		}
	}

	public unsafe EffectCharPaint eff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectCharPaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectCharPaint));
		}
	}

	public unsafe EffectCharPaint effTask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effTask);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectCharPaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effTask)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectCharPaint));
		}
	}

	public unsafe int indexSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexSkill)) = num;
		}
	}

	public unsafe int i0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i0);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i0)) = num;
		}
	}

	public unsafe int i1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i1)) = num;
		}
	}

	public unsafe int i2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i2)) = num;
		}
	}

	public unsafe int dx0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx0);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx0)) = num;
		}
	}

	public unsafe int dx1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx1)) = num;
		}
	}

	public unsafe int dx2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx2)) = num;
		}
	}

	public unsafe int dy0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy0);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy0)) = num;
		}
	}

	public unsafe int dy1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy1)) = num;
		}
	}

	public unsafe int dy2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy2)) = num;
		}
	}

	public unsafe EffectCharPaint eff0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectCharPaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectCharPaint));
		}
	}

	public unsafe EffectCharPaint eff1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectCharPaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectCharPaint));
		}
	}

	public unsafe EffectCharPaint eff2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectCharPaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eff2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectCharPaint));
		}
	}

	public unsafe Arrow arr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Arrow>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arrow));
		}
	}

	public unsafe PlayerDart dart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dart);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerDart>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dart)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)playerDart));
		}
	}

	public unsafe bool isCreateDark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCreateDark);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCreateDark)) = flag;
		}
	}

	public unsafe SkillPaint skillPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillPaint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillPaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillPaint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillPaint));
		}
	}

	public unsafe SkillPaint skillPaintRandomPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillPaintRandomPaint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillPaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillPaintRandomPaint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillPaint));
		}
	}

	public unsafe Il2CppReferenceArray<EffectPaint> effPaints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effPaints);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EffectPaint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effPaints)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int sType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sType)) = num;
		}
	}

	public unsafe sbyte isInjure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInjure);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInjure)) = b;
		}
	}

	public unsafe bool isUseSkillAfterCharge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseSkillAfterCharge);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseSkillAfterCharge)) = flag;
		}
	}

	public unsafe bool isFlyAndCharge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFlyAndCharge);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFlyAndCharge)) = flag;
		}
	}

	public unsafe bool isStandAndCharge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStandAndCharge);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStandAndCharge)) = flag;
		}
	}

	public unsafe bool isFlying
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFlying);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFlying)) = flag;
		}
	}

	public unsafe int posDisY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posDisY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posDisY)) = num;
		}
	}

	public unsafe int chargeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chargeCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chargeCount)) = num;
		}
	}

	public unsafe bool hasSendAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSendAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasSendAttack)) = flag;
		}
	}

	public unsafe bool isMabuHold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMabuHold);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMabuHold)) = flag;
		}
	}

	public unsafe long timeBlue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeBlue);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeBlue)) = num;
		}
	}

	public unsafe int tBlue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tBlue);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tBlue)) = num;
		}
	}

	public unsafe bool IsAddDust1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAddDust1);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAddDust1)) = flag;
		}
	}

	public unsafe bool IsAddDust2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAddDust2);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAddDust2)) = flag;
		}
	}

	public unsafe int len
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_len);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_len)) = num;
		}
	}

	public unsafe int w_hp_bar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_hp_bar);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w_hp_bar)) = num;
		}
	}

	public unsafe int per
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_per);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_per)) = num;
		}
	}

	public unsafe int per_tem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_per_tem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_per_tem)) = num;
		}
	}

	public unsafe Image imgHPtem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgHPtem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgHPtem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe bool isPet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPet)) = flag;
		}
	}

	public unsafe bool isMiniPet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMiniPet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMiniPet)) = flag;
		}
	}

	public unsafe int xSd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xSd)) = num;
		}
	}

	public unsafe int ySd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ySd)) = num;
		}
	}

	public unsafe bool isOutMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutMap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOutMap)) = flag;
		}
	}

	public unsafe int fBag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fBag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fBag)) = num;
		}
	}

	public unsafe Part ph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ph);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Part>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ph)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)part));
		}
	}

	public unsafe Part pl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Part>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)part));
		}
	}

	public unsafe Part pb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pb);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Part>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pb)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)part));
		}
	}

	public unsafe int cH_new
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cH_new);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cH_new)) = num;
		}
	}

	public unsafe int statusBeforeNothing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusBeforeNothing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statusBeforeNothing)) = num;
		}
	}

	public unsafe int timeFocusToMob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeFocusToMob);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeFocusToMob)) = num;
		}
	}

	public unsafe static bool isManualFocus
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isManualFocus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isManualFocus, (void*)(&flag));
		}
	}

	public unsafe Char charHold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charHold);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charHold)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe Mob mobHold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobHold);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobHold)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mob));
		}
	}

	public unsafe int nInjure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nInjure);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nInjure)) = num;
		}
	}

	public unsafe short wdx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wdx);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wdx)) = num;
		}
	}

	public unsafe short wdy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wdy);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wdy)) = num;
		}
	}

	public unsafe bool isDirtyPostion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDirtyPostion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDirtyPostion)) = flag;
		}
	}

	public unsafe Skill lastNormalSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastNormalSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skill>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastNormalSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill));
		}
	}

	public unsafe bool currentFireByShortcut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFireByShortcut);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFireByShortcut)) = flag;
		}
	}

	public unsafe long cDamGoc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDamGoc);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDamGoc)) = num;
		}
	}

	public unsafe long cHPGoc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPGoc);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cHPGoc)) = num;
		}
	}

	public unsafe long cMPGoc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMPGoc);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMPGoc)) = num;
		}
	}

	public unsafe int cDefGoc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDefGoc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cDefGoc)) = num;
		}
	}

	public unsafe int cCriticalGoc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cCriticalGoc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cCriticalGoc)) = num;
		}
	}

	public unsafe sbyte hpFrom1000TiemNang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hpFrom1000TiemNang);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hpFrom1000TiemNang)) = b;
		}
	}

	public unsafe sbyte mpFrom1000TiemNang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpFrom1000TiemNang);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpFrom1000TiemNang)) = b;
		}
	}

	public unsafe sbyte damFrom1000TiemNang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damFrom1000TiemNang);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damFrom1000TiemNang)) = b;
		}
	}

	public unsafe sbyte defFrom1000TiemNang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defFrom1000TiemNang);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defFrom1000TiemNang)) = b;
		}
	}

	public unsafe sbyte criticalFrom1000Tiemnang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_criticalFrom1000Tiemnang);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_criticalFrom1000Tiemnang)) = b;
		}
	}

	public unsafe short cMaxStamina
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMaxStamina);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cMaxStamina)) = num;
		}
	}

	public unsafe short expForOneAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expForOneAdd);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_expForOneAdd)) = num;
		}
	}

	public unsafe sbyte isMonkey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMonkey);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMonkey)) = b;
		}
	}

	public unsafe bool isCopy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCopy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCopy)) = flag;
		}
	}

	public unsafe bool isWaitMonkey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWaitMonkey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWaitMonkey)) = flag;
		}
	}

	public unsafe bool isFeetEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFeetEff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFeetEff)) = flag;
		}
	}

	public unsafe bool meDead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meDead);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meDead)) = flag;
		}
	}

	public unsafe int holdEffID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdEffID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdEffID)) = num;
		}
	}

	public unsafe bool holder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holder)) = flag;
		}
	}

	public unsafe bool protectEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protectEff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_protectEff)) = flag;
		}
	}

	public unsafe bool isSetPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSetPos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSetPos)) = flag;
		}
	}

	public unsafe int tpos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tpos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tpos)) = num;
		}
	}

	public unsafe short xPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xPos);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xPos)) = num;
		}
	}

	public unsafe short yPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPos);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPos)) = num;
		}
	}

	public unsafe sbyte typePos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typePos);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typePos)) = b;
		}
	}

	public unsafe bool isMyFusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMyFusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMyFusion)) = flag;
		}
	}

	public unsafe bool isFusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFusion)) = flag;
		}
	}

	public unsafe int tFusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tFusion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tFusion)) = num;
		}
	}

	public unsafe bool huytSao
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_huytSao);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_huytSao)) = flag;
		}
	}

	public unsafe bool blindEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindEff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blindEff)) = flag;
		}
	}

	public unsafe bool telePortSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telePortSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_telePortSkill)) = flag;
		}
	}

	public unsafe bool sleepEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepEff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepEff)) = flag;
		}
	}

	public unsafe bool stone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stone)) = flag;
		}
	}

	public unsafe int perCentMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perCentMp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perCentMp)) = num;
		}
	}

	public unsafe long dHP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dHP);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dHP)) = num;
		}
	}

	public unsafe int headTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headTemp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headTemp)) = num;
		}
	}

	public unsafe int bodyTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyTemp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyTemp)) = num;
		}
	}

	public unsafe int legTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legTemp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_legTemp)) = num;
		}
	}

	public unsafe int bagTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bagTemp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bagTemp)) = num;
		}
	}

	public unsafe int wpTemp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wpTemp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wpTemp)) = num;
		}
	}

	public unsafe MyVector vEffChar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vEffChar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vEffChar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static FrameImage fraRedEye
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fraRedEye, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fraRedEye, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe int fChopmat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fChopmat);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fChopmat)) = num;
		}
	}

	public unsafe bool isAddChopMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAddChopMat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAddChopMat)) = flag;
		}
	}

	public unsafe long timeAddChopmat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAddChopmat);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAddChopmat)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> frChopNhanh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frChopNhanh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frChopNhanh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> frChopCham
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frChopCham);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frChopCham)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> frEye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frEye);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frEye)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> Arr_Head_2Fr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Arr_Head_2Fr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Arr_Head_2Fr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int fHead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fHead);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fHead)) = num;
		}
	}

	public unsafe string strEffAura
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strEffAura);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strEffAura)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe short idAuraEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idAuraEff);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idAuraEff)) = num;
		}
	}

	public unsafe static bool isPaintAura
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintAura, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintAura, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintAura2
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintAura2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintAura2, (void*)(&flag));
		}
	}

	public unsafe FrameImage fraEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraEff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraEff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe FrameImage fraEffSub
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraEffSub);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraEffSub)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe string strEff_Set_Item
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strEff_Set_Item);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strEff_Set_Item)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe short idEff_Set_Item
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idEff_Set_Item);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idEff_Set_Item)) = num;
		}
	}

	public unsafe FrameImage fraHat_behind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_behind);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_behind)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe FrameImage fraHat_font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_font);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_font)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe FrameImage fraHat_behind_2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_behind_2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_behind_2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe FrameImage fraHat_font_2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_font_2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraHat_font_2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe string strHat_behind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strHat_behind);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strHat_behind)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string strHat_font
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strHat_font);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strHat_font)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string strNgang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strNgang);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strNgang)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe short idHat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idHat);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idHat)) = num;
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> hatInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hatInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hatInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static byte TYPE_SKILL_KAMEX10
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SKILL_KAMEX10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SKILL_KAMEX10, (void*)(&b));
		}
	}

	public unsafe static byte TYPE_SKILL_FINAL
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SKILL_FINAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SKILL_FINAL, (void*)(&b));
		}
	}

	public unsafe static byte TYPE_SKILL_MAFUBA
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SKILL_MAFUBA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SKILL_MAFUBA, (void*)(&b));
		}
	}

	public unsafe static byte TYPE_SKILL_GENKI
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SKILL_GENKI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SKILL_GENKI, (void*)(&b));
		}
	}

	public unsafe bool isPaintNewSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintNewSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintNewSkill)) = flag;
		}
	}

	public unsafe bool isFly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFly)) = flag;
		}
	}

	public unsafe long timeReset_newSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeReset_newSkill);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeReset_newSkill)) = num;
		}
	}

	public unsafe sbyte typeFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeFrame);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeFrame)) = b;
		}
	}

	public unsafe short idskillPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idskillPaint);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idskillPaint)) = num;
		}
	}

	public unsafe Il2CppStructArray<byte> fr_start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr_start);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr_start)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<byte> fr_atk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr_atk);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr_atk)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<byte> fr_end
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr_end);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fr_end)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int count_NEW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count_NEW);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count_NEW)) = num;
		}
	}

	public unsafe int stt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stt)) = num;
		}
	}

	public unsafe short rangeDame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeDame);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeDame)) = num;
		}
	}

	public unsafe sbyte typePaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typePaint);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typePaint)) = b;
		}
	}

	public unsafe sbyte typeItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeItem);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeItem)) = b;
		}
	}

	public unsafe Point targetDame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point));
		}
	}

	public unsafe long timeDame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeDame);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeDame)) = num;
		}
	}

	public unsafe bool isMafuba
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMafuba);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMafuba)) = flag;
		}
	}

	public unsafe short countMafuba
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countMafuba);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countMafuba)) = num;
		}
	}

	public unsafe int xMFB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMFB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xMFB)) = num;
		}
	}

	public unsafe int yMFB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMFB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yMFB)) = num;
		}
	}

	public unsafe List<Il2CppStructArray<int>> danhhieu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_danhhieu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_danhhieu)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe Il2CppStructArray<int> arrHead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrHead);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrHead)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int idVongChan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idVongChan);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idVongChan)) = num;
		}
	}

	static Char()
	{
		Il2CppClassPointerStore<Char>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Char");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Char>.NativeClassPtr);
		NativeFieldInfoPtr_xuStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xuStr");
		NativeFieldInfoPtr_luongStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "luongStr");
		NativeFieldInfoPtr_luongKhoaStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "luongKhoaStr");
		NativeFieldInfoPtr_lastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "lastUpdateTime");
		NativeFieldInfoPtr_meLive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "meLive");
		NativeFieldInfoPtr_isMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMask");
		NativeFieldInfoPtr_isTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isTeleport");
		NativeFieldInfoPtr_isUsePlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isUsePlane");
		NativeFieldInfoPtr_shadowX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "shadowX");
		NativeFieldInfoPtr_shadowY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "shadowY");
		NativeFieldInfoPtr_shadowLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "shadowLife");
		NativeFieldInfoPtr_isNhapThe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isNhapThe");
		NativeFieldInfoPtr_petFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "petFollow");
		NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "rank");
		NativeFieldInfoPtr_A_STAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_STAND");
		NativeFieldInfoPtr_A_RUN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_RUN");
		NativeFieldInfoPtr_A_JUMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_JUMP");
		NativeFieldInfoPtr_A_FALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_FALL");
		NativeFieldInfoPtr_A_DEADFLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_DEADFLY");
		NativeFieldInfoPtr_A_NOTHING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_NOTHING");
		NativeFieldInfoPtr_A_ATTK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_ATTK");
		NativeFieldInfoPtr_A_INJURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_INJURE");
		NativeFieldInfoPtr_A_AUTOJUMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_AUTOJUMP");
		NativeFieldInfoPtr_A_FLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_FLY");
		NativeFieldInfoPtr_SKILL_STAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "SKILL_STAND");
		NativeFieldInfoPtr_SKILL_FALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "SKILL_FALL");
		NativeFieldInfoPtr_A_DEAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_DEAD");
		NativeFieldInfoPtr_A_HIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_HIDE");
		NativeFieldInfoPtr_A_RESETPOINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "A_RESETPOINT");
		NativeFieldInfoPtr_chatPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "chatPopup");
		NativeFieldInfoPtr_cPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cPower");
		NativeFieldInfoPtr_chatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "chatInfo");
		NativeFieldInfoPtr_petStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "petStatus");
		NativeFieldInfoPtr_cx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cx");
		NativeFieldInfoPtr_cy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cy");
		NativeFieldInfoPtr_cvx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cvx");
		NativeFieldInfoPtr_cvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cvy");
		NativeFieldInfoPtr_cp1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cp1");
		NativeFieldInfoPtr_cp2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cp2");
		NativeFieldInfoPtr_cp3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cp3");
		NativeFieldInfoPtr_statusMe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "statusMe");
		NativeFieldInfoPtr_cdir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cdir");
		NativeFieldInfoPtr_charID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "charID");
		NativeFieldInfoPtr_cgender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cgender");
		NativeFieldInfoPtr_ctaskId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ctaskId");
		NativeFieldInfoPtr_menuSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "menuSelect");
		NativeFieldInfoPtr_cBonusSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cBonusSpeed");
		NativeFieldInfoPtr_cspeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cspeed");
		NativeFieldInfoPtr_ccurrentAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ccurrentAttack");
		NativeFieldInfoPtr_cDamFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cDamFull");
		NativeFieldInfoPtr_cDefull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cDefull");
		NativeFieldInfoPtr_cCriticalFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cCriticalFull");
		NativeFieldInfoPtr_clevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "clevel");
		NativeFieldInfoPtr_cMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cMP");
		NativeFieldInfoPtr_cHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cHP");
		NativeFieldInfoPtr_cHPNew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cHPNew");
		NativeFieldInfoPtr_cMaxEXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cMaxEXP");
		NativeFieldInfoPtr_cHPShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cHPShow");
		NativeFieldInfoPtr_xReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xReload");
		NativeFieldInfoPtr_yReload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "yReload");
		NativeFieldInfoPtr_cyStartFall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cyStartFall");
		NativeFieldInfoPtr_saveStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "saveStatus");
		NativeFieldInfoPtr_eff5BuffHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eff5BuffHp");
		NativeFieldInfoPtr_eff5BuffMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eff5BuffMp");
		NativeFieldInfoPtr_cHPFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cHPFull");
		NativeFieldInfoPtr_cMPFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cMPFull");
		NativeFieldInfoPtr_cdameDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cdameDown");
		NativeFieldInfoPtr_cStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cStr");
		NativeFieldInfoPtr_cLevelPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cLevelPercent");
		NativeFieldInfoPtr_cTiemNang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cTiemNang");
		NativeFieldInfoPtr_cNangdong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cNangdong");
		NativeFieldInfoPtr_damHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "damHP");
		NativeFieldInfoPtr_damMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "damMP");
		NativeFieldInfoPtr_isMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMob");
		NativeFieldInfoPtr_isCrit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isCrit");
		NativeFieldInfoPtr_isDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isDie");
		NativeFieldInfoPtr_pointUydanh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointUydanh");
		NativeFieldInfoPtr_pointNon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointNon");
		NativeFieldInfoPtr_pointVukhi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointVukhi");
		NativeFieldInfoPtr_pointAo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointAo");
		NativeFieldInfoPtr_pointLien = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointLien");
		NativeFieldInfoPtr_pointGangtay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointGangtay");
		NativeFieldInfoPtr_pointNhan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointNhan");
		NativeFieldInfoPtr_pointQuan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointQuan");
		NativeFieldInfoPtr_pointNgocboi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointNgocboi");
		NativeFieldInfoPtr_pointGiay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointGiay");
		NativeFieldInfoPtr_pointPhu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pointPhu");
		NativeFieldInfoPtr_countFinishDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "countFinishDay");
		NativeFieldInfoPtr_countLoopBoos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "countLoopBoos");
		NativeFieldInfoPtr_limitTiemnangso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "limitTiemnangso");
		NativeFieldInfoPtr_limitKynangso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "limitKynangso");
		NativeFieldInfoPtr_potential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "potential");
		NativeFieldInfoPtr_cName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cName");
		NativeFieldInfoPtr_clanID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "clanID");
		NativeFieldInfoPtr_ctypeClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ctypeClan");
		NativeFieldInfoPtr_clan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "clan");
		NativeFieldInfoPtr_role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "role");
		NativeFieldInfoPtr_cw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cw");
		NativeFieldInfoPtr_ch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ch");
		NativeFieldInfoPtr_chw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "chw");
		NativeFieldInfoPtr_chh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "chh");
		NativeFieldInfoPtr_cmdMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cmdMenu");
		NativeFieldInfoPtr_canFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "canFly");
		NativeFieldInfoPtr_cmtoChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cmtoChar");
		NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "me");
		NativeFieldInfoPtr_cFinishedAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cFinishedAttack");
		NativeFieldInfoPtr_cchistlast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cchistlast");
		NativeFieldInfoPtr_isAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isAttack");
		NativeFieldInfoPtr_isAttFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isAttFly");
		NativeFieldInfoPtr_cwpt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cwpt");
		NativeFieldInfoPtr_cwplv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cwplv");
		NativeFieldInfoPtr_cf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cf");
		NativeFieldInfoPtr_tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "tick");
		NativeFieldInfoPtr_fallAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fallAttack");
		NativeFieldInfoPtr_isJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isJump");
		NativeFieldInfoPtr_autoFall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "autoFall");
		NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "attack");
		NativeFieldInfoPtr_xu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xu");
		NativeFieldInfoPtr_xuInBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xuInBox");
		NativeFieldInfoPtr_yen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "yen");
		NativeFieldInfoPtr_gold_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "gold_lock");
		NativeFieldInfoPtr_luong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "luong");
		NativeFieldInfoPtr_luongKhoa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "luongKhoa");
		NativeFieldInfoPtr_nClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "nClass");
		NativeFieldInfoPtr_endMovePointCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "endMovePointCommand");
		NativeFieldInfoPtr_vSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "vSkill");
		NativeFieldInfoPtr_vSkillFight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "vSkillFight");
		NativeFieldInfoPtr_vEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "vEff");
		NativeFieldInfoPtr_myskill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "myskill");
		NativeFieldInfoPtr_taskMaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "taskMaint");
		NativeFieldInfoPtr_paintName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "paintName");
		NativeFieldInfoPtr_arrArchive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arrArchive");
		NativeFieldInfoPtr_arrItemBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arrItemBag");
		NativeFieldInfoPtr_arrItemBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arrItemBox");
		NativeFieldInfoPtr_arrItemBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arrItemBody");
		NativeFieldInfoPtr_arrPetSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arrPetSkill");
		NativeFieldInfoPtr_arrItemShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arrItemShop");
		NativeFieldInfoPtr_infoSpeacialSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "infoSpeacialSkill");
		NativeFieldInfoPtr_imgSpeacialSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgSpeacialSkill");
		NativeFieldInfoPtr_cResFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cResFire");
		NativeFieldInfoPtr_cResIce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cResIce");
		NativeFieldInfoPtr_cResWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cResWind");
		NativeFieldInfoPtr_cMiss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cMiss");
		NativeFieldInfoPtr_cExactly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cExactly");
		NativeFieldInfoPtr_cFatal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cFatal");
		NativeFieldInfoPtr_cPk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cPk");
		NativeFieldInfoPtr_cTypePk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cTypePk");
		NativeFieldInfoPtr_cReactDame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cReactDame");
		NativeFieldInfoPtr_sysUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "sysUp");
		NativeFieldInfoPtr_sysDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "sysDown");
		NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "avatar");
		NativeFieldInfoPtr_skillTemplateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "skillTemplateId");
		NativeFieldInfoPtr_mobFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "mobFocus");
		NativeFieldInfoPtr_mobMe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "mobMe");
		NativeFieldInfoPtr_tMobMeBorn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "tMobMeBorn");
		NativeFieldInfoPtr_npcFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "npcFocus");
		NativeFieldInfoPtr_charFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "charFocus");
		NativeFieldInfoPtr_itemFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "itemFocus");
		NativeFieldInfoPtr_focus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "focus");
		NativeFieldInfoPtr_attMobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "attMobs");
		NativeFieldInfoPtr_attChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "attChars");
		NativeFieldInfoPtr_moveFast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "moveFast");
		NativeFieldInfoPtr_testCharId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "testCharId");
		NativeFieldInfoPtr_killCharId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "killCharId");
		NativeFieldInfoPtr_resultTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "resultTest");
		NativeFieldInfoPtr_countKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "countKill");
		NativeFieldInfoPtr_countKillMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "countKillMax");
		NativeFieldInfoPtr_isInvisiblez = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isInvisiblez");
		NativeFieldInfoPtr_isShadown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isShadown");
		NativeFieldInfoPtr_PK_NORMAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "PK_NORMAL");
		NativeFieldInfoPtr_PK_PHE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "PK_PHE");
		NativeFieldInfoPtr_PK_BANG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "PK_BANG");
		NativeFieldInfoPtr_PK_THIDAU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "PK_THIDAU");
		NativeFieldInfoPtr_PK_LUYENTAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "PK_LUYENTAP");
		NativeFieldInfoPtr_PK_TUDO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "PK_TUDO");
		NativeFieldInfoPtr_taskOrders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "taskOrders");
		NativeFieldInfoPtr_cStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cStamina");
		NativeFieldInfoPtr_idHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idHead");
		NativeFieldInfoPtr_idAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idAvatar");
		NativeFieldInfoPtr_exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "exp");
		NativeFieldInfoPtr_strLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strLevel");
		NativeFieldInfoPtr_currStrLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "currStrLevel");
		NativeFieldInfoPtr_eyeTraiDat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eyeTraiDat");
		NativeFieldInfoPtr_eyeNamek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eyeNamek");
		NativeFieldInfoPtr_isFreez = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isFreez");
		NativeFieldInfoPtr_isCharge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isCharge");
		NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "seconds");
		NativeFieldInfoPtr_freezSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "freezSeconds");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "last");
		NativeFieldInfoPtr_cur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cur");
		NativeFieldInfoPtr_lastFreez = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "lastFreez");
		NativeFieldInfoPtr_currFreez = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "currFreez");
		NativeFieldInfoPtr_isFlyUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isFlyUp");
		NativeFieldInfoPtr_vItemTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "vItemTime");
		NativeFieldInfoPtr_ID_NEW_MOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ID_NEW_MOUNT");
		NativeFieldInfoPtr_idMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idMount");
		NativeFieldInfoPtr_isHaveMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isHaveMount");
		NativeFieldInfoPtr_isMountVip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMountVip");
		NativeFieldInfoPtr_isEventMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isEventMount");
		NativeFieldInfoPtr_isSpeacialMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isSpeacialMount");
		NativeFieldInfoPtr_imgMount_TD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_TD");
		NativeFieldInfoPtr_imgMount_NM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_NM");
		NativeFieldInfoPtr_imgMount_NM_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_NM_1");
		NativeFieldInfoPtr_imgMount_XD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_XD");
		NativeFieldInfoPtr_imgMount_TD_VIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_TD_VIP");
		NativeFieldInfoPtr_imgMount_NM_VIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_NM_VIP");
		NativeFieldInfoPtr_imgMount_NM_1_VIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_NM_1_VIP");
		NativeFieldInfoPtr_imgMount_XD_VIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgMount_XD_VIP");
		NativeFieldInfoPtr_imgEventMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgEventMount");
		NativeFieldInfoPtr_imgEventMountWing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgEventMountWing");
		NativeFieldInfoPtr_FrameMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "FrameMount");
		NativeFieldInfoPtr_frameMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "frameMount");
		NativeFieldInfoPtr_frameNewMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "frameNewMount");
		NativeFieldInfoPtr_transMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "transMount");
		NativeFieldInfoPtr_genderMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "genderMount");
		NativeFieldInfoPtr_idcharMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idcharMount");
		NativeFieldInfoPtr_xMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xMount");
		NativeFieldInfoPtr_yMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "yMount");
		NativeFieldInfoPtr_dxMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dxMount");
		NativeFieldInfoPtr_dyMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dyMount");
		NativeFieldInfoPtr_xChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xChar");
		NativeFieldInfoPtr_xdis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xdis");
		NativeFieldInfoPtr_speedMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "speedMount");
		NativeFieldInfoPtr_isStartMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isStartMount");
		NativeFieldInfoPtr_isMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMount");
		NativeFieldInfoPtr_isEndMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isEndMount");
		NativeFieldInfoPtr_cFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cFlag");
		NativeFieldInfoPtr_flagImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "flagImage");
		NativeFieldInfoPtr_x_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "x_hint");
		NativeFieldInfoPtr_y_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "y_hint");
		NativeFieldInfoPtr_CharInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "CharInfo");
		NativeFieldInfoPtr_CHAR_WEAPONX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "CHAR_WEAPONX");
		NativeFieldInfoPtr_CHAR_WEAPONY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "CHAR_WEAPONY");
		NativeFieldInfoPtr_myChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "myChar");
		NativeFieldInfoPtr_myPet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "myPet");
		NativeFieldInfoPtr_listAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "listAttack");
		NativeFieldInfoPtr_listIonC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "listIonC");
		NativeFieldInfoPtr_cvyJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cvyJump");
		NativeFieldInfoPtr_indexUseSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "indexUseSkill");
		NativeFieldInfoPtr_cxSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cxSend");
		NativeFieldInfoPtr_cySend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cySend");
		NativeFieldInfoPtr_cdirSend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cdirSend");
		NativeFieldInfoPtr_cxFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cxFocus");
		NativeFieldInfoPtr_cyFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cyFocus");
		NativeFieldInfoPtr_cactFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cactFirst");
		NativeFieldInfoPtr_vMovePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "vMovePoints");
		NativeFieldInfoPtr_inforClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "inforClass");
		NativeFieldInfoPtr_inforSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "inforSkill");
		NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "flag");
		NativeFieldInfoPtr_ischangingMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ischangingMap");
		NativeFieldInfoPtr_isLockKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isLockKey");
		NativeFieldInfoPtr_isLoadingMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isLoadingMap");
		NativeFieldInfoPtr_isLockMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isLockMove");
		NativeFieldInfoPtr_isLockAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isLockAttack");
		NativeFieldInfoPtr_strInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strInfo");
		NativeFieldInfoPtr_powerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "powerPoint");
		NativeFieldInfoPtr_maxPowerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "maxPowerPoint");
		NativeFieldInfoPtr_secondPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "secondPower");
		NativeFieldInfoPtr_lastS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "lastS");
		NativeFieldInfoPtr_currS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "currS");
		NativeFieldInfoPtr_havePet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "havePet");
		NativeFieldInfoPtr_currentMovePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "currentMovePoint");
		NativeFieldInfoPtr_bom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "bom");
		NativeFieldInfoPtr_delayFall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "delayFall");
		NativeFieldInfoPtr_isSoundJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isSoundJump");
		NativeFieldInfoPtr_lastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "lastFrame");
		NativeFieldInfoPtr_eProtect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eProtect");
		NativeFieldInfoPtr_twHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "twHp");
		NativeFieldInfoPtr_isInjureHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isInjureHp");
		NativeFieldInfoPtr_changePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "changePos");
		NativeFieldInfoPtr_isHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isHide");
		NativeFieldInfoPtr_wy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "wy");
		NativeFieldInfoPtr_wt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "wt");
		NativeFieldInfoPtr_fy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fy");
		NativeFieldInfoPtr_ty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ty");
		NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "t");
		NativeFieldInfoPtr_fM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fM");
		NativeFieldInfoPtr_move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "move");
		NativeFieldInfoPtr_strMount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strMount");
		NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "head");
		NativeFieldInfoPtr_leg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "leg");
		NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "body");
		NativeFieldInfoPtr_bag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "bag");
		NativeFieldInfoPtr_wp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "wp");
		NativeFieldInfoPtr_indexEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "indexEff");
		NativeFieldInfoPtr_indexEffTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "indexEffTask");
		NativeFieldInfoPtr_eff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eff");
		NativeFieldInfoPtr_effTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "effTask");
		NativeFieldInfoPtr_indexSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "indexSkill");
		NativeFieldInfoPtr_i0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "i0");
		NativeFieldInfoPtr_i1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "i1");
		NativeFieldInfoPtr_i2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "i2");
		NativeFieldInfoPtr_dx0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dx0");
		NativeFieldInfoPtr_dx1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dx1");
		NativeFieldInfoPtr_dx2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dx2");
		NativeFieldInfoPtr_dy0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dy0");
		NativeFieldInfoPtr_dy1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dy1");
		NativeFieldInfoPtr_dy2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dy2");
		NativeFieldInfoPtr_eff0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eff0");
		NativeFieldInfoPtr_eff1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eff1");
		NativeFieldInfoPtr_eff2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "eff2");
		NativeFieldInfoPtr_arr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arr");
		NativeFieldInfoPtr_dart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dart");
		NativeFieldInfoPtr_isCreateDark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isCreateDark");
		NativeFieldInfoPtr_skillPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "skillPaint");
		NativeFieldInfoPtr_skillPaintRandomPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "skillPaintRandomPaint");
		NativeFieldInfoPtr_effPaints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "effPaints");
		NativeFieldInfoPtr_sType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "sType");
		NativeFieldInfoPtr_isInjure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isInjure");
		NativeFieldInfoPtr_isUseSkillAfterCharge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isUseSkillAfterCharge");
		NativeFieldInfoPtr_isFlyAndCharge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isFlyAndCharge");
		NativeFieldInfoPtr_isStandAndCharge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isStandAndCharge");
		NativeFieldInfoPtr_isFlying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isFlying");
		NativeFieldInfoPtr_posDisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "posDisY");
		NativeFieldInfoPtr_chargeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "chargeCount");
		NativeFieldInfoPtr_hasSendAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "hasSendAttack");
		NativeFieldInfoPtr_isMabuHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMabuHold");
		NativeFieldInfoPtr_timeBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "timeBlue");
		NativeFieldInfoPtr_tBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "tBlue");
		NativeFieldInfoPtr_IsAddDust1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "IsAddDust1");
		NativeFieldInfoPtr_IsAddDust2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "IsAddDust2");
		NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "len");
		NativeFieldInfoPtr_w_hp_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "w_hp_bar");
		NativeFieldInfoPtr_per = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "per");
		NativeFieldInfoPtr_per_tem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "per_tem");
		NativeFieldInfoPtr_imgHPtem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "imgHPtem");
		NativeFieldInfoPtr_isPet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isPet");
		NativeFieldInfoPtr_isMiniPet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMiniPet");
		NativeFieldInfoPtr_xSd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xSd");
		NativeFieldInfoPtr_ySd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ySd");
		NativeFieldInfoPtr_isOutMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isOutMap");
		NativeFieldInfoPtr_fBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fBag");
		NativeFieldInfoPtr_ph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "ph");
		NativeFieldInfoPtr_pl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pl");
		NativeFieldInfoPtr_pb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "pb");
		NativeFieldInfoPtr_cH_new = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cH_new");
		NativeFieldInfoPtr_statusBeforeNothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "statusBeforeNothing");
		NativeFieldInfoPtr_timeFocusToMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "timeFocusToMob");
		NativeFieldInfoPtr_isManualFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isManualFocus");
		NativeFieldInfoPtr_charHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "charHold");
		NativeFieldInfoPtr_mobHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "mobHold");
		NativeFieldInfoPtr_nInjure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "nInjure");
		NativeFieldInfoPtr_wdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "wdx");
		NativeFieldInfoPtr_wdy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "wdy");
		NativeFieldInfoPtr_isDirtyPostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isDirtyPostion");
		NativeFieldInfoPtr_lastNormalSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "lastNormalSkill");
		NativeFieldInfoPtr_currentFireByShortcut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "currentFireByShortcut");
		NativeFieldInfoPtr_cDamGoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cDamGoc");
		NativeFieldInfoPtr_cHPGoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cHPGoc");
		NativeFieldInfoPtr_cMPGoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cMPGoc");
		NativeFieldInfoPtr_cDefGoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cDefGoc");
		NativeFieldInfoPtr_cCriticalGoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cCriticalGoc");
		NativeFieldInfoPtr_hpFrom1000TiemNang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "hpFrom1000TiemNang");
		NativeFieldInfoPtr_mpFrom1000TiemNang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "mpFrom1000TiemNang");
		NativeFieldInfoPtr_damFrom1000TiemNang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "damFrom1000TiemNang");
		NativeFieldInfoPtr_defFrom1000TiemNang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "defFrom1000TiemNang");
		NativeFieldInfoPtr_criticalFrom1000Tiemnang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "criticalFrom1000Tiemnang");
		NativeFieldInfoPtr_cMaxStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "cMaxStamina");
		NativeFieldInfoPtr_expForOneAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "expForOneAdd");
		NativeFieldInfoPtr_isMonkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMonkey");
		NativeFieldInfoPtr_isCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isCopy");
		NativeFieldInfoPtr_isWaitMonkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isWaitMonkey");
		NativeFieldInfoPtr_isFeetEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isFeetEff");
		NativeFieldInfoPtr_meDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "meDead");
		NativeFieldInfoPtr_holdEffID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "holdEffID");
		NativeFieldInfoPtr_holder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "holder");
		NativeFieldInfoPtr_protectEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "protectEff");
		NativeFieldInfoPtr_isSetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isSetPos");
		NativeFieldInfoPtr_tpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "tpos");
		NativeFieldInfoPtr_xPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xPos");
		NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "yPos");
		NativeFieldInfoPtr_typePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "typePos");
		NativeFieldInfoPtr_isMyFusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMyFusion");
		NativeFieldInfoPtr_isFusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isFusion");
		NativeFieldInfoPtr_tFusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "tFusion");
		NativeFieldInfoPtr_huytSao = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "huytSao");
		NativeFieldInfoPtr_blindEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "blindEff");
		NativeFieldInfoPtr_telePortSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "telePortSkill");
		NativeFieldInfoPtr_sleepEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "sleepEff");
		NativeFieldInfoPtr_stone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "stone");
		NativeFieldInfoPtr_perCentMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "perCentMp");
		NativeFieldInfoPtr_dHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "dHP");
		NativeFieldInfoPtr_headTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "headTemp");
		NativeFieldInfoPtr_bodyTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "bodyTemp");
		NativeFieldInfoPtr_legTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "legTemp");
		NativeFieldInfoPtr_bagTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "bagTemp");
		NativeFieldInfoPtr_wpTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "wpTemp");
		NativeFieldInfoPtr_vEffChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "vEffChar");
		NativeFieldInfoPtr_fraRedEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fraRedEye");
		NativeFieldInfoPtr_fChopmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fChopmat");
		NativeFieldInfoPtr_isAddChopMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isAddChopMat");
		NativeFieldInfoPtr_timeAddChopmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "timeAddChopmat");
		NativeFieldInfoPtr_frChopNhanh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "frChopNhanh");
		NativeFieldInfoPtr_frChopCham = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "frChopCham");
		NativeFieldInfoPtr_frEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "frEye");
		NativeFieldInfoPtr_Arr_Head_2Fr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "Arr_Head_2Fr");
		NativeFieldInfoPtr_fHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fHead");
		NativeFieldInfoPtr_strEffAura = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strEffAura");
		NativeFieldInfoPtr_idAuraEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idAuraEff");
		NativeFieldInfoPtr_isPaintAura = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isPaintAura");
		NativeFieldInfoPtr_isPaintAura2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isPaintAura2");
		NativeFieldInfoPtr_fraEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fraEff");
		NativeFieldInfoPtr_fraEffSub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fraEffSub");
		NativeFieldInfoPtr_strEff_Set_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strEff_Set_Item");
		NativeFieldInfoPtr_idEff_Set_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idEff_Set_Item");
		NativeFieldInfoPtr_fraHat_behind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fraHat_behind");
		NativeFieldInfoPtr_fraHat_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fraHat_font");
		NativeFieldInfoPtr_fraHat_behind_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fraHat_behind_2");
		NativeFieldInfoPtr_fraHat_font_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fraHat_font_2");
		NativeFieldInfoPtr_strHat_behind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strHat_behind");
		NativeFieldInfoPtr_strHat_font = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strHat_font");
		NativeFieldInfoPtr_strNgang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "strNgang");
		NativeFieldInfoPtr_idHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idHat");
		NativeFieldInfoPtr_hatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "hatInfo");
		NativeFieldInfoPtr_TYPE_SKILL_KAMEX10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "TYPE_SKILL_KAMEX10");
		NativeFieldInfoPtr_TYPE_SKILL_FINAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "TYPE_SKILL_FINAL");
		NativeFieldInfoPtr_TYPE_SKILL_MAFUBA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "TYPE_SKILL_MAFUBA");
		NativeFieldInfoPtr_TYPE_SKILL_GENKI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "TYPE_SKILL_GENKI");
		NativeFieldInfoPtr_isPaintNewSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isPaintNewSkill");
		NativeFieldInfoPtr_isFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isFly");
		NativeFieldInfoPtr_timeReset_newSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "timeReset_newSkill");
		NativeFieldInfoPtr_typeFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "typeFrame");
		NativeFieldInfoPtr_idskillPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idskillPaint");
		NativeFieldInfoPtr_fr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fr_start");
		NativeFieldInfoPtr_fr_atk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fr_atk");
		NativeFieldInfoPtr_fr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "fr_end");
		NativeFieldInfoPtr_count_NEW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "count_NEW");
		NativeFieldInfoPtr_stt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "stt");
		NativeFieldInfoPtr_rangeDame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "rangeDame");
		NativeFieldInfoPtr_typePaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "typePaint");
		NativeFieldInfoPtr_typeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "typeItem");
		NativeFieldInfoPtr_targetDame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "targetDame");
		NativeFieldInfoPtr_timeDame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "timeDame");
		NativeFieldInfoPtr_isMafuba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "isMafuba");
		NativeFieldInfoPtr_countMafuba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "countMafuba");
		NativeFieldInfoPtr_xMFB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "xMFB");
		NativeFieldInfoPtr_yMFB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "yMFB");
		NativeFieldInfoPtr_danhhieu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "danhhieu");
		NativeFieldInfoPtr_arrHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "arrHead");
		NativeFieldInfoPtr_idVongChan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Char>.NativeClassPtr, "idVongChan");
		NativeMethodInfoPtr_subcName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_applyCharLevelPercent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_getdxSkill_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_getdySkill_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_taskAction_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_getStrLevel_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_avatarz_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_getAvatar_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_setPowerInfo_Public_Void_String_Int16_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_addInfo_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_getSys_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_myCharz_Public_Static_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_myPetz_Public_Static_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_clearMyChar_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_bagSort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_boxSort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_useItem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_getSkill_Public_Skill_SkillTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_isInEnterOfflinePoint_Public_Waypoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_isInEnterOnlinePoint_Public_Waypoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_isInWaypoint_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_isPunchKickSkill_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_soundUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_updateChargeSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_isWaiting_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_updateEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_checkPerformEndMovePointAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_checkHideCharName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_updateMobMe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_updateSkillPaint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr_saveLoadPreviousSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663529);
		NativeMethodInfoPtr_setResetPoint_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_updateCharDeadFly_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_updateResetPoint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_updateSkillFall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_updateSkillStand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_updateCharAutoJump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_getVx_Public_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_getVy_Public_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_returnAct_Public_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_setAutoJump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_updateCharStand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_updateSuperEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_getSoundVolumn_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_updateCharRun_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_updateCharJump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_checkInRangeJump_Public_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_setCharFallFromJump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_updateCharFall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_updateCharFly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_setMount_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_updateMount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_getMountData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_checkFrameTick_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_paintMount1_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_paintMount2_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_setMountIsStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_setMountIsEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_checkHaveMount_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_checkDelayFallIfTooHigh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_setDefaultPart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_setDefaultWeapon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_setDefaultBody_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_setDefaultLeg_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_isSelectingSkillUseAlone_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_isUseSkillSpec_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_isSelectingSkillBuffToPlayer_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_isUseChargeSkill_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_setSkillPaint_Public_Void_SkillPaint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_useSkillNotFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_sendUseChargeSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_stopUseChargeSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr_useChargeSkill_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_setAutoSkillPaint_Public_Void_SkillPaint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_skillInfoPaint_Public_Il2CppReferenceArray_1_SkillInfoPaint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_setAttack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_isOutX_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_isPaint_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_createShadow_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_setMabuHold_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_paintDanhHieu_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_paint_Public_Virtual_New_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_paint_map_line_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_paintEff_Pet_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_paintSuperEffBehind_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_paintSuperEffFront_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_paintEffect_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_paintArrowAttack_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_paintHp_Public_Void_mGraphics_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_getClassColor_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_paintNameInSameParty_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_paintCharName_HP_MP_Overhead_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_paintShadow_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_updateShadown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_paintCharWithoutSkill_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_paintBag_Public_Void_mGraphics_Il2CppStructArray_1_Int16_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_isCharBodyImageID_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_paintHead_Public_Void_mGraphics_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_paintHeadWithXY_Public_Void_mGraphics_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_paintCharBody_Public_Void_mGraphics_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_paintCharWithSkill_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_getIndexChar_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_moveTo_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_getcharInjure_Public_Static_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_isMagicTree_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_searchItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_searchFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_clearFocus_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_isCharInScreen_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_isAttacPlayerStatus_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_setHoldChar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_setHoldMob_Public_Void_Mob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_findNextFocusByKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_deFocusNPC_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr_updateCharInBridge_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_sort_Public_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_setInsc_Public_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_kickOption_Public_Void_Item_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_doInjure_Public_Void_Int64_Int64_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_doInjure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_startDie_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_waitToDie_Public_Void_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_liveFromDead_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_isHavePean_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_doUsePotion_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_isLang_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_isMeCanAttackOtherPlayer_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_clearTask_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_getX_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_getY_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_getH_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_getW_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_focusManualTo_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_stopMoving_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_cancelAttack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_isInvisible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_focusToAttack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_addDustEff_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_isGetFlagImage_Public_Boolean_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_paintPKFlag_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_removeHoleEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_removeProtectEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_removeBlindEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_removeEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_setPos_Public_Void_Int16_Int16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_removeHuytSao_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_fusionComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_setFusion_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_removeSleepEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_setPartOld_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_setPartTemp_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_resetPartTemp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_getEffById_Public_Effect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_addEffChar_Public_Void_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_removeEffChar_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_paintEffBehind_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_paintEffFront_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_updEffChar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_checkLuong_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_updateEye_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_paintRedEye_Private_Void_mGraphics_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_isHead_2Fr_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_updateFHead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_getFHead_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_paintAuraBehind_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_paintAuraFront_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_paintEff_Lvup_behind_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663669);
		NativeMethodInfoPtr_paintEff_Lvup_front_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663670);
		NativeMethodInfoPtr_paintHat_behind_Public_Void_mGraphics_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_paintHat_front_Public_Void_mGraphics_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_isFrNgang_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_sendNewAttack_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_SetSkillPaint_NEW_Public_Void_Int16_Boolean_SByte_SByte_SByte_Int16_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_SetSkillPaint_STT_Public_Void_Int32_Int16_Point_Int16_Int16_SByte_Il2CppReferenceArray_1_Point_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_UpdSkillPaint_NEW_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_GetGender_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr_updatePetPean_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663679);
		NativeMethodInfoPtr_isBuffPet_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663680);
		NativeMethodInfoPtr_getGender_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Char>.NativeClassPtr, 100663681);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8290, RefRangeEnd = 8292, XrefRangeStart = 8284, XrefRangeEnd = 8290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string subcName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_subcName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 8397, RefRangeEnd = 8411, XrefRangeStart = 8292, XrefRangeEnd = 8397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Char()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Char>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8427, RefRangeEnd = 8430, XrefRangeStart = 8411, XrefRangeEnd = 8427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyCharLevelPercent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyCharLevelPercent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getdxSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getdxSkill_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int getdySkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getdySkill_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8564, RefRangeEnd = 8566, XrefRangeStart = 8430, XrefRangeEnd = 8564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void taskAction(bool isNextStep)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isNextStep);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_taskAction_Public_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8586, RefRangeEnd = 8587, XrefRangeStart = 8566, XrefRangeEnd = 8586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getStrLevel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getStrLevel_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 8596, RefRangeEnd = 8603, XrefRangeStart = 8587, XrefRangeEnd = 8596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int avatarz()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_avatarz_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8603, XrefRangeEnd = 8612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getAvatar(int headId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&headId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getAvatar_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8617, RefRangeEnd = 8618, XrefRangeStart = 8612, XrefRangeEnd = 8617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPowerInfo(string info, short p, short maxP, short sc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxP;
		*(short**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sc;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPowerInfo_Public_Void_String_Int16_Int16_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 8624, RefRangeEnd = 8627, XrefRangeStart = 8618, XrefRangeEnd = 8624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addInfo(string info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addInfo_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getSys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSys_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2234)]
	[CachedScanResults(RefRangeStart = 8643, RefRangeEnd = 10877, XrefRangeStart = 8627, XrefRangeEnd = 8643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Char myCharz()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_myCharz_Public_Static_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 10892, RefRangeEnd = 10968, XrefRangeStart = 10877, XrefRangeEnd = 10892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Char myPetz()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_myPetz_Public_Static_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 10974, RefRangeEnd = 10975, XrefRangeStart = 10968, XrefRangeEnd = 10974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearMyChar()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearMyChar_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10975, XrefRangeEnd = 11000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void bagSort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bagSort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11025, RefRangeEnd = 11026, XrefRangeStart = 11000, XrefRangeEnd = 11025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void boxSort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_boxSort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11026, XrefRangeEnd = 11036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void useItem(int indexUI)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&indexUI);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_useItem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 11043, RefRangeEnd = 11051, XrefRangeStart = 11036, XrefRangeEnd = 11043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Skill getSkill(SkillTemplate skillTemplate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillTemplate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSkill_Public_Skill_SkillTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skill>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11076, RefRangeEnd = 11079, XrefRangeStart = 11051, XrefRangeEnd = 11076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Waypoint isInEnterOfflinePoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInEnterOfflinePoint_Public_Waypoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Waypoint>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11104, RefRangeEnd = 11107, XrefRangeStart = 11079, XrefRangeEnd = 11104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Waypoint isInEnterOnlinePoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInEnterOnlinePoint_Public_Waypoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Waypoint>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11115, RefRangeEnd = 11117, XrefRangeStart = 11107, XrefRangeEnd = 11115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isInWaypoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInWaypoint_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isPunchKickSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPunchKickSkill_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11145, RefRangeEnd = 11146, XrefRangeStart = 11117, XrefRangeEnd = 11145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void soundUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_soundUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateChargeSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateChargeSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 11146, RefRangeEnd = 11150, XrefRangeStart = 11146, XrefRangeEnd = 11146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isWaiting()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isWaiting_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11429, RefRangeEnd = 11431, XrefRangeStart = 11150, XrefRangeEnd = 11429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11460, RefRangeEnd = 11461, XrefRangeStart = 11431, XrefRangeEnd = 11460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11461, XrefRangeEnd = 11463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkPerformEndMovePointAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkPerformEndMovePointAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11504, RefRangeEnd = 11505, XrefRangeStart = 11463, XrefRangeEnd = 11504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkHideCharName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkHideCharName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void updateMobMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMobMe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11695, RefRangeEnd = 11696, XrefRangeStart = 11505, XrefRangeEnd = 11695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSkillPaint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSkillPaint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void saveLoadPreviousSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveLoadPreviousSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11703, RefRangeEnd = 11704, XrefRangeStart = 11696, XrefRangeEnd = 11703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setResetPoint(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setResetPoint_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11704, XrefRangeEnd = 11731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharDeadFly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharDeadFly_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11731, XrefRangeEnd = 11754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateResetPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateResetPoint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSkillFall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSkillFall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11754, XrefRangeEnd = 11786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSkillStand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSkillStand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11786, XrefRangeEnd = 11802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharAutoJump()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharAutoJump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11802, XrefRangeEnd = 11806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getVx(int size, int dx, int dy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&size);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getVx_Public_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11814, RefRangeEnd = 11815, XrefRangeStart = 11806, XrefRangeEnd = 11814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11823, RefRangeEnd = 11825, XrefRangeStart = 11815, XrefRangeEnd = 11823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getVy(int size, int dx, int dy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&size);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getVy_Public_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11825, XrefRangeEnd = 11836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int returnAct(int xFirst, int yFirst, int xEnd, int yEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&xFirst);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yFirst;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &xEnd;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &yEnd;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_returnAct_Public_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11836, XrefRangeEnd = 11839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setAutoJump()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAutoJump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11839, XrefRangeEnd = 11886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharStand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharStand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11893, RefRangeEnd = 11894, XrefRangeStart = 11886, XrefRangeEnd = 11893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSuperEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSuperEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 11902, RefRangeEnd = 11904, XrefRangeStart = 11894, XrefRangeEnd = 11902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float getSoundVolumn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSoundVolumn_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11904, XrefRangeEnd = 11984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharRun()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharRun_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(205)]
	[CachedScanResults(RefRangeStart = 11984, RefRangeEnd = 12189, XrefRangeStart = 11984, XrefRangeEnd = 11984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int abs(int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_abs_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12189, XrefRangeEnd = 12278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharJump()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharJump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool checkInRangeJump(int x1, int xw1, int xmob, int y1, int yh1, int ymob)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&x1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &xw1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &xmob;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &yh1;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ymob;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkInRangeJump_Public_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12303, RefRangeEnd = 12304, XrefRangeStart = 12278, XrefRangeEnd = 12303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCharFallFromJump()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCharFallFromJump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12304, XrefRangeEnd = 12325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharFall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharFall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12325, XrefRangeEnd = 12393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharFly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharFly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12393, XrefRangeEnd = 12405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setMount(int cid, int ctrans, int cgender)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cid);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ctrans;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cgender;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMount_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12405, XrefRangeEnd = 12407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateMount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12407, XrefRangeEnd = 12453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getMountData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMountData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void checkFrameTick(Il2CppStructArray<int> array)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkFrameTick_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12472, RefRangeEnd = 12473, XrefRangeStart = 12453, XrefRangeEnd = 12472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintMount1(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintMount1_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12497, RefRangeEnd = 12500, XrefRangeStart = 12473, XrefRangeEnd = 12497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintMount2(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintMount2_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12521, RefRangeEnd = 12523, XrefRangeStart = 12500, XrefRangeEnd = 12521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setMountIsStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMountIsStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setMountIsEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMountIsEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12535, RefRangeEnd = 12536, XrefRangeStart = 12523, XrefRangeEnd = 12535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkHaveMount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkHaveMount_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12536, XrefRangeEnd = 12543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkDelayFallIfTooHigh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkDelayFallIfTooHigh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12543, RefRangeEnd = 12546, XrefRangeStart = 12543, XrefRangeEnd = 12543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDefaultPart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDefaultPart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12546, RefRangeEnd = 12548, XrefRangeStart = 12546, XrefRangeEnd = 12546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDefaultWeapon()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDefaultWeapon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12548, RefRangeEnd = 12550, XrefRangeStart = 12548, XrefRangeEnd = 12548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDefaultBody()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDefaultBody_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12550, RefRangeEnd = 12552, XrefRangeStart = 12550, XrefRangeEnd = 12550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDefaultLeg()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDefaultLeg_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12552, RefRangeEnd = 12554, XrefRangeStart = 12552, XrefRangeEnd = 12552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isSelectingSkillUseAlone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isSelectingSkillUseAlone_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isUseSkillSpec()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isUseSkillSpec_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12554, RefRangeEnd = 12557, XrefRangeStart = 12554, XrefRangeEnd = 12554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isSelectingSkillBuffToPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isSelectingSkillBuffToPlayer_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12557, RefRangeEnd = 12559, XrefRangeStart = 12557, XrefRangeEnd = 12557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isUseChargeSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isUseChargeSkill_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 12647, RefRangeEnd = 12660, XrefRangeStart = 12559, XrefRangeEnd = 12647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setSkillPaint(SkillPaint skillPaint, int sType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillPaint);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSkillPaint_Public_Void_SkillPaint_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12679, RefRangeEnd = 12681, XrefRangeStart = 12660, XrefRangeEnd = 12679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void useSkillNotFocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_useSkillNotFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12686, RefRangeEnd = 12687, XrefRangeStart = 12681, XrefRangeEnd = 12686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendUseChargeSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendUseChargeSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 12691, RefRangeEnd = 12696, XrefRangeStart = 12687, XrefRangeEnd = 12691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void stopUseChargeSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopUseChargeSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12714, RefRangeEnd = 12717, XrefRangeStart = 12696, XrefRangeEnd = 12714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void useChargeSkill(bool isGround)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isGround);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_useChargeSkill_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 12740, RefRangeEnd = 12743, XrefRangeStart = 12717, XrefRangeEnd = 12740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setAutoSkillPaint(SkillPaint skillPaint, int sType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillPaint);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAutoSkillPaint_Public_Void_SkillPaint_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12759, XrefRangeStart = 12743, XrefRangeEnd = 12743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<SkillInfoPaint> skillInfoPaint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_skillInfoPaint_Public_Il2CppReferenceArray_1_SkillInfoPaint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkillInfoPaint>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12785, XrefRangeStart = 12759, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAttack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12791, RefRangeEnd = 12793, XrefRangeStart = 12785, XrefRangeEnd = 12791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isOutX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isOutX_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 12805, RefRangeEnd = 12810, XrefRangeStart = 12793, XrefRangeEnd = 12805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isPaint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPaint_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12810, RefRangeEnd = 12811, XrefRangeStart = 12810, XrefRangeEnd = 12810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createShadow(int x, int y, int life)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &life;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createShadow_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void setMabuHold(bool m)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMabuHold_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 12845, RefRangeEnd = 12846, XrefRangeStart = 12811, XrefRangeEnd = 12845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintDanhHieu(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintDanhHieu_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13004, RefRangeEnd = 13005, XrefRangeStart = 12846, XrefRangeEnd = 13004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_paint_Public_Virtual_New_Void_mGraphics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13026, RefRangeEnd = 13027, XrefRangeStart = 13005, XrefRangeEnd = 13026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint_map_line(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_map_line_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13027, XrefRangeEnd = 13033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintEff_Pet(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintEff_Pet_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13067, RefRangeEnd = 13068, XrefRangeStart = 13033, XrefRangeEnd = 13067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintSuperEffBehind(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintSuperEffBehind_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13083, RefRangeEnd = 13084, XrefRangeStart = 13068, XrefRangeEnd = 13083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintSuperEffFront(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintSuperEffFront_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13084, XrefRangeEnd = 13120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintEffect(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintEffect_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintArrowAttack(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintArrowAttack_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 13166, RefRangeEnd = 13169, XrefRangeStart = 13120, XrefRangeEnd = 13166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintHp(mGraphics g, int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintHp_Public_Void_mGraphics_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getClassColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getClassColor_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13169, XrefRangeEnd = 13195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintNameInSameParty(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintNameInSameParty_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13265, RefRangeEnd = 13266, XrefRangeStart = 13195, XrefRangeEnd = 13265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintCharName_HP_MP_Overhead(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCharName_HP_MP_Overhead_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 13304, RefRangeEnd = 13308, XrefRangeStart = 13266, XrefRangeEnd = 13304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintShadow(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintShadow_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13315, RefRangeEnd = 13317, XrefRangeStart = 13308, XrefRangeEnd = 13315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateShadown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateShadown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 13353, RefRangeEnd = 13356, XrefRangeStart = 13317, XrefRangeEnd = 13353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintCharWithoutSkill(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCharWithoutSkill_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13383, RefRangeEnd = 13385, XrefRangeStart = 13356, XrefRangeEnd = 13383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintBag(mGraphics g, Il2CppStructArray<short> id, int x, int y, int dir, bool isPaintChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)id);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPaintChar;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBag_Public_Void_mGraphics_Il2CppStructArray_1_Int16_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13385, XrefRangeEnd = 13400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isCharBodyImageID(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isCharBodyImageID_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13416, RefRangeEnd = 13417, XrefRangeStart = 13400, XrefRangeEnd = 13416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintHead(mGraphics g, int cx, int cy, int look)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &look;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintHead_Public_Void_mGraphics_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 13433, RefRangeEnd = 13439, XrefRangeStart = 13417, XrefRangeEnd = 13433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintHeadWithXY(mGraphics g, int x, int y, int look)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &look;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintHeadWithXY_Public_Void_mGraphics_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 13617, RefRangeEnd = 13624, XrefRangeStart = 13439, XrefRangeEnd = 13617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintCharBody(mGraphics g, int cx, int cy, int cdir, int cf, bool isPaintBag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cdir;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &cf;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPaintBag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCharBody_Public_Void_mGraphics_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13646, RefRangeEnd = 13648, XrefRangeStart = 13624, XrefRangeEnd = 13646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintCharWithSkill(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCharWithSkill_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13648, XrefRangeEnd = 13660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getIndexChar(int ID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getIndexChar_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 13674, RefRangeEnd = 13678, XrefRangeStart = 13660, XrefRangeEnd = 13674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void moveTo(int toX, int toY, int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&toX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toY;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveTo_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13678, XrefRangeEnd = 13703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getcharInjure(int cID, int dx, int dy, int HP)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&cID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dy;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &HP;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getcharInjure_Public_Static_Void_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13703, XrefRangeEnd = 13711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isMagicTree()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMagicTree_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13744, RefRangeEnd = 13745, XrefRangeStart = 13711, XrefRangeEnd = 13744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void searchItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_searchItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13745, XrefRangeEnd = 13851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void searchFocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_searchFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13851, XrefRangeEnd = 13862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearFocus(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearFocus_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 13871, RefRangeEnd = 13872, XrefRangeStart = 13862, XrefRangeEnd = 13871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isCharInScreen(Char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isCharInScreen_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 13872, RefRangeEnd = 13876, XrefRangeStart = 13872, XrefRangeEnd = 13872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isAttacPlayerStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isAttacPlayerStatus_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 13877, RefRangeEnd = 13880, XrefRangeStart = 13876, XrefRangeEnd = 13877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setHoldChar(Char r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)r);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setHoldChar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 13881, RefRangeEnd = 13883, XrefRangeStart = 13880, XrefRangeEnd = 13881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setHoldMob(Mob r)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)r);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setHoldMob_Public_Void_Mob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 13992, RefRangeEnd = 13995, XrefRangeStart = 13883, XrefRangeEnd = 13992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void findNextFocusByKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findNextFocusByKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14006, RefRangeEnd = 14010, XrefRangeStart = 13995, XrefRangeEnd = 14006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void deFocusNPC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_deFocusNPC_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14042, RefRangeEnd = 14044, XrefRangeStart = 14010, XrefRangeEnd = 14042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateCharInBridge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCharInBridge_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void sort(Il2CppStructArray<int> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sort_Public_Static_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool setInsc(int cmX, int cmWx, int x, int cmy, int cmyH, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&cmX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmWx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmy;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmyH;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setInsc_Public_Static_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14044, XrefRangeEnd = 14050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void kickOption(Item item, int maxKick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxKick;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_kickOption_Public_Void_Item_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 14116, RefRangeEnd = 14134, XrefRangeStart = 14050, XrefRangeEnd = 14116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doInjure(long HPShow, long MPShow, bool isCrit, bool isMob)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&HPShow);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &MPShow;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCrit;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isMob;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doInjure_Public_Void_Int64_Int64_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14142, RefRangeEnd = 14146, XrefRangeStart = 14134, XrefRangeEnd = 14142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doInjure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doInjure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 14179, RefRangeEnd = 14182, XrefRangeStart = 14146, XrefRangeEnd = 14179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startDie(short toX, short toY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&toX);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startDie_Public_Void_Int16_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14182, RefRangeEnd = 14183, XrefRangeStart = 14182, XrefRangeEnd = 14182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void waitToDie(short toX, short toY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&toX);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_waitToDie_Public_Void_Int16_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14190, RefRangeEnd = 14194, XrefRangeStart = 14183, XrefRangeEnd = 14190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void liveFromDead()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_liveFromDead_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14195, RefRangeEnd = 14196, XrefRangeStart = 14194, XrefRangeEnd = 14195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isHavePean()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHavePean_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14203, RefRangeEnd = 14204, XrefRangeStart = 14196, XrefRangeEnd = 14203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool doUsePotion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doUsePotion_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 14226, RefRangeEnd = 14232, XrefRangeStart = 14204, XrefRangeEnd = 14226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isLang()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isLang_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 14283, RefRangeEnd = 14290, XrefRangeStart = 14232, XrefRangeEnd = 14283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isMeCanAttackOtherPlayer(Char cAtt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cAtt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeCanAttackOtherPlayer_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14315, RefRangeEnd = 14316, XrefRangeStart = 14290, XrefRangeEnd = 14315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearTask()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearTask_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int getX()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getX_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int getY()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getY_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int getH()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getH_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual int getW()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getW_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14329, RefRangeEnd = 14330, XrefRangeStart = 14316, XrefRangeEnd = 14329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void focusManualTo(Il2CppSystem.Object objectz)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectz);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_focusManualTo_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void stopMoving()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopMoving_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void cancelAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cancelAttack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(89)]
	[CachedScanResults(RefRangeStart = 14330, RefRangeEnd = 14419, XrefRangeStart = 14330, XrefRangeEnd = 14330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool isInvisible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInvisible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14419, RefRangeEnd = 14421, XrefRangeStart = 14419, XrefRangeEnd = 14419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool focusToAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_focusToAttack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14434, RefRangeEnd = 14436, XrefRangeStart = 14421, XrefRangeEnd = 14434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addDustEff(int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addDustEff_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14448, RefRangeEnd = 14450, XrefRangeStart = 14436, XrefRangeEnd = 14448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isGetFlagImage(sbyte getFlag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&getFlag);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isGetFlagImage_Public_Boolean_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14470, RefRangeEnd = 14471, XrefRangeStart = 14450, XrefRangeEnd = 14470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintPKFlag(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintPKFlag_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14474, RefRangeEnd = 14476, XrefRangeStart = 14471, XrefRangeEnd = 14474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeHoleEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeHoleEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14477, RefRangeEnd = 14479, XrefRangeStart = 14476, XrefRangeEnd = 14477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeProtectEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeProtectEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14479, RefRangeEnd = 14481, XrefRangeStart = 14479, XrefRangeEnd = 14479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeBlindEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeBlindEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14484, RefRangeEnd = 14485, XrefRangeStart = 14481, XrefRangeEnd = 14484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14498, RefRangeEnd = 14499, XrefRangeStart = 14485, XrefRangeEnd = 14498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPos(short xPos, short yPos, sbyte typePos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xPos);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yPos;
		*(sbyte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPos_Public_Void_Int16_Int16_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14499, RefRangeEnd = 14501, XrefRangeStart = 14499, XrefRangeEnd = 14499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeHuytSao()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeHuytSao_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14505, RefRangeEnd = 14507, XrefRangeStart = 14501, XrefRangeEnd = 14505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void fusionComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_fusionComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14535, RefRangeEnd = 14537, XrefRangeStart = 14507, XrefRangeEnd = 14535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setFusion(sbyte fusion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fusion);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFusion_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14537, RefRangeEnd = 14539, XrefRangeStart = 14537, XrefRangeEnd = 14537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeSleepEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeSleepEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14539, RefRangeEnd = 14540, XrefRangeStart = 14539, XrefRangeEnd = 14539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPartOld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPartOld_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14540, RefRangeEnd = 14541, XrefRangeStart = 14540, XrefRangeEnd = 14540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPartTemp(int head, int body, int leg, int bag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&head);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &body;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &leg;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPartTemp_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14541, RefRangeEnd = 14543, XrefRangeStart = 14541, XrefRangeEnd = 14541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resetPartTemp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetPartTemp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14548, RefRangeEnd = 14552, XrefRangeStart = 14543, XrefRangeEnd = 14548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Effect getEffById(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEffById_Public_Effect_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Effect>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 14557, RefRangeEnd = 14561, XrefRangeStart = 14552, XrefRangeEnd = 14557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addEffChar(Effect e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addEffChar_Public_Void_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 14564, RefRangeEnd = 14570, XrefRangeStart = 14561, XrefRangeEnd = 14564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeEffChar(int type, int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeEffChar_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14570, XrefRangeEnd = 14576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintEffBehind(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintEffBehind_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14576, XrefRangeEnd = 14582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintEffFront(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintEffFront_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14582, XrefRangeEnd = 14588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updEffChar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updEffChar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 14588, RefRangeEnd = 14591, XrefRangeStart = 14588, XrefRangeEnd = 14588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int checkLuong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkLuong_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14591, XrefRangeEnd = 14596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateEye()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateEye_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14621, RefRangeEnd = 14623, XrefRangeStart = 14596, XrefRangeEnd = 14621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintRedEye(mGraphics g, int xx, int yy, int trans, int anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &xx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &yy;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &trans;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintRedEye_Private_Void_mGraphics_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 14630, RefRangeEnd = 14633, XrefRangeStart = 14623, XrefRangeEnd = 14630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isHead_2Fr(int idHead)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idHead);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHead_2Fr_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14633, XrefRangeEnd = 14634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateFHead()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateFHead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 14643, RefRangeEnd = 14646, XrefRangeStart = 14634, XrefRangeEnd = 14643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getFHead(int idHead)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idHead);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFHead_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14688, RefRangeEnd = 14689, XrefRangeStart = 14646, XrefRangeEnd = 14688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintAuraBehind(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintAuraBehind_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14713, RefRangeEnd = 14714, XrefRangeStart = 14689, XrefRangeEnd = 14713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintAuraFront(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintAuraFront_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14714, XrefRangeEnd = 14732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintEff_Lvup_behind(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintEff_Lvup_behind_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14732, XrefRangeEnd = 14750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintEff_Lvup_front(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintEff_Lvup_front_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 14795, RefRangeEnd = 14797, XrefRangeStart = 14750, XrefRangeEnd = 14795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintHat_behind(mGraphics g, int cf, int yh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cf;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &yh;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintHat_behind_Public_Void_mGraphics_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14842, RefRangeEnd = 14843, XrefRangeStart = 14797, XrefRangeEnd = 14842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintHat_front(mGraphics g, int cf, int yh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cf;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &yh;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintHat_front_Public_Void_mGraphics_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool isFrNgang(int fr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isFrNgang_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14843, XrefRangeEnd = 14848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendNewAttack(short idTemplateSkill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idTemplateSkill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendNewAttack_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14962, RefRangeEnd = 14963, XrefRangeStart = 14848, XrefRangeEnd = 14962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkillPaint_NEW(short idskillPaint, bool isFly, sbyte typeFrame, sbyte typePaint, sbyte dir, short timeGong, sbyte typeItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&idskillPaint);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFly;
		*(sbyte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeFrame;
		*(sbyte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePaint;
		*(sbyte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(short**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeGong;
		*(sbyte**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeItem;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkillPaint_NEW_Public_Void_Int16_Boolean_SByte_SByte_SByte_Int16_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14981, RefRangeEnd = 14982, XrefRangeStart = 14963, XrefRangeEnd = 14981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSkillPaint_STT(int stt, short idskillPaint, Point targetDame, short timeDame, short rangeDame, sbyte typePaint, Il2CppReferenceArray<Point> listObj, sbyte typeItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&stt);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idskillPaint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetDame);
		*(short**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeDame;
		*(short**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeDame;
		*(sbyte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePaint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listObj);
		*(sbyte**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeItem;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSkillPaint_STT_Public_Void_Int32_Int16_Point_Int16_Int16_SByte_Il2CppReferenceArray_1_Point_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14982, XrefRangeEnd = 14987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdSkillPaint_NEW()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdSkillPaint_NEW_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14987, XrefRangeEnd = 14992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetGender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGender_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15010, RefRangeEnd = 15011, XrefRangeStart = 14992, XrefRangeEnd = 15010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updatePetPean()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updatePetPean_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15034, RefRangeEnd = 15035, XrefRangeStart = 15011, XrefRangeEnd = 15034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isBuffPet()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isBuffPet_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15040, RefRangeEnd = 15041, XrefRangeStart = 15035, XrefRangeEnd = 15040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getGender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getGender_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	public Char(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
