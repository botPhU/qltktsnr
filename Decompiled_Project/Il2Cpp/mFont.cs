using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp;

public class mFont : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_RIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_CENTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_RED;

	private static readonly System.IntPtr NativeFieldInfoPtr_YELLOW;

	private static readonly System.IntPtr NativeFieldInfoPtr_GREEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_FATAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MISS;

	private static readonly System.IntPtr NativeFieldInfoPtr_ORANGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_ADDMONEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_MISS_ME;

	private static readonly System.IntPtr NativeFieldInfoPtr_FATAL_ME;

	private static readonly System.IntPtr NativeFieldInfoPtr_HP;

	private static readonly System.IntPtr NativeFieldInfoPtr_MP;

	private static readonly System.IntPtr NativeFieldInfoPtr_space;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_strFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_fImages;

	private static readonly System.IntPtr NativeFieldInfoPtr_yAddFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorJava;

	private static readonly System.IntPtr NativeFieldInfoPtr_gI;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_blue;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_white;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_yellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_yellowSmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_dark;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_green2;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_focus;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_unfocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_blue1;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_blue1Small;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_green2;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_yellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_grey;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_blue;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_white;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_8b;

	private static readonly System.IntPtr NativeFieldInfoPtr_number_yellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_number_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_number_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_number_gray;

	private static readonly System.IntPtr NativeFieldInfoPtr_number_orange;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigNumber_red;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigNumber_While;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigNumber_yellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigNumber_green;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigNumber_orange;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigNumber_blue;

	private static readonly System.IntPtr NativeFieldInfoPtr_bigNumber_black;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameFontRed;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameFontYellow;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameFontGreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_greySmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_yellowSmall2;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_green2Small;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7_whiteSmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_tahoma_7b_greenSmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_myFont;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_wO;

	private static readonly System.IntPtr NativeFieldInfoPtr_color1;

	private static readonly System.IntPtr NativeFieldInfoPtr_color2;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_fstyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_st1;

	private static readonly System.IntPtr NativeFieldInfoPtr_st2;

	private static readonly System.IntPtr NativeFieldInfoPtr_str;

	private static readonly System.IntPtr NativeFieldInfoPtr_yAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_pathImage;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setHeight_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setColor_Public_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bigColor_Public_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setColorByID_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTypePaint_Public_Void_mGraphics_String_Int32_Int32_Int32_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setColorFont_Public_Color_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawStringBorder_Public_Void_mGraphics_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawStringBorder_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawStringBd_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_splitFontVector_Public_MyVector_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_splitFirst_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_splitStrInLine_Public_Il2CppStringArray_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_splitStrInLineA_Public_ArrayList_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_splitFontArray_Public_Il2CppStringArray_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_compare_Public_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getWidth_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getWidthExactOf_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getWidthNotExactOf_Public_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeight_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_splitStringSv_Public_Static_Il2CppStringArray_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reloadImage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeImage_Public_Void_0;

	public unsafe static int LEFT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LEFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LEFT, (void*)(&num));
		}
	}

	public unsafe static int RIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RIGHT, (void*)(&num));
		}
	}

	public unsafe static int CENTER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CENTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CENTER, (void*)(&num));
		}
	}

	public unsafe static int RED
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RED, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RED, (void*)(&num));
		}
	}

	public unsafe static int YELLOW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_YELLOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_YELLOW, (void*)(&num));
		}
	}

	public unsafe static int GREEN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GREEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GREEN, (void*)(&num));
		}
	}

	public unsafe static int FATAL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FATAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FATAL, (void*)(&num));
		}
	}

	public unsafe static int MISS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MISS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MISS, (void*)(&num));
		}
	}

	public unsafe static int ORANGE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ORANGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ORANGE, (void*)(&num));
		}
	}

	public unsafe static int ADDMONEY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ADDMONEY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ADDMONEY, (void*)(&num));
		}
	}

	public unsafe static int MISS_ME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MISS_ME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MISS_ME, (void*)(&num));
		}
	}

	public unsafe static int FATAL_ME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FATAL_ME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FATAL_ME, (void*)(&num));
		}
	}

	public unsafe static int HP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HP, (void*)(&num));
		}
	}

	public unsafe static int MP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MP, (void*)(&num));
		}
	}

	public unsafe int space
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_space);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_space)) = num;
		}
	}

	public unsafe Image imgFont
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgFont);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgFont)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe string strFont
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strFont);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strFont)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> fImages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fImages);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fImages)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int yAddFont
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yAddFont, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yAddFont, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> colorJava
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorJava, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorJava, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static mFont gI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_red
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_red, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_red, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_blue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_blue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_blue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_white
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_white, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_white, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_yellow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_yellow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_yellow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_yellowSmall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_yellowSmall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_yellowSmall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_dark
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_dark, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_dark, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_green2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_green2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_green2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_green
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_green, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_green, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_focus
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_focus, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_focus, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_unfocus
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_unfocus, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_unfocus, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_blue1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_blue1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_blue1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_blue1Small
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_blue1Small, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_blue1Small, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_green2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_green2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_green2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_yellow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_yellow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_yellow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_grey
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_grey, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_grey, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_red
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_red, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_red, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_blue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_blue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_blue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_green
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_green, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_green, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_white
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_white, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_white, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_8b
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_8b, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_8b, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont number_yellow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_number_yellow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_number_yellow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont number_red
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_number_red, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_number_red, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont number_green
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_number_green, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_number_green, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont number_gray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_number_gray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_number_gray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont number_orange
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_number_orange, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_number_orange, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont bigNumber_red
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigNumber_red, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigNumber_red, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont bigNumber_While
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigNumber_While, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigNumber_While, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont bigNumber_yellow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigNumber_yellow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigNumber_yellow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont bigNumber_green
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigNumber_green, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigNumber_green, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont bigNumber_orange
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigNumber_orange, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigNumber_orange, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont bigNumber_blue
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigNumber_blue, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigNumber_blue, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont bigNumber_black
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bigNumber_black, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bigNumber_black, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont nameFontRed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nameFontRed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nameFontRed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont nameFontYellow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nameFontYellow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nameFontYellow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont nameFontGreen
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nameFontGreen, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nameFontGreen, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_greySmall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_greySmall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_greySmall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_yellowSmall2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_yellowSmall2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_yellowSmall2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_green2Small
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_green2Small, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_green2Small, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7_whiteSmall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7_whiteSmall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7_whiteSmall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe static mFont tahoma_7b_greenSmall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tahoma_7b_greenSmall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tahoma_7b_greenSmall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe Font myFont
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myFont);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Font>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myFont)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font));
		}
	}

	public unsafe int height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = num;
		}
	}

	public unsafe int wO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wO);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wO)) = num;
		}
	}

	public unsafe Color color1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color1);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color1)) = color;
		}
	}

	public unsafe Color color2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color2);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color2)) = color;
		}
	}

	public unsafe sbyte id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = b;
		}
	}

	public unsafe int fstyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fstyle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fstyle)) = num;
		}
	}

	public unsafe string st1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_st1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_st1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string st2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_st2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_st2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string str
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_str, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_str, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int yAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yAdd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yAdd)) = num;
		}
	}

	public unsafe string pathImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathImage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathImage)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static mFont()
	{
		Il2CppClassPointerStore<mFont>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "mFont");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<mFont>.NativeClassPtr);
		NativeFieldInfoPtr_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "LEFT");
		NativeFieldInfoPtr_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "RIGHT");
		NativeFieldInfoPtr_CENTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "CENTER");
		NativeFieldInfoPtr_RED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "RED");
		NativeFieldInfoPtr_YELLOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "YELLOW");
		NativeFieldInfoPtr_GREEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "GREEN");
		NativeFieldInfoPtr_FATAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "FATAL");
		NativeFieldInfoPtr_MISS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "MISS");
		NativeFieldInfoPtr_ORANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "ORANGE");
		NativeFieldInfoPtr_ADDMONEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "ADDMONEY");
		NativeFieldInfoPtr_MISS_ME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "MISS_ME");
		NativeFieldInfoPtr_FATAL_ME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "FATAL_ME");
		NativeFieldInfoPtr_HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "HP");
		NativeFieldInfoPtr_MP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "MP");
		NativeFieldInfoPtr_space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "space");
		NativeFieldInfoPtr_imgFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "imgFont");
		NativeFieldInfoPtr_strFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "strFont");
		NativeFieldInfoPtr_fImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "fImages");
		NativeFieldInfoPtr_yAddFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "yAddFont");
		NativeFieldInfoPtr_colorJava = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "colorJava");
		NativeFieldInfoPtr_gI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "gI");
		NativeFieldInfoPtr_tahoma_7b_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_red");
		NativeFieldInfoPtr_tahoma_7b_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_blue");
		NativeFieldInfoPtr_tahoma_7b_white = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_white");
		NativeFieldInfoPtr_tahoma_7b_yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_yellow");
		NativeFieldInfoPtr_tahoma_7b_yellowSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_yellowSmall");
		NativeFieldInfoPtr_tahoma_7b_dark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_dark");
		NativeFieldInfoPtr_tahoma_7b_green2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_green2");
		NativeFieldInfoPtr_tahoma_7b_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_green");
		NativeFieldInfoPtr_tahoma_7b_focus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_focus");
		NativeFieldInfoPtr_tahoma_7b_unfocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_unfocus");
		NativeFieldInfoPtr_tahoma_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7");
		NativeFieldInfoPtr_tahoma_7_blue1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_blue1");
		NativeFieldInfoPtr_tahoma_7_blue1Small = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_blue1Small");
		NativeFieldInfoPtr_tahoma_7_green2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_green2");
		NativeFieldInfoPtr_tahoma_7_yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_yellow");
		NativeFieldInfoPtr_tahoma_7_grey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_grey");
		NativeFieldInfoPtr_tahoma_7_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_red");
		NativeFieldInfoPtr_tahoma_7_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_blue");
		NativeFieldInfoPtr_tahoma_7_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_green");
		NativeFieldInfoPtr_tahoma_7_white = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_white");
		NativeFieldInfoPtr_tahoma_8b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_8b");
		NativeFieldInfoPtr_number_yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "number_yellow");
		NativeFieldInfoPtr_number_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "number_red");
		NativeFieldInfoPtr_number_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "number_green");
		NativeFieldInfoPtr_number_gray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "number_gray");
		NativeFieldInfoPtr_number_orange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "number_orange");
		NativeFieldInfoPtr_bigNumber_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "bigNumber_red");
		NativeFieldInfoPtr_bigNumber_While = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "bigNumber_While");
		NativeFieldInfoPtr_bigNumber_yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "bigNumber_yellow");
		NativeFieldInfoPtr_bigNumber_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "bigNumber_green");
		NativeFieldInfoPtr_bigNumber_orange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "bigNumber_orange");
		NativeFieldInfoPtr_bigNumber_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "bigNumber_blue");
		NativeFieldInfoPtr_bigNumber_black = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "bigNumber_black");
		NativeFieldInfoPtr_nameFontRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "nameFontRed");
		NativeFieldInfoPtr_nameFontYellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "nameFontYellow");
		NativeFieldInfoPtr_nameFontGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "nameFontGreen");
		NativeFieldInfoPtr_tahoma_7_greySmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_greySmall");
		NativeFieldInfoPtr_tahoma_7b_yellowSmall2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_yellowSmall2");
		NativeFieldInfoPtr_tahoma_7b_green2Small = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_green2Small");
		NativeFieldInfoPtr_tahoma_7_whiteSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7_whiteSmall");
		NativeFieldInfoPtr_tahoma_7b_greenSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "tahoma_7b_greenSmall");
		NativeFieldInfoPtr_myFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "myFont");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "height");
		NativeFieldInfoPtr_wO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "wO");
		NativeFieldInfoPtr_color1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "color1");
		NativeFieldInfoPtr_color2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "color2");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "id");
		NativeFieldInfoPtr_fstyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "fstyle");
		NativeFieldInfoPtr_st1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "st1");
		NativeFieldInfoPtr_st2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "st2");
		NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "str");
		NativeFieldInfoPtr_yAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "yAdd");
		NativeFieldInfoPtr_pathImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mFont>.NativeClassPtr, "pathImage");
		NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664738);
		NativeMethodInfoPtr__ctor_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664739);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664740);
		NativeMethodInfoPtr_setHeight_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664741);
		NativeMethodInfoPtr_setColor_Public_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664742);
		NativeMethodInfoPtr_bigColor_Public_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664743);
		NativeMethodInfoPtr_setColorByID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664744);
		NativeMethodInfoPtr_setTypePaint_Public_Void_mGraphics_String_Int32_Int32_Int32_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664745);
		NativeMethodInfoPtr_setColorFont_Public_Color_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664746);
		NativeMethodInfoPtr_drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664747);
		NativeMethodInfoPtr_drawStringBorder_Public_Void_mGraphics_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664748);
		NativeMethodInfoPtr_drawStringBorder_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664749);
		NativeMethodInfoPtr_drawStringBd_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664750);
		NativeMethodInfoPtr_drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664751);
		NativeMethodInfoPtr_splitFontVector_Public_MyVector_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664752);
		NativeMethodInfoPtr_splitFirst_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664753);
		NativeMethodInfoPtr_splitStrInLine_Public_Il2CppStringArray_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664754);
		NativeMethodInfoPtr_splitStrInLineA_Public_ArrayList_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664755);
		NativeMethodInfoPtr_splitFontArray_Public_Il2CppStringArray_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664756);
		NativeMethodInfoPtr_compare_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664757);
		NativeMethodInfoPtr_getWidth_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664758);
		NativeMethodInfoPtr_getWidthExactOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664759);
		NativeMethodInfoPtr_getWidthNotExactOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664760);
		NativeMethodInfoPtr_getHeight_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664761);
		NativeMethodInfoPtr__drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664762);
		NativeMethodInfoPtr__drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664763);
		NativeMethodInfoPtr_splitStringSv_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664764);
		NativeMethodInfoPtr_reloadImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664765);
		NativeMethodInfoPtr_freeImage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mFont>.NativeClassPtr, 100664766);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57534, XrefRangeEnd = 57574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe mFont(string strFont, string pathImage, string pathData, int space)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<mFont>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strFont);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pathImage);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(pathData);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &space;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 57615, RefRangeEnd = 57648, XrefRangeStart = 57574, XrefRangeEnd = 57615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe mFont(sbyte id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<mFont>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57917, RefRangeEnd = 57918, XrefRangeStart = 57648, XrefRangeEnd = 57917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 57918, RefRangeEnd = 57923, XrefRangeStart = 57918, XrefRangeEnd = 57918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setHeight(int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&height);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setHeight_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe Color setColor(int rgb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rgb);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setColor_Public_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 57926, RefRangeEnd = 57930, XrefRangeStart = 57923, XrefRangeEnd = 57926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color bigColor(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bigColor_Public_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57930, XrefRangeEnd = 57935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setColorByID(int ID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setColorByID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 57957, RefRangeEnd = 57979, XrefRangeStart = 57935, XrefRangeEnd = 57957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setTypePaint(mGraphics g, string st, int x, int y, int align, sbyte idFont)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		*(sbyte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &idFont;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTypePaint_Public_Void_mGraphics_String_Int32_Int32_Int32_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 57983, RefRangeEnd = 57985, XrefRangeStart = 57979, XrefRangeEnd = 57983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color setColorFont(sbyte id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setColorFont_Public_Color_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(240)]
	[CachedScanResults(RefRangeStart = 57992, RefRangeEnd = 58232, XrefRangeStart = 57985, XrefRangeEnd = 57992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawString(mGraphics g, string st, int x, int y, int align)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58239, RefRangeEnd = 58240, XrefRangeStart = 58232, XrefRangeEnd = 58239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawStringBorder(mGraphics g, string st, int x, int y, int align)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawStringBorder_Public_Void_mGraphics_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58255, RefRangeEnd = 58256, XrefRangeStart = 58240, XrefRangeEnd = 58255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawStringBorder(mGraphics g, string st, int x, int y, int align, mFont font2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font2);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawStringBorder_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58256, XrefRangeEnd = 58266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawStringBd(mGraphics g, string st, int x, int y, int align, mFont font)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawStringBd_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(95)]
	[CachedScanResults(RefRangeStart = 58273, RefRangeEnd = 58368, XrefRangeStart = 58266, XrefRangeEnd = 58273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawString(mGraphics g, string st, int x, int y, int align, mFont font)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_mFont_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 58395, RefRangeEnd = 58398, XrefRangeStart = 58368, XrefRangeEnd = 58395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyVector splitFontVector(string src, int lineWidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_splitFontVector_Public_MyVector_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58398, XrefRangeEnd = 58417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string splitFirst(string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_splitFirst_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58417, XrefRangeEnd = 58425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray splitStrInLine(string src, int lineWidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_splitStrInLine_Public_Il2CppStringArray_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58475, RefRangeEnd = 58476, XrefRangeStart = 58425, XrefRangeEnd = 58475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArrayList splitStrInLineA(string src, int lineWidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_splitStrInLineA_Public_ArrayList_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 58487, RefRangeEnd = 58515, XrefRangeStart = 58476, XrefRangeEnd = 58487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray splitFontArray(string src, int lineWidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineWidth;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_splitFontArray_Public_Il2CppStringArray_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58525, RefRangeEnd = 58526, XrefRangeStart = 58515, XrefRangeEnd = 58525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool compare(string strSource, string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strSource);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_compare_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 58534, RefRangeEnd = 58569, XrefRangeStart = 58526, XrefRangeEnd = 58534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getWidth(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getWidth_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58598, RefRangeEnd = 58600, XrefRangeStart = 58569, XrefRangeEnd = 58598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getWidthExactOf(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getWidthExactOf_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58604, RefRangeEnd = 58605, XrefRangeStart = 58600, XrefRangeEnd = 58604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getWidthNotExactOf(string s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getWidthNotExactOf_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 58629, RefRangeEnd = 58657, XrefRangeStart = 58605, XrefRangeEnd = 58629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeight_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 58691, RefRangeEnd = 58693, XrefRangeStart = 58657, XrefRangeEnd = 58691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _drawString(mGraphics g, string st, int x0, int y0, int align, int font)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &font;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 58721, RefRangeEnd = 58730, XrefRangeStart = 58693, XrefRangeEnd = 58721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _drawString(mGraphics g, string st, int x0, int y0, int align)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x0;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y0;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__drawString_Public_Void_mGraphics_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58730, XrefRangeEnd = 58743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray splitStringSv(string _text, string _searchStr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(_searchStr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_splitStringSv_Public_Static_Il2CppStringArray_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58743, XrefRangeEnd = 58752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void reloadImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reloadImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void freeImage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeImage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public mFont(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
