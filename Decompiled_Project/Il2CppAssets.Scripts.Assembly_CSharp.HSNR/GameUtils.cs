using System;
using System.Runtime.CompilerServices;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppAssets.Scripts.Assembly_CSharp.HSNR;

public class GameUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__instance_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeUse;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeChat;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeChatGlobal;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_GameUtils_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_instance_Private_Static_set_Void_GameUtils_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_GameUtils_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_useItemWithTime_Public_Void_Int32_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseItem_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_focusManual_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetFocus_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_saveBoolean_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetYGround_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapToX_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GotoNpc_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindIndexItem_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_startChat_Public_Void_IChatable_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GotoXY_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chatWithTime_Public_Void_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tf_Private_get_ChatTextField_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_resetTF_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chatGlobalWithTime_Public_Void_String_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FocusTo_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExistItem_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static GameUtils _instance_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__instance_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameUtils>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameUtils));
		}
	}

	public unsafe long timeUse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeUse);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeUse)) = num;
		}
	}

	public unsafe long timeChat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeChat);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeChat)) = num;
		}
	}

	public unsafe long timeChatGlobal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeChatGlobal);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeChatGlobal)) = num;
		}
	}

	public unsafe static GameUtils instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131393, XrefRangeEnd = 131395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Private_Static_get_GameUtils_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameUtils>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131395, XrefRangeEnd = 131399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_instance_Private_Static_set_Void_GameUtils_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	public unsafe ChatTextField tf
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tf_Private_get_ChatTextField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChatTextField>(intPtr) : null;
		}
	}

	static GameUtils()
	{
		Il2CppClassPointerStore<GameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.Assembly_CSharp.HSNR", "GameUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameUtils>.NativeClassPtr);
		NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, "<instance>k__BackingField");
		NativeFieldInfoPtr_timeUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, "timeUse");
		NativeFieldInfoPtr_timeChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, "timeChat");
		NativeFieldInfoPtr_timeChatGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, "timeChatGlobal");
		NativeMethodInfoPtr_get_instance_Private_Static_get_GameUtils_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr_set_instance_Private_Static_set_Void_GameUtils_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667242);
		NativeMethodInfoPtr_gI_Public_Static_GameUtils_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_useItemWithTime_Public_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_UseItem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_focusManual_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_ResetFocus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_saveBoolean_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667248);
		NativeMethodInfoPtr_GetYGround_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667249);
		NativeMethodInfoPtr_MapToX_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667250);
		NativeMethodInfoPtr_GotoNpc_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667251);
		NativeMethodInfoPtr_FindIndexItem_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667252);
		NativeMethodInfoPtr_startChat_Public_Void_IChatable_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667253);
		NativeMethodInfoPtr_GotoXY_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_chatWithTime_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_get_tf_Private_get_ChatTextField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667256);
		NativeMethodInfoPtr_resetTF_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667257);
		NativeMethodInfoPtr_chatGlobalWithTime_Public_Void_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667258);
		NativeMethodInfoPtr_FocusTo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667259);
		NativeMethodInfoPtr_IsExistItem_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667260);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameUtils>.NativeClassPtr, 100667261);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 131411, RefRangeEnd = 131433, XrefRangeStart = 131399, XrefRangeEnd = 131411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameUtils gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_GameUtils_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameUtils>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131446, RefRangeEnd = 131447, XrefRangeStart = 131433, XrefRangeEnd = 131446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void useItemWithTime(int id, long time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_useItemWithTime_Public_Void_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 131463, RefRangeEnd = 131467, XrefRangeStart = 131447, XrefRangeEnd = 131463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseItem(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseItem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131467, XrefRangeEnd = 131505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void focusManual()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_focusManual_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131505, XrefRangeEnd = 131517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetFocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetFocus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131517, XrefRangeEnd = 131518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void saveBoolean(string data, bool boolean)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boolean;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_saveBoolean_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131518, XrefRangeEnd = 131522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetYGround(int a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetYGround_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131522, XrefRangeEnd = 131526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int MapToX(int xSd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&xSd);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapToX_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131526, XrefRangeEnd = 131548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GotoNpc(int npcID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GotoNpc_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131548, XrefRangeEnd = 131556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindIndexItem(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindIndexItem_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131556, XrefRangeEnd = 131572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void startChat(IChatable chatable, string name, string text, int typeInput)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chatable);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeInput;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_startChat_Public_Void_IChatable_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 131583, RefRangeEnd = 131587, XrefRangeStart = 131572, XrefRangeEnd = 131583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GotoXY(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GotoXY_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131587, XrefRangeEnd = 131599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chatWithTime(string chat, long time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chat);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatWithTime_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 131627, RefRangeEnd = 131637, XrefRangeStart = 131599, XrefRangeEnd = 131627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resetTF()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_resetTF_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131637, XrefRangeEnd = 131649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void chatGlobalWithTime(string chat, long time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chat);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chatGlobalWithTime_Public_Void_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 131670, RefRangeEnd = 131671, XrefRangeStart = 131649, XrefRangeEnd = 131670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FocusTo(int charId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&charId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FocusTo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 131676, RefRangeEnd = 131679, XrefRangeStart = 131671, XrefRangeEnd = 131676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsExistItem(int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExistItem_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameUtils()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameUtils>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GameUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
