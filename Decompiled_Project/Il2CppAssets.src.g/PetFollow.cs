using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.src.g;

public class PetFollow : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_smallID;

	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeFieldInfoPtr_dir;

	private static readonly System.IntPtr NativeFieldInfoPtr_f;

	private static readonly System.IntPtr NativeFieldInfoPtr_tF;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoY;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvy;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmyLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmtoX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmvx;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmxLim;

	private static readonly System.IntPtr NativeFieldInfoPtr_fimg;

	private static readonly System.IntPtr NativeFieldInfoPtr_wimg;

	private static readonly System.IntPtr NativeFieldInfoPtr_himg;

	private static readonly System.IntPtr NativeFieldInfoPtr_frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetImg_Public_Void_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_moveCamera_Public_Void_0;

	public unsafe short smallID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallID);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallID)) = num;
		}
	}

	public unsafe Info info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Info>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info));
		}
	}

	public unsafe int dir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dir)) = num;
		}
	}

	public unsafe int f
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f)) = num;
		}
	}

	public unsafe int tF
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tF);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tF)) = num;
		}
	}

	public unsafe int cmtoY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoY);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoY)) = num;
		}
	}

	public unsafe int cmy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmy)) = num;
		}
	}

	public unsafe int cmdy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdy)) = num;
		}
	}

	public unsafe int cmvy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvy)) = num;
		}
	}

	public unsafe int cmyLim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyLim);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmyLim)) = num;
		}
	}

	public unsafe int cmtoX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoX);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmtoX)) = num;
		}
	}

	public unsafe int cmx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmx)) = num;
		}
	}

	public unsafe int cmdx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdx)) = num;
		}
	}

	public unsafe int cmvx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmvx)) = num;
		}
	}

	public unsafe int cmxLim
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxLim);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmxLim)) = num;
		}
	}

	public unsafe int fimg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fimg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fimg)) = num;
		}
	}

	public unsafe int wimg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wimg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wimg)) = num;
		}
	}

	public unsafe int himg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_himg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_himg)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> frame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frame)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int count
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = num;
		}
	}

	static PetFollow()
	{
		Il2CppClassPointerStore<PetFollow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.src.g", "PetFollow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PetFollow>.NativeClassPtr);
		NativeFieldInfoPtr_smallID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "smallID");
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "info");
		NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "dir");
		NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "f");
		NativeFieldInfoPtr_tF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "tF");
		NativeFieldInfoPtr_cmtoY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmtoY");
		NativeFieldInfoPtr_cmy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmy");
		NativeFieldInfoPtr_cmdy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmdy");
		NativeFieldInfoPtr_cmvy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmvy");
		NativeFieldInfoPtr_cmyLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmyLim");
		NativeFieldInfoPtr_cmtoX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmtoX");
		NativeFieldInfoPtr_cmx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmx");
		NativeFieldInfoPtr_cmdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmdx");
		NativeFieldInfoPtr_cmvx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmvx");
		NativeFieldInfoPtr_cmxLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "cmxLim");
		NativeFieldInfoPtr_fimg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "fimg");
		NativeFieldInfoPtr_wimg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "wimg");
		NativeFieldInfoPtr_himg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "himg");
		NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "frame");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, "count");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, 100666776);
		NativeMethodInfoPtr_SetImg_Public_Void_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, 100666777);
		NativeMethodInfoPtr_paint_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, 100666778);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, 100666779);
		NativeMethodInfoPtr_remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, 100666780);
		NativeMethodInfoPtr_moveCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PetFollow>.NativeClassPtr, 100666781);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119466, RefRangeEnd = 119468, XrefRangeStart = 119449, XrefRangeEnd = 119466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PetFollow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PetFollow>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119469, RefRangeEnd = 119470, XrefRangeStart = 119468, XrefRangeEnd = 119469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetImg(int fimg, Il2CppStructArray<int> frameNew, int wimg, int himg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&fimg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameNew);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &wimg;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &himg;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetImg_Public_Void_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119482, RefRangeEnd = 119483, XrefRangeStart = 119470, XrefRangeEnd = 119482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119487, RefRangeEnd = 119488, XrefRangeStart = 119483, XrefRangeEnd = 119487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119493, RefRangeEnd = 119495, XrefRangeStart = 119488, XrefRangeEnd = 119493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void moveCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_moveCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public PetFollow(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
