using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Menu : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_showMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuSelectedItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuX;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuY;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuW;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuH;

	private static readonly System.IntPtr NativeFieldInfoPtr_menuTemY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmxLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_xc;

	private static readonly System.IntPtr NativeFieldInfoPtr_left;

	private static readonly System.IntPtr NativeFieldInfoPtr_right;

	private static readonly System.IntPtr NativeFieldInfoPtr_center;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMenu1;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMenu2;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_tDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_pa;

	private static readonly System.IntPtr NativeFieldInfoPtr_trans;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerDownTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerDownFirstX;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerDownLastX;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointerIsDowning;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDownWhenRunning;

	private static readonly System.IntPtr NativeFieldInfoPtr_wantUpdateList;

	private static readonly System.IntPtr NativeFieldInfoPtr_waitToPerform;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_touch;

	private static readonly System.IntPtr NativeFieldInfoPtr_close;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_isClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNotClose;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadBg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startWithoutCloseButton_Public_Void_MyVector_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startAt_Public_Void_MyVector_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startAt_Public_Void_MyVector_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isScrolling_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMenuKey_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveCamera_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintMenu_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doCloseMenu_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_performSelect_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateMenu_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool showMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showMenu)) = flag;
		}
	}

	public unsafe MyVector menuItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuItems)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe int menuSelectedItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuSelectedItem);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuSelectedItem)) = num;
		}
	}

	public unsafe int menuX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuX)) = num;
		}
	}

	public unsafe int menuY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuY)) = num;
		}
	}

	public unsafe int menuW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuW);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuW)) = num;
		}
	}

	public unsafe int menuH
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuH);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_menuH)) = num;
		}
	}

	public unsafe static Il2CppStructArray<int> menuTemY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_menuTemY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_menuTemY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
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

	public unsafe static int xc
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xc, (void*)(&num));
		}
	}

	public unsafe Command left
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_left)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command right
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_right)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe Command center
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_center);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_center)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe static Image imgMenu1
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMenu1, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMenu1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMenu2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMenu2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMenu2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe bool disableClose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableClose);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableClose)) = flag;
		}
	}

	public unsafe int tDelay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tDelay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tDelay)) = num;
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

	public unsafe int pa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pa);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pa)) = num;
		}
	}

	public unsafe bool trans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trans)) = flag;
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

	public unsafe bool wantUpdateList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wantUpdateList);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wantUpdateList)) = flag;
		}
	}

	public unsafe int waitToPerform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitToPerform);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_waitToPerform)) = num;
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

	public unsafe bool touch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_touch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_touch)) = flag;
		}
	}

	public unsafe bool close
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_close);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_close)) = flag;
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

	public unsafe bool isClose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClose);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClose)) = flag;
		}
	}

	public unsafe Il2CppStructArray<bool> isNotClose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNotClose);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isNotClose)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static Menu()
	{
		Il2CppClassPointerStore<Menu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Menu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Menu>.NativeClassPtr);
		NativeFieldInfoPtr_showMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "showMenu");
		NativeFieldInfoPtr_menuItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "menuItems");
		NativeFieldInfoPtr_menuSelectedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "menuSelectedItem");
		NativeFieldInfoPtr_menuX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "menuX");
		NativeFieldInfoPtr_menuY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "menuY");
		NativeFieldInfoPtr_menuW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "menuW");
		NativeFieldInfoPtr_menuH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "menuH");
		NativeFieldInfoPtr_menuTemY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "menuTemY");
		NativeFieldInfoPtr_cmtoX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmtoX");
		NativeFieldInfoPtr_cmx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmx");
		NativeFieldInfoPtr_cmdy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmdy");
		NativeFieldInfoPtr_cmvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmvy");
		NativeFieldInfoPtr_cmxLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmxLim");
		NativeFieldInfoPtr_xc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "xc");
		NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "left");
		NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "right");
		NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "center");
		NativeFieldInfoPtr_imgMenu1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "imgMenu1");
		NativeFieldInfoPtr_imgMenu2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "imgMenu2");
		NativeFieldInfoPtr_disableClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "disableClose");
		NativeFieldInfoPtr_tDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "tDelay");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "w");
		NativeFieldInfoPtr_pa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pa");
		NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "trans");
		NativeFieldInfoPtr_pointerDownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pointerDownTime");
		NativeFieldInfoPtr_pointerDownFirstX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pointerDownFirstX");
		NativeFieldInfoPtr_pointerDownLastX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pointerDownLastX");
		NativeFieldInfoPtr_pointerIsDowning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "pointerIsDowning");
		NativeFieldInfoPtr_isDownWhenRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "isDownWhenRunning");
		NativeFieldInfoPtr_wantUpdateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "wantUpdateList");
		NativeFieldInfoPtr_waitToPerform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "waitToPerform");
		NativeFieldInfoPtr_cmRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmRun");
		NativeFieldInfoPtr_touch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "touch");
		NativeFieldInfoPtr_close = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "close");
		NativeFieldInfoPtr_cmvx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmvx");
		NativeFieldInfoPtr_cmdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "cmdx");
		NativeFieldInfoPtr_isClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "isClose");
		NativeFieldInfoPtr_isNotClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Menu>.NativeClassPtr, "isNotClose");
		NativeMethodInfoPtr_loadBg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664715);
		NativeMethodInfoPtr_startWithoutCloseButton_Public_Void_MyVector_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664716);
		NativeMethodInfoPtr_startAt_Public_Void_MyVector_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664717);
		NativeMethodInfoPtr_startAt_Public_Void_MyVector_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664718);
		NativeMethodInfoPtr_isScrolling_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664719);
		NativeMethodInfoPtr_updateMenuKey_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664720);
		NativeMethodInfoPtr_moveCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664721);
		NativeMethodInfoPtr_paintMenu_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664722);
		NativeMethodInfoPtr_doCloseMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664723);
		NativeMethodInfoPtr_performSelect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664724);
		NativeMethodInfoPtr_updateMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664725);
		NativeMethodInfoPtr_perform_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664726);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Menu>.NativeClassPtr, 100664727);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57068, XrefRangeEnd = 57084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadBg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadBg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57085, RefRangeEnd = 57086, XrefRangeStart = 57084, XrefRangeEnd = 57085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startWithoutCloseButton(MyVector menuItems, int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)menuItems);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startWithoutCloseButton_Public_Void_MyVector_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 57092, RefRangeEnd = 57107, XrefRangeStart = 57086, XrefRangeEnd = 57092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startAt(MyVector menuItems, int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)menuItems);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startAt_Public_Void_MyVector_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(43)]
	[CachedScanResults(RefRangeStart = 57130, RefRangeEnd = 57173, XrefRangeStart = 57107, XrefRangeEnd = 57130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startAt(MyVector menuItems, int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)menuItems);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startAt_Public_Void_MyVector_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57176, RefRangeEnd = 57177, XrefRangeStart = 57173, XrefRangeEnd = 57176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isScrolling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isScrolling_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57194, RefRangeEnd = 57195, XrefRangeStart = 57177, XrefRangeEnd = 57194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateMenuKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMenuKey_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57195, XrefRangeEnd = 57202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void moveCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57259, RefRangeEnd = 57260, XrefRangeStart = 57202, XrefRangeEnd = 57259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintMenu(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintMenu_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57288, RefRangeEnd = 57289, XrefRangeStart = 57260, XrefRangeEnd = 57288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doCloseMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doCloseMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57289, XrefRangeEnd = 57294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void performSelect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_performSelect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57328, RefRangeEnd = 57329, XrefRangeStart = 57294, XrefRangeEnd = 57328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void perform(int idAction, Il2CppSystem.Object p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_perform_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57329, XrefRangeEnd = 57356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Menu()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Menu>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Menu(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
