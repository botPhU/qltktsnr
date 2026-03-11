using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Effect_End : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Lvlpaint_All;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lvlpaint_Front;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lvlpaint_Mid;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lvlpaint_Mid_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lvlpaint_Behind;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_String_Lose;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_String_Win;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_String_Draw;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_FireWork;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_line_in;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_e8_rock;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_e8_ice;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_SUB_MaFuBa;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_SUB_Destroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_POW_Kamex10;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_POW_Destroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_POW_MaFuBa;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_GONG_Kamex10;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_GONG_Destroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_GONG_MaFuBa;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_Skill_Kamex10;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_Skill_Destroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_End_Skill_MaFuBa;

	private static readonly System.IntPtr NativeFieldInfoPtr_VecEffEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_fraImgEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_nFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_nFrame_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_typePaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeSub;

	private static readonly System.IntPtr NativeFieldInfoPtr_range;

	private static readonly System.IntPtr NativeFieldInfoPtr_idEndeff;

	private static readonly System.IntPtr NativeFieldInfoPtr_fRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_fMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_n_frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_dir;

	private static readonly System.IntPtr NativeFieldInfoPtr_dir_nguoc;

	private static readonly System.IntPtr NativeFieldInfoPtr_levelPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_f;

	private static readonly System.IntPtr NativeFieldInfoPtr_frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_fSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_vx;

	private static readonly System.IntPtr NativeFieldInfoPtr_vy;

	private static readonly System.IntPtr NativeFieldInfoPtr_x1000;

	private static readonly System.IntPtr NativeFieldInfoPtr_y1000;

	private static readonly System.IntPtr NativeFieldInfoPtr_vx1000;

	private static readonly System.IntPtr NativeFieldInfoPtr_vy1000;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy_throw;

	private static readonly System.IntPtr NativeFieldInfoPtr_vMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_toX;

	private static readonly System.IntPtr NativeFieldInfoPtr_toY;

	private static readonly System.IntPtr NativeFieldInfoPtr_stt;

	private static readonly System.IntPtr NativeFieldInfoPtr_dx;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAddSub;

	private static readonly System.IntPtr NativeFieldInfoPtr_charUse;

	private static readonly System.IntPtr NativeFieldInfoPtr_listObj;

	private static readonly System.IntPtr NativeFieldInfoPtr_target;

	private static readonly System.IntPtr NativeFieldInfoPtr_arrInfoEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_life;

	private static readonly System.IntPtr NativeFieldInfoPtr_goc_Arc;

	private static readonly System.IntPtr NativeFieldInfoPtr_va;

	private static readonly System.IntPtr NativeFieldInfoPtr_gocT_Arc;

	private static readonly System.IntPtr NativeFieldInfoPtr_mpaintone_Arrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_mImageArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_mXoayArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_rS;

	private static readonly System.IntPtr NativeFieldInfoPtr_angleS;

	private static readonly System.IntPtr NativeFieldInfoPtr_angleO;

	private static readonly System.IntPtr NativeFieldInfoPtr_iAngleS;

	private static readonly System.IntPtr NativeFieldInfoPtr_iDotS;

	private static readonly System.IntPtr NativeFieldInfoPtr_xArgS;

	private static readonly System.IntPtr NativeFieldInfoPtr_yArgS;

	private static readonly System.IntPtr NativeFieldInfoPtr_xDotS;

	private static readonly System.IntPtr NativeFieldInfoPtr_yDotS;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorStar;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorpaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexColorStar;

	private static readonly System.IntPtr NativeFieldInfoPtr_xline;

	private static readonly System.IntPtr NativeFieldInfoPtr_yline;

	private static readonly System.IntPtr NativeFieldInfoPtr_fra_skill;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Char_Point_Int32_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getImage_Public_Static_Image_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setSoundSkill_END_Public_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_create_Effect_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeEff_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createDanFocus_Public_Void_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateAngleXP_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFrameAngle_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_create_Arrow_Public_Void_Int32_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_create_Speed_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveTo_xy_Public_Void_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Arrow_Public_Void_mGraphics_FrameImage_Int32_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_End_String_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_End_String_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_End_String_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_FireWork_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_FireWork_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_FireWork_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Skill_Kamex10_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_Skill_Kamex10_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_Skill_Kamex10_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Skill_Destroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_Skill_Destroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_Skill_Destroy_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Skill_MaFuba_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_changeAngleStar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDotStar_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_Skill_MaFuba_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_Skill_MaFuba_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fill_Rect_Img_Private_Void_mGraphics_FrameImage_FrameImage_FrameImage_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LINE_IN_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_LINE_IN_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_create_Star_Line_In_Private_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_LINE_IN_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_End_Rock_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_End_Rock_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_End_Rock_Private_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updListObj_Mafuba_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hideListObj_Mafuba_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Img_Skill_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Gong_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_Gong_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_Gong_Private_Void_mGraphics_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Pow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_Pow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_Pow_Private_Void_mGraphics_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Sub_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd_Sub_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt_Sub_Private_Void_mGraphics_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set__Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upd__Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pnt__Private_Void_mGraphics_0;

	public unsafe static sbyte Lvlpaint_All
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lvlpaint_All, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lvlpaint_All, (void*)(&b));
		}
	}

	public unsafe static sbyte Lvlpaint_Front
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lvlpaint_Front, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lvlpaint_Front, (void*)(&b));
		}
	}

	public unsafe static sbyte Lvlpaint_Mid
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lvlpaint_Mid, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lvlpaint_Mid, (void*)(&b));
		}
	}

	public unsafe static sbyte Lvlpaint_Mid_2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lvlpaint_Mid_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lvlpaint_Mid_2, (void*)(&b));
		}
	}

	public unsafe static sbyte Lvlpaint_Behind
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Lvlpaint_Behind, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Lvlpaint_Behind, (void*)(&b));
		}
	}

	public unsafe static short End_String_Lose
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_String_Lose, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_String_Lose, (void*)(&num));
		}
	}

	public unsafe static short End_String_Win
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_String_Win, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_String_Win, (void*)(&num));
		}
	}

	public unsafe static short End_String_Draw
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_String_Draw, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_String_Draw, (void*)(&num));
		}
	}

	public unsafe static short End_FireWork
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_FireWork, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_FireWork, (void*)(&num));
		}
	}

	public unsafe static short End_line_in
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_line_in, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_line_in, (void*)(&num));
		}
	}

	public unsafe static short End_e8_rock
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_e8_rock, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_e8_rock, (void*)(&num));
		}
	}

	public unsafe static short End_e8_ice
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_e8_ice, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_e8_ice, (void*)(&num));
		}
	}

	public unsafe static short End_SUB_MaFuBa
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_SUB_MaFuBa, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_SUB_MaFuBa, (void*)(&num));
		}
	}

	public unsafe static short End_SUB_Destroy
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_SUB_Destroy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_SUB_Destroy, (void*)(&num));
		}
	}

	public unsafe static short End_POW_Kamex10
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_POW_Kamex10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_POW_Kamex10, (void*)(&num));
		}
	}

	public unsafe static short End_POW_Destroy
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_POW_Destroy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_POW_Destroy, (void*)(&num));
		}
	}

	public unsafe static short End_POW_MaFuBa
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_POW_MaFuBa, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_POW_MaFuBa, (void*)(&num));
		}
	}

	public unsafe static short End_GONG_Kamex10
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_GONG_Kamex10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_GONG_Kamex10, (void*)(&num));
		}
	}

	public unsafe static short End_GONG_Destroy
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_GONG_Destroy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_GONG_Destroy, (void*)(&num));
		}
	}

	public unsafe static short End_GONG_MaFuBa
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_GONG_MaFuBa, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_GONG_MaFuBa, (void*)(&num));
		}
	}

	public unsafe static short End_Skill_Kamex10
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_Skill_Kamex10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_Skill_Kamex10, (void*)(&num));
		}
	}

	public unsafe static short End_Skill_Destroy
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_Skill_Destroy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_Skill_Destroy, (void*)(&num));
		}
	}

	public unsafe static short End_Skill_MaFuBa
	{
		get
		{
			Unsafe.SkipInit(out short result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_End_Skill_MaFuBa, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_End_Skill_MaFuBa, (void*)(&num));
		}
	}

	public unsafe MyVector VecEffEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VecEffEnd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VecEffEnd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe FrameImage fraImgEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraImgEff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fraImgEff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameImage));
		}
	}

	public unsafe Il2CppStructArray<byte> nFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<byte> nFrame_2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame_2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame_2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int typePaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typePaint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typePaint)) = num;
		}
	}

	public unsafe int typeEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeEffect);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeEffect)) = num;
		}
	}

	public unsafe int typeSub
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeSub);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeSub)) = num;
		}
	}

	public unsafe int range
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_range)) = num;
		}
	}

	public unsafe short idEndeff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idEndeff);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idEndeff)) = num;
		}
	}

	public unsafe int fRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fRemove);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fRemove)) = num;
		}
	}

	public unsafe int fMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fMove);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fMove)) = num;
		}
	}

	public unsafe int n_frame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n_frame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n_frame)) = num;
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

	public unsafe int dir_nguoc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir_nguoc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir_nguoc)) = num;
		}
	}

	public unsafe int levelPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelPaint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_levelPaint)) = num;
		}
	}

	public unsafe int f
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f)) = num;
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

	public unsafe int fSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fSpeed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fSpeed)) = num;
		}
	}

	public unsafe int vx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vx)) = num;
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

	public unsafe int x1000
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x1000);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x1000)) = num;
		}
	}

	public unsafe int y1000
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y1000);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y1000)) = num;
		}
	}

	public unsafe int vx1000
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vx1000);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vx1000)) = num;
		}
	}

	public unsafe int vy1000
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vy1000);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vy1000)) = num;
		}
	}

	public unsafe int dy_throw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy_throw);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy_throw)) = num;
		}
	}

	public unsafe int vMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vMax)) = num;
		}
	}

	public unsafe int toX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toX)) = num;
		}
	}

	public unsafe int toY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toY)) = num;
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

	public unsafe int dx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx)) = num;
		}
	}

	public unsafe int dy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy)) = num;
		}
	}

	public unsafe short timeRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRemove);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRemove)) = num;
		}
	}

	public unsafe long time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = num;
		}
	}

	public unsafe bool isRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRemove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRemove)) = flag;
		}
	}

	public unsafe bool isAddSub
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAddSub);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAddSub)) = flag;
		}
	}

	public unsafe Char charUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charUse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charUse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe Il2CppReferenceArray<Point> listObj
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listObj);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Point>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listObj)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Point target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<short>> arrInfoEff
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_arrInfoEff, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<short>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_arrInfoEff, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int life
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_life);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_life)) = num;
		}
	}

	public unsafe int goc_Arc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goc_Arc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_goc_Arc)) = num;
		}
	}

	public unsafe int va
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_va);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_va)) = num;
		}
	}

	public unsafe int gocT_Arc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gocT_Arc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gocT_Arc)) = num;
		}
	}

	public unsafe Il2CppStructArray<byte> mpaintone_Arrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpaintone_Arrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mpaintone_Arrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<byte> mImageArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mImageArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mImageArrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<byte> mXoayArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mXoayArrow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mXoayArrow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int rS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rS);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rS)) = num;
		}
	}

	public unsafe int angleS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleS);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleS)) = num;
		}
	}

	public unsafe int angleO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleO);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_angleO)) = num;
		}
	}

	public unsafe int iAngleS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iAngleS);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iAngleS)) = num;
		}
	}

	public unsafe int iDotS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDotS);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iDotS)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> xArgS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xArgS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xArgS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> yArgS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yArgS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yArgS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> xDotS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xDotS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xDotS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> yDotS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yDotS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yDotS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> colorStar
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorStar, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorStar, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> colorpaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorpaint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorpaint)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int indexColorStar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexColorStar);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexColorStar)) = num;
		}
	}

	public unsafe int xline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xline);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xline)) = num;
		}
	}

	public unsafe int yline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yline);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yline)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<FrameImage> fra_skill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fra_skill);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FrameImage>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fra_skill)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static Effect_End()
	{
		Il2CppClassPointerStore<Effect_End>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Effect_End");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Effect_End>.NativeClassPtr);
		NativeFieldInfoPtr_Lvlpaint_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "Lvlpaint_All");
		NativeFieldInfoPtr_Lvlpaint_Front = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "Lvlpaint_Front");
		NativeFieldInfoPtr_Lvlpaint_Mid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "Lvlpaint_Mid");
		NativeFieldInfoPtr_Lvlpaint_Mid_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "Lvlpaint_Mid_2");
		NativeFieldInfoPtr_Lvlpaint_Behind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "Lvlpaint_Behind");
		NativeFieldInfoPtr_End_String_Lose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_String_Lose");
		NativeFieldInfoPtr_End_String_Win = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_String_Win");
		NativeFieldInfoPtr_End_String_Draw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_String_Draw");
		NativeFieldInfoPtr_End_FireWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_FireWork");
		NativeFieldInfoPtr_End_line_in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_line_in");
		NativeFieldInfoPtr_End_e8_rock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_e8_rock");
		NativeFieldInfoPtr_End_e8_ice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_e8_ice");
		NativeFieldInfoPtr_End_SUB_MaFuBa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_SUB_MaFuBa");
		NativeFieldInfoPtr_End_SUB_Destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_SUB_Destroy");
		NativeFieldInfoPtr_End_POW_Kamex10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_POW_Kamex10");
		NativeFieldInfoPtr_End_POW_Destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_POW_Destroy");
		NativeFieldInfoPtr_End_POW_MaFuBa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_POW_MaFuBa");
		NativeFieldInfoPtr_End_GONG_Kamex10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_GONG_Kamex10");
		NativeFieldInfoPtr_End_GONG_Destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_GONG_Destroy");
		NativeFieldInfoPtr_End_GONG_MaFuBa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_GONG_MaFuBa");
		NativeFieldInfoPtr_End_Skill_Kamex10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_Skill_Kamex10");
		NativeFieldInfoPtr_End_Skill_Destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_Skill_Destroy");
		NativeFieldInfoPtr_End_Skill_MaFuBa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "End_Skill_MaFuBa");
		NativeFieldInfoPtr_VecEffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "VecEffEnd");
		NativeFieldInfoPtr_fraImgEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "fraImgEff");
		NativeFieldInfoPtr_nFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "nFrame");
		NativeFieldInfoPtr_nFrame_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "nFrame_2");
		NativeFieldInfoPtr_typePaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "typePaint");
		NativeFieldInfoPtr_typeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "typeEffect");
		NativeFieldInfoPtr_typeSub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "typeSub");
		NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "range");
		NativeFieldInfoPtr_idEndeff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "idEndeff");
		NativeFieldInfoPtr_fRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "fRemove");
		NativeFieldInfoPtr_fMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "fMove");
		NativeFieldInfoPtr_n_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "n_frame");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "y");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "w");
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "h");
		NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "dir");
		NativeFieldInfoPtr_dir_nguoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "dir_nguoc");
		NativeFieldInfoPtr_levelPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "levelPaint");
		NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "f");
		NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "frame");
		NativeFieldInfoPtr_fSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "fSpeed");
		NativeFieldInfoPtr_vx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "vx");
		NativeFieldInfoPtr_vy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "vy");
		NativeFieldInfoPtr_x1000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "x1000");
		NativeFieldInfoPtr_y1000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "y1000");
		NativeFieldInfoPtr_vx1000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "vx1000");
		NativeFieldInfoPtr_vy1000 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "vy1000");
		NativeFieldInfoPtr_dy_throw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "dy_throw");
		NativeFieldInfoPtr_vMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "vMax");
		NativeFieldInfoPtr_toX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "toX");
		NativeFieldInfoPtr_toY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "toY");
		NativeFieldInfoPtr_stt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "stt");
		NativeFieldInfoPtr_dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "dx");
		NativeFieldInfoPtr_dy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "dy");
		NativeFieldInfoPtr_timeRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "timeRemove");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "time");
		NativeFieldInfoPtr_isRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "isRemove");
		NativeFieldInfoPtr_isAddSub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "isAddSub");
		NativeFieldInfoPtr_charUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "charUse");
		NativeFieldInfoPtr_listObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "listObj");
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "target");
		NativeFieldInfoPtr_arrInfoEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "arrInfoEff");
		NativeFieldInfoPtr_life = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "life");
		NativeFieldInfoPtr_goc_Arc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "goc_Arc");
		NativeFieldInfoPtr_va = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "va");
		NativeFieldInfoPtr_gocT_Arc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "gocT_Arc");
		NativeFieldInfoPtr_mpaintone_Arrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "mpaintone_Arrow");
		NativeFieldInfoPtr_mImageArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "mImageArrow");
		NativeFieldInfoPtr_mXoayArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "mXoayArrow");
		NativeFieldInfoPtr_rS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "rS");
		NativeFieldInfoPtr_angleS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "angleS");
		NativeFieldInfoPtr_angleO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "angleO");
		NativeFieldInfoPtr_iAngleS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "iAngleS");
		NativeFieldInfoPtr_iDotS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "iDotS");
		NativeFieldInfoPtr_xArgS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "xArgS");
		NativeFieldInfoPtr_yArgS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "yArgS");
		NativeFieldInfoPtr_xDotS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "xDotS");
		NativeFieldInfoPtr_yDotS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "yDotS");
		NativeFieldInfoPtr_colorStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "colorStar");
		NativeFieldInfoPtr_colorpaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "colorpaint");
		NativeFieldInfoPtr_indexColorStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "indexColorStar");
		NativeFieldInfoPtr_xline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "xline");
		NativeFieldInfoPtr_yline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "yline");
		NativeFieldInfoPtr_fra_skill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, "fra_skill");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Char_Point_Int32_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_getImage_Public_Static_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_setSoundSkill_END_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_create_Effect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_paint_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_removeEff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_createDanFocus_Public_Void_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_updateAngleXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663941);
		NativeMethodInfoPtr_setFrameAngle_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663942);
		NativeMethodInfoPtr_create_Arrow_Public_Void_Int32_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_create_Speed_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_moveTo_xy_Public_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663945);
		NativeMethodInfoPtr_paint_Arrow_Public_Void_mGraphics_FrameImage_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_set_End_String_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_upd_End_String_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_pnt_End_String_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_set_FireWork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663950);
		NativeMethodInfoPtr_upd_FireWork_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_pnt_FireWork_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_set_Skill_Kamex10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr_upd_Skill_Kamex10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr_pnt_Skill_Kamex10_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663955);
		NativeMethodInfoPtr_set_Skill_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663956);
		NativeMethodInfoPtr_upd_Skill_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663957);
		NativeMethodInfoPtr_pnt_Skill_Destroy_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663958);
		NativeMethodInfoPtr_set_Skill_MaFuba_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663959);
		NativeMethodInfoPtr_changeAngleStar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663960);
		NativeMethodInfoPtr_setDotStar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_upd_Skill_MaFuba_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr_pnt_Skill_MaFuba_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663963);
		NativeMethodInfoPtr_Fill_Rect_Img_Private_Void_mGraphics_FrameImage_FrameImage_FrameImage_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663964);
		NativeMethodInfoPtr_set_LINE_IN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_upd_LINE_IN_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663966);
		NativeMethodInfoPtr_create_Star_Line_In_Private_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_pnt_LINE_IN_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr_set_End_Rock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663969);
		NativeMethodInfoPtr_upd_End_Rock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_pnt_End_Rock_Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_updListObj_Mafuba_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_hideListObj_Mafuba_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_get_Img_Skill_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_set_Gong_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_upd_Gong_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_pnt_Gong_Private_Void_mGraphics_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_set_Pow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_upd_Pow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_pnt_Pow_Private_Void_mGraphics_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_set_Sub_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_upd_Sub_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_pnt_Sub_Private_Void_mGraphics_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_set__Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_upd__Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_pnt__Private_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Effect_End>.NativeClassPtr, 100663986);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33381, XrefRangeEnd = 33431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Effect_End(int type, int typeSub, int x, int y, int levelPaint, int dir, short timeRemove, Il2CppReferenceArray<Point> listObj)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Effect_End>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeSub;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelPaint;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(short**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeRemove;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33473, RefRangeEnd = 33474, XrefRangeStart = 33431, XrefRangeEnd = 33473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Effect_End(int type, int typeSub, int typePaint, Char charUse, Point target, int levelPaint, short timeRemove, short range)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Effect_End>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeSub;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePaint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charUse);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelPaint;
		*(short**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeRemove;
		*(short**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Char_Point_Int32_Int16_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33524, RefRangeEnd = 33525, XrefRangeStart = 33474, XrefRangeEnd = 33524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Effect_End(int type, int typeSub, int typePaint, int x, int y, int levelPaint, int dir, short timeRemove, Il2CppReferenceArray<Point> listObj)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Effect_End>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeSub;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typePaint;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &levelPaint;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		*(short**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeRemove;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)listObj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Int16_Il2CppReferenceArray_1_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33536, RefRangeEnd = 33537, XrefRangeStart = 33525, XrefRangeEnd = 33536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image getImage(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getImage_Public_Static_Image_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33548, RefRangeEnd = 33549, XrefRangeStart = 33537, XrefRangeEnd = 33548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setSoundSkill_END(int x, int y, int typeEffect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeEffect;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setSoundSkill_END_Public_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 33623, RefRangeEnd = 33626, XrefRangeStart = 33549, XrefRangeEnd = 33623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void create_Effect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_create_Effect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33680, RefRangeEnd = 33681, XrefRangeStart = 33626, XrefRangeEnd = 33680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33736, RefRangeEnd = 33737, XrefRangeStart = 33681, XrefRangeEnd = 33736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void removeEff()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeEff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33737, XrefRangeEnd = 33749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createDanFocus(bool isRandom, Char obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isRandom);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createDanFocus_Public_Void_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33749, XrefRangeEnd = 33775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateAngleXP(int fmove)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fmove);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateAngleXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33775, RefRangeEnd = 33776, XrefRangeStart = 33775, XrefRangeEnd = 33775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int setFrameAngle(int goc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&goc);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFrameAngle_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33776, XrefRangeEnd = 33794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void create_Arrow(int vMax, Point targetPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vMax);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_create_Arrow_Public_Void_Int32_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33794, XrefRangeEnd = 33806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void create_Speed(int dx, int dy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dy;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_create_Speed_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33806, XrefRangeEnd = 33843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void moveTo_xy(int toX, int toY, int fMove, int typeEff_End, int rangeEnd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&toX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &toY;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fMove;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeEff_End;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rangeEnd;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveTo_xy_Public_Void_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33843, XrefRangeEnd = 33847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint_Arrow(mGraphics g, FrameImage frm, int index, int x, int y, int anchor, bool isCountFr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frm);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCountFr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Arrow_Public_Void_mGraphics_FrameImage_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33847, XrefRangeEnd = 33862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_End_String(int typeEffect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeEffect);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_End_String_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33862, XrefRangeEnd = 33870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_End_String()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_End_String_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33870, XrefRangeEnd = 33871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_End_String(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_End_String_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33901, RefRangeEnd = 33902, XrefRangeStart = 33871, XrefRangeEnd = 33901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_FireWork()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FireWork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33926, RefRangeEnd = 33927, XrefRangeStart = 33902, XrefRangeEnd = 33926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_FireWork()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_FireWork_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33927, XrefRangeEnd = 33933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_FireWork(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_FireWork_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33933, XrefRangeEnd = 33949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_Skill_Kamex10()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Skill_Kamex10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33949, XrefRangeEnd = 33960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_Skill_Kamex10()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_Skill_Kamex10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33974, RefRangeEnd = 33975, XrefRangeStart = 33960, XrefRangeEnd = 33974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_Skill_Kamex10(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_Skill_Kamex10_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33977, RefRangeEnd = 33978, XrefRangeStart = 33975, XrefRangeEnd = 33977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_Skill_Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Skill_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34007, RefRangeEnd = 34008, XrefRangeStart = 33978, XrefRangeEnd = 34007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_Skill_Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_Skill_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34022, RefRangeEnd = 34023, XrefRangeStart = 34008, XrefRangeEnd = 34022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_Skill_Destroy(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_Skill_Destroy_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34053, RefRangeEnd = 34054, XrefRangeStart = 34023, XrefRangeEnd = 34053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_Skill_MaFuba()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Skill_MaFuba_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void changeAngleStar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_changeAngleStar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34054, XrefRangeEnd = 34065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDotStar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDotStar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34094, RefRangeEnd = 34095, XrefRangeStart = 34065, XrefRangeEnd = 34094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_Skill_MaFuba()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_Skill_MaFuba_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34106, RefRangeEnd = 34107, XrefRangeStart = 34095, XrefRangeEnd = 34106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_Skill_MaFuba(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_Skill_MaFuba_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34107, XrefRangeEnd = 34113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Fill_Rect_Img(mGraphics g, FrameImage head, FrameImage body, FrameImage foot, int frame, int x, int y, int w)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)head);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)body);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)foot);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &frame;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fill_Rect_Img_Private_Void_mGraphics_FrameImage_FrameImage_FrameImage_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34113, XrefRangeEnd = 34118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_LINE_IN()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LINE_IN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34134, RefRangeEnd = 34135, XrefRangeStart = 34118, XrefRangeEnd = 34134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_LINE_IN()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_LINE_IN_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 34197, RefRangeEnd = 34200, XrefRangeStart = 34135, XrefRangeEnd = 34197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void create_Star_Line_In(int vline, int minline, int maxline, int numpoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&vline);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minline;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxline;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numpoint;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_create_Star_Line_In_Private_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34208, RefRangeEnd = 34209, XrefRangeStart = 34200, XrefRangeEnd = 34208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_LINE_IN(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_LINE_IN_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34240, RefRangeEnd = 34241, XrefRangeStart = 34209, XrefRangeEnd = 34240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_End_Rock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_End_Rock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34241, XrefRangeEnd = 34248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_End_Rock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_End_Rock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34248, XrefRangeEnd = 34259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_End_Rock(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_End_Rock_Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34276, RefRangeEnd = 34277, XrefRangeStart = 34259, XrefRangeEnd = 34276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updListObj_Mafuba(bool ismafuba)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ismafuba);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updListObj_Mafuba_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34277, XrefRangeEnd = 34294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void hideListObj_Mafuba(bool ishide)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ishide);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hideListObj_Mafuba_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 34365, RefRangeEnd = 34368, XrefRangeStart = 34294, XrefRangeEnd = 34365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void get_Img_Skill()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Img_Skill_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34369, RefRangeEnd = 34370, XrefRangeStart = 34368, XrefRangeEnd = 34369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_Gong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Gong_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34370, XrefRangeEnd = 34371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_Gong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_Gong_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34371, XrefRangeEnd = 34372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_Gong(mGraphics g, int anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_Gong_Private_Void_mGraphics_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34372, XrefRangeEnd = 34384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_Pow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Pow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34384, XrefRangeEnd = 34385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_Pow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_Pow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34385, XrefRangeEnd = 34386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_Pow(mGraphics g, int anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_Pow_Private_Void_mGraphics_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void set_Sub()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Sub_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34386, XrefRangeEnd = 34387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_Sub()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd_Sub_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 34388, RefRangeEnd = 34390, XrefRangeStart = 34387, XrefRangeEnd = 34388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_Sub(mGraphics g, int anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt_Sub_Private_Void_mGraphics_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void set_()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set__Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void upd_()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upd__Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pnt_(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pnt__Private_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Effect_End(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
