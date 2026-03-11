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

public class Item : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OPT_STAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPT_MOON;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPT_SUN;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPT_COLORNAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPT_LVITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPT_STARSLOT;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPT_MAXSTARSLOT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_BODY_MIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_BODY_MAX;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_AO;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_QUAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_GANGTAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_GIAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_RADA;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_HAIR;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_DAUTHAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_NGOCRONG;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_SACH;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_NHIEMVU;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_GOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_DIAMOND;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_BALO;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_MOUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_MOUNT_VIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_DIAMOND_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_TRAINSUIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_HAT;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_WEAPON;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_BAG;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_BOX;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_BODY;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_STACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_STACK_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_GROCERY;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_GROCERY_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_UPGRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_UPPEARL;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_UPPEARL_LOCK;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_SPLIT;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_STORE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_BOOK;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_LIEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_NHAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_NGOCBOI;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_PHU;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_NONNAM;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_NONNU;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_AONAM;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_AONU;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_GANGTAYNAM;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_GANGTAYNU;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_QUANNAM;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_QUANNU;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_GIAYNAM;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_GIAYNU;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_TRADE;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_UPGRADE_GOLD;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_FASHION;

	private static readonly System.IntPtr NativeFieldInfoPtr_UI_CONVERT;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_template;

	private static readonly System.IntPtr NativeFieldInfoPtr_options;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemId;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantity;

	private static readonly System.IntPtr NativeFieldInfoPtr_quantilyToBuy;

	private static readonly System.IntPtr NativeFieldInfoPtr_powerRequire;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_sys;

	private static readonly System.IntPtr NativeFieldInfoPtr_upgrade;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyGold;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyCoinLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyDiamond;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyGoldLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_saleCoinLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_buySpec;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyRuby;

	private static readonly System.IntPtr NativeFieldInfoPtr_iconSpec;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyType;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_isExpires;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBuySpec;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_eff;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexEff;

	private static readonly System.IntPtr NativeFieldInfoPtr_img;

	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_content;

	private static readonly System.IntPtr NativeFieldInfoPtr_reason;

	private static readonly System.IntPtr NativeFieldInfoPtr_compare;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMe;

	private static readonly System.IntPtr NativeFieldInfoPtr_newItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_headTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_bodyTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_legTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_bagTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_wpTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorBorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_listTypeBody;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCompare_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPrice_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintUpgradeEffect_Public_Void_Int32_Int32_Int32_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upgradeEffectY_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_upgradeEffectX_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHaveOption_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clone_Public_Item_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeBody_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getLockstring_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getUpgradestring_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeUIMe_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeUIShopView_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeUIShop_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeUIShopLock_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeUIStore_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeUIBook_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTypeUIFashion_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isUpMax_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getUpMax_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPartTemp_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFullName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int OPT_STAR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPT_STAR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPT_STAR, (void*)(&num));
		}
	}

	public unsafe static int OPT_MOON
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPT_MOON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPT_MOON, (void*)(&num));
		}
	}

	public unsafe static int OPT_SUN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPT_SUN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPT_SUN, (void*)(&num));
		}
	}

	public unsafe static int OPT_COLORNAME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPT_COLORNAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPT_COLORNAME, (void*)(&num));
		}
	}

	public unsafe static int OPT_LVITEM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPT_LVITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPT_LVITEM, (void*)(&num));
		}
	}

	public unsafe static int OPT_STARSLOT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPT_STARSLOT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPT_STARSLOT, (void*)(&num));
		}
	}

	public unsafe static int OPT_MAXSTARSLOT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPT_MAXSTARSLOT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPT_MAXSTARSLOT, (void*)(&num));
		}
	}

	public unsafe static int TYPE_BODY_MIN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_BODY_MIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_BODY_MIN, (void*)(&num));
		}
	}

	public unsafe static int TYPE_BODY_MAX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_BODY_MAX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_BODY_MAX, (void*)(&num));
		}
	}

	public unsafe static int TYPE_AO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_AO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_AO, (void*)(&num));
		}
	}

	public unsafe static int TYPE_QUAN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_QUAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_QUAN, (void*)(&num));
		}
	}

	public unsafe static int TYPE_GANGTAY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_GANGTAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_GANGTAY, (void*)(&num));
		}
	}

	public unsafe static int TYPE_GIAY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_GIAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_GIAY, (void*)(&num));
		}
	}

	public unsafe static int TYPE_RADA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_RADA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_RADA, (void*)(&num));
		}
	}

	public unsafe static int TYPE_HAIR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_HAIR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_HAIR, (void*)(&num));
		}
	}

	public unsafe static int TYPE_DAUTHAN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_DAUTHAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_DAUTHAN, (void*)(&num));
		}
	}

	public unsafe static int TYPE_NGOCRONG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_NGOCRONG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_NGOCRONG, (void*)(&num));
		}
	}

	public unsafe static int TYPE_SACH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_SACH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_SACH, (void*)(&num));
		}
	}

	public unsafe static int TYPE_NHIEMVU
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_NHIEMVU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_NHIEMVU, (void*)(&num));
		}
	}

	public unsafe static int TYPE_GOLD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_GOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_GOLD, (void*)(&num));
		}
	}

	public unsafe static int TYPE_DIAMOND
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_DIAMOND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_DIAMOND, (void*)(&num));
		}
	}

	public unsafe static int TYPE_BALO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_BALO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_BALO, (void*)(&num));
		}
	}

	public unsafe static int TYPE_MOUNT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_MOUNT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_MOUNT, (void*)(&num));
		}
	}

	public unsafe static int TYPE_MOUNT_VIP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_MOUNT_VIP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_MOUNT_VIP, (void*)(&num));
		}
	}

	public unsafe static int TYPE_DIAMOND_LOCK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_DIAMOND_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_DIAMOND_LOCK, (void*)(&num));
		}
	}

	public unsafe static int TYPE_TRAINSUIT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_TRAINSUIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_TRAINSUIT, (void*)(&num));
		}
	}

	public unsafe static int TYPE_HAT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_HAT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_HAT, (void*)(&num));
		}
	}

	public unsafe static sbyte UI_WEAPON
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_WEAPON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_WEAPON, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_BAG
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_BAG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_BAG, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_BOX
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_BOX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_BOX, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_BODY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_BODY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_BODY, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_STACK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_STACK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_STACK, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_STACK_LOCK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_STACK_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_STACK_LOCK, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_GROCERY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_GROCERY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_GROCERY, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_GROCERY_LOCK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_GROCERY_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_GROCERY_LOCK, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_UPGRADE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_UPGRADE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_UPGRADE, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_UPPEARL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_UPPEARL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_UPPEARL, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_UPPEARL_LOCK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_UPPEARL_LOCK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_UPPEARL_LOCK, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_SPLIT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_SPLIT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_SPLIT, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_STORE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_STORE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_STORE, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_BOOK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_BOOK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_BOOK, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_LIEN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_LIEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_LIEN, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_NHAN
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_NHAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_NHAN, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_NGOCBOI
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_NGOCBOI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_NGOCBOI, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_PHU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_PHU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_PHU, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_NONNAM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_NONNAM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_NONNAM, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_NONNU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_NONNU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_NONNU, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_AONAM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_AONAM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_AONAM, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_AONU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_AONU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_AONU, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_GANGTAYNAM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_GANGTAYNAM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_GANGTAYNAM, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_GANGTAYNU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_GANGTAYNU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_GANGTAYNU, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_QUANNAM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_QUANNAM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_QUANNAM, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_QUANNU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_QUANNU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_QUANNU, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_GIAYNAM
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_GIAYNAM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_GIAYNAM, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_GIAYNU
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_GIAYNU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_GIAYNU, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_TRADE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_TRADE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_TRADE, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_UPGRADE_GOLD
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_UPGRADE_GOLD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_UPGRADE_GOLD, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_FASHION
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_FASHION, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_FASHION, (void*)(&b));
		}
	}

	public unsafe static sbyte UI_CONVERT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UI_CONVERT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UI_CONVERT, (void*)(&b));
		}
	}

	public unsafe Il2CppReferenceArray<ItemOption> itemOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemOption);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemOption>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemOption)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe ItemTemplate template
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTemplate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)itemTemplate));
		}
	}

	public unsafe MyVector options
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe int itemId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemId)) = num;
		}
	}

	public unsafe int playerId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerId)) = num;
		}
	}

	public unsafe bool isSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSelect)) = flag;
		}
	}

	public unsafe int indexUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexUI);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexUI)) = num;
		}
	}

	public unsafe int quantity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantity)) = num;
		}
	}

	public unsafe int quantilyToBuy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantilyToBuy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_quantilyToBuy)) = num;
		}
	}

	public unsafe long powerRequire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerRequire);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powerRequire)) = num;
		}
	}

	public unsafe bool isLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLock)) = flag;
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

	public unsafe int upgrade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgrade);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upgrade)) = num;
		}
	}

	public unsafe long buyGold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyGold);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyGold)) = num;
		}
	}

	public unsafe int buyCoinLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyCoinLock);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyCoinLock)) = num;
		}
	}

	public unsafe int buyDiamond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyDiamond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyDiamond)) = num;
		}
	}

	public unsafe int buyGoldLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyGoldLock);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyGoldLock)) = num;
		}
	}

	public unsafe int saleCoinLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saleCoinLock);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saleCoinLock)) = num;
		}
	}

	public unsafe int buySpec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buySpec);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buySpec)) = num;
		}
	}

	public unsafe int buyRuby
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyRuby);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyRuby)) = num;
		}
	}

	public unsafe short iconSpec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSpec);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconSpec)) = num;
		}
	}

	public unsafe sbyte buyType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyType);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyType)) = b;
		}
	}

	public unsafe int typeUI
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeUI);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeUI)) = num;
		}
	}

	public unsafe bool isExpires
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isExpires);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isExpires)) = flag;
		}
	}

	public unsafe bool isBuySpec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBuySpec);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBuySpec)) = flag;
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

	public unsafe Image img
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe string info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string content
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string reason
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reason);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reason)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int compare
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compare);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compare)) = num;
		}
	}

	public unsafe sbyte isMe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMe);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isMe)) = b;
		}
	}

	public unsafe bool newItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newItem);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newItem)) = flag;
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

	public unsafe Il2CppStructArray<int> color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> colorBorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorBorder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorBorder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Il2CppStructArray<int> size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static List<int> listTypeBody
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listTypeBody, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listTypeBody, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static Item()
	{
		Il2CppClassPointerStore<Item>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Item");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item>.NativeClassPtr);
		NativeFieldInfoPtr_OPT_STAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OPT_STAR");
		NativeFieldInfoPtr_OPT_MOON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OPT_MOON");
		NativeFieldInfoPtr_OPT_SUN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OPT_SUN");
		NativeFieldInfoPtr_OPT_COLORNAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OPT_COLORNAME");
		NativeFieldInfoPtr_OPT_LVITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OPT_LVITEM");
		NativeFieldInfoPtr_OPT_STARSLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OPT_STARSLOT");
		NativeFieldInfoPtr_OPT_MAXSTARSLOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "OPT_MAXSTARSLOT");
		NativeFieldInfoPtr_TYPE_BODY_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_BODY_MIN");
		NativeFieldInfoPtr_TYPE_BODY_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_BODY_MAX");
		NativeFieldInfoPtr_TYPE_AO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_AO");
		NativeFieldInfoPtr_TYPE_QUAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_QUAN");
		NativeFieldInfoPtr_TYPE_GANGTAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_GANGTAY");
		NativeFieldInfoPtr_TYPE_GIAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_GIAY");
		NativeFieldInfoPtr_TYPE_RADA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_RADA");
		NativeFieldInfoPtr_TYPE_HAIR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_HAIR");
		NativeFieldInfoPtr_TYPE_DAUTHAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_DAUTHAN");
		NativeFieldInfoPtr_TYPE_NGOCRONG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_NGOCRONG");
		NativeFieldInfoPtr_TYPE_SACH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_SACH");
		NativeFieldInfoPtr_TYPE_NHIEMVU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_NHIEMVU");
		NativeFieldInfoPtr_TYPE_GOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_GOLD");
		NativeFieldInfoPtr_TYPE_DIAMOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_DIAMOND");
		NativeFieldInfoPtr_TYPE_BALO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_BALO");
		NativeFieldInfoPtr_TYPE_MOUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_MOUNT");
		NativeFieldInfoPtr_TYPE_MOUNT_VIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_MOUNT_VIP");
		NativeFieldInfoPtr_TYPE_DIAMOND_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_DIAMOND_LOCK");
		NativeFieldInfoPtr_TYPE_TRAINSUIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_TRAINSUIT");
		NativeFieldInfoPtr_TYPE_HAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "TYPE_HAT");
		NativeFieldInfoPtr_UI_WEAPON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_WEAPON");
		NativeFieldInfoPtr_UI_BAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_BAG");
		NativeFieldInfoPtr_UI_BOX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_BOX");
		NativeFieldInfoPtr_UI_BODY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_BODY");
		NativeFieldInfoPtr_UI_STACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_STACK");
		NativeFieldInfoPtr_UI_STACK_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_STACK_LOCK");
		NativeFieldInfoPtr_UI_GROCERY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_GROCERY");
		NativeFieldInfoPtr_UI_GROCERY_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_GROCERY_LOCK");
		NativeFieldInfoPtr_UI_UPGRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_UPGRADE");
		NativeFieldInfoPtr_UI_UPPEARL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_UPPEARL");
		NativeFieldInfoPtr_UI_UPPEARL_LOCK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_UPPEARL_LOCK");
		NativeFieldInfoPtr_UI_SPLIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_SPLIT");
		NativeFieldInfoPtr_UI_STORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_STORE");
		NativeFieldInfoPtr_UI_BOOK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_BOOK");
		NativeFieldInfoPtr_UI_LIEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_LIEN");
		NativeFieldInfoPtr_UI_NHAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_NHAN");
		NativeFieldInfoPtr_UI_NGOCBOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_NGOCBOI");
		NativeFieldInfoPtr_UI_PHU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_PHU");
		NativeFieldInfoPtr_UI_NONNAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_NONNAM");
		NativeFieldInfoPtr_UI_NONNU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_NONNU");
		NativeFieldInfoPtr_UI_AONAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_AONAM");
		NativeFieldInfoPtr_UI_AONU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_AONU");
		NativeFieldInfoPtr_UI_GANGTAYNAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_GANGTAYNAM");
		NativeFieldInfoPtr_UI_GANGTAYNU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_GANGTAYNU");
		NativeFieldInfoPtr_UI_QUANNAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_QUANNAM");
		NativeFieldInfoPtr_UI_QUANNU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_QUANNU");
		NativeFieldInfoPtr_UI_GIAYNAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_GIAYNAM");
		NativeFieldInfoPtr_UI_GIAYNU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_GIAYNU");
		NativeFieldInfoPtr_UI_TRADE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_TRADE");
		NativeFieldInfoPtr_UI_UPGRADE_GOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_UPGRADE_GOLD");
		NativeFieldInfoPtr_UI_FASHION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_FASHION");
		NativeFieldInfoPtr_UI_CONVERT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "UI_CONVERT");
		NativeFieldInfoPtr_itemOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "itemOption");
		NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "template");
		NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "options");
		NativeFieldInfoPtr_itemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "itemId");
		NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "playerId");
		NativeFieldInfoPtr_isSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "isSelect");
		NativeFieldInfoPtr_indexUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "indexUI");
		NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "quantity");
		NativeFieldInfoPtr_quantilyToBuy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "quantilyToBuy");
		NativeFieldInfoPtr_powerRequire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "powerRequire");
		NativeFieldInfoPtr_isLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "isLock");
		NativeFieldInfoPtr_sys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "sys");
		NativeFieldInfoPtr_upgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "upgrade");
		NativeFieldInfoPtr_buyGold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "buyGold");
		NativeFieldInfoPtr_buyCoinLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "buyCoinLock");
		NativeFieldInfoPtr_buyDiamond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "buyDiamond");
		NativeFieldInfoPtr_buyGoldLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "buyGoldLock");
		NativeFieldInfoPtr_saleCoinLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "saleCoinLock");
		NativeFieldInfoPtr_buySpec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "buySpec");
		NativeFieldInfoPtr_buyRuby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "buyRuby");
		NativeFieldInfoPtr_iconSpec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "iconSpec");
		NativeFieldInfoPtr_buyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "buyType");
		NativeFieldInfoPtr_typeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "typeUI");
		NativeFieldInfoPtr_isExpires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "isExpires");
		NativeFieldInfoPtr_isBuySpec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "isBuySpec");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "status");
		NativeFieldInfoPtr_eff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "eff");
		NativeFieldInfoPtr_indexEff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "indexEff");
		NativeFieldInfoPtr_img = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "img");
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "info");
		NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "content");
		NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "reason");
		NativeFieldInfoPtr_compare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "compare");
		NativeFieldInfoPtr_isMe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "isMe");
		NativeFieldInfoPtr_newItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "newItem");
		NativeFieldInfoPtr_headTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "headTemp");
		NativeFieldInfoPtr_bodyTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "bodyTemp");
		NativeFieldInfoPtr_legTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "legTemp");
		NativeFieldInfoPtr_bagTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "bagTemp");
		NativeFieldInfoPtr_wpTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "wpTemp");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "color");
		NativeFieldInfoPtr_colorBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "colorBorder");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "size");
		NativeFieldInfoPtr_listTypeBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item>.NativeClassPtr, "listTypeBody");
		NativeMethodInfoPtr_getCompare_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr_getPrice_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664549);
		NativeMethodInfoPtr_paintUpgradeEffect_Public_Void_Int32_Int32_Int32_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664550);
		NativeMethodInfoPtr_upgradeEffectY_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664551);
		NativeMethodInfoPtr_upgradeEffectX_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664552);
		NativeMethodInfoPtr_isHaveOption_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664553);
		NativeMethodInfoPtr_clone_Public_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664554);
		NativeMethodInfoPtr_isTypeBody_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664555);
		NativeMethodInfoPtr_getLockstring_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664556);
		NativeMethodInfoPtr_getUpgradestring_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664557);
		NativeMethodInfoPtr_isTypeUIMe_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664558);
		NativeMethodInfoPtr_isTypeUIShopView_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664559);
		NativeMethodInfoPtr_isTypeUIShop_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664560);
		NativeMethodInfoPtr_isTypeUIShopLock_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664561);
		NativeMethodInfoPtr_isTypeUIStore_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664562);
		NativeMethodInfoPtr_isTypeUIBook_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664563);
		NativeMethodInfoPtr_isTypeUIFashion_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664564);
		NativeMethodInfoPtr_isUpMax_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664565);
		NativeMethodInfoPtr_getUpMax_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664566);
		NativeMethodInfoPtr_setPartTemp_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664567);
		NativeMethodInfoPtr_getFullName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664568);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item>.NativeClassPtr, 100664569);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53782, RefRangeEnd = 53784, XrefRangeStart = 53777, XrefRangeEnd = 53782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getCompare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCompare_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53784, XrefRangeEnd = 53789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getPrice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPrice_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53789, XrefRangeEnd = 53892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintUpgradeEffect(int x, int y, int upgrade, mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &upgrade;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintUpgradeEffect_Public_Void_Int32_Int32_Int32_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53892, XrefRangeEnd = 53896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int upgradeEffectY(int tick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tick);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upgradeEffectY_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53896, XrefRangeEnd = 53900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int upgradeEffectX(int tick)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tick);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_upgradeEffectX_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 53901, RefRangeEnd = 53909, XrefRangeStart = 53900, XrefRangeEnd = 53901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isHaveOption(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHaveOption_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53909, XrefRangeEnd = 53931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clone_Public_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Item>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 53938, RefRangeEnd = 53946, XrefRangeStart = 53931, XrefRangeEnd = 53938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isTypeBody()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeBody_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53946, XrefRangeEnd = 53950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getLockstring()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getLockstring_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53950, XrefRangeEnd = 53951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getUpgradestring()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getUpgradestring_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isTypeUIMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeUIMe_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isTypeUIShopView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeUIShopView_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isTypeUIShop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeUIShop_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isTypeUIShopLock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeUIShopLock_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isTypeUIStore()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeUIStore_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isTypeUIBook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeUIBook_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isTypeUIFashion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTypeUIFashion_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool isUpMax()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isUpMax_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int getUpMax()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getUpMax_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53951, RefRangeEnd = 53953, XrefRangeStart = 53951, XrefRangeEnd = 53951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPartTemp(int headTemp, int bodyTemp, int legTemp, int bagTemp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&headTemp);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bodyTemp;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &legTemp;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bagTemp;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPartTemp_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53996, RefRangeEnd = 53997, XrefRangeStart = 53953, XrefRangeEnd = 53996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getFullName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFullName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 54050, RefRangeEnd = 54064, XrefRangeStart = 53997, XrefRangeEnd = 54050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Item()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Item(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
