using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class FrameImage : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_frameWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_nFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_numWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_numHeight;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Image_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Image_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_drawFrame_Public_Void_Int32_Int32_Int32_Int32_Int32_mGraphics_0;

	public unsafe int frameWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameWidth)) = num;
		}
	}

	public unsafe int frameHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameHeight)) = num;
		}
	}

	public unsafe int nFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nFrame)) = num;
		}
	}

	public unsafe Image imgFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgFrame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgFrame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe int Id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Id)) = num;
		}
	}

	public unsafe int numWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numWidth)) = num;
		}
	}

	public unsafe int numHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numHeight)) = num;
		}
	}

	static FrameImage()
	{
		Il2CppClassPointerStore<FrameImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FrameImage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameImage>.NativeClassPtr);
		NativeFieldInfoPtr_frameWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, "frameWidth");
		NativeFieldInfoPtr_frameHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, "frameHeight");
		NativeFieldInfoPtr_nFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, "nFrame");
		NativeFieldInfoPtr_imgFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, "imgFrame");
		NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, "Id");
		NativeFieldInfoPtr_numWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, "numWidth");
		NativeFieldInfoPtr_numHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, "numHeight");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr__ctor_Public_Void_Image_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr__ctor_Public_Void_Image_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, 100664009);
		NativeMethodInfoPtr_drawFrame_Public_Void_Int32_Int32_Int32_Int32_Int32_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameImage>.NativeClassPtr, 100664010);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 34663, RefRangeEnd = 34668, XrefRangeStart = 34652, XrefRangeEnd = 34663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FrameImage(int ID)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameImage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 34671, RefRangeEnd = 34681, XrefRangeStart = 34668, XrefRangeEnd = 34671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FrameImage(Image img, int width, int height)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameImage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Image_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34681, XrefRangeEnd = 34685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FrameImage(Image img, int numW, int numH, int numNull)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameImage>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numW;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numH;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numNull;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Image_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 34687, RefRangeEnd = 34736, XrefRangeStart = 34685, XrefRangeEnd = 34687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void drawFrame(int idx, int x, int y, int trans, int anchor, mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&idx);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &trans;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &anchor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawFrame_Public_Void_Int32_Int32_Int32_Int32_Int32_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FrameImage(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
