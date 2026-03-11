using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Arrowpaint : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_life;

	private static readonly System.IntPtr NativeFieldInfoPtr_ax;

	private static readonly System.IntPtr NativeFieldInfoPtr_ay;

	private static readonly System.IntPtr NativeFieldInfoPtr_axTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_ayTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_avx;

	private static readonly System.IntPtr NativeFieldInfoPtr_avy;

	private static readonly System.IntPtr NativeFieldInfoPtr_adx;

	private static readonly System.IntPtr NativeFieldInfoPtr_ady;

	private static readonly System.IntPtr NativeFieldInfoPtr_charBelong;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgId;

	private static readonly System.IntPtr NativeFieldInfoPtr_FRAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_ARROWINDEX;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANSFORM;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_endMe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findDirIndexFromAngle_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe int life
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_life);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_life)) = num;
		}
	}

	public unsafe int ax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ax)) = num;
		}
	}

	public unsafe int ay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ay)) = num;
		}
	}

	public unsafe int axTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axTo);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_axTo)) = num;
		}
	}

	public unsafe int ayTo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ayTo);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ayTo)) = num;
		}
	}

	public unsafe int avx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avx)) = num;
		}
	}

	public unsafe int avy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_avy)) = num;
		}
	}

	public unsafe int adx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_adx)) = num;
		}
	}

	public unsafe int ady
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ady);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ady)) = num;
		}
	}

	public unsafe Char charBelong
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charBelong);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charBelong)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe Il2CppStructArray<int> imgId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgId);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imgId)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> FRAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FRAME, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FRAME, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> ARROWINDEX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ARROWINDEX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ARROWINDEX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> TRANSFORM
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRANSFORM, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRANSFORM, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static Arrowpaint()
	{
		Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Arrowpaint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "id");
		NativeFieldInfoPtr_life = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "life");
		NativeFieldInfoPtr_ax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "ax");
		NativeFieldInfoPtr_ay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "ay");
		NativeFieldInfoPtr_axTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "axTo");
		NativeFieldInfoPtr_ayTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "ayTo");
		NativeFieldInfoPtr_avx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "avx");
		NativeFieldInfoPtr_avy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "avy");
		NativeFieldInfoPtr_adx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "adx");
		NativeFieldInfoPtr_ady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "ady");
		NativeFieldInfoPtr_charBelong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "charBelong");
		NativeFieldInfoPtr_imgId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "imgId");
		NativeFieldInfoPtr_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "FRAME");
		NativeFieldInfoPtr_ARROWINDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "ARROWINDEX");
		NativeFieldInfoPtr_TRANSFORM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, "TRANSFORM");
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_endMe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_paint_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_findDirIndexFromAngle_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr, 100663350);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140, XrefRangeEnd = 1145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1148, RefRangeEnd = 1149, XrefRangeStart = 1145, XrefRangeEnd = 1148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void endMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_endMe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149, XrefRangeEnd = 1175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Void_mGraphics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1175, XrefRangeEnd = 1184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int findDirIndexFromAngle(int angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findDirIndexFromAngle_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1189, RefRangeEnd = 1190, XrefRangeStart = 1184, XrefRangeEnd = 1189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Arrowpaint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Arrowpaint>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Arrowpaint(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
