using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2Cpp;

public class EffectManager : MyVector
{
	private static readonly IntPtr NativeFieldInfoPtr_lowEffects;

	private static readonly IntPtr NativeFieldInfoPtr_mid_2Effects;

	private static readonly IntPtr NativeFieldInfoPtr_midEffects;

	private static readonly IntPtr NativeFieldInfoPtr_hiEffects;

	private static readonly IntPtr NativeMethodInfoPtr_updateAll_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_paintAll_Public_Void_mGraphics_0;

	private static readonly IntPtr NativeMethodInfoPtr_removeAll_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_remove_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_addHiEffect_Public_Static_Void_Effect_End_0;

	private static readonly IntPtr NativeMethodInfoPtr_addMidEffects_Public_Static_Void_Effect_End_0;

	private static readonly IntPtr NativeMethodInfoPtr_addMid_2Effects_Public_Static_Void_Effect_End_0;

	private static readonly IntPtr NativeMethodInfoPtr_addLowEffect_Public_Static_Void_Effect_End_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static EffectManager lowEffects
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lowEffects, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<EffectManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lowEffects, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectManager));
		}
	}

	public unsafe static EffectManager mid_2Effects
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mid_2Effects, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<EffectManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mid_2Effects, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectManager));
		}
	}

	public unsafe static EffectManager midEffects
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_midEffects, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<EffectManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_midEffects, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectManager));
		}
	}

	public unsafe static EffectManager hiEffects
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hiEffects, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<EffectManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hiEffects, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectManager));
		}
	}

	static EffectManager()
	{
		Il2CppClassPointerStore<EffectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EffectManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectManager>.NativeClassPtr);
		NativeFieldInfoPtr_lowEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, "lowEffects");
		NativeFieldInfoPtr_mid_2Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, "mid_2Effects");
		NativeFieldInfoPtr_midEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, "midEffects");
		NativeFieldInfoPtr_hiEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, "hiEffects");
		NativeMethodInfoPtr_updateAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_paintAll_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_removeAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_remove_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_addHiEffect_Public_Static_Void_Effect_End_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_addMidEffects_Public_Static_Void_Effect_End_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_addMid_2Effects_Public_Static_Void_Effect_End_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_addLowEffect_Public_Static_Void_Effect_End_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectManager>.NativeClassPtr, 100663922);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 33220, RefRangeEnd = 33224, XrefRangeStart = 33214, XrefRangeEnd = 33220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33236, RefRangeEnd = 33237, XrefRangeStart = 33224, XrefRangeEnd = 33236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 33245, RefRangeEnd = 33249, XrefRangeStart = 33237, XrefRangeEnd = 33245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paintAll(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintAll_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 33254, RefRangeEnd = 33258, XrefRangeStart = 33249, XrefRangeEnd = 33254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33271, XrefRangeStart = 33258, XrefRangeEnd = 33270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33277, RefRangeEnd = 33278, XrefRangeStart = 33271, XrefRangeEnd = 33277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addHiEffect(Effect_End eff)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eff);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addHiEffect_Public_Static_Void_Effect_End_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33284, RefRangeEnd = 33285, XrefRangeStart = 33278, XrefRangeEnd = 33284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addMidEffects(Effect_End eff)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eff);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addMidEffects_Public_Static_Void_Effect_End_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33291, RefRangeEnd = 33292, XrefRangeStart = 33285, XrefRangeEnd = 33291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addMid_2Effects(Effect_End eff)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eff);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addMid_2Effects_Public_Static_Void_Effect_End_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 33298, RefRangeEnd = 33299, XrefRangeStart = 33292, XrefRangeEnd = 33298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addLowEffect(Effect_End eff)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eff);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addLowEffect_Public_Static_Void_Effect_End_0, (IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33299, XrefRangeEnd = 33300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EffectManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EffectManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
