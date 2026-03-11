using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Sockets;
using Il2CppSystem.Threading;

namespace Il2Cpp;

public class Session_ME2 : Il2CppSystem.Object
{
	public class Sender : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lockObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_sendingMessage;

		private static readonly System.IntPtr NativeFieldInfoPtr_isRunning;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_AddMessage_Public_Void_Message_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_run_Public_Void_0;

		public unsafe Il2CppSystem.Object lockObject
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockObject);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
			}
		}

		public unsafe List<Message> sendingMessage
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendingMessage);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Message>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sendingMessage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list));
			}
		}

		public unsafe bool isRunning
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRunning);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRunning)) = flag;
			}
		}

		static Sender()
		{
			Il2CppClassPointerStore<Sender>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "Sender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sender>.NativeClassPtr);
			NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sender>.NativeClassPtr, "lockObject");
			NativeFieldInfoPtr_sendingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sender>.NativeClassPtr, "sendingMessage");
			NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sender>.NativeClassPtr, "isRunning");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666061);
			NativeMethodInfoPtr_AddMessage_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666062);
			NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666063);
			NativeMethodInfoPtr_run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666064);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94156, XrefRangeEnd = 94169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sender()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sender>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94169, XrefRangeEnd = 94178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMessage(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMessage_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94178, XrefRangeEnd = 94215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public Sender(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class MessageCollector : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_readBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_isRunning;

		private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_run_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_getKey_Private_Void_Message_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_readMessage2_Private_Message_SByte_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_readMessage_Private_Message_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppStructArray<byte> readBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
			}
		}

		public unsafe bool isRunning
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRunning);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRunning)) = flag;
			}
		}

		static MessageCollector()
		{
			Il2CppClassPointerStore<MessageCollector>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "MessageCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr);
			NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, "readBuffer");
			NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, "isRunning");
			NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666065);
			NativeMethodInfoPtr_run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666066);
			NativeMethodInfoPtr_getKey_Private_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666067);
			NativeMethodInfoPtr_readMessage2_Private_Message_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666068);
			NativeMethodInfoPtr_readMessage_Private_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666069);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666070);
		}

		[CallerCount(0)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94215, XrefRangeEnd = 94260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94307, RefRangeEnd = 94308, XrefRangeStart = 94260, XrefRangeEnd = 94307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void getKey(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getKey_Private_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94427, RefRangeEnd = 94428, XrefRangeStart = 94308, XrefRangeEnd = 94427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message readMessage2(sbyte cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&cmd);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readMessage2_Private_Message_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Message>(intPtr) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94522, RefRangeEnd = 94523, XrefRangeStart = 94428, XrefRangeEnd = 94522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message readMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readMessage_Private_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Message>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94523, XrefRangeEnd = 94528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageCollector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		public MessageCollector(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataStream;

	private static readonly System.IntPtr NativeFieldInfoPtr_dis;

	private static readonly System.IntPtr NativeFieldInfoPtr_dos;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_isMainSession;

	private static readonly System.IntPtr NativeFieldInfoPtr_sc;

	private static readonly System.IntPtr NativeFieldInfoPtr_connected;

	private static readonly System.IntPtr NativeFieldInfoPtr_connecting;

	private static readonly System.IntPtr NativeFieldInfoPtr_sender;

	private static readonly System.IntPtr NativeFieldInfoPtr_initThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_collectorThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_sendByteCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_recvByteCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_getKeyComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeFieldInfoPtr_curR;

	private static readonly System.IntPtr NativeFieldInfoPtr_curW;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeConn;

	private static readonly System.IntPtr NativeFieldInfoPtr_strRecvByteCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_host;

	private static readonly System.IntPtr NativeFieldInfoPtr_port;

	private static readonly System.IntPtr NativeFieldInfoPtr_recieveMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_recieveMsgLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDisposed;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONNECTION_TIMEOUT;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearSendingMessage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_Session_ME2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isConnected_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setHandler_Public_Virtual_Final_New_Void_IMessageHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_connect_Public_Virtual_Final_New_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doConnect_Public_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sendMessage_Public_Virtual_Final_New_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doSendMessage_Private_Static_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_readKey_Public_Static_SByte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_writeKey_Public_Static_SByte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_onRecieveMsg_Public_Static_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_enqueueMessage_Public_Static_Void_Message_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_close_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_cleanNetwork_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_currentTimeMillis_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__NetworkInit_b__37_0_Private_Void_0;

	public unsafe static Session_ME2 instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Session_ME2>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)session_ME));
		}
	}

	public unsafe static NetworkStream dataStream
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dataStream, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkStream>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dataStream, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)networkStream));
		}
	}

	public unsafe static BinaryReader dis
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dis, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dis, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binaryReader));
		}
	}

	public unsafe static BinaryWriter dos
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dos, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dos, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)binaryWriter));
		}
	}

	public unsafe static IMessageHandler messageHandler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_messageHandler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessageHandler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_messageHandler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messageHandler));
		}
	}

	public unsafe static bool isMainSession
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isMainSession, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isMainSession, (void*)(&flag));
		}
	}

	public unsafe static TcpClient sc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sc, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TcpClient>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sc, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tcpClient));
		}
	}

	public unsafe static bool connected
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_connected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_connected, (void*)(&flag));
		}
	}

	public unsafe static bool connecting
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_connecting, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_connecting, (void*)(&flag));
		}
	}

	public unsafe static Sender sender
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sender, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sender>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sender, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sender));
		}
	}

	public unsafe static Thread initThread
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initThread, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initThread, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe static Thread collectorThread
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_collectorThread, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_collectorThread, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe static Thread sendThread
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sendThread, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sendThread, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe static int sendByteCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sendByteCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sendByteCount, (void*)(&num));
		}
	}

	public unsafe static int recvByteCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_recvByteCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_recvByteCount, (void*)(&num));
		}
	}

	public unsafe static bool getKeyComplete
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getKeyComplete, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getKeyComplete, (void*)(&flag));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> key
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_key, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_key, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static sbyte curR
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curR, (void*)(&b));
		}
	}

	public unsafe static sbyte curW
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_curW, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_curW, (void*)(&b));
		}
	}

	public unsafe static int timeConnected
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeConnected, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeConnected, (void*)(&num));
		}
	}

	public unsafe long lastTimeConn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeConn);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTimeConn)) = num;
		}
	}

	public unsafe static string strRecvByteCount
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_strRecvByteCount, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_strRecvByteCount, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static bool isCancel
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isCancel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isCancel, (void*)(&flag));
		}
	}

	public unsafe string host
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_host);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_host)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int port
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_port);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_port)) = num;
		}
	}

	public unsafe static MyVector recieveMsg
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_recieveMsg, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_recieveMsg, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	public unsafe static Il2CppSystem.Object recieveMsgLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_recieveMsgLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_recieveMsgLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe bool isDisposed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisposed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisposed)) = flag;
		}
	}

	public unsafe static int CONNECTION_TIMEOUT
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CONNECTION_TIMEOUT, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CONNECTION_TIMEOUT, (void*)(&num));
		}
	}

	static Session_ME2()
	{
		Il2CppClassPointerStore<Session_ME2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Session_ME2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_dataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "dataStream");
		NativeFieldInfoPtr_dis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "dis");
		NativeFieldInfoPtr_dos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "dos");
		NativeFieldInfoPtr_messageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "messageHandler");
		NativeFieldInfoPtr_isMainSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "isMainSession");
		NativeFieldInfoPtr_sc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "sc");
		NativeFieldInfoPtr_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "connected");
		NativeFieldInfoPtr_connecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "connecting");
		NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "sender");
		NativeFieldInfoPtr_initThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "initThread");
		NativeFieldInfoPtr_collectorThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "collectorThread");
		NativeFieldInfoPtr_sendThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "sendThread");
		NativeFieldInfoPtr_sendByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "sendByteCount");
		NativeFieldInfoPtr_recvByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "recvByteCount");
		NativeFieldInfoPtr_getKeyComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "getKeyComplete");
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "key");
		NativeFieldInfoPtr_curR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "curR");
		NativeFieldInfoPtr_curW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "curW");
		NativeFieldInfoPtr_timeConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "timeConnected");
		NativeFieldInfoPtr_lastTimeConn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "lastTimeConn");
		NativeFieldInfoPtr_strRecvByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "strRecvByteCount");
		NativeFieldInfoPtr_isCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "isCancel");
		NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "host");
		NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "port");
		NativeFieldInfoPtr_recieveMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "recieveMsg");
		NativeFieldInfoPtr_recieveMsgLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "recieveMsgLock");
		NativeFieldInfoPtr_isDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "isDisposed");
		NativeFieldInfoPtr_CONNECTION_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, "CONNECTION_TIMEOUT");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666039);
		NativeMethodInfoPtr_clearSendingMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666040);
		NativeMethodInfoPtr_gI_Public_Static_Session_ME2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666041);
		NativeMethodInfoPtr_isConnected_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666042);
		NativeMethodInfoPtr_setHandler_Public_Virtual_Final_New_Void_IMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666043);
		NativeMethodInfoPtr_connect_Public_Virtual_Final_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666044);
		NativeMethodInfoPtr_NetworkInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666045);
		NativeMethodInfoPtr_doConnect_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666046);
		NativeMethodInfoPtr_sendMessage_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666047);
		NativeMethodInfoPtr_doSendMessage_Private_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666048);
		NativeMethodInfoPtr_readKey_Public_Static_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666049);
		NativeMethodInfoPtr_writeKey_Public_Static_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666050);
		NativeMethodInfoPtr_onRecieveMsg_Public_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666051);
		NativeMethodInfoPtr_enqueueMessage_Public_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666052);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666053);
		NativeMethodInfoPtr_close_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666054);
		NativeMethodInfoPtr_cleanNetwork_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666055);
		NativeMethodInfoPtr_currentTimeMillis_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666056);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666057);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666058);
		NativeMethodInfoPtr__NetworkInit_b__37_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr, 100666060);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 94535, RefRangeEnd = 94538, XrefRangeStart = 94528, XrefRangeEnd = 94535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Session_ME2()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session_ME2>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94544, RefRangeEnd = 94546, XrefRangeStart = 94538, XrefRangeEnd = 94544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearSendingMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearSendingMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94546, XrefRangeEnd = 94566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Session_ME2 gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_Session_ME2_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Session_ME2>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94566, XrefRangeEnd = 94578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool isConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isConnected_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94584, RefRangeEnd = 94585, XrefRangeStart = 94578, XrefRangeEnd = 94584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void setHandler(IMessageHandler msgHandler)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msgHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setHandler_Public_Virtual_Final_New_Void_IMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94628, RefRangeEnd = 94629, XrefRangeStart = 94585, XrefRangeEnd = 94628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void connect(string host, int port)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_connect_Public_Virtual_Final_New_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94629, XrefRangeEnd = 94678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NetworkInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NetworkInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94783, RefRangeEnd = 94784, XrefRangeStart = 94678, XrefRangeEnd = 94783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void doConnect(string host, int port)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &port;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doConnect_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94784, XrefRangeEnd = 94798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void sendMessage(Message message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendMessage_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 94888, RefRangeEnd = 94890, XrefRangeStart = 94798, XrefRangeEnd = 94888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void doSendMessage(Message m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doSendMessage_Private_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94890, XrefRangeEnd = 94897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte readKey(sbyte b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readKey_Public_Static_SByte_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94897, XrefRangeEnd = 94904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte writeKey(sbyte b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_writeKey_Public_Static_SByte_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94929, RefRangeEnd = 94930, XrefRangeStart = 94904, XrefRangeEnd = 94929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onRecieveMsg(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRecieveMsg_Public_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94930, XrefRangeEnd = 94942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void enqueueMessage(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_enqueueMessage_Public_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 94984, RefRangeEnd = 94985, XrefRangeStart = 94942, XrefRangeEnd = 94984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 94989, RefRangeEnd = 94993, XrefRangeStart = 94985, XrefRangeEnd = 94989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_close_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 95073, RefRangeEnd = 95075, XrefRangeStart = 94993, XrefRangeEnd = 95073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cleanNetwork()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cleanNetwork_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int currentTimeMillis()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_currentTimeMillis_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52093, RefRangeEnd = 52094, XrefRangeStart = 52093, XrefRangeEnd = 52094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte convertSbyteToByte(sbyte var)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&var);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95075, XrefRangeEnd = 95080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> convertSbyteToByte(Il2CppStructArray<sbyte> var)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)var);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95080, XrefRangeEnd = 95136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NetworkInit_b__37_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NetworkInit_b__37_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Session_ME2(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
