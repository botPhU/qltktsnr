using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class TextInfo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dx;

	private static readonly System.IntPtr NativeFieldInfoPtr_tx;

	private static readonly System.IntPtr NativeFieldInfoPtr_wStr;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_laststring;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_String_Int32_Int32_Int32_Int32_mFont_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int dx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dx, (void*)(&num));
		}
	}

	public unsafe static int tx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tx, (void*)(&num));
		}
	}

	public unsafe static int wStr
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wStr, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wStr, (void*)(&num));
		}
	}

	public unsafe static bool isBack
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isBack, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isBack, (void*)(&flag));
		}
	}

	public unsafe static string laststring
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_laststring, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_laststring, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static TextInfo()
	{
		Il2CppClassPointerStore<TextInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TextInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInfo>.NativeClassPtr);
		NativeFieldInfoPtr_dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "dx");
		NativeFieldInfoPtr_tx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "tx");
		NativeFieldInfoPtr_wStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "wStr");
		NativeFieldInfoPtr_isBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "isBack");
		NativeFieldInfoPtr_laststring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, "laststring");
		NativeMethodInfoPtr_reset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_String_Int32_Int32_Int32_Int32_mFont_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInfo>.NativeClassPtr, 100666343);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 108871, RefRangeEnd = 108872, XrefRangeStart = 108865, XrefRangeEnd = 108871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void reset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 108926, RefRangeEnd = 108929, XrefRangeStart = 108872, XrefRangeEnd = 108926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paint(mGraphics g, string str, int x, int y, int w, int h, mFont f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(str);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)f);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_String_Int32_Int32_Int32_Int32_mFont_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TextInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
