using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2Cpp;

public class InputStream : myReader
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	static InputStream()
	{
		Il2CppClassPointerStore<InputStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InputStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputStream>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStream>.NativeClassPtr, 100664499);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStream>.NativeClassPtr, 100664500);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputStream>.NativeClassPtr, 100664501);
	}

	[CallerCount(60)]
	[CachedScanResults(RefRangeStart = 53669, RefRangeEnd = 53729, XrefRangeStart = 53640, XrefRangeEnd = 53669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputStream()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputStream>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53731, RefRangeEnd = 53733, XrefRangeStart = 53729, XrefRangeEnd = 53731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputStream(Il2CppStructArray<sbyte> data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputStream>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53733, XrefRangeEnd = 53734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputStream(string filename)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputStream>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InputStream(IntPtr pointer)
		: base(pointer)
	{
	}
}
