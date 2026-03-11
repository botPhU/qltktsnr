using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Skill : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ATT_STAND;

	private static readonly System.IntPtr NativeFieldInfoPtr_ATT_FLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_AUTO_USE;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_CLICK_USE_ATTACK;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_CLICK_USE_BUFF;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_CLICK_NPC;

	private static readonly System.IntPtr NativeFieldInfoPtr_SKILL_CLICK_LIVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_template;

	private static readonly System.IntPtr NativeFieldInfoPtr_skillId;

	private static readonly System.IntPtr NativeFieldInfoPtr_point;

	private static readonly System.IntPtr NativeFieldInfoPtr_powRequire;

	private static readonly System.IntPtr NativeFieldInfoPtr_coolDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeUseThisSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_dx;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxFight;

	private static readonly System.IntPtr NativeFieldInfoPtr_manaUse;

	private static readonly System.IntPtr NativeFieldInfoPtr_options;

	private static readonly System.IntPtr NativeFieldInfoPtr_paintCanNotUseSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_damage;

	private static readonly System.IntPtr NativeFieldInfoPtr_moreInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_price;

	private static readonly System.IntPtr NativeFieldInfoPtr_curExp;

	private static readonly System.IntPtr NativeMethodInfoPtr_strCurExp_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_strTimeReplay_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_Int32_Int32_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static sbyte ATT_STAND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ATT_STAND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ATT_STAND, (void*)(&b));
		}
	}

	public unsafe static sbyte ATT_FLY
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ATT_FLY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ATT_FLY, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_AUTO_USE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_AUTO_USE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_AUTO_USE, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_CLICK_USE_ATTACK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_CLICK_USE_ATTACK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_CLICK_USE_ATTACK, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_CLICK_USE_BUFF
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_CLICK_USE_BUFF, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_CLICK_USE_BUFF, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_CLICK_NPC
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_CLICK_NPC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_CLICK_NPC, (void*)(&b));
		}
	}

	public unsafe static sbyte SKILL_CLICK_LIVE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SKILL_CLICK_LIVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SKILL_CLICK_LIVE, (void*)(&b));
		}
	}

	public unsafe SkillTemplate template
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillTemplate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillTemplate));
		}
	}

	public unsafe short skillId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillId);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skillId)) = num;
		}
	}

	public unsafe int point
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_point);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_point)) = num;
		}
	}

	public unsafe long powRequire
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powRequire);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_powRequire)) = num;
		}
	}

	public unsafe int coolDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coolDown);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coolDown)) = num;
		}
	}

	public unsafe long lastTimeUseThisSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeUseThisSkill);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeUseThisSkill)) = num;
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

	public unsafe int maxFight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxFight)) = num;
		}
	}

	public unsafe int manaUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manaUse);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manaUse)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<SkillOption> options
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkillOption>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool paintCanNotUseSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintCanNotUseSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paintCanNotUseSkill)) = flag;
		}
	}

	public unsafe short damage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damage);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_damage)) = num;
		}
	}

	public unsafe string moreInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreInfo);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreInfo)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe short price
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_price)) = num;
		}
	}

	public unsafe short curExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curExp);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curExp)) = num;
		}
	}

	static Skill()
	{
		Il2CppClassPointerStore<Skill>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Skill");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skill>.NativeClassPtr);
		NativeFieldInfoPtr_ATT_STAND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "ATT_STAND");
		NativeFieldInfoPtr_ATT_FLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "ATT_FLY");
		NativeFieldInfoPtr_SKILL_AUTO_USE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "SKILL_AUTO_USE");
		NativeFieldInfoPtr_SKILL_CLICK_USE_ATTACK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "SKILL_CLICK_USE_ATTACK");
		NativeFieldInfoPtr_SKILL_CLICK_USE_BUFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "SKILL_CLICK_USE_BUFF");
		NativeFieldInfoPtr_SKILL_CLICK_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "SKILL_CLICK_NPC");
		NativeFieldInfoPtr_SKILL_CLICK_LIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "SKILL_CLICK_LIVE");
		NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "template");
		NativeFieldInfoPtr_skillId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "skillId");
		NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "point");
		NativeFieldInfoPtr_powRequire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "powRequire");
		NativeFieldInfoPtr_coolDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "coolDown");
		NativeFieldInfoPtr_lastTimeUseThisSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "lastTimeUseThisSkill");
		NativeFieldInfoPtr_dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "dx");
		NativeFieldInfoPtr_dy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "dy");
		NativeFieldInfoPtr_maxFight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "maxFight");
		NativeFieldInfoPtr_manaUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "manaUse");
		NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "options");
		NativeFieldInfoPtr_paintCanNotUseSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "paintCanNotUseSkill");
		NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "damage");
		NativeFieldInfoPtr_moreInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "moreInfo");
		NativeFieldInfoPtr_price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "price");
		NativeFieldInfoPtr_curExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skill>.NativeClassPtr, "curExp");
		NativeMethodInfoPtr_strCurExp_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100666156);
		NativeMethodInfoPtr_strTimeReplay_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100666157);
		NativeMethodInfoPtr_paint_Public_Void_Int32_Int32_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100666158);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skill>.NativeClassPtr, 100666159);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95900, XrefRangeEnd = 95908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string strCurExp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_strCurExp_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95915, RefRangeEnd = 95917, XrefRangeStart = 95908, XrefRangeEnd = 95915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string strTimeReplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_strTimeReplay_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95930, RefRangeEnd = 95931, XrefRangeStart = 95917, XrefRangeEnd = 95930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint(int x, int y, mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Void_Int32_Int32_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Skill()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skill>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Skill(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
