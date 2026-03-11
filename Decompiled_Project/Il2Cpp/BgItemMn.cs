using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class BgItemMn : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_blendImage_Public_Static_Image_Image_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getByteArray_Public_Static_Il2CppStructArray_1_Byte_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_blendcurrBg_Public_Static_Void_Int16_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static BgItemMn()
	{
		Il2CppClassPointerStore<BgItemMn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BgItemMn");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BgItemMn>.NativeClassPtr);
		NativeMethodInfoPtr_blendImage_Public_Static_Image_Image_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BgItemMn>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_getByteArray_Public_Static_Il2CppStructArray_1_Byte_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BgItemMn>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_blendcurrBg_Public_Static_Void_Int16_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BgItemMn>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BgItemMn>.NativeClassPtr, 100663453);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7806, RefRangeEnd = 7807, XrefRangeStart = 7700, XrefRangeEnd = 7806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image blendImage(Image img, int layer, int idImage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &idImage;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_blendImage_Public_Static_Image_Image_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7809, RefRangeEnd = 7810, XrefRangeStart = 7807, XrefRangeEnd = 7809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> getByteArray(Image img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getByteArray_Public_Static_Il2CppStructArray_1_Byte_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7874, RefRangeEnd = 7875, XrefRangeStart = 7810, XrefRangeEnd = 7874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void blendcurrBg(short id, Image img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_blendcurrBg_Public_Static_Void_Int16_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BgItemMn()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BgItemMn>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public BgItemMn(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
