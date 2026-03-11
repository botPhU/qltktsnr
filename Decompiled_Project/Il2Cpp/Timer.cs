using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Timer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_timeListener;

	private static readonly System.IntPtr NativeFieldInfoPtr_idAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeExecute;

	private static readonly System.IntPtr NativeFieldInfoPtr_isON;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTimer_Public_Static_Void_IActionListener_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static IActionListener timeListener
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeListener, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IActionListener>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeListener, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionListener));
		}
	}

	public unsafe static int idAction
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idAction, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idAction, (void*)(&num));
		}
	}

	public unsafe static long timeExecute
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeExecute, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeExecute, (void*)(&num));
		}
	}

	public unsafe static bool isON
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isON, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isON, (void*)(&flag));
		}
	}

	static Timer()
	{
		Il2CppClassPointerStore<Timer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Timer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer>.NativeClassPtr);
		NativeFieldInfoPtr_timeListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "timeListener");
		NativeFieldInfoPtr_idAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "idAction");
		NativeFieldInfoPtr_timeExecute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "timeExecute");
		NativeFieldInfoPtr_isON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "isON");
		NativeMethodInfoPtr_setTimer_Public_Static_Void_IActionListener_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100666434);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100666435);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100666436);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112388, XrefRangeEnd = 112399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTimer(IActionListener actionListener, int action, long timeEllapse)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actionListener);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &action;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeEllapse;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTimer_Public_Static_Void_IActionListener_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112413, RefRangeEnd = 112414, XrefRangeStart = 112399, XrefRangeEnd = 112413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Timer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Timer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
