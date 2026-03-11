using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public class ServerBOSS : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("ServerBOSS+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__17_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__17_2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortBossDictionary_b__17_0_Internal_String_KeyValuePair_2_String_List_1_ServerBOSS_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortBossDictionary_b__17_1_Internal_String_KeyValuePair_2_String_List_1_ServerBOSS_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SortBossDictionary_b__17_2_Internal_List_1_ServerBOSS_KeyValuePair_2_String_List_1_ServerBOSS_0;

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

		public unsafe static Il2CppSystem.Func<KeyValuePair<string, List<ServerBOSS>>, string> __9__17_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<string, List<ServerBOSS>>, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__17_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<KeyValuePair<string, List<ServerBOSS>>, string> __9__17_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<string, List<ServerBOSS>>, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__17_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		public unsafe static Il2CppSystem.Func<KeyValuePair<string, List<ServerBOSS>>, List<ServerBOSS>> __9__17_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<string, List<ServerBOSS>>, List<ServerBOSS>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__17_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)func));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__17_0");
			NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__17_1");
			NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__17_2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664385);
			NativeMethodInfoPtr__SortBossDictionary_b__17_0_Internal_String_KeyValuePair_2_String_List_1_ServerBOSS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664386);
			NativeMethodInfoPtr__SortBossDictionary_b__17_1_Internal_String_KeyValuePair_2_String_List_1_ServerBOSS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664387);
			NativeMethodInfoPtr__SortBossDictionary_b__17_2_Internal_List_1_ServerBOSS_KeyValuePair_2_String_List_1_ServerBOSS_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664388);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51779, XrefRangeEnd = 51780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _SortBossDictionary_b__17_0(KeyValuePair<string, List<ServerBOSS>> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kvp));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortBossDictionary_b__17_0_Internal_String_KeyValuePair_2_String_List_1_ServerBOSS_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51780, XrefRangeEnd = 51781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _SortBossDictionary_b__17_1(KeyValuePair<string, List<ServerBOSS>> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kvp));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortBossDictionary_b__17_1_Internal_String_KeyValuePair_2_String_List_1_ServerBOSS_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 51781, XrefRangeEnd = 51782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ServerBOSS> _SortBossDictionary_b__17_2(KeyValuePair<string, List<ServerBOSS>> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)kvp));
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SortBossDictionary_b__17_2_Internal_List_1_ServerBOSS_KeyValuePair_2_String_List_1_ServerBOSS_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ServerBOSS>>(intPtr) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_endTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerName;

	private static readonly System.IntPtr NativeFieldInfoPtr_bossName;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapName;

	private static readonly System.IntPtr NativeFieldInfoPtr_HAS_NOT_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_BossDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bosses;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addBoss_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPlayerInfo_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBOSSInfo_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTimeInfo_Private_String_Nullable_1_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getStartTimeInfo_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEndTimeInfo_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getMapName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPlayerName_Public_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortBossDictionary_Public_Static_Void_0;

	public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTime> startTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime);
			return new Il2CppSystem.Nullable<Il2CppSystem.DateTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTime>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTime>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTime> endTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime);
			return new Il2CppSystem.Nullable<Il2CppSystem.DateTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTime>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nullable)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTime>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string playerName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerName)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string bossName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bossName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bossName)), IL2CPP.ManagedStringToIl2Cpp(text));
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

	public unsafe static string HAS_NOT_INFO
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HAS_NOT_INFO, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HAS_NOT_INFO, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static Dictionary<string, List<ServerBOSS>> BossDictionary
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BossDictionary, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, List<ServerBOSS>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BossDictionary, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe List<ServerBOSS> Bosses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bosses);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ServerBOSS>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bosses)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static ServerBOSS()
	{
		Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ServerBOSS");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr);
		NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "startTime");
		NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "endTime");
		NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "playerName");
		NativeFieldInfoPtr_bossName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "bossName");
		NativeFieldInfoPtr_mapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "mapName");
		NativeFieldInfoPtr_HAS_NOT_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "HAS_NOT_INFO");
		NativeFieldInfoPtr_BossDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "BossDictionary");
		NativeFieldInfoPtr_Bosses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, "Bosses");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664373);
		NativeMethodInfoPtr_addBoss_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664374);
		NativeMethodInfoPtr_getPlayerInfo_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664375);
		NativeMethodInfoPtr_getBOSSInfo_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664376);
		NativeMethodInfoPtr_getTimeInfo_Private_String_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664377);
		NativeMethodInfoPtr_getStartTimeInfo_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664378);
		NativeMethodInfoPtr_getEndTimeInfo_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664379);
		NativeMethodInfoPtr_getMapName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664380);
		NativeMethodInfoPtr_getPlayerName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664381);
		NativeMethodInfoPtr_SortBossDictionary_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr, 100664382);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51790, RefRangeEnd = 51791, XrefRangeStart = 51782, XrefRangeEnd = 51790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ServerBOSS()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerBOSS>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51801, RefRangeEnd = 51802, XrefRangeStart = 51791, XrefRangeEnd = 51801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void addBoss(string chatVip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chatVip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addBoss_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51862, XrefRangeStart = 51802, XrefRangeEnd = 51861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getPlayerInfo(string chatVip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chatVip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPlayerInfo_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51918, RefRangeEnd = 51919, XrefRangeStart = 51862, XrefRangeEnd = 51918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getBOSSInfo(string chatVip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chatVip);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBOSSInfo_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 51970, RefRangeEnd = 51972, XrefRangeStart = 51919, XrefRangeEnd = 51970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getTimeInfo(Il2CppSystem.Nullable<Il2CppSystem.DateTime> dateTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)dateTime));
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTimeInfo_Private_String_Nullable_1_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51973, RefRangeEnd = 51974, XrefRangeStart = 51972, XrefRangeEnd = 51973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getStartTimeInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getStartTimeInfo_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51975, RefRangeEnd = 51976, XrefRangeStart = 51974, XrefRangeEnd = 51975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getEndTimeInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEndTimeInfo_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51978, RefRangeEnd = 51979, XrefRangeStart = 51976, XrefRangeEnd = 51978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getMapName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMapName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 51981, RefRangeEnd = 51982, XrefRangeStart = 51979, XrefRangeEnd = 51981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string getPlayerName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPlayerName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52062, RefRangeEnd = 52063, XrefRangeStart = 51982, XrefRangeEnd = 52062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SortBossDictionary()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortBossDictionary_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ServerBOSS(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
