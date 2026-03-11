using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class Friend : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_friendName;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string friendName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friendName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_friendName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe sbyte type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = b;
		}
	}

	static Friend()
	{
		Il2CppClassPointerStore<Friend>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Friend");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Friend>.NativeClassPtr);
		NativeFieldInfoPtr_friendName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend>.NativeClassPtr, "friendName");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Friend>.NativeClassPtr, "type");
		NativeMethodInfoPtr__ctor_Public_Void_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100664011);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Friend>.NativeClassPtr, 100664012);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34738, RefRangeEnd = 34739, XrefRangeStart = 34736, XrefRangeEnd = 34738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Friend(string friendName, sbyte type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(friendName);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34739, XrefRangeEnd = 34741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Friend(string friendName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Friend>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(friendName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Friend(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
