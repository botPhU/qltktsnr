using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public class TField : Il2CppSystem.Object
{
	public class ReplaceChar : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_charFind;

		private static readonly System.IntPtr NativeFieldInfoPtr_charReplace;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Char_0;

		public unsafe char charFind
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charFind);
				return *(char*)num;
			}
			set
			{
				*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charFind)) = c;
			}
		}

		public unsafe char charReplace
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charReplace);
				return *(char*)num;
			}
			set
			{
				*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charReplace)) = c;
			}
		}

		static ReplaceChar()
		{
			Il2CppClassPointerStore<ReplaceChar>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TField>.NativeClassPtr, "ReplaceChar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceChar>.NativeClassPtr);
			NativeFieldInfoPtr_charFind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceChar>.NativeClassPtr, "charFind");
			NativeFieldInfoPtr_charReplace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceChar>.NativeClassPtr, "charReplace");
			NativeMethodInfoPtr__ctor_Public_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceChar>.NativeClassPtr, 100666393);
		}

		[CallerCount(124)]
		[CachedScanResults(RefRangeStart = 108930, RefRangeEnd = 109054, XrefRangeStart = 108929, XrefRangeEnd = 108930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReplaceChar(char charFind, char charReplace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceChar>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&charFind);
			*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &charReplace;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public ReplaceChar(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_canTelex;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockArrow;

	private static readonly System.IntPtr NativeFieldInfoPtr_justReturnFromTextBox;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_RIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_CLEAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeXpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TIME_TO_CONFIRM_KEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_CARET_HEIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_CARET_WIDTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_CARET_SHOWING_TIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_GAP_X;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SHOW_CARET_COUNER;

	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_TYPE_ANY;

	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_TYPE_NUMERIC;

	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_TYPE_PASSWORD;

	private static readonly System.IntPtr NativeFieldInfoPtr_INPUT_ALPHA_NUMBER_ONLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_print;

	private static readonly System.IntPtr NativeFieldInfoPtr_printA;

	private static readonly System.IntPtr NativeFieldInfoPtr_printBB;

	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_passwordText;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintedText;

	private static readonly System.IntPtr NativeFieldInfoPtr_caretPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_counter;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTextLenght;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsetX;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyInActiveState;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexOfActiveChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_showCaretCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputType;

	private static readonly System.IntPtr NativeFieldInfoPtr_isQwerty;

	private static readonly System.IntPtr NativeFieldInfoPtr_typingModeAreaWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeChangeMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_modeNotify;

	private static readonly System.IntPtr NativeFieldInfoPtr_NOKIA;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOTO;

	private static readonly System.IntPtr NativeFieldInfoPtr_ORTHER;

	private static readonly System.IntPtr NativeFieldInfoPtr_BB;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeModeKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_abc;

	private static readonly System.IntPtr NativeFieldInfoPtr_Abc;

	private static readonly System.IntPtr NativeFieldInfoPtr_ABC;

	private static readonly System.IntPtr NativeFieldInfoPtr_number123;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentTField;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTfield;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_title;

	private static readonly System.IntPtr NativeFieldInfoPtr_strInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdClear;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdDoneAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentScr;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeDelayKyCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_holdCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeDau;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexDau;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexTemplate;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexCong;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeDau;

	private static readonly System.IntPtr NativeFieldInfoPtr_printDau;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgTf;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgTf2;

	private static readonly System.IntPtr NativeFieldInfoPtr_timePutKeyClearAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeClearFirt;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPaintCarret;

	private static readonly System.IntPtr NativeFieldInfoPtr_showSubTextField;

	private static readonly System.IntPtr NativeFieldInfoPtr_kb;

	private static readonly System.IntPtr NativeFieldInfoPtr_BBKEY;

	private static readonly System.IntPtr NativeFieldInfoPtr_img1;

	private static readonly System.IntPtr NativeFieldInfoPtr_img2;

	private static readonly System.IntPtr NativeFieldInfoPtr_isProcessed;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCopy;

	private static readonly System.IntPtr NativeFieldInfoPtr_input;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_mScreen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setNormal_Public_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doChangeToTextBox_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setVendorTypeMode_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTFImg_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearKeyWhenPutText_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearAllText_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOffset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyPressedAny_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NQMP_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Telex_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyState_Public_Static_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCapsLockOn_Private_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsKeyDown_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isCtrlV_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkCapslock_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCapsLockOrShiftOn_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyPressedAscii_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMode_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setDau_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyPressed_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setOffset_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintInputTf2_Public_Void_mGraphics_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintInputTf_Public_Void_mGraphics_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isFocused_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_subString_Public_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setPasswordTest_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTextBox_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFocus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setFocusWithKb_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getText_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearKb_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setText_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_insertText_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMaxTextLenght_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setMaxTextLenght_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getIputType_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setIputType_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	public unsafe bool canTelex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTelex);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canTelex)) = flag;
		}
	}

	public unsafe bool isFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFocus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFocus)) = flag;
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

	public unsafe int width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = num;
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

	public unsafe bool lockArrow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockArrow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockArrow)) = flag;
		}
	}

	public unsafe bool justReturnFromTextBox
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_justReturnFromTextBox);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_justReturnFromTextBox)) = flag;
		}
	}

	public unsafe bool paintFocus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintFocus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintFocus)) = flag;
		}
	}

	public unsafe static sbyte KEY_LEFT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_LEFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_LEFT, (void*)(&b));
		}
	}

	public unsafe static sbyte KEY_RIGHT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_RIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_RIGHT, (void*)(&b));
		}
	}

	public unsafe static sbyte KEY_CLEAR
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_CLEAR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_CLEAR, (void*)(&b));
		}
	}

	public unsafe static int typeXpeed
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeXpeed, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeXpeed, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> MAX_TIME_TO_CONFIRM_KEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_TIME_TO_CONFIRM_KEY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_TIME_TO_CONFIRM_KEY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int CARET_HEIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CARET_HEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CARET_HEIGHT, (void*)(&num));
		}
	}

	public unsafe static int CARET_WIDTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CARET_WIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CARET_WIDTH, (void*)(&num));
		}
	}

	public unsafe static int CARET_SHOWING_TIME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CARET_SHOWING_TIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CARET_SHOWING_TIME, (void*)(&num));
		}
	}

	public unsafe static int TEXT_GAP_X
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_GAP_X, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_GAP_X, (void*)(&num));
		}
	}

	public unsafe static int MAX_SHOW_CARET_COUNER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_SHOW_CARET_COUNER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_SHOW_CARET_COUNER, (void*)(&num));
		}
	}

	public unsafe static int INPUT_TYPE_ANY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_TYPE_ANY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_TYPE_ANY, (void*)(&num));
		}
	}

	public unsafe static int INPUT_TYPE_NUMERIC
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_TYPE_NUMERIC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_TYPE_NUMERIC, (void*)(&num));
		}
	}

	public unsafe static int INPUT_TYPE_PASSWORD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_TYPE_PASSWORD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_TYPE_PASSWORD, (void*)(&num));
		}
	}

	public unsafe static int INPUT_ALPHA_NUMBER_ONLY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INPUT_ALPHA_NUMBER_ONLY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INPUT_ALPHA_NUMBER_ONLY, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray print
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_print, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_print, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray printA
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_printA, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_printA, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray printBB
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_printBB, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_printBB, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe string text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string passwordText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passwordText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string paintedText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedText);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintedText)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int caretPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caretPos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_caretPos)) = num;
		}
	}

	public unsafe int counter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_counter)) = num;
		}
	}

	public unsafe int maxTextLenght
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTextLenght);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTextLenght)) = num;
		}
	}

	public unsafe int offsetX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetX)) = num;
		}
	}

	public unsafe static int lastKey
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastKey, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastKey, (void*)(&num));
		}
	}

	public unsafe int keyInActiveState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyInActiveState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyInActiveState)) = num;
		}
	}

	public unsafe int indexOfActiveChar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexOfActiveChar);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexOfActiveChar)) = num;
		}
	}

	public unsafe int showCaretCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCaretCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCaretCounter)) = num;
		}
	}

	public unsafe int inputType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputType)) = num;
		}
	}

	public unsafe static bool isQwerty
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isQwerty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isQwerty, (void*)(&flag));
		}
	}

	public unsafe static int typingModeAreaWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typingModeAreaWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typingModeAreaWidth, (void*)(&num));
		}
	}

	public unsafe static int mode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mode, (void*)(&num));
		}
	}

	public unsafe static long timeChangeMode
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeChangeMode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeChangeMode, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray modeNotify
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_modeNotify, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_modeNotify, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int NOKIA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NOKIA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NOKIA, (void*)(&num));
		}
	}

	public unsafe static int MOTO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOTO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOTO, (void*)(&num));
		}
	}

	public unsafe static int ORTHER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ORTHER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ORTHER, (void*)(&num));
		}
	}

	public unsafe static int BB
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BB, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BB, (void*)(&num));
		}
	}

	public unsafe static int changeModeKey
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_changeModeKey, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_changeModeKey, (void*)(&num));
		}
	}

	public unsafe static sbyte abc
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_abc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_abc, (void*)(&b));
		}
	}

	public unsafe static sbyte Abc
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Abc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Abc, (void*)(&b));
		}
	}

	public unsafe static sbyte ABC
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ABC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ABC, (void*)(&b));
		}
	}

	public unsafe static sbyte number123
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_number123, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_number123, (void*)(&b));
		}
	}

	public unsafe static TField currentTField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentTField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TField>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentTField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tField));
		}
	}

	public unsafe bool isTfield
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTfield);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTfield)) = flag;
		}
	}

	public unsafe bool isPaintMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintMouse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintMouse)) = flag;
		}
	}

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string title
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_title)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe Command cmdClear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdClear);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdClear)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdDoneAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdDoneAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdDoneAction)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe mScreen parentScr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentScr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<mScreen>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentScr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mScreen2));
		}
	}

	public unsafe int timeDelayKyCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeDelayKyCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeDelayKyCode)) = num;
		}
	}

	public unsafe int holdCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_holdCount)) = num;
		}
	}

	public unsafe static int changeDau
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_changeDau, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_changeDau, (void*)(&num));
		}
	}

	public unsafe int indexDau
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexDau);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexDau)) = num;
		}
	}

	public unsafe int indexTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexTemplate);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexTemplate)) = num;
		}
	}

	public unsafe int indexCong
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexCong);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexCong)) = num;
		}
	}

	public unsafe long timeDau
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeDau);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeDau)) = num;
		}
	}

	public unsafe static string printDau
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_printDau, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_printDau, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Image imgTf
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgTf, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgTf, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe Image imgTf2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgTf2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgTf2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe int timePutKeyClearAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timePutKeyClearAll);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timePutKeyClearAll)) = num;
		}
	}

	public unsafe int timeClearFirt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeClearFirt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeClearFirt)) = num;
		}
	}

	public unsafe bool isPaintCarret
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintCarret);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPaintCarret)) = flag;
		}
	}

	public unsafe bool showSubTextField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSubTextField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showSubTextField)) = flag;
		}
	}

	public unsafe static UnityEngine.TouchScreenKeyboard kb
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kb, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.TouchScreenKeyboard>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kb, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)touchScreenKeyboard));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> BBKEY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BBKEY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BBKEY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image img1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_img1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_img1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image img2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_img2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_img2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe bool isProcessed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isProcessed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isProcessed)) = flag;
		}
	}

	public unsafe static long lastCopy
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastCopy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastCopy, (void*)(&num));
		}
	}

	public unsafe static Image input
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_input, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_input, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static bool IsCapsLockOn
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110699, XrefRangeEnd = 110704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCapsLockOn_Private_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	static TField()
	{
		Il2CppClassPointerStore<TField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TField");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TField>.NativeClassPtr);
		NativeFieldInfoPtr_canTelex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "canTelex");
		NativeFieldInfoPtr_isFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "isFocus");
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "y");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "height");
		NativeFieldInfoPtr_lockArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "lockArrow");
		NativeFieldInfoPtr_justReturnFromTextBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "justReturnFromTextBox");
		NativeFieldInfoPtr_paintFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "paintFocus");
		NativeFieldInfoPtr_KEY_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "KEY_LEFT");
		NativeFieldInfoPtr_KEY_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "KEY_RIGHT");
		NativeFieldInfoPtr_KEY_CLEAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "KEY_CLEAR");
		NativeFieldInfoPtr_typeXpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "typeXpeed");
		NativeFieldInfoPtr_MAX_TIME_TO_CONFIRM_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "MAX_TIME_TO_CONFIRM_KEY");
		NativeFieldInfoPtr_CARET_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "CARET_HEIGHT");
		NativeFieldInfoPtr_CARET_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "CARET_WIDTH");
		NativeFieldInfoPtr_CARET_SHOWING_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "CARET_SHOWING_TIME");
		NativeFieldInfoPtr_TEXT_GAP_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "TEXT_GAP_X");
		NativeFieldInfoPtr_MAX_SHOW_CARET_COUNER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "MAX_SHOW_CARET_COUNER");
		NativeFieldInfoPtr_INPUT_TYPE_ANY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "INPUT_TYPE_ANY");
		NativeFieldInfoPtr_INPUT_TYPE_NUMERIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "INPUT_TYPE_NUMERIC");
		NativeFieldInfoPtr_INPUT_TYPE_PASSWORD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "INPUT_TYPE_PASSWORD");
		NativeFieldInfoPtr_INPUT_ALPHA_NUMBER_ONLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "INPUT_ALPHA_NUMBER_ONLY");
		NativeFieldInfoPtr_print = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "print");
		NativeFieldInfoPtr_printA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "printA");
		NativeFieldInfoPtr_printBB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "printBB");
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "text");
		NativeFieldInfoPtr_passwordText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "passwordText");
		NativeFieldInfoPtr_paintedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "paintedText");
		NativeFieldInfoPtr_caretPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "caretPos");
		NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "counter");
		NativeFieldInfoPtr_maxTextLenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "maxTextLenght");
		NativeFieldInfoPtr_offsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "offsetX");
		NativeFieldInfoPtr_lastKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "lastKey");
		NativeFieldInfoPtr_keyInActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "keyInActiveState");
		NativeFieldInfoPtr_indexOfActiveChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "indexOfActiveChar");
		NativeFieldInfoPtr_showCaretCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "showCaretCounter");
		NativeFieldInfoPtr_inputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "inputType");
		NativeFieldInfoPtr_isQwerty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "isQwerty");
		NativeFieldInfoPtr_typingModeAreaWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "typingModeAreaWidth");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_timeChangeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "timeChangeMode");
		NativeFieldInfoPtr_modeNotify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "modeNotify");
		NativeFieldInfoPtr_NOKIA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "NOKIA");
		NativeFieldInfoPtr_MOTO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "MOTO");
		NativeFieldInfoPtr_ORTHER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "ORTHER");
		NativeFieldInfoPtr_BB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "BB");
		NativeFieldInfoPtr_changeModeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "changeModeKey");
		NativeFieldInfoPtr_abc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "abc");
		NativeFieldInfoPtr_Abc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "Abc");
		NativeFieldInfoPtr_ABC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "ABC");
		NativeFieldInfoPtr_number123 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "number123");
		NativeFieldInfoPtr_currentTField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "currentTField");
		NativeFieldInfoPtr_isTfield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "isTfield");
		NativeFieldInfoPtr_isPaintMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "isPaintMouse");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "name");
		NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "title");
		NativeFieldInfoPtr_strInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "strInfo");
		NativeFieldInfoPtr_cmdClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "cmdClear");
		NativeFieldInfoPtr_cmdDoneAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "cmdDoneAction");
		NativeFieldInfoPtr_parentScr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "parentScr");
		NativeFieldInfoPtr_timeDelayKyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "timeDelayKyCode");
		NativeFieldInfoPtr_holdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "holdCount");
		NativeFieldInfoPtr_changeDau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "changeDau");
		NativeFieldInfoPtr_indexDau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "indexDau");
		NativeFieldInfoPtr_indexTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "indexTemplate");
		NativeFieldInfoPtr_indexCong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "indexCong");
		NativeFieldInfoPtr_timeDau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "timeDau");
		NativeFieldInfoPtr_printDau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "printDau");
		NativeFieldInfoPtr_imgTf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "imgTf");
		NativeFieldInfoPtr_imgTf2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "imgTf2");
		NativeFieldInfoPtr_timePutKeyClearAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "timePutKeyClearAll");
		NativeFieldInfoPtr_timeClearFirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "timeClearFirt");
		NativeFieldInfoPtr_isPaintCarret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "isPaintCarret");
		NativeFieldInfoPtr_showSubTextField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "showSubTextField");
		NativeFieldInfoPtr_kb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "kb");
		NativeFieldInfoPtr_BBKEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "BBKEY");
		NativeFieldInfoPtr_img1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "img1");
		NativeFieldInfoPtr_img2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "img2");
		NativeFieldInfoPtr_isProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "isProcessed");
		NativeFieldInfoPtr_lastCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "lastCopy");
		NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TField>.NativeClassPtr, "input");
		NativeMethodInfoPtr__ctor_Public_Void_mScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666346);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666347);
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666348);
		NativeMethodInfoPtr_setNormal_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr_doChangeToTextBox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr_setVendorTypeMode_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr_init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_setTFImg_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666353);
		NativeMethodInfoPtr_clearKeyWhenPutText_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666354);
		NativeMethodInfoPtr_clearAllText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666355);
		NativeMethodInfoPtr_clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666356);
		NativeMethodInfoPtr_clearAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666357);
		NativeMethodInfoPtr_setOffset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666358);
		NativeMethodInfoPtr_keyPressedAny_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666359);
		NativeMethodInfoPtr_NQMP_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666360);
		NativeMethodInfoPtr_Telex_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666361);
		NativeMethodInfoPtr_GetKeyState_Public_Static_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666362);
		NativeMethodInfoPtr_get_IsCapsLockOn_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666363);
		NativeMethodInfoPtr_IsKeyDown_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666364);
		NativeMethodInfoPtr_isCtrlV_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666365);
		NativeMethodInfoPtr_checkCapslock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666366);
		NativeMethodInfoPtr_IsCapsLockOrShiftOn_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666367);
		NativeMethodInfoPtr_keyPressedAscii_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666368);
		NativeMethodInfoPtr_setMode_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666369);
		NativeMethodInfoPtr_setDau_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666370);
		NativeMethodInfoPtr_keyPressed_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666371);
		NativeMethodInfoPtr_setOffset_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666372);
		NativeMethodInfoPtr_paintInputTf2_Public_Void_mGraphics_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666373);
		NativeMethodInfoPtr_paintInputTf_Public_Void_mGraphics_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666374);
		NativeMethodInfoPtr_paint_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666375);
		NativeMethodInfoPtr_isFocused_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666376);
		NativeMethodInfoPtr_subString_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666377);
		NativeMethodInfoPtr_setPasswordTest_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666378);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666379);
		NativeMethodInfoPtr_setTextBox_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666380);
		NativeMethodInfoPtr_setFocus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666381);
		NativeMethodInfoPtr_setFocusWithKb_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666382);
		NativeMethodInfoPtr_getText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666383);
		NativeMethodInfoPtr_clearKb_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666384);
		NativeMethodInfoPtr_setText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666385);
		NativeMethodInfoPtr_insertText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666386);
		NativeMethodInfoPtr_getMaxTextLenght_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666387);
		NativeMethodInfoPtr_setMaxTextLenght_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666388);
		NativeMethodInfoPtr_getIputType_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666389);
		NativeMethodInfoPtr_setIputType_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666390);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TField>.NativeClassPtr, 100666391);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109054, XrefRangeEnd = 109075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TField(mScreen parentScr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TField>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parentScr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_mScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 109095, RefRangeEnd = 109112, XrefRangeStart = 109075, XrefRangeEnd = 109095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TField()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TField>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109112, XrefRangeEnd = 109132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TField(int x, int y, int w, int h)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TField>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109132, XrefRangeEnd = 109151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TField(string text, int maxLen, int inputType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TField>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxLen;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool setNormal(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setNormal_Public_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doChangeToTextBox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doChangeToTextBox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109151, XrefRangeEnd = 109176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setVendorTypeMode(int mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setVendorTypeMode_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 109214, RefRangeEnd = 109218, XrefRangeStart = 109176, XrefRangeEnd = 109214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109218, XrefRangeEnd = 109225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setTFImg()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTFImg_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109225, XrefRangeEnd = 109226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearKeyWhenPutText(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearKeyWhenPutText_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109226, XrefRangeEnd = 109240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearAllText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearAllText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 109255, RefRangeEnd = 109258, XrefRangeStart = 109240, XrefRangeEnd = 109255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 109272, RefRangeEnd = 109274, XrefRangeStart = 109258, XrefRangeEnd = 109272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 109323, RefRangeEnd = 109328, XrefRangeStart = 109274, XrefRangeEnd = 109323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setOffset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOffset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109328, XrefRangeEnd = 109409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void keyPressedAny(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keyPressedAny_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110087, RefRangeEnd = 110088, XrefRangeStart = 109409, XrefRangeEnd = 110087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NQMP(int keycode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keycode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NQMP_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110693, RefRangeEnd = 110694, XrefRangeStart = 110088, XrefRangeEnd = 110693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Telex(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Telex_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 110696, RefRangeEnd = 110699, XrefRangeStart = 110694, XrefRangeEnd = 110696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short GetKeyState(int nVirtKey)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nVirtKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyState_Public_Static_Int16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 110708, RefRangeEnd = 110710, XrefRangeStart = 110704, XrefRangeEnd = 110708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsKeyDown(int nVirtKey)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nVirtKey);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsKeyDown_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110735, RefRangeEnd = 110736, XrefRangeStart = 110710, XrefRangeEnd = 110735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void isCtrlV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isCtrlV_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110755, RefRangeEnd = 110756, XrefRangeStart = 110736, XrefRangeEnd = 110755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void checkCapslock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkCapslock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110756, XrefRangeEnd = 110766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsCapsLockOrShiftOn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCapsLockOrShiftOn_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110766, XrefRangeEnd = 110811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void keyPressedAscii(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keyPressedAscii_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110811, XrefRangeEnd = 110823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setMode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMode_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110823, XrefRangeEnd = 110842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setDau()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setDau_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 110848, RefRangeEnd = 110856, XrefRangeStart = 110842, XrefRangeEnd = 110848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool keyPressed(int keyCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keyCode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keyPressed_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 110884, RefRangeEnd = 110888, XrefRangeStart = 110856, XrefRangeEnd = 110884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setOffset(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setOffset_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110888, XrefRangeEnd = 110906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintInputTf2(mGraphics g, bool iss, int x, int y, int w, int h, int xText, int yText, string text, string info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &iss;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &xText;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &yText;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintInputTf2_Public_Void_mGraphics_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110906, XrefRangeEnd = 110945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintInputTf(mGraphics g, bool iss, int x, int y, int w, int h, int xText, int yText, string text, string info)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &iss;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &xText;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &yText;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(info);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintInputTf_Public_Void_mGraphics_Boolean_Int32_Int32_Int32_Int32_Int32_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 111008, RefRangeEnd = 111025, XrefRangeStart = 110945, XrefRangeEnd = 111008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe bool isFocused()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isFocused_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111025, XrefRangeEnd = 111028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string subString(string str, int index, int indexTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexTo;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_subString_Public_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 111049, RefRangeEnd = 111060, XrefRangeStart = 111028, XrefRangeEnd = 111049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setPasswordTest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setPasswordTest_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 111112, RefRangeEnd = 111132, XrefRangeStart = 111060, XrefRangeEnd = 111112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111168, RefRangeEnd = 111169, XrefRangeStart = 111132, XrefRangeEnd = 111168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setTextBox()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTextBox_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111169, XrefRangeEnd = 111191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setFocus(bool isFocus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isFocus);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFocus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 111249, RefRangeEnd = 111255, XrefRangeStart = 111191, XrefRangeEnd = 111249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setFocusWithKb(bool isFocus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isFocus);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setFocusWithKb_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32815, RefRangeEnd = 32817, XrefRangeStart = 32815, XrefRangeEnd = 32817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getText()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111264, RefRangeEnd = 111266, XrefRangeStart = 111255, XrefRangeEnd = 111264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearKb()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearKb_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 111278, RefRangeEnd = 111313, XrefRangeStart = 111266, XrefRangeEnd = 111278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setText(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111313, XrefRangeEnd = 111320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void insertText(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_insertText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getMaxTextLenght()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMaxTextLenght_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe void setMaxTextLenght(int maxTextLenght)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxTextLenght);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setMaxTextLenght_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int getIputType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getIputType_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 111320, RefRangeEnd = 111358, XrefRangeStart = 111320, XrefRangeEnd = 111320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setIputType(int iputType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&iputType);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setIputType_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111358, XrefRangeEnd = 111359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void perform(int idAction, Il2CppSystem.Object p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TField(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
