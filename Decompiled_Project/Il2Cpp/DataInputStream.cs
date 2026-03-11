using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class DataInputStream : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXTIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_istemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_filenametemp;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getResourceAsStream_Public_Static_DataInputStream_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__getResourceAsStream_Private_Static_DataInputStream_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___getResourceAsStream_Private_Static_DataInputStream_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readShort_Public_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readInt_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_Public_Void_byref_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_close_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readUTF_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readByte_Public_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readLong_Public_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readBoolean_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readUnsignedByte_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readUnsignedShort_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readFully_Public_Void_byref_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_available_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_Internal_Void_byref_Il2CppStructArray_1_SByte_Int32_Int32_0;

	public unsafe myReader r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<myReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myReader2));
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

	public unsafe static DataInputStream istemp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_istemp, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataInputStream>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_istemp, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataInputStream));
		}
	}

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

	public unsafe static string filenametemp
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_filenametemp, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_filenametemp, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static DataInputStream()
	{
		Il2CppClassPointerStore<DataInputStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DataInputStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr);
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, "r");
		NativeFieldInfoPtr_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, "INTERVAL");
		NativeFieldInfoPtr_MAXTIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, "MAXTIME");
		NativeFieldInfoPtr_istemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, "istemp");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, "status");
		NativeFieldInfoPtr_filenametemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, "filenametemp");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_getResourceAsStream_Public_Static_DataInputStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr__getResourceAsStream_Private_Static_DataInputStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr___getResourceAsStream_Private_Static_DataInputStream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_readShort_Public_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_readInt_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_read_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_read_Public_Void_byref_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_readUTF_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_readByte_Public_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_readLong_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_readBoolean_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_readUnsignedByte_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_readUnsignedShort_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_readFully_Public_Void_byref_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_available_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_read_Internal_Void_byref_Il2CppStructArray_1_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr, 100663843);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31680, XrefRangeEnd = 31699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataInputStream(string filename)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 31705, RefRangeEnd = 31721, XrefRangeStart = 31699, XrefRangeEnd = 31705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DataInputStream(Il2CppStructArray<sbyte> data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataInputStream>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31729, RefRangeEnd = 31730, XrefRangeStart = 31721, XrefRangeEnd = 31729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31731, RefRangeEnd = 31732, XrefRangeStart = 31730, XrefRangeEnd = 31731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DataInputStream getResourceAsStream(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getResourceAsStream_Public_Static_DataInputStream_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataInputStream>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31732, XrefRangeEnd = 31746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DataInputStream _getResourceAsStream(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__getResourceAsStream_Private_Static_DataInputStream_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataInputStream>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31767, RefRangeEnd = 31769, XrefRangeStart = 31746, XrefRangeEnd = 31767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DataInputStream __getResourceAsStream(string filename)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___getResourceAsStream_Private_Static_DataInputStream_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataInputStream>(intPtr) : null;
	}

	[CallerCount(68)]
	[CachedScanResults(RefRangeStart = 31771, RefRangeEnd = 31839, XrefRangeStart = 31769, XrefRangeEnd = 31771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe short readShort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readShort_Public_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31850, RefRangeEnd = 31851, XrefRangeStart = 31839, XrefRangeEnd = 31850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int readInt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readInt_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 31852, RefRangeEnd = 31856, XrefRangeStart = 31851, XrefRangeEnd = 31852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int read()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31856, XrefRangeEnd = 31858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void read(ref Il2CppStructArray<sbyte> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_Public_Void_byref_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<sbyte>(intPtr4));
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 31860, RefRangeEnd = 31866, XrefRangeStart = 31858, XrefRangeEnd = 31860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 31860, RefRangeEnd = 31866, XrefRangeStart = 31860, XrefRangeEnd = 31866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 31868, RefRangeEnd = 31872, XrefRangeStart = 31866, XrefRangeEnd = 31868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string readUTF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readUTF_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 31874, RefRangeEnd = 31893, XrefRangeStart = 31872, XrefRangeEnd = 31874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe sbyte readByte()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readByte_Public_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31893, XrefRangeEnd = 31904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long readLong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readLong_Public_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31904, XrefRangeEnd = 31905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool readBoolean()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readBoolean_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 31852, RefRangeEnd = 31856, XrefRangeStart = 31852, XrefRangeEnd = 31856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int readUnsignedByte()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readUnsignedByte_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31905, XrefRangeEnd = 31916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int readUnsignedShort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readUnsignedShort_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readFully(ref Il2CppStructArray<sbyte> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readFully_Public_Void_byref_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<sbyte>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31916, RefRangeEnd = 31917, XrefRangeStart = 31916, XrefRangeEnd = 31916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int available()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_available_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31917, XrefRangeEnd = 31922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void read(ref Il2CppStructArray<sbyte> byteData, int p, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)byteData);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &p;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_Internal_Void_byref_Il2CppStructArray_1_SByte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		byteData = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<sbyte>(intPtr4));
	}

	public DataInputStream(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
