using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class mSystem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_strAdmob;

	private static readonly System.IntPtr NativeFieldInfoPtr_loadAdOk;

	private static readonly System.IntPtr NativeFieldInfoPtr_publicID;

	private static readonly System.IntPtr NativeFieldInfoPtr_android_pack;

	private static readonly System.IntPtr NativeFieldInfoPtr_clientType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LANGUAGE;

	private static readonly System.IntPtr NativeFieldInfoPtr_curINAPP;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxINAPP;

	private static readonly System.IntPtr NativeFieldInfoPtr_JAVA;

	private static readonly System.IntPtr NativeFieldInfoPtr_ANDROID;

	private static readonly System.IntPtr NativeFieldInfoPtr_IP_JB;

	private static readonly System.IntPtr NativeFieldInfoPtr_PC;

	private static readonly System.IntPtr NativeFieldInfoPtr_IP_APPSTORE;

	private static readonly System.IntPtr NativeFieldInfoPtr_WINDOWS_PHONE;

	private static readonly System.IntPtr NativeFieldInfoPtr_GOOGLE_PLAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastGCC;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetCurInapp_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getWidth_Public_Static_Int32_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getHeight_Public_Static_Int32_Image_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getTimeCountDown_Public_Static_String_Int64_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_numberTostring2_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_numberTostring_Public_Static_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callHotlinePC_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callHotlineJava_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callHotlineIphone_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_callHotlineWindowsPhone_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_closeBanner_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_showBanner_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createAdmob_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_checkAdComlete_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintPopUp2_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_arraycopy_Public_Static_Void_Il2CppStructArray_1_SByte_Int32_Il2CppStructArray_1_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_arrayReplace_Public_Static_Void_Il2CppStructArray_1_SByte_Int32_byref_Il2CppStructArray_1_SByte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_currentTimeMillis_Public_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_freeData_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertToSbyte_Public_Static_Il2CppStructArray_1_SByte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertToSbyte_Public_Static_Il2CppStructArray_1_SByte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convetToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_currentHour_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_println_Public_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gcc_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_mSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onConnectOK_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onConnectionFail_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onDisconnected_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_exitWP_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paintFlyText_Public_Static_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_endKey_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getFraImage_Public_Static_FrameImage_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadImage_Public_Static_Image_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool isTest
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTest, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTest, (void*)(&flag));
		}
	}

	public unsafe static string strAdmob
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_strAdmob, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_strAdmob, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool loadAdOk
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_loadAdOk, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_loadAdOk, (void*)(&flag));
		}
	}

	public unsafe static string publicID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_publicID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_publicID, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static string android_pack
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_android_pack, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_android_pack, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int clientType
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_clientType, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_clientType, (void*)(&num));
		}
	}

	public unsafe static sbyte LANGUAGE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LANGUAGE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LANGUAGE, (void*)(&b));
		}
	}

	public unsafe static sbyte curINAPP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curINAPP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curINAPP, (void*)(&b));
		}
	}

	public unsafe static sbyte maxINAPP
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxINAPP, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxINAPP, (void*)(&b));
		}
	}

	public unsafe static int JAVA
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JAVA, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JAVA, (void*)(&num));
		}
	}

	public unsafe static int ANDROID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ANDROID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ANDROID, (void*)(&num));
		}
	}

	public unsafe static int IP_JB
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IP_JB, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IP_JB, (void*)(&num));
		}
	}

	public unsafe static int PC
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PC, (void*)(&num));
		}
	}

	public unsafe static int IP_APPSTORE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IP_APPSTORE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IP_APPSTORE, (void*)(&num));
		}
	}

	public unsafe static int WINDOWS_PHONE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WINDOWS_PHONE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WINDOWS_PHONE, (void*)(&num));
		}
	}

	public unsafe static int GOOGLE_PLAY
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GOOGLE_PLAY, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GOOGLE_PLAY, (void*)(&num));
		}
	}

	public unsafe static mSystem instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<mSystem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mSystem2));
		}
	}

	public unsafe static long lastGCC
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastGCC, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastGCC, (void*)(&num));
		}
	}

	static mSystem()
	{
		Il2CppClassPointerStore<mSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "mSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<mSystem>.NativeClassPtr);
		NativeFieldInfoPtr_isTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "isTest");
		NativeFieldInfoPtr_strAdmob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "strAdmob");
		NativeFieldInfoPtr_loadAdOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "loadAdOk");
		NativeFieldInfoPtr_publicID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "publicID");
		NativeFieldInfoPtr_android_pack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "android_pack");
		NativeFieldInfoPtr_clientType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "clientType");
		NativeFieldInfoPtr_LANGUAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "LANGUAGE");
		NativeFieldInfoPtr_curINAPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "curINAPP");
		NativeFieldInfoPtr_maxINAPP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "maxINAPP");
		NativeFieldInfoPtr_JAVA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "JAVA");
		NativeFieldInfoPtr_ANDROID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "ANDROID");
		NativeFieldInfoPtr_IP_JB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "IP_JB");
		NativeFieldInfoPtr_PC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "PC");
		NativeFieldInfoPtr_IP_APPSTORE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "IP_APPSTORE");
		NativeFieldInfoPtr_WINDOWS_PHONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "WINDOWS_PHONE");
		NativeFieldInfoPtr_GOOGLE_PLAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "GOOGLE_PLAY");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_lastGCC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mSystem>.NativeClassPtr, "lastGCC");
		NativeMethodInfoPtr_resetCurInapp_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664967);
		NativeMethodInfoPtr_getWidth_Public_Static_Int32_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664968);
		NativeMethodInfoPtr_getHeight_Public_Static_Int32_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664969);
		NativeMethodInfoPtr_getTimeCountDown_Public_Static_String_Int64_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664970);
		NativeMethodInfoPtr_numberTostring2_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664971);
		NativeMethodInfoPtr_numberTostring_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664972);
		NativeMethodInfoPtr_callHotlinePC_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664973);
		NativeMethodInfoPtr_callHotlineJava_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664974);
		NativeMethodInfoPtr_callHotlineIphone_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664975);
		NativeMethodInfoPtr_callHotlineWindowsPhone_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664976);
		NativeMethodInfoPtr_closeBanner_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664977);
		NativeMethodInfoPtr_showBanner_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664978);
		NativeMethodInfoPtr_createAdmob_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664979);
		NativeMethodInfoPtr_checkAdComlete_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr_paintPopUp2_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_arraycopy_Public_Static_Void_Il2CppStructArray_1_SByte_Int32_Il2CppStructArray_1_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_arrayReplace_Public_Static_Void_Il2CppStructArray_1_SByte_Int32_byref_Il2CppStructArray_1_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_currentTimeMillis_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_freeData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_convertToSbyte_Public_Static_Il2CppStructArray_1_SByte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664986);
		NativeMethodInfoPtr_convertToSbyte_Public_Static_Il2CppStructArray_1_SByte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664987);
		NativeMethodInfoPtr_convetToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664988);
		NativeMethodInfoPtr_ToCharArray_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664989);
		NativeMethodInfoPtr_currentHour_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664990);
		NativeMethodInfoPtr_println_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_gcc_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_gI_Public_Static_mSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_onConnectOK_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_onConnectionFail_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_onDisconnected_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_exitWP_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_paintFlyText_Public_Static_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_endKey_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_getFraImage_Public_Static_FrameImage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_loadImage_Public_Static_Image_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mSystem>.NativeClassPtr, 100665002);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 63300, RefRangeEnd = 63302, XrefRangeStart = 63296, XrefRangeEnd = 63300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void resetCurInapp()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetCurInapp_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63302, XrefRangeEnd = 63307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getWidth(Image img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getWidth_Public_Static_Int32_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63307, XrefRangeEnd = 63314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getHeight(Image img)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)img);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getHeight_Public_Static_Int32_Image_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63332, RefRangeEnd = 63333, XrefRangeStart = 63314, XrefRangeEnd = 63332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string getTimeCountDown(long timeStart, int secondCount, bool isOnlySecond, bool isShortText)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&timeStart);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &secondCount;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOnlySecond;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isShortText;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getTimeCountDown_Public_Static_String_Int64_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63333, XrefRangeEnd = 63365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string numberTostring2(int aa)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&aa);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_numberTostring2_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 63385, RefRangeEnd = 63400, XrefRangeStart = 63365, XrefRangeEnd = 63385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string numberTostring(long number)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&number);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_numberTostring_Public_Static_String_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63406, RefRangeEnd = 63407, XrefRangeStart = 63400, XrefRangeEnd = 63406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void callHotlinePC()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callHotlinePC_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void callHotlineJava()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callHotlineJava_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void callHotlineIphone()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callHotlineIphone_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void callHotlineWindowsPhone()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_callHotlineWindowsPhone_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void closeBanner()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_closeBanner_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void showBanner()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_showBanner_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void createAdmob()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createAdmob_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void checkAdComlete()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkAdComlete_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63408, RefRangeEnd = 63409, XrefRangeStart = 63407, XrefRangeEnd = 63408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintPopUp2(mGraphics g, int x, int y, int w, int h)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintPopUp2_Public_Static_Void_mGraphics_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63409, XrefRangeEnd = 63410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void arraycopy(Il2CppStructArray<sbyte> scr, int scrPos, Il2CppStructArray<sbyte> dest, int destPos, int lenght)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scrPos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destPos;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &lenght;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_arraycopy_Public_Static_Void_Il2CppStructArray_1_SByte_Int32_Il2CppStructArray_1_SByte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63410, XrefRangeEnd = 63415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void arrayReplace(Il2CppStructArray<sbyte> scr, int scrPos, ref Il2CppStructArray<sbyte> dest, int destPos, int lenght)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scrPos;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dest);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destPos;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &lenght;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_arrayReplace_Public_Static_Void_Il2CppStructArray_1_SByte_Int32_byref_Il2CppStructArray_1_SByte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr4 = intPtr;
		dest = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppStructArray<sbyte>(intPtr4));
	}

	[CallerCount(226)]
	[CachedScanResults(RefRangeStart = 63422, RefRangeEnd = 63648, XrefRangeStart = 63415, XrefRangeEnd = 63422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long currentTimeMillis()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_currentTimeMillis_Public_Static_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63648, XrefRangeEnd = 63653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void freeData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_freeData_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63653, XrefRangeEnd = 63657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> convertToSbyte(Il2CppStructArray<byte> scr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertToSbyte_Public_Static_Il2CppStructArray_1_SByte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63657, XrefRangeEnd = 63668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> convertToSbyte(string scr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(scr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertToSbyte_Public_Static_Il2CppStructArray_1_SByte_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63668, XrefRangeEnd = 63672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> convetToByte(Il2CppStructArray<sbyte> scr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convetToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63672, XrefRangeEnd = 63676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> ToCharArray(Il2CppStructArray<sbyte> scr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCharArray_Public_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63676, XrefRangeEnd = 63681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int currentHour()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_currentHour_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63681, XrefRangeEnd = 63685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void println(Il2CppSystem.Object str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)str);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_println_Public_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 63698, RefRangeEnd = 63715, XrefRangeStart = 63685, XrefRangeEnd = 63698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void gcc()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gcc_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63715, XrefRangeEnd = 63729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static mSystem gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_mSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<mSystem>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63733, RefRangeEnd = 63734, XrefRangeStart = 63729, XrefRangeEnd = 63733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onConnectOK()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onConnectOK_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63738, RefRangeEnd = 63739, XrefRangeStart = 63734, XrefRangeEnd = 63738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onConnectionFail()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onConnectionFail_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63743, RefRangeEnd = 63744, XrefRangeStart = 63739, XrefRangeEnd = 63743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onDisconnected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onDisconnected_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void exitWP()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_exitWP_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 63873, RefRangeEnd = 63875, XrefRangeStart = 63744, XrefRangeEnd = 63873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void paintFlyText(mGraphics g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_paintFlyText_Public_Static_Void_mGraphics_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void endKey()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_endKey_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 63886, RefRangeEnd = 63895, XrefRangeStart = 63875, XrefRangeEnd = 63886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FrameImage getFraImage(string nameImg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(nameImg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getFraImage_Public_Static_FrameImage_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FrameImage>(intPtr) : null;
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 63899, RefRangeEnd = 63928, XrefRangeStart = 63895, XrefRangeEnd = 63899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Image loadImage(string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadImage_Public_Static_Image_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe mSystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<mSystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public mSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
