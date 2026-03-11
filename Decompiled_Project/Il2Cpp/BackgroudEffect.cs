using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class BackgroudEffect : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_vBgEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_vx;

	private static readonly System.IntPtr NativeFieldInfoPtr_vy;

	private static readonly System.IntPtr NativeFieldInfoPtr_wP;

	private static readonly System.IntPtr NativeFieldInfoPtr_num;

	private static readonly System.IntPtr NativeFieldInfoPtr_xShip;

	private static readonly System.IntPtr NativeFieldInfoPtr_yShip;

	private static readonly System.IntPtr NativeFieldInfoPtr_way;

	private static readonly System.IntPtr NativeFieldInfoPtr_trans;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameFire;

	private static readonly System.IntPtr NativeFieldInfoPtr_tFire;

	private static readonly System.IntPtr NativeFieldInfoPtr_tStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFly;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSnow;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgHatMua;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMua1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMua2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSao;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgLacay;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgShip;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFire1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFire2;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_sum;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_xx;

	private static readonly System.IntPtr NativeFieldInfoPtr_waterY;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRainEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_t;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_yWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_MUA;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LATRAIDAT_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LATRAIDAT_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SAMSET;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SAO;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LANAMEK_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LASAYAI_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LANAMEK_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SHIP_TRAIDAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_HANHTINH;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_WATER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SNOW;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_MUA_FRONT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_CLOUD;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_FOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LUNAR_YEAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_PIXEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_water1;

	private static readonly System.IntPtr NativeFieldInfoPtr_water2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgChamTron1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgChamTron2;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFog;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintFar;

	private static readonly System.IntPtr NativeFieldInfoPtr_nCloud;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgCloud1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFog;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloudw;

	private static readonly System.IntPtr NativeFieldInfoPtr_xfog;

	private static readonly System.IntPtr NativeFieldInfoPtr_yfog;

	private static readonly System.IntPtr NativeFieldInfoPtr_fogw;

	private static readonly System.IntPtr NativeFieldInfoPtr_dem;

	private static readonly System.IntPtr NativeFieldInfoPtr_tick;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearImage_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHaveRain_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initCloud_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateCloud2_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateFog_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCloud2_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintFog_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reloadShip_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintWater_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintFar_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintFront_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintLacay1_Public_Void_mGraphics_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintLacay2_Public_Void_mGraphics_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBehindTile_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBack_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addEffect_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addWater_Public_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintWaterAll_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBehindTileAll_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintFrontAll_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintFarAll_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintBackAll_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateEff_Public_Static_Void_0;

	public unsafe static MyVector vBgEffect
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vBgEffect, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vBgEffect, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe Il2CppStructArray<int> x
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> y
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> vx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vx);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> vy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> wP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int num
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_num);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_num)) = num;
		}
	}

	public unsafe int xShip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xShip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xShip)) = num;
		}
	}

	public unsafe int yShip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yShip);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yShip)) = num;
		}
	}

	public unsafe int way
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_way);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_way)) = num;
		}
	}

	public unsafe int trans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans)) = num;
		}
	}

	public unsafe int frameFire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameFire);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameFire)) = num;
		}
	}

	public unsafe int tFire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tFire);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tFire)) = num;
		}
	}

	public unsafe int tStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tStart)) = num;
		}
	}

	public unsafe int speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed)) = num;
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

	public unsafe static Image imgSnow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSnow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSnow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgHatMua
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgHatMua, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgHatMua, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMua1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMua1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMua1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMua2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMua2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMua2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgSao
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSao, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSao, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgLacay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLacay, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLacay, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgShip
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgShip, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgShip, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
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

	public unsafe static Image imgFire2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgFire2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgFire2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Il2CppStructArray<int> type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int sum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sum)) = num;
		}
	}

	public unsafe int typeEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeEff);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeEff)) = num;
		}
	}

	public unsafe int xx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xx)) = num;
		}
	}

	public unsafe int waterY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waterY)) = num;
		}
	}

	public unsafe Il2CppStructArray<bool> isRainEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRainEffect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRainEffect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> frame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> t
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_t)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<bool> activeEff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeEff);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_activeEff)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int yWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yWater);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yWater)) = num;
		}
	}

	public unsafe int colorWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorWater);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorWater)) = num;
		}
	}

	public unsafe static int TYPE_MUA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_MUA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_MUA, (void*)(&num));
		}
	}

	public unsafe static int TYPE_LATRAIDAT_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LATRAIDAT_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LATRAIDAT_1, (void*)(&num));
		}
	}

	public unsafe static int TYPE_LATRAIDAT_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LATRAIDAT_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LATRAIDAT_2, (void*)(&num));
		}
	}

	public unsafe static int TYPE_SAMSET
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SAMSET, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SAMSET, (void*)(&num));
		}
	}

	public unsafe static int TYPE_SAO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SAO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SAO, (void*)(&num));
		}
	}

	public unsafe static int TYPE_LANAMEK_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LANAMEK_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LANAMEK_1, (void*)(&num));
		}
	}

	public unsafe static int TYPE_LASAYAI_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LASAYAI_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LASAYAI_1, (void*)(&num));
		}
	}

	public unsafe static int TYPE_LANAMEK_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LANAMEK_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LANAMEK_2, (void*)(&num));
		}
	}

	public unsafe static int TYPE_SHIP_TRAIDAT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SHIP_TRAIDAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SHIP_TRAIDAT, (void*)(&num));
		}
	}

	public unsafe static int TYPE_HANHTINH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_HANHTINH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_HANHTINH, (void*)(&num));
		}
	}

	public unsafe static int TYPE_WATER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_WATER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_WATER, (void*)(&num));
		}
	}

	public unsafe static int TYPE_SNOW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SNOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SNOW, (void*)(&num));
		}
	}

	public unsafe static int TYPE_MUA_FRONT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_MUA_FRONT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_MUA_FRONT, (void*)(&num));
		}
	}

	public unsafe static int TYPE_CLOUD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_CLOUD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_CLOUD, (void*)(&num));
		}
	}

	public unsafe static int TYPE_FOG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_FOG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_FOG, (void*)(&num));
		}
	}

	public unsafe static int TYPE_LUNAR_YEAR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LUNAR_YEAR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LUNAR_YEAR, (void*)(&num));
		}
	}

	public unsafe static int PIXEL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PIXEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PIXEL, (void*)(&num));
		}
	}

	public unsafe static Image water1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_water1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_water1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image water2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_water2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_water2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgChamTron1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgChamTron1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgChamTron1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgChamTron2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgChamTron2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgChamTron2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static bool isFog
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isFog, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isFog, (void*)(&flag));
		}
	}

	public unsafe static bool isPaintFar
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintFar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintFar, (void*)(&flag));
		}
	}

	public unsafe static int nCloud
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nCloud, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nCloud, (void*)(&num));
		}
	}

	public unsafe static Image imgCloud1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgCloud1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgCloud1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgFog
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgFog, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgFog, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int cloudw
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cloudw, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cloudw, (void*)(&num));
		}
	}

	public unsafe static int xfog
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xfog, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xfog, (void*)(&num));
		}
	}

	public unsafe static int yfog
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yfog, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yfog, (void*)(&num));
		}
	}

	public unsafe static int fogw
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fogw, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fogw, (void*)(&num));
		}
	}

	public unsafe Il2CppStructArray<int> dem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> tick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tick);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tick)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static BackgroudEffect()
	{
		Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BackgroudEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr);
		NativeFieldInfoPtr_vBgEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "vBgEffect");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "y");
		NativeFieldInfoPtr_vx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "vx");
		NativeFieldInfoPtr_vy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "vy");
		NativeFieldInfoPtr_wP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "wP");
		NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "num");
		NativeFieldInfoPtr_xShip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "xShip");
		NativeFieldInfoPtr_yShip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "yShip");
		NativeFieldInfoPtr_way = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "way");
		NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "trans");
		NativeFieldInfoPtr_frameFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "frameFire");
		NativeFieldInfoPtr_tFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "tFire");
		NativeFieldInfoPtr_tStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "tStart");
		NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "speed");
		NativeFieldInfoPtr_isFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "isFly");
		NativeFieldInfoPtr_imgSnow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgSnow");
		NativeFieldInfoPtr_imgHatMua = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgHatMua");
		NativeFieldInfoPtr_imgMua1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgMua1");
		NativeFieldInfoPtr_imgMua2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgMua2");
		NativeFieldInfoPtr_imgSao = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgSao");
		NativeFieldInfoPtr_imgLacay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgLacay");
		NativeFieldInfoPtr_imgShip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgShip");
		NativeFieldInfoPtr_imgFire1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgFire1");
		NativeFieldInfoPtr_imgFire2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgFire2");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "type");
		NativeFieldInfoPtr_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "sum");
		NativeFieldInfoPtr_typeEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "typeEff");
		NativeFieldInfoPtr_xx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "xx");
		NativeFieldInfoPtr_waterY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "waterY");
		NativeFieldInfoPtr_isRainEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "isRainEffect");
		NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "frame");
		NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "t");
		NativeFieldInfoPtr_activeEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "activeEff");
		NativeFieldInfoPtr_yWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "yWater");
		NativeFieldInfoPtr_colorWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "colorWater");
		NativeFieldInfoPtr_TYPE_MUA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_MUA");
		NativeFieldInfoPtr_TYPE_LATRAIDAT_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_LATRAIDAT_1");
		NativeFieldInfoPtr_TYPE_LATRAIDAT_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_LATRAIDAT_2");
		NativeFieldInfoPtr_TYPE_SAMSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_SAMSET");
		NativeFieldInfoPtr_TYPE_SAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_SAO");
		NativeFieldInfoPtr_TYPE_LANAMEK_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_LANAMEK_1");
		NativeFieldInfoPtr_TYPE_LASAYAI_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_LASAYAI_1");
		NativeFieldInfoPtr_TYPE_LANAMEK_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_LANAMEK_2");
		NativeFieldInfoPtr_TYPE_SHIP_TRAIDAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_SHIP_TRAIDAT");
		NativeFieldInfoPtr_TYPE_HANHTINH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_HANHTINH");
		NativeFieldInfoPtr_TYPE_WATER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_WATER");
		NativeFieldInfoPtr_TYPE_SNOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_SNOW");
		NativeFieldInfoPtr_TYPE_MUA_FRONT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_MUA_FRONT");
		NativeFieldInfoPtr_TYPE_CLOUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_CLOUD");
		NativeFieldInfoPtr_TYPE_FOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_FOG");
		NativeFieldInfoPtr_TYPE_LUNAR_YEAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "TYPE_LUNAR_YEAR");
		NativeFieldInfoPtr_PIXEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "PIXEL");
		NativeFieldInfoPtr_water1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "water1");
		NativeFieldInfoPtr_water2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "water2");
		NativeFieldInfoPtr_imgChamTron1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgChamTron1");
		NativeFieldInfoPtr_imgChamTron2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgChamTron2");
		NativeFieldInfoPtr_isFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "isFog");
		NativeFieldInfoPtr_isPaintFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "isPaintFar");
		NativeFieldInfoPtr_nCloud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "nCloud");
		NativeFieldInfoPtr_imgCloud1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgCloud1");
		NativeFieldInfoPtr_imgFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "imgFog");
		NativeFieldInfoPtr_cloudw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "cloudw");
		NativeFieldInfoPtr_xfog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "xfog");
		NativeFieldInfoPtr_yfog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "yfog");
		NativeFieldInfoPtr_fogw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "fogw");
		NativeFieldInfoPtr_dem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "dem");
		NativeFieldInfoPtr_tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, "tick");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_clearImage_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_isHaveRain_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_initCloud_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_updateCloud2_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_updateFog_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_paintCloud2_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_paintFog_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_reloadShip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_paintWater_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_paintFar_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_paintFront_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_paintLacay1_Public_Void_mGraphics_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_paintLacay2_Public_Void_mGraphics_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_paintBehindTile_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_paintBack_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_addEffect_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_addWater_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_paintWaterAll_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_paintBehindTileAll_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_paintFrontAll_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_paintFarAll_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_paintBackAll_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_updateEff_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr, 100663436);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7041, RefRangeEnd = 7043, XrefRangeStart = 7005, XrefRangeEnd = 7041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BackgroudEffect(int typeS)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackgroudEffect>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeS);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7047, RefRangeEnd = 7048, XrefRangeStart = 7043, XrefRangeEnd = 7047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearImage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearImage_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7059, RefRangeEnd = 7060, XrefRangeStart = 7048, XrefRangeEnd = 7059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isHaveRain()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHaveRain_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void initCloud()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initCloud_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7060, XrefRangeEnd = 7071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateCloud2()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateCloud2_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateFog()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateFog_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7084, RefRangeEnd = 7085, XrefRangeStart = 7071, XrefRangeEnd = 7084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintCloud2(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCloud2_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintFog(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintFog_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7085, XrefRangeEnd = 7106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reloadShip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reloadShip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7106, XrefRangeEnd = 7115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintWater(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintWater_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7133, RefRangeEnd = 7134, XrefRangeStart = 7115, XrefRangeEnd = 7133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintFar(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintFar_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7144, RefRangeEnd = 7145, XrefRangeStart = 7134, XrefRangeEnd = 7144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7203, RefRangeEnd = 7204, XrefRangeStart = 7145, XrefRangeEnd = 7203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintFront(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintFront_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7241, RefRangeEnd = 7242, XrefRangeStart = 7204, XrefRangeEnd = 7241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintLacay1(mGraphics g, Image img)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintLacay1_Public_Void_mGraphics_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7279, RefRangeEnd = 7280, XrefRangeStart = 7242, XrefRangeEnd = 7279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintLacay2(mGraphics g, Image img)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintLacay2_Public_Void_mGraphics_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7292, RefRangeEnd = 7293, XrefRangeStart = 7280, XrefRangeEnd = 7292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintBehindTile(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBehindTile_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7343, RefRangeEnd = 7344, XrefRangeStart = 7293, XrefRangeEnd = 7343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintBack(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBack_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 7356, RefRangeEnd = 7361, XrefRangeStart = 7344, XrefRangeEnd = 7356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addEffect(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addEffect_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7370, RefRangeEnd = 7371, XrefRangeStart = 7361, XrefRangeEnd = 7370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addWater(int color, int yWater)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&color);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yWater;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addWater_Public_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7391, RefRangeEnd = 7392, XrefRangeStart = 7371, XrefRangeEnd = 7391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintWaterAll(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintWaterAll_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7404, RefRangeEnd = 7406, XrefRangeStart = 7392, XrefRangeEnd = 7404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintBehindTileAll(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBehindTileAll_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7418, RefRangeEnd = 7419, XrefRangeStart = 7406, XrefRangeEnd = 7418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintFrontAll(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintFrontAll_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7431, RefRangeEnd = 7433, XrefRangeStart = 7419, XrefRangeEnd = 7431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintFarAll(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintFarAll_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7445, RefRangeEnd = 7446, XrefRangeStart = 7433, XrefRangeEnd = 7445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintBackAll(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBackAll_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7458, RefRangeEnd = 7459, XrefRangeStart = 7446, XrefRangeEnd = 7458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateEff()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateEff_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BackgroudEffect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
