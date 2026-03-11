using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Numerics;

namespace Il2Cpp;

public class SimpleECC : Il2CppSystem.Object
{
	public class Point : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_infinity;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_BigInteger_0;

		public unsafe BigInteger x
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe BigInteger y
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
				return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool infinity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infinity);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_infinity)) = flag;
			}
		}

		static Point()
		{
			Il2CppClassPointerStore<Point>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "Point");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Point>.NativeClassPtr);
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Point>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Point>.NativeClassPtr, "y");
			NativeFieldInfoPtr_infinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Point>.NativeClassPtr, "infinity");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100666154);
			NativeMethodInfoPtr__ctor_Public_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Point>.NativeClassPtr, 100666155);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95275, XrefRangeEnd = 95289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Point()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Point>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95292, RefRangeEnd = 95294, XrefRangeStart = 95289, XrefRangeEnd = 95292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Point(BigInteger x, BigInteger y)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Point>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)y));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Point(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_p;

	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeFieldInfoPtr_b;

	private static readonly System.IntPtr NativeFieldInfoPtr_g;

	private static readonly System.IntPtr NativeFieldInfoPtr__zeroValue;

	private static readonly System.IntPtr NativeFieldInfoPtr__oneValue;

	private static readonly System.IntPtr NativeFieldInfoPtr__twoValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetZeroValue_Private_Static_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOneValue_Private_Static_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTwoValue_Private_Static_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_BigInteger_BigInteger_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOnCurve_Public_Boolean_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModInverse_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeInput_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeModuloP_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPToResult_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFinalModuloP_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessModularInverse_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckZeroCondition_Private_Boolean_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareWithZero_Private_Boolean_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetZeroResult_Private_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFermatInverse_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeFermatExponent_Private_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubstractFromP_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteModularPow_Private_BigInteger_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Point_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleInfinityPoints_Private_Boolean_Point_Point_byref_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckFirstPointInfinity_Private_Boolean_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSecondPointInfinity_Private_Boolean_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnFirstPoint_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnSecondPoint_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNullPoint_Private_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessPointAddition_Private_Point_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckSameXCoordinate_Private_Boolean_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareXCoordinates_Private_Boolean_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleSameXCoordinate_Private_Point_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckOppositeYCoordinates_Private_Boolean_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddYCoordinates_Private_BigInteger_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInfinityPoint_Private_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformPointDoubling_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDoublingSlope_Private_BigInteger_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDoublingNumerator_Private_BigInteger_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyValues_Private_BigInteger_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyByThree_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddConstantA_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDoublingDenominator_Private_BigInteger_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyByTwo_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiplyWithInverse_Private_BigInteger_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleDifferentXCoordinate_Private_Point_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateAdditionSlope_Private_BigInteger_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeAdditionNumerator_Private_BigInteger_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeAdditionDenominator_Private_BigInteger_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubtractValues_Private_BigInteger_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeResultFromSlope_Private_Point_Point_Point_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateResultX_Private_BigInteger_Point_Point_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckPointsEqual_Private_Boolean_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeDoublingResultX_Private_BigInteger_Point_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeAdditionResultX_Private_BigInteger_Point_Point_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateResultY_Private_BigInteger_Point_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNormalizedPoint_Private_Point_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeCoordinate_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConstructPoint_Private_Point_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Multiply_Public_Point_Point_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAccumulator_Private_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCurrentPoint_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyPoint_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeScalar_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyScalar_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessScalarMultiplication_Private_Point_Point_Point_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckScalarCondition_Private_Boolean_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareScalarWithZero_Private_Boolean_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSingleIteration_Private_Point_Point_Point_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldAddCurrentPoint_Private_Boolean_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsScalarBitSet_Private_Boolean_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckOddScalar_Private_Boolean_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddToAccumulator_Private_Point_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnUnchangedAccumulator_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoubleCurrentPoint_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShiftScalarRight_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformRightShift_Private_BigInteger_BigInteger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFinalResult_Private_Point_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidatePoint_Private_Boolean_Point_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeModP_Private_BigInteger_BigInteger_0;

	public unsafe BigInteger p
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p);
			return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_p), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe BigInteger a
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
			return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe BigInteger b
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b);
			return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Point g
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point));
		}
	}

	public unsafe BigInteger _zeroValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zeroValue);
			return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__zeroValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe BigInteger _oneValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oneValue);
			return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oneValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe BigInteger _twoValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__twoValue);
			return new BigInteger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__twoValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bigInteger)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static SimpleECC()
	{
		Il2CppClassPointerStore<SimpleECC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SimpleECC");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr);
		NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "p");
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "a");
		NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "b");
		NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "g");
		NativeFieldInfoPtr__zeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "_zeroValue");
		NativeFieldInfoPtr__oneValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "_oneValue");
		NativeFieldInfoPtr__twoValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, "_twoValue");
		NativeMethodInfoPtr_GetZeroValue_Private_Static_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666078);
		NativeMethodInfoPtr_GetOneValue_Private_Static_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666079);
		NativeMethodInfoPtr_GetTwoValue_Private_Static_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666080);
		NativeMethodInfoPtr__ctor_Public_Void_BigInteger_BigInteger_BigInteger_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666081);
		NativeMethodInfoPtr_IsOnCurve_Public_Boolean_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666082);
		NativeMethodInfoPtr_ModInverse_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666083);
		NativeMethodInfoPtr_NormalizeInput_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666084);
		NativeMethodInfoPtr_ComputeModuloP_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666085);
		NativeMethodInfoPtr_AddPToResult_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666086);
		NativeMethodInfoPtr_ComputeFinalModuloP_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666087);
		NativeMethodInfoPtr_ProcessModularInverse_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666088);
		NativeMethodInfoPtr_CheckZeroCondition_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666089);
		NativeMethodInfoPtr_CompareWithZero_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666090);
		NativeMethodInfoPtr_GetZeroResult_Private_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666091);
		NativeMethodInfoPtr_CalculateFermatInverse_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666092);
		NativeMethodInfoPtr_ComputeFermatExponent_Private_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666093);
		NativeMethodInfoPtr_SubstractFromP_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666094);
		NativeMethodInfoPtr_ExecuteModularPow_Private_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666095);
		NativeMethodInfoPtr_Add_Public_Point_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666096);
		NativeMethodInfoPtr_HandleInfinityPoints_Private_Boolean_Point_Point_byref_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666097);
		NativeMethodInfoPtr_CheckFirstPointInfinity_Private_Boolean_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666098);
		NativeMethodInfoPtr_CheckSecondPointInfinity_Private_Boolean_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666099);
		NativeMethodInfoPtr_ReturnFirstPoint_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666100);
		NativeMethodInfoPtr_ReturnSecondPoint_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666101);
		NativeMethodInfoPtr_GetNullPoint_Private_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666102);
		NativeMethodInfoPtr_ProcessPointAddition_Private_Point_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666103);
		NativeMethodInfoPtr_CheckSameXCoordinate_Private_Boolean_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666104);
		NativeMethodInfoPtr_CompareXCoordinates_Private_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666105);
		NativeMethodInfoPtr_HandleSameXCoordinate_Private_Point_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666106);
		NativeMethodInfoPtr_CheckOppositeYCoordinates_Private_Boolean_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666107);
		NativeMethodInfoPtr_AddYCoordinates_Private_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666108);
		NativeMethodInfoPtr_CreateInfinityPoint_Private_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666109);
		NativeMethodInfoPtr_PerformPointDoubling_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666110);
		NativeMethodInfoPtr_CalculateDoublingSlope_Private_BigInteger_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666111);
		NativeMethodInfoPtr_ComputeDoublingNumerator_Private_BigInteger_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666112);
		NativeMethodInfoPtr_MultiplyValues_Private_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666113);
		NativeMethodInfoPtr_MultiplyByThree_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666114);
		NativeMethodInfoPtr_AddConstantA_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666115);
		NativeMethodInfoPtr_ComputeDoublingDenominator_Private_BigInteger_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666116);
		NativeMethodInfoPtr_MultiplyByTwo_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666117);
		NativeMethodInfoPtr_MultiplyWithInverse_Private_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666118);
		NativeMethodInfoPtr_HandleDifferentXCoordinate_Private_Point_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666119);
		NativeMethodInfoPtr_CalculateAdditionSlope_Private_BigInteger_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666120);
		NativeMethodInfoPtr_ComputeAdditionNumerator_Private_BigInteger_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666121);
		NativeMethodInfoPtr_ComputeAdditionDenominator_Private_BigInteger_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666122);
		NativeMethodInfoPtr_SubtractValues_Private_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666123);
		NativeMethodInfoPtr_ComputeResultFromSlope_Private_Point_Point_Point_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666124);
		NativeMethodInfoPtr_CalculateResultX_Private_BigInteger_Point_Point_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666125);
		NativeMethodInfoPtr_CheckPointsEqual_Private_Boolean_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666126);
		NativeMethodInfoPtr_ComputeDoublingResultX_Private_BigInteger_Point_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666127);
		NativeMethodInfoPtr_ComputeAdditionResultX_Private_BigInteger_Point_Point_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666128);
		NativeMethodInfoPtr_CalculateResultY_Private_BigInteger_Point_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666129);
		NativeMethodInfoPtr_CreateNormalizedPoint_Private_Point_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666130);
		NativeMethodInfoPtr_NormalizeCoordinate_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666131);
		NativeMethodInfoPtr_ConstructPoint_Private_Point_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666132);
		NativeMethodInfoPtr_Multiply_Public_Point_Point_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666133);
		NativeMethodInfoPtr_InitializeAccumulator_Private_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666134);
		NativeMethodInfoPtr_InitializeCurrentPoint_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666135);
		NativeMethodInfoPtr_CopyPoint_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666136);
		NativeMethodInfoPtr_InitializeScalar_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666137);
		NativeMethodInfoPtr_CopyScalar_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666138);
		NativeMethodInfoPtr_ProcessScalarMultiplication_Private_Point_Point_Point_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666139);
		NativeMethodInfoPtr_CheckScalarCondition_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666140);
		NativeMethodInfoPtr_CompareScalarWithZero_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666141);
		NativeMethodInfoPtr_ProcessSingleIteration_Private_Point_Point_Point_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666142);
		NativeMethodInfoPtr_ShouldAddCurrentPoint_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666143);
		NativeMethodInfoPtr_IsScalarBitSet_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666144);
		NativeMethodInfoPtr_CheckOddScalar_Private_Boolean_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666145);
		NativeMethodInfoPtr_AddToAccumulator_Private_Point_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666146);
		NativeMethodInfoPtr_ReturnUnchangedAccumulator_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666147);
		NativeMethodInfoPtr_DoubleCurrentPoint_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666148);
		NativeMethodInfoPtr_ShiftScalarRight_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666149);
		NativeMethodInfoPtr_PerformRightShift_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666150);
		NativeMethodInfoPtr_GetFinalResult_Private_Point_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666151);
		NativeMethodInfoPtr_ValidatePoint_Private_Boolean_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666152);
		NativeMethodInfoPtr_NormalizeModP_Private_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr, 100666153);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95294, XrefRangeEnd = 95306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BigInteger GetZeroValue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetZeroValue_Private_Static_BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95306, XrefRangeEnd = 95318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BigInteger GetOneValue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOneValue_Private_Static_BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95318, XrefRangeEnd = 95330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BigInteger GetTwoValue()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTwoValue_Private_Static_BigInteger_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95374, RefRangeEnd = 95375, XrefRangeStart = 95330, XrefRangeEnd = 95374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleECC(BigInteger p, BigInteger a, BigInteger b, Point g)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleECC>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)p));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BigInteger_BigInteger_BigInteger_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95375, XrefRangeEnd = 95395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsOnCurve(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOnCurve_Public_Boolean_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 95420, RefRangeEnd = 95425, XrefRangeStart = 95395, XrefRangeEnd = 95420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ModInverse(BigInteger x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ModInverse_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95425, XrefRangeEnd = 95437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger NormalizeInput(BigInteger input)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)input));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeInput_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95437, XrefRangeEnd = 95441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeModuloP(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeModuloP_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95441, XrefRangeEnd = 95445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger AddPToResult(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPToResult_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95445, XrefRangeEnd = 95449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeFinalModuloP(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFinalModuloP_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95449, XrefRangeEnd = 95462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ProcessModularInverse(BigInteger normalizedValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)normalizedValue));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessModularInverse_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95462, XrefRangeEnd = 95466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckZeroCondition(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckZeroCondition_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareWithZero(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareWithZero_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe BigInteger GetZeroResult()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetZeroResult_Private_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95466, XrefRangeEnd = 95474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger CalculateFermatInverse(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFermatInverse_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95474, XrefRangeEnd = 95478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeFermatExponent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeFermatExponent_Private_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95478, XrefRangeEnd = 95482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger SubstractFromP(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubstractFromP_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95482, XrefRangeEnd = 95486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ExecuteModularPow(BigInteger baseValue, BigInteger exponent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)baseValue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)exponent));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteModularPow_Private_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95486, XrefRangeEnd = 95488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point Add(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Point_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95488, XrefRangeEnd = 95489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleInfinityPoints(Point P, Point Q, out Point result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleInfinityPoints_Private_Boolean_Point_Point_byref_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		nint num3 = num2;
		result = ((num3 == 0) ? null : new Point(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool CheckFirstPointInfinity(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckFirstPointInfinity_Private_Boolean_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool CheckSecondPointInfinity(Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSecondPointInfinity_Private_Boolean_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe Point ReturnFirstPoint(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnFirstPoint_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Point ReturnSecondPoint(Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnSecondPoint_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 70451, RefRangeEnd = 70470, XrefRangeStart = 70451, XrefRangeEnd = 70470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point GetNullPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNullPoint_Private_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 95511, RefRangeEnd = 95514, XrefRangeStart = 95489, XrefRangeEnd = 95511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point ProcessPointAddition(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessPointAddition_Private_Point_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95514, XrefRangeEnd = 95518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckSameXCoordinate(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckSameXCoordinate_Private_Boolean_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95518, XrefRangeEnd = 95522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareXCoordinates(BigInteger x1, BigInteger x2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x1));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x2));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareXCoordinates_Private_Boolean_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95522, XrefRangeEnd = 95536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point HandleSameXCoordinate(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleSameXCoordinate_Private_Point_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95536, XrefRangeEnd = 95548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckOppositeYCoordinates(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckOppositeYCoordinates_Private_Boolean_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95548, XrefRangeEnd = 95552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger AddYCoordinates(BigInteger y1, BigInteger y2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)y1));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)y2));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddYCoordinates_Private_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95569, RefRangeEnd = 95571, XrefRangeStart = 95552, XrefRangeEnd = 95569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point CreateInfinityPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInfinityPoint_Private_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95571, XrefRangeEnd = 95573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point PerformPointDoubling(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformPointDoubling_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 95607, RefRangeEnd = 95611, XrefRangeStart = 95573, XrefRangeEnd = 95607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger CalculateDoublingSlope(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDoublingSlope_Private_BigInteger_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95611, XrefRangeEnd = 95628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeDoublingNumerator(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDoublingNumerator_Private_BigInteger_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95628, XrefRangeEnd = 95632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger MultiplyValues(BigInteger a, BigInteger b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyValues_Private_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95632, XrefRangeEnd = 95637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger MultiplyByThree(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyByThree_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95637, XrefRangeEnd = 95641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger AddConstantA(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddConstantA_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95641, XrefRangeEnd = 95649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeDoublingDenominator(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDoublingDenominator_Private_BigInteger_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95649, XrefRangeEnd = 95653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger MultiplyByTwo(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyByTwo_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95653, XrefRangeEnd = 95662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger MultiplyWithInverse(BigInteger numerator, BigInteger denominator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)numerator));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)denominator));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiplyWithInverse_Private_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95662, XrefRangeEnd = 95680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point HandleDifferentXCoordinate(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleDifferentXCoordinate_Private_Point_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95680, XrefRangeEnd = 95697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger CalculateAdditionSlope(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateAdditionSlope_Private_BigInteger_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95697, XrefRangeEnd = 95701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeAdditionNumerator(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeAdditionNumerator_Private_BigInteger_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95701, XrefRangeEnd = 95705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeAdditionDenominator(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeAdditionDenominator_Private_BigInteger_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95705, XrefRangeEnd = 95709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger SubtractValues(BigInteger a, BigInteger b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)a));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubtractValues_Private_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 95734, RefRangeEnd = 95740, XrefRangeStart = 95709, XrefRangeEnd = 95734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point ComputeResultFromSlope(Point P, Point Q, BigInteger slope)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)slope));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeResultFromSlope_Private_Point_Point_Point_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95773, RefRangeEnd = 95774, XrefRangeStart = 95740, XrefRangeEnd = 95773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger CalculateResultX(Point P, Point Q, BigInteger slope)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)slope));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateResultX_Private_BigInteger_Point_Point_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckPointsEqual(Point P, Point Q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckPointsEqual_Private_Boolean_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95774, XrefRangeEnd = 95790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeDoublingResultX(Point P, BigInteger slope)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)slope));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeDoublingResultX_Private_BigInteger_Point_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95790, XrefRangeEnd = 95806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ComputeAdditionResultX(Point P, Point Q, BigInteger slope)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)Q);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)slope));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeAdditionResultX_Private_BigInteger_Point_Point_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95806, XrefRangeEnd = 95822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger CalculateResultY(Point P, BigInteger slope, BigInteger resultX)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)slope));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resultX));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateResultY_Private_BigInteger_Point_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95822, XrefRangeEnd = 95830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point CreateNormalizedPoint(BigInteger x, BigInteger y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)y));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNormalizedPoint_Private_Point_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 95838, RefRangeEnd = 95842, XrefRangeStart = 95830, XrefRangeEnd = 95838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger NormalizeCoordinate(BigInteger coordinate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)coordinate));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeCoordinate_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95842, XrefRangeEnd = 95848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point ConstructPoint(BigInteger x, BigInteger y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)x));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)y));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConstructPoint_Private_Point_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95850, RefRangeEnd = 95852, XrefRangeStart = 95848, XrefRangeEnd = 95850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point Multiply(Point P, BigInteger k)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)k));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Multiply_Public_Point_Point_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95852, XrefRangeEnd = 95853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point InitializeAccumulator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeAccumulator_Private_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Point InitializeCurrentPoint(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeCurrentPoint_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Point CopyPoint(Point P)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)P);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyPoint_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe BigInteger InitializeScalar(BigInteger k)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)k));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeScalar_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	public unsafe BigInteger CopyScalar(BigInteger k)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)k));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyScalar_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95873, RefRangeEnd = 95874, XrefRangeStart = 95853, XrefRangeEnd = 95873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point ProcessScalarMultiplication(Point accumulator, Point currentPoint, BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accumulator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentPoint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessScalarMultiplication_Private_Point_Point_Point_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95874, XrefRangeEnd = 95878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckScalarCondition(BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckScalarCondition_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CompareScalarWithZero(BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareScalarWithZero_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95878, XrefRangeEnd = 95882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point ProcessSingleIteration(Point accumulator, Point currentPoint, BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accumulator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentPoint);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessSingleIteration_Private_Point_Point_Point_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95882, XrefRangeEnd = 95886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldAddCurrentPoint(BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldAddCurrentPoint_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsScalarBitSet(BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsScalarBitSet_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95886, XrefRangeEnd = 95890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckOddScalar(BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckOddScalar_Private_Boolean_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point AddToAccumulator(Point accumulator, Point currentPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accumulator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddToAccumulator_Private_Point_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Point ReturnUnchangedAccumulator(Point accumulator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accumulator);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnUnchangedAccumulator_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Point DoubleCurrentPoint(Point currentPoint)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)currentPoint);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoubleCurrentPoint_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95890, XrefRangeEnd = 95894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger ShiftScalarRight(BigInteger scalar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)scalar));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShiftScalarRight_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger PerformRightShift(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformRightShift_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	[CallerCount(0)]
	public unsafe Point GetFinalResult(Point accumulator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)accumulator);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFinalResult_Private_Point_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Point>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe bool ValidatePoint(Point point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)point);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidatePoint_Private_Boolean_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95894, XrefRangeEnd = 95900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BigInteger NormalizeModP(BigInteger value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalizeModP_Private_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new BigInteger(pointer);
	}

	public SimpleECC(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
