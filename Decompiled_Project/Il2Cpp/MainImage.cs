using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class MainImage : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_img;

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeImageNull;

	private static readonly System.IntPtr NativeFieldInfoPtr_idImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_timerequest;

	private static readonly System.IntPtr NativeFieldInfoPtr_nFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeUse;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Image_SByte_0;

	public unsafe Image img
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_img)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe long count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
		}
	}

	public unsafe int timeImageNull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeImageNull);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeImageNull)) = num;
		}
	}

	public unsafe int idImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idImage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idImage)) = num;
		}
	}

	public unsafe long timerequest
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerequest);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerequest)) = num;
		}
	}

	public unsafe sbyte nFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame);
			return *(sbyte*)num;
		}
		set
		{
			*(sbyte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame)) = b;
		}
	}

	public unsafe long timeUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeUse);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeUse)) = num;
		}
	}

	static MainImage()
	{
		Il2CppClassPointerStore<MainImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MainImage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainImage>.NativeClassPtr);
		NativeFieldInfoPtr_img = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainImage>.NativeClassPtr, "img");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainImage>.NativeClassPtr, "count");
		NativeFieldInfoPtr_timeImageNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainImage>.NativeClassPtr, "timeImageNull");
		NativeFieldInfoPtr_idImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainImage>.NativeClassPtr, "idImage");
		NativeFieldInfoPtr_timerequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainImage>.NativeClassPtr, "timerequest");
		NativeFieldInfoPtr_nFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainImage>.NativeClassPtr, "nFrame");
		NativeFieldInfoPtr_timeUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainImage>.NativeClassPtr, "timeUse");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainImage>.NativeClassPtr, 100664687);
		NativeMethodInfoPtr__ctor_Public_Void_Image_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainImage>.NativeClassPtr, 100664688);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56636, RefRangeEnd = 56638, XrefRangeStart = 56631, XrefRangeEnd = 56636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MainImage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainImage>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56644, RefRangeEnd = 56645, XrefRangeStart = 56638, XrefRangeEnd = 56644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MainImage(Image im, sbyte nFrame)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainImage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)im);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Image_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MainImage(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
