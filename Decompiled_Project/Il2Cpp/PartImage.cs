using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class PartImage : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_dx;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe short id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe sbyte dx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx)) = b;
		}
	}

	public unsafe sbyte dy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy)) = b;
		}
	}

	static PartImage()
	{
		Il2CppClassPointerStore<PartImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PartImage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartImage>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartImage>.NativeClassPtr, "id");
		NativeFieldInfoPtr_dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartImage>.NativeClassPtr, "dx");
		NativeFieldInfoPtr_dy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartImage>.NativeClassPtr, "dy");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartImage>.NativeClassPtr, 100665635);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PartImage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartImage>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PartImage(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
