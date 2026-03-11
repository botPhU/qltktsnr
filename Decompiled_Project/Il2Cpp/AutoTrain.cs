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

public class AutoTrain : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoTrain;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAvoidSuperMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_minimumMPGoHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMPPercentGoHome;

	private static readonly System.IntPtr NativeFieldInfoPtr_listMobIds;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeAddNewMob;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeTeleportToMob;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInstance_Public_Static_AutoTrain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMeCanAttack_Private_Static_Boolean_Mob_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetFocus_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoIt_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseGrape_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AutoTrain _Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoTrain>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoTrain));
		}
	}

	public unsafe static bool isAutoTrain
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoTrain, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoTrain, (void*)(&flag));
		}
	}

	public unsafe static bool isAvoidSuperMob
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAvoidSuperMob, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAvoidSuperMob, (void*)(&flag));
		}
	}

	public unsafe static int minimumMPGoHome
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_minimumMPGoHome, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_minimumMPGoHome, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray inputMPPercentGoHome
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputMPPercentGoHome, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputMPPercentGoHome, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static List<Mob> listMobIds
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listMobIds, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Mob>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listMobIds, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static long lastTimeAddNewMob
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeAddNewMob, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeAddNewMob, (void*)(&num));
		}
	}

	public unsafe static long lastTimeTeleportToMob
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeTeleportToMob, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeTeleportToMob, (void*)(&num));
		}
	}

	static AutoTrain()
	{
		Il2CppClassPointerStore<AutoTrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AutoTrain");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr);
		NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "_Instance");
		NativeFieldInfoPtr_isAutoTrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "isAutoTrain");
		NativeFieldInfoPtr_isAvoidSuperMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "isAvoidSuperMob");
		NativeFieldInfoPtr_minimumMPGoHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "minimumMPGoHome");
		NativeFieldInfoPtr_inputMPPercentGoHome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "inputMPPercentGoHome");
		NativeFieldInfoPtr_listMobIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "listMobIds");
		NativeFieldInfoPtr_lastTimeAddNewMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "lastTimeAddNewMob");
		NativeFieldInfoPtr_lastTimeTeleportToMob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, "lastTimeTeleportToMob");
		NativeMethodInfoPtr_getInstance_Public_Static_AutoTrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665297);
		NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665298);
		NativeMethodInfoPtr_isMeCanAttack_Private_Static_Boolean_Mob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665299);
		NativeMethodInfoPtr_ResetFocus_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665300);
		NativeMethodInfoPtr_DoIt_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665301);
		NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665302);
		NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665303);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665304);
		NativeMethodInfoPtr_UseGrape_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665305);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665306);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr, 100665307);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 69716, RefRangeEnd = 69721, XrefRangeStart = 69702, XrefRangeEnd = 69716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AutoTrain getInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInstance_Public_Static_AutoTrain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoTrain>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69744, RefRangeEnd = 69745, XrefRangeStart = 69721, XrefRangeEnd = 69744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Mob GetNextMob(int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextMob_Private_Static_Mob_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mob>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 38844, RefRangeEnd = 38851, XrefRangeStart = 38844, XrefRangeEnd = 38851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMeCanAttack(Mob mob)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mob);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMeCanAttack_Private_Static_Boolean_Mob_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69757, RefRangeEnd = 69758, XrefRangeStart = 69745, XrefRangeEnd = 69757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetFocus()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetFocus_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69960, RefRangeEnd = 69961, XrefRangeStart = 69758, XrefRangeEnd = 69960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoIt()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoIt_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 70088, RefRangeEnd = 70089, XrefRangeStart = 69961, XrefRangeEnd = 70088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70089, XrefRangeEnd = 70102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TurnOnAutoTrain()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TurnOnAutoTrain_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70102, XrefRangeEnd = 70129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 70142, RefRangeEnd = 70143, XrefRangeStart = 70129, XrefRangeEnd = 70142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseGrape()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseGrape_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 70179, RefRangeEnd = 70181, XrefRangeStart = 70143, XrefRangeEnd = 70179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoTrain()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoTrain>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AutoTrain(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
