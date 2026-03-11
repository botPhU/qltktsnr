using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public class GameScr : mScreen
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintOther;

	private static readonly System.IntPtr NativeFieldInfoPtr_textTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoadAllData;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_gW;

	private static readonly System.IntPtr NativeFieldInfoPtr_gH;

	private static readonly System.IntPtr NativeFieldInfoPtr_gW2;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssw;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssh;

	private static readonly System.IntPtr NativeFieldInfoPtr_gH34;

	private static readonly System.IntPtr NativeFieldInfoPtr_gW3;

	private static readonly System.IntPtr NativeFieldInfoPtr_gH3;

	private static readonly System.IntPtr NativeFieldInfoPtr_gH23;

	private static readonly System.IntPtr NativeFieldInfoPtr_gW23;

	private static readonly System.IntPtr NativeFieldInfoPtr_gH2;

	private static readonly System.IntPtr NativeFieldInfoPtr_csPadMaxH;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarH;

	private static readonly System.IntPtr NativeFieldInfoPtr_gW34;

	private static readonly System.IntPtr NativeFieldInfoPtr_gW6;

	private static readonly System.IntPtr NativeFieldInfoPtr_gH6;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmxLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssx;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssy;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssxe;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssye;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdback;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBag;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdTiemnang;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdtrangbi;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdFire;

	private static readonly System.IntPtr NativeFieldInfoPtr_d;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpPotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_sks;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrs;

	private static readonly System.IntPtr NativeFieldInfoPtr_darts;

	private static readonly System.IntPtr NativeFieldInfoPtr_parts;

	private static readonly System.IntPtr NativeFieldInfoPtr_efs;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveDow;

	private static readonly System.IntPtr NativeFieldInfoPtr_idTypeTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_isstarOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_isChangeSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_vClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_vPtMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_vFriend;

	private static readonly System.IntPtr NativeFieldInfoPtr_vEnemies;

	private static readonly System.IntPtr NativeFieldInfoPtr_vCharInMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_vItemMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_vMobAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_vSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_vMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_vNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_vFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_nClasss;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexRowMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_iOptionTemplates;

	private static readonly System.IntPtr NativeFieldInfoPtr_sOptionTemplates;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrMain;

	private static readonly System.IntPtr NativeFieldInfoPtr_vItemUpGrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTypeXu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isViewNext;

	private static readonly System.IntPtr NativeFieldInfoPtr_isViewClanMemOnline;

	private static readonly System.IntPtr NativeFieldInfoPtr_isViewClanInvite;

	private static readonly System.IntPtr NativeFieldInfoPtr_isChop;

	private static readonly System.IntPtr NativeFieldInfoPtr_titleInputText;

	private static readonly System.IntPtr NativeFieldInfoPtr_tickMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintAlert;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintFindTeam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintFriend;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintEnemies;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintItemInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHaveSelectSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintInfoMe;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintStore;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintNonNam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintNonNu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintAoNam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintAoNu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintGangTayNam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintGangTayNu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintQuanNam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintQuanNu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintGiayNam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintGiayNu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintLien;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintNhan;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintNgocBoi;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintPhu;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintWeapon;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintStack;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintStackLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintGrocery;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintGroceryLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintUpGrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintConvert;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintUpGradeGold;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintUpPearl;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintSplit;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintCharInMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintTrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintClan;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRequestMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentCharViewInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_exps;

	private static readonly System.IntPtr NativeFieldInfoPtr_crystals;

	private static readonly System.IntPtr NativeFieldInfoPtr_upClothe;

	private static readonly System.IntPtr NativeFieldInfoPtr_upAdorn;

	private static readonly System.IntPtr NativeFieldInfoPtr_upWeapon;

	private static readonly System.IntPtr NativeFieldInfoPtr_coinUpCrystals;

	private static readonly System.IntPtr NativeFieldInfoPtr_coinUpClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_coinUpAdorns;

	private static readonly System.IntPtr NativeFieldInfoPtr_coinUpWeapons;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPercents;

	private static readonly System.IntPtr NativeFieldInfoPtr_goldUps;

	private static readonly System.IntPtr NativeFieldInfoPtr_tMenuDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoneCol;

	private static readonly System.IntPtr NativeFieldInfoPtr_zones;

	private static readonly System.IntPtr NativeFieldInfoPtr_pts;

	private static readonly System.IntPtr NativeFieldInfoPtr_numPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_rank1;

	private static readonly System.IntPtr NativeFieldInfoPtr_rank2;

	private static readonly System.IntPtr NativeFieldInfoPtr_rankName1;

	private static readonly System.IntPtr NativeFieldInfoPtr_rankName2;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeTrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeTradeOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_coinTrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_coinTradeOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeTrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexItemUse;

	private static readonly System.IntPtr NativeFieldInfoPtr_cLastFocusID;

	private static readonly System.IntPtr NativeFieldInfoPtr_cPreFocusID;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLockKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_tasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapTasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgRoomStat;

	private static readonly System.IntPtr NativeFieldInfoPtr_frBarPow0;

	private static readonly System.IntPtr NativeFieldInfoPtr_frBarPow1;

	private static readonly System.IntPtr NativeFieldInfoPtr_frBarPow2;

	private static readonly System.IntPtr NativeFieldInfoPtr_frBarPow20;

	private static readonly System.IntPtr NativeFieldInfoPtr_frBarPow21;

	private static readonly System.IntPtr NativeFieldInfoPtr_frBarPow22;

	private static readonly System.IntPtr NativeFieldInfoPtr_texts;

	private static readonly System.IntPtr NativeFieldInfoPtr_textsTitle;

	private static readonly System.IntPtr NativeFieldInfoPtr_vcData;

	private static readonly System.IntPtr NativeFieldInfoPtr_vcMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_vcSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_vcItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_vsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_vsMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_vsSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_vsItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_vcTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgArrow2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgChat;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgChat2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFocus2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSkill2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP3;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP4;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFire0;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFire1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgLbtn;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgLbtnFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgLbtn2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgLbtnFocus2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgAnalog1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgAnalog2;

	private static readonly System.IntPtr NativeFieldInfoPtr_tradeName;

	private static readonly System.IntPtr NativeFieldInfoPtr_tradeItemName;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeLengthMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeStartMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeViewInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_info1;

	private static readonly System.IntPtr NativeFieldInfoPtr_info2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgPanel2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSP;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHPLost;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMPLost;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP_tm_do;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP_tm_vang;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP_tm_xam;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP_tm_xanh;

	private static readonly System.IntPtr NativeFieldInfoPtr_mobCapcha;

	private static readonly System.IntPtr NativeFieldInfoPtr_magicTree;

	private static readonly System.IntPtr NativeFieldInfoPtr_countEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_gamePad;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgChatPC;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgChatsPC2;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAnalog;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUseTouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_numSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_numSkill_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_keySkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_onScreenSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstY;

	private static readonly System.IntPtr NativeFieldInfoPtr_wSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPointerDowning;

	private static readonly System.IntPtr NativeFieldInfoPtr_isChangingCameraMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptLastDownX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptLastDownY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptFirstDownX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptFirstDownY;

	private static readonly System.IntPtr NativeFieldInfoPtr_ptDownTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableSingleClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSingleClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickMoving;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickOnTileTop;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickMovingRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickToX;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickToY;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastClickCMX;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastClickCMY;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickMovingP1;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickMovingTimeOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNewClanMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastFire;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUsePotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_auto;

	private static readonly System.IntPtr NativeFieldInfoPtr_dem;

	private static readonly System.IntPtr NativeFieldInfoPtr_strTam;

	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFreez;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUseFreez;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgTrans;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRongThanXuatHien;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRongNamek;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSuperPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_tPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_xPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_yPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_dxPower;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeRongThan;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMeCallRongThan;

	private static readonly System.IntPtr NativeFieldInfoPtr_mautroi;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapRID;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoneRID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgRID;

	private static readonly System.IntPtr NativeFieldInfoPtr_tam;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoPlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_canAutoPlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_isChangeZone;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_nSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedIndexSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_doSeleckSkillFlag;

	private static readonly System.IntPtr NativeFieldInfoPtr_strCapcha;

	private static readonly System.IntPtr NativeFieldInfoPtr_longPress;

	private static readonly System.IntPtr NativeFieldInfoPtr_move;

	private static readonly System.IntPtr NativeFieldInfoPtr_flareFindFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_flareTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyTouchSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSendUpdatePostion;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_currTick;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeAuto;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastXS;

	private static readonly System.IntPtr NativeFieldInfoPtr_currXS;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondXS;

	private static readonly System.IntPtr NativeFieldInfoPtr_runArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintRada;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgNut;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgNutF;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyCapcha;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgCapcha;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_disXC;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_shock_scr;

	private static readonly System.IntPtr NativeFieldInfoPtr_shock_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_shock_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_tDoubleDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_yTouchBar;

	private static readonly System.IntPtr NativeFieldInfoPtr_xC;

	private static readonly System.IntPtr NativeFieldInfoPtr_yC;

	private static readonly System.IntPtr NativeFieldInfoPtr_xL;

	private static readonly System.IntPtr NativeFieldInfoPtr_yL;

	private static readonly System.IntPtr NativeFieldInfoPtr_xR;

	private static readonly System.IntPtr NativeFieldInfoPtr_yR;

	private static readonly System.IntPtr NativeFieldInfoPtr_xU;

	private static readonly System.IntPtr NativeFieldInfoPtr_yU;

	private static readonly System.IntPtr NativeFieldInfoPtr_xF;

	private static readonly System.IntPtr NativeFieldInfoPtr_yF;

	private static readonly System.IntPtr NativeFieldInfoPtr_xHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_yHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_xTG;

	private static readonly System.IntPtr NativeFieldInfoPtr_yTG;

	private static readonly System.IntPtr NativeFieldInfoPtr_xS;

	private static readonly System.IntPtr NativeFieldInfoPtr_yS;

	private static readonly System.IntPtr NativeFieldInfoPtr_xSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_ySkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_padSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_dMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_twMp;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInjureMp;

	private static readonly System.IntPtr NativeFieldInfoPtr_dHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_twHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInjureHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_curr;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondVS;

	private static readonly System.IntPtr NativeFieldInfoPtr_idVS;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextString;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextX;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextY;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextYTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextDx;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextDy;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextState;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTextColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_splashX;

	private static readonly System.IntPtr NativeFieldInfoPtr_splashY;

	private static readonly System.IntPtr NativeFieldInfoPtr_splashState;

	private static readonly System.IntPtr NativeFieldInfoPtr_splashF;

	private static readonly System.IntPtr NativeFieldInfoPtr_splashDir;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSplash;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarLeftW;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarRightW;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdBarCenterW;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarX;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarY;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_spBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_mpBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_expBarW;

	private static readonly System.IntPtr NativeFieldInfoPtr_lvPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_moneyPosX;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpBarH;

	private static readonly System.IntPtr NativeFieldInfoPtr_girlHPBarY;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgCmdBar;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgScrW;

	private static readonly System.IntPtr NativeFieldInfoPtr_popupY;

	private static readonly System.IntPtr NativeFieldInfoPtr_popupX;

	private static readonly System.IntPtr NativeFieldInfoPtr_isborderIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isselectedRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgNolearn;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmxp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvxp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdxp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmxLimp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyLimp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvyp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdyp;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexTiemNang;

	private static readonly System.IntPtr NativeFieldInfoPtr_alertURL;

	private static readonly System.IntPtr NativeFieldInfoPtr_fnick;

	private static readonly System.IntPtr NativeFieldInfoPtr_xstart;

	private static readonly System.IntPtr NativeFieldInfoPtr_ystart;

	private static readonly System.IntPtr NativeFieldInfoPtr_popupW;

	private static readonly System.IntPtr NativeFieldInfoPtr_popupH;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmySK;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoYSK;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdySK;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvySK;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyLimSK;

	private static readonly System.IntPtr NativeFieldInfoPtr_columns;

	private static readonly System.IntPtr NativeFieldInfoPtr_rows;

	private static readonly System.IntPtr NativeFieldInfoPtr_totalRowInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_ypaintKill;

	private static readonly System.IntPtr NativeFieldInfoPtr_ylimUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ylimDow;

	private static readonly System.IntPtr NativeFieldInfoPtr_yPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_effUpok;

	private static readonly System.IntPtr NativeFieldInfoPtr_inforX;

	private static readonly System.IntPtr NativeFieldInfoPtr_inforY;

	private static readonly System.IntPtr NativeFieldInfoPtr_inforW;

	private static readonly System.IntPtr NativeFieldInfoPtr_inforH;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdDead;

	private static readonly System.IntPtr NativeFieldInfoPtr_notPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPing;

	private static readonly System.IntPtr NativeFieldInfoPtr_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_STORE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZONE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UPGRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_Hitem;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSizeRow;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTranKyNang;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTran;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmY_Old;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmX_Old;

	private static readonly System.IntPtr NativeFieldInfoPtr_popUpYesNo;

	private static readonly System.IntPtr NativeFieldInfoPtr_vChatVip;

	private static readonly System.IntPtr NativeFieldInfoPtr_vBig;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFireWorks;

	private static readonly System.IntPtr NativeFieldInfoPtr_winnumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_tMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_delayMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWin;

	private static readonly System.IntPtr NativeFieldInfoPtr_strFinish;

	private static readonly System.IntPtr NativeFieldInfoPtr_tShow;

	private static readonly System.IntPtr NativeFieldInfoPtr_xChatVip;

	private static readonly System.IntPtr NativeFieldInfoPtr_currChatWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_startChat;

	private static readonly System.IntPtr NativeFieldInfoPtr_percentMabu;

	private static readonly System.IntPtr NativeFieldInfoPtr_mabuEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_tMabuEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintChatVip;

	private static readonly System.IntPtr NativeFieldInfoPtr_mabuPercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNewMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_yourNumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_strPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP_NEW;

	private static readonly System.IntPtr NativeFieldInfoPtr_phuban_Info;

	private static readonly System.IntPtr NativeFieldInfoPtr_fra_PVE_Bar_0;

	private static readonly System.IntPtr NativeFieldInfoPtr_fra_PVE_Bar_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgVS;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgBall;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgKhung;

	private static readonly System.IntPtr NativeFieldInfoPtr_yClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_head;

	private static readonly System.IntPtr NativeFieldInfoPtr_body;

	private static readonly System.IntPtr NativeFieldInfoPtr_leg;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadBg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initSelectChar_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintOngMauPercent_Public_Static_Void_Image_Image_Image_Single_Single_Int32_Single_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initTraining_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMapDocNhan_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMapFize_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMaxExp_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetAllvector_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadSkillShortcut_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onOSkill_Public_Void_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onKSkill_Public_Void_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCSkill_Public_Void_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadDefaultonScreenSkill_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadDefaultKeySkill_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doSetOnScreenSkill_Public_Void_SkillTemplate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doSetKeySkill_Public_Void_SkillTemplate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveonScreenSkillToRMS_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveKeySkillToRMS_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRMSCurrentSkill_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addSkillShortcut_Public_Void_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isBagFull_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createConfirm_Public_Void_Il2CppStringArray_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createMenu_Public_Void_Il2CppStringArray_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readPart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readEfect_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readArrow_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readDart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_GameScr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearGameScr_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadGameScr_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doMenuInforMe_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doMenusynthesis_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadCamera_Public_Static_Void_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSkillBarPosition_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCamera_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_testAct_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clanInvite_Public_Void_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playerMenu_Public_Void_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isAttack_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMeCanAttackMob_Public_Boolean_Mob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkSkillValid_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkSkillValid2_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetButton_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyPress_Public_Virtual_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isVsMap_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkDrag_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findClickToItem_Private_IMapObject_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_inRectangle_Private_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkSingleClickEarly_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkDoubleClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkClickToBotton_Private_Boolean_IMapObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doDoubleClickToObj_Public_Void_IMapObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkSingleClick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkClipTopChatPopUp_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkClickToPopup_Private_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkClickMoveTo_Private_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkAuto_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doUseHP_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_activeSuperPower_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_activeRongThanEff_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hideRongThanEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doiMauTroi_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callRongThan_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hideRongThan_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_autoPlay_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doFire_Private_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_askToPick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pickItem_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isCharging_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doSelectSkill_Public_Void_Skill_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doUseSkill_Public_Void_Skill_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMyClan_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doUseSkillNotFocus_Public_Void_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sortSkill_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKeyTouchCapcha_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkClickToCapcha_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkMouseChat_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKeyTouchControl_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCharJumpAtt_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setCharJump_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateOpen_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initCreateCommand_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkCharFocus_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateXoSo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKeyChatPopUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isRongThanMenu_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintEffect_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBgItem_Public_Void_mGraphics_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBlackSky_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCapcha_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintXoSo_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkEffToObj_Private_Void_IMapObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateClickToArrow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintWaypointArrow_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findNPCInMap_Public_Static_Npc_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findCharInMap_Public_Static_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findMobInMap_Public_Static_Mob_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findMobInMap2_Public_Static_Mob_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findMobInMap_Public_Static_Mob_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNpcTask_Public_Static_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintArrowPointToNPC_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetTranslate_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintTouchControl_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintImageBarRight_Public_Void_mGraphics_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintImageBar_Private_Void_mGraphics_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInjure_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_starVS_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findCharVS1_Private_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findCharVS2_Private_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintInfoBar_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isVS_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintSelectedSkill_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintOpen_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startFlyText_Public_Static_Void_String_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateFlyText_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadSplash_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startSplash_Public_Static_Boolean_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSplash_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintSplash_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadInforBar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSS_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKeyAlert_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPaintPopup_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNotPaintTouchControl_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPaintUI_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isOpenUI_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPopupSize_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadImg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintTitle_Public_Void_mGraphics_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTaskMapId_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTaskNpcId_Public_Static_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_refreshTeam_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openWeb_Public_Void_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendSms_Public_Void_String_String_Int16_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_actMenu_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openUIZone_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showViewInfo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_actDead_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startYesNoPopUp_Public_Void_String_Command_Command_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_player_vs_player_Public_Void_Int32_Int32_String_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_giaodich_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFlagImage_Public_Void_Int32_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_actionPerform_Public_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTouchBtn_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateGamePad_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintGamePad_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showWinNumber_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chatVip_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearChatVip_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintChatVip_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateChatVip_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showYourNumber_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkRemoveImage_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartServerPopUp_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ispaintPhubangBar_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintPhuBanBar_Public_Void_mGraphics_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintChienTruong_Life_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintHPBar_NEW_Public_Static_Void_mGraphics_Int32_Int32_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addEffectEnd_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addEffectEnd_Target_Public_Static_Void_Int32_Int32_Int32_Char_Point_Int32_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addEffect2Vector_Public_Static_Void_Effect_End_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setIsInScreen_Public_Static_Boolean_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isSmallScr_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_xp_bar_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExportCurrentMapPNG_Public_Static_Void_0;

	public unsafe static bool isPaintOther
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintOther, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintOther, (void*)(&flag));
		}
	}

	public unsafe static MyVector textTime
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_textTime, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_textTime, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static bool isLoadAllData
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoadAllData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoadAllData, (void*)(&flag));
		}
	}

	public unsafe static GameScr instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameScr>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameScr));
		}
	}

	public unsafe static int gW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gW, (void*)(&num));
		}
	}

	public unsafe static int gH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gH, (void*)(&num));
		}
	}

	public unsafe static int gW2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gW2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gW2, (void*)(&num));
		}
	}

	public unsafe static int gssw
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssw, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssw, (void*)(&num));
		}
	}

	public unsafe static int gssh
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssh, (void*)(&num));
		}
	}

	public unsafe static int gH34
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gH34, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gH34, (void*)(&num));
		}
	}

	public unsafe static int gW3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gW3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gW3, (void*)(&num));
		}
	}

	public unsafe static int gH3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gH3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gH3, (void*)(&num));
		}
	}

	public unsafe static int gH23
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gH23, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gH23, (void*)(&num));
		}
	}

	public unsafe static int gW23
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gW23, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gW23, (void*)(&num));
		}
	}

	public unsafe static int gH2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gH2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gH2, (void*)(&num));
		}
	}

	public unsafe static int csPadMaxH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_csPadMaxH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_csPadMaxH, (void*)(&num));
		}
	}

	public unsafe static int cmdBarH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarH, (void*)(&num));
		}
	}

	public unsafe static int gW34
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gW34, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gW34, (void*)(&num));
		}
	}

	public unsafe static int gW6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gW6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gW6, (void*)(&num));
		}
	}

	public unsafe static int gH6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gH6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gH6, (void*)(&num));
		}
	}

	public unsafe static int cmx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmx, (void*)(&num));
		}
	}

	public unsafe static int cmy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmy, (void*)(&num));
		}
	}

	public unsafe static int cmdx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdx, (void*)(&num));
		}
	}

	public unsafe static int cmdy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdy, (void*)(&num));
		}
	}

	public unsafe static int cmvx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmvx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmvx, (void*)(&num));
		}
	}

	public unsafe static int cmvy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmvy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmvy, (void*)(&num));
		}
	}

	public unsafe static int cmtoX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmtoX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmtoX, (void*)(&num));
		}
	}

	public unsafe static int cmtoY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmtoY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmtoY, (void*)(&num));
		}
	}

	public unsafe static int cmxLim
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmxLim, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmxLim, (void*)(&num));
		}
	}

	public unsafe static int cmyLim
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmyLim, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmyLim, (void*)(&num));
		}
	}

	public unsafe static int gssx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssx, (void*)(&num));
		}
	}

	public unsafe static int gssy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssy, (void*)(&num));
		}
	}

	public unsafe static int gssxe
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssxe, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssxe, (void*)(&num));
		}
	}

	public unsafe static int gssye
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssye, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssye, (void*)(&num));
		}
	}

	public unsafe Command cmdback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdBag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdBag);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdBag)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdTiemnang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdTiemnang);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdTiemnang)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdtrangbi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdtrangbi);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdtrangbi)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdFire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdFire);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdFire)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe static int d
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_d, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_d, (void*)(&num));
		}
	}

	public unsafe static int hpPotion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpPotion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpPotion, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<SkillPaint> sks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkillPaint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Arrowpaint> arrs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Arrowpaint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<DartInfo> darts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_darts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DartInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_darts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Part> parts
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_parts, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Part>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_parts, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<EffectCharPaint> efs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_efs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EffectCharPaint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_efs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int lockTick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lockTick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lockTick, (void*)(&num));
		}
	}

	public unsafe int moveUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveUp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveUp)) = num;
		}
	}

	public unsafe int moveDow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveDow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveDow)) = num;
		}
	}

	public unsafe int idTypeTask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idTypeTask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idTypeTask)) = num;
		}
	}

	public unsafe bool isstarOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isstarOpen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isstarOpen)) = flag;
		}
	}

	public unsafe bool isChangeSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChangeSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChangeSkill)) = flag;
		}
	}

	public unsafe static MyVector vClan
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vClan, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vClan, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vPtMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vPtMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vPtMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vFriend
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vFriend, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vFriend, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vEnemies
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vEnemies, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vEnemies, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vCharInMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vCharInMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vCharInMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vItemMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vItemMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vItemMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vMobAttack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vMobAttack, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vMobAttack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vSet
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vSet, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vSet, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vMob
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vMob, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vMob, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vNpc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vNpc, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vNpc, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vFlag
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vFlag, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vFlag, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static Il2CppReferenceArray<NClass> nClasss
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nClasss, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NClass>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nClasss, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int indexSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexSize, (void*)(&num));
		}
	}

	public unsafe static int indexTitle
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexTitle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexTitle, (void*)(&num));
		}
	}

	public unsafe static int indexSelect
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexSelect, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexSelect, (void*)(&num));
		}
	}

	public unsafe static int indexRow
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexRow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexRow, (void*)(&num));
		}
	}

	public unsafe static int indexRowMax
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexRowMax, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexRowMax, (void*)(&num));
		}
	}

	public unsafe static int indexMenu
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexMenu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexMenu, (void*)(&num));
		}
	}

	public unsafe Item itemFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Item>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item));
		}
	}

	public unsafe Dictionary<int, ItemOptionTemplate> iOptionTemplates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iOptionTemplates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, ItemOptionTemplate>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iOptionTemplates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe Il2CppReferenceArray<SkillOptionTemplate> sOptionTemplates
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sOptionTemplates);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkillOptionTemplate>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sOptionTemplates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Scroll scrInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scrInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scroll>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scrInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scroll));
		}
	}

	public unsafe static Scroll scrMain
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scrMain, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scroll>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scrMain, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scroll));
		}
	}

	public unsafe static MyVector vItemUpGrade
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vItemUpGrade, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vItemUpGrade, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static bool isTypeXu
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTypeXu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTypeXu, (void*)(&flag));
		}
	}

	public unsafe static bool isViewNext
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isViewNext, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isViewNext, (void*)(&flag));
		}
	}

	public unsafe static bool isViewClanMemOnline
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isViewClanMemOnline, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isViewClanMemOnline, (void*)(&flag));
		}
	}

	public unsafe static bool isViewClanInvite
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isViewClanInvite, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isViewClanInvite, (void*)(&flag));
		}
	}

	public unsafe static bool isChop
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isChop, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isChop, (void*)(&flag));
		}
	}

	public unsafe static string titleInputText
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_titleInputText, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_titleInputText, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int tickMove
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tickMove, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tickMove, (void*)(&num));
		}
	}

	public unsafe static bool isPaintAlert
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintAlert, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintAlert, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintTask
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintTask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintTask, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintTeam
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintTeam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintTeam, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintFindTeam
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintFindTeam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintFindTeam, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintFriend
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintFriend, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintFriend, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintEnemies
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintEnemies, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintEnemies, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintItemInfo
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintItemInfo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintItemInfo, (void*)(&flag));
		}
	}

	public unsafe static bool isHaveSelectSkill
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isHaveSelectSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isHaveSelectSkill, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintSkill
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintSkill, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintInfoMe
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintInfoMe, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintInfoMe, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintStore
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintStore, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintStore, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintNonNam
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintNonNam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintNonNam, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintNonNu
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintNonNu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintNonNu, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintAoNam
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintAoNam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintAoNam, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintAoNu
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintAoNu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintAoNu, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintGangTayNam
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintGangTayNam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintGangTayNam, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintGangTayNu
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintGangTayNu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintGangTayNu, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintQuanNam
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintQuanNam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintQuanNam, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintQuanNu
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintQuanNu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintQuanNu, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintGiayNam
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintGiayNam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintGiayNam, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintGiayNu
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintGiayNu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintGiayNu, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintLien
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintLien, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintLien, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintNhan
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintNhan, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintNhan, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintNgocBoi
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintNgocBoi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintNgocBoi, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintPhu
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintPhu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintPhu, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintWeapon
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintWeapon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintWeapon, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintStack
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintStack, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintStack, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintStackLock
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintStackLock, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintStackLock, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintGrocery
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintGrocery, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintGrocery, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintGroceryLock
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintGroceryLock, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintGroceryLock, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintUpGrade
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintUpGrade, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintUpGrade, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintConvert
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintConvert, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintConvert, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintUpGradeGold
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintUpGradeGold, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintUpGradeGold, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintUpPearl
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintUpPearl, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintUpPearl, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintBox
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintBox, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintBox, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintSplit
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintSplit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintSplit, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintCharInMap
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintCharInMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintCharInMap, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintTrade
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintTrade, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintTrade, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintZone
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintZone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintZone, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintMessage
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintMessage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintMessage, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintClan
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintClan, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintClan, (void*)(&flag));
		}
	}

	public unsafe static bool isRequestMember
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isRequestMember, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isRequestMember, (void*)(&flag));
		}
	}

	public unsafe static Char currentCharViewInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentCharViewInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentCharViewInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe static Il2CppStructArray<long> exps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_exps, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_exps, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> crystals
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_crystals, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_crystals, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> upClothe
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_upClothe, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_upClothe, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> upAdorn
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_upAdorn, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_upAdorn, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> upWeapon
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_upWeapon, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_upWeapon, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> coinUpCrystals
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_coinUpCrystals, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_coinUpCrystals, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> coinUpClothes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_coinUpClothes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_coinUpClothes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> coinUpAdorns
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_coinUpAdorns, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_coinUpAdorns, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> coinUpWeapons
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_coinUpWeapons, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_coinUpWeapons, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> maxPercents
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxPercents, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxPercents, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> goldUps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_goldUps, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_goldUps, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int tMenuDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMenuDelay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMenuDelay)) = num;
		}
	}

	public unsafe int zoneCol
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneCol);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneCol)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> zones
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zones);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zones)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> pts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> numPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPlayer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numPlayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> maxPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPlayer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> rank1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> rank2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rank2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStringArray rankName1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankName1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankName1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStringArray rankName2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankName2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankName2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int typeTrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeTrade);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeTrade)) = num;
		}
	}

	public unsafe int typeTradeOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeTradeOrder);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeTradeOrder)) = num;
		}
	}

	public unsafe int coinTrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coinTrade);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coinTrade)) = num;
		}
	}

	public unsafe int coinTradeOrder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coinTradeOrder);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coinTradeOrder)) = num;
		}
	}

	public unsafe int timeTrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeTrade);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeTrade)) = num;
		}
	}

	public unsafe int indexItemUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexItemUse);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexItemUse)) = num;
		}
	}

	public unsafe int cLastFocusID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cLastFocusID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cLastFocusID)) = num;
		}
	}

	public unsafe int cPreFocusID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cPreFocusID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cPreFocusID)) = num;
		}
	}

	public unsafe bool isLockKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLockKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLockKey)) = flag;
		}
	}

	public unsafe static Il2CppStructArray<int> tasks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tasks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tasks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> mapTasks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mapTasks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mapTasks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgRoomStat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgRoomStat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgRoomStat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image frBarPow0
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frBarPow0, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frBarPow0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image frBarPow1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frBarPow1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frBarPow1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image frBarPow2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frBarPow2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frBarPow2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image frBarPow20
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frBarPow20, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frBarPow20, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image frBarPow21
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frBarPow21, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frBarPow21, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image frBarPow22
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frBarPow22, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frBarPow22, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe MyVector texts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe string textsTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textsTitle);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textsTitle)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static sbyte vcData
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vcData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vcData, (void*)(&b));
		}
	}

	public unsafe static sbyte vcMap
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vcMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vcMap, (void*)(&b));
		}
	}

	public unsafe static sbyte vcSkill
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vcSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vcSkill, (void*)(&b));
		}
	}

	public unsafe static sbyte vcItem
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vcItem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vcItem, (void*)(&b));
		}
	}

	public unsafe static sbyte vsData
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vsData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vsData, (void*)(&b));
		}
	}

	public unsafe static sbyte vsMap
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vsMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vsMap, (void*)(&b));
		}
	}

	public unsafe static sbyte vsSkill
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vsSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vsSkill, (void*)(&b));
		}
	}

	public unsafe static sbyte vsItem
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vsItem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vsItem, (void*)(&b));
		}
	}

	public unsafe static sbyte vcTask
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vcTask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vcTask, (void*)(&b));
		}
	}

	public unsafe static Image imgArrow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgArrow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgArrow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgArrow2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgArrow2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgArrow2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgChat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgChat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgChat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgChat2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgChat2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgChat2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMenu
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMenu, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMenu, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgFocus
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgFocus, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgFocus, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgFocus2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgFocus2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgFocus2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgSkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSkill, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSkill, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgSkill2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSkill2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSkill2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP3
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP3, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP3, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP4
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP4, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP4, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgFire0
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgFire0, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgFire0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgFire1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgFire1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgFire1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgLbtn
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLbtn, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLbtn, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgLbtnFocus
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLbtnFocus, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLbtnFocus, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgLbtn2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLbtn2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLbtn2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgLbtnFocus2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLbtnFocus2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLbtnFocus2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgAnalog1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgAnalog1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgAnalog1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgAnalog2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgAnalog2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgAnalog2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe string tradeName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string tradeItemName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeItemName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tradeItemName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int timeLengthMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLengthMap);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLengthMap)) = num;
		}
	}

	public unsafe int timeStartMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStartMap);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStartMap)) = num;
		}
	}

	public unsafe static sbyte typeViewInfo
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeViewInfo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeViewInfo, (void*)(&b));
		}
	}

	public unsafe static sbyte typeActive
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeActive, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeActive, (void*)(&b));
		}
	}

	public unsafe static InfoMe info1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_info1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InfoMe>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_info1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)infoMe));
		}
	}

	public unsafe static InfoMe info2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_info2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InfoMe>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_info2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)infoMe));
		}
	}

	public unsafe static Image imgPanel
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgPanel, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgPanel, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgPanel2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgPanel2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgPanel2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgSP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHPLost
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHPLost, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHPLost, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMPLost
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMPLost, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMPLost, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP_tm_do
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP_tm_do, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP_tm_do, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP_tm_vang
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP_tm_vang, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP_tm_vang, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP_tm_xam
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP_tm_xam, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP_tm_xam, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHP_tm_xanh
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP_tm_xanh, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP_tm_xanh, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Mob mobCapcha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobCapcha);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobCapcha)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mob));
		}
	}

	public unsafe MagicTree magicTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_magicTree);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MagicTree>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_magicTree)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)magicTree));
		}
	}

	public unsafe static int countEff
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_countEff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_countEff, (void*)(&num));
		}
	}

	public unsafe static GamePad gamePad
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gamePad, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GamePad>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gamePad, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gamePad));
		}
	}

	public unsafe static Image imgChatPC
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgChatPC, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgChatPC, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgChatsPC2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgChatsPC2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgChatsPC2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int isAnalog
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAnalog, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAnalog, (void*)(&num));
		}
	}

	public unsafe static bool isUseTouch
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isUseTouch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isUseTouch, (void*)(&flag));
		}
	}

	public unsafe static int numSkill
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numSkill, (void*)(&num));
		}
	}

	public unsafe static int numSkill_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numSkill_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numSkill_2, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<Skill> keySkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keySkill, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Skill>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keySkill, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Skill> onScreenSkill
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onScreenSkill, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Skill>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onScreenSkill, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
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

	public unsafe static int firstY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_firstY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_firstY, (void*)(&num));
		}
	}

	public unsafe static int wSkill
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wSkill, (void*)(&num));
		}
	}

	public unsafe static long deltaTime
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deltaTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deltaTime, (void*)(&num));
		}
	}

	public unsafe bool isPointerDowning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPointerDowning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPointerDowning)) = flag;
		}
	}

	public unsafe bool isChangingCameraMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChangingCameraMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChangingCameraMode)) = flag;
		}
	}

	public unsafe int ptLastDownX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptLastDownX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptLastDownX)) = num;
		}
	}

	public unsafe int ptLastDownY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptLastDownY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptLastDownY)) = num;
		}
	}

	public unsafe int ptFirstDownX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptFirstDownX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptFirstDownX)) = num;
		}
	}

	public unsafe int ptFirstDownY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptFirstDownY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptFirstDownY)) = num;
		}
	}

	public unsafe int ptDownTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptDownTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ptDownTime)) = num;
		}
	}

	public unsafe bool disableSingleClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSingleClick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableSingleClick)) = flag;
		}
	}

	public unsafe long lastSingleClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSingleClick);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSingleClick)) = num;
		}
	}

	public unsafe bool clickMoving
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMoving);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMoving)) = flag;
		}
	}

	public unsafe bool clickOnTileTop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickOnTileTop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickOnTileTop)) = flag;
		}
	}

	public unsafe bool clickMovingRed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMovingRed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMovingRed)) = flag;
		}
	}

	public unsafe int clickToX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickToX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickToX)) = num;
		}
	}

	public unsafe int clickToY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickToY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickToY)) = num;
		}
	}

	public unsafe int lastClickCMX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastClickCMX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastClickCMX)) = num;
		}
	}

	public unsafe int lastClickCMY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastClickCMY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastClickCMY)) = num;
		}
	}

	public unsafe int clickMovingP1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMovingP1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMovingP1)) = num;
		}
	}

	public unsafe int clickMovingTimeOut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMovingTimeOut);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clickMovingTimeOut)) = num;
		}
	}

	public unsafe long lastMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMove);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMove)) = num;
		}
	}

	public unsafe static bool isNewClanMessage
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isNewClanMessage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isNewClanMessage, (void*)(&flag));
		}
	}

	public unsafe long lastFire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFire);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastFire)) = num;
		}
	}

	public unsafe long lastUsePotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsePotion);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUsePotion)) = num;
		}
	}

	public unsafe int auto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auto);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_auto)) = num;
		}
	}

	public unsafe int dem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dem)) = num;
		}
	}

	public unsafe string strTam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strTam);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strTam)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int a
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = num;
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

	public unsafe bool isUseFreez
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseFreez);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseFreez)) = flag;
		}
	}

	public unsafe static Image imgTrans
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgTrans, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgTrans, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe bool isRongThanXuatHien
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRongThanXuatHien);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRongThanXuatHien)) = flag;
		}
	}

	public unsafe bool isRongNamek
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRongNamek);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRongNamek)) = flag;
		}
	}

	public unsafe bool isSuperPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSuperPower);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSuperPower)) = flag;
		}
	}

	public unsafe int tPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tPower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tPower)) = num;
		}
	}

	public unsafe int xPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xPower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xPower)) = num;
		}
	}

	public unsafe int yPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPower)) = num;
		}
	}

	public unsafe int dxPower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dxPower);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dxPower)) = num;
		}
	}

	public unsafe bool activeRongThan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRongThan);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeRongThan)) = flag;
		}
	}

	public unsafe bool isMeCallRongThan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMeCallRongThan);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMeCallRongThan)) = flag;
		}
	}

	public unsafe int mautroi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mautroi);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mautroi)) = num;
		}
	}

	public unsafe int mapRID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapRID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapRID)) = num;
		}
	}

	public unsafe int zoneRID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneRID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_zoneRID)) = num;
		}
	}

	public unsafe int bgRID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgRID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgRID)) = num;
		}
	}

	public unsafe static int tam
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tam, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tam, (void*)(&num));
		}
	}

	public unsafe static bool isAutoPlay
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoPlay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoPlay, (void*)(&flag));
		}
	}

	public unsafe static bool canAutoPlay
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_canAutoPlay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_canAutoPlay, (void*)(&flag));
		}
	}

	public unsafe static bool isChangeZone
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isChangeZone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isChangeZone, (void*)(&flag));
		}
	}

	public unsafe int timeSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSkill)) = num;
		}
	}

	public unsafe int nSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nSkill)) = num;
		}
	}

	public unsafe int selectedIndexSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedIndexSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedIndexSkill)) = num;
		}
	}

	public unsafe Skill lastSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSkill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skill>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSkill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill));
		}
	}

	public unsafe bool doSeleckSkillFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doSeleckSkillFlag);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doSeleckSkillFlag)) = flag;
		}
	}

	public unsafe string strCapcha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strCapcha);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strCapcha)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe long longPress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longPress);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longPress)) = num;
		}
	}

	public unsafe int move
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_move);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_move)) = num;
		}
	}

	public unsafe bool flareFindFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flareFindFocus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flareFindFocus)) = flag;
		}
	}

	public unsafe int flareTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flareTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flareTime)) = num;
		}
	}

	public unsafe int keyTouchSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyTouchSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyTouchSkill)) = num;
		}
	}

	public unsafe long lastSendUpdatePostion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSendUpdatePostion);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSendUpdatePostion)) = num;
		}
	}

	public unsafe static long lastTick
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTick, (void*)(&num));
		}
	}

	public unsafe static long currTick
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currTick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currTick, (void*)(&num));
		}
	}

	public unsafe int timeAuto
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAuto);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeAuto)) = num;
		}
	}

	public unsafe static long lastXS
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastXS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastXS, (void*)(&num));
		}
	}

	public unsafe static long currXS
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currXS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currXS, (void*)(&num));
		}
	}

	public unsafe static int secondXS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_secondXS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_secondXS, (void*)(&num));
		}
	}

	public unsafe int runArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runArrow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_runArrow)) = num;
		}
	}

	public unsafe static int isPaintRada
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintRada, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintRada, (void*)(&num));
		}
	}

	public unsafe static Image imgNut
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgNut, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgNut, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgNutF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgNutF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgNutF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Il2CppStructArray<int> keyCapcha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyCapcha);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyCapcha)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgCapcha
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgCapcha, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgCapcha, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe string keyInput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyInput);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyInput)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int disXC
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_disXC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_disXC, (void*)(&num));
		}
	}

	public unsafe static bool isPaint
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaint, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaint, (void*)(&flag));
		}
	}

	public unsafe static int shock_scr
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shock_scr, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shock_scr, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> shock_x
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shock_x, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shock_x, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> shock_y
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shock_y, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shock_y, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int tDoubleDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tDoubleDelay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tDoubleDelay)) = num;
		}
	}

	public unsafe static Image arrow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int yTouchBar
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yTouchBar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yTouchBar, (void*)(&num));
		}
	}

	public unsafe static int xC
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xC, (void*)(&num));
		}
	}

	public unsafe static int yC
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yC, (void*)(&num));
		}
	}

	public unsafe static int xL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xL, (void*)(&num));
		}
	}

	public unsafe static int yL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yL, (void*)(&num));
		}
	}

	public unsafe int xR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xR)) = num;
		}
	}

	public unsafe int yR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yR)) = num;
		}
	}

	public unsafe static int xU
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xU, (void*)(&num));
		}
	}

	public unsafe static int yU
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yU, (void*)(&num));
		}
	}

	public unsafe static int xF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xF, (void*)(&num));
		}
	}

	public unsafe static int yF
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yF, (void*)(&num));
		}
	}

	public unsafe static int xHP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xHP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xHP, (void*)(&num));
		}
	}

	public unsafe static int yHP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yHP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yHP, (void*)(&num));
		}
	}

	public unsafe static int xTG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xTG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xTG, (void*)(&num));
		}
	}

	public unsafe static int yTG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yTG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yTG, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> xS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> yS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int xSkill
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xSkill, (void*)(&num));
		}
	}

	public unsafe static int ySkill
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ySkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ySkill, (void*)(&num));
		}
	}

	public unsafe static int padSkill
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_padSkill, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_padSkill, (void*)(&num));
		}
	}

	public unsafe long dMP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dMP);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dMP)) = num;
		}
	}

	public unsafe int twMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twMp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twMp)) = num;
		}
	}

	public unsafe bool isInjureMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInjureMp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInjureMp)) = flag;
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

	public unsafe long curr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curr);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curr)) = num;
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

	public unsafe int secondVS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondVS);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondVS)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> idVS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idVS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idVS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray flyTextString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextString, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextString, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTextX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTextY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTextYTo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextYTo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextYTo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTextDx
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextDx, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextDx, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTextDy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextDy, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextDy, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTextState
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextState, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTextColor
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTextColor, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTextColor, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> flyTime
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_flyTime, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_flyTime, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> splashX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_splashX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_splashX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> splashY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_splashY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_splashY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> splashState
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_splashState, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_splashState, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> splashF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_splashF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_splashF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> splashDir
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_splashDir, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_splashDir, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgSplash
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSplash, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSplash, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int cmdBarX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarX, (void*)(&num));
		}
	}

	public unsafe static int cmdBarY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarY, (void*)(&num));
		}
	}

	public unsafe static int cmdBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarW, (void*)(&num));
		}
	}

	public unsafe static int cmdBarLeftW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarLeftW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarLeftW, (void*)(&num));
		}
	}

	public unsafe static int cmdBarRightW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarRightW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarRightW, (void*)(&num));
		}
	}

	public unsafe static int cmdBarCenterW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdBarCenterW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdBarCenterW, (void*)(&num));
		}
	}

	public unsafe static int hpBarX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarX, (void*)(&num));
		}
	}

	public unsafe static int hpBarY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarY, (void*)(&num));
		}
	}

	public unsafe static int hpBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarW, (void*)(&num));
		}
	}

	public unsafe static int spBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_spBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_spBarW, (void*)(&num));
		}
	}

	public unsafe static int mpBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mpBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mpBarW, (void*)(&num));
		}
	}

	public unsafe static int expBarW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_expBarW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_expBarW, (void*)(&num));
		}
	}

	public unsafe static int lvPosX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lvPosX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lvPosX, (void*)(&num));
		}
	}

	public unsafe static int moneyPosX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_moneyPosX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_moneyPosX, (void*)(&num));
		}
	}

	public unsafe static int hpBarH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hpBarH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hpBarH, (void*)(&num));
		}
	}

	public unsafe static int girlHPBarY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_girlHPBarY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_girlHPBarY, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgCmdBar
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgCmdBar, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgCmdBar, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int imgScrW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgScrW);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgScrW)) = num;
		}
	}

	public unsafe static int popupY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_popupY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_popupY, (void*)(&num));
		}
	}

	public unsafe static int popupX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_popupX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_popupX, (void*)(&num));
		}
	}

	public unsafe static int isborderIndex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isborderIndex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isborderIndex, (void*)(&num));
		}
	}

	public unsafe static int isselectedRow
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isselectedRow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isselectedRow, (void*)(&num));
		}
	}

	public unsafe static Image imgNolearn
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgNolearn, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgNolearn, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe int cmxp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxp)) = num;
		}
	}

	public unsafe int cmvxp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvxp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvxp)) = num;
		}
	}

	public unsafe int cmdxp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdxp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdxp)) = num;
		}
	}

	public unsafe int cmxLimp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxLimp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxLimp)) = num;
		}
	}

	public unsafe int cmyLimp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyLimp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyLimp)) = num;
		}
	}

	public unsafe int cmyp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyp)) = num;
		}
	}

	public unsafe int cmvyp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvyp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvyp)) = num;
		}
	}

	public unsafe int cmdyp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdyp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdyp)) = num;
		}
	}

	public unsafe int indexTiemNang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexTiemNang);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexTiemNang)) = num;
		}
	}

	public unsafe string alertURL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertURL);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alertURL)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string fnick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fnick);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fnick)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int xstart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xstart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xstart, (void*)(&num));
		}
	}

	public unsafe static int ystart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ystart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ystart, (void*)(&num));
		}
	}

	public unsafe static int popupW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_popupW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_popupW, (void*)(&num));
		}
	}

	public unsafe static int popupH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_popupH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_popupH, (void*)(&num));
		}
	}

	public unsafe static int cmySK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmySK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmySK, (void*)(&num));
		}
	}

	public unsafe static int cmtoYSK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmtoYSK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmtoYSK, (void*)(&num));
		}
	}

	public unsafe static int cmdySK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdySK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdySK, (void*)(&num));
		}
	}

	public unsafe static int cmvySK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmvySK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmvySK, (void*)(&num));
		}
	}

	public unsafe static int cmyLimSK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmyLimSK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmyLimSK, (void*)(&num));
		}
	}

	public unsafe static int columns
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_columns, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_columns, (void*)(&num));
		}
	}

	public unsafe static int rows
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rows, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rows, (void*)(&num));
		}
	}

	public unsafe int totalRowInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalRowInfo);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_totalRowInfo)) = num;
		}
	}

	public unsafe int ypaintKill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ypaintKill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ypaintKill)) = num;
		}
	}

	public unsafe int ylimUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ylimUp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ylimUp)) = num;
		}
	}

	public unsafe int ylimDow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ylimDow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ylimDow)) = num;
		}
	}

	public unsafe int yPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPaint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPaint)) = num;
		}
	}

	public unsafe static int indexEff
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indexEff, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indexEff, (void*)(&num));
		}
	}

	public unsafe static EffectCharPaint effUpok
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_effUpok, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectCharPaint>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_effUpok, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectCharPaint));
		}
	}

	public unsafe static int inforX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inforX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inforX, (void*)(&num));
		}
	}

	public unsafe static int inforY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inforY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inforY, (void*)(&num));
		}
	}

	public unsafe static int inforW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inforW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inforW, (void*)(&num));
		}
	}

	public unsafe static int inforH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inforH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inforH, (void*)(&num));
		}
	}

	public unsafe Command cmdDead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdDead);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdDead)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe static bool notPaint
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_notPaint, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_notPaint, (void*)(&flag));
		}
	}

	public unsafe static bool isPing
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPing, (void*)(&flag));
		}
	}

	public unsafe static int INFO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INFO, (void*)(&num));
		}
	}

	public unsafe static int STORE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STORE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STORE, (void*)(&num));
		}
	}

	public unsafe static int ZONE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ZONE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ZONE, (void*)(&num));
		}
	}

	public unsafe static int UPGRADE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UPGRADE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UPGRADE, (void*)(&num));
		}
	}

	public unsafe int Hitem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hitem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Hitem)) = num;
		}
	}

	public unsafe int maxSizeRow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSizeRow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSizeRow)) = num;
		}
	}

	public unsafe int isTranKyNang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTranKyNang);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTranKyNang)) = num;
		}
	}

	public unsafe bool isTran
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTran);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTran)) = flag;
		}
	}

	public unsafe int cmY_Old
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmY_Old);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmY_Old)) = num;
		}
	}

	public unsafe int cmX_Old
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmX_Old);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmX_Old)) = num;
		}
	}

	public unsafe PopUpYesNo popUpYesNo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_popUpYesNo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PopUpYesNo>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_popUpYesNo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)popUpYesNo));
		}
	}

	public unsafe static MyVector vChatVip
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vChatVip, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vChatVip, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static int vBig
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vBig, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vBig, (void*)(&num));
		}
	}

	public unsafe bool isFireWorks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFireWorks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFireWorks)) = flag;
		}
	}

	public unsafe Il2CppStructArray<int> winnumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winnumber);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_winnumber)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> randomNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomNumber);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomNumber)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> tMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> moveCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveCount);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveCount)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> delayMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayMove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayMove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int moveIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveIndex)) = num;
		}
	}

	public unsafe bool isWin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWin);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWin)) = flag;
		}
	}

	public unsafe string strFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strFinish);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strFinish)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int tShow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tShow);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tShow)) = num;
		}
	}

	public unsafe int xChatVip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xChatVip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xChatVip)) = num;
		}
	}

	public unsafe int currChatWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currChatWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currChatWidth)) = num;
		}
	}

	public unsafe bool startChat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startChat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startChat)) = flag;
		}
	}

	public unsafe sbyte percentMabu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_percentMabu);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_percentMabu)) = b;
		}
	}

	public unsafe bool mabuEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mabuEff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mabuEff)) = flag;
		}
	}

	public unsafe int tMabuEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMabuEff);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tMabuEff)) = num;
		}
	}

	public unsafe static bool isPaintChatVip
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintChatVip, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintChatVip, (void*)(&flag));
		}
	}

	public unsafe static sbyte mabuPercent
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mabuPercent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mabuPercent, (void*)(&b));
		}
	}

	public unsafe static sbyte isNewMember
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isNewMember, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isNewMember, (void*)(&b));
		}
	}

	public unsafe string yourNumber
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yourNumber);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yourNumber)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppStringArray strPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strPaint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strPaint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgHP_NEW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHP_NEW, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHP_NEW, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static InfoPhuBan phuban_Info
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_phuban_Info, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InfoPhuBan>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_phuban_Info, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)infoPhuBan));
		}
	}

	public unsafe static FrameImage fra_PVE_Bar_0
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fra_PVE_Bar_0, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fra_PVE_Bar_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe static FrameImage fra_PVE_Bar_1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fra_PVE_Bar_1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fra_PVE_Bar_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe static Image imgVS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgVS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgVS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgBall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgBall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgBall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgKhung
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgKhung, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgKhung, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int yClick
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yClick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yClick, (void*)(&num));
		}
	}

	public unsafe static int head
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_head, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_head, (void*)(&num));
		}
	}

	public unsafe static int body
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_body, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_body, (void*)(&num));
		}
	}

	public unsafe static int leg
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_leg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_leg, (void*)(&num));
		}
	}

	static GameScr()
	{
		Il2CppClassPointerStore<GameScr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameScr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameScr>.NativeClassPtr);
		NativeFieldInfoPtr_isPaintOther = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintOther");
		NativeFieldInfoPtr_textTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "textTime");
		NativeFieldInfoPtr_isLoadAllData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isLoadAllData");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_gW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gW");
		NativeFieldInfoPtr_gH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gH");
		NativeFieldInfoPtr_gW2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gW2");
		NativeFieldInfoPtr_gssw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gssw");
		NativeFieldInfoPtr_gssh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gssh");
		NativeFieldInfoPtr_gH34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gH34");
		NativeFieldInfoPtr_gW3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gW3");
		NativeFieldInfoPtr_gH3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gH3");
		NativeFieldInfoPtr_gH23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gH23");
		NativeFieldInfoPtr_gW23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gW23");
		NativeFieldInfoPtr_gH2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gH2");
		NativeFieldInfoPtr_csPadMaxH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "csPadMaxH");
		NativeFieldInfoPtr_cmdBarH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBarH");
		NativeFieldInfoPtr_gW34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gW34");
		NativeFieldInfoPtr_gW6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gW6");
		NativeFieldInfoPtr_gH6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gH6");
		NativeFieldInfoPtr_cmx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmx");
		NativeFieldInfoPtr_cmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmy");
		NativeFieldInfoPtr_cmdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdx");
		NativeFieldInfoPtr_cmdy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdy");
		NativeFieldInfoPtr_cmvx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmvx");
		NativeFieldInfoPtr_cmvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmvy");
		NativeFieldInfoPtr_cmtoX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmtoX");
		NativeFieldInfoPtr_cmtoY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmtoY");
		NativeFieldInfoPtr_cmxLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmxLim");
		NativeFieldInfoPtr_cmyLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmyLim");
		NativeFieldInfoPtr_gssx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gssx");
		NativeFieldInfoPtr_gssy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gssy");
		NativeFieldInfoPtr_gssxe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gssxe");
		NativeFieldInfoPtr_gssye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gssye");
		NativeFieldInfoPtr_cmdback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdback");
		NativeFieldInfoPtr_cmdBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBag");
		NativeFieldInfoPtr_cmdSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdSkill");
		NativeFieldInfoPtr_cmdTiemnang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdTiemnang");
		NativeFieldInfoPtr_cmdtrangbi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdtrangbi");
		NativeFieldInfoPtr_cmdInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdInfo");
		NativeFieldInfoPtr_cmdFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdFocus");
		NativeFieldInfoPtr_cmdFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdFire");
		NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "d");
		NativeFieldInfoPtr_hpPotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "hpPotion");
		NativeFieldInfoPtr_sks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "sks");
		NativeFieldInfoPtr_arrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "arrs");
		NativeFieldInfoPtr_darts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "darts");
		NativeFieldInfoPtr_parts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "parts");
		NativeFieldInfoPtr_efs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "efs");
		NativeFieldInfoPtr_lockTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lockTick");
		NativeFieldInfoPtr_moveUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "moveUp");
		NativeFieldInfoPtr_moveDow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "moveDow");
		NativeFieldInfoPtr_idTypeTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "idTypeTask");
		NativeFieldInfoPtr_isstarOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isstarOpen");
		NativeFieldInfoPtr_isChangeSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isChangeSkill");
		NativeFieldInfoPtr_vClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vClan");
		NativeFieldInfoPtr_vPtMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vPtMap");
		NativeFieldInfoPtr_vFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vFriend");
		NativeFieldInfoPtr_vEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vEnemies");
		NativeFieldInfoPtr_vCharInMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vCharInMap");
		NativeFieldInfoPtr_vItemMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vItemMap");
		NativeFieldInfoPtr_vMobAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vMobAttack");
		NativeFieldInfoPtr_vSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vSet");
		NativeFieldInfoPtr_vMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vMob");
		NativeFieldInfoPtr_vNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vNpc");
		NativeFieldInfoPtr_vFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vFlag");
		NativeFieldInfoPtr_nClasss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "nClasss");
		NativeFieldInfoPtr_indexSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexSize");
		NativeFieldInfoPtr_indexTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexTitle");
		NativeFieldInfoPtr_indexSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexSelect");
		NativeFieldInfoPtr_indexRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexRow");
		NativeFieldInfoPtr_indexRowMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexRowMax");
		NativeFieldInfoPtr_indexMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexMenu");
		NativeFieldInfoPtr_itemFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "itemFocus");
		NativeFieldInfoPtr_iOptionTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "iOptionTemplates");
		NativeFieldInfoPtr_sOptionTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "sOptionTemplates");
		NativeFieldInfoPtr_scrInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "scrInfo");
		NativeFieldInfoPtr_scrMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "scrMain");
		NativeFieldInfoPtr_vItemUpGrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vItemUpGrade");
		NativeFieldInfoPtr_isTypeXu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isTypeXu");
		NativeFieldInfoPtr_isViewNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isViewNext");
		NativeFieldInfoPtr_isViewClanMemOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isViewClanMemOnline");
		NativeFieldInfoPtr_isViewClanInvite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isViewClanInvite");
		NativeFieldInfoPtr_isChop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isChop");
		NativeFieldInfoPtr_titleInputText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "titleInputText");
		NativeFieldInfoPtr_tickMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tickMove");
		NativeFieldInfoPtr_isPaintAlert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintAlert");
		NativeFieldInfoPtr_isPaintTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintTask");
		NativeFieldInfoPtr_isPaintTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintTeam");
		NativeFieldInfoPtr_isPaintFindTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintFindTeam");
		NativeFieldInfoPtr_isPaintFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintFriend");
		NativeFieldInfoPtr_isPaintEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintEnemies");
		NativeFieldInfoPtr_isPaintItemInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintItemInfo");
		NativeFieldInfoPtr_isHaveSelectSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isHaveSelectSkill");
		NativeFieldInfoPtr_isPaintSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintSkill");
		NativeFieldInfoPtr_isPaintInfoMe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintInfoMe");
		NativeFieldInfoPtr_isPaintStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintStore");
		NativeFieldInfoPtr_isPaintNonNam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintNonNam");
		NativeFieldInfoPtr_isPaintNonNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintNonNu");
		NativeFieldInfoPtr_isPaintAoNam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintAoNam");
		NativeFieldInfoPtr_isPaintAoNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintAoNu");
		NativeFieldInfoPtr_isPaintGangTayNam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintGangTayNam");
		NativeFieldInfoPtr_isPaintGangTayNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintGangTayNu");
		NativeFieldInfoPtr_isPaintQuanNam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintQuanNam");
		NativeFieldInfoPtr_isPaintQuanNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintQuanNu");
		NativeFieldInfoPtr_isPaintGiayNam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintGiayNam");
		NativeFieldInfoPtr_isPaintGiayNu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintGiayNu");
		NativeFieldInfoPtr_isPaintLien = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintLien");
		NativeFieldInfoPtr_isPaintNhan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintNhan");
		NativeFieldInfoPtr_isPaintNgocBoi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintNgocBoi");
		NativeFieldInfoPtr_isPaintPhu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintPhu");
		NativeFieldInfoPtr_isPaintWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintWeapon");
		NativeFieldInfoPtr_isPaintStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintStack");
		NativeFieldInfoPtr_isPaintStackLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintStackLock");
		NativeFieldInfoPtr_isPaintGrocery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintGrocery");
		NativeFieldInfoPtr_isPaintGroceryLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintGroceryLock");
		NativeFieldInfoPtr_isPaintUpGrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintUpGrade");
		NativeFieldInfoPtr_isPaintConvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintConvert");
		NativeFieldInfoPtr_isPaintUpGradeGold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintUpGradeGold");
		NativeFieldInfoPtr_isPaintUpPearl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintUpPearl");
		NativeFieldInfoPtr_isPaintBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintBox");
		NativeFieldInfoPtr_isPaintSplit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintSplit");
		NativeFieldInfoPtr_isPaintCharInMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintCharInMap");
		NativeFieldInfoPtr_isPaintTrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintTrade");
		NativeFieldInfoPtr_isPaintZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintZone");
		NativeFieldInfoPtr_isPaintMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintMessage");
		NativeFieldInfoPtr_isPaintClan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintClan");
		NativeFieldInfoPtr_isRequestMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isRequestMember");
		NativeFieldInfoPtr_currentCharViewInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "currentCharViewInfo");
		NativeFieldInfoPtr_exps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "exps");
		NativeFieldInfoPtr_crystals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "crystals");
		NativeFieldInfoPtr_upClothe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "upClothe");
		NativeFieldInfoPtr_upAdorn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "upAdorn");
		NativeFieldInfoPtr_upWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "upWeapon");
		NativeFieldInfoPtr_coinUpCrystals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "coinUpCrystals");
		NativeFieldInfoPtr_coinUpClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "coinUpClothes");
		NativeFieldInfoPtr_coinUpAdorns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "coinUpAdorns");
		NativeFieldInfoPtr_coinUpWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "coinUpWeapons");
		NativeFieldInfoPtr_maxPercents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "maxPercents");
		NativeFieldInfoPtr_goldUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "goldUps");
		NativeFieldInfoPtr_tMenuDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tMenuDelay");
		NativeFieldInfoPtr_zoneCol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "zoneCol");
		NativeFieldInfoPtr_zones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "zones");
		NativeFieldInfoPtr_pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "pts");
		NativeFieldInfoPtr_numPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "numPlayer");
		NativeFieldInfoPtr_maxPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "maxPlayer");
		NativeFieldInfoPtr_rank1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "rank1");
		NativeFieldInfoPtr_rank2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "rank2");
		NativeFieldInfoPtr_rankName1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "rankName1");
		NativeFieldInfoPtr_rankName2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "rankName2");
		NativeFieldInfoPtr_typeTrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "typeTrade");
		NativeFieldInfoPtr_typeTradeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "typeTradeOrder");
		NativeFieldInfoPtr_coinTrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "coinTrade");
		NativeFieldInfoPtr_coinTradeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "coinTradeOrder");
		NativeFieldInfoPtr_timeTrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "timeTrade");
		NativeFieldInfoPtr_indexItemUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexItemUse");
		NativeFieldInfoPtr_cLastFocusID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cLastFocusID");
		NativeFieldInfoPtr_cPreFocusID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cPreFocusID");
		NativeFieldInfoPtr_isLockKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isLockKey");
		NativeFieldInfoPtr_tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tasks");
		NativeFieldInfoPtr_mapTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "mapTasks");
		NativeFieldInfoPtr_imgRoomStat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgRoomStat");
		NativeFieldInfoPtr_frBarPow0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "frBarPow0");
		NativeFieldInfoPtr_frBarPow1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "frBarPow1");
		NativeFieldInfoPtr_frBarPow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "frBarPow2");
		NativeFieldInfoPtr_frBarPow20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "frBarPow20");
		NativeFieldInfoPtr_frBarPow21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "frBarPow21");
		NativeFieldInfoPtr_frBarPow22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "frBarPow22");
		NativeFieldInfoPtr_texts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "texts");
		NativeFieldInfoPtr_textsTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "textsTitle");
		NativeFieldInfoPtr_vcData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vcData");
		NativeFieldInfoPtr_vcMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vcMap");
		NativeFieldInfoPtr_vcSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vcSkill");
		NativeFieldInfoPtr_vcItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vcItem");
		NativeFieldInfoPtr_vsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vsData");
		NativeFieldInfoPtr_vsMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vsMap");
		NativeFieldInfoPtr_vsSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vsSkill");
		NativeFieldInfoPtr_vsItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vsItem");
		NativeFieldInfoPtr_vcTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vcTask");
		NativeFieldInfoPtr_imgArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgArrow");
		NativeFieldInfoPtr_imgArrow2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgArrow2");
		NativeFieldInfoPtr_imgChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgChat");
		NativeFieldInfoPtr_imgChat2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgChat2");
		NativeFieldInfoPtr_imgMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgMenu");
		NativeFieldInfoPtr_imgFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgFocus");
		NativeFieldInfoPtr_imgFocus2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgFocus2");
		NativeFieldInfoPtr_imgSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgSkill");
		NativeFieldInfoPtr_imgSkill2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgSkill2");
		NativeFieldInfoPtr_imgHP1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP1");
		NativeFieldInfoPtr_imgHP2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP2");
		NativeFieldInfoPtr_imgHP3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP3");
		NativeFieldInfoPtr_imgHP4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP4");
		NativeFieldInfoPtr_imgFire0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgFire0");
		NativeFieldInfoPtr_imgFire1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgFire1");
		NativeFieldInfoPtr_imgLbtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgLbtn");
		NativeFieldInfoPtr_imgLbtnFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgLbtnFocus");
		NativeFieldInfoPtr_imgLbtn2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgLbtn2");
		NativeFieldInfoPtr_imgLbtnFocus2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgLbtnFocus2");
		NativeFieldInfoPtr_imgAnalog1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgAnalog1");
		NativeFieldInfoPtr_imgAnalog2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgAnalog2");
		NativeFieldInfoPtr_tradeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tradeName");
		NativeFieldInfoPtr_tradeItemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tradeItemName");
		NativeFieldInfoPtr_timeLengthMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "timeLengthMap");
		NativeFieldInfoPtr_timeStartMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "timeStartMap");
		NativeFieldInfoPtr_typeViewInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "typeViewInfo");
		NativeFieldInfoPtr_typeActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "typeActive");
		NativeFieldInfoPtr_info1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "info1");
		NativeFieldInfoPtr_info2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "info2");
		NativeFieldInfoPtr_imgPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgPanel");
		NativeFieldInfoPtr_imgPanel2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgPanel2");
		NativeFieldInfoPtr_imgHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP");
		NativeFieldInfoPtr_imgMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgMP");
		NativeFieldInfoPtr_imgSP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgSP");
		NativeFieldInfoPtr_imgHPLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHPLost");
		NativeFieldInfoPtr_imgMPLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgMPLost");
		NativeFieldInfoPtr_imgHP_tm_do = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP_tm_do");
		NativeFieldInfoPtr_imgHP_tm_vang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP_tm_vang");
		NativeFieldInfoPtr_imgHP_tm_xam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP_tm_xam");
		NativeFieldInfoPtr_imgHP_tm_xanh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP_tm_xanh");
		NativeFieldInfoPtr_mobCapcha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "mobCapcha");
		NativeFieldInfoPtr_magicTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "magicTree");
		NativeFieldInfoPtr_countEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "countEff");
		NativeFieldInfoPtr_gamePad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "gamePad");
		NativeFieldInfoPtr_imgChatPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgChatPC");
		NativeFieldInfoPtr_imgChatsPC2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgChatsPC2");
		NativeFieldInfoPtr_isAnalog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isAnalog");
		NativeFieldInfoPtr_isUseTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isUseTouch");
		NativeFieldInfoPtr_numSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "numSkill");
		NativeFieldInfoPtr_numSkill_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "numSkill_2");
		NativeFieldInfoPtr_keySkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "keySkill");
		NativeFieldInfoPtr_onScreenSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "onScreenSkill");
		NativeFieldInfoPtr_cmdMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdMenu");
		NativeFieldInfoPtr_firstY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "firstY");
		NativeFieldInfoPtr_wSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "wSkill");
		NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "deltaTime");
		NativeFieldInfoPtr_isPointerDowning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPointerDowning");
		NativeFieldInfoPtr_isChangingCameraMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isChangingCameraMode");
		NativeFieldInfoPtr_ptLastDownX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ptLastDownX");
		NativeFieldInfoPtr_ptLastDownY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ptLastDownY");
		NativeFieldInfoPtr_ptFirstDownX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ptFirstDownX");
		NativeFieldInfoPtr_ptFirstDownY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ptFirstDownY");
		NativeFieldInfoPtr_ptDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ptDownTime");
		NativeFieldInfoPtr_disableSingleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "disableSingleClick");
		NativeFieldInfoPtr_lastSingleClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastSingleClick");
		NativeFieldInfoPtr_clickMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "clickMoving");
		NativeFieldInfoPtr_clickOnTileTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "clickOnTileTop");
		NativeFieldInfoPtr_clickMovingRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "clickMovingRed");
		NativeFieldInfoPtr_clickToX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "clickToX");
		NativeFieldInfoPtr_clickToY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "clickToY");
		NativeFieldInfoPtr_lastClickCMX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastClickCMX");
		NativeFieldInfoPtr_lastClickCMY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastClickCMY");
		NativeFieldInfoPtr_clickMovingP1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "clickMovingP1");
		NativeFieldInfoPtr_clickMovingTimeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "clickMovingTimeOut");
		NativeFieldInfoPtr_lastMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastMove");
		NativeFieldInfoPtr_isNewClanMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isNewClanMessage");
		NativeFieldInfoPtr_lastFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastFire");
		NativeFieldInfoPtr_lastUsePotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastUsePotion");
		NativeFieldInfoPtr_auto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "auto");
		NativeFieldInfoPtr_dem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "dem");
		NativeFieldInfoPtr_strTam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "strTam");
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "a");
		NativeFieldInfoPtr_isFreez = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isFreez");
		NativeFieldInfoPtr_isUseFreez = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isUseFreez");
		NativeFieldInfoPtr_imgTrans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgTrans");
		NativeFieldInfoPtr_isRongThanXuatHien = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isRongThanXuatHien");
		NativeFieldInfoPtr_isRongNamek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isRongNamek");
		NativeFieldInfoPtr_isSuperPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isSuperPower");
		NativeFieldInfoPtr_tPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tPower");
		NativeFieldInfoPtr_xPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xPower");
		NativeFieldInfoPtr_yPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yPower");
		NativeFieldInfoPtr_dxPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "dxPower");
		NativeFieldInfoPtr_activeRongThan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "activeRongThan");
		NativeFieldInfoPtr_isMeCallRongThan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isMeCallRongThan");
		NativeFieldInfoPtr_mautroi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "mautroi");
		NativeFieldInfoPtr_mapRID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "mapRID");
		NativeFieldInfoPtr_zoneRID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "zoneRID");
		NativeFieldInfoPtr_bgRID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "bgRID");
		NativeFieldInfoPtr_tam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tam");
		NativeFieldInfoPtr_isAutoPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isAutoPlay");
		NativeFieldInfoPtr_canAutoPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "canAutoPlay");
		NativeFieldInfoPtr_isChangeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isChangeZone");
		NativeFieldInfoPtr_timeSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "timeSkill");
		NativeFieldInfoPtr_nSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "nSkill");
		NativeFieldInfoPtr_selectedIndexSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "selectedIndexSkill");
		NativeFieldInfoPtr_lastSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastSkill");
		NativeFieldInfoPtr_doSeleckSkillFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "doSeleckSkillFlag");
		NativeFieldInfoPtr_strCapcha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "strCapcha");
		NativeFieldInfoPtr_longPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "longPress");
		NativeFieldInfoPtr_move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "move");
		NativeFieldInfoPtr_flareFindFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flareFindFocus");
		NativeFieldInfoPtr_flareTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flareTime");
		NativeFieldInfoPtr_keyTouchSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "keyTouchSkill");
		NativeFieldInfoPtr_lastSendUpdatePostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastSendUpdatePostion");
		NativeFieldInfoPtr_lastTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastTick");
		NativeFieldInfoPtr_currTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "currTick");
		NativeFieldInfoPtr_timeAuto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "timeAuto");
		NativeFieldInfoPtr_lastXS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lastXS");
		NativeFieldInfoPtr_currXS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "currXS");
		NativeFieldInfoPtr_secondXS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "secondXS");
		NativeFieldInfoPtr_runArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "runArrow");
		NativeFieldInfoPtr_isPaintRada = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintRada");
		NativeFieldInfoPtr_imgNut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgNut");
		NativeFieldInfoPtr_imgNutF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgNutF");
		NativeFieldInfoPtr_keyCapcha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "keyCapcha");
		NativeFieldInfoPtr_imgCapcha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgCapcha");
		NativeFieldInfoPtr_keyInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "keyInput");
		NativeFieldInfoPtr_disXC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "disXC");
		NativeFieldInfoPtr_isPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaint");
		NativeFieldInfoPtr_shock_scr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "shock_scr");
		NativeFieldInfoPtr_shock_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "shock_x");
		NativeFieldInfoPtr_shock_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "shock_y");
		NativeFieldInfoPtr_tDoubleDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tDoubleDelay");
		NativeFieldInfoPtr_arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "arrow");
		NativeFieldInfoPtr_yTouchBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yTouchBar");
		NativeFieldInfoPtr_xC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xC");
		NativeFieldInfoPtr_yC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yC");
		NativeFieldInfoPtr_xL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xL");
		NativeFieldInfoPtr_yL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yL");
		NativeFieldInfoPtr_xR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xR");
		NativeFieldInfoPtr_yR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yR");
		NativeFieldInfoPtr_xU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xU");
		NativeFieldInfoPtr_yU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yU");
		NativeFieldInfoPtr_xF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xF");
		NativeFieldInfoPtr_yF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yF");
		NativeFieldInfoPtr_xHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xHP");
		NativeFieldInfoPtr_yHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yHP");
		NativeFieldInfoPtr_xTG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xTG");
		NativeFieldInfoPtr_yTG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yTG");
		NativeFieldInfoPtr_xS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xS");
		NativeFieldInfoPtr_yS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yS");
		NativeFieldInfoPtr_xSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xSkill");
		NativeFieldInfoPtr_ySkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ySkill");
		NativeFieldInfoPtr_padSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "padSkill");
		NativeFieldInfoPtr_dMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "dMP");
		NativeFieldInfoPtr_twMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "twMp");
		NativeFieldInfoPtr_isInjureMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isInjureMp");
		NativeFieldInfoPtr_dHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "dHP");
		NativeFieldInfoPtr_twHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "twHp");
		NativeFieldInfoPtr_isInjureHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isInjureHp");
		NativeFieldInfoPtr_curr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "curr");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "last");
		NativeFieldInfoPtr_secondVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "secondVS");
		NativeFieldInfoPtr_idVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "idVS");
		NativeFieldInfoPtr_flyTextString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextString");
		NativeFieldInfoPtr_flyTextX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextX");
		NativeFieldInfoPtr_flyTextY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextY");
		NativeFieldInfoPtr_flyTextYTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextYTo");
		NativeFieldInfoPtr_flyTextDx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextDx");
		NativeFieldInfoPtr_flyTextDy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextDy");
		NativeFieldInfoPtr_flyTextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextState");
		NativeFieldInfoPtr_flyTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTextColor");
		NativeFieldInfoPtr_flyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "flyTime");
		NativeFieldInfoPtr_splashX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "splashX");
		NativeFieldInfoPtr_splashY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "splashY");
		NativeFieldInfoPtr_splashState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "splashState");
		NativeFieldInfoPtr_splashF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "splashF");
		NativeFieldInfoPtr_splashDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "splashDir");
		NativeFieldInfoPtr_imgSplash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgSplash");
		NativeFieldInfoPtr_cmdBarX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBarX");
		NativeFieldInfoPtr_cmdBarY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBarY");
		NativeFieldInfoPtr_cmdBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBarW");
		NativeFieldInfoPtr_cmdBarLeftW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBarLeftW");
		NativeFieldInfoPtr_cmdBarRightW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBarRightW");
		NativeFieldInfoPtr_cmdBarCenterW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdBarCenterW");
		NativeFieldInfoPtr_hpBarX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "hpBarX");
		NativeFieldInfoPtr_hpBarY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "hpBarY");
		NativeFieldInfoPtr_hpBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "hpBarW");
		NativeFieldInfoPtr_spBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "spBarW");
		NativeFieldInfoPtr_mpBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "mpBarW");
		NativeFieldInfoPtr_expBarW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "expBarW");
		NativeFieldInfoPtr_lvPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "lvPosX");
		NativeFieldInfoPtr_moneyPosX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "moneyPosX");
		NativeFieldInfoPtr_hpBarH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "hpBarH");
		NativeFieldInfoPtr_girlHPBarY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "girlHPBarY");
		NativeFieldInfoPtr_imgCmdBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgCmdBar");
		NativeFieldInfoPtr_imgScrW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgScrW");
		NativeFieldInfoPtr_popupY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "popupY");
		NativeFieldInfoPtr_popupX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "popupX");
		NativeFieldInfoPtr_isborderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isborderIndex");
		NativeFieldInfoPtr_isselectedRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isselectedRow");
		NativeFieldInfoPtr_imgNolearn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgNolearn");
		NativeFieldInfoPtr_cmxp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmxp");
		NativeFieldInfoPtr_cmvxp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmvxp");
		NativeFieldInfoPtr_cmdxp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdxp");
		NativeFieldInfoPtr_cmxLimp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmxLimp");
		NativeFieldInfoPtr_cmyLimp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmyLimp");
		NativeFieldInfoPtr_cmyp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmyp");
		NativeFieldInfoPtr_cmvyp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmvyp");
		NativeFieldInfoPtr_cmdyp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdyp");
		NativeFieldInfoPtr_indexTiemNang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexTiemNang");
		NativeFieldInfoPtr_alertURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "alertURL");
		NativeFieldInfoPtr_fnick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "fnick");
		NativeFieldInfoPtr_xstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xstart");
		NativeFieldInfoPtr_ystart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ystart");
		NativeFieldInfoPtr_popupW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "popupW");
		NativeFieldInfoPtr_popupH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "popupH");
		NativeFieldInfoPtr_cmySK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmySK");
		NativeFieldInfoPtr_cmtoYSK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmtoYSK");
		NativeFieldInfoPtr_cmdySK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdySK");
		NativeFieldInfoPtr_cmvySK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmvySK");
		NativeFieldInfoPtr_cmyLimSK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmyLimSK");
		NativeFieldInfoPtr_columns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "columns");
		NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "rows");
		NativeFieldInfoPtr_totalRowInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "totalRowInfo");
		NativeFieldInfoPtr_ypaintKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ypaintKill");
		NativeFieldInfoPtr_ylimUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ylimUp");
		NativeFieldInfoPtr_ylimDow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ylimDow");
		NativeFieldInfoPtr_yPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yPaint");
		NativeFieldInfoPtr_indexEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "indexEff");
		NativeFieldInfoPtr_effUpok = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "effUpok");
		NativeFieldInfoPtr_inforX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "inforX");
		NativeFieldInfoPtr_inforY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "inforY");
		NativeFieldInfoPtr_inforW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "inforW");
		NativeFieldInfoPtr_inforH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "inforH");
		NativeFieldInfoPtr_cmdDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmdDead");
		NativeFieldInfoPtr_notPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "notPaint");
		NativeFieldInfoPtr_isPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPing");
		NativeFieldInfoPtr_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "INFO");
		NativeFieldInfoPtr_STORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "STORE");
		NativeFieldInfoPtr_ZONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "ZONE");
		NativeFieldInfoPtr_UPGRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "UPGRADE");
		NativeFieldInfoPtr_Hitem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "Hitem");
		NativeFieldInfoPtr_maxSizeRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "maxSizeRow");
		NativeFieldInfoPtr_isTranKyNang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isTranKyNang");
		NativeFieldInfoPtr_isTran = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isTran");
		NativeFieldInfoPtr_cmY_Old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmY_Old");
		NativeFieldInfoPtr_cmX_Old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "cmX_Old");
		NativeFieldInfoPtr_popUpYesNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "popUpYesNo");
		NativeFieldInfoPtr_vChatVip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vChatVip");
		NativeFieldInfoPtr_vBig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "vBig");
		NativeFieldInfoPtr_isFireWorks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isFireWorks");
		NativeFieldInfoPtr_winnumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "winnumber");
		NativeFieldInfoPtr_randomNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "randomNumber");
		NativeFieldInfoPtr_tMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tMove");
		NativeFieldInfoPtr_moveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "moveCount");
		NativeFieldInfoPtr_delayMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "delayMove");
		NativeFieldInfoPtr_moveIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "moveIndex");
		NativeFieldInfoPtr_isWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isWin");
		NativeFieldInfoPtr_strFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "strFinish");
		NativeFieldInfoPtr_tShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tShow");
		NativeFieldInfoPtr_xChatVip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "xChatVip");
		NativeFieldInfoPtr_currChatWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "currChatWidth");
		NativeFieldInfoPtr_startChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "startChat");
		NativeFieldInfoPtr_percentMabu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "percentMabu");
		NativeFieldInfoPtr_mabuEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "mabuEff");
		NativeFieldInfoPtr_tMabuEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "tMabuEff");
		NativeFieldInfoPtr_isPaintChatVip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isPaintChatVip");
		NativeFieldInfoPtr_mabuPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "mabuPercent");
		NativeFieldInfoPtr_isNewMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "isNewMember");
		NativeFieldInfoPtr_yourNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yourNumber");
		NativeFieldInfoPtr_strPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "strPaint");
		NativeFieldInfoPtr_imgHP_NEW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgHP_NEW");
		NativeFieldInfoPtr_phuban_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "phuban_Info");
		NativeFieldInfoPtr_fra_PVE_Bar_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "fra_PVE_Bar_0");
		NativeFieldInfoPtr_fra_PVE_Bar_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "fra_PVE_Bar_1");
		NativeFieldInfoPtr_imgVS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgVS");
		NativeFieldInfoPtr_imgBall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgBall");
		NativeFieldInfoPtr_imgKhung = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "imgKhung");
		NativeFieldInfoPtr_yClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "yClick");
		NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "head");
		NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "body");
		NativeFieldInfoPtr_leg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameScr>.NativeClassPtr, "leg");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_loadBg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664131);
		NativeMethodInfoPtr_initSelectChar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664132);
		NativeMethodInfoPtr_paintOngMauPercent_Public_Static_Void_Image_Image_Image_Single_Single_Int32_Single_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664133);
		NativeMethodInfoPtr_initTraining_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664134);
		NativeMethodInfoPtr_isMapDocNhan_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664135);
		NativeMethodInfoPtr_isMapFize_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_getMaxExp_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_resetAllvector_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_loadSkillShortcut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_onOSkill_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_onKSkill_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_onCSkill_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_loadDefaultonScreenSkill_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_loadDefaultKeySkill_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_doSetOnScreenSkill_Public_Void_SkillTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_doSetKeySkill_Public_Void_SkillTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_saveonScreenSkillToRMS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_saveKeySkillToRMS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_saveRMSCurrentSkill_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_addSkillShortcut_Public_Void_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_isBagFull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_createConfirm_Public_Void_Il2CppStringArray_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_createMenu_Public_Void_Il2CppStringArray_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_readPart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_readEfect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_readArrow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_readDart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_readSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_gI_Public_Static_GameScr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_clearGameScr_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_loadGameScr_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_doMenuInforMe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_doMenusynthesis_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr_loadCamera_Public_Static_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_setSkillBarPosition_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_updateCamera_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr_testAct_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664168);
		NativeMethodInfoPtr_clanInvite_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664169);
		NativeMethodInfoPtr_playerMenu_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664170);
		NativeMethodInfoPtr_isAttack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664171);
		NativeMethodInfoPtr_isMeCanAttackMob_Public_Boolean_Mob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664172);
		NativeMethodInfoPtr_checkSkillValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664173);
		NativeMethodInfoPtr_checkSkillValid2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664174);
		NativeMethodInfoPtr_resetButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664175);
		NativeMethodInfoPtr_keyPress_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664176);
		NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664177);
		NativeMethodInfoPtr_isVsMap_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664178);
		NativeMethodInfoPtr_checkDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664179);
		NativeMethodInfoPtr_checkClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664180);
		NativeMethodInfoPtr_findClickToItem_Private_IMapObject_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr_inRectangle_Private_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664182);
		NativeMethodInfoPtr_checkSingleClickEarly_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664183);
		NativeMethodInfoPtr_checkDoubleClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664184);
		NativeMethodInfoPtr_checkClickToBotton_Private_Boolean_IMapObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664185);
		NativeMethodInfoPtr_doDoubleClickToObj_Public_Void_IMapObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_checkSingleClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_checkClipTopChatPopUp_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_checkClickToPopup_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_checkClickMoveTo_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_checkAuto_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_doUseHP_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664192);
		NativeMethodInfoPtr_activeSuperPower_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664193);
		NativeMethodInfoPtr_activeRongThanEff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664194);
		NativeMethodInfoPtr_hideRongThanEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664195);
		NativeMethodInfoPtr_doiMauTroi_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664196);
		NativeMethodInfoPtr_callRongThan_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr_hideRongThan_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664198);
		NativeMethodInfoPtr_autoPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664199);
		NativeMethodInfoPtr_doFire_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664200);
		NativeMethodInfoPtr_askToPick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664201);
		NativeMethodInfoPtr_pickItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664202);
		NativeMethodInfoPtr_isCharging_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664203);
		NativeMethodInfoPtr_doSelectSkill_Public_Void_Skill_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664204);
		NativeMethodInfoPtr_doUseSkill_Public_Void_Skill_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664205);
		NativeMethodInfoPtr_isMyClan_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664206);
		NativeMethodInfoPtr_doUseSkillNotFocus_Public_Void_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664207);
		NativeMethodInfoPtr_sortSkill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664208);
		NativeMethodInfoPtr_updateKeyTouchCapcha_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664209);
		NativeMethodInfoPtr_checkClickToCapcha_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664210);
		NativeMethodInfoPtr_checkMouseChat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr_updateKeyTouchControl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664212);
		NativeMethodInfoPtr_setCharJumpAtt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664213);
		NativeMethodInfoPtr_setCharJump_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664214);
		NativeMethodInfoPtr_updateOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr_initCreateCommand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr_checkCharFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_updateXoSo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_updateKeyChatPopUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_isRongThanMenu_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_paintEffect_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_paintBgItem_Public_Void_mGraphics_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_paintBlackSky_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_paintCapcha_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_paintXoSo_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_checkEffToObj_Private_Void_IMapObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_updateClickToArrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_paintWaypointArrow_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_findNPCInMap_Public_Static_Npc_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_findCharInMap_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_findMobInMap_Public_Static_Mob_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_findMobInMap2_Public_Static_Mob_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_findMobInMap_Public_Static_Mob_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664235);
		NativeMethodInfoPtr_getNpcTask_Public_Static_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664236);
		NativeMethodInfoPtr_paintArrowPointToNPC_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664237);
		NativeMethodInfoPtr_resetTranslate_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_paintTouchControl_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr_paintImageBarRight_Public_Void_mGraphics_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664240);
		NativeMethodInfoPtr_paintImageBar_Private_Void_mGraphics_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664241);
		NativeMethodInfoPtr_getInjure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_starVS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_findCharVS1_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_findCharVS2_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_paintInfoBar_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_isVS_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_paintSelectedSkill_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_paintOpen_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664249);
		NativeMethodInfoPtr_startFlyText_Public_Static_Void_String_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664250);
		NativeMethodInfoPtr_updateFlyText_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664251);
		NativeMethodInfoPtr_loadSplash_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664252);
		NativeMethodInfoPtr_startSplash_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr_updateSplash_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664254);
		NativeMethodInfoPtr_paintSplash_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr_loadInforBar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr_updateSS_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_updateKeyAlert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_isPaintPopup_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_isNotPaintTouchControl_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_isPaintUI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_isOpenUI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_setPopupSize_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr_loadImg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664264);
		NativeMethodInfoPtr_paintTitle_Public_Void_mGraphics_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664265);
		NativeMethodInfoPtr_getTaskMapId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664266);
		NativeMethodInfoPtr_getTaskNpcId_Public_Static_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664267);
		NativeMethodInfoPtr_refreshTeam_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664268);
		NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664269);
		NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664270);
		NativeMethodInfoPtr_openWeb_Public_Void_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664271);
		NativeMethodInfoPtr_sendSms_Public_Void_String_String_Int16_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_actMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_openUIZone_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr_showViewInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_actDead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_startYesNoPopUp_Public_Void_String_Command_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_player_vs_player_Public_Void_Int32_Int32_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_giaodich_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_getFlagImage_Public_Void_Int32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_actionPerform_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_setTouchBtn_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_updateGamePad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_paintGamePad_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_showWinNumber_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr_chatVip_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_clearChatVip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664287);
		NativeMethodInfoPtr_paintChatVip_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr_updateChatVip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr_showYourNumber_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664290);
		NativeMethodInfoPtr_checkRemoveImage_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664291);
		NativeMethodInfoPtr_StartServerPopUp_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr_ispaintPhubangBar_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_paintPhuBanBar_Public_Void_mGraphics_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_paintChienTruong_Life_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_paintHPBar_NEW_Public_Static_Void_mGraphics_Int32_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr_addEffectEnd_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr_addEffectEnd_Target_Public_Static_Void_Int32_Int32_Int32_Char_Point_Int32_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr_addEffect2Vector_Public_Static_Void_Effect_End_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_setIsInScreen_Public_Static_Boolean_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_isSmallScr_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_paint_xp_bar_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_ExportCurrentMapPNG_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameScr>.NativeClassPtr, 100664303);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40896, RefRangeEnd = 40897, XrefRangeStart = 40822, XrefRangeEnd = 40896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameScr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameScr>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41327, RefRangeEnd = 41328, XrefRangeStart = 40897, XrefRangeEnd = 41327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadBg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadBg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41333, RefRangeEnd = 41335, XrefRangeStart = 41328, XrefRangeEnd = 41333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initSelectChar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initSelectChar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41358, RefRangeEnd = 41360, XrefRangeStart = 41335, XrefRangeEnd = 41358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintOngMauPercent(Image img0, Image img1, Image img2, float x, float y, int size, float pixelPercent, mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img0);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img2);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelPercent;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintOngMauPercent_Public_Static_Void_Image_Image_Image_Single_Single_Int32_Single_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41360, XrefRangeEnd = 41367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initTraining()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initTraining_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41373, RefRangeEnd = 41375, XrefRangeStart = 41367, XrefRangeEnd = 41373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isMapDocNhan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMapDocNhan_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41379, RefRangeEnd = 41381, XrefRangeStart = 41375, XrefRangeEnd = 41379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isMapFize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMapFize_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41381, XrefRangeEnd = 41435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void switchToMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41435, XrefRangeEnd = 41439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getMaxExp(int level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMaxExp_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41476, RefRangeEnd = 41478, XrefRangeStart = 41439, XrefRangeEnd = 41476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetAllvector()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetAllvector_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadSkillShortcut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadSkillShortcut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41526, RefRangeEnd = 41527, XrefRangeStart = 41478, XrefRangeEnd = 41526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onOSkill(Il2CppStructArray<sbyte> oSkillID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)oSkillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onOSkill_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41557, RefRangeEnd = 41559, XrefRangeStart = 41527, XrefRangeEnd = 41557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onKSkill(Il2CppStructArray<sbyte> kSkillID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)kSkillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onKSkill_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41604, RefRangeEnd = 41605, XrefRangeStart = 41559, XrefRangeEnd = 41604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onCSkill(Il2CppStructArray<sbyte> cSkillID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cSkillID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCSkill_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41635, RefRangeEnd = 41636, XrefRangeStart = 41605, XrefRangeEnd = 41635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadDefaultonScreenSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadDefaultonScreenSkill_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41666, RefRangeEnd = 41667, XrefRangeStart = 41636, XrefRangeEnd = 41666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadDefaultKeySkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadDefaultKeySkill_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41703, RefRangeEnd = 41704, XrefRangeStart = 41667, XrefRangeEnd = 41703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doSetOnScreenSkill(SkillTemplate skillTemplate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillTemplate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doSetOnScreenSkill_Public_Void_SkillTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41748, RefRangeEnd = 41750, XrefRangeStart = 41704, XrefRangeEnd = 41748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doSetKeySkill(SkillTemplate skillTemplate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillTemplate);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doSetKeySkill_Public_Void_SkillTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41773, RefRangeEnd = 41776, XrefRangeStart = 41750, XrefRangeEnd = 41773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void saveonScreenSkillToRMS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveonScreenSkillToRMS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 41799, RefRangeEnd = 41803, XrefRangeStart = 41776, XrefRangeEnd = 41799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void saveKeySkillToRMS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveKeySkillToRMS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void saveRMSCurrentSkill(sbyte id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRMSCurrentSkill_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41803, XrefRangeEnd = 41845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addSkillShortcut(Skill skill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addSkillShortcut_Public_Void_Skill_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 41852, RefRangeEnd = 41857, XrefRangeStart = 41845, XrefRangeEnd = 41852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isBagFull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isBagFull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41857, XrefRangeEnd = 41869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createConfirm(Il2CppStringArray menu, Npc npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)menu);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createConfirm_Public_Void_Il2CppStringArray_Npc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41886, RefRangeEnd = 41888, XrefRangeStart = 41869, XrefRangeEnd = 41886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createMenu(Il2CppStringArray menu, Npc npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)menu);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createMenu_Public_Void_Il2CppStringArray_Npc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41976, RefRangeEnd = 41977, XrefRangeStart = 41888, XrefRangeEnd = 41976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readPart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readPart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 42035, RefRangeEnd = 42040, XrefRangeStart = 41977, XrefRangeEnd = 42035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readEfect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readEfect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 42080, RefRangeEnd = 42085, XrefRangeStart = 42040, XrefRangeEnd = 42080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readArrow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readArrow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 42216, RefRangeEnd = 42221, XrefRangeStart = 42085, XrefRangeEnd = 42216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readDart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readDart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 42361, RefRangeEnd = 42366, XrefRangeStart = 42221, XrefRangeEnd = 42361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(306)]
	[CachedScanResults(RefRangeStart = 42380, RefRangeEnd = 42686, XrefRangeStart = 42366, XrefRangeEnd = 42380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameScr gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_GameScr_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameScr>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42692, RefRangeEnd = 42693, XrefRangeStart = 42686, XrefRangeEnd = 42692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearGameScr()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearGameScr_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 42710, RefRangeEnd = 42712, XrefRangeStart = 42693, XrefRangeEnd = 42710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadGameScr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadGameScr_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42712, XrefRangeEnd = 42765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doMenuInforMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doMenuInforMe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42765, XrefRangeEnd = 42795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doMenusynthesis()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doMenusynthesis_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 43044, RefRangeEnd = 43052, XrefRangeStart = 42795, XrefRangeEnd = 43044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadCamera(bool fullmScreen, int cx, int cy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&fullmScreen);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cx;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadCamera_Public_Static_Void_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 43242, RefRangeEnd = 43246, XrefRangeStart = 43052, XrefRangeEnd = 43242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setSkillBarPosition()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSkillBarPosition_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43361, RefRangeEnd = 43362, XrefRangeStart = 43246, XrefRangeEnd = 43361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateCamera()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCamera_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43362, XrefRangeEnd = 43366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool testAct()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_testAct_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43384, RefRangeEnd = 43385, XrefRangeStart = 43366, XrefRangeEnd = 43384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clanInvite(string strInvite, int clanID, int code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strInvite);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clanID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &code;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clanInvite_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43519, RefRangeEnd = 43520, XrefRangeStart = 43385, XrefRangeEnd = 43519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void playerMenu(Char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playerMenu_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43602, RefRangeEnd = 43603, XrefRangeStart = 43520, XrefRangeEnd = 43602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isAttack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 43625, RefRangeEnd = 43633, XrefRangeStart = 43603, XrefRangeEnd = 43625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isMeCanAttackMob(Mob m)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeCanAttackMob_Public_Boolean_Mob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 43662, RefRangeEnd = 43666, XrefRangeStart = 43633, XrefRangeEnd = 43662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkSkillValid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkSkillValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43694, RefRangeEnd = 43695, XrefRangeStart = 43666, XrefRangeEnd = 43694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkSkillValid2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkSkillValid2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 43760, RefRangeEnd = 43769, XrefRangeStart = 43695, XrefRangeEnd = 43760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resetButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43769, XrefRangeEnd = 43770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void keyPress(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_keyPress_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43770, XrefRangeEnd = 43980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void updateKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 38844, RefRangeEnd = 38851, XrefRangeStart = 38844, XrefRangeEnd = 38851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isVsMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isVsMap_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43980, XrefRangeEnd = 44091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44091, XrefRangeEnd = 44136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 44186, RefRangeEnd = 44190, XrefRangeStart = 44136, XrefRangeEnd = 44186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IMapObject findClickToItem(int px, int py)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&px);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &py;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findClickToItem_Private_IMapObject_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMapObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe bool inRectangle(int xClick, int yClick, int x, int y, int w, int h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&xClick);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yClick;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_inRectangle_Private_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44239, RefRangeEnd = 44240, XrefRangeStart = 44190, XrefRangeEnd = 44239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkSingleClickEarly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkSingleClickEarly_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44257, RefRangeEnd = 44258, XrefRangeStart = 44240, XrefRangeEnd = 44257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkDoubleClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkDoubleClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 44279, RefRangeEnd = 44283, XrefRangeStart = 44258, XrefRangeEnd = 44279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkClickToBotton(IMapObject Object)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Object);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkClickToBotton_Private_Boolean_IMapObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44305, RefRangeEnd = 44307, XrefRangeStart = 44283, XrefRangeEnd = 44305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doDoubleClickToObj(IMapObject obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doDoubleClickToObj_Public_Void_IMapObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44307, XrefRangeEnd = 44314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkSingleClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkSingleClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44322, RefRangeEnd = 44325, XrefRangeStart = 44314, XrefRangeEnd = 44322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkClipTopChatPopUp(int xClick, int yClick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xClick);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yClick;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkClipTopChatPopUp_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44344, RefRangeEnd = 44347, XrefRangeStart = 44325, XrefRangeEnd = 44344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkClickToPopup(int xClick, int yClick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xClick);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yClick;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkClickToPopup_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44375, RefRangeEnd = 44378, XrefRangeStart = 44347, XrefRangeEnd = 44375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkClickMoveTo(int xClick, int yClick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&xClick);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yClick;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkClickMoveTo_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44496, RefRangeEnd = 44497, XrefRangeStart = 44378, XrefRangeEnd = 44496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkAuto()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkAuto_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 44533, RefRangeEnd = 44537, XrefRangeStart = 44497, XrefRangeEnd = 44533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doUseHP()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doUseHP_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44547, RefRangeEnd = 44549, XrefRangeStart = 44537, XrefRangeEnd = 44547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void activeSuperPower(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_activeSuperPower_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44562, RefRangeEnd = 44564, XrefRangeStart = 44549, XrefRangeEnd = 44562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void activeRongThanEff(bool isMe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isMe);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_activeRongThanEff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44564, RefRangeEnd = 44565, XrefRangeStart = 44564, XrefRangeEnd = 44564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void hideRongThanEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hideRongThanEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44573, RefRangeEnd = 44575, XrefRangeStart = 44565, XrefRangeEnd = 44573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doiMauTroi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doiMauTroi_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44602, RefRangeEnd = 44604, XrefRangeStart = 44575, XrefRangeEnd = 44602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void callRongThan(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callRongThan_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44604, XrefRangeEnd = 44611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void hideRongThan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hideRongThan_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44611, XrefRangeEnd = 44785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void autoPlay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_autoPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44900, RefRangeEnd = 44903, XrefRangeStart = 44785, XrefRangeEnd = 44900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doFire(bool isFireByShortCut, bool skipWaypoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isFireByShortCut);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipWaypoint;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doFire_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44946, RefRangeEnd = 44947, XrefRangeStart = 44903, XrefRangeEnd = 44946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void askToPick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_askToPick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44981, RefRangeEnd = 44983, XrefRangeStart = 44947, XrefRangeEnd = 44981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pickItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pickItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44999, RefRangeEnd = 45002, XrefRangeStart = 44983, XrefRangeEnd = 44999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isCharging()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isCharging_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 45041, RefRangeEnd = 45045, XrefRangeStart = 45002, XrefRangeEnd = 45041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doSelectSkill(Skill skill, bool isShortcut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShortcut;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doSelectSkill_Public_Void_Skill_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 45072, RefRangeEnd = 45076, XrefRangeStart = 45045, XrefRangeEnd = 45072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doUseSkill(Skill skill, bool isShortcut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShortcut;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doUseSkill_Public_Void_Skill_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45088, RefRangeEnd = 45089, XrefRangeStart = 45076, XrefRangeEnd = 45088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMyClan(int charID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMyClan_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45089, XrefRangeEnd = 45113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doUseSkillNotFocus(Skill skill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doUseSkillNotFocus_Public_Void_Skill_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45141, RefRangeEnd = 45143, XrefRangeStart = 45113, XrefRangeEnd = 45141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sortSkill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sortSkill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45143, XrefRangeEnd = 45207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateKeyTouchCapcha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKeyTouchCapcha_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45207, XrefRangeEnd = 45217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkClickToCapcha()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkClickToCapcha_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45217, XrefRangeEnd = 45271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkMouseChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkMouseChat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45307, RefRangeEnd = 45308, XrefRangeStart = 45271, XrefRangeEnd = 45307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateKeyTouchControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKeyTouchControl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45308, XrefRangeEnd = 45314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCharJumpAtt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCharJumpAtt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45314, XrefRangeEnd = 45334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setCharJump(int cvx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cvx);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setCharJump_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45334, XrefRangeEnd = 45345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initCreateCommand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initCreateCommand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkCharFocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkCharFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45377, RefRangeEnd = 45378, XrefRangeStart = 45345, XrefRangeEnd = 45377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateXoSo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateXoSo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45378, XrefRangeEnd = 45896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateKeyChatPopUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKeyChatPopUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool isRongThanMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isRongThanMenu_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45933, RefRangeEnd = 45934, XrefRangeStart = 45896, XrefRangeEnd = 45933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintEffect(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintEffect_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 45971, RefRangeEnd = 45976, XrefRangeStart = 45934, XrefRangeEnd = 45971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintBgItem(mGraphics g, int layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBgItem_Public_Void_mGraphics_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45988, RefRangeEnd = 45989, XrefRangeStart = 45976, XrefRangeEnd = 45988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintBlackSky(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBlackSky_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46056, RefRangeEnd = 46057, XrefRangeStart = 45989, XrefRangeEnd = 46056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintCapcha(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCapcha_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46057, XrefRangeEnd = 47100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47124, RefRangeEnd = 47125, XrefRangeStart = 47100, XrefRangeEnd = 47124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintXoSo(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintXoSo_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47170, RefRangeEnd = 47171, XrefRangeStart = 47125, XrefRangeEnd = 47170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkEffToObj(IMapObject obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkEffToObj_Private_Void_IMapObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47171, XrefRangeEnd = 47185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateClickToArrow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateClickToArrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47185, XrefRangeEnd = 47273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintWaypointArrow(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintWaypointArrow_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 47285, RefRangeEnd = 47291, XrefRangeStart = 47273, XrefRangeEnd = 47285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Npc findNPCInMap(short id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findNPCInMap_Public_Static_Npc_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Npc>(intPtr) : null;
	}

	[CallerCount(156)]
	[CachedScanResults(RefRangeStart = 47303, RefRangeEnd = 47459, XrefRangeStart = 47291, XrefRangeEnd = 47303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Char findCharInMap(int charId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findCharInMap_Public_Static_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47459, XrefRangeEnd = 47466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mob findMobInMap(sbyte mobIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mobIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findMobInMap_Public_Static_Mob_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47478, RefRangeEnd = 47479, XrefRangeStart = 47466, XrefRangeEnd = 47478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mob findMobInMap2(int mobId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mobId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findMobInMap2_Public_Static_Mob_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 47491, RefRangeEnd = 47530, XrefRangeStart = 47479, XrefRangeEnd = 47491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mob findMobInMap(int mobId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mobId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findMobInMap_Public_Static_Mob_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 47543, RefRangeEnd = 47546, XrefRangeStart = 47530, XrefRangeEnd = 47543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Npc getNpcTask()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNpcTask_Public_Static_Npc_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Npc>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47676, RefRangeEnd = 47677, XrefRangeStart = 47546, XrefRangeEnd = 47676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintArrowPointToNPC(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintArrowPointToNPC_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 47685, RefRangeEnd = 47698, XrefRangeStart = 47677, XrefRangeEnd = 47685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetTranslate(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetTranslate_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47733, RefRangeEnd = 47734, XrefRangeStart = 47698, XrefRangeEnd = 47733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintTouchControl(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintTouchControl_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47789, RefRangeEnd = 47791, XrefRangeStart = 47734, XrefRangeEnd = 47789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintImageBarRight(mGraphics g, Char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintImageBarRight_Public_Void_mGraphics_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 47927, RefRangeEnd = 47930, XrefRangeStart = 47791, XrefRangeEnd = 47927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintImageBar(mGraphics g, bool isLeft, Char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLeft;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintImageBar_Private_Void_mGraphics_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getInjure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInjure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47934, RefRangeEnd = 47936, XrefRangeStart = 47930, XrefRangeEnd = 47934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void starVS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_starVS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 47948, RefRangeEnd = 47953, XrefRangeStart = 47936, XrefRangeEnd = 47948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Char findCharVS1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findCharVS1_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 47966, RefRangeEnd = 47970, XrefRangeStart = 47953, XrefRangeEnd = 47966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Char findCharVS2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findCharVS2_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48202, RefRangeEnd = 48204, XrefRangeStart = 47970, XrefRangeEnd = 48202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintInfoBar(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintInfoBar_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 48217, RefRangeEnd = 48222, XrefRangeStart = 48204, XrefRangeEnd = 48217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isVS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isVS_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 48520, RefRangeEnd = 48522, XrefRangeStart = 48222, XrefRangeEnd = 48520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintSelectedSkill(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintSelectedSkill_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48522, XrefRangeEnd = 48535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintOpen(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintOpen_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 48540, RefRangeEnd = 48559, XrefRangeStart = 48535, XrefRangeEnd = 48540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void startFlyText(string flyString, int x, int y, int dx, int dy, int color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(flyString);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dx;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dy;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startFlyText_Public_Static_Void_String_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48584, RefRangeEnd = 48585, XrefRangeStart = 48559, XrefRangeEnd = 48584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateFlyText()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateFlyText_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48641, RefRangeEnd = 48642, XrefRangeStart = 48585, XrefRangeEnd = 48641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadSplash()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadSplash_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48653, RefRangeEnd = 48654, XrefRangeStart = 48642, XrefRangeEnd = 48653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool startSplash(int x, int y, int dir)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startSplash_Public_Static_Boolean_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48668, RefRangeEnd = 48669, XrefRangeStart = 48654, XrefRangeEnd = 48668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateSplash()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSplash_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48690, RefRangeEnd = 48691, XrefRangeStart = 48669, XrefRangeEnd = 48690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintSplash(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintSplash_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48691, XrefRangeEnd = 48700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadInforBar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadInforBar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48729, RefRangeEnd = 48730, XrefRangeStart = 48700, XrefRangeEnd = 48729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSS()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSS_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48854, RefRangeEnd = 48855, XrefRangeStart = 48730, XrefRangeEnd = 48854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateKeyAlert()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKeyAlert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 48933, RefRangeEnd = 48936, XrefRangeStart = 48855, XrefRangeEnd = 48933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isPaintPopup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPaintPopup_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 48965, RefRangeEnd = 48968, XrefRangeStart = 48936, XrefRangeEnd = 48965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isNotPaintTouchControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNotPaintTouchControl_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49022, RefRangeEnd = 49023, XrefRangeStart = 48968, XrefRangeEnd = 49022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isPaintUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPaintUI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49023, XrefRangeEnd = 49081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isOpenUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isOpenUI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 49166, RefRangeEnd = 49170, XrefRangeStart = 49081, XrefRangeEnd = 49166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setPopupSize(int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&w);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPopupSize_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49174, RefRangeEnd = 49175, XrefRangeStart = 49170, XrefRangeEnd = 49174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadImg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadImg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49175, XrefRangeEnd = 49256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintTitle(mGraphics g, string title, bool arrow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrow;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintTitle_Public_Void_mGraphics_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 49267, RefRangeEnd = 49273, XrefRangeStart = 49256, XrefRangeEnd = 49267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getTaskMapId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTaskMapId_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 49289, RefRangeEnd = 49293, XrefRangeStart = 49273, XrefRangeEnd = 49289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte getTaskNpcId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTaskNpcId_Public_Static_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void refreshTeam()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_refreshTeam_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49293, XrefRangeEnd = 49325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49325, XrefRangeEnd = 49339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onCancelChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49339, XrefRangeEnd = 49364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openWeb(string strLeft, string strRight, string url, string title, string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strRight);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openWeb_Public_Void_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49364, XrefRangeEnd = 49398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void sendSms(string strLeft, string strRight, short port, string syntax, string title, string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strLeft);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(strRight);
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(syntax);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendSms_Public_Void_String_String_Int16_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49398, XrefRangeEnd = 49406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void actMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_actMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49456, RefRangeEnd = 49457, XrefRangeStart = 49406, XrefRangeEnd = 49456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openUIZone(Message message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openUIZone_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49457, XrefRangeEnd = 49463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showViewInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showViewInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49463, XrefRangeEnd = 49506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void actDead()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_actDead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 49513, RefRangeEnd = 49516, XrefRangeStart = 49506, XrefRangeEnd = 49513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startYesNoPopUp(string info, Command cmdYes, Command cmdNo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdYes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmdNo);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startYesNoPopUp_Public_Void_String_Command_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49539, RefRangeEnd = 49540, XrefRangeStart = 49516, XrefRangeEnd = 49539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void player_vs_player(int playerId, int xu, string info, sbyte typePK)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&playerId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &xu;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(info);
		*(sbyte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePK;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_player_vs_player_Public_Void_Int32_Int32_String_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49559, RefRangeEnd = 49560, XrefRangeStart = 49540, XrefRangeEnd = 49559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void giaodich(int playerID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playerID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_giaodich_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 49601, RefRangeEnd = 49603, XrefRangeStart = 49560, XrefRangeEnd = 49601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getFlagImage(int charID, sbyte cflag)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&charID);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cflag;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFlagImage_Public_Void_Int32_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 49794, RefRangeEnd = 49797, XrefRangeStart = 49603, XrefRangeEnd = 49794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void actionPerform(int idAction, Il2CppSystem.Object p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_actionPerform_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 49826, RefRangeEnd = 49828, XrefRangeStart = 49797, XrefRangeEnd = 49826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTouchBtn()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTouchBtn_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49828, XrefRangeEnd = 49887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateGamePad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateGamePad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49932, RefRangeEnd = 49933, XrefRangeStart = 49887, XrefRangeEnd = 49932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintGamePad(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintGamePad_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49971, RefRangeEnd = 49972, XrefRangeStart = 49933, XrefRangeEnd = 49971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showWinNumber(string num, string finish)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(num);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(finish);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showWinNumber_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50053, RefRangeEnd = 50054, XrefRangeStart = 49972, XrefRangeEnd = 50053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chatVip(string chatVip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chatVip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatVip_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50054, XrefRangeEnd = 50063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearChatVip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearChatVip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50090, RefRangeEnd = 50091, XrefRangeStart = 50063, XrefRangeEnd = 50090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintChatVip(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintChatVip_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50091, XrefRangeEnd = 50113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateChatVip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateChatVip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50121, RefRangeEnd = 50122, XrefRangeStart = 50113, XrefRangeEnd = 50121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void showYourNumber(string strNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strNum);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showYourNumber_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50122, XrefRangeEnd = 50127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void checkRemoveImage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkRemoveImage_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50127, XrefRangeEnd = 50154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartServerPopUp(string strMsg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strMsg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartServerPopUp_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50162, RefRangeEnd = 50164, XrefRangeStart = 50154, XrefRangeEnd = 50162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ispaintPhubangBar()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ispaintPhubangBar_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50328, RefRangeEnd = 50329, XrefRangeStart = 50164, XrefRangeEnd = 50328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintPhuBanBar(mGraphics g, int x, int y, int w)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintPhuBanBar_Public_Void_mGraphics_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50355, RefRangeEnd = 50356, XrefRangeStart = 50329, XrefRangeEnd = 50355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintChienTruong_Life(mGraphics g, int maxLife, int cl1, int lifeTeam1, int x1, int cl2, int lifeTeam2, int x2, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLife;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cl1;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lifeTeam1;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cl2;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &lifeTeam2;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &x2;
		*(int**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintChienTruong_Life_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50386, RefRangeEnd = 50387, XrefRangeStart = 50356, XrefRangeEnd = 50386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintHPBar_NEW(mGraphics g, int x, int y, Char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintHPBar_NEW_Public_Static_Void_mGraphics_Int32_Int32_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 50395, RefRangeEnd = 50404, XrefRangeStart = 50387, XrefRangeEnd = 50395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addEffectEnd(int type, int subtype, int typePaint, int x, int y, int levelPaint, int dir, short timeRemove, Il2CppReferenceArray<Point> listObj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subtype;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePaint;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelPaint;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(short**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeRemove;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addEffectEnd_Public_Static_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 50412, RefRangeEnd = 50421, XrefRangeStart = 50404, XrefRangeEnd = 50412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addEffectEnd_Target(int type, int subtype, int typePaint, Char charUse, Point target, int levelPaint, short timeRemove, short range)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &subtype;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePaint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charUse);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelPaint;
		*(short**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeRemove;
		*(short**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addEffectEnd_Target_Public_Static_Void_Int32_Int32_Int32_Char_Point_Int32_Int16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50432, RefRangeEnd = 50434, XrefRangeStart = 50421, XrefRangeEnd = 50432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addEffect2Vector(Effect_End eff)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eff);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addEffect2Vector_Public_Static_Void_Effect_End_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50434, XrefRangeEnd = 50453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool setIsInScreen(int x, int y, int wOne, int hOne)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wOne;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hOne;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setIsInScreen_Public_Static_Boolean_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50453, XrefRangeEnd = 50457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isSmallScr()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isSmallScr_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50457, XrefRangeEnd = 50478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint_xp_bar(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_xp_bar_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50478, XrefRangeEnd = 50646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExportCurrentMapPNG()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExportCurrentMapPNG_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameScr(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
