using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2Cpp;

public class TileMap : Il2CppSystem.Object
{
	public class MapData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_mapId;

		private static readonly System.IntPtr NativeFieldInfoPtr_tmw;

		private static readonly System.IntPtr NativeFieldInfoPtr_tmh;

		private static readonly System.IntPtr NativeFieldInfoPtr_maps;

		private static readonly System.IntPtr NativeFieldInfoPtr_types;

		private static readonly System.IntPtr NativeMethodInfoPtr_getMap_Public_Static_MapData_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int mapId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mapId)) = num;
			}
		}

		public unsafe int tmw
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmw);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmw)) = num;
			}
		}

		public unsafe int tmh
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmh);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmh)) = num;
			}
		}

		public unsafe Il2CppStructArray<int> maps
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maps);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe Il2CppStructArray<int> types
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_types);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_types)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		static MapData()
		{
			Il2CppClassPointerStore<MapData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "MapData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapData>.NativeClassPtr);
			NativeFieldInfoPtr_mapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "mapId");
			NativeFieldInfoPtr_tmw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "tmw");
			NativeFieldInfoPtr_tmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "tmh");
			NativeFieldInfoPtr_maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "maps");
			NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapData>.NativeClassPtr, "types");
			NativeMethodInfoPtr_getMap_Public_Static_MapData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapData>.NativeClassPtr, 100666432);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapData>.NativeClassPtr, 100666433);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111373, RefRangeEnd = 111374, XrefRangeStart = 111359, XrefRangeEnd = 111373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MapData getMap(int mapId)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&mapId);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getMap_Public_Static_MapData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MapData>(intPtr) : null;
		}

		[CallerCount(707)]
		[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MapData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_T_EMPTY;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_TOP;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_LEFT;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_RIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_TREE;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_WATERFALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_WATERFLOW;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_TOPFALL;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_OUTSIDE;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_DOWN1PIXEL;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_BRIDGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_UNDERWATER;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_SOLIDGROUND;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_BOTTOM;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_DIE;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_HEBI;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_BANG;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_JUM8;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_NT0;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_NT1;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_CENTER;

	private static readonly System.IntPtr NativeFieldInfoPtr_tmw;

	private static readonly System.IntPtr NativeFieldInfoPtr_tmh;

	private static readonly System.IntPtr NativeFieldInfoPtr_pxw;

	private static readonly System.IntPtr NativeFieldInfoPtr_pxh;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTileID;

	private static readonly System.IntPtr NativeFieldInfoPtr_maps;

	private static readonly System.IntPtr NativeFieldInfoPtr_types;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgTileSmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgMiniMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgWaterfall;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgTopWaterfall;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgWaterflow;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgWaterlowN;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgWaterlowN2;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgWaterF;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgLeaf;

	private static readonly System.IntPtr NativeFieldInfoPtr_size;

	private static readonly System.IntPtr NativeFieldInfoPtr_bx;

	private static readonly System.IntPtr NativeFieldInfoPtr_dbx;

	private static readonly System.IntPtr NativeFieldInfoPtr_fx;

	private static readonly System.IntPtr NativeFieldInfoPtr_dfx;

	private static readonly System.IntPtr NativeFieldInfoPtr_instruction;

	private static readonly System.IntPtr NativeFieldInfoPtr_iX;

	private static readonly System.IntPtr NativeFieldInfoPtr_iY;

	private static readonly System.IntPtr NativeFieldInfoPtr_iW;

	private static readonly System.IntPtr NativeFieldInfoPtr_iCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMapDouble;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapName;

	private static readonly System.IntPtr NativeFieldInfoPtr_versionMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastBgID;

	private static readonly System.IntPtr NativeFieldInfoPtr_zoneID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgType;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastType;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_planetID;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPlanetId;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeTranMini;

	private static readonly System.IntPtr NativeFieldInfoPtr_vGo;

	private static readonly System.IntPtr NativeFieldInfoPtr_vItemBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_vCurrItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAP_NORMAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_bong;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRAIDAT_DOINUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRAIDAT_RUNG;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRAIDAT_DAORUA;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRAIDAT_DADO;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAMEK_THUNGLUNG;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAMEK_DOINUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAMEK_RUNG;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAMEK_DAO;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAYAI_DOINUI;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAYAI_RUNG;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAYAI_CITY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SAYAI_NIGHT;

	private static readonly System.IntPtr NativeFieldInfoPtr_KAMISAMA;

	private static readonly System.IntPtr NativeFieldInfoPtr_TIME_ROOM;

	private static readonly System.IntPtr NativeFieldInfoPtr_HELL;

	private static readonly System.IntPtr NativeFieldInfoPtr_BEERUS;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_vObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_offlineId;

	private static readonly System.IntPtr NativeFieldInfoPtr_highterId;

	private static readonly System.IntPtr NativeFieldInfoPtr_toOfflineId;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileType;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_imgLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeMiniMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssx;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssxe;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssy;

	private static readonly System.IntPtr NativeFieldInfoPtr_gssye;

	private static readonly System.IntPtr NativeFieldInfoPtr_countx;

	private static readonly System.IntPtr NativeFieldInfoPtr_county;

	private static readonly System.IntPtr NativeFieldInfoPtr_colorMini;

	private static readonly System.IntPtr NativeFieldInfoPtr_yWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapDatas;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadBg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isVoDaiMap_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isTrainingMap_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mapPhuBang_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBIById_Public_Static_BgItem_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isOfflineMap_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isHighterMap_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isToOfflineMap_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeTilemap_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadTileCreatChar_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isExistMoreOne_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadTileImage_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTile_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadMap_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isInAirMap_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isDoubleMap_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTile_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintTile_Public_Static_Void_mGraphics_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintTile_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintTilemapLOW_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintTilemap_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isWaterEff_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintOutTilemap_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadMapFromResource_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadMaptoRMS_Public_Static_MapData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveMaptoRMS_Public_Static_Void_MapData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tileAt_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tileTypeAt_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tileTypeAtPixel_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tileTypeAt_Public_Static_Boolean_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTileTypeAtPixel_Public_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setTileTypeAt_Public_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_killTileTypeAt_Public_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tileYofPixel_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_tileXofPixel_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadMainTile_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int T_EMPTY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_EMPTY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_EMPTY, (void*)(&num));
		}
	}

	public unsafe static int T_TOP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_TOP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_TOP, (void*)(&num));
		}
	}

	public unsafe static int T_LEFT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_LEFT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_LEFT, (void*)(&num));
		}
	}

	public unsafe static int T_RIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_RIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_RIGHT, (void*)(&num));
		}
	}

	public unsafe static int T_TREE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_TREE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_TREE, (void*)(&num));
		}
	}

	public unsafe static int T_WATERFALL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_WATERFALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_WATERFALL, (void*)(&num));
		}
	}

	public unsafe static int T_WATERFLOW
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_WATERFLOW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_WATERFLOW, (void*)(&num));
		}
	}

	public unsafe static int T_TOPFALL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_TOPFALL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_TOPFALL, (void*)(&num));
		}
	}

	public unsafe static int T_OUTSIDE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_OUTSIDE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_OUTSIDE, (void*)(&num));
		}
	}

	public unsafe static int T_DOWN1PIXEL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_DOWN1PIXEL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_DOWN1PIXEL, (void*)(&num));
		}
	}

	public unsafe static int T_BRIDGE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_BRIDGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_BRIDGE, (void*)(&num));
		}
	}

	public unsafe static int T_UNDERWATER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_UNDERWATER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_UNDERWATER, (void*)(&num));
		}
	}

	public unsafe static int T_SOLIDGROUND
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_SOLIDGROUND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_SOLIDGROUND, (void*)(&num));
		}
	}

	public unsafe static int T_BOTTOM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_BOTTOM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_BOTTOM, (void*)(&num));
		}
	}

	public unsafe static int T_DIE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_DIE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_DIE, (void*)(&num));
		}
	}

	public unsafe static int T_HEBI
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_HEBI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_HEBI, (void*)(&num));
		}
	}

	public unsafe static int T_BANG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_BANG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_BANG, (void*)(&num));
		}
	}

	public unsafe static int T_JUM8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_JUM8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_JUM8, (void*)(&num));
		}
	}

	public unsafe static int T_NT0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_NT0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_NT0, (void*)(&num));
		}
	}

	public unsafe static int T_NT1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_NT1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_NT1, (void*)(&num));
		}
	}

	public unsafe static int T_CENTER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_CENTER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_CENTER, (void*)(&num));
		}
	}

	public unsafe static int tmw
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tmw, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tmw, (void*)(&num));
		}
	}

	public unsafe static int tmh
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tmh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tmh, (void*)(&num));
		}
	}

	public unsafe static int pxw
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pxw, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pxw, (void*)(&num));
		}
	}

	public unsafe static int pxh
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pxh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pxh, (void*)(&num));
		}
	}

	public unsafe static int tileID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tileID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tileID, (void*)(&num));
		}
	}

	public unsafe static int lastTileID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTileID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTileID, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> maps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maps, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maps, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> types
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_types, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_types, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> imgTile
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgTile, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgTile, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgTileSmall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgTileSmall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgTileSmall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgMiniMap
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgMiniMap, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgMiniMap, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgWaterfall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgWaterfall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgWaterfall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgTopWaterfall
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgTopWaterfall, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgTopWaterfall, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgWaterflow
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgWaterflow, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgWaterflow, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgWaterlowN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgWaterlowN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgWaterlowN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgWaterlowN2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgWaterlowN2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgWaterlowN2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgWaterF
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgWaterF, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgWaterF, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static Image imgLeaf
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLeaf, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLeaf, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static sbyte size
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_size, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_size, (void*)(&b));
		}
	}

	public unsafe static int bx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bx, (void*)(&num));
		}
	}

	public unsafe static int dbx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dbx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dbx, (void*)(&num));
		}
	}

	public unsafe static int fx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fx, (void*)(&num));
		}
	}

	public unsafe static int dfx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dfx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dfx, (void*)(&num));
		}
	}

	public unsafe static Il2CppStringArray instruction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instruction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instruction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> iX
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iX, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iX, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> iY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> iW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iW, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iW, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int iCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_iCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_iCount, (void*)(&num));
		}
	}

	public unsafe static bool isMapDouble
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isMapDouble, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isMapDouble, (void*)(&flag));
		}
	}

	public unsafe static string mapName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mapName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mapName, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static sbyte versionMap
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_versionMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_versionMap, (void*)(&b));
		}
	}

	public unsafe static int mapID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mapID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mapID, (void*)(&num));
		}
	}

	public unsafe static int lastBgID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastBgID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastBgID, (void*)(&num));
		}
	}

	public unsafe static int zoneID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zoneID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zoneID, (void*)(&num));
		}
	}

	public unsafe static int bgID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgID, (void*)(&num));
		}
	}

	public unsafe static int bgType
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgType, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgType, (void*)(&num));
		}
	}

	public unsafe static int lastType
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastType, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastType, (void*)(&num));
		}
	}

	public unsafe static int typeMap
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeMap, (void*)(&num));
		}
	}

	public unsafe static sbyte planetID
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_planetID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_planetID, (void*)(&b));
		}
	}

	public unsafe static sbyte lastPlanetId
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastPlanetId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastPlanetId, (void*)(&b));
		}
	}

	public unsafe static long timeTranMini
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeTranMini, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeTranMini, (void*)(&num));
		}
	}

	public unsafe static MyVector vGo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vGo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vGo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vItemBg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vItemBg, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vItemBg, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static MyVector vCurrItem
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vCurrItem, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vCurrItem, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static Il2CppStringArray mapNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mapNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mapNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static sbyte MAP_NORMAL
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAP_NORMAL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAP_NORMAL, (void*)(&b));
		}
	}

	public unsafe static Image bong
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bong, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bong, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int TRAIDAT_DOINUI
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRAIDAT_DOINUI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRAIDAT_DOINUI, (void*)(&num));
		}
	}

	public unsafe static int TRAIDAT_RUNG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRAIDAT_RUNG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRAIDAT_RUNG, (void*)(&num));
		}
	}

	public unsafe static int TRAIDAT_DAORUA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRAIDAT_DAORUA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRAIDAT_DAORUA, (void*)(&num));
		}
	}

	public unsafe static int TRAIDAT_DADO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRAIDAT_DADO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRAIDAT_DADO, (void*)(&num));
		}
	}

	public unsafe static int NAMEK_THUNGLUNG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAMEK_THUNGLUNG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAMEK_THUNGLUNG, (void*)(&num));
		}
	}

	public unsafe static int NAMEK_DOINUI
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAMEK_DOINUI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAMEK_DOINUI, (void*)(&num));
		}
	}

	public unsafe static int NAMEK_RUNG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAMEK_RUNG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAMEK_RUNG, (void*)(&num));
		}
	}

	public unsafe static int NAMEK_DAO
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAMEK_DAO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAMEK_DAO, (void*)(&num));
		}
	}

	public unsafe static int SAYAI_DOINUI
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAYAI_DOINUI, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAYAI_DOINUI, (void*)(&num));
		}
	}

	public unsafe static int SAYAI_RUNG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAYAI_RUNG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAYAI_RUNG, (void*)(&num));
		}
	}

	public unsafe static int SAYAI_CITY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAYAI_CITY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAYAI_CITY, (void*)(&num));
		}
	}

	public unsafe static int SAYAI_NIGHT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SAYAI_NIGHT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SAYAI_NIGHT, (void*)(&num));
		}
	}

	public unsafe static int KAMISAMA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KAMISAMA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KAMISAMA, (void*)(&num));
		}
	}

	public unsafe static int TIME_ROOM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TIME_ROOM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TIME_ROOM, (void*)(&num));
		}
	}

	public unsafe static int HELL
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HELL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HELL, (void*)(&num));
		}
	}

	public unsafe static int BEERUS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BEERUS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BEERUS, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<Image> bgItem
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_bgItem, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_bgItem, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static MyVector vObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_vObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_vObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static Il2CppStructArray<int> offlineId
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_offlineId, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_offlineId, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> highterId
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_highterId, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_highterId, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> toOfflineId
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_toOfflineId, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_toOfflineId, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> tileType
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tileType, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tileType, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppReferenceArray<Il2CppStructArray<int>>> tileIndex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tileIndex, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<Il2CppStructArray<int>>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tileIndex, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Image imgLight
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_imgLight, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_imgLight, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)image));
		}
	}

	public unsafe static int sizeMiniMap
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sizeMiniMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sizeMiniMap, (void*)(&num));
		}
	}

	public unsafe static int gssx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssx, (void*)(&num));
		}
	}

	public unsafe static int gssxe
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssxe, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssxe, (void*)(&num));
		}
	}

	public unsafe static int gssy
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssy, (void*)(&num));
		}
	}

	public unsafe static int gssye
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gssye, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gssye, (void*)(&num));
		}
	}

	public unsafe static int countx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_countx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_countx, (void*)(&num));
		}
	}

	public unsafe static int county
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_county, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_county, (void*)(&num));
		}
	}

	public unsafe static Il2CppStructArray<int> colorMini
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_colorMini, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_colorMini, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int yWater
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_yWater, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_yWater, (void*)(&num));
		}
	}

	public unsafe static List<MapData> mapDatas
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mapDatas, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MapData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mapDatas, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	static TileMap()
	{
		Il2CppClassPointerStore<TileMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TileMap");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileMap>.NativeClassPtr);
		NativeFieldInfoPtr_T_EMPTY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_EMPTY");
		NativeFieldInfoPtr_T_TOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_TOP");
		NativeFieldInfoPtr_T_LEFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_LEFT");
		NativeFieldInfoPtr_T_RIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_RIGHT");
		NativeFieldInfoPtr_T_TREE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_TREE");
		NativeFieldInfoPtr_T_WATERFALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_WATERFALL");
		NativeFieldInfoPtr_T_WATERFLOW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_WATERFLOW");
		NativeFieldInfoPtr_T_TOPFALL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_TOPFALL");
		NativeFieldInfoPtr_T_OUTSIDE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_OUTSIDE");
		NativeFieldInfoPtr_T_DOWN1PIXEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_DOWN1PIXEL");
		NativeFieldInfoPtr_T_BRIDGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_BRIDGE");
		NativeFieldInfoPtr_T_UNDERWATER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_UNDERWATER");
		NativeFieldInfoPtr_T_SOLIDGROUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_SOLIDGROUND");
		NativeFieldInfoPtr_T_BOTTOM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_BOTTOM");
		NativeFieldInfoPtr_T_DIE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_DIE");
		NativeFieldInfoPtr_T_HEBI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_HEBI");
		NativeFieldInfoPtr_T_BANG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_BANG");
		NativeFieldInfoPtr_T_JUM8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_JUM8");
		NativeFieldInfoPtr_T_NT0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_NT0");
		NativeFieldInfoPtr_T_NT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_NT1");
		NativeFieldInfoPtr_T_CENTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "T_CENTER");
		NativeFieldInfoPtr_tmw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "tmw");
		NativeFieldInfoPtr_tmh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "tmh");
		NativeFieldInfoPtr_pxw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "pxw");
		NativeFieldInfoPtr_pxh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "pxh");
		NativeFieldInfoPtr_tileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "tileID");
		NativeFieldInfoPtr_lastTileID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "lastTileID");
		NativeFieldInfoPtr_maps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "maps");
		NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "types");
		NativeFieldInfoPtr_imgTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgTile");
		NativeFieldInfoPtr_imgTileSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgTileSmall");
		NativeFieldInfoPtr_imgMiniMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgMiniMap");
		NativeFieldInfoPtr_imgWaterfall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgWaterfall");
		NativeFieldInfoPtr_imgTopWaterfall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgTopWaterfall");
		NativeFieldInfoPtr_imgWaterflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgWaterflow");
		NativeFieldInfoPtr_imgWaterlowN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgWaterlowN");
		NativeFieldInfoPtr_imgWaterlowN2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgWaterlowN2");
		NativeFieldInfoPtr_imgWaterF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgWaterF");
		NativeFieldInfoPtr_imgLeaf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgLeaf");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "size");
		NativeFieldInfoPtr_bx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "bx");
		NativeFieldInfoPtr_dbx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "dbx");
		NativeFieldInfoPtr_fx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "fx");
		NativeFieldInfoPtr_dfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "dfx");
		NativeFieldInfoPtr_instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "instruction");
		NativeFieldInfoPtr_iX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "iX");
		NativeFieldInfoPtr_iY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "iY");
		NativeFieldInfoPtr_iW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "iW");
		NativeFieldInfoPtr_iCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "iCount");
		NativeFieldInfoPtr_isMapDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "isMapDouble");
		NativeFieldInfoPtr_mapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "mapName");
		NativeFieldInfoPtr_versionMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "versionMap");
		NativeFieldInfoPtr_mapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "mapID");
		NativeFieldInfoPtr_lastBgID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "lastBgID");
		NativeFieldInfoPtr_zoneID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "zoneID");
		NativeFieldInfoPtr_bgID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "bgID");
		NativeFieldInfoPtr_bgType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "bgType");
		NativeFieldInfoPtr_lastType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "lastType");
		NativeFieldInfoPtr_typeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "typeMap");
		NativeFieldInfoPtr_planetID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "planetID");
		NativeFieldInfoPtr_lastPlanetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "lastPlanetId");
		NativeFieldInfoPtr_timeTranMini = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "timeTranMini");
		NativeFieldInfoPtr_vGo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "vGo");
		NativeFieldInfoPtr_vItemBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "vItemBg");
		NativeFieldInfoPtr_vCurrItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "vCurrItem");
		NativeFieldInfoPtr_mapNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "mapNames");
		NativeFieldInfoPtr_MAP_NORMAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "MAP_NORMAL");
		NativeFieldInfoPtr_bong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "bong");
		NativeFieldInfoPtr_TRAIDAT_DOINUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "TRAIDAT_DOINUI");
		NativeFieldInfoPtr_TRAIDAT_RUNG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "TRAIDAT_RUNG");
		NativeFieldInfoPtr_TRAIDAT_DAORUA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "TRAIDAT_DAORUA");
		NativeFieldInfoPtr_TRAIDAT_DADO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "TRAIDAT_DADO");
		NativeFieldInfoPtr_NAMEK_THUNGLUNG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "NAMEK_THUNGLUNG");
		NativeFieldInfoPtr_NAMEK_DOINUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "NAMEK_DOINUI");
		NativeFieldInfoPtr_NAMEK_RUNG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "NAMEK_RUNG");
		NativeFieldInfoPtr_NAMEK_DAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "NAMEK_DAO");
		NativeFieldInfoPtr_SAYAI_DOINUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "SAYAI_DOINUI");
		NativeFieldInfoPtr_SAYAI_RUNG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "SAYAI_RUNG");
		NativeFieldInfoPtr_SAYAI_CITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "SAYAI_CITY");
		NativeFieldInfoPtr_SAYAI_NIGHT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "SAYAI_NIGHT");
		NativeFieldInfoPtr_KAMISAMA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "KAMISAMA");
		NativeFieldInfoPtr_TIME_ROOM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "TIME_ROOM");
		NativeFieldInfoPtr_HELL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "HELL");
		NativeFieldInfoPtr_BEERUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "BEERUS");
		NativeFieldInfoPtr_bgItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "bgItem");
		NativeFieldInfoPtr_vObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "vObject");
		NativeFieldInfoPtr_offlineId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "offlineId");
		NativeFieldInfoPtr_highterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "highterId");
		NativeFieldInfoPtr_toOfflineId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "toOfflineId");
		NativeFieldInfoPtr_tileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "tileType");
		NativeFieldInfoPtr_tileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "tileIndex");
		NativeFieldInfoPtr_imgLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "imgLight");
		NativeFieldInfoPtr_sizeMiniMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "sizeMiniMap");
		NativeFieldInfoPtr_gssx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "gssx");
		NativeFieldInfoPtr_gssxe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "gssxe");
		NativeFieldInfoPtr_gssy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "gssy");
		NativeFieldInfoPtr_gssye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "gssye");
		NativeFieldInfoPtr_countx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "countx");
		NativeFieldInfoPtr_county = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "county");
		NativeFieldInfoPtr_colorMini = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "colorMini");
		NativeFieldInfoPtr_yWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "yWater");
		NativeFieldInfoPtr_mapDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileMap>.NativeClassPtr, "mapDatas");
		NativeMethodInfoPtr_loadBg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666394);
		NativeMethodInfoPtr_isVoDaiMap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666395);
		NativeMethodInfoPtr_isTrainingMap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666396);
		NativeMethodInfoPtr_mapPhuBang_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666397);
		NativeMethodInfoPtr_getBIById_Public_Static_BgItem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666398);
		NativeMethodInfoPtr_isOfflineMap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666399);
		NativeMethodInfoPtr_isHighterMap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666400);
		NativeMethodInfoPtr_isToOfflineMap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666401);
		NativeMethodInfoPtr_freeTilemap_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666402);
		NativeMethodInfoPtr_loadTileCreatChar_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666403);
		NativeMethodInfoPtr_isExistMoreOne_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666404);
		NativeMethodInfoPtr_loadTileImage_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666405);
		NativeMethodInfoPtr_setTile_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666406);
		NativeMethodInfoPtr_loadMap_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666407);
		NativeMethodInfoPtr_isInAirMap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666408);
		NativeMethodInfoPtr_isDoubleMap_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666409);
		NativeMethodInfoPtr_getTile_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666410);
		NativeMethodInfoPtr_paintTile_Public_Static_Void_mGraphics_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666411);
		NativeMethodInfoPtr_paintTile_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666412);
		NativeMethodInfoPtr_paintTilemapLOW_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666413);
		NativeMethodInfoPtr_paintTilemap_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666414);
		NativeMethodInfoPtr_isWaterEff_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666415);
		NativeMethodInfoPtr_paintOutTilemap_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666416);
		NativeMethodInfoPtr_loadMapFromResource_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666417);
		NativeMethodInfoPtr_loadMaptoRMS_Public_Static_MapData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666418);
		NativeMethodInfoPtr_saveMaptoRMS_Public_Static_Void_MapData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666419);
		NativeMethodInfoPtr_tileAt_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666420);
		NativeMethodInfoPtr_tileTypeAt_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666421);
		NativeMethodInfoPtr_tileTypeAtPixel_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666422);
		NativeMethodInfoPtr_tileTypeAt_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666423);
		NativeMethodInfoPtr_setTileTypeAtPixel_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666424);
		NativeMethodInfoPtr_setTileTypeAt_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666425);
		NativeMethodInfoPtr_killTileTypeAt_Public_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666426);
		NativeMethodInfoPtr_tileYofPixel_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666427);
		NativeMethodInfoPtr_tileXofPixel_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666428);
		NativeMethodInfoPtr_loadMainTile_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666429);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileMap>.NativeClassPtr, 100666430);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111406, RefRangeEnd = 111407, XrefRangeStart = 111374, XrefRangeEnd = 111406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadBg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadBg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 111423, RefRangeEnd = 111426, XrefRangeStart = 111407, XrefRangeEnd = 111423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isVoDaiMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isVoDaiMap_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 111434, RefRangeEnd = 111437, XrefRangeStart = 111426, XrefRangeEnd = 111434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isTrainingMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isTrainingMap_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111448, RefRangeEnd = 111449, XrefRangeStart = 111437, XrefRangeEnd = 111448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool mapPhuBang()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mapPhuBang_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 111461, RefRangeEnd = 111465, XrefRangeStart = 111449, XrefRangeEnd = 111461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BgItem getBIById(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBIById_Public_Static_BgItem_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BgItem>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 111472, RefRangeEnd = 111475, XrefRangeStart = 111465, XrefRangeEnd = 111472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isOfflineMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isOfflineMap_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111475, XrefRangeEnd = 111482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isHighterMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isHighterMap_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111482, XrefRangeEnd = 111489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isToOfflineMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isToOfflineMap_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111489, XrefRangeEnd = 111499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void freeTilemap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeTilemap_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadTileCreatChar()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadTileCreatChar_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111526, RefRangeEnd = 111527, XrefRangeStart = 111499, XrefRangeEnd = 111526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isExistMoreOne(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isExistMoreOne_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111598, RefRangeEnd = 111599, XrefRangeStart = 111527, XrefRangeEnd = 111598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadTileImage()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadTileImage_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111606, RefRangeEnd = 111607, XrefRangeStart = 111599, XrefRangeEnd = 111606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTile(int index, Il2CppStructArray<int> mapsArr, int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mapsArr);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTile_Public_Static_Void_Int32_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111639, RefRangeEnd = 111640, XrefRangeStart = 111607, XrefRangeEnd = 111639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadMap(int tileId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&tileId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadMap_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 111648, RefRangeEnd = 111654, XrefRangeStart = 111640, XrefRangeEnd = 111648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isInAirMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isInAirMap_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111694, RefRangeEnd = 111695, XrefRangeStart = 111654, XrefRangeEnd = 111694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isDoubleMap()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isDoubleMap_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111752, RefRangeEnd = 111753, XrefRangeStart = 111695, XrefRangeEnd = 111752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getTile()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTile_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 111764, RefRangeEnd = 111771, XrefRangeStart = 111753, XrefRangeEnd = 111764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintTile(mGraphics g, int frame, int indexX, int indexY)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frame;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexX;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indexY;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintTile_Public_Static_Void_mGraphics_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 111780, RefRangeEnd = 111784, XrefRangeStart = 111771, XrefRangeEnd = 111780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintTile(mGraphics g, int frame, int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frame;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintTile_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111784, XrefRangeEnd = 111878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintTilemapLOW(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintTilemapLOW_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 112014, RefRangeEnd = 112017, XrefRangeStart = 111878, XrefRangeEnd = 112014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintTilemap(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintTilemap_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112029, RefRangeEnd = 112031, XrefRangeStart = 112017, XrefRangeEnd = 112029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isWaterEff()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isWaterEff_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112105, RefRangeEnd = 112107, XrefRangeStart = 112031, XrefRangeEnd = 112105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintOutTilemap(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintOutTilemap_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112144, RefRangeEnd = 112145, XrefRangeStart = 112107, XrefRangeEnd = 112144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadMapFromResource(int mapID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadMapFromResource_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 112181, RefRangeEnd = 112182, XrefRangeStart = 112145, XrefRangeEnd = 112181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MapData loadMaptoRMS(int mapId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadMaptoRMS_Public_Static_MapData_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MapData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112202, RefRangeEnd = 112204, XrefRangeStart = 112182, XrefRangeEnd = 112202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void saveMaptoRMS(MapData map)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)map);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveMaptoRMS_Public_Static_Void_MapData_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112204, XrefRangeEnd = 112209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tileAt(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tileAt_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 112214, RefRangeEnd = 112245, XrefRangeStart = 112209, XrefRangeEnd = 112214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tileTypeAt(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tileTypeAt_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 112250, RefRangeEnd = 112277, XrefRangeStart = 112245, XrefRangeEnd = 112250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tileTypeAtPixel(int px, int py)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&px);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &py;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tileTypeAtPixel_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(57)]
	[CachedScanResults(RefRangeStart = 112282, RefRangeEnd = 112339, XrefRangeStart = 112277, XrefRangeEnd = 112282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool tileTypeAt(int px, int py, int t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&px);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &py;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tileTypeAt_Public_Static_Boolean_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112343, RefRangeEnd = 112345, XrefRangeStart = 112339, XrefRangeEnd = 112343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTileTypeAtPixel(int px, int py, int t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&px);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &py;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTileTypeAtPixel_Public_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112345, XrefRangeEnd = 112349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setTileTypeAt(int x, int y, int t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setTileTypeAt_Public_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 112353, RefRangeEnd = 112357, XrefRangeStart = 112349, XrefRangeEnd = 112353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void killTileTypeAt(int px, int py, int t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&px);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &py;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_killTileTypeAt_Public_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 112361, RefRangeEnd = 112365, XrefRangeStart = 112357, XrefRangeEnd = 112361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tileYofPixel(int py)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&py);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tileYofPixel_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 112369, RefRangeEnd = 112379, XrefRangeStart = 112365, XrefRangeEnd = 112369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int tileXofPixel(int px)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&px);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tileXofPixel_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 112386, RefRangeEnd = 112388, XrefRangeStart = 112379, XrefRangeEnd = 112386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void loadMainTile()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadMainTile_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TileMap()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileMap>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public TileMap(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
