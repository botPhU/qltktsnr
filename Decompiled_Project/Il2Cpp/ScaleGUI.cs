using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class ScaleGUI : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_scaleScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_WIDTH;

	private static readonly System.IntPtr NativeFieldInfoPtr_HEIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_stack;

	private static readonly System.IntPtr NativeMethodInfoPtr_initScaleGUI_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginGUI_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndGUI_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleX_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_scaleY_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool scaleScreen
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scaleScreen, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scaleScreen, (void*)(&flag));
		}
	}

	public unsafe static float WIDTH
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WIDTH, (void*)(&num));
		}
	}

	public unsafe static float HEIGHT
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HEIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HEIGHT, (void*)(&num));
		}
	}

	public unsafe static List<Matrix4x4> stack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stack, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Matrix4x4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stack, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ScaleGUI()
	{
		Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScaleGUI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr);
		NativeFieldInfoPtr_scaleScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, "scaleScreen");
		NativeFieldInfoPtr_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, "WIDTH");
		NativeFieldInfoPtr_HEIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, "HEIGHT");
		NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, "stack");
		NativeMethodInfoPtr_initScaleGUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, 100665776);
		NativeMethodInfoPtr_BeginGUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, 100665777);
		NativeMethodInfoPtr_EndGUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, 100665778);
		NativeMethodInfoPtr_scaleX_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, 100665779);
		NativeMethodInfoPtr_scaleY_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, 100665780);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr, 100665781);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86393, RefRangeEnd = 86394, XrefRangeStart = 86367, XrefRangeEnd = 86393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void initScaleGUI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initScaleGUI_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86394, XrefRangeEnd = 86432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginGUI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginGUI_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86432, XrefRangeEnd = 86450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndGUI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndGUI_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86450, XrefRangeEnd = 86457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float scaleX(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scaleX_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86457, XrefRangeEnd = 86464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float scaleY(float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&y);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_scaleY_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScaleGUI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleGUI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ScaleGUI(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
