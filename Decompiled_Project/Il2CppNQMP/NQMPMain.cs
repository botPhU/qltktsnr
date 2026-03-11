using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppNQMP;

public class NQMPMain : Il2CppSystem.Object
{
	public class BossChat : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__NameBoss_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__MapBoss_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__TimeCreate_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_NameBoss_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_NameBoss_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MapBoss_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_MapBoss_Public_set_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeCreate_Public_get_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeCreate_Public_set_Void_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe string _NameBoss_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NameBoss_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NameBoss_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe string _MapBoss_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MapBoss_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MapBoss_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe long _TimeCreate_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeCreate_k__BackingField);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TimeCreate_k__BackingField)) = num;
			}
		}

		public unsafe string NameBoss
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70411, RefRangeEnd = 70413, XrefRangeStart = 70411, XrefRangeEnd = 70413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NameBoss_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62796, RefRangeEnd = 62797, XrefRangeStart = 62796, XrefRangeEnd = 62797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NameBoss_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe string MapBoss
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 51667, RefRangeEnd = 51671, XrefRangeStart = 51667, XrefRangeEnd = 51671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MapBoss_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117236, XrefRangeEnd = 117237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MapBoss_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		public unsafe long TimeCreate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeCreate_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TimeCreate_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		static BossChat()
		{
			Il2CppClassPointerStore<BossChat>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, "BossChat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossChat>.NativeClassPtr);
			NativeFieldInfoPtr__NameBoss_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossChat>.NativeClassPtr, "<NameBoss>k__BackingField");
			NativeFieldInfoPtr__MapBoss_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossChat>.NativeClassPtr, "<MapBoss>k__BackingField");
			NativeFieldInfoPtr__TimeCreate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossChat>.NativeClassPtr, "<TimeCreate>k__BackingField");
			NativeMethodInfoPtr_get_NameBoss_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossChat>.NativeClassPtr, 100666669);
			NativeMethodInfoPtr_set_NameBoss_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossChat>.NativeClassPtr, 100666670);
			NativeMethodInfoPtr_get_MapBoss_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossChat>.NativeClassPtr, 100666671);
			NativeMethodInfoPtr_set_MapBoss_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossChat>.NativeClassPtr, 100666672);
			NativeMethodInfoPtr_get_TimeCreate_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossChat>.NativeClassPtr, 100666673);
			NativeMethodInfoPtr_set_TimeCreate_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossChat>.NativeClassPtr, 100666674);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossChat>.NativeClassPtr, 100666675);
		}

		[CallerCount(707)]
		[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BossChat()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossChat>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public BossChat(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class aaMod : Il2CppSystem.Object
	{
		public class BossFunctions : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_nameBoss;

			private static readonly System.IntPtr NativeFieldInfoPtr_mapName;

			private static readonly System.IntPtr NativeFieldInfoPtr_mapID;

			private static readonly System.IntPtr NativeFieldInfoPtr_time;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_paintBoss_Public_Void_mGraphics_Int32_Int32_Int32_0;

			public unsafe string nameBoss
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameBoss);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameBoss)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe string mapName
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapName);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapName)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe int mapID
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapID);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapID)) = num;
				}
			}

			public unsafe Il2CppSystem.DateTime time
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
					return *(Il2CppSystem.DateTime*)num;
				}
				set
				{
					*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = dateTime;
				}
			}

			static BossFunctions()
			{
				Il2CppClassPointerStore<BossFunctions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "BossFunctions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr);
				NativeFieldInfoPtr_nameBoss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr, "nameBoss");
				NativeFieldInfoPtr_mapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr, "mapName");
				NativeFieldInfoPtr_mapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr, "mapID");
				NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr, "time");
				NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr, 100666696);
				NativeMethodInfoPtr_paintBoss_Public_Void_mGraphics_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr, 100666697);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 117277, RefRangeEnd = 117279, XrefRangeStart = 117237, XrefRangeEnd = 117277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BossFunctions(string a)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossFunctions>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 117359, RefRangeEnd = 117361, XrefRangeStart = 117279, XrefRangeEnd = 117359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void paintBoss(mGraphics a, int b, int c, int d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[4];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
				*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
				*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
				*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBoss_Public_Void_mGraphics_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public BossFunctions(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[System.Serializable]
		[ObfuscatedName("NQMP.NQMPMain+aaMod+<>c")]
		public sealed class __c : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_1;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__PaintCharInMap_b__24_0_Internal_Boolean_Char_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__PaintCharInMap_b__24_1_Internal_SByte_Char_0;

			public unsafe static __c __9
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)_c));
				}
			}

			public unsafe static Il2CppSystem.Func<Il2Cpp.Char, bool> __9__24_0
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2Cpp.Char, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			public unsafe static Il2CppSystem.Func<Il2Cpp.Char, sbyte> __9__24_1
			{
				get
				{
					Unsafe.SkipInit(out System.IntPtr intPtr);
					IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2Cpp.Char, sbyte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__24_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
				}
			}

			static __c()
			{
				Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
				NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
				NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_0");
				NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__24_1");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666699);
				NativeMethodInfoPtr__PaintCharInMap_b__24_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666700);
				NativeMethodInfoPtr__PaintCharInMap_b__24_1_Internal_SByte_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666701);
			}

			[CallerCount(707)]
			[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			public unsafe bool _PaintCharInMap_b__24_0(Il2Cpp.Char player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PaintCharInMap_b__24_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			[CallerCount(0)]
			public unsafe sbyte _PaintCharInMap_b__24_1(Il2Cpp.Char player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)player);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PaintCharInMap_b__24_1_Internal_SByte_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
			}

			public __c(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("NQMP.NQMPMain+aaMod+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_text;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__ChatVip_b__0_Internal_Void_String_0;

			public unsafe string text
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr);
				NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, "text");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100666702);
				NativeMethodInfoPtr__ChatVip_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr, 100666703);
			}

			[CallerCount(707)]
			[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117361, XrefRangeEnd = 117366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ChatVip_b__0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ChatVip_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public __c__DisplayClass10_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		[ObfuscatedName("NQMP.NQMPMain+aaMod+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_g;

			private static readonly System.IntPtr NativeFieldInfoPtr_text;

			private static readonly System.IntPtr NativeFieldInfoPtr_countChar;

			private static readonly System.IntPtr NativeFieldInfoPtr_maxwidth;

			private static readonly System.IntPtr NativeFieldInfoPtr_x;

			private static readonly System.IntPtr NativeFieldInfoPtr_y;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__PaintCharInMap_b__2_Internal_Void_Char_0;

			private static readonly System.IntPtr NativeMethodInfoPtr__PaintCharInMap_b__3_Internal_Void_Char_0;

			public unsafe mGraphics g
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<mGraphics>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mGraphics));
				}
			}

			public unsafe string text
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(text));
				}
			}

			public unsafe int countChar
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countChar);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countChar)) = num;
				}
			}

			public unsafe int maxwidth
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxwidth);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxwidth)) = num;
				}
			}

			public unsafe int x
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
				}
			}

			public unsafe int y
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)) = num;
				}
			}

			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr);
				NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "g");
				NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "text");
				NativeFieldInfoPtr_countChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "countChar");
				NativeFieldInfoPtr_maxwidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "maxwidth");
				NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "x");
				NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, "y");
				NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100666704);
				NativeMethodInfoPtr__PaintCharInMap_b__2_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100666705);
				NativeMethodInfoPtr__PaintCharInMap_b__3_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr, 100666706);
			}

			[CallerCount(707)]
			[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass24_0>.NativeClassPtr))
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117366, XrefRangeEnd = 117389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PaintCharInMap_b__2(Il2Cpp.Char item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PaintCharInMap_b__2_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117389, XrefRangeEnd = 117492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PaintCharInMap_b__3(Il2Cpp.Char item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PaintCharInMap_b__3_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			public __c__DisplayClass24_0(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_strBossAppeared;

		private static readonly System.IntPtr NativeFieldInfoPtr_bosschats;

		private static readonly System.IntPtr NativeFieldInfoPtr_isPaintboss;

		private static readonly System.IntPtr NativeFieldInfoPtr_isPaintChar;

		private static readonly System.IntPtr NativeFieldInfoPtr_iscdt;

		private static readonly System.IntPtr NativeFieldInfoPtr_isAutoHoiSinh;

		private static readonly System.IntPtr NativeFieldInfoPtr_isAk;

		private static readonly System.IntPtr NativeFieldInfoPtr_isAutoFocus;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastak;

		private static readonly System.IntPtr NativeFieldInfoPtr_ListMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_MapNames;

		private static readonly System.IntPtr NativeFieldInfoPtr_bossVip;

		private static readonly System.IntPtr NativeFieldInfoPtr_listChars;

		private static readonly System.IntPtr NativeFieldInfoPtr_isTanSat;

		private static readonly System.IntPtr NativeFieldInfoPtr_timeFixMapError;

		private static readonly System.IntPtr NativeFieldInfoPtr_LastPetInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastSetHs;

		private static readonly System.IntPtr NativeFieldInfoPtr_sethoisinh;

		private static readonly System.IntPtr NativeMethodInfoPtr_AutoAk_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ChatVip_Public_Static_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetIDMap_Public_Static_Int32_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_chatVip_Public_Static_Void_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Paint_Public_Static_Void_mGraphics_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_paintBoss_Public_Static_Void_mGraphics_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getMapNames_Public_Static_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getTimess_Public_Static_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getTimeAgo_Public_Static_String_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_rgpFlag_Private_Static_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PaintCharInMap_Public_Static_Void_mGraphics_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TanSat_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AutoFocus_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_checkMapError_Public_Static_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getYGround_Public_Static_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_drawString_Private_Static_Void_mGraphics_String_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_PaintInfoMod_Public_Static_Void_mGraphics_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_chat_Public_Static_Boolean_String_0;

		public unsafe static List<string> strBossAppeared
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_strBossAppeared, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_strBossAppeared, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe static List<BossChat> bosschats
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bosschats, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BossChat>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bosschats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe static bool isPaintboss
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintboss, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintboss, (void*)(&flag));
			}
		}

		public unsafe static bool isPaintChar
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPaintChar, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPaintChar, (void*)(&flag));
			}
		}

		public unsafe static bool iscdt
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iscdt, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iscdt, (void*)(&flag));
			}
		}

		public unsafe static bool isAutoHoiSinh
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoHoiSinh, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoHoiSinh, (void*)(&flag));
			}
		}

		public unsafe static bool isAk
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAk, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAk, (void*)(&flag));
			}
		}

		public unsafe static bool isAutoFocus
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoFocus, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoFocus, (void*)(&flag));
			}
		}

		public unsafe static long lastak
		{
			get
			{
				Unsafe.SkipInit(out long result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastak, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastak, (void*)(&num));
			}
		}

		public unsafe static string ListMap
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ListMap, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ListMap, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
			}
		}

		public unsafe static Il2CppStringArray MapNames
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MapNames, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MapNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe static MyVector bossVip
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bossVip, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bossVip, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
			}
		}

		public unsafe static List<Il2Cpp.Char> listChars
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listChars, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2Cpp.Char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe static bool isTanSat
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTanSat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTanSat, (void*)(&flag));
			}
		}

		public unsafe static long timeFixMapError
		{
			get
			{
				Unsafe.SkipInit(out long result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeFixMapError, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeFixMapError, (void*)(&num));
			}
		}

		public unsafe static long LastPetInfo
		{
			get
			{
				Unsafe.SkipInit(out long result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LastPetInfo, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LastPetInfo, (void*)(&num));
			}
		}

		public unsafe static long lastSetHs
		{
			get
			{
				Unsafe.SkipInit(out long result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastSetHs, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastSetHs, (void*)(&num));
			}
		}

		public unsafe static bool sethoisinh
		{
			get
			{
				Unsafe.SkipInit(out bool result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sethoisinh, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sethoisinh, (void*)(&flag));
			}
		}

		static aaMod()
		{
			Il2CppClassPointerStore<aaMod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, "aaMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<aaMod>.NativeClassPtr);
			NativeFieldInfoPtr_strBossAppeared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "strBossAppeared");
			NativeFieldInfoPtr_bosschats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "bosschats");
			NativeFieldInfoPtr_isPaintboss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "isPaintboss");
			NativeFieldInfoPtr_isPaintChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "isPaintChar");
			NativeFieldInfoPtr_iscdt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "iscdt");
			NativeFieldInfoPtr_isAutoHoiSinh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "isAutoHoiSinh");
			NativeFieldInfoPtr_isAk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "isAk");
			NativeFieldInfoPtr_isAutoFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "isAutoFocus");
			NativeFieldInfoPtr_lastak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "lastak");
			NativeFieldInfoPtr_ListMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "ListMap");
			NativeFieldInfoPtr_MapNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "MapNames");
			NativeFieldInfoPtr_bossVip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "bossVip");
			NativeFieldInfoPtr_listChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "listChars");
			NativeFieldInfoPtr_isTanSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "isTanSat");
			NativeFieldInfoPtr_timeFixMapError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "timeFixMapError");
			NativeFieldInfoPtr_LastPetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "LastPetInfo");
			NativeFieldInfoPtr_lastSetHs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "lastSetHs");
			NativeFieldInfoPtr_sethoisinh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<aaMod>.NativeClassPtr, "sethoisinh");
			NativeMethodInfoPtr_AutoAk_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666676);
			NativeMethodInfoPtr_ChatVip_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666677);
			NativeMethodInfoPtr_GetIDMap_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666678);
			NativeMethodInfoPtr_chatVip_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666679);
			NativeMethodInfoPtr_Paint_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666680);
			NativeMethodInfoPtr_paintBoss_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666681);
			NativeMethodInfoPtr_getMapNames_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666682);
			NativeMethodInfoPtr_getTimess_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666683);
			NativeMethodInfoPtr_getTimeAgo_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666684);
			NativeMethodInfoPtr_rgpFlag_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666685);
			NativeMethodInfoPtr_PaintCharInMap_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666686);
			NativeMethodInfoPtr_TanSat_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666687);
			NativeMethodInfoPtr_AutoFocus_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666688);
			NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666689);
			NativeMethodInfoPtr_checkMapError_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666690);
			NativeMethodInfoPtr_getYGround_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666691);
			NativeMethodInfoPtr_drawString_Private_Static_Void_mGraphics_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666692);
			NativeMethodInfoPtr_PaintInfoMod_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666693);
			NativeMethodInfoPtr_chat_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<aaMod>.NativeClassPtr, 100666694);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117526, RefRangeEnd = 117527, XrefRangeStart = 117492, XrefRangeEnd = 117526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoAk()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoAk_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117527, XrefRangeEnd = 117576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ChatVip(string text)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChatVip_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117576, XrefRangeEnd = 117588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetIDMap(string mapName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mapName);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIDMap_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117588, XrefRangeEnd = 117608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void chatVip(string chatVip)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(chatVip);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatVip_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117690, RefRangeEnd = 117692, XrefRangeStart = 117608, XrefRangeEnd = 117690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Paint(mGraphics g)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Paint_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117713, RefRangeEnd = 117714, XrefRangeStart = 117692, XrefRangeEnd = 117713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void paintBoss(mGraphics g)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintBoss_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117714, XrefRangeEnd = 117718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getMapNames(int mapid)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapid);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMapNames_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117718, XrefRangeEnd = 117740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getTimess()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTimess_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117740, XrefRangeEnd = 117751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		public unsafe static int rgpFlag(int flag)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&flag);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rgpFlag_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117864, RefRangeEnd = 117865, XrefRangeStart = 117751, XrefRangeEnd = 117864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PaintCharInMap(mGraphics g)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintCharInMap_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117865, XrefRangeEnd = 117875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TanSat()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TanSat_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117901, RefRangeEnd = 117902, XrefRangeStart = 117875, XrefRangeEnd = 117901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AutoFocus()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AutoFocus_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118048, RefRangeEnd = 118049, XrefRangeStart = 117902, XrefRangeEnd = 118048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Update()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118049, XrefRangeEnd = 118057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool checkMapError(int x)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkMapError_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118057, XrefRangeEnd = 118061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int getYGround(int x)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&x);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getYGround_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 118066, RefRangeEnd = 118070, XrefRangeStart = 118061, XrefRangeEnd = 118066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void drawString(mGraphics g, string st, int x, int y)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(st);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_drawString_Private_Static_Void_mGraphics_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118103, RefRangeEnd = 118104, XrefRangeStart = 118070, XrefRangeEnd = 118103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PaintInfoMod(mGraphics g)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintInfoMod_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118104, XrefRangeEnd = 118152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool chat(string chat)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(chat);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chat_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		public aaMod(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_isSP;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDT;

	private static readonly System.IntPtr NativeFieldInfoPtr_HiddenInfoItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_i;

	private static readonly System.IntPtr NativeFieldInfoPtr_gdh;

	private static readonly System.IntPtr NativeMethodInfoPtr_PaintTT_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetTF_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InfoAdd_Private_Static_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowCommand_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateKey_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_NQMPMain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindItemBag_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Paint_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool isSP
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isSP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isSP, (void*)(&flag));
		}
	}

	public unsafe static bool isDT
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isDT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isDT, (void*)(&flag));
		}
	}

	public unsafe static bool HiddenInfoItem
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HiddenInfoItem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HiddenInfoItem, (void*)(&flag));
		}
	}

	public unsafe static NQMPMain i
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_i, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NQMPMain>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_i, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nQMPMain));
		}
	}

	public unsafe static bool gdh
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gdh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gdh, (void*)(&flag));
		}
	}

	static NQMPMain()
	{
		Il2CppClassPointerStore<NQMPMain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NQMP", "NQMPMain");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr);
		NativeFieldInfoPtr_isSP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, "isSP");
		NativeFieldInfoPtr_isDT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, "isDT");
		NativeFieldInfoPtr_HiddenInfoItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, "HiddenInfoItem");
		NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, "i");
		NativeFieldInfoPtr_gdh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, "gdh");
		NativeMethodInfoPtr_PaintTT_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666655);
		NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666656);
		NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666657);
		NativeMethodInfoPtr_ResetTF_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666658);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666659);
		NativeMethodInfoPtr_InfoAdd_Private_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666660);
		NativeMethodInfoPtr_ShowCommand_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666661);
		NativeMethodInfoPtr_UpdateKey_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666662);
		NativeMethodInfoPtr_gI_Public_Static_NQMPMain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666663);
		NativeMethodInfoPtr_FindItemBag_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666664);
		NativeMethodInfoPtr_Paint_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666665);
		NativeMethodInfoPtr_UseItem_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666666);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr, 100666667);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118235, RefRangeEnd = 118236, XrefRangeStart = 118152, XrefRangeEnd = 118235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PaintTT(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PaintTT_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onCancelChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onChatFromMe(string text, string to)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(to);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118236, XrefRangeEnd = 118254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetTF()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetTF_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118254, XrefRangeEnd = 118304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void perform(int idAction, Il2CppSystem.Object p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&idAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118315, RefRangeEnd = 118316, XrefRangeStart = 118304, XrefRangeEnd = 118315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InfoAdd(string str, bool active)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &active;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InfoAdd_Private_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118464, RefRangeEnd = 118465, XrefRangeStart = 118316, XrefRangeEnd = 118464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowCommand()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowCommand_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118465, XrefRangeEnd = 118516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateKey()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateKey_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 118530, RefRangeEnd = 118534, XrefRangeStart = 118516, XrefRangeEnd = 118530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NQMPMain gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_NQMPMain_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NQMPMain>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118534, XrefRangeEnd = 118542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FindItemBag(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindItemBag_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118586, RefRangeEnd = 118587, XrefRangeStart = 118542, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Paint(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Paint_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 118600, RefRangeEnd = 118606, XrefRangeStart = 118587, XrefRangeEnd = 118600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UseItem(int templateId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&templateId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NQMPMain()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NQMPMain>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public NQMPMain(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
