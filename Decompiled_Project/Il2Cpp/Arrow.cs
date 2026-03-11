using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Arrow : Il2CppSystem.Object
{
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

	private static readonly System.IntPtr NativeFieldInfoPtr_arrp;

	private static readonly System.IntPtr NativeFieldInfoPtr_FRAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_ARROWINDEX;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRANSFORM;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Arrowpaint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_endMe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findDirIndexFromAngle_Public_Static_Int32_Int32_0;

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

	public unsafe Arrowpaint arrp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrp);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Arrowpaint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrp)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arrowpaint));
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

	static Arrow()
	{
		Il2CppClassPointerStore<Arrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Arrow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Arrow>.NativeClassPtr);
		NativeFieldInfoPtr_life = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "life");
		NativeFieldInfoPtr_ax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "ax");
		NativeFieldInfoPtr_ay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "ay");
		NativeFieldInfoPtr_axTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "axTo");
		NativeFieldInfoPtr_ayTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "ayTo");
		NativeFieldInfoPtr_avx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "avx");
		NativeFieldInfoPtr_avy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "avy");
		NativeFieldInfoPtr_adx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "adx");
		NativeFieldInfoPtr_ady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "ady");
		NativeFieldInfoPtr_charBelong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "charBelong");
		NativeFieldInfoPtr_arrp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "arrp");
		NativeFieldInfoPtr_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "FRAME");
		NativeFieldInfoPtr_ARROWINDEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "ARROWINDEX");
		NativeFieldInfoPtr_TRANSFORM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Arrow>.NativeClassPtr, "TRANSFORM");
		NativeMethodInfoPtr__ctor_Public_Void_Char_Arrowpaint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrow>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrow>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_endMe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrow>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_paint_Public_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrow>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_findDirIndexFromAngle_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Arrow>.NativeClassPtr, 100663344);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1093, RefRangeEnd = 1094, XrefRangeStart = 1090, XrefRangeEnd = 1093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Arrow(Char charBelong, Arrowpaint arrp)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Arrow>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charBelong);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arrp);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Char_Arrowpaint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1099, RefRangeEnd = 1100, XrefRangeStart = 1094, XrefRangeEnd = 1099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103, RefRangeEnd = 1104, XrefRangeStart = 1100, XrefRangeEnd = 1103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void endMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_endMe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1130, RefRangeEnd = 1131, XrefRangeStart = 1104, XrefRangeEnd = 1130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1131, XrefRangeEnd = 1140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int findDirIndexFromAngle(int angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findDirIndexFromAngle_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	public Arrow(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
