using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class PKFlag : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cflag;

	private static readonly System.IntPtr NativeFieldInfoPtr_IDimageFlag;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe sbyte cflag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cflag);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cflag)) = b;
		}
	}

	public unsafe int IDimageFlag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IDimageFlag);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IDimageFlag)) = num;
		}
	}

	static PKFlag()
	{
		Il2CppClassPointerStore<PKFlag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PKFlag");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKFlag>.NativeClassPtr);
		NativeFieldInfoPtr_cflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKFlag>.NativeClassPtr, "cflag");
		NativeFieldInfoPtr_IDimageFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKFlag>.NativeClassPtr, "IDimageFlag");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKFlag>.NativeClassPtr, 100665647);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PKFlag()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKFlag>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PKFlag(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
