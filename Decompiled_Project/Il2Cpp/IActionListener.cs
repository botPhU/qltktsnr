using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class IActionListener : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Abstract_Virtual_New_Void_Int32_Object_0;

	static IActionListener()
	{
		Il2CppClassPointerStore<IActionListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IActionListener");
		NativeMethodInfoPtr_perform_Public_Abstract_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IActionListener>.NativeClassPtr, 100664390);
	}

	[CallerCount(0)]
	public unsafe virtual void perform(int idAction, Il2CppSystem.Object p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_perform_Public_Abstract_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public IActionListener(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
