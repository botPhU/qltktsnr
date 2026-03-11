using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppAssets.src.f;

public class Controller2 : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_readMessage_Public_Static_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readLuckyRound_Private_Static_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readInfoRada_Private_Static_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readInfoEffChar_Private_Static_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readActionBoss_Private_Static_Void_Message_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Controller2()
	{
		Il2CppClassPointerStore<Controller2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.src.f", "Controller2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller2>.NativeClassPtr);
		NativeMethodInfoPtr_readMessage_Public_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller2>.NativeClassPtr, 100666808);
		NativeMethodInfoPtr_readLuckyRound_Private_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller2>.NativeClassPtr, 100666809);
		NativeMethodInfoPtr_readInfoRada_Private_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller2>.NativeClassPtr, 100666810);
		NativeMethodInfoPtr_readInfoEffChar_Private_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller2>.NativeClassPtr, 100666811);
		NativeMethodInfoPtr_readActionBoss_Private_Static_Void_Message_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller2>.NativeClassPtr, 100666812);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller2>.NativeClassPtr, 100666813);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121767, RefRangeEnd = 121768, XrefRangeStart = 120436, XrefRangeEnd = 121767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void readMessage(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readMessage_Public_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121809, RefRangeEnd = 121810, XrefRangeStart = 121768, XrefRangeEnd = 121809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void readLuckyRound(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readLuckyRound_Private_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121947, RefRangeEnd = 121948, XrefRangeStart = 121810, XrefRangeEnd = 121947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void readInfoRada(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readInfoRada_Private_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 121979, RefRangeEnd = 121980, XrefRangeStart = 121948, XrefRangeEnd = 121979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void readInfoEffChar(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readInfoEffChar_Private_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 122025, RefRangeEnd = 122026, XrefRangeStart = 121980, XrefRangeEnd = 122025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void readActionBoss(Message msg, int actionBoss)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &actionBoss;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readActionBoss_Private_Static_Void_Message_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Controller2()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller2>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Controller2(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
