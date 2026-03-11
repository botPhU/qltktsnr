using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class SkillOption : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_param;

	private static readonly System.IntPtr NativeFieldInfoPtr_optionTemplate;

	private static readonly System.IntPtr NativeFieldInfoPtr_optionString;

	private static readonly System.IntPtr NativeMethodInfoPtr_getOptionString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int param
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param)) = num;
		}
	}

	public unsafe SkillOptionTemplate optionTemplate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionTemplate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillOptionTemplate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionTemplate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skillOptionTemplate));
		}
	}

	public unsafe string optionString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionString)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static SkillOption()
	{
		Il2CppClassPointerStore<SkillOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SkillOption");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillOption>.NativeClassPtr);
		NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillOption>.NativeClassPtr, "param");
		NativeFieldInfoPtr_optionTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillOption>.NativeClassPtr, "optionTemplate");
		NativeFieldInfoPtr_optionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillOption>.NativeClassPtr, "optionString");
		NativeMethodInfoPtr_getOptionString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillOption>.NativeClassPtr, 100666161);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillOption>.NativeClassPtr, 100666162);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95931, XrefRangeEnd = 95939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getOptionString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getOptionString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkillOption()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillOption>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SkillOption(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
