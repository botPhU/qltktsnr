using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class ChatPopup : Effect2
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sayWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_delay;

	private static readonly System.IntPtr NativeFieldInfoPtr_sayRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_says;

	private static readonly System.IntPtr NativeFieldInfoPtr_cx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cy;

	private static readonly System.IntPtr NativeFieldInfoPtr_ch;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmy;

	private static readonly System.IntPtr NativeFieldInfoPtr_lim;

	private static readonly System.IntPtr NativeFieldInfoPtr_c;

	private static readonly System.IntPtr NativeFieldInfoPtr_outSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_curr;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_lines;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdNextLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdMsg1;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdMsg2;

	private static readonly System.IntPtr NativeFieldInfoPtr_currChatPopup;

	private static readonly System.IntPtr NativeFieldInfoPtr_serverChatPopUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextMultiChatPopUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShopDetail;

	private static readonly System.IntPtr NativeFieldInfoPtr_starSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxStarSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_scr;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHavePetNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_mH;

	private static readonly System.IntPtr NativeFieldInfoPtr_performDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_dx;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy;

	private static readonly System.IntPtr NativeFieldInfoPtr_second;

	private static readonly System.IntPtr NativeFieldInfoPtr_numSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_nMaxslot_duoi;

	private static readonly System.IntPtr NativeFieldInfoPtr_nMaxslot_tren;

	private static readonly System.IntPtr NativeFieldInfoPtr_nslot_duoi;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgStar;

	private static readonly System.IntPtr NativeFieldInfoPtr_strY;

	private static readonly System.IntPtr NativeFieldInfoPtr_iconID;

	private static readonly System.IntPtr NativeFieldInfoPtr_isClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyText;

	private static readonly System.IntPtr NativeFieldInfoPtr_pxx;

	private static readonly System.IntPtr NativeFieldInfoPtr_pyy;

	private static readonly System.IntPtr NativeMethodInfoPtr_addNextPopUpMultiLine_Public_Static_Void_String_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addBigMessage_Public_Static_Void_String_Int32_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addChatPopupMultiLine_Public_Static_Void_String_Int32_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addChatPopupWithIcon_Public_Static_ChatPopup_String_Int32_Npc_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addChatPopup_Public_Static_ChatPopup_String_Int32_Npc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintRada_Public_Void_mGraphics_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doKeyText_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintCmd_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int sayWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sayWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sayWidth)) = num;
		}
	}

	public unsafe int delay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay)) = num;
		}
	}

	public unsafe int sayRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sayRun);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sayRun)) = num;
		}
	}

	public unsafe Il2CppStringArray says
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_says);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_says)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
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

	public unsafe int cmx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmx)) = num;
		}
	}

	public unsafe int cmy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmy)) = num;
		}
	}

	public unsafe int lim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lim);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lim)) = num;
		}
	}

	public unsafe Npc c
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Npc>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc));
		}
	}

	public unsafe bool outSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outSide);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outSide)) = flag;
		}
	}

	public unsafe static long curr
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curr, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curr, (void*)(&num));
		}
	}

	public unsafe static long last
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_last, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_last, (void*)(&num));
		}
	}

	public unsafe int currentLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLine);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentLine)) = num;
		}
	}

	public unsafe Il2CppStringArray lines
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lines)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Command cmdNextLine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdNextLine);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdNextLine)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdMsg1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdMsg1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdMsg1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command cmdMsg2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdMsg2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdMsg2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe static ChatPopup currChatPopup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currChatPopup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatPopup>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currChatPopup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatPopup));
		}
	}

	public unsafe static ChatPopup serverChatPopUp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serverChatPopUp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatPopup>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serverChatPopUp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatPopup));
		}
	}

	public unsafe static string nextMultiChatPopUp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nextMultiChatPopUp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nextMultiChatPopUp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Npc nextChar
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nextChar, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Npc>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nextChar, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)npc));
		}
	}

	public unsafe bool isShopDetail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShopDetail);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isShopDetail)) = flag;
		}
	}

	public unsafe sbyte starSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starSlot);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_starSlot)) = b;
		}
	}

	public unsafe sbyte maxStarSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStarSlot);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxStarSlot)) = b;
		}
	}

	public unsafe static Scroll scr
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scr, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scroll>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scr, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scroll));
		}
	}

	public unsafe static bool isHavePetNpc
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isHavePetNpc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isHavePetNpc, (void*)(&flag));
		}
	}

	public unsafe int mH
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mH);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mH)) = num;
		}
	}

	public unsafe static int performDelay
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_performDelay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_performDelay, (void*)(&num));
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

	public unsafe int second
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_second);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_second)) = num;
		}
	}

	public unsafe static int numSlot
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_numSlot, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_numSlot, (void*)(&num));
		}
	}

	public unsafe int nMaxslot_duoi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nMaxslot_duoi);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nMaxslot_duoi)) = num;
		}
	}

	public unsafe int nMaxslot_tren
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nMaxslot_tren);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nMaxslot_tren)) = num;
		}
	}

	public unsafe int nslot_duoi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nslot_duoi);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nslot_duoi)) = num;
		}
	}

	public unsafe Image imgStar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgStar);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgStar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe int strY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strY)) = num;
		}
	}

	public unsafe int iconID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconID)) = num;
		}
	}

	public unsafe bool isClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClip)) = flag;
		}
	}

	public unsafe static int cmyText
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmyText, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmyText, (void*)(&num));
		}
	}

	public unsafe int pxx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pxx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pxx)) = num;
		}
	}

	public unsafe int pyy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pyy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pyy)) = num;
		}
	}

	static ChatPopup()
	{
		Il2CppClassPointerStore<ChatPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ChatPopup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr);
		NativeFieldInfoPtr_sayWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "sayWidth");
		NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "delay");
		NativeFieldInfoPtr_sayRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "sayRun");
		NativeFieldInfoPtr_says = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "says");
		NativeFieldInfoPtr_cx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cx");
		NativeFieldInfoPtr_cy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cy");
		NativeFieldInfoPtr_ch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "ch");
		NativeFieldInfoPtr_cmx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cmx");
		NativeFieldInfoPtr_cmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cmy");
		NativeFieldInfoPtr_lim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "lim");
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "c");
		NativeFieldInfoPtr_outSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "outSide");
		NativeFieldInfoPtr_curr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "curr");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "last");
		NativeFieldInfoPtr_currentLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "currentLine");
		NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "lines");
		NativeFieldInfoPtr_cmdNextLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cmdNextLine");
		NativeFieldInfoPtr_cmdMsg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cmdMsg1");
		NativeFieldInfoPtr_cmdMsg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cmdMsg2");
		NativeFieldInfoPtr_currChatPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "currChatPopup");
		NativeFieldInfoPtr_serverChatPopUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "serverChatPopUp");
		NativeFieldInfoPtr_nextMultiChatPopUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "nextMultiChatPopUp");
		NativeFieldInfoPtr_nextChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "nextChar");
		NativeFieldInfoPtr_isShopDetail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "isShopDetail");
		NativeFieldInfoPtr_starSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "starSlot");
		NativeFieldInfoPtr_maxStarSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "maxStarSlot");
		NativeFieldInfoPtr_scr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "scr");
		NativeFieldInfoPtr_isHavePetNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "isHavePetNpc");
		NativeFieldInfoPtr_mH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "mH");
		NativeFieldInfoPtr_performDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "performDelay");
		NativeFieldInfoPtr_dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "dx");
		NativeFieldInfoPtr_dy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "dy");
		NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "second");
		NativeFieldInfoPtr_numSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "numSlot");
		NativeFieldInfoPtr_nMaxslot_duoi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "nMaxslot_duoi");
		NativeFieldInfoPtr_nMaxslot_tren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "nMaxslot_tren");
		NativeFieldInfoPtr_nslot_duoi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "nslot_duoi");
		NativeFieldInfoPtr_imgStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "imgStar");
		NativeFieldInfoPtr_strY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "strY");
		NativeFieldInfoPtr_iconID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "iconID");
		NativeFieldInfoPtr_isClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "isClip");
		NativeFieldInfoPtr_cmyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "cmyText");
		NativeFieldInfoPtr_pxx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "pxx");
		NativeFieldInfoPtr_pyy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, "pyy");
		NativeMethodInfoPtr_addNextPopUpMultiLine_Public_Static_Void_String_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663683);
		NativeMethodInfoPtr_addBigMessage_Public_Static_Void_String_Int32_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663684);
		NativeMethodInfoPtr_addChatPopupMultiLine_Public_Static_Void_String_Int32_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663685);
		NativeMethodInfoPtr_addChatPopupWithIcon_Public_Static_ChatPopup_String_Int32_Npc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663686);
		NativeMethodInfoPtr_addChatPopup_Public_Static_ChatPopup_String_Int32_Npc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663687);
		NativeMethodInfoPtr_update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr_paintRada_Public_Void_mGraphics_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr_doKeyText_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663691);
		NativeMethodInfoPtr_updateKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663692);
		NativeMethodInfoPtr_paintCmd_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr, 100663695);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15060, RefRangeEnd = 15061, XrefRangeStart = 15041, XrefRangeEnd = 15060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addNextPopUpMultiLine(string strNext, Npc next)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strNext);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)next);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addNextPopUpMultiLine_Public_Static_Void_String_Npc_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15110, RefRangeEnd = 15112, XrefRangeStart = 15061, XrefRangeEnd = 15110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addBigMessage(string chat, int howLong, Npc c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chat);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &howLong;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addBigMessage_Public_Static_Void_String_Int32_Npc_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 15160, RefRangeEnd = 15163, XrefRangeStart = 15112, XrefRangeEnd = 15160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addChatPopupMultiLine(string chat, int howLong, Npc c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chat);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &howLong;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addChatPopupMultiLine_Public_Static_Void_String_Int32_Npc_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 15230, RefRangeEnd = 15231, XrefRangeStart = 15163, XrefRangeEnd = 15230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ChatPopup addChatPopupWithIcon(string chat, int howLong, Npc c, int idIcon)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chat);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &howLong;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &idIcon;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addChatPopupWithIcon_Public_Static_ChatPopup_String_Int32_Npc_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatPopup>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 15298, RefRangeEnd = 15305, XrefRangeStart = 15231, XrefRangeEnd = 15298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ChatPopup addChatPopup(string chat, int howLong, Npc c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chat);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &howLong;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addChatPopup_Public_Static_ChatPopup_String_Int32_Npc_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatPopup>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15305, XrefRangeEnd = 15367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15367, XrefRangeEnd = 15581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 15661, RefRangeEnd = 15662, XrefRangeStart = 15581, XrefRangeEnd = 15661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintRada(mGraphics g, int cmyText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmyText;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintRada_Public_Void_mGraphics_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15674, RefRangeEnd = 15676, XrefRangeStart = 15662, XrefRangeEnd = 15674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doKeyText(int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doKeyText_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 15845, RefRangeEnd = 15847, XrefRangeStart = 15676, XrefRangeEnd = 15845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15847, XrefRangeEnd = 15865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintCmd(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintCmd_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15865, XrefRangeEnd = 15913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 15917, RefRangeEnd = 15928, XrefRangeStart = 15913, XrefRangeEnd = 15917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ChatPopup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatPopup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ChatPopup(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
