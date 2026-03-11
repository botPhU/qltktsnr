using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class Controller : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_me;

	private static readonly System.IntPtr NativeFieldInfoPtr_me2;

	private static readonly System.IntPtr NativeFieldInfoPtr_messWait;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoadingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_count_Batch;

	private static readonly System.IntPtr NativeFieldInfoPtr_max_Batch;

	private static readonly System.IntPtr NativeFieldInfoPtr_isConnectOK;

	private static readonly System.IntPtr NativeFieldInfoPtr_isConnectionFail;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDisconnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMain;

	private static readonly System.IntPtr NativeFieldInfoPtr_demCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_move;

	private static readonly System.IntPtr NativeFieldInfoPtr_total;

	private static readonly System.IntPtr NativeFieldInfoPtr_isStopReadMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameHT_NEWBOSS;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHUBAN_TYPE_CHIENTRUONGNAMEK;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHUBAN_START;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHUBAN_UPDATE_POINT;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHUBAN_END;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHUBAN_LIFE;

	private static readonly System.IntPtr NativeFieldInfoPtr_PHUBAN_INFO;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemSum;

	private static readonly System.IntPtr NativeFieldInfoPtr_partSum;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_Controller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI2_Public_Static_Controller_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onConnectOK_Public_Virtual_Final_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onConnectionFail_Public_Virtual_Final_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onDisconnected_Public_Virtual_Final_New_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_requestItemPlayer_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onMessage_Public_Virtual_Final_New_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createSkill_Private_Void_myReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createMap_Private_Void_myReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createData_Private_Void_myReader_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createImage_Private_Image_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_arrayByte2Int_Public_Il2CppStructArray_1_Int32_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readClanMsg_Public_Void_Message_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadCurrMap_Public_Void_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadInfoMap_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_keyValueAction_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_messageNotMap_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_messageNotLogin_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_messageSubCommand_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_useSkill_Private_Void_Skill_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readCharInfo_Public_Boolean_Char_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readGetImgByName_Private_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_createItemNew_Private_Void_myReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_loadItemNew_Private_Void_myReader_SByte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readFrameBoss_Private_Void_Message_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readArrHead_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_myReader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_phuban_Info_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readPhuBan_CHIENTRUONGNAMEK_Private_Void_Message_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_opt_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_read_UpdateSkill_Public_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Controller me
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_me, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_me, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller));
		}
	}

	public unsafe static Controller me2
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_me2, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controller>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_me2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)controller));
		}
	}

	public unsafe Message messWait
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messWait);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Message>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messWait)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message));
		}
	}

	public unsafe static bool isLoadingData
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isLoadingData, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isLoadingData, (void*)(&flag));
		}
	}

	public unsafe static int count_Batch
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_count_Batch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_count_Batch, (void*)(&num));
		}
	}

	public unsafe static int max_Batch
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_max_Batch, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_max_Batch, (void*)(&num));
		}
	}

	public unsafe static bool isConnectOK
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isConnectOK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isConnectOK, (void*)(&flag));
		}
	}

	public unsafe static bool isConnectionFail
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isConnectionFail, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isConnectionFail, (void*)(&flag));
		}
	}

	public unsafe static bool isDisconnected
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isDisconnected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isDisconnected, (void*)(&flag));
		}
	}

	public unsafe static bool isMain
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isMain, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isMain, (void*)(&flag));
		}
	}

	public unsafe float demCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demCount);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_demCount)) = num;
		}
	}

	public unsafe int move
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_move);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_move)) = num;
		}
	}

	public unsafe int total
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_total);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_total)) = num;
		}
	}

	public unsafe static bool isStopReadMessage
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isStopReadMessage, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isStopReadMessage, (void*)(&flag));
		}
	}

	public unsafe static MyHashTable frameHT_NEWBOSS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_frameHT_NEWBOSS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyHashTable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_frameHT_NEWBOSS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myHashTable));
		}
	}

	public unsafe static sbyte PHUBAN_TYPE_CHIENTRUONGNAMEK
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHUBAN_TYPE_CHIENTRUONGNAMEK, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHUBAN_TYPE_CHIENTRUONGNAMEK, (void*)(&b));
		}
	}

	public unsafe static sbyte PHUBAN_START
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHUBAN_START, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHUBAN_START, (void*)(&b));
		}
	}

	public unsafe static sbyte PHUBAN_UPDATE_POINT
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHUBAN_UPDATE_POINT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHUBAN_UPDATE_POINT, (void*)(&b));
		}
	}

	public unsafe static sbyte PHUBAN_END
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHUBAN_END, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHUBAN_END, (void*)(&b));
		}
	}

	public unsafe static sbyte PHUBAN_LIFE
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHUBAN_LIFE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHUBAN_LIFE, (void*)(&b));
		}
	}

	public unsafe static sbyte PHUBAN_INFO
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PHUBAN_INFO, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PHUBAN_INFO, (void*)(&b));
		}
	}

	public unsafe long itemSum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSum);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemSum)) = num;
		}
	}

	public unsafe long partSum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partSum);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partSum)) = num;
		}
	}

	static Controller()
	{
		Il2CppClassPointerStore<Controller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Controller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Controller>.NativeClassPtr);
		NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "me");
		NativeFieldInfoPtr_me2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "me2");
		NativeFieldInfoPtr_messWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "messWait");
		NativeFieldInfoPtr_isLoadingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "isLoadingData");
		NativeFieldInfoPtr_count_Batch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "count_Batch");
		NativeFieldInfoPtr_max_Batch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "max_Batch");
		NativeFieldInfoPtr_isConnectOK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "isConnectOK");
		NativeFieldInfoPtr_isConnectionFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "isConnectionFail");
		NativeFieldInfoPtr_isDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "isDisconnected");
		NativeFieldInfoPtr_isMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "isMain");
		NativeFieldInfoPtr_demCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "demCount");
		NativeFieldInfoPtr_move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "move");
		NativeFieldInfoPtr_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "total");
		NativeFieldInfoPtr_isStopReadMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "isStopReadMessage");
		NativeFieldInfoPtr_frameHT_NEWBOSS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "frameHT_NEWBOSS");
		NativeFieldInfoPtr_PHUBAN_TYPE_CHIENTRUONGNAMEK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "PHUBAN_TYPE_CHIENTRUONGNAMEK");
		NativeFieldInfoPtr_PHUBAN_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "PHUBAN_START");
		NativeFieldInfoPtr_PHUBAN_UPDATE_POINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "PHUBAN_UPDATE_POINT");
		NativeFieldInfoPtr_PHUBAN_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "PHUBAN_END");
		NativeFieldInfoPtr_PHUBAN_LIFE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "PHUBAN_LIFE");
		NativeFieldInfoPtr_PHUBAN_INFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "PHUBAN_INFO");
		NativeFieldInfoPtr_itemSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "itemSum");
		NativeFieldInfoPtr_partSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Controller>.NativeClassPtr, "partSum");
		NativeMethodInfoPtr_gI_Public_Static_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663753);
		NativeMethodInfoPtr_gI2_Public_Static_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663754);
		NativeMethodInfoPtr_onConnectOK_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663755);
		NativeMethodInfoPtr_onConnectionFail_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663756);
		NativeMethodInfoPtr_onDisconnected_Public_Virtual_Final_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663757);
		NativeMethodInfoPtr_requestItemPlayer_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663758);
		NativeMethodInfoPtr_onMessage_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663759);
		NativeMethodInfoPtr_createSkill_Private_Void_myReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663760);
		NativeMethodInfoPtr_createMap_Private_Void_myReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663761);
		NativeMethodInfoPtr_createData_Private_Void_myReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663762);
		NativeMethodInfoPtr_createImage_Private_Image_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663763);
		NativeMethodInfoPtr_arrayByte2Int_Public_Il2CppStructArray_1_Int32_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663764);
		NativeMethodInfoPtr_readClanMsg_Public_Void_Message_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663765);
		NativeMethodInfoPtr_loadCurrMap_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663766);
		NativeMethodInfoPtr_loadInfoMap_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663767);
		NativeMethodInfoPtr_keyValueAction_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663768);
		NativeMethodInfoPtr_messageNotMap_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663769);
		NativeMethodInfoPtr_messageNotLogin_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663770);
		NativeMethodInfoPtr_messageSubCommand_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663771);
		NativeMethodInfoPtr_useSkill_Private_Void_Skill_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663772);
		NativeMethodInfoPtr_readCharInfo_Public_Boolean_Char_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663773);
		NativeMethodInfoPtr_readGetImgByName_Private_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663774);
		NativeMethodInfoPtr_createItemNew_Private_Void_myReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663775);
		NativeMethodInfoPtr_loadItemNew_Private_Void_myReader_SByte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663776);
		NativeMethodInfoPtr_readFrameBoss_Private_Void_Message_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663777);
		NativeMethodInfoPtr_readArrHead_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_myReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663778);
		NativeMethodInfoPtr_phuban_Info_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663779);
		NativeMethodInfoPtr_readPhuBan_CHIENTRUONGNAMEK_Private_Void_Message_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663780);
		NativeMethodInfoPtr_read_opt_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr_read_UpdateSkill_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Controller>.NativeClassPtr, 100663783);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 17553, RefRangeEnd = 17555, XrefRangeStart = 17539, XrefRangeEnd = 17553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Controller gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_Controller_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controller>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17555, XrefRangeEnd = 17569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Controller gI2()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI2_Public_Static_Controller_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Controller>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17569, XrefRangeEnd = 17577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onConnectOK(bool isMain1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isMain1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onConnectOK_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17577, XrefRangeEnd = 17585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onConnectionFail(bool isMain1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isMain1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onConnectionFail_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17585, XrefRangeEnd = 17593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onDisconnected(bool isMain1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isMain1);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onDisconnected_Public_Virtual_Final_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 17640, RefRangeEnd = 17641, XrefRangeStart = 17593, XrefRangeEnd = 17640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void requestItemPlayer(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_requestItemPlayer_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 25826, RefRangeEnd = 25827, XrefRangeStart = 17641, XrefRangeEnd = 25826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void onMessage(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onMessage_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 25978, RefRangeEnd = 25980, XrefRangeStart = 25827, XrefRangeEnd = 25978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createSkill(myReader d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createSkill_Private_Void_myReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26142, RefRangeEnd = 26144, XrefRangeStart = 25980, XrefRangeEnd = 26142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createMap(myReader d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createMap_Private_Void_myReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26176, RefRangeEnd = 26177, XrefRangeStart = 26144, XrefRangeEnd = 26176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createData(myReader d, bool isSaveRMS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSaveRMS;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createData_Private_Void_myReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26178, RefRangeEnd = 26180, XrefRangeStart = 26177, XrefRangeEnd = 26178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Image createImage(Il2CppStructArray<sbyte> arr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createImage_Private_Image_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26180, XrefRangeEnd = 26184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> arrayByte2Int(Il2CppStructArray<sbyte> b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_arrayByte2Int_Public_Il2CppStructArray_1_Int32_Il2CppStructArray_1_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 26297, RefRangeEnd = 26299, XrefRangeStart = 26184, XrefRangeEnd = 26297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readClanMsg(Message msg, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readClanMsg_Public_Void_Message_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26531, RefRangeEnd = 26532, XrefRangeStart = 26299, XrefRangeEnd = 26531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadCurrMap(sbyte teleport3)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&teleport3);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadCurrMap_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 27242, RefRangeEnd = 27244, XrefRangeStart = 26532, XrefRangeEnd = 27242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadInfoMap(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadInfoMap_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27263, RefRangeEnd = 27264, XrefRangeStart = 27244, XrefRangeEnd = 27263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void keyValueAction(string key, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_keyValueAction_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27836, RefRangeEnd = 27837, XrefRangeStart = 27264, XrefRangeEnd = 27836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void messageNotMap(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_messageNotMap_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27881, RefRangeEnd = 27882, XrefRangeStart = 27837, XrefRangeEnd = 27881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void messageNotLogin(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_messageNotLogin_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29104, RefRangeEnd = 29105, XrefRangeStart = 27882, XrefRangeEnd = 29104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void messageSubCommand(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_messageSubCommand_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 29135, RefRangeEnd = 29138, XrefRangeStart = 29105, XrefRangeEnd = 29135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void useSkill(Skill skill)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skill);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_useSkill_Private_Void_Skill_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29260, RefRangeEnd = 29262, XrefRangeStart = 29138, XrefRangeEnd = 29260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool readCharInfo(Char c, Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readCharInfo_Public_Boolean_Char_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29274, RefRangeEnd = 29275, XrefRangeStart = 29262, XrefRangeEnd = 29274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readGetImgByName(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readGetImgByName_Private_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29280, RefRangeEnd = 29281, XrefRangeStart = 29275, XrefRangeEnd = 29280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void createItemNew(myReader d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_createItemNew_Private_Void_myReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 29544, RefRangeEnd = 29549, XrefRangeStart = 29281, XrefRangeEnd = 29544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void loadItemNew(myReader d, sbyte type, bool isSave)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		*(sbyte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSave;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_loadItemNew_Private_Void_myReader_SByte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29571, RefRangeEnd = 29572, XrefRangeStart = 29549, XrefRangeEnd = 29571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readFrameBoss(Message msg, int mobTemplateId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mobTemplateId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readFrameBoss_Private_Void_Message_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29590, RefRangeEnd = 29591, XrefRangeStart = 29572, XrefRangeEnd = 29590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> readArrHead(myReader d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readArrHead_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_myReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29594, RefRangeEnd = 29595, XrefRangeStart = 29591, XrefRangeEnd = 29594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void phuban_Info(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_phuban_Info_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29655, RefRangeEnd = 29656, XrefRangeStart = 29595, XrefRangeEnd = 29655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void readPhuBan_CHIENTRUONGNAMEK(Message msg, int type_PB)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type_PB;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readPhuBan_CHIENTRUONGNAMEK_Private_Void_Message_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29668, RefRangeEnd = 29669, XrefRangeStart = 29656, XrefRangeEnd = 29668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void read_opt(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_opt_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29797, RefRangeEnd = 29798, XrefRangeStart = 29669, XrefRangeEnd = 29797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void read_UpdateSkill(Message msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_read_UpdateSkill_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Controller()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Controller>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Controller(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
