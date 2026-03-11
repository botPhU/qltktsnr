using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Scroll : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdy;

	private static readonly System.IntPtr NativeFieldInfoPtr_xPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_yPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmxLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_gI;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerDownTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerDownFirstX;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerDownLastX;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerIsDowning;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDownWhenRunning;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_selectedItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_nITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_ITEM_PER_LINE;

	private static readonly System.IntPtr NativeFieldInfoPtr_styleUPDOWN;

	private static readonly System.IntPtr NativeMethodInfoPtr_clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKey_Public_ScrollResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKey_Public_ScrollResult_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKeyScrollUpDown_Private_ScrollResult_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKeyScrollLeftRight_Private_ScrollResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updatecm_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setStyle_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveTo_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gIz_Public_Static_Scroll_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int cmtoX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoX)) = num;
		}
	}

	public unsafe int cmtoY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoY)) = num;
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

	public unsafe int cmvx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvx)) = num;
		}
	}

	public unsafe int cmvy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvy)) = num;
		}
	}

	public unsafe int cmdx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdx)) = num;
		}
	}

	public unsafe int cmdy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdy)) = num;
		}
	}

	public unsafe int xPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xPos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xPos)) = num;
		}
	}

	public unsafe int yPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yPos)) = num;
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

	public unsafe int cmxLim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxLim);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxLim)) = num;
		}
	}

	public unsafe int cmyLim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyLim);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyLim)) = num;
		}
	}

	public unsafe static Scroll gI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scroll>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scroll));
		}
	}

	public unsafe int pointerDownTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerDownTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerDownTime)) = num;
		}
	}

	public unsafe int pointerDownFirstX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerDownFirstX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerDownFirstX)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> pointerDownLastX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerDownLastX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerDownLastX)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool pointerIsDowning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerIsDowning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointerIsDowning)) = flag;
		}
	}

	public unsafe bool isDownWhenRunning
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDownWhenRunning);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDownWhenRunning)) = flag;
		}
	}

	public unsafe int cmRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmRun);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmRun)) = num;
		}
	}

	public unsafe int selectedItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedItem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedItem)) = num;
		}
	}

	public unsafe int ITEM_SIZE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ITEM_SIZE);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ITEM_SIZE)) = num;
		}
	}

	public unsafe int nITEM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nITEM);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nITEM)) = num;
		}
	}

	public unsafe int ITEM_PER_LINE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ITEM_PER_LINE);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ITEM_PER_LINE)) = num;
		}
	}

	public unsafe bool styleUPDOWN
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleUPDOWN);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleUPDOWN)) = flag;
		}
	}

	static Scroll()
	{
		Il2CppClassPointerStore<Scroll>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Scroll");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scroll>.NativeClassPtr);
		NativeFieldInfoPtr_cmtoX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmtoX");
		NativeFieldInfoPtr_cmtoY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmtoY");
		NativeFieldInfoPtr_cmx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmx");
		NativeFieldInfoPtr_cmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmy");
		NativeFieldInfoPtr_cmvx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmvx");
		NativeFieldInfoPtr_cmvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmvy");
		NativeFieldInfoPtr_cmdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmdx");
		NativeFieldInfoPtr_cmdy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmdy");
		NativeFieldInfoPtr_xPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "xPos");
		NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "yPos");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "height");
		NativeFieldInfoPtr_cmxLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmxLim");
		NativeFieldInfoPtr_cmyLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmyLim");
		NativeFieldInfoPtr_gI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "gI");
		NativeFieldInfoPtr_pointerDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "pointerDownTime");
		NativeFieldInfoPtr_pointerDownFirstX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "pointerDownFirstX");
		NativeFieldInfoPtr_pointerDownLastX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "pointerDownLastX");
		NativeFieldInfoPtr_pointerIsDowning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "pointerIsDowning");
		NativeFieldInfoPtr_isDownWhenRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "isDownWhenRunning");
		NativeFieldInfoPtr_cmRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "cmRun");
		NativeFieldInfoPtr_selectedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "selectedItem");
		NativeFieldInfoPtr_ITEM_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "ITEM_SIZE");
		NativeFieldInfoPtr_nITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "nITEM");
		NativeFieldInfoPtr_ITEM_PER_LINE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "ITEM_PER_LINE");
		NativeFieldInfoPtr_styleUPDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scroll>.NativeClassPtr, "styleUPDOWN");
		NativeMethodInfoPtr_clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665783);
		NativeMethodInfoPtr_updateKey_Public_ScrollResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665784);
		NativeMethodInfoPtr_updateKey_Public_ScrollResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665785);
		NativeMethodInfoPtr_updateKeyScrollUpDown_Private_ScrollResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665786);
		NativeMethodInfoPtr_updateKeyScrollLeftRight_Private_ScrollResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665787);
		NativeMethodInfoPtr_updatecm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665788);
		NativeMethodInfoPtr_setStyle_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665789);
		NativeMethodInfoPtr_moveTo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665790);
		NativeMethodInfoPtr_gIz_Public_Static_Scroll_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665791);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scroll>.NativeClassPtr, 100665792);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 86464, RefRangeEnd = 86467, XrefRangeStart = 86464, XrefRangeEnd = 86464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 86469, RefRangeEnd = 86473, XrefRangeStart = 86467, XrefRangeEnd = 86469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollResult updateKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKey_Public_ScrollResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollResult>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86473, XrefRangeEnd = 86475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollResult updateKey(bool isGetSelectNow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isGetSelectNow);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKey_Public_ScrollResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollResult>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86542, RefRangeEnd = 86544, XrefRangeStart = 86475, XrefRangeEnd = 86542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollResult updateKeyScrollUpDown(bool isGetNow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isGetNow);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKeyScrollUpDown_Private_ScrollResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollResult>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86600, RefRangeEnd = 86602, XrefRangeStart = 86544, XrefRangeEnd = 86600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollResult updateKeyScrollLeftRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateKeyScrollLeftRight_Private_ScrollResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScrollResult>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 86607, RefRangeEnd = 86612, XrefRangeStart = 86602, XrefRangeEnd = 86607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updatecm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updatecm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 86636, RefRangeEnd = 86639, XrefRangeStart = 86612, XrefRangeEnd = 86636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setStyle(int nItem, int ITEM_SIZE, int xPos, int yPos, int width, int height, bool styleUPDOWN, int ITEM_PER_LINE)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&nItem);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ITEM_SIZE;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &xPos;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &yPos;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &styleUPDOWN;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &ITEM_PER_LINE;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setStyle_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 86639, RefRangeEnd = 86642, XrefRangeStart = 86639, XrefRangeEnd = 86639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void moveTo(int to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&to);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveTo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86642, XrefRangeEnd = 86654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Scroll gIz()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gIz_Public_Static_Scroll_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scroll>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 86659, RefRangeEnd = 86662, XrefRangeStart = 86654, XrefRangeEnd = 86659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Scroll()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scroll>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Scroll(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
