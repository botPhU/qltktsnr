using System;
using System.Runtime.CompilerServices;
using Il2CppAssets.src.g;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Mob : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_countDie;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeDie;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_DUNG;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_DI;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_NHAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LET;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_BAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_BAY_DAU;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrMobTemplate;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_INHELL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_DEADFLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_STANDWAIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_ATTACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_STANDFLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_WALK;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_FALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MA_INJURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_changBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHintFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_flystring;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyx;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyy;

	private static readonly System.IntPtr NativeFieldInfoPtr_flyIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFreez;

	private static readonly System.IntPtr NativeFieldInfoPtr_seconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeFieldInfoPtr_cur;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdEffID;

	private static readonly System.IntPtr NativeFieldInfoPtr_hp;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxHp;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_dir;

	private static readonly System.IntPtr NativeFieldInfoPtr_dirV;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_p1;

	private static readonly System.IntPtr NativeFieldInfoPtr_p2;

	private static readonly System.IntPtr NativeFieldInfoPtr_p3;

	private static readonly System.IntPtr NativeFieldInfoPtr_xFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_yFirst;

	private static readonly System.IntPtr NativeFieldInfoPtr_vy;

	private static readonly System.IntPtr NativeFieldInfoPtr_exp;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_hpInjure;

	private static readonly System.IntPtr NativeFieldInfoPtr_charIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_mobId;

	private static readonly System.IntPtr NativeFieldInfoPtr_isx;

	private static readonly System.IntPtr NativeFieldInfoPtr_isy;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDontMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFire;

	private static readonly System.IntPtr NativeFieldInfoPtr_isIce;

	private static readonly System.IntPtr NativeFieldInfoPtr_isWind;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDie;

	private static readonly System.IntPtr NativeFieldInfoPtr_vMobMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGo;

	private static readonly System.IntPtr NativeFieldInfoPtr_mobName;

	private static readonly System.IntPtr NativeFieldInfoPtr_templateId;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointx;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_dame;

	private static readonly System.IntPtr NativeFieldInfoPtr_dameMp;

	private static readonly System.IntPtr NativeFieldInfoPtr_sys;

	private static readonly System.IntPtr NativeFieldInfoPtr_levelBoss;

	private static readonly System.IntPtr NativeFieldInfoPtr_level;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBoss;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMobMe;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_newMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMafuba;

	private static readonly System.IntPtr NativeFieldInfoPtr_xMFB;

	private static readonly System.IntPtr NativeFieldInfoPtr_yMFB;

	private static readonly System.IntPtr NativeFieldInfoPtr_xSd;

	private static readonly System.IntPtr NativeFieldInfoPtr_ySd;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOutMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_wCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShadown;

	private static readonly System.IntPtr NativeFieldInfoPtr_tick;

	private static readonly System.IntPtr NativeFieldInfoPtr_frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHP;

	private static readonly System.IntPtr NativeFieldInfoPtr_wy;

	private static readonly System.IntPtr NativeFieldInfoPtr_wt;

	private static readonly System.IntPtr NativeFieldInfoPtr_fy;

	private static readonly System.IntPtr NativeFieldInfoPtr_ty;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeSuperEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBusyAttackSomeOne;

	private static readonly System.IntPtr NativeFieldInfoPtr_stand;

	private static readonly System.IntPtr NativeFieldInfoPtr_move;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveFast;

	private static readonly System.IntPtr NativeFieldInfoPtr_attack1;

	private static readonly System.IntPtr NativeFieldInfoPtr_attack2;

	private static readonly System.IntPtr NativeFieldInfoPtr_hurt;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_w_hp_bar;

	private static readonly System.IntPtr NativeFieldInfoPtr_per;

	private static readonly System.IntPtr NativeFieldInfoPtr_per_tem;

	private static readonly System.IntPtr NativeFieldInfoPtr_h_hp_bar;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHPtem;

	private static readonly System.IntPtr NativeFieldInfoPtr_offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHide;

	private static readonly System.IntPtr NativeFieldInfoPtr_cou;

	private static readonly System.IntPtr NativeFieldInfoPtr_injureBy;

	private static readonly System.IntPtr NativeFieldInfoPtr_injureThenDie;

	private static readonly System.IntPtr NativeFieldInfoPtr_mobToAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceWait;

	private static readonly System.IntPtr NativeFieldInfoPtr_blindEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleepEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameArr;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGetFr;

	private static readonly System.IntPtr NativeFieldInfoPtr_cTimeDie;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Int64_SByte_Int64_Int16_Int16_SByte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isBigBoss_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setBody_Public_Virtual_New_Void_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearBody_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isExistNewMob_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkData_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkFrameTick_Public_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateShadown_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintShadow_Internal_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateSuperEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setInjure_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBigBoss_Public_Static_BigBoss_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBigBoss2_Public_Static_BigBoss2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBachTuoc_Public_Static_BachTuoc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getNewBoss_Public_Static_NewBoss_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeBigBoss_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setAttack_Public_Void_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isSpecial_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNewModStand_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNewMod_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateInjure_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMobStandWait_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMobAttack_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMobWalk_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTemplate_Public_MobTemplate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPaint_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isUpdate_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkIsBoss_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateHp_bar_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Virtual_New_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHPColor_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startDie_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_attackOtherMob_Public_Void_Mob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getX_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getY_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getH_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getW_Public_Virtual_Final_New_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopMoving_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInvisible_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeHoldEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeBlindEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeSleepEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFrame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeNewMod_Internal_Boolean_0;

	public unsafe int countDie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countDie);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countDie)) = num;
		}
	}

	public unsafe long lastTimeDie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeDie);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeDie)) = num;
		}
	}

	public unsafe static sbyte TYPE_DUNG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_DUNG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_DUNG, (void*)(&b));
		}
	}

	public unsafe static sbyte TYPE_DI
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_DI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_DI, (void*)(&b));
		}
	}

	public unsafe static sbyte TYPE_NHAY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_NHAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_NHAY, (void*)(&b));
		}
	}

	public unsafe static sbyte TYPE_LET
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LET, (void*)(&b));
		}
	}

	public unsafe static sbyte TYPE_BAY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_BAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_BAY, (void*)(&b));
		}
	}

	public unsafe static sbyte TYPE_BAY_DAU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_BAY_DAU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_BAY_DAU, (void*)(&b));
		}
	}

	public unsafe static Il2CppReferenceArray<MobTemplate> arrMobTemplate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrMobTemplate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MobTemplate>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrMobTemplate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static sbyte MA_INHELL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_INHELL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_INHELL, (void*)(&b));
		}
	}

	public unsafe static sbyte MA_DEADFLY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_DEADFLY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_DEADFLY, (void*)(&b));
		}
	}

	public unsafe static sbyte MA_STANDWAIT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_STANDWAIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_STANDWAIT, (void*)(&b));
		}
	}

	public unsafe static sbyte MA_ATTACK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_ATTACK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_ATTACK, (void*)(&b));
		}
	}

	public unsafe static sbyte MA_STANDFLY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_STANDFLY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_STANDFLY, (void*)(&b));
		}
	}

	public unsafe static sbyte MA_WALK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_WALK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_WALK, (void*)(&b));
		}
	}

	public unsafe static sbyte MA_FALL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_FALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_FALL, (void*)(&b));
		}
	}

	public unsafe static sbyte MA_INJURE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MA_INJURE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MA_INJURE, (void*)(&b));
		}
	}

	public unsafe bool changBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changBody);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changBody)) = flag;
		}
	}

	public unsafe short smallBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallBody);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallBody)) = num;
		}
	}

	public unsafe bool isHintFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHintFocus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHintFocus)) = flag;
		}
	}

	public unsafe string flystring
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flystring);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flystring)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int flyx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyx)) = num;
		}
	}

	public unsafe int flyy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyy)) = num;
		}
	}

	public unsafe int flyIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flyIndex)) = num;
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

	public unsafe long hp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hp)) = num;
		}
	}

	public unsafe long maxHp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHp);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxHp)) = num;
		}
	}

	public unsafe int x
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
		}
	}

	public unsafe int y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)) = num;
		}
	}

	public unsafe int dir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir)) = num;
		}
	}

	public unsafe int dirV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirV);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dirV)) = num;
		}
	}

	public unsafe int status
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_status)) = num;
		}
	}

	public unsafe int p1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p1)) = num;
		}
	}

	public unsafe int p2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p2)) = num;
		}
	}

	public unsafe int p3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p3);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p3)) = num;
		}
	}

	public unsafe int xFirst
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xFirst);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xFirst)) = num;
		}
	}

	public unsafe int yFirst
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yFirst);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yFirst)) = num;
		}
	}

	public unsafe int vy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vy)) = num;
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

	public unsafe int w
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w)) = num;
		}
	}

	public unsafe int h
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h)) = num;
		}
	}

	public unsafe long hpInjure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hpInjure);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hpInjure)) = num;
		}
	}

	public unsafe int charIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charIndex)) = num;
		}
	}

	public unsafe int timeStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStatus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStatus)) = num;
		}
	}

	public unsafe int mobId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobId)) = num;
		}
	}

	public unsafe bool isx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isx);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isx)) = flag;
		}
	}

	public unsafe bool isy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isy)) = flag;
		}
	}

	public unsafe bool isDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisable)) = flag;
		}
	}

	public unsafe bool isDontMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDontMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDontMove)) = flag;
		}
	}

	public unsafe bool isFire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFire);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFire)) = flag;
		}
	}

	public unsafe bool isIce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isIce)) = flag;
		}
	}

	public unsafe bool isWind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWind);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWind)) = flag;
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

	public unsafe MyVector vMobMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vMobMove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vMobMove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe bool isGo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGo)) = flag;
		}
	}

	public unsafe string mobName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int templateId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templateId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_templateId)) = num;
		}
	}

	public unsafe short pointx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointx);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointx)) = num;
		}
	}

	public unsafe short pointy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointy);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointy)) = num;
		}
	}

	public unsafe Char cFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFocus);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cFocus)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe long dame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dame);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dame)) = num;
		}
	}

	public unsafe long dameMp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dameMp);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dameMp)) = num;
		}
	}

	public unsafe int sys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sys);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sys)) = num;
		}
	}

	public unsafe sbyte levelBoss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelBoss);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelBoss)) = b;
		}
	}

	public unsafe sbyte level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_level)) = b;
		}
	}

	public unsafe bool isBoss
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBoss);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBoss)) = flag;
		}
	}

	public unsafe bool isMobMe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMobMe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMobMe)) = flag;
		}
	}

	public unsafe static MyVector lastMob
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastMob, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastMob, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector newMob
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_newMob, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_newMob, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
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

	public unsafe int wCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wCount)) = num;
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

	public unsafe int frame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame)) = num;
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

	public unsafe int typeSuperEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeSuperEff);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeSuperEff)) = num;
		}
	}

	public unsafe bool isBusyAttackSomeOne
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBusyAttackSomeOne);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBusyAttackSomeOne)) = flag;
		}
	}

	public unsafe Il2CppStructArray<int> stand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stand)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
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

	public unsafe Il2CppStructArray<int> moveFast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveFast);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveFast)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> attack1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attack1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attack1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> attack2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attack2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attack2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> hurt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hurt);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hurt)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = num;
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

	public unsafe byte h_hp_bar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h_hp_bar);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h_hp_bar)) = b;
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

	public unsafe int offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = num;
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

	public unsafe Il2CppStructArray<sbyte> cou
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cou);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cou)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Char injureBy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injureBy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injureBy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe bool injureThenDie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injureThenDie);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_injureThenDie)) = flag;
		}
	}

	public unsafe Mob mobToAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobToAttack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mobToAttack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mob));
		}
	}

	public unsafe int forceWait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceWait);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceWait)) = num;
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

	public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> frameArr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameArr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameArr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool isGetFr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGetFr);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGetFr)) = flag;
		}
	}

	public unsafe long cTimeDie
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cTimeDie);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cTimeDie)) = num;
		}
	}

	static Mob()
	{
		Il2CppClassPointerStore<Mob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Mob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mob>.NativeClassPtr);
		NativeFieldInfoPtr_countDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "countDie");
		NativeFieldInfoPtr_lastTimeDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "lastTimeDie");
		NativeFieldInfoPtr_TYPE_DUNG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "TYPE_DUNG");
		NativeFieldInfoPtr_TYPE_DI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "TYPE_DI");
		NativeFieldInfoPtr_TYPE_NHAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "TYPE_NHAY");
		NativeFieldInfoPtr_TYPE_LET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "TYPE_LET");
		NativeFieldInfoPtr_TYPE_BAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "TYPE_BAY");
		NativeFieldInfoPtr_TYPE_BAY_DAU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "TYPE_BAY_DAU");
		NativeFieldInfoPtr_arrMobTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "arrMobTemplate");
		NativeFieldInfoPtr_MA_INHELL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_INHELL");
		NativeFieldInfoPtr_MA_DEADFLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_DEADFLY");
		NativeFieldInfoPtr_MA_STANDWAIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_STANDWAIT");
		NativeFieldInfoPtr_MA_ATTACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_ATTACK");
		NativeFieldInfoPtr_MA_STANDFLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_STANDFLY");
		NativeFieldInfoPtr_MA_WALK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_WALK");
		NativeFieldInfoPtr_MA_FALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_FALL");
		NativeFieldInfoPtr_MA_INJURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "MA_INJURE");
		NativeFieldInfoPtr_changBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "changBody");
		NativeFieldInfoPtr_smallBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "smallBody");
		NativeFieldInfoPtr_isHintFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isHintFocus");
		NativeFieldInfoPtr_flystring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "flystring");
		NativeFieldInfoPtr_flyx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "flyx");
		NativeFieldInfoPtr_flyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "flyy");
		NativeFieldInfoPtr_flyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "flyIndex");
		NativeFieldInfoPtr_isFreez = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isFreez");
		NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "seconds");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "last");
		NativeFieldInfoPtr_cur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "cur");
		NativeFieldInfoPtr_holdEffID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "holdEffID");
		NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "hp");
		NativeFieldInfoPtr_maxHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "maxHp");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "y");
		NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "dir");
		NativeFieldInfoPtr_dirV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "dirV");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "status");
		NativeFieldInfoPtr_p1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "p1");
		NativeFieldInfoPtr_p2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "p2");
		NativeFieldInfoPtr_p3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "p3");
		NativeFieldInfoPtr_xFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "xFirst");
		NativeFieldInfoPtr_yFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "yFirst");
		NativeFieldInfoPtr_vy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "vy");
		NativeFieldInfoPtr_exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "exp");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "w");
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "h");
		NativeFieldInfoPtr_hpInjure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "hpInjure");
		NativeFieldInfoPtr_charIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "charIndex");
		NativeFieldInfoPtr_timeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "timeStatus");
		NativeFieldInfoPtr_mobId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "mobId");
		NativeFieldInfoPtr_isx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isx");
		NativeFieldInfoPtr_isy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isy");
		NativeFieldInfoPtr_isDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isDisable");
		NativeFieldInfoPtr_isDontMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isDontMove");
		NativeFieldInfoPtr_isFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isFire");
		NativeFieldInfoPtr_isIce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isIce");
		NativeFieldInfoPtr_isWind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isWind");
		NativeFieldInfoPtr_isDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isDie");
		NativeFieldInfoPtr_vMobMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "vMobMove");
		NativeFieldInfoPtr_isGo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isGo");
		NativeFieldInfoPtr_mobName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "mobName");
		NativeFieldInfoPtr_templateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "templateId");
		NativeFieldInfoPtr_pointx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "pointx");
		NativeFieldInfoPtr_pointy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "pointy");
		NativeFieldInfoPtr_cFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "cFocus");
		NativeFieldInfoPtr_dame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "dame");
		NativeFieldInfoPtr_dameMp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "dameMp");
		NativeFieldInfoPtr_sys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "sys");
		NativeFieldInfoPtr_levelBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "levelBoss");
		NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "level");
		NativeFieldInfoPtr_isBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isBoss");
		NativeFieldInfoPtr_isMobMe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isMobMe");
		NativeFieldInfoPtr_lastMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "lastMob");
		NativeFieldInfoPtr_newMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "newMob");
		NativeFieldInfoPtr_isMafuba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isMafuba");
		NativeFieldInfoPtr_xMFB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "xMFB");
		NativeFieldInfoPtr_yMFB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "yMFB");
		NativeFieldInfoPtr_xSd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "xSd");
		NativeFieldInfoPtr_ySd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "ySd");
		NativeFieldInfoPtr_isOutMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isOutMap");
		NativeFieldInfoPtr_wCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "wCount");
		NativeFieldInfoPtr_isShadown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isShadown");
		NativeFieldInfoPtr_tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "tick");
		NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "frame");
		NativeFieldInfoPtr_imgHP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "imgHP");
		NativeFieldInfoPtr_wy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "wy");
		NativeFieldInfoPtr_wt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "wt");
		NativeFieldInfoPtr_fy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "fy");
		NativeFieldInfoPtr_ty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "ty");
		NativeFieldInfoPtr_typeSuperEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "typeSuperEff");
		NativeFieldInfoPtr_isBusyAttackSomeOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isBusyAttackSomeOne");
		NativeFieldInfoPtr_stand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "stand");
		NativeFieldInfoPtr_move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "move");
		NativeFieldInfoPtr_moveFast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "moveFast");
		NativeFieldInfoPtr_attack1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "attack1");
		NativeFieldInfoPtr_attack2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "attack2");
		NativeFieldInfoPtr_hurt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "hurt");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "color");
		NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "len");
		NativeFieldInfoPtr_w_hp_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "w_hp_bar");
		NativeFieldInfoPtr_per = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "per");
		NativeFieldInfoPtr_per_tem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "per_tem");
		NativeFieldInfoPtr_h_hp_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "h_hp_bar");
		NativeFieldInfoPtr_imgHPtem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "imgHPtem");
		NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "offset");
		NativeFieldInfoPtr_isHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isHide");
		NativeFieldInfoPtr_cou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "cou");
		NativeFieldInfoPtr_injureBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "injureBy");
		NativeFieldInfoPtr_injureThenDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "injureThenDie");
		NativeFieldInfoPtr_mobToAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "mobToAttack");
		NativeFieldInfoPtr_forceWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "forceWait");
		NativeFieldInfoPtr_blindEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "blindEff");
		NativeFieldInfoPtr_sleepEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "sleepEff");
		NativeFieldInfoPtr_frameArr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "frameArr");
		NativeFieldInfoPtr_isGetFr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "isGetFr");
		NativeFieldInfoPtr_cTimeDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mob>.NativeClassPtr, "cTimeDie");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664838);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Int64_SByte_Int64_Int16_Int16_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664839);
		NativeMethodInfoPtr_isBigBoss_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664840);
		NativeMethodInfoPtr_getData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664841);
		NativeMethodInfoPtr_setBody_Public_Virtual_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664842);
		NativeMethodInfoPtr_clearBody_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664843);
		NativeMethodInfoPtr_isExistNewMob_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664844);
		NativeMethodInfoPtr_checkData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664845);
		NativeMethodInfoPtr_checkFrameTick_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664846);
		NativeMethodInfoPtr_updateShadown_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664847);
		NativeMethodInfoPtr_paintShadow_Internal_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664848);
		NativeMethodInfoPtr_updateSuperEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664849);
		NativeMethodInfoPtr_update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664850);
		NativeMethodInfoPtr_setInjure_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664851);
		NativeMethodInfoPtr_getBigBoss_Public_Static_BigBoss_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664852);
		NativeMethodInfoPtr_getBigBoss2_Public_Static_BigBoss2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664853);
		NativeMethodInfoPtr_getBachTuoc_Public_Static_BachTuoc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664854);
		NativeMethodInfoPtr_getNewBoss_Public_Static_NewBoss_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664855);
		NativeMethodInfoPtr_removeBigBoss_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664856);
		NativeMethodInfoPtr_setAttack_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664857);
		NativeMethodInfoPtr_isSpecial_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664858);
		NativeMethodInfoPtr_isNewModStand_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664859);
		NativeMethodInfoPtr_isNewMod_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664860);
		NativeMethodInfoPtr_updateInjure_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664861);
		NativeMethodInfoPtr_updateMobStandWait_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664862);
		NativeMethodInfoPtr_updateMobAttack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664863);
		NativeMethodInfoPtr_updateMobWalk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664864);
		NativeMethodInfoPtr_getTemplate_Public_MobTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664865);
		NativeMethodInfoPtr_isPaint_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664866);
		NativeMethodInfoPtr_isUpdate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664867);
		NativeMethodInfoPtr_checkIsBoss_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664868);
		NativeMethodInfoPtr_updateHp_bar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664869);
		NativeMethodInfoPtr_paint_Public_Virtual_New_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664870);
		NativeMethodInfoPtr_getHPColor_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664871);
		NativeMethodInfoPtr_startDie_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664872);
		NativeMethodInfoPtr_attackOtherMob_Public_Void_Mob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664873);
		NativeMethodInfoPtr_getX_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664874);
		NativeMethodInfoPtr_getY_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664875);
		NativeMethodInfoPtr_getH_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664876);
		NativeMethodInfoPtr_getW_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664877);
		NativeMethodInfoPtr_stopMoving_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664878);
		NativeMethodInfoPtr_isInvisible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664879);
		NativeMethodInfoPtr_removeHoldEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664880);
		NativeMethodInfoPtr_removeBlindEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664881);
		NativeMethodInfoPtr_removeSleepEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664882);
		NativeMethodInfoPtr_GetFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664883);
		NativeMethodInfoPtr_isTypeNewMod_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mob>.NativeClassPtr, 100664884);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 60823, RefRangeEnd = 60829, XrefRangeStart = 60742, XrefRangeEnd = 60823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mob()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mob>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 61020, RefRangeEnd = 61024, XrefRangeStart = 60829, XrefRangeEnd = 61020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mob(int mobId, bool isDisable, bool isDontMove, bool isFire, bool isIce, bool isWind, int templateId, int sys, long hp, sbyte level, long maxp, short pointx, short pointy, sbyte status, sbyte levelBoss)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mob>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[15];
		*ptr = (nint)(&mobId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDisable;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDontMove;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFire;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isIce;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isWind;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &templateId;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &sys;
		*(long**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &hp;
		*(sbyte**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		*(long**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxp;
		*(short**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointx;
		*(short**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointy;
		*(sbyte**)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = &status;
		*(sbyte**)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelBoss;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Int64_SByte_Int64_Int16_Int16_SByte_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61031, RefRangeEnd = 61032, XrefRangeStart = 61024, XrefRangeEnd = 61031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isBigBoss()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isBigBoss_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 61046, RefRangeEnd = 61048, XrefRangeStart = 61032, XrefRangeEnd = 61046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void setBody(short id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_setBody_Public_Virtual_New_Void_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual void clearBody()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_clearBody_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61048, XrefRangeEnd = 61061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isExistNewMob(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isExistNewMob_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61077, RefRangeEnd = 61078, XrefRangeStart = 61061, XrefRangeEnd = 61077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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
	[CachedScanResults(RefRangeStart = 61098, RefRangeEnd = 61099, XrefRangeStart = 61078, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateShadown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateShadown_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61130, RefRangeEnd = 61131, XrefRangeStart = 61099, XrefRangeEnd = 61130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintShadow(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintShadow_Internal_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61131, XrefRangeEnd = 61144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateSuperEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateSuperEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61144, XrefRangeEnd = 61312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 61317, RefRangeEnd = 61321, XrefRangeStart = 61312, XrefRangeEnd = 61317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setInjure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setInjure_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61335, RefRangeEnd = 61336, XrefRangeStart = 61321, XrefRangeEnd = 61335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BigBoss getBigBoss()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBigBoss_Public_Static_BigBoss_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BigBoss>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61350, RefRangeEnd = 61351, XrefRangeStart = 61336, XrefRangeEnd = 61350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BigBoss2 getBigBoss2()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBigBoss2_Public_Static_BigBoss2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BigBoss2>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61365, RefRangeEnd = 61366, XrefRangeStart = 61351, XrefRangeEnd = 61365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BachTuoc getBachTuoc()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBachTuoc_Public_Static_BachTuoc_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BachTuoc>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61375, RefRangeEnd = 61376, XrefRangeStart = 61366, XrefRangeEnd = 61375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NewBoss getNewBoss(sbyte idBoss)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idBoss);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getNewBoss_Public_Static_NewBoss_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NewBoss>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61376, XrefRangeEnd = 61394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void removeBigBoss()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeBigBoss_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 61403, RefRangeEnd = 61407, XrefRangeStart = 61394, XrefRangeEnd = 61403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setAttack(Char cFocus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cFocus);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setAttack_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool isSpecial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isSpecial_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isNewModStand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNewModStand_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isNewMod()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNewMod_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61407, XrefRangeEnd = 61429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateInjure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateInjure_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61454, RefRangeEnd = 61455, XrefRangeStart = 61429, XrefRangeEnd = 61454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateMobStandWait()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMobStandWait_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61517, RefRangeEnd = 61518, XrefRangeStart = 61455, XrefRangeEnd = 61517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateMobAttack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMobAttack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61518, XrefRangeEnd = 61632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateMobWalk()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMobWalk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 61636, RefRangeEnd = 61649, XrefRangeStart = 61632, XrefRangeEnd = 61636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobTemplate getTemplate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTemplate_Public_MobTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MobTemplate>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61667, RefRangeEnd = 61668, XrefRangeStart = 61649, XrefRangeEnd = 61667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isPaint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPaint_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61668, XrefRangeEnd = 61674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isUpdate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6914, RefRangeEnd = 6915, XrefRangeStart = 6914, XrefRangeEnd = 6915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool checkIsBoss()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkIsBoss_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 61692, RefRangeEnd = 61702, XrefRangeStart = 61674, XrefRangeEnd = 61692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateHp_bar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateHp_bar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61702, XrefRangeEnd = 61713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_paint_Public_Virtual_New_Void_mGraphics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getHPColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHPColor_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 61719, RefRangeEnd = 61722, XrefRangeStart = 61713, XrefRangeEnd = 61719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startDie()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startDie_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 61731, RefRangeEnd = 61734, XrefRangeStart = 61722, XrefRangeEnd = 61731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void attackOtherMob(Mob mobToAttack)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mobToAttack);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_attackOtherMob_Public_Void_Mob_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
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

	[CallerCount(0)]
	public unsafe virtual void stopMoving()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopMoving_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool isInvisible()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInvisible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7003, RefRangeEnd = 7004, XrefRangeStart = 7003, XrefRangeEnd = 7004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeHoldEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeHoldEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61734, RefRangeEnd = 61735, XrefRangeStart = 61734, XrefRangeEnd = 61734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeBlindEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeBlindEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61735, RefRangeEnd = 61736, XrefRangeStart = 61735, XrefRangeEnd = 61735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeSleepEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeSleepEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61763, RefRangeEnd = 61764, XrefRangeStart = 61736, XrefRangeEnd = 61763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 61770, RefRangeEnd = 61775, XrefRangeStart = 61764, XrefRangeEnd = 61770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isTypeNewMod()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeNewMod_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Mob(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
