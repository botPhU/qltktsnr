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

namespace Il2CppAssets.Scripts.Assembly_CSharp.HSNR;

public class AutoPick : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAutoPick;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimePickedItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumPickDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTeleportToItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPickAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_pickByList;

	private static readonly System.IntPtr NativeFieldInfoPtr_listItemAutoPick;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputMaximumPickDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputItemID;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoNRSD;

	private static readonly System.IntPtr NativeMethodInfoPtr_getInstance_Public_Static_AutoPick_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_smethod_0_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_smethod_1_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FocusToNearestItem_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickIt_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPickIt_Private_Static_Boolean_ItemMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNRDMap_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNRD_Private_Static_Boolean_ItemMap_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AutoPick _Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoPick>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)autoPick));
		}
	}

	public unsafe static bool isAutoPick
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAutoPick, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAutoPick, (void*)(&flag));
		}
	}

	public unsafe static long lastTimePickedItem
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimePickedItem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimePickedItem, (void*)(&num));
		}
	}

	public unsafe static int maximumPickDistance
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maximumPickDistance, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maximumPickDistance, (void*)(&num));
		}
	}

	public unsafe static bool isTeleportToItem
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isTeleportToItem, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isTeleportToItem, (void*)(&flag));
		}
	}

	public unsafe static bool isPickAll
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isPickAll, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isPickAll, (void*)(&flag));
		}
	}

	public unsafe static int pickByList
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pickByList, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pickByList, (void*)(&num));
		}
	}

	public unsafe static List<int> listItemAutoPick
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_listItemAutoPick, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_listItemAutoPick, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
		}
	}

	public unsafe static Il2CppStringArray inputMaximumPickDistance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputMaximumPickDistance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputMaximumPickDistance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static Il2CppStringArray inputItemID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inputItemID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inputItemID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe bool autoNRSD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoNRSD);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoNRSD)) = flag;
		}
	}

	static AutoPick()
	{
		Il2CppClassPointerStore<AutoPick>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Assets.Scripts.Assembly_CSharp.HSNR", "AutoPick");
		NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "_Instance");
		NativeFieldInfoPtr_isAutoPick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "isAutoPick");
		NativeFieldInfoPtr_lastTimePickedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "lastTimePickedItem");
		NativeFieldInfoPtr_maximumPickDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "maximumPickDistance");
		NativeFieldInfoPtr_isTeleportToItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "isTeleportToItem");
		NativeFieldInfoPtr_isPickAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "isPickAll");
		NativeFieldInfoPtr_pickByList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "pickByList");
		NativeFieldInfoPtr_listItemAutoPick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "listItemAutoPick");
		NativeFieldInfoPtr_inputMaximumPickDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "inputMaximumPickDistance");
		NativeFieldInfoPtr_inputItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "inputItemID");
		NativeFieldInfoPtr_autoNRSD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, "autoNRSD");
		NativeMethodInfoPtr_getInstance_Public_Static_AutoPick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667139);
		NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667140);
		NativeMethodInfoPtr_onChatFromMe_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667141);
		NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667142);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667143);
		NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667144);
		NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667145);
		NativeMethodInfoPtr_smethod_0_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667146);
		NativeMethodInfoPtr_smethod_1_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667147);
		NativeMethodInfoPtr_FocusToNearestItem_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667148);
		NativeMethodInfoPtr_PickIt_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667149);
		NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667150);
		NativeMethodInfoPtr_isPickIt_Private_Static_Boolean_ItemMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667151);
		NativeMethodInfoPtr_isNRDMap_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667152);
		NativeMethodInfoPtr_isNRD_Private_Static_Boolean_ItemMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667153);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoPick>.NativeClassPtr, 100667155);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 127515, RefRangeEnd = 127526, XrefRangeStart = 127501, XrefRangeEnd = 127515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AutoPick getInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getInstance_Public_Static_AutoPick_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoPick>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 127595, RefRangeEnd = 127596, XrefRangeStart = 127526, XrefRangeEnd = 127595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127596, XrefRangeEnd = 127653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127653, XrefRangeEnd = 127664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onCancelChat()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onCancelChat_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 127699, RefRangeEnd = 127701, XrefRangeStart = 127664, XrefRangeEnd = 127699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127701, XrefRangeEnd = 127840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowMenu()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowMenu_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127840, XrefRangeEnd = 127851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetChatTextField()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetChatTextField_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void smethod_0()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_smethod_0_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4741)]
	[CachedScanResults(RefRangeStart = 2110, RefRangeEnd = 6851, XrefRangeStart = 2110, XrefRangeEnd = 6851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void smethod_1()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_smethod_1_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 127902, RefRangeEnd = 127907, XrefRangeStart = 127851, XrefRangeEnd = 127902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FocusToNearestItem()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FocusToNearestItem_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 127978, RefRangeEnd = 127981, XrefRangeStart = 127907, XrefRangeEnd = 127978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PickIt()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickIt_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 128000, RefRangeEnd = 128002, XrefRangeStart = 127981, XrefRangeEnd = 128000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TeleportTo(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TeleportTo_Private_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128002, XrefRangeEnd = 128016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPickIt(ItemMap item)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPickIt_Private_Static_Boolean_ItemMap_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115336, RefRangeEnd = 115337, XrefRangeStart = 115336, XrefRangeEnd = 115337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isNRDMap(int mapID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mapID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNRDMap_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool isNRD(ItemMap item)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)item);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNRD_Private_Static_Boolean_ItemMap_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AutoPick()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoPick>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public AutoPick(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
