using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class GameMidlet : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IP;

	private static readonly System.IntPtr NativeFieldInfoPtr_PORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_IP2;

	private static readonly System.IntPtr NativeFieldInfoPtr_PORT2;

	private static readonly System.IntPtr NativeFieldInfoPtr_VOICE_PORT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PROVIDER;

	private static readonly System.IntPtr NativeFieldInfoPtr_VERSION;

	private static readonly System.IntPtr NativeFieldInfoPtr_gameCanvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isConnect2;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBackWindowsPhone;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initGame_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_exit_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendSMS_Public_Static_Void_String_String_Command_Command_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_flatForm_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_notifyDestroyed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_platformRequest_Public_Void_String_0;

	public unsafe static string IP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IP, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IP, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int PORT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PORT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PORT, (void*)(&num));
		}
	}

	public unsafe static string IP2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IP2, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IP2, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int PORT2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PORT2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PORT2, (void*)(&num));
		}
	}

	public unsafe static int VOICE_PORT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VOICE_PORT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VOICE_PORT, (void*)(&num));
		}
	}

	public unsafe static sbyte PROVIDER
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PROVIDER, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PROVIDER, (void*)(&b));
		}
	}

	public unsafe static string VERSION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_VERSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_VERSION, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static GameCanvas gameCanvas
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gameCanvas, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameCanvas>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gameCanvas, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameCanvas));
		}
	}

	public unsafe static GameMidlet instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameMidlet>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameMidlet));
		}
	}

	public unsafe static bool isConnect2
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isConnect2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isConnect2, (void*)(&flag));
		}
	}

	public unsafe static bool isBackWindowsPhone
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isBackWindowsPhone, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isBackWindowsPhone, (void*)(&flag));
		}
	}

	static GameMidlet()
	{
		Il2CppClassPointerStore<GameMidlet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GameMidlet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr);
		NativeFieldInfoPtr_IP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "IP");
		NativeFieldInfoPtr_PORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "PORT");
		NativeFieldInfoPtr_IP2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "IP2");
		NativeFieldInfoPtr_PORT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "PORT2");
		NativeFieldInfoPtr_VOICE_PORT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "VOICE_PORT");
		NativeFieldInfoPtr_PROVIDER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "PROVIDER");
		NativeFieldInfoPtr_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "VERSION");
		NativeFieldInfoPtr_gameCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "gameCanvas");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_isConnect2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "isConnect2");
		NativeFieldInfoPtr_isBackWindowsPhone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, "isBackWindowsPhone");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, 100664115);
		NativeMethodInfoPtr_initGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, 100664116);
		NativeMethodInfoPtr_exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, 100664117);
		NativeMethodInfoPtr_sendSMS_Public_Static_Void_String_String_Command_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, 100664118);
		NativeMethodInfoPtr_flatForm_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_notifyDestroyed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_platformRequest_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr, 100664121);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40427, RefRangeEnd = 40428, XrefRangeStart = 40425, XrefRangeEnd = 40427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameMidlet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameMidlet>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40482, RefRangeEnd = 40483, XrefRangeStart = 40428, XrefRangeEnd = 40482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initGame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 40503, RefRangeEnd = 40507, XrefRangeStart = 40483, XrefRangeEnd = 40503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void exit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40507, XrefRangeEnd = 40510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void sendSMS(string data, string to, Command successAction, Command failAction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(to);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)successAction);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)failAction);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendSMS_Public_Static_Void_String_String_Command_Command_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40510, XrefRangeEnd = 40518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void flatForm(string url)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_flatForm_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40522, RefRangeEnd = 40523, XrefRangeStart = 40518, XrefRangeEnd = 40522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void notifyDestroyed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_notifyDestroyed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 40531, RefRangeEnd = 40532, XrefRangeStart = 40523, XrefRangeEnd = 40531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void platformRequest(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_platformRequest_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameMidlet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
