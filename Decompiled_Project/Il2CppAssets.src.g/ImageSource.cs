using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.src.g;

public class ImageSource : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_vSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_vRms;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkRMS_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getVersionRMSByID_Public_Static_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCurrVersionByID_Public_Static_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isExistID_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRMS_Public_Static_Void_0;

	public unsafe sbyte version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)) = b;
		}
	}

	public unsafe string id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static MyVector vSource
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vSource, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vSource, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vRms
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vRms, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vRms, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	static ImageSource()
	{
		Il2CppClassPointerStore<ImageSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.src.g", "ImageSource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageSource>.NativeClassPtr);
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "version");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "id");
		NativeFieldInfoPtr_vSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "vSource");
		NativeFieldInfoPtr_vRms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, "vRms");
		NativeMethodInfoPtr__ctor_Public_Void_String_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, 100666760);
		NativeMethodInfoPtr_checkRMS_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, 100666761);
		NativeMethodInfoPtr_getVersionRMSByID_Public_Static_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, 100666762);
		NativeMethodInfoPtr_getCurrVersionByID_Public_Static_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, 100666763);
		NativeMethodInfoPtr_isExistID_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, 100666764);
		NativeMethodInfoPtr_saveRMS_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSource>.NativeClassPtr, 100666765);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119145, XrefRangeEnd = 119147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImageSource(string ID, sbyte version)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSource>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &version;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119209, RefRangeEnd = 119210, XrefRangeStart = 119147, XrefRangeEnd = 119209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void checkRMS()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkRMS_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119210, XrefRangeEnd = 119227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte getVersionRMSByID(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getVersionRMSByID_Public_Static_SByte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119227, XrefRangeEnd = 119244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte getCurrVersionByID(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCurrVersionByID_Public_Static_SByte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119244, XrefRangeEnd = 119256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isExistID(string id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isExistID_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119287, RefRangeEnd = 119288, XrefRangeStart = 119256, XrefRangeEnd = 119287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveRMS()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRMS_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ImageSource(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
