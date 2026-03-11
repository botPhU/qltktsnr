using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class ImgByName : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hashImagePath;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetImage_Public_Static_Void_String_Image_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getImagePath_Public_Static_MainImage_String_MyHashTable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFromRms_Public_Static_MainImage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRMS_Public_Static_Void_String_SByte_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkDelHash_Public_Static_Void_MyHashTable_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static MyHashTable hashImagePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hashImagePath, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyHashTable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hashImagePath, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myHashTable));
		}
	}

	static ImgByName()
	{
		Il2CppClassPointerStore<ImgByName>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ImgByName");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImgByName>.NativeClassPtr);
		NativeFieldInfoPtr_hashImagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImgByName>.NativeClassPtr, "hashImagePath");
		NativeMethodInfoPtr_SetImage_Public_Static_Void_String_Image_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImgByName>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr_getImagePath_Public_Static_MainImage_String_MyHashTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImgByName>.NativeClassPtr, 100664440);
		NativeMethodInfoPtr_getFromRms_Public_Static_MainImage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImgByName>.NativeClassPtr, 100664441);
		NativeMethodInfoPtr_saveRMS_Public_Static_Void_String_SByte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImgByName>.NativeClassPtr, 100664442);
		NativeMethodInfoPtr_checkDelHash_Public_Static_Void_MyHashTable_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImgByName>.NativeClassPtr, 100664443);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImgByName>.NativeClassPtr, 100664444);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52476, RefRangeEnd = 52477, XrefRangeStart = 52455, XrefRangeEnd = 52476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetImage(string name, Image img, sbyte nFrame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		*(sbyte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetImage_Public_Static_Void_String_Image_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52503, RefRangeEnd = 52505, XrefRangeStart = 52477, XrefRangeEnd = 52503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MainImage getImagePath(string nameImg, MyHashTable hash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(nameImg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hash);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getImagePath_Public_Static_MainImage_String_MyHashTable_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MainImage>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52531, RefRangeEnd = 52532, XrefRangeStart = 52505, XrefRangeEnd = 52531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MainImage getFromRms(string nameImg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(nameImg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFromRms_Public_Static_MainImage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MainImage>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52565, RefRangeEnd = 52566, XrefRangeStart = 52532, XrefRangeEnd = 52565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveRMS(string nameImg, sbyte nFrame, Il2CppStructArray<sbyte> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(nameImg);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nFrame;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRMS_Public_Static_Void_String_SByte_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52600, RefRangeEnd = 52602, XrefRangeStart = 52566, XrefRangeEnd = 52600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void checkDelHash(MyHashTable hash, int minute, bool isTrue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hash);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minute;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTrue;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkDelHash_Public_Static_Void_MyHashTable_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ImgByName()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImgByName>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ImgByName(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
