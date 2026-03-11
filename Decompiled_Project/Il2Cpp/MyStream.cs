using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class MyStream : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_readFile_Public_Static_DataInputStream_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static MyStream()
	{
		Il2CppClassPointerStore<MyStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyStream>.NativeClassPtr);
		NativeMethodInfoPtr_readFile_Public_Static_DataInputStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyStream>.NativeClassPtr, 100665173);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyStream>.NativeClassPtr, 100665174);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 67380, RefRangeEnd = 67389, XrefRangeStart = 67373, XrefRangeEnd = 67380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DataInputStream readFile(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readFile_Public_Static_DataInputStream_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataInputStream>(intPtr) : null;
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyStream()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyStream>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MyStream(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
