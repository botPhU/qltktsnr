using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class NinjaUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_onLoadMapComplete_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onLoading_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_randomNumber_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readByteArray_Public_Static_Il2CppStructArray_1_SByte_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readByteArray_Public_Static_Il2CppStructArray_1_SByte_myReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_replace_Public_Static_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_numberTostring_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDate_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDate2_Public_Static_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTime_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMoneys_Public_Static_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTimeAgo_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_split_Public_Static_Il2CppStringArray_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static NinjaUtil()
	{
		Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NinjaUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr);
		NativeMethodInfoPtr_onLoadMapComplete_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665273);
		NativeMethodInfoPtr_onLoading_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665274);
		NativeMethodInfoPtr_randomNumber_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665275);
		NativeMethodInfoPtr_readByteArray_Public_Static_Il2CppStructArray_1_SByte_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665276);
		NativeMethodInfoPtr_readByteArray_Public_Static_Il2CppStructArray_1_SByte_myReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665277);
		NativeMethodInfoPtr_replace_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665278);
		NativeMethodInfoPtr_numberTostring_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665279);
		NativeMethodInfoPtr_getDate_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665280);
		NativeMethodInfoPtr_getDate2_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665281);
		NativeMethodInfoPtr_getTime_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665282);
		NativeMethodInfoPtr_getMoneys_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665283);
		NativeMethodInfoPtr_getTimeAgo_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665284);
		NativeMethodInfoPtr_split_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665285);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr, 100665286);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69040, XrefRangeEnd = 69044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onLoadMapComplete()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onLoadMapComplete_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69044, XrefRangeEnd = 69052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void onLoading()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onLoading_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69058, RefRangeEnd = 69059, XrefRangeStart = 69052, XrefRangeEnd = 69058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int randomNumber(int max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&max);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_randomNumber_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 69064, RefRangeEnd = 69071, XrefRangeStart = 69059, XrefRangeEnd = 69064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> readByteArray(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readByteArray_Public_Static_Il2CppStructArray_1_SByte_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 69076, RefRangeEnd = 69082, XrefRangeStart = 69071, XrefRangeEnd = 69076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> readByteArray(myReader dos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readByteArray_Public_Static_Il2CppStructArray_1_SByte_myReader_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 69084, RefRangeEnd = 69093, XrefRangeStart = 69082, XrefRangeEnd = 69084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string replace(string text, string regex, string replacement)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(regex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(replacement);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_replace_Public_Static_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 69115, RefRangeEnd = 69117, XrefRangeStart = 69093, XrefRangeEnd = 69115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string numberTostring(string number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(number);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_numberTostring_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69151, RefRangeEnd = 69152, XrefRangeStart = 69117, XrefRangeEnd = 69151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getDate(int second)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&second);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDate_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69167, RefRangeEnd = 69168, XrefRangeStart = 69152, XrefRangeEnd = 69167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getDate2(long second)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&second);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDate2_Public_Static_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 69186, RefRangeEnd = 69190, XrefRangeStart = 69168, XrefRangeEnd = 69186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getTime(int timeRemainS)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeRemainS);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTime_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 69210, RefRangeEnd = 69259, XrefRangeStart = 69190, XrefRangeEnd = 69210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getMoneys(long m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMoneys_Public_Static_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 69269, RefRangeEnd = 69271, XrefRangeStart = 69259, XrefRangeEnd = 69269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getTimeAgo(int timeRemainS)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeRemainS);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTimeAgo_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69271, XrefRangeEnd = 69294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray split(string original, string separator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(original);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(separator);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_split_Public_Static_Il2CppStringArray_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NinjaUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NinjaUtil>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NinjaUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
