using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Skills : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_skills;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Public_Static_Void_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Public_Static_Skill_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static MyHashTable skills
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_skills, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyHashTable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_skills, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myHashTable));
		}
	}

	static Skills()
	{
		Il2CppClassPointerStore<Skills>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Skills");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Skills>.NativeClassPtr);
		NativeFieldInfoPtr_skills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Skills>.NativeClassPtr, "skills");
		NativeMethodInfoPtr_add_Public_Static_Void_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skills>.NativeClassPtr, 100666165);
		NativeMethodInfoPtr_get_Public_Static_Skill_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skills>.NativeClassPtr, 100666166);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Skills>.NativeClassPtr, 100666167);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95947, RefRangeEnd = 95948, XrefRangeStart = 95939, XrefRangeEnd = 95947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add(Skill skill)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_Public_Static_Void_Skill_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 95958, RefRangeEnd = 95963, XrefRangeStart = 95948, XrefRangeEnd = 95958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Skill get(short skillId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skillId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Public_Static_Skill_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skill>(intPtr) : null;
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Skills()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Skills>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Skills(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
