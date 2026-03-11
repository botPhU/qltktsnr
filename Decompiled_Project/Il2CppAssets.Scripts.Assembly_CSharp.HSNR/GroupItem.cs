using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.Assembly_CSharp.HSNR;

[StructLayout(LayoutKind.Explicit)]
public struct GroupItem
{
	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_indexUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyGold;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyCoin;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastUse;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_0;

	[FieldOffset(0)]
	public int id;

	[FieldOffset(4)]
	public int indexUI;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool buyGold;

	[FieldOffset(9)]
	[MarshalAs(UnmanagedType.U1)]
	public bool buyCoin;

	[FieldOffset(16)]
	public long lastUse;

	static GroupItem()
	{
		Il2CppClassPointerStore<GroupItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.Assembly_CSharp.HSNR", "GroupItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupItem>.NativeClassPtr);
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupItem>.NativeClassPtr, "id");
		NativeFieldInfoPtr_indexUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupItem>.NativeClassPtr, "indexUI");
		NativeFieldInfoPtr_buyGold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupItem>.NativeClassPtr, "buyGold");
		NativeFieldInfoPtr_buyCoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupItem>.NativeClassPtr, "buyCoin");
		NativeFieldInfoPtr_lastUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupItem>.NativeClassPtr, "lastUse");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupItem>.NativeClassPtr, 100667262);
	}

	[CallerCount(0)]
	public unsafe GroupItem(int id, int indexUI, bool buyGold, bool buyCoin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexUI;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buyGold;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &buyCoin;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GroupItem>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
