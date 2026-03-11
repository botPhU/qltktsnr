using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class StaticObj : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TOP_CENTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOP_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_TOP_RIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOTTOM_HCENTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOTTOM_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_BOTTOM_RIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_VCENTER_HCENTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_VCENTER_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_SKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_VERSIONUPDATE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_KEYKILL;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_NORMAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_UP_FALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_UP_RUN;

	private static readonly System.IntPtr NativeFieldInfoPtr_FALL_RIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_FALL_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOD_ATTACK_ME;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_NON;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_VUKHI;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_AO;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_LIEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_TAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_NHAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_QUAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_BOI;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_GIAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_PHU;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_OTHER;

	private static readonly System.IntPtr NativeFieldInfoPtr_TYPE_CRYSTAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOCUS_MOD;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOCUS_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOCUS_PLAYER;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOCUS_ZONE;

	private static readonly System.IntPtr NativeFieldInfoPtr_FOCUS_NPC;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKYCOLOR;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int TOP_CENTER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOP_CENTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOP_CENTER, (void*)(&num));
		}
	}

	public unsafe static int TOP_LEFT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOP_LEFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOP_LEFT, (void*)(&num));
		}
	}

	public unsafe static int TOP_RIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TOP_RIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TOP_RIGHT, (void*)(&num));
		}
	}

	public unsafe static int BOTTOM_HCENTER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOTTOM_HCENTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOTTOM_HCENTER, (void*)(&num));
		}
	}

	public unsafe static int BOTTOM_LEFT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOTTOM_LEFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOTTOM_LEFT, (void*)(&num));
		}
	}

	public unsafe static int BOTTOM_RIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BOTTOM_RIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BOTTOM_RIGHT, (void*)(&num));
		}
	}

	public unsafe static int VCENTER_HCENTER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VCENTER_HCENTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VCENTER_HCENTER, (void*)(&num));
		}
	}

	public unsafe static int VCENTER_LEFT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VCENTER_LEFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VCENTER_LEFT, (void*)(&num));
		}
	}

	public unsafe static string SAVE_SKILL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAVE_SKILL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAVE_SKILL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SAVE_VERSIONUPDATE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAVE_VERSIONUPDATE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAVE_VERSIONUPDATE, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SAVE_KEYKILL
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAVE_KEYKILL, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAVE_KEYKILL, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string SAVE_ITEM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAVE_ITEM, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAVE_ITEM, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int NORMAL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NORMAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NORMAL, (void*)(&num));
		}
	}

	public unsafe static int UP_FALL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UP_FALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UP_FALL, (void*)(&num));
		}
	}

	public unsafe static int UP_RUN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UP_RUN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UP_RUN, (void*)(&num));
		}
	}

	public unsafe static int FALL_RIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FALL_RIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FALL_RIGHT, (void*)(&num));
		}
	}

	public unsafe static int FALL_LEFT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FALL_LEFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FALL_LEFT, (void*)(&num));
		}
	}

	public unsafe static int MOD_ATTACK_ME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOD_ATTACK_ME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOD_ATTACK_ME, (void*)(&num));
		}
	}

	public unsafe static int TYPE_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_PLAYER, (void*)(&num));
		}
	}

	public unsafe static int TYPE_NON
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_NON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_NON, (void*)(&num));
		}
	}

	public unsafe static int TYPE_VUKHI
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_VUKHI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_VUKHI, (void*)(&num));
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

	public unsafe static int TYPE_LIEN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_LIEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_LIEN, (void*)(&num));
		}
	}

	public unsafe static int TYPE_TAY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_TAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_TAY, (void*)(&num));
		}
	}

	public unsafe static int TYPE_NHAN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_NHAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_NHAN, (void*)(&num));
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

	public unsafe static int TYPE_BOI
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_BOI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_BOI, (void*)(&num));
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

	public unsafe static int TYPE_PHU
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_PHU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_PHU, (void*)(&num));
		}
	}

	public unsafe static int TYPE_OTHER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_OTHER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_OTHER, (void*)(&num));
		}
	}

	public unsafe static int TYPE_CRYSTAL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TYPE_CRYSTAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TYPE_CRYSTAL, (void*)(&num));
		}
	}

	public unsafe static int FOCUS_MOD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FOCUS_MOD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FOCUS_MOD, (void*)(&num));
		}
	}

	public unsafe static int FOCUS_ITEM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FOCUS_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FOCUS_ITEM, (void*)(&num));
		}
	}

	public unsafe static int FOCUS_PLAYER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FOCUS_PLAYER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FOCUS_PLAYER, (void*)(&num));
		}
	}

	public unsafe static int FOCUS_ZONE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FOCUS_ZONE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FOCUS_ZONE, (void*)(&num));
		}
	}

	public unsafe static int FOCUS_NPC
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FOCUS_NPC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FOCUS_NPC, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> SKYCOLOR
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKYCOLOR, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKYCOLOR, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static StaticObj()
	{
		Il2CppClassPointerStore<StaticObj>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StaticObj");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticObj>.NativeClassPtr);
		NativeFieldInfoPtr_TOP_CENTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TOP_CENTER");
		NativeFieldInfoPtr_TOP_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TOP_LEFT");
		NativeFieldInfoPtr_TOP_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TOP_RIGHT");
		NativeFieldInfoPtr_BOTTOM_HCENTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "BOTTOM_HCENTER");
		NativeFieldInfoPtr_BOTTOM_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "BOTTOM_LEFT");
		NativeFieldInfoPtr_BOTTOM_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "BOTTOM_RIGHT");
		NativeFieldInfoPtr_VCENTER_HCENTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "VCENTER_HCENTER");
		NativeFieldInfoPtr_VCENTER_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "VCENTER_LEFT");
		NativeFieldInfoPtr_SAVE_SKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "SAVE_SKILL");
		NativeFieldInfoPtr_SAVE_VERSIONUPDATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "SAVE_VERSIONUPDATE");
		NativeFieldInfoPtr_SAVE_KEYKILL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "SAVE_KEYKILL");
		NativeFieldInfoPtr_SAVE_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "SAVE_ITEM");
		NativeFieldInfoPtr_NORMAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "NORMAL");
		NativeFieldInfoPtr_UP_FALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "UP_FALL");
		NativeFieldInfoPtr_UP_RUN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "UP_RUN");
		NativeFieldInfoPtr_FALL_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "FALL_RIGHT");
		NativeFieldInfoPtr_FALL_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "FALL_LEFT");
		NativeFieldInfoPtr_MOD_ATTACK_ME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "MOD_ATTACK_ME");
		NativeFieldInfoPtr_TYPE_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_PLAYER");
		NativeFieldInfoPtr_TYPE_NON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_NON");
		NativeFieldInfoPtr_TYPE_VUKHI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_VUKHI");
		NativeFieldInfoPtr_TYPE_AO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_AO");
		NativeFieldInfoPtr_TYPE_LIEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_LIEN");
		NativeFieldInfoPtr_TYPE_TAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_TAY");
		NativeFieldInfoPtr_TYPE_NHAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_NHAN");
		NativeFieldInfoPtr_TYPE_QUAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_QUAN");
		NativeFieldInfoPtr_TYPE_BOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_BOI");
		NativeFieldInfoPtr_TYPE_GIAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_GIAY");
		NativeFieldInfoPtr_TYPE_PHU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_PHU");
		NativeFieldInfoPtr_TYPE_OTHER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_OTHER");
		NativeFieldInfoPtr_TYPE_CRYSTAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "TYPE_CRYSTAL");
		NativeFieldInfoPtr_FOCUS_MOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "FOCUS_MOD");
		NativeFieldInfoPtr_FOCUS_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "FOCUS_ITEM");
		NativeFieldInfoPtr_FOCUS_PLAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "FOCUS_PLAYER");
		NativeFieldInfoPtr_FOCUS_ZONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "FOCUS_ZONE");
		NativeFieldInfoPtr_FOCUS_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "FOCUS_NPC");
		NativeFieldInfoPtr_SKYCOLOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, "SKYCOLOR");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticObj>.NativeClassPtr, 100666312);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StaticObj()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticObj>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public StaticObj(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
