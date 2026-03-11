using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class SoundMn : Il2CppSystem.Object
{
	public class MediaPlayer : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static MediaPlayer()
		{
			Il2CppClassPointerStore<MediaPlayer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MediaPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MediaPlayer>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MediaPlayer>.NativeClassPtr, 100666301);
		}

		[CallerCount(707)]
		[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MediaPlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MediaPlayer>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MediaPlayer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class SoundPool : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static SoundPool()
		{
			Il2CppClassPointerStore<SoundPool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "SoundPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundPool>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundPool>.NativeClassPtr, 100666302);
		}

		[CallerCount(707)]
		[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoundPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundPool>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public SoundPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class AssetManager : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static AssetManager()
		{
			Il2CppClassPointerStore<AssetManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "AssetManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetManager>.NativeClassPtr);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetManager>.NativeClassPtr, 100666303);
		}

		[CallerCount(707)]
		[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetManager>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public AssetManager(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDelAcc;

	private static readonly System.IntPtr NativeFieldInfoPtr_gIz;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_volume;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_VOLUME;

	private static readonly System.IntPtr NativeFieldInfoPtr_music;

	private static readonly System.IntPtr NativeFieldInfoPtr_sound;

	private static readonly System.IntPtr NativeFieldInfoPtr_soundID;

	private static readonly System.IntPtr NativeFieldInfoPtr_AIR_SHIP;

	private static readonly System.IntPtr NativeFieldInfoPtr_RAIN;

	private static readonly System.IntPtr NativeFieldInfoPtr_TAITAONANGLUONG;

	private static readonly System.IntPtr NativeFieldInfoPtr_GET_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOVE;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOW_PUNCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_LOW_KICK;

	private static readonly System.IntPtr NativeFieldInfoPtr_FLY;

	private static readonly System.IntPtr NativeFieldInfoPtr_JUMP;

	private static readonly System.IntPtr NativeFieldInfoPtr_PANEL_OPEN;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUTTON_CLOSE;

	private static readonly System.IntPtr NativeFieldInfoPtr_BUTTON_CLICK;

	private static readonly System.IntPtr NativeFieldInfoPtr_MEDIUM_PUNCH;

	private static readonly System.IntPtr NativeFieldInfoPtr_MEDIUM_KICK;

	private static readonly System.IntPtr NativeFieldInfoPtr_PANEL_CLICK;

	private static readonly System.IntPtr NativeFieldInfoPtr_EAT_PEAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_DIALOG;

	private static readonly System.IntPtr NativeFieldInfoPtr_NORMAL_KAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAMEK_KAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_XAYDA_KAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_EXPLODE_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_EXPLODE_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_TRAIDAT_KAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_HP_UP;

	private static readonly System.IntPtr NativeFieldInfoPtr_THAIDUONGHASAN;

	private static readonly System.IntPtr NativeFieldInfoPtr_HOISINH;

	private static readonly System.IntPtr NativeFieldInfoPtr_GONG;

	private static readonly System.IntPtr NativeFieldInfoPtr_KHICHAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_BIG_EXPLODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAMEK_LAZER;

	private static readonly System.IntPtr NativeFieldInfoPtr_NAMEK_CHARGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_RADAR_CLICK;

	private static readonly System.IntPtr NativeFieldInfoPtr_RADAR_ITEM;

	private static readonly System.IntPtr NativeFieldInfoPtr_FIREWORK;

	private static readonly System.IntPtr NativeFieldInfoPtr_KAMEX10_0;

	private static readonly System.IntPtr NativeFieldInfoPtr_KAMEX10_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_DESTROY_0;

	private static readonly System.IntPtr NativeFieldInfoPtr_DESTROY_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAFUBA_0;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAFUBA_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAFUBA_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_DESTROY_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_freePool;

	private static readonly System.IntPtr NativeFieldInfoPtr_poolCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_cout;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_AssetManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_SoundMn_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadSound_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getSoundOption_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getStrOption_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HP_MPup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_charPunch_Public_Void_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_thaiduonghasan_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_rain_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gongName_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gong_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_soundToolOption_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chatVipToolOption_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_analogToolOption_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaseAnalog_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CaseSizeScr_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_caseAutoPlay_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AuraToolOption_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AuraToolOption2_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HatToolOption_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_closeSound_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openSound_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_bigeExlode_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_explode_1_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_explode_2_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_traidatKame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_namekKame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_nameLazer_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_xaydaKame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mobKame_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_charRun_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_monkeyRun_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_charFall_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_charJump_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_panelOpen_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buttonClose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_buttonClick_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopMove_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_charFly_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopFly_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openMenu_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_panelClick_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_eatPeans_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_openDialog_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_hoisinh_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_taitao_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_taitaoPause_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPlayRain_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPlayAirShip_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_airShip_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_pauseAirShip_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resumeAirShip_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_backToRegister_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_newKame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_radarClick_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_radarItem_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playSound_Public_Static_Void_Int32_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool IsDelAcc
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsDelAcc, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsDelAcc, (void*)(&flag));
		}
	}

	public unsafe static SoundMn gIz
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gIz, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundMn>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gIz, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)soundMn));
		}
	}

	public unsafe static bool isSound
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isSound, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isSound, (void*)(&flag));
		}
	}

	public unsafe static float volume
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_volume, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_volume, (void*)(&num));
		}
	}

	public unsafe static int MAX_VOLUME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_VOLUME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_VOLUME, (void*)(&num));
		}
	}

	public unsafe static Il2CppReferenceArray<MediaPlayer> music
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_music, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MediaPlayer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_music, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<SoundPool> sound
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sound, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SoundPool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sound, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStructArray<int> soundID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_soundID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_soundID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static int AIR_SHIP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AIR_SHIP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AIR_SHIP, (void*)(&num));
		}
	}

	public unsafe static int RAIN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RAIN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RAIN, (void*)(&num));
		}
	}

	public unsafe static int TAITAONANGLUONG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TAITAONANGLUONG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TAITAONANGLUONG, (void*)(&num));
		}
	}

	public unsafe static int GET_ITEM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GET_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GET_ITEM, (void*)(&num));
		}
	}

	public unsafe static int MOVE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOVE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOVE, (void*)(&num));
		}
	}

	public unsafe static int LOW_PUNCH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOW_PUNCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOW_PUNCH, (void*)(&num));
		}
	}

	public unsafe static int LOW_KICK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LOW_KICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LOW_KICK, (void*)(&num));
		}
	}

	public unsafe static int FLY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FLY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FLY, (void*)(&num));
		}
	}

	public unsafe static int JUMP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JUMP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JUMP, (void*)(&num));
		}
	}

	public unsafe static int PANEL_OPEN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PANEL_OPEN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PANEL_OPEN, (void*)(&num));
		}
	}

	public unsafe static int BUTTON_CLOSE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUTTON_CLOSE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUTTON_CLOSE, (void*)(&num));
		}
	}

	public unsafe static int BUTTON_CLICK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BUTTON_CLICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BUTTON_CLICK, (void*)(&num));
		}
	}

	public unsafe static int MEDIUM_PUNCH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEDIUM_PUNCH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEDIUM_PUNCH, (void*)(&num));
		}
	}

	public unsafe static int MEDIUM_KICK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEDIUM_KICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEDIUM_KICK, (void*)(&num));
		}
	}

	public unsafe static int PANEL_CLICK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PANEL_CLICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PANEL_CLICK, (void*)(&num));
		}
	}

	public unsafe static int EAT_PEAN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EAT_PEAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EAT_PEAN, (void*)(&num));
		}
	}

	public unsafe static int OPEN_DIALOG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OPEN_DIALOG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OPEN_DIALOG, (void*)(&num));
		}
	}

	public unsafe static int NORMAL_KAME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NORMAL_KAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NORMAL_KAME, (void*)(&num));
		}
	}

	public unsafe static int NAMEK_KAME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAMEK_KAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAMEK_KAME, (void*)(&num));
		}
	}

	public unsafe static int XAYDA_KAME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_XAYDA_KAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_XAYDA_KAME, (void*)(&num));
		}
	}

	public unsafe static int EXPLODE_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EXPLODE_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EXPLODE_1, (void*)(&num));
		}
	}

	public unsafe static int EXPLODE_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EXPLODE_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EXPLODE_2, (void*)(&num));
		}
	}

	public unsafe static int TRAIDAT_KAME
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TRAIDAT_KAME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TRAIDAT_KAME, (void*)(&num));
		}
	}

	public unsafe static int HP_UP
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HP_UP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HP_UP, (void*)(&num));
		}
	}

	public unsafe static int THAIDUONGHASAN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_THAIDUONGHASAN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_THAIDUONGHASAN, (void*)(&num));
		}
	}

	public unsafe static int HOISINH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HOISINH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HOISINH, (void*)(&num));
		}
	}

	public unsafe static int GONG
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GONG, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GONG, (void*)(&num));
		}
	}

	public unsafe static int KHICHAY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KHICHAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KHICHAY, (void*)(&num));
		}
	}

	public unsafe static int BIG_EXPLODE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BIG_EXPLODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BIG_EXPLODE, (void*)(&num));
		}
	}

	public unsafe static int NAMEK_LAZER
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAMEK_LAZER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAMEK_LAZER, (void*)(&num));
		}
	}

	public unsafe static int NAMEK_CHARGE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NAMEK_CHARGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NAMEK_CHARGE, (void*)(&num));
		}
	}

	public unsafe static int RADAR_CLICK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RADAR_CLICK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RADAR_CLICK, (void*)(&num));
		}
	}

	public unsafe static int RADAR_ITEM
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RADAR_ITEM, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RADAR_ITEM, (void*)(&num));
		}
	}

	public unsafe static int FIREWORK
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FIREWORK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FIREWORK, (void*)(&num));
		}
	}

	public unsafe static int KAMEX10_0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KAMEX10_0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KAMEX10_0, (void*)(&num));
		}
	}

	public unsafe static int KAMEX10_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KAMEX10_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KAMEX10_1, (void*)(&num));
		}
	}

	public unsafe static int DESTROY_0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESTROY_0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESTROY_0, (void*)(&num));
		}
	}

	public unsafe static int DESTROY_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESTROY_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESTROY_1, (void*)(&num));
		}
	}

	public unsafe static int MAFUBA_0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAFUBA_0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAFUBA_0, (void*)(&num));
		}
	}

	public unsafe static int MAFUBA_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAFUBA_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAFUBA_1, (void*)(&num));
		}
	}

	public unsafe static int MAFUBA_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAFUBA_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAFUBA_2, (void*)(&num));
		}
	}

	public unsafe static int DESTROY_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DESTROY_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DESTROY_2, (void*)(&num));
		}
	}

	public unsafe bool freePool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freePool);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freePool)) = flag;
		}
	}

	public unsafe int poolCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_poolCount)) = num;
		}
	}

	public unsafe static int cout
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cout, (void*)(&num));
		}
	}

	static SoundMn()
	{
		Il2CppClassPointerStore<SoundMn>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SoundMn");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundMn>.NativeClassPtr);
		NativeFieldInfoPtr_IsDelAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "IsDelAcc");
		NativeFieldInfoPtr_gIz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "gIz");
		NativeFieldInfoPtr_isSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "isSound");
		NativeFieldInfoPtr_volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "volume");
		NativeFieldInfoPtr_MAX_VOLUME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MAX_VOLUME");
		NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "music");
		NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "sound");
		NativeFieldInfoPtr_soundID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "soundID");
		NativeFieldInfoPtr_AIR_SHIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "AIR_SHIP");
		NativeFieldInfoPtr_RAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "RAIN");
		NativeFieldInfoPtr_TAITAONANGLUONG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "TAITAONANGLUONG");
		NativeFieldInfoPtr_GET_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "GET_ITEM");
		NativeFieldInfoPtr_MOVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MOVE");
		NativeFieldInfoPtr_LOW_PUNCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "LOW_PUNCH");
		NativeFieldInfoPtr_LOW_KICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "LOW_KICK");
		NativeFieldInfoPtr_FLY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "FLY");
		NativeFieldInfoPtr_JUMP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "JUMP");
		NativeFieldInfoPtr_PANEL_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "PANEL_OPEN");
		NativeFieldInfoPtr_BUTTON_CLOSE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "BUTTON_CLOSE");
		NativeFieldInfoPtr_BUTTON_CLICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "BUTTON_CLICK");
		NativeFieldInfoPtr_MEDIUM_PUNCH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MEDIUM_PUNCH");
		NativeFieldInfoPtr_MEDIUM_KICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MEDIUM_KICK");
		NativeFieldInfoPtr_PANEL_CLICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "PANEL_CLICK");
		NativeFieldInfoPtr_EAT_PEAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "EAT_PEAN");
		NativeFieldInfoPtr_OPEN_DIALOG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "OPEN_DIALOG");
		NativeFieldInfoPtr_NORMAL_KAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "NORMAL_KAME");
		NativeFieldInfoPtr_NAMEK_KAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "NAMEK_KAME");
		NativeFieldInfoPtr_XAYDA_KAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "XAYDA_KAME");
		NativeFieldInfoPtr_EXPLODE_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "EXPLODE_1");
		NativeFieldInfoPtr_EXPLODE_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "EXPLODE_2");
		NativeFieldInfoPtr_TRAIDAT_KAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "TRAIDAT_KAME");
		NativeFieldInfoPtr_HP_UP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "HP_UP");
		NativeFieldInfoPtr_THAIDUONGHASAN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "THAIDUONGHASAN");
		NativeFieldInfoPtr_HOISINH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "HOISINH");
		NativeFieldInfoPtr_GONG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "GONG");
		NativeFieldInfoPtr_KHICHAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "KHICHAY");
		NativeFieldInfoPtr_BIG_EXPLODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "BIG_EXPLODE");
		NativeFieldInfoPtr_NAMEK_LAZER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "NAMEK_LAZER");
		NativeFieldInfoPtr_NAMEK_CHARGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "NAMEK_CHARGE");
		NativeFieldInfoPtr_RADAR_CLICK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "RADAR_CLICK");
		NativeFieldInfoPtr_RADAR_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "RADAR_ITEM");
		NativeFieldInfoPtr_FIREWORK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "FIREWORK");
		NativeFieldInfoPtr_KAMEX10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "KAMEX10_0");
		NativeFieldInfoPtr_KAMEX10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "KAMEX10_1");
		NativeFieldInfoPtr_DESTROY_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "DESTROY_0");
		NativeFieldInfoPtr_DESTROY_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "DESTROY_1");
		NativeFieldInfoPtr_MAFUBA_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MAFUBA_0");
		NativeFieldInfoPtr_MAFUBA_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MAFUBA_1");
		NativeFieldInfoPtr_MAFUBA_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "MAFUBA_2");
		NativeFieldInfoPtr_DESTROY_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "DESTROY_2");
		NativeFieldInfoPtr_freePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "freePool");
		NativeFieldInfoPtr_poolCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "poolCount");
		NativeFieldInfoPtr_cout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, "cout");
		NativeMethodInfoPtr_init_Public_Static_Void_AssetManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666239);
		NativeMethodInfoPtr_gI_Public_Static_SoundMn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666240);
		NativeMethodInfoPtr_loadSound_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666241);
		NativeMethodInfoPtr_getSoundOption_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666242);
		NativeMethodInfoPtr_getStrOption_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666243);
		NativeMethodInfoPtr_HP_MPup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666244);
		NativeMethodInfoPtr_charPunch_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666245);
		NativeMethodInfoPtr_thaiduonghasan_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666246);
		NativeMethodInfoPtr_rain_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666247);
		NativeMethodInfoPtr_gongName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666248);
		NativeMethodInfoPtr_gong_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666249);
		NativeMethodInfoPtr_getItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666250);
		NativeMethodInfoPtr_soundToolOption_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666251);
		NativeMethodInfoPtr_chatVipToolOption_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666252);
		NativeMethodInfoPtr_analogToolOption_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666253);
		NativeMethodInfoPtr_CaseAnalog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666254);
		NativeMethodInfoPtr_CaseSizeScr_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666255);
		NativeMethodInfoPtr_caseAutoPlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666256);
		NativeMethodInfoPtr_AuraToolOption_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666257);
		NativeMethodInfoPtr_AuraToolOption2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666258);
		NativeMethodInfoPtr_HatToolOption_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666259);
		NativeMethodInfoPtr_update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666260);
		NativeMethodInfoPtr_closeSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666261);
		NativeMethodInfoPtr_openSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666262);
		NativeMethodInfoPtr_bigeExlode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666263);
		NativeMethodInfoPtr_explode_1_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666264);
		NativeMethodInfoPtr_explode_2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666265);
		NativeMethodInfoPtr_traidatKame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666266);
		NativeMethodInfoPtr_namekKame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666267);
		NativeMethodInfoPtr_nameLazer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666268);
		NativeMethodInfoPtr_xaydaKame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666269);
		NativeMethodInfoPtr_mobKame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666270);
		NativeMethodInfoPtr_charRun_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666271);
		NativeMethodInfoPtr_monkeyRun_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666272);
		NativeMethodInfoPtr_charFall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666273);
		NativeMethodInfoPtr_charJump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666274);
		NativeMethodInfoPtr_panelOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666275);
		NativeMethodInfoPtr_buttonClose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666276);
		NativeMethodInfoPtr_buttonClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666277);
		NativeMethodInfoPtr_stopMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666278);
		NativeMethodInfoPtr_charFly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666279);
		NativeMethodInfoPtr_stopFly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666280);
		NativeMethodInfoPtr_openMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666281);
		NativeMethodInfoPtr_panelClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666282);
		NativeMethodInfoPtr_eatPeans_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666283);
		NativeMethodInfoPtr_openDialog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666284);
		NativeMethodInfoPtr_hoisinh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666285);
		NativeMethodInfoPtr_taitao_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666286);
		NativeMethodInfoPtr_taitaoPause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666287);
		NativeMethodInfoPtr_isPlayRain_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666288);
		NativeMethodInfoPtr_isPlayAirShip_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666289);
		NativeMethodInfoPtr_airShip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666290);
		NativeMethodInfoPtr_pauseAirShip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666291);
		NativeMethodInfoPtr_resumeAirShip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666292);
		NativeMethodInfoPtr_stopAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666293);
		NativeMethodInfoPtr_backToRegister_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666294);
		NativeMethodInfoPtr_newKame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666295);
		NativeMethodInfoPtr_radarClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666296);
		NativeMethodInfoPtr_radarItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666297);
		NativeMethodInfoPtr_playSound_Public_Static_Void_Int32_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666298);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundMn>.NativeClassPtr, 100666299);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97370, XrefRangeEnd = 97373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init(AssetManager ac)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ac);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_AssetManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(77)]
	[CachedScanResults(RefRangeStart = 97387, RefRangeEnd = 97464, XrefRangeStart = 97373, XrefRangeEnd = 97387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SoundMn gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_SoundMn_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundMn>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 97520, RefRangeEnd = 97524, XrefRangeStart = 97464, XrefRangeEnd = 97520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadSound(int mapID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadSound_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 97690, RefRangeEnd = 97691, XrefRangeStart = 97524, XrefRangeEnd = 97690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getSoundOption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getSoundOption_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 97753, RefRangeEnd = 97768, XrefRangeStart = 97691, XrefRangeEnd = 97753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getStrOption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getStrOption_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 97780, RefRangeEnd = 97783, XrefRangeStart = 97768, XrefRangeEnd = 97780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HP_MPup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HP_MPup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 97816, RefRangeEnd = 97818, XrefRangeStart = 97783, XrefRangeEnd = 97816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void charPunch(bool isKick, float volumn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isKick);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volumn;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_charPunch_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 97830, RefRangeEnd = 97831, XrefRangeStart = 97818, XrefRangeEnd = 97830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void thaiduonghasan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_thaiduonghasan_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 97839, RefRangeEnd = 97840, XrefRangeStart = 97831, XrefRangeEnd = 97839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void rain()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_rain_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97840, XrefRangeEnd = 97852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gongName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gongName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 97864, RefRangeEnd = 97868, XrefRangeStart = 97852, XrefRangeEnd = 97864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void gong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gong_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 97880, RefRangeEnd = 97885, XrefRangeStart = 97868, XrefRangeEnd = 97880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97885, XrefRangeEnd = 97937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void soundToolOption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_soundToolOption_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97937, XrefRangeEnd = 97947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chatVipToolOption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatVipToolOption_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97947, XrefRangeEnd = 97962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void analogToolOption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_analogToolOption_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97962, XrefRangeEnd = 97995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CaseAnalog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaseAnalog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97995, XrefRangeEnd = 98011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CaseSizeScr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CaseSizeScr_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98011, XrefRangeEnd = 98018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void caseAutoPlay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_caseAutoPlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98018, XrefRangeEnd = 98034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AuraToolOption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AuraToolOption_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98034, XrefRangeEnd = 98050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AuraToolOption2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AuraToolOption2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98050, XrefRangeEnd = 98101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HatToolOption()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HatToolOption_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98101, XrefRangeEnd = 98131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void closeSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_closeSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98131, XrefRangeEnd = 98139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98151, RefRangeEnd = 98153, XrefRangeStart = 98139, XrefRangeEnd = 98151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void bigeExlode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_bigeExlode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98165, RefRangeEnd = 98167, XrefRangeStart = 98153, XrefRangeEnd = 98165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void explode_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_explode_1_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98179, RefRangeEnd = 98180, XrefRangeStart = 98167, XrefRangeEnd = 98179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void explode_2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_explode_2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98192, RefRangeEnd = 98193, XrefRangeStart = 98180, XrefRangeEnd = 98192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void traidatKame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_traidatKame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98205, RefRangeEnd = 98206, XrefRangeStart = 98193, XrefRangeEnd = 98205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void namekKame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_namekKame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98218, RefRangeEnd = 98219, XrefRangeStart = 98206, XrefRangeEnd = 98218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void nameLazer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_nameLazer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98231, RefRangeEnd = 98232, XrefRangeStart = 98219, XrefRangeEnd = 98231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void xaydaKame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_xaydaKame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98246, RefRangeEnd = 98248, XrefRangeStart = 98232, XrefRangeEnd = 98246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void mobKame(int type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mobKame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98267, RefRangeEnd = 98268, XrefRangeStart = 98248, XrefRangeEnd = 98267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void charRun(float volumn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&volumn);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_charRun_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98284, RefRangeEnd = 98285, XrefRangeStart = 98268, XrefRangeEnd = 98284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void monkeyRun(float volumn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&volumn);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_monkeyRun_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98297, RefRangeEnd = 98298, XrefRangeStart = 98285, XrefRangeEnd = 98297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void charFall()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_charFall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98298, XrefRangeEnd = 98310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void charJump()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_charJump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98322, RefRangeEnd = 98323, XrefRangeStart = 98310, XrefRangeEnd = 98322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void panelOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_panelOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 98335, RefRangeEnd = 98338, XrefRangeStart = 98323, XrefRangeEnd = 98335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buttonClose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buttonClose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98350, RefRangeEnd = 98352, XrefRangeStart = 98338, XrefRangeEnd = 98350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void buttonClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_buttonClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void stopMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98364, RefRangeEnd = 98365, XrefRangeStart = 98352, XrefRangeEnd = 98364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void charFly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_charFly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void stopFly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopFly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98365, XrefRangeEnd = 98377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openMenu()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98389, RefRangeEnd = 98391, XrefRangeStart = 98377, XrefRangeEnd = 98389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void panelClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_panelClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98391, XrefRangeEnd = 98403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void eatPeans()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_eatPeans_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98415, RefRangeEnd = 98417, XrefRangeStart = 98403, XrefRangeEnd = 98415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void openDialog()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_openDialog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98429, RefRangeEnd = 98431, XrefRangeStart = 98417, XrefRangeEnd = 98429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void hoisinh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_hoisinh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98431, XrefRangeEnd = 98439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void taitao()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_taitao_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void taitaoPause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_taitaoPause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98459, RefRangeEnd = 98460, XrefRangeStart = 98439, XrefRangeEnd = 98459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isPlayRain()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPlayRain_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(89)]
	[CachedScanResults(RefRangeStart = 14330, RefRangeEnd = 14419, XrefRangeStart = 14330, XrefRangeEnd = 14419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isPlayAirShip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPlayAirShip_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98471, RefRangeEnd = 98472, XrefRangeStart = 98460, XrefRangeEnd = 98471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void airShip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_airShip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void pauseAirShip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_pauseAirShip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resumeAirShip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resumeAirShip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 98498, RefRangeEnd = 98504, XrefRangeStart = 98472, XrefRangeEnd = 98498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void stopAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98504, XrefRangeEnd = 98543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void backToRegister()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_backToRegister_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98555, RefRangeEnd = 98556, XrefRangeStart = 98543, XrefRangeEnd = 98555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void newKame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_newKame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 98568, RefRangeEnd = 98572, XrefRangeStart = 98556, XrefRangeEnd = 98568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void radarClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_radarClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98584, RefRangeEnd = 98585, XrefRangeStart = 98572, XrefRangeEnd = 98584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void radarItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_radarItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 98593, RefRangeEnd = 98600, XrefRangeStart = 98585, XrefRangeEnd = 98593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playSound(int x, int y, int id, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playSound_Public_Static_Void_Int32_Int32_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundMn()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundMn>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public SoundMn(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
