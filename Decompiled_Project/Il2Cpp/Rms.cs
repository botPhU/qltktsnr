using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Rms : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_data;

	private static readonly System.IntPtr NativeFieldInfoPtr_filename;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXTIME;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRMS_Public_Static_Void_String_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadRMS_Public_Static_Il2CppStructArray_1_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadRMSString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRMSString_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__saveRMS_Private_Static_Void_String_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__loadRMS_Private_Static_Il2CppStructArray_1_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadRMSInt_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRMSInt_Public_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadRMSLong_Public_Static_Int64_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveRMSLong_Public_Static_Void_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetiPhoneDocumentsPath_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToHex_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___saveRMS_Private_Static_Void_String_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___loadRMS_Private_Static_Il2CppStructArray_1_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearAll_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteStorage_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ByteArrayToString_Public_Static_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_deleteRecord_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearRMS_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveIP_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadIP_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int status
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_status, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_status, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> data
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_data, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_data, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string filename
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_filename, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_filename, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int INTERVAL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INTERVAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INTERVAL, (void*)(&num));
		}
	}

	public unsafe static int MAXTIME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAXTIME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAXTIME, (void*)(&num));
		}
	}

	static Rms()
	{
		Il2CppClassPointerStore<Rms>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Rms");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rms>.NativeClassPtr);
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rms>.NativeClassPtr, "status");
		NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rms>.NativeClassPtr, "data");
		NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rms>.NativeClassPtr, "filename");
		NativeFieldInfoPtr_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rms>.NativeClassPtr, "INTERVAL");
		NativeFieldInfoPtr_MAXTIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rms>.NativeClassPtr, "MAXTIME");
		NativeMethodInfoPtr_saveRMS_Public_Static_Void_String_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665751);
		NativeMethodInfoPtr_loadRMS_Public_Static_Il2CppStructArray_1_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665752);
		NativeMethodInfoPtr_loadRMSString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665753);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665754);
		NativeMethodInfoPtr_saveRMSString_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665755);
		NativeMethodInfoPtr__saveRMS_Private_Static_Void_String_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665756);
		NativeMethodInfoPtr__loadRMS_Private_Static_Il2CppStructArray_1_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665757);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665758);
		NativeMethodInfoPtr_loadRMSInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665759);
		NativeMethodInfoPtr_saveRMSInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665760);
		NativeMethodInfoPtr_loadRMSLong_Public_Static_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665761);
		NativeMethodInfoPtr_saveRMSLong_Public_Static_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665762);
		NativeMethodInfoPtr_GetiPhoneDocumentsPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665763);
		NativeMethodInfoPtr_StringToHex_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665764);
		NativeMethodInfoPtr___saveRMS_Private_Static_Void_String_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665765);
		NativeMethodInfoPtr___loadRMS_Private_Static_Il2CppStructArray_1_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665766);
		NativeMethodInfoPtr_clearAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665767);
		NativeMethodInfoPtr_DeleteStorage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665768);
		NativeMethodInfoPtr_ByteArrayToString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665769);
		NativeMethodInfoPtr_StringToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665770);
		NativeMethodInfoPtr_deleteRecord_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665771);
		NativeMethodInfoPtr_clearRMS_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665772);
		NativeMethodInfoPtr_saveIP_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665773);
		NativeMethodInfoPtr_loadIP_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665774);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rms>.NativeClassPtr, 100665775);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 85872, RefRangeEnd = 85900, XrefRangeStart = 85846, XrefRangeEnd = 85872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveRMS(string filename, Il2CppStructArray<sbyte> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRMS_Public_Static_Void_String_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 85927, RefRangeEnd = 85960, XrefRangeStart = 85900, XrefRangeEnd = 85927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> loadRMS(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadRMS_Public_Static_Il2CppStructArray_1_SByte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 85967, RefRangeEnd = 86000, XrefRangeStart = 85960, XrefRangeEnd = 85967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string loadRMSString(string fileName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadRMSString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86000, XrefRangeEnd = 86004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> convertSbyteToByte(Il2CppStructArray<sbyte> var)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)var);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 86014, RefRangeEnd = 86035, XrefRangeStart = 86004, XrefRangeEnd = 86014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveRMSString(string filename, string data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRMSString_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86035, XrefRangeEnd = 86058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _saveRMS(string filename, Il2CppStructArray<sbyte> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__saveRMS_Private_Static_Void_String_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86058, XrefRangeEnd = 86078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> _loadRMS(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__loadRMS_Private_Static_Il2CppStructArray_1_SByte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86089, RefRangeEnd = 86090, XrefRangeStart = 86078, XrefRangeEnd = 86089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 86091, RefRangeEnd = 86142, XrefRangeStart = 86090, XrefRangeEnd = 86091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int loadRMSInt(string file)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadRMSInt_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(61)]
	[CachedScanResults(RefRangeStart = 86147, RefRangeEnd = 86208, XrefRangeStart = 86142, XrefRangeEnd = 86147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveRMSInt(string file, int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRMSInt_Public_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86209, RefRangeEnd = 86211, XrefRangeStart = 86208, XrefRangeEnd = 86209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long loadRMSLong(string file)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadRMSLong_Public_Static_Int64_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86217, RefRangeEnd = 86219, XrefRangeStart = 86211, XrefRangeEnd = 86217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveRMSLong(string file, long x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(file);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveRMSLong_Public_Static_Void_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86219, XrefRangeEnd = 86223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetiPhoneDocumentsPath()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetiPhoneDocumentsPath_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86233, RefRangeEnd = 86235, XrefRangeStart = 86223, XrefRangeEnd = 86233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string StringToHex(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToHex_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86256, RefRangeEnd = 86257, XrefRangeStart = 86235, XrefRangeEnd = 86256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __saveRMS(string filename, Il2CppStructArray<sbyte> data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___saveRMS_Private_Static_Void_String_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86275, RefRangeEnd = 86276, XrefRangeStart = 86257, XrefRangeEnd = 86275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> __loadRMS(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___loadRMS_Private_Static_Il2CppStructArray_1_SByte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 86293, RefRangeEnd = 86297, XrefRangeStart = 86276, XrefRangeEnd = 86293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearAll()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearAll_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 86306, RefRangeEnd = 86308, XrefRangeStart = 86297, XrefRangeEnd = 86306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteStorage(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteStorage_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86308, XrefRangeEnd = 86315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ByteArrayToString(Il2CppStructArray<byte> ba)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ba);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ByteArrayToString_Public_Static_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86315, XrefRangeEnd = 86323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> StringToByteArray(string hex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(hex);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 86328, RefRangeEnd = 86336, XrefRangeStart = 86323, XrefRangeEnd = 86328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void deleteRecord(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_deleteRecord_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86336, XrefRangeEnd = 86360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void clearRMS()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearRMS_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86363, RefRangeEnd = 86364, XrefRangeStart = 86360, XrefRangeEnd = 86363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveIP(string strID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(strID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveIP_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86364, XrefRangeEnd = 86367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string loadIP()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadIP_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rms()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rms>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Rms(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
