using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class InfoDlg : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isShow;

	private static readonly System.IntPtr NativeFieldInfoPtr_title;

	private static readonly System.IntPtr NativeFieldInfoPtr_subtitke;

	private static readonly System.IntPtr NativeFieldInfoPtr_delay;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLock;

	private static readonly System.IntPtr NativeMethodInfoPtr_show_Public_Static_Void_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showWait_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showWait_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hide_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool isShow
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isShow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isShow, (void*)(&flag));
		}
	}

	public unsafe static string title
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_title, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_title, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string subtitke
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_subtitke, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_subtitke, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int delay
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_delay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_delay, (void*)(&num));
		}
	}

	public unsafe static bool isLock
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLock, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLock, (void*)(&flag));
		}
	}

	static InfoDlg()
	{
		Il2CppClassPointerStore<InfoDlg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InfoDlg");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr);
		NativeFieldInfoPtr_isShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, "isShow");
		NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, "title");
		NativeFieldInfoPtr_subtitke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, "subtitke");
		NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, "delay");
		NativeFieldInfoPtr_isLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, "isLock");
		NativeMethodInfoPtr_show_Public_Static_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, 100664457);
		NativeMethodInfoPtr_showWait_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, 100664458);
		NativeMethodInfoPtr_showWait_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, 100664459);
		NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, 100664460);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, 100664461);
		NativeMethodInfoPtr_hide_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, 100664462);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr, 100664463);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52902, RefRangeEnd = 52903, XrefRangeStart = 52893, XrefRangeEnd = 52902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void show(string title, string subtitle, int delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(subtitle);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_show_Public_Static_Void_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showWait()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showWait_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showWait(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showWait_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52924, RefRangeEnd = 52925, XrefRangeStart = 52903, XrefRangeEnd = 52924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paint(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paint_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52940, RefRangeEnd = 52941, XrefRangeStart = 52925, XrefRangeEnd = 52940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 52953, RefRangeEnd = 52981, XrefRangeStart = 52941, XrefRangeEnd = 52953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void hide()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hide_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfoDlg()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfoDlg>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InfoDlg(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
