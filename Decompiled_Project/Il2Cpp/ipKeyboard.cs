using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public class ipKeyboard : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tk;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT;

	private static readonly System.IntPtr NativeFieldInfoPtr_NUMBERIC;

	private static readonly System.IntPtr NativeFieldInfoPtr_PASS;

	private static readonly System.IntPtr NativeFieldInfoPtr_act;

	private static readonly System.IntPtr NativeMethodInfoPtr_openKeyBoard_Public_Static_Void_String_Int32_String_Command_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static UnityEngine.TouchScreenKeyboard tk
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tk, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.TouchScreenKeyboard>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tk, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)touchScreenKeyboard));
		}
	}

	public unsafe static int TEXT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT, (void*)(&num));
		}
	}

	public unsafe static int NUMBERIC
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NUMBERIC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NUMBERIC, (void*)(&num));
		}
	}

	public unsafe static int PASS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PASS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PASS, (void*)(&num));
		}
	}

	public unsafe static Command act
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_act, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_act, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	static ipKeyboard()
	{
		Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ipKeyboard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr);
		NativeFieldInfoPtr_tk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, "tk");
		NativeFieldInfoPtr_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, "TEXT");
		NativeFieldInfoPtr_NUMBERIC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, "NUMBERIC");
		NativeFieldInfoPtr_PASS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, "PASS");
		NativeFieldInfoPtr_act = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, "act");
		NativeMethodInfoPtr_openKeyBoard_Public_Static_Void_String_Int32_String_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, 100664539);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, 100664540);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr, 100664541);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53750, RefRangeEnd = 53752, XrefRangeStart = 53736, XrefRangeEnd = 53750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void openKeyBoard(string caption, int type, string text, Command action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(caption);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openKeyBoard_Public_Static_Void_String_Int32_String_Command_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53776, RefRangeEnd = 53777, XrefRangeStart = 53752, XrefRangeEnd = 53776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ipKeyboard()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ipKeyboard>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ipKeyboard(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
