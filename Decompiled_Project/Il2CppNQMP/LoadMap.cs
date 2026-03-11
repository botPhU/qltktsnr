using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppNQMP;

public class LoadMap : Il2CppSystem.Object
{
	public class NextMap : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_MapID;

		private static readonly System.IntPtr NativeFieldInfoPtr_Npc;

		private static readonly System.IntPtr NativeFieldInfoPtr_Index;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GotoMap_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetWayPoint_Public_Waypoint_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMapName_Public_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Void_Waypoint_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetMapName_Public_String_PopUp_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TeleportTo_Public_Void_Int32_Int32_0;

		public unsafe int MapID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MapID)) = num;
			}
		}

		public unsafe int Npc
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Npc);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Npc)) = num;
			}
		}

		public unsafe int Index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Index)) = num;
			}
		}

		static NextMap()
		{
			Il2CppClassPointerStore<NextMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "NextMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NextMap>.NativeClassPtr);
			NativeFieldInfoPtr_MapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextMap>.NativeClassPtr, "MapID");
			NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextMap>.NativeClassPtr, "Npc");
			NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextMap>.NativeClassPtr, "Index");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextMap>.NativeClassPtr, 100666648);
			NativeMethodInfoPtr_GotoMap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextMap>.NativeClassPtr, 100666649);
			NativeMethodInfoPtr_GetWayPoint_Public_Waypoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextMap>.NativeClassPtr, 100666650);
			NativeMethodInfoPtr_GetMapName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextMap>.NativeClassPtr, 100666651);
			NativeMethodInfoPtr_Enter_Public_Void_Waypoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextMap>.NativeClassPtr, 100666652);
			NativeMethodInfoPtr_GetMapName_Public_String_PopUp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextMap>.NativeClassPtr, 100666653);
			NativeMethodInfoPtr_TeleportTo_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextMap>.NativeClassPtr, 100666654);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 83248, RefRangeEnd = 83258, XrefRangeStart = 83248, XrefRangeEnd = 83258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NextMap(int a, int b, int c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NextMap>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&a);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115816, RefRangeEnd = 115817, XrefRangeStart = 115813, XrefRangeEnd = 115816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GotoMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GotoMap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115844, RefRangeEnd = 115845, XrefRangeStart = 115817, XrefRangeEnd = 115844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Waypoint GetWayPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWayPoint_Public_Waypoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Waypoint>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115845, XrefRangeEnd = 115849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMapName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMapName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115874, RefRangeEnd = 115875, XrefRangeStart = 115849, XrefRangeEnd = 115874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enter(Waypoint a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enter_Public_Void_Waypoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115875, XrefRangeEnd = 115887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMapName(PopUp a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMapName_Public_String_PopUp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115916, RefRangeEnd = 115917, XrefRangeStart = 115887, XrefRangeEnd = 115916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TeleportTo(int a, int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&a);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TeleportTo_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public NextMap(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_LinkMaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlanetDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_isXmaping;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMapGoTo;

	private static readonly System.IntPtr NativeFieldInfoPtr_wayPointMapLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_wayPointMapCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_wayPointMapRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEatChicken;

	private static readonly System.IntPtr NativeFieldInfoPtr_isHarvestPean;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUseCapsule;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUsingCapsule;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOpeningPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeOpenedPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSaveData;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastWaitTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMapNamek;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMapXayda;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMapTraiDat;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMapTuongLai;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMapCold;

	private static readonly System.IntPtr NativeFieldInfoPtr_idMapNappa;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInstance_Public_Static_LoadMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowPlanetMenu_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMapsMenu_Private_Static_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Xmap_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetStatus_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartRunToMapId_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadMapLeft_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadMapCenter_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadMapRight_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadData_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveData_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadLinkMapsXmap_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadNPCLinkMapsXmap_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPlanetXmap_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddLinkMapsXmap_Private_Static_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNPCLinkMapsXmap_Private_Static_Void_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Goto_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindWay_Private_Static_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindWay_Private_Static_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hasWayGoFutureAndBack_Private_Static_Boolean_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hasWayGoToColdMap_Private_Static_Boolean_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMapName_Private_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadWaypointsInMap_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetYGround_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSavedWaypoints_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNRDMap_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isFutureMap_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNRD_Private_Static_Boolean_ItemMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadMap2_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isClanXmap_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static LoadMap _Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoadMap>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loadMap));
		}
	}

	public unsafe static Dictionary<int, List<NextMap>> LinkMaps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LinkMaps, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<NextMap>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LinkMaps, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static Dictionary<string, Il2CppStructArray<int>> PlanetDictionary
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlanetDictionary, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlanetDictionary, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static bool isXmaping
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isXmaping, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isXmaping, (void*)(&flag));
		}
	}

	public unsafe static int idMapGoTo
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idMapGoTo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idMapGoTo, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> wayPointMapLeft
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wayPointMapLeft, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wayPointMapLeft, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> wayPointMapCenter
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wayPointMapCenter, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wayPointMapCenter, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> wayPointMapRight
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_wayPointMapRight, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_wayPointMapRight, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static bool isEatChicken
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isEatChicken, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isEatChicken, (void*)(&flag));
		}
	}

	public unsafe static bool isHarvestPean
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isHarvestPean, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isHarvestPean, (void*)(&flag));
		}
	}

	public unsafe static bool isUseCapsule
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isUseCapsule, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isUseCapsule, (void*)(&flag));
		}
	}

	public unsafe static bool isUsingCapsule
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isUsingCapsule, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isUsingCapsule, (void*)(&flag));
		}
	}

	public unsafe static bool isOpeningPanel
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isOpeningPanel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isOpeningPanel, (void*)(&flag));
		}
	}

	public unsafe static long lastTimeOpenedPanel
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeOpenedPanel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeOpenedPanel, (void*)(&num));
		}
	}

	public unsafe static bool isSaveData
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isSaveData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isSaveData, (void*)(&flag));
		}
	}

	public unsafe static long lastWaitTime
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastWaitTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastWaitTime, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> idMapNamek
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idMapNamek, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idMapNamek, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> idMapXayda
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idMapXayda, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idMapXayda, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> idMapTraiDat
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idMapTraiDat, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idMapTraiDat, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> idMapTuongLai
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idMapTuongLai, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idMapTuongLai, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> idMapCold
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idMapCold, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idMapCold, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> idMapNappa
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_idMapNappa, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_idMapNappa, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	static LoadMap()
	{
		Il2CppClassPointerStore<LoadMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NQMP", "LoadMap");
		NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "_Instance");
		NativeFieldInfoPtr_LinkMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "LinkMaps");
		NativeFieldInfoPtr_PlanetDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "PlanetDictionary");
		NativeFieldInfoPtr_isXmaping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "isXmaping");
		NativeFieldInfoPtr_idMapGoTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "idMapGoTo");
		NativeFieldInfoPtr_wayPointMapLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "wayPointMapLeft");
		NativeFieldInfoPtr_wayPointMapCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "wayPointMapCenter");
		NativeFieldInfoPtr_wayPointMapRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "wayPointMapRight");
		NativeFieldInfoPtr_isEatChicken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "isEatChicken");
		NativeFieldInfoPtr_isHarvestPean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "isHarvestPean");
		NativeFieldInfoPtr_isUseCapsule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "isUseCapsule");
		NativeFieldInfoPtr_isUsingCapsule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "isUsingCapsule");
		NativeFieldInfoPtr_isOpeningPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "isOpeningPanel");
		NativeFieldInfoPtr_lastTimeOpenedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "lastTimeOpenedPanel");
		NativeFieldInfoPtr_isSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "isSaveData");
		NativeFieldInfoPtr_lastWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "lastWaitTime");
		NativeFieldInfoPtr_idMapNamek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "idMapNamek");
		NativeFieldInfoPtr_idMapXayda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "idMapXayda");
		NativeFieldInfoPtr_idMapTraiDat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "idMapTraiDat");
		NativeFieldInfoPtr_idMapTuongLai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "idMapTuongLai");
		NativeFieldInfoPtr_idMapCold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "idMapCold");
		NativeFieldInfoPtr_idMapNappa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, "idMapNappa");
		NativeMethodInfoPtr_getInstance_Public_Static_LoadMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666612);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666613);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_ShowPlanetMenu_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_ShowMapsMenu_Private_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_Xmap_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_ResetStatus_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_StartRunToMapId_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_LoadMapLeft_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr_LoadMapCenter_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666622);
		NativeMethodInfoPtr_LoadMapRight_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666623);
		NativeMethodInfoPtr_LoadData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666624);
		NativeMethodInfoPtr_SaveData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666625);
		NativeMethodInfoPtr_LoadLinkMapsXmap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666626);
		NativeMethodInfoPtr_LoadNPCLinkMapsXmap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666627);
		NativeMethodInfoPtr_AddPlanetXmap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666628);
		NativeMethodInfoPtr_AddLinkMapsXmap_Private_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666629);
		NativeMethodInfoPtr_AddNPCLinkMapsXmap_Private_Static_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666630);
		NativeMethodInfoPtr_Goto_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666631);
		NativeMethodInfoPtr_FindWay_Private_Static_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666632);
		NativeMethodInfoPtr_FindWay_Private_Static_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666633);
		NativeMethodInfoPtr_hasWayGoFutureAndBack_Private_Static_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666634);
		NativeMethodInfoPtr_hasWayGoToColdMap_Private_Static_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666635);
		NativeMethodInfoPtr_GetMapName_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666636);
		NativeMethodInfoPtr_LoadWaypointsInMap_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666637);
		NativeMethodInfoPtr_GetYGround_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666638);
		NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666639);
		NativeMethodInfoPtr_ResetSavedWaypoints_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666640);
		NativeMethodInfoPtr_isNRDMap_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666641);
		NativeMethodInfoPtr_isFutureMap_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666642);
		NativeMethodInfoPtr_isNRD_Private_Static_Boolean_ItemMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666643);
		NativeMethodInfoPtr_LoadMap2_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666644);
		NativeMethodInfoPtr_isClanXmap_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666645);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadMap>.NativeClassPtr, 100666647);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115931, RefRangeEnd = 115938, XrefRangeStart = 115917, XrefRangeEnd = 115931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LoadMap getInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInstance_Public_Static_LoadMap_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LoadMap>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116073, RefRangeEnd = 116074, XrefRangeStart = 115938, XrefRangeEnd = 116073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116074, XrefRangeEnd = 116196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116196, XrefRangeEnd = 116272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116309, RefRangeEnd = 116310, XrefRangeStart = 116272, XrefRangeEnd = 116309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowPlanetMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowPlanetMenu_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116347, RefRangeEnd = 116348, XrefRangeStart = 116310, XrefRangeEnd = 116347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMapsMenu(Il2CppStructArray<int> a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMapsMenu_Private_Static_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116348, XrefRangeEnd = 116353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Xmap(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Xmap_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116353, XrefRangeEnd = 116359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetStatus()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetStatus_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116447, RefRangeEnd = 116448, XrefRangeStart = 116359, XrefRangeEnd = 116447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartRunToMapId(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartRunToMapId_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116448, XrefRangeEnd = 116452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadMapLeft()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadMapLeft_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116452, XrefRangeEnd = 116456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadMapCenter()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadMapCenter_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116456, XrefRangeEnd = 116460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadMapRight()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadMapRight_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116498, RefRangeEnd = 116499, XrefRangeStart = 116460, XrefRangeEnd = 116498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadData_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116499, XrefRangeEnd = 116518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveData_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116518, XrefRangeEnd = 116653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadLinkMapsXmap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadLinkMapsXmap_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116653, XrefRangeEnd = 116682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadNPCLinkMapsXmap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadNPCLinkMapsXmap_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116682, XrefRangeEnd = 116717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddPlanetXmap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPlanetXmap_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 116760, RefRangeEnd = 116791, XrefRangeStart = 116717, XrefRangeEnd = 116760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddLinkMapsXmap([Optional] Il2CppStructArray<int> a)
	{
		if (a == null)
		{
			a = new Il2CppStructArray<int>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddLinkMapsXmap_Private_Static_Void_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 116823, RefRangeEnd = 116849, XrefRangeStart = 116791, XrefRangeEnd = 116823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddNPCLinkMapsXmap(int a, int b, int c, int d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNPCLinkMapsXmap_Private_Static_Void_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116849, XrefRangeEnd = 116884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Goto(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Goto_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116884, XrefRangeEnd = 116897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> FindWay(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindWay_Private_Static_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116959, RefRangeEnd = 116962, XrefRangeStart = 116897, XrefRangeEnd = 116959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> FindWay(int a, Il2CppStructArray<int> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindWay_Private_Static_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116962, XrefRangeEnd = 116963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool hasWayGoFutureAndBack(Il2CppStructArray<int> a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hasWayGoFutureAndBack_Private_Static_Boolean_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116963, XrefRangeEnd = 116964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool hasWayGoToColdMap(Il2CppStructArray<int> a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hasWayGoToColdMap_Private_Static_Boolean_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116986, RefRangeEnd = 116987, XrefRangeStart = 116964, XrefRangeEnd = 116986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetMapName(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMapName_Private_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117035, RefRangeEnd = 117036, XrefRangeStart = 116987, XrefRangeEnd = 117035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadWaypointsInMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadWaypointsInMap_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 117040, RefRangeEnd = 117046, XrefRangeStart = 117036, XrefRangeEnd = 117040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetYGround(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetYGround_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 117075, RefRangeEnd = 117079, XrefRangeStart = 117046, XrefRangeEnd = 117075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TeleportTo(int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117079, XrefRangeEnd = 117098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetSavedWaypoints()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSavedWaypoints_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115336, RefRangeEnd = 115337, XrefRangeStart = 115336, XrefRangeEnd = 115337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isNRDMap(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNRDMap_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117098, XrefRangeEnd = 117105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isFutureMap(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isFutureMap_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool isNRD(ItemMap a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNRD_Private_Static_Boolean_ItemMap_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 117177, RefRangeEnd = 117183, XrefRangeStart = 117105, XrefRangeEnd = 117177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadMap2(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadMap2_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117235, RefRangeEnd = 117236, XrefRangeStart = 117183, XrefRangeEnd = 117235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void isClanXmap(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isClanXmap_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadMap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadMap>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public static void AddLinkMapsXmap(params int[] a)
	{
		AddLinkMapsXmap(new Il2CppStructArray<int>(a));
	}

	public LoadMap(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
