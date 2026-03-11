using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp;

public class MyKeyMap : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeMethodInfoPtr_map_Public_Static_Int32_KeyCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Hashtable h
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_h, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_h, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashtable));
		}
	}

	static MyKeyMap()
	{
		Il2CppClassPointerStore<MyKeyMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyKeyMap");
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyKeyMap>.NativeClassPtr, "h");
		NativeMethodInfoPtr_map_Public_Static_Int32_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyKeyMap>.NativeClassPtr, 100665134);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyKeyMap>.NativeClassPtr, 100665135);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 66366, RefRangeEnd = 66368, XrefRangeStart = 66356, XrefRangeEnd = 66366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int map(KeyCode k)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&k);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_map_Public_Static_Int32_KeyCode_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyKeyMap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyKeyMap>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MyKeyMap(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
