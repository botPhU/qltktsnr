using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2CppNQMP;

public class ClickHandler : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_MenuSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdX;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdY;

	private static readonly System.IntPtr NativeMethodInfoPtr_size_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ArrayList a
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arrayList));
		}
	}

	public unsafe static int MenuSelected
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MenuSelected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MenuSelected, (void*)(&num));
		}
	}

	public unsafe static int cmdX
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdX, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdX, (void*)(&num));
		}
	}

	public unsafe static int cmdY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cmdY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cmdY, (void*)(&num));
		}
	}

	static ClickHandler()
	{
		Il2CppClassPointerStore<ClickHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NQMP", "ClickHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr);
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr, "a");
		NativeFieldInfoPtr_MenuSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr, "MenuSelected");
		NativeFieldInfoPtr_cmdX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr, "cmdX");
		NativeFieldInfoPtr_cmdY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr, "cmdY");
		NativeMethodInfoPtr_size_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr, 100666609);
		NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr, 100666610);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr, 100666611);
	}

	[CallerCount(393)]
	[CachedScanResults(RefRangeStart = 67583, RefRangeEnd = 67976, XrefRangeStart = 67583, XrefRangeEnd = 67976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int size()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_size_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115812, RefRangeEnd = 115813, XrefRangeStart = 115384, XrefRangeEnd = 115812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paint(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClickHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClickHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ClickHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
