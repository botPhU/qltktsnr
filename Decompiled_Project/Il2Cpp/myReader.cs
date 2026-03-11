using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class myReader : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_posRead;

	private static readonly System.IntPtr NativeFieldInfoPtr_posMark;

	private static readonly System.IntPtr NativeFieldInfoPtr_fileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetByteSpan_Private_ReadOnlySpan_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readSByte_Public_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readsbyte_Public_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readByte_Public_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mark_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readUnsignedByte_Public_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readShort_Public_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readUnsignedShort_Public_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readInt_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readLong_Public_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readFloat_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readBool_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readBoolean_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readString_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readStringUTF_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readUTF_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_Public_Int32_byref_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readFully_Public_Void_byref_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_available_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_close_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_Public_Void_byref_Il2CppStructArray_1_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readInts_Public_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readLongs_Public_Il2CppStructArray_1_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readUTFs_Public_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readBooleans_Public_Il2CppStructArray_1_Boolean_0;

	public unsafe Il2CppStructArray<sbyte> buffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe int posRead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posRead);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posRead)) = num;
		}
	}

	public unsafe int posMark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posMark);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_posMark)) = num;
		}
	}

	public unsafe static string fileName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fileName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fileName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
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

	static myReader()
	{
		Il2CppClassPointerStore<myReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "myReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<myReader>.NativeClassPtr);
		NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<myReader>.NativeClassPtr, "buffer");
		NativeFieldInfoPtr_posRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<myReader>.NativeClassPtr, "posRead");
		NativeFieldInfoPtr_posMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<myReader>.NativeClassPtr, "posMark");
		NativeFieldInfoPtr_fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<myReader>.NativeClassPtr, "fileName");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<myReader>.NativeClassPtr, "status");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665140);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665141);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665142);
		NativeMethodInfoPtr_GetByteSpan_Private_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665143);
		NativeMethodInfoPtr_readSByte_Public_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665144);
		NativeMethodInfoPtr_readsbyte_Public_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665145);
		NativeMethodInfoPtr_readByte_Public_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665146);
		NativeMethodInfoPtr_mark_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665147);
		NativeMethodInfoPtr_reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665148);
		NativeMethodInfoPtr_readUnsignedByte_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665149);
		NativeMethodInfoPtr_readShort_Public_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665150);
		NativeMethodInfoPtr_readUnsignedShort_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665151);
		NativeMethodInfoPtr_readInt_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665152);
		NativeMethodInfoPtr_readLong_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665153);
		NativeMethodInfoPtr_readFloat_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665154);
		NativeMethodInfoPtr_readBool_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665155);
		NativeMethodInfoPtr_readBoolean_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665156);
		NativeMethodInfoPtr_readString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665157);
		NativeMethodInfoPtr_readStringUTF_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665158);
		NativeMethodInfoPtr_readUTF_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665159);
		NativeMethodInfoPtr_read_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665160);
		NativeMethodInfoPtr_read_Public_Int32_byref_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665161);
		NativeMethodInfoPtr_readFully_Public_Void_byref_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665162);
		NativeMethodInfoPtr_available_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665163);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665164);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665165);
		NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665166);
		NativeMethodInfoPtr_close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665167);
		NativeMethodInfoPtr_read_Public_Void_byref_Il2CppStructArray_1_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665168);
		NativeMethodInfoPtr_readInts_Public_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665169);
		NativeMethodInfoPtr_readLongs_Public_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665170);
		NativeMethodInfoPtr_readUTFs_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665171);
		NativeMethodInfoPtr_readBooleans_Public_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<myReader>.NativeClassPtr, 100665172);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe myReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<myReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 66432, RefRangeEnd = 66446, XrefRangeStart = 66430, XrefRangeEnd = 66432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe myReader(Il2CppStructArray<sbyte> data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<myReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66468, RefRangeEnd = 66469, XrefRangeStart = 66446, XrefRangeEnd = 66468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe myReader(string filename)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<myReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66469, XrefRangeEnd = 66479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ReadOnlySpan<byte> GetByteSpan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByteSpan_Private_ReadOnlySpan_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ReadOnlySpan<byte>(pointer);
	}

	[CallerCount(388)]
	[CachedScanResults(RefRangeStart = 66479, RefRangeEnd = 66867, XrefRangeStart = 66479, XrefRangeEnd = 66479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe sbyte readSByte()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readSByte_Public_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 66868, RefRangeEnd = 66922, XrefRangeStart = 66867, XrefRangeEnd = 66868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe sbyte readsbyte()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readsbyte_Public_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 66868, RefRangeEnd = 66922, XrefRangeStart = 66868, XrefRangeEnd = 66922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe void mark(int readlimit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&readlimit);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mark_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(54)]
	[CachedScanResults(RefRangeStart = 66868, RefRangeEnd = 66922, XrefRangeStart = 66868, XrefRangeEnd = 66922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte readUnsignedByte()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readUnsignedByte_Public_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66922, XrefRangeEnd = 66933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe short readShort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readShort_Public_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66933, XrefRangeEnd = 66944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ushort readUnsignedShort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readUnsignedShort_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66944, XrefRangeEnd = 66955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int readInt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readInt_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66955, XrefRangeEnd = 66961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66961, XrefRangeEnd = 66972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float readFloat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readFloat_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 66973, RefRangeEnd = 66994, XrefRangeStart = 66972, XrefRangeEnd = 66973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool readBool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readBool_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 66973, RefRangeEnd = 66994, XrefRangeStart = 66973, XrefRangeEnd = 66994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool readBoolean()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readBoolean_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(166)]
	[CachedScanResults(RefRangeStart = 67002, RefRangeEnd = 67168, XrefRangeStart = 66994, XrefRangeEnd = 67002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string readString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 67177, RefRangeEnd = 67206, XrefRangeStart = 67168, XrefRangeEnd = 67177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string readStringUTF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readStringUTF_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 67177, RefRangeEnd = 67206, XrefRangeStart = 67177, XrefRangeEnd = 67206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string readUTF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readUTF_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	public unsafe int read()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 67224, RefRangeEnd = 67230, XrefRangeStart = 67206, XrefRangeEnd = 67224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int read(ref Il2CppStructArray<sbyte> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_Public_Int32_byref_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<sbyte>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 67244, RefRangeEnd = 67252, XrefRangeStart = 67230, XrefRangeEnd = 67244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 67252, RefRangeEnd = 67256, XrefRangeStart = 67252, XrefRangeEnd = 67252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int available()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_available_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52093, RefRangeEnd = 52094, XrefRangeStart = 52093, XrefRangeEnd = 52094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte convertSbyteToByte(sbyte var)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&var);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67256, XrefRangeEnd = 67269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> convertSbyteToByte(Il2CppStructArray<sbyte> var)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)var);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 67270, RefRangeEnd = 67272, XrefRangeStart = 67269, XrefRangeEnd = 67270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 67270, RefRangeEnd = 67272, XrefRangeStart = 67270, XrefRangeEnd = 67272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 67290, RefRangeEnd = 67293, XrefRangeStart = 67272, XrefRangeEnd = 67290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void read(ref Il2CppStructArray<sbyte> data, int offset, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_Public_Void_byref_Il2CppStructArray_1_SByte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<sbyte>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 67324, RefRangeEnd = 67325, XrefRangeStart = 67293, XrefRangeEnd = 67324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> readInts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readInts_Public_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67325, XrefRangeEnd = 67350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<long> readLongs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readLongs_Public_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67350, XrefRangeEnd = 67368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStringArray readUTFs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readUTFs_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67368, XrefRangeEnd = 67373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<bool> readBooleans()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readBooleans_Public_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
	}

	public myReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
