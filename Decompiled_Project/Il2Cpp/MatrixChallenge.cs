using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public static class MatrixChallenge : Il2CppSystem.Object
{
	public class JavaRandom : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_seed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NextInt_Public_Int32_0;

		public unsafe long seed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seed)) = num;
			}
		}

		static JavaRandom()
		{
			Il2CppClassPointerStore<JavaRandom>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, "JavaRandom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JavaRandom>.NativeClassPtr);
			NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JavaRandom>.NativeClassPtr, "seed");
			NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaRandom>.NativeClassPtr, 100664711);
			NativeMethodInfoPtr_NextInt_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JavaRandom>.NativeClassPtr, 100664712);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56691, XrefRangeEnd = 56703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JavaRandom(long seed)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JavaRandom>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&seed);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 56717, RefRangeEnd = 56719, XrefRangeStart = 56703, XrefRangeEnd = 56717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NextInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextInt_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public JavaRandom(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOD;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_SECRET;

	private static readonly System.IntPtr NativeFieldInfoPtr_logFilePath;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogToFile_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateDefaultSecret_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DefaultSecret_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomMatrix_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeResponse_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearLogFile_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrintDefaultSecret_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessChallenge_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0;

	public unsafe static int SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SIZE, (void*)(&num));
		}
	}

	public unsafe static ulong MOD
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOD, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<ulong>> DEFAULT_SECRET
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_SECRET, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<ulong>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_SECRET, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static string logFilePath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_logFilePath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_logFilePath, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	static MatrixChallenge()
	{
		Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MatrixChallenge");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr);
		NativeFieldInfoPtr_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, "SIZE");
		NativeFieldInfoPtr_MOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, "MOD");
		NativeFieldInfoPtr_DEFAULT_SECRET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, "DEFAULT_SECRET");
		NativeFieldInfoPtr_logFilePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, "logFilePath");
		NativeMethodInfoPtr_LogToFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664701);
		NativeMethodInfoPtr_GenerateDefaultSecret_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664702);
		NativeMethodInfoPtr_DefaultSecret_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664703);
		NativeMethodInfoPtr_RandomMatrix_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664704);
		NativeMethodInfoPtr_Multiply_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664705);
		NativeMethodInfoPtr_ComputeResponse_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664706);
		NativeMethodInfoPtr_ClearLogFile_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664707);
		NativeMethodInfoPtr_PrintDefaultSecret_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664708);
		NativeMethodInfoPtr_ProcessChallenge_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatrixChallenge>.NativeClassPtr, 100664709);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogToFile(string message)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogToFile_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56719, XrefRangeEnd = 56796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<ulong>> GenerateDefaultSecret()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateDefaultSecret_Private_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<ulong>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56808, RefRangeEnd = 56809, XrefRangeStart = 56796, XrefRangeEnd = 56808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<ulong>> DefaultSecret()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DefaultSecret_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<ulong>>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56809, XrefRangeEnd = 56827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<ulong>> RandomMatrix()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomMatrix_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<ulong>>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56911, RefRangeEnd = 56913, XrefRangeStart = 56827, XrefRangeEnd = 56911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<ulong>> Multiply(Il2CppReferenceArray<Il2CppStructArray<ulong>> a, Il2CppReferenceArray<Il2CppStructArray<ulong>> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Multiply_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<ulong>>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56975, RefRangeEnd = 56977, XrefRangeStart = 56913, XrefRangeEnd = 56975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<ulong>> ComputeResponse(Il2CppReferenceArray<Il2CppStructArray<ulong>> secret, Il2CppReferenceArray<Il2CppStructArray<ulong>> challenge)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secret);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)challenge);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeResponse_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<ulong>>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56977, XrefRangeEnd = 56994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearLogFile()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearLogFile_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56994, XrefRangeEnd = 57015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrintDefaultSecret()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrintDefaultSecret_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57015, XrefRangeEnd = 57063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppStructArray<ulong>> ProcessChallenge(Il2CppReferenceArray<Il2CppStructArray<ulong>> challenge)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)challenge);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessChallenge_Public_Static_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_Il2CppReferenceArray_1_Il2CppStructArray_1_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<ulong>>>(intPtr) : null;
	}

	public MatrixChallenge(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
