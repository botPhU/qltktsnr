using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public class Image : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXTIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_texture;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_filenametemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_datatemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgSrcTemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_xtemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ytemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_wtemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_htemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_transformtemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorBlend;

	private static readonly System.IntPtr NativeMethodInfoPtr_createEmptyImage_Public_Static_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createImage_Public_Static_Image_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createImage_Public_Static_Image_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createImage_Public_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createImage_Public_Static_Image_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createImage_Public_Static_Image_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createImage_Public_Static_Image_Il2CppStructArray_1_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertArrSbyteToArrByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createRGBImage_Public_Static_Image_Il2CppStructArray_1_Int32_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setColorFromRBG_Public_Static_Color_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__createEmptyImage_Private_Static_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__createImage_Private_Static_Image_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__createImage_Private_Static_Image_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__createImage_Private_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__createImage_Private_Static_Image_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadData_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___createImage_Private_Static_Image_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___createImage_Private_Static_Image_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___createImage_Private_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___createEmptyImage_Private_Static_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___createImage_Public_Static_Image_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getImageWidth_Public_Static_Int32_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getImageHeight_Public_Static_Int32_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getWidth_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeight_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTextureQuality_Private_Static_Void_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTextureQuality_Public_Static_Void_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getColor_Public_Il2CppStructArray_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRealImageWidth_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRealImageHeight_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRGB_Public_Void_byref_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static int MAXTIME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXTIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXTIME, (void*)(&num));
		}
	}

	public unsafe Texture2D texture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_texture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture2D));
		}
	}

	public unsafe static Image imgTemp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgTemp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgTemp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static string filenametemp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_filenametemp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_filenametemp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Il2CppStructArray<byte> datatemp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_datatemp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_datatemp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgSrcTemp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgSrcTemp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgSrcTemp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int xtemp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xtemp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xtemp, (void*)(&num));
		}
	}

	public unsafe static int ytemp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ytemp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ytemp, (void*)(&num));
		}
	}

	public unsafe static int wtemp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wtemp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wtemp, (void*)(&num));
		}
	}

	public unsafe static int htemp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_htemp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_htemp, (void*)(&num));
		}
	}

	public unsafe static int transformtemp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_transformtemp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_transformtemp, (void*)(&num));
		}
	}

	public unsafe int w
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w)) = num;
		}
	}

	public unsafe int h
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h)) = num;
		}
	}

	public unsafe static int status
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_status, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_status, (void*)(&num));
		}
	}

	public unsafe Color colorBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorBlend);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_colorBlend)) = color;
		}
	}

	static Image()
	{
		Il2CppClassPointerStore<Image>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Image");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Image>.NativeClassPtr);
		NativeFieldInfoPtr_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "INTERVAL");
		NativeFieldInfoPtr_MAXTIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "MAXTIME");
		NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "texture");
		NativeFieldInfoPtr_imgTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "imgTemp");
		NativeFieldInfoPtr_filenametemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "filenametemp");
		NativeFieldInfoPtr_datatemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "datatemp");
		NativeFieldInfoPtr_imgSrcTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "imgSrcTemp");
		NativeFieldInfoPtr_xtemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "xtemp");
		NativeFieldInfoPtr_ytemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "ytemp");
		NativeFieldInfoPtr_wtemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "wtemp");
		NativeFieldInfoPtr_htemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "htemp");
		NativeFieldInfoPtr_transformtemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "transformtemp");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "w");
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "h");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "status");
		NativeFieldInfoPtr_colorBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Image>.NativeClassPtr, "colorBlend");
		NativeMethodInfoPtr_createEmptyImage_Public_Static_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664394);
		NativeMethodInfoPtr_createImage_Public_Static_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664395);
		NativeMethodInfoPtr_createImage_Public_Static_Image_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664396);
		NativeMethodInfoPtr_createImage_Public_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664397);
		NativeMethodInfoPtr_createImage_Public_Static_Image_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664398);
		NativeMethodInfoPtr_createImage_Public_Static_Image_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664399);
		NativeMethodInfoPtr_createImage_Public_Static_Image_Il2CppStructArray_1_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664400);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664401);
		NativeMethodInfoPtr_convertArrSbyteToArrByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664402);
		NativeMethodInfoPtr_createRGBImage_Public_Static_Image_Il2CppStructArray_1_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664403);
		NativeMethodInfoPtr_setColorFromRBG_Public_Static_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664404);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664405);
		NativeMethodInfoPtr__createEmptyImage_Private_Static_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664406);
		NativeMethodInfoPtr__createImage_Private_Static_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664407);
		NativeMethodInfoPtr__createImage_Private_Static_Image_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664408);
		NativeMethodInfoPtr__createImage_Private_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664409);
		NativeMethodInfoPtr__createImage_Private_Static_Image_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664410);
		NativeMethodInfoPtr_loadData_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664411);
		NativeMethodInfoPtr___createImage_Private_Static_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr___createImage_Private_Static_Image_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr___createImage_Private_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664414);
		NativeMethodInfoPtr___createEmptyImage_Private_Static_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664415);
		NativeMethodInfoPtr___createImage_Public_Static_Image_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664416);
		NativeMethodInfoPtr_getImageWidth_Public_Static_Int32_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664417);
		NativeMethodInfoPtr_getImageHeight_Public_Static_Int32_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_getWidth_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_getHeight_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_setTextureQuality_Private_Static_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_setTextureQuality_Public_Static_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr_getColor_Public_Il2CppStructArray_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664423);
		NativeMethodInfoPtr_getRealImageWidth_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664424);
		NativeMethodInfoPtr_getRealImageHeight_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664425);
		NativeMethodInfoPtr_getRGB_Public_Void_byref_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664426);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Image>.NativeClassPtr, 100664427);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52063, XrefRangeEnd = 52067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createEmptyImage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createEmptyImage_Public_Static_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52068, RefRangeEnd = 52070, XrefRangeStart = 52067, XrefRangeEnd = 52068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createImage(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createImage_Public_Static_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52071, RefRangeEnd = 52072, XrefRangeStart = 52070, XrefRangeEnd = 52071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createImage(Il2CppStructArray<byte> imageData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createImage_Public_Static_Image_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52073, RefRangeEnd = 52074, XrefRangeStart = 52072, XrefRangeEnd = 52073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createImage(Image src, int x, int y, int w, int h, int transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createImage_Public_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52075, RefRangeEnd = 52076, XrefRangeStart = 52074, XrefRangeEnd = 52075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createImage(int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&w);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createImage_Public_Static_Image_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52076, XrefRangeEnd = 52079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createImage(Image img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createImage_Public_Static_Image_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 52083, RefRangeEnd = 52093, XrefRangeStart = 52079, XrefRangeEnd = 52083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createImage(Il2CppStructArray<sbyte> imageData, int offset, int lenght)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lenght;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createImage_Public_Static_Image_Il2CppStructArray_1_SByte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52093, RefRangeEnd = 52094, XrefRangeStart = 52093, XrefRangeEnd = 52093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte convertSbyteToByte(sbyte var)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&var);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52094, XrefRangeEnd = 52098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> convertArrSbyteToArrByte(Il2CppStructArray<sbyte> var)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)var);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertArrSbyteToArrByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 52105, RefRangeEnd = 52112, XrefRangeStart = 52098, XrefRangeEnd = 52105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image createRGBImage(Il2CppStructArray<int> rbg, int w, int h, bool bl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rbg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bl;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createRGBImage_Public_Static_Image_Il2CppStructArray_1_Int32_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static Color setColorFromRBG(int rgb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rgb);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setColorFromRBG_Public_Static_Color_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52140, RefRangeEnd = 52141, XrefRangeStart = 52112, XrefRangeEnd = 52140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52141, XrefRangeEnd = 52154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image _createEmptyImage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__createEmptyImage_Private_Static_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52154, XrefRangeEnd = 52172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image _createImage(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__createImage_Private_Static_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52172, XrefRangeEnd = 52188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image _createImage(Il2CppStructArray<byte> imageData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__createImage_Private_Static_Image_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52188, XrefRangeEnd = 52212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image _createImage(Image src, int x, int y, int w, int h, int transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__createImage_Private_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52212, XrefRangeEnd = 52227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image _createImage(int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&w);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__createImage_Private_Static_Image_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52227, XrefRangeEnd = 52257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> loadData(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadData_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52273, RefRangeEnd = 52275, XrefRangeStart = 52257, XrefRangeEnd = 52273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image __createImage(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___createImage_Private_Static_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 52290, RefRangeEnd = 52294, XrefRangeStart = 52275, XrefRangeEnd = 52290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image __createImage(Il2CppStructArray<byte> imageData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)imageData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___createImage_Private_Static_Image_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52310, RefRangeEnd = 52312, XrefRangeStart = 52294, XrefRangeEnd = 52310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image __createImage(Image src, int x, int y, int w, int h, int transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___createImage_Private_Static_Image_Image_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image __createEmptyImage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___createEmptyImage_Private_Static_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 52326, RefRangeEnd = 52330, XrefRangeStart = 52312, XrefRangeEnd = 52326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image __createImage(int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&w);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___createImage_Public_Static_Image_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52330, XrefRangeEnd = 52334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getImageWidth(Image image)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getImageWidth_Public_Static_Int32_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52334, XrefRangeEnd = 52338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getImageHeight(Image image)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getImageHeight_Public_Static_Int32_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 52342, RefRangeEnd = 52378, XrefRangeStart = 52338, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getWidth_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 52382, RefRangeEnd = 52415, XrefRangeStart = 52378, XrefRangeEnd = 52382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int getHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeight_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52415, XrefRangeEnd = 52420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTextureQuality(Image img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTextureQuality_Private_Static_Void_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52425, RefRangeEnd = 52428, XrefRangeStart = 52420, XrefRangeEnd = 52425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTextureQuality(Texture2D texture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTextureQuality_Public_Static_Void_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52428, XrefRangeEnd = 52430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Color> getColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getColor_Public_Il2CppStructArray_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe int getRealImageWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRealImageWidth_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe int getRealImageHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRealImageHeight_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 52436, RefRangeEnd = 52441, XrefRangeStart = 52430, XrefRangeEnd = 52436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getRGB(ref Il2CppStructArray<int> data, int x1, int x2, int x, int y, int w, int h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x2;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRGB_Public_Void_byref_Il2CppStructArray_1_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<int>(intPtr4));
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 52447, RefRangeEnd = 52455, XrefRangeStart = 52441, XrefRangeEnd = 52447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Image()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Image>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Image(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
