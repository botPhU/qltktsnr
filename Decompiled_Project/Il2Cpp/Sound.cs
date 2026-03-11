using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class Sound : Il2CppSystem.Object
{
	[ObfuscatedName("Sound+<ReturnToPoolAfterPlay>d__90")]
	public sealed class _ReturnToPoolAfterPlay_d__90 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

		private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

		private static readonly System.IntPtr NativeFieldInfoPtr_delay;

		private static readonly System.IntPtr NativeFieldInfoPtr_audioSource;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		public unsafe int __1__state
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___1__state)) = num;
			}
		}

		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr___2__current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe float delay
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delay)) = num;
			}
		}

		public unsafe AudioSource audioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource));
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 51667, RefRangeEnd = 51671, XrefRangeStart = 51667, XrefRangeEnd = 51671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 51667, RefRangeEnd = 51671, XrefRangeStart = 51667, XrefRangeEnd = 51671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr2);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
		}

		static _ReturnToPoolAfterPlay_d__90()
		{
			Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sound>.NativeClassPtr, "<ReturnToPoolAfterPlay>d__90");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr);
			NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, "<>1__state");
			NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, "<>2__current");
			NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, "delay");
			NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, "audioSource");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, 100666233);
			NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, 100666234);
			NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, 100666235);
			NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, 100666236);
			NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, 100666237);
			NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr, 100666238);
		}

		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 51595, RefRangeEnd = 51624, XrefRangeStart = 51595, XrefRangeEnd = 51624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ReturnToPoolAfterPlay_d__90(int _003C_003E1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<_ReturnToPoolAfterPlay_d__90>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&_003C_003E1__state);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(4741)]
		[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96374, XrefRangeEnd = 96380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96380, XrefRangeEnd = 96385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public _ReturnToPoolAfterPlay_d__90(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_INTERVAL;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAXTIME;

	private static readonly System.IntPtr NativeFieldInfoPtr_status;

	private static readonly System.IntPtr NativeFieldInfoPtr_postem;

	private static readonly System.IntPtr NativeFieldInfoPtr_timestart;

	private static readonly System.IntPtr NativeFieldInfoPtr_filenametemp;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumetem;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_isNotPlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_stopAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundBGLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_music;

	private static readonly System.IntPtr NativeFieldInfoPtr_player;

	private static readonly System.IntPtr NativeFieldInfoPtr_MLogin;

	private static readonly System.IntPtr NativeFieldInfoPtr_MBClick;

	private static readonly System.IntPtr NativeFieldInfoPtr_MTone;

	private static readonly System.IntPtr NativeFieldInfoPtr_MSanzu;

	private static readonly System.IntPtr NativeFieldInfoPtr_MChakumi;

	private static readonly System.IntPtr NativeFieldInfoPtr_MChai;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOshin;

	private static readonly System.IntPtr NativeFieldInfoPtr_MEchigo;

	private static readonly System.IntPtr NativeFieldInfoPtr_MKojin;

	private static readonly System.IntPtr NativeFieldInfoPtr_MHaruna;

	private static readonly System.IntPtr NativeFieldInfoPtr_MHirosaki;

	private static readonly System.IntPtr NativeFieldInfoPtr_MOokaza;

	private static readonly System.IntPtr NativeFieldInfoPtr_MGiotuyet;

	private static readonly System.IntPtr NativeFieldInfoPtr_MHangdong;

	private static readonly System.IntPtr NativeFieldInfoPtr_MDeKeu;

	private static readonly System.IntPtr NativeFieldInfoPtr_MChimKeu;

	private static readonly System.IntPtr NativeFieldInfoPtr_MBuocChan;

	private static readonly System.IntPtr NativeFieldInfoPtr_MNuocChay;

	private static readonly System.IntPtr NativeFieldInfoPtr_MBomMau;

	private static readonly System.IntPtr NativeFieldInfoPtr_MKiemGo;

	private static readonly System.IntPtr NativeFieldInfoPtr_MKiem;

	private static readonly System.IntPtr NativeFieldInfoPtr_MTieu;

	private static readonly System.IntPtr NativeFieldInfoPtr_MKunai;

	private static readonly System.IntPtr NativeFieldInfoPtr_MCung;

	private static readonly System.IntPtr NativeFieldInfoPtr_MDao;

	private static readonly System.IntPtr NativeFieldInfoPtr_MQuat;

	private static readonly System.IntPtr NativeFieldInfoPtr_MCung2;

	private static readonly System.IntPtr NativeFieldInfoPtr_MTieu2;

	private static readonly System.IntPtr NativeFieldInfoPtr_MTieu3;

	private static readonly System.IntPtr NativeFieldInfoPtr_MKiem2;

	private static readonly System.IntPtr NativeFieldInfoPtr_MKiem3;

	private static readonly System.IntPtr NativeFieldInfoPtr_MDao2;

	private static readonly System.IntPtr NativeFieldInfoPtr_MDao3;

	private static readonly System.IntPtr NativeFieldInfoPtr_MCung3;

	private static readonly System.IntPtr NativeFieldInfoPtr_l1;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioSourcePool;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioClipCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_audioPoolParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_POOL_SIZE;

	private static readonly System.IntPtr NativeMethodInfoPtr_setActivity_Public_Static_Void_AssetManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stop_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPlaying_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_init_Public_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playSound_Public_Static_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playSound1_Public_Static_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getAssetSoundFile_Public_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopAllz_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopAllBg_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopMusic_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_play_Public_Static_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playSoundRun_Public_Static_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sTopSoundRun_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPlayingSound_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playSoundNatural_Public_Static_Void_Int32_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stopSoundNatural_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPlayingSoundatural_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playMus_Public_Static_Void_Int32_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playSoundBGLoop_Public_Static_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sTopSoundBG_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPlayingSoundBG_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_load_Public_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__load_Private_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___load_Private_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_start_Public_Static_Void_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__start_Public_Static_Void_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___start_Public_Static_Void_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_stop_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__stop_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___stop_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_playSound_Public_Static_Void_Il2CppStructArray_1_Byte_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAudioPool_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioSourceFromPool_Private_Static_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnAudioSourceToPool_Private_Static_Void_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPoolAfterPlay_Private_Static_IEnumerator_AudioSource_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateAudioClip_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioHash_Private_Static_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAudioClipFromBytesOptimized_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAudioClipFromBytes_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe static int postem
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_postem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_postem, (void*)(&num));
		}
	}

	public unsafe static int timestart
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timestart, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timestart, (void*)(&num));
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

	public unsafe static float volumetem
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_volumetem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_volumetem, (void*)(&num));
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

	public unsafe static bool isNotPlay
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isNotPlay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isNotPlay, (void*)(&flag));
		}
	}

	public unsafe static bool stopAll
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stopAll, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stopAll, (void*)(&flag));
		}
	}

	public unsafe static AudioSource SoundWater
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundWater, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundWater, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource));
		}
	}

	public unsafe static AudioSource SoundRun
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundRun, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundRun, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource));
		}
	}

	public unsafe static AudioSource SoundBGLoop
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SoundBGLoop, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SoundBGLoop, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource));
		}
	}

	public unsafe static Il2CppReferenceArray<AudioClip> music
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_music, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_music, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppReferenceArray<GameObject> player
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_player, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_player, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static sbyte MLogin
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MLogin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MLogin, (void*)(&b));
		}
	}

	public unsafe static sbyte MBClick
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MBClick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MBClick, (void*)(&b));
		}
	}

	public unsafe static sbyte MTone
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MTone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MTone, (void*)(&b));
		}
	}

	public unsafe static sbyte MSanzu
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MSanzu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MSanzu, (void*)(&b));
		}
	}

	public unsafe static sbyte MChakumi
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MChakumi, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MChakumi, (void*)(&b));
		}
	}

	public unsafe static sbyte MChai
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MChai, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MChai, (void*)(&b));
		}
	}

	public unsafe static sbyte MOshin
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOshin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOshin, (void*)(&b));
		}
	}

	public unsafe static sbyte MEchigo
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MEchigo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MEchigo, (void*)(&b));
		}
	}

	public unsafe static sbyte MKojin
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MKojin, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MKojin, (void*)(&b));
		}
	}

	public unsafe static sbyte MHaruna
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MHaruna, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MHaruna, (void*)(&b));
		}
	}

	public unsafe static sbyte MHirosaki
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MHirosaki, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MHirosaki, (void*)(&b));
		}
	}

	public unsafe static sbyte MOokaza
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MOokaza, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MOokaza, (void*)(&b));
		}
	}

	public unsafe static sbyte MGiotuyet
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MGiotuyet, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MGiotuyet, (void*)(&b));
		}
	}

	public unsafe static sbyte MHangdong
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MHangdong, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MHangdong, (void*)(&b));
		}
	}

	public unsafe static sbyte MDeKeu
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MDeKeu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MDeKeu, (void*)(&b));
		}
	}

	public unsafe static sbyte MChimKeu
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MChimKeu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MChimKeu, (void*)(&b));
		}
	}

	public unsafe static sbyte MBuocChan
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MBuocChan, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MBuocChan, (void*)(&b));
		}
	}

	public unsafe static sbyte MNuocChay
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MNuocChay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MNuocChay, (void*)(&b));
		}
	}

	public unsafe static sbyte MBomMau
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MBomMau, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MBomMau, (void*)(&b));
		}
	}

	public unsafe static sbyte MKiemGo
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MKiemGo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MKiemGo, (void*)(&b));
		}
	}

	public unsafe static sbyte MKiem
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MKiem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MKiem, (void*)(&b));
		}
	}

	public unsafe static sbyte MTieu
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MTieu, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MTieu, (void*)(&b));
		}
	}

	public unsafe static sbyte MKunai
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MKunai, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MKunai, (void*)(&b));
		}
	}

	public unsafe static sbyte MCung
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MCung, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MCung, (void*)(&b));
		}
	}

	public unsafe static sbyte MDao
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MDao, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MDao, (void*)(&b));
		}
	}

	public unsafe static sbyte MQuat
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MQuat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MQuat, (void*)(&b));
		}
	}

	public unsafe static sbyte MCung2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MCung2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MCung2, (void*)(&b));
		}
	}

	public unsafe static sbyte MTieu2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MTieu2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MTieu2, (void*)(&b));
		}
	}

	public unsafe static sbyte MTieu3
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MTieu3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MTieu3, (void*)(&b));
		}
	}

	public unsafe static sbyte MKiem2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MKiem2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MKiem2, (void*)(&b));
		}
	}

	public unsafe static sbyte MKiem3
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MKiem3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MKiem3, (void*)(&b));
		}
	}

	public unsafe static sbyte MDao2
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MDao2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MDao2, (void*)(&b));
		}
	}

	public unsafe static sbyte MDao3
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MDao3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MDao3, (void*)(&b));
		}
	}

	public unsafe static sbyte MCung3
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MCung3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MCung3, (void*)(&b));
		}
	}

	public unsafe static int l1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_l1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_l1, (void*)(&num));
		}
	}

	public unsafe static Queue<AudioSource> audioSourcePool
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_audioSourcePool, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<AudioSource>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_audioSourcePool, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)queue));
		}
	}

	public unsafe static Dictionary<string, AudioClip> audioClipCache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_audioClipCache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, AudioClip>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_audioClipCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dictionary));
		}
	}

	public unsafe static GameObject audioPoolParent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_audioPoolParent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_audioPoolParent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject));
		}
	}

	public unsafe static int POOL_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_POOL_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_POOL_SIZE, (void*)(&num));
		}
	}

	static Sound()
	{
		Il2CppClassPointerStore<Sound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Sound");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sound>.NativeClassPtr);
		NativeFieldInfoPtr_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "INTERVAL");
		NativeFieldInfoPtr_MAXTIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MAXTIME");
		NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "status");
		NativeFieldInfoPtr_postem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "postem");
		NativeFieldInfoPtr_timestart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "timestart");
		NativeFieldInfoPtr_filenametemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "filenametemp");
		NativeFieldInfoPtr_volumetem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "volumetem");
		NativeFieldInfoPtr_isSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "isSound");
		NativeFieldInfoPtr_isNotPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "isNotPlay");
		NativeFieldInfoPtr_stopAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "stopAll");
		NativeFieldInfoPtr_SoundWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "SoundWater");
		NativeFieldInfoPtr_SoundRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "SoundRun");
		NativeFieldInfoPtr_SoundBGLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "SoundBGLoop");
		NativeFieldInfoPtr_music = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "music");
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "player");
		NativeFieldInfoPtr_MLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MLogin");
		NativeFieldInfoPtr_MBClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MBClick");
		NativeFieldInfoPtr_MTone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MTone");
		NativeFieldInfoPtr_MSanzu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MSanzu");
		NativeFieldInfoPtr_MChakumi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MChakumi");
		NativeFieldInfoPtr_MChai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MChai");
		NativeFieldInfoPtr_MOshin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MOshin");
		NativeFieldInfoPtr_MEchigo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MEchigo");
		NativeFieldInfoPtr_MKojin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MKojin");
		NativeFieldInfoPtr_MHaruna = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MHaruna");
		NativeFieldInfoPtr_MHirosaki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MHirosaki");
		NativeFieldInfoPtr_MOokaza = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MOokaza");
		NativeFieldInfoPtr_MGiotuyet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MGiotuyet");
		NativeFieldInfoPtr_MHangdong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MHangdong");
		NativeFieldInfoPtr_MDeKeu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MDeKeu");
		NativeFieldInfoPtr_MChimKeu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MChimKeu");
		NativeFieldInfoPtr_MBuocChan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MBuocChan");
		NativeFieldInfoPtr_MNuocChay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MNuocChay");
		NativeFieldInfoPtr_MBomMau = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MBomMau");
		NativeFieldInfoPtr_MKiemGo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MKiemGo");
		NativeFieldInfoPtr_MKiem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MKiem");
		NativeFieldInfoPtr_MTieu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MTieu");
		NativeFieldInfoPtr_MKunai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MKunai");
		NativeFieldInfoPtr_MCung = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MCung");
		NativeFieldInfoPtr_MDao = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MDao");
		NativeFieldInfoPtr_MQuat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MQuat");
		NativeFieldInfoPtr_MCung2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MCung2");
		NativeFieldInfoPtr_MTieu2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MTieu2");
		NativeFieldInfoPtr_MTieu3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MTieu3");
		NativeFieldInfoPtr_MKiem2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MKiem2");
		NativeFieldInfoPtr_MKiem3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MKiem3");
		NativeFieldInfoPtr_MDao2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MDao2");
		NativeFieldInfoPtr_MDao3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MDao3");
		NativeFieldInfoPtr_MCung3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "MCung3");
		NativeFieldInfoPtr_l1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "l1");
		NativeFieldInfoPtr_audioSourcePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "audioSourcePool");
		NativeFieldInfoPtr_audioClipCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "audioClipCache");
		NativeFieldInfoPtr_audioPoolParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "audioPoolParent");
		NativeFieldInfoPtr_POOL_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sound>.NativeClassPtr, "POOL_SIZE");
		NativeMethodInfoPtr_setActivity_Public_Static_Void_AssetManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666190);
		NativeMethodInfoPtr_stop_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666191);
		NativeMethodInfoPtr_isPlaying_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666192);
		NativeMethodInfoPtr_init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666193);
		NativeMethodInfoPtr_init_Public_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666194);
		NativeMethodInfoPtr_playSound_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666195);
		NativeMethodInfoPtr_playSound1_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666196);
		NativeMethodInfoPtr_getAssetSoundFile_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666197);
		NativeMethodInfoPtr_stopAllz_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666198);
		NativeMethodInfoPtr_stopAllBg_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666199);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666200);
		NativeMethodInfoPtr_stopMusic_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666201);
		NativeMethodInfoPtr_play_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666202);
		NativeMethodInfoPtr_playSoundRun_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666203);
		NativeMethodInfoPtr_sTopSoundRun_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666204);
		NativeMethodInfoPtr_isPlayingSound_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666205);
		NativeMethodInfoPtr_playSoundNatural_Public_Static_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666206);
		NativeMethodInfoPtr_stopSoundNatural_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666207);
		NativeMethodInfoPtr_isPlayingSoundatural_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666208);
		NativeMethodInfoPtr_playMus_Public_Static_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666209);
		NativeMethodInfoPtr_playSoundBGLoop_Public_Static_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666210);
		NativeMethodInfoPtr_sTopSoundBG_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666211);
		NativeMethodInfoPtr_isPlayingSoundBG_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666212);
		NativeMethodInfoPtr_load_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666213);
		NativeMethodInfoPtr__load_Private_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666214);
		NativeMethodInfoPtr___load_Private_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666215);
		NativeMethodInfoPtr_start_Public_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666216);
		NativeMethodInfoPtr__start_Public_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666217);
		NativeMethodInfoPtr___start_Public_Static_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666218);
		NativeMethodInfoPtr_stop_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666219);
		NativeMethodInfoPtr__stop_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666220);
		NativeMethodInfoPtr___stop_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666221);
		NativeMethodInfoPtr_playSound_Public_Static_Void_Il2CppStructArray_1_Byte_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666222);
		NativeMethodInfoPtr_InitializeAudioPool_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666223);
		NativeMethodInfoPtr_GetAudioSourceFromPool_Private_Static_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666224);
		NativeMethodInfoPtr_ReturnAudioSourceToPool_Private_Static_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666225);
		NativeMethodInfoPtr_ReturnToPoolAfterPlay_Private_Static_IEnumerator_AudioSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666226);
		NativeMethodInfoPtr_GetOrCreateAudioClip_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666227);
		NativeMethodInfoPtr_GetAudioHash_Private_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666228);
		NativeMethodInfoPtr_CreateAudioClipFromBytesOptimized_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666229);
		NativeMethodInfoPtr_CreateAudioClipFromBytes_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666230);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sound>.NativeClassPtr, 100666231);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void setActivity(SoundMn.AssetManager ac)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ac);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setActivity_Public_Static_Void_AssetManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96385, XrefRangeEnd = 96403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void stop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stop_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(89)]
	[CachedScanResults(RefRangeStart = 14330, RefRangeEnd = 14419, XrefRangeStart = 14330, XrefRangeEnd = 14419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPlaying()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPlaying_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96403, XrefRangeEnd = 96427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96495, RefRangeEnd = 96496, XrefRangeStart = 96427, XrefRangeEnd = 96495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void init(Il2CppStructArray<int> musicID, Il2CppStructArray<int> sID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)musicID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_init_Public_Static_Void_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96501, RefRangeEnd = 96502, XrefRangeStart = 96496, XrefRangeEnd = 96501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playSound(int id, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playSound_Public_Static_Void_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96502, XrefRangeEnd = 96506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playSound1(int id, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playSound1_Public_Static_Void_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96530, RefRangeEnd = 96531, XrefRangeStart = 96506, XrefRangeEnd = 96530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void getAssetSoundFile(string fileName, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getAssetSoundFile_Public_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96531, XrefRangeEnd = 96552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void stopAllz()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopAllz_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96552, XrefRangeEnd = 96586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void stopAllBg()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopAllBg_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96586, XrefRangeEnd = 96594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void stopMusic(int x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopMusic_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 96615, RefRangeEnd = 96647, XrefRangeStart = 96594, XrefRangeEnd = 96615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void play(int id, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_play_Public_Static_Void_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96647, XrefRangeEnd = 96679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playSoundRun(int id, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playSoundRun_Public_Static_Void_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96679, XrefRangeEnd = 96688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sTopSoundRun()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sTopSoundRun_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96688, XrefRangeEnd = 96703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPlayingSound()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPlayingSound_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96703, XrefRangeEnd = 96735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playSoundNatural(int id, float volume, bool isLoop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLoop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playSoundNatural_Public_Static_Void_Int32_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96735, XrefRangeEnd = 96744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void stopSoundNatural(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stopSoundNatural_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96744, XrefRangeEnd = 96759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPlayingSoundatural(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPlayingSoundatural_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 96765, RefRangeEnd = 96768, XrefRangeStart = 96759, XrefRangeEnd = 96765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playMus(int type, float vl, bool loop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vl;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &loop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playMus_Public_Static_Void_Int32_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96821, RefRangeEnd = 96822, XrefRangeStart = 96768, XrefRangeEnd = 96821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playSoundBGLoop(int id, float volume)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playSoundBGLoop_Public_Static_Void_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96822, XrefRangeEnd = 96831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sTopSoundBG(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sTopSoundBG_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96831, XrefRangeEnd = 96846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPlayingSoundBG(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPlayingSoundBG_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96846, XrefRangeEnd = 96860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void load(string filename, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_load_Public_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96894, RefRangeEnd = 96896, XrefRangeStart = 96860, XrefRangeEnd = 96894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _load(string filename, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__load_Private_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96924, RefRangeEnd = 96926, XrefRangeStart = 96896, XrefRangeEnd = 96924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __load(string filename, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___load_Private_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96926, XrefRangeEnd = 96940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void start(float volume, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&volume);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_start_Public_Static_Void_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 96971, RefRangeEnd = 96973, XrefRangeStart = 96940, XrefRangeEnd = 96971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _start(float volume, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&volume);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__start_Public_Static_Void_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 96997, RefRangeEnd = 96998, XrefRangeStart = 96973, XrefRangeEnd = 96997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __start(float volume, int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&volume);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___start_Public_Static_Void_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 97032, RefRangeEnd = 97039, XrefRangeStart = 96998, XrefRangeEnd = 97032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void stop(int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_stop_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97039, XrefRangeEnd = 97062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _stop(int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__stop_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97062, XrefRangeEnd = 97077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void __stop(int pos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___stop_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 97184, RefRangeEnd = 97186, XrefRangeStart = 97077, XrefRangeEnd = 97184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void playSound(Il2CppStructArray<byte> sounds, float volume = 1f, bool loop = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sounds);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &volume;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &loop;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_playSound_Public_Static_Void_Il2CppStructArray_1_Byte_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 97232, RefRangeEnd = 97234, XrefRangeStart = 97186, XrefRangeEnd = 97232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeAudioPool()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeAudioPool_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97234, XrefRangeEnd = 97257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSource GetAudioSourceFromPool()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAudioSourceFromPool_Private_Static_AudioSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 97270, RefRangeEnd = 97272, XrefRangeStart = 97257, XrefRangeEnd = 97270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReturnAudioSourceToPool(AudioSource audioSource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnAudioSourceToPool_Private_Static_Void_AudioSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97272, XrefRangeEnd = 97277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator ReturnToPoolAfterPlay(AudioSource audioSource, float delay)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioSource);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delay;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnToPoolAfterPlay_Private_Static_IEnumerator_AudioSource_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 97320, RefRangeEnd = 97321, XrefRangeStart = 97277, XrefRangeEnd = 97320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip GetOrCreateAudioClip(Il2CppStructArray<byte> audioData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateAudioClip_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97321, XrefRangeEnd = 97324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetAudioHash(Il2CppStructArray<byte> audioData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAudioHash_Private_Static_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 97364, RefRangeEnd = 97366, XrefRangeStart = 97324, XrefRangeEnd = 97364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip CreateAudioClipFromBytesOptimized(Il2CppStructArray<byte> audioData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAudioClipFromBytesOptimized_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97366, XrefRangeEnd = 97370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip CreateAudioClipFromBytes(Il2CppStructArray<byte> audioData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)audioData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAudioClipFromBytes_Private_Static_AudioClip_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sound()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sound>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Sound(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
