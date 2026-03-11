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

public class Session_ME : Il2CppSystem.Object
{
	public class Sender : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lockObject;

		private static readonly System.IntPtr NativeFieldInfoPtr_sendingMessage;

		private static readonly System.IntPtr NativeFieldInfoPtr_tempBuffer;

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

		public unsafe Il2CppStructArray<byte> tempBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempBuffer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tempBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
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
			Il2CppClassPointerStore<Sender>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "Sender");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sender>.NativeClassPtr);
			NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sender>.NativeClassPtr, "lockObject");
			NativeFieldInfoPtr_sendingMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sender>.NativeClassPtr, "sendingMessage");
			NativeFieldInfoPtr_tempBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sender>.NativeClassPtr, "tempBuffer");
			NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sender>.NativeClassPtr, "isRunning");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666029);
			NativeMethodInfoPtr_AddMessage_Public_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666030);
			NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666031);
			NativeMethodInfoPtr_run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sender>.NativeClassPtr, 100666032);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 92628, RefRangeEnd = 92631, XrefRangeStart = 92611, XrefRangeEnd = 92628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sender()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sender>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92631, XrefRangeEnd = 92640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMessage(Message message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMessage_Public_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 92640, RefRangeEnd = 92643, XrefRangeStart = 92640, XrefRangeEnd = 92640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92643, XrefRangeEnd = 92680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		private static readonly System.IntPtr NativeFieldInfoPtr_lockObject;

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
			Il2CppClassPointerStore<MessageCollector>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "MessageCollector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr);
			NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, "readBuffer");
			NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, "lockObject");
			NativeFieldInfoPtr_isRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, "isRunning");
			NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666033);
			NativeMethodInfoPtr_run_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666034);
			NativeMethodInfoPtr_getKey_Private_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666035);
			NativeMethodInfoPtr_readMessage2_Private_Message_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666036);
			NativeMethodInfoPtr_readMessage_Private_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666037);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageCollector>.NativeClassPtr, 100666038);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92680, XrefRangeEnd = 92733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_run_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92791, RefRangeEnd = 92792, XrefRangeStart = 92733, XrefRangeEnd = 92791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 92914, RefRangeEnd = 92915, XrefRangeStart = 92792, XrefRangeEnd = 92914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 93047, RefRangeEnd = 93048, XrefRangeStart = 92915, XrefRangeEnd = 93047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message readMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_readMessage_Private_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Message>(intPtr) : null;
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93058, RefRangeEnd = 93060, XrefRangeStart = 93048, XrefRangeEnd = 93058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_recieveMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_recieveMsgLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDisposed;

	private static readonly System.IntPtr NativeFieldInfoPtr_CONNECTION_TIMEOUT;

	private static readonly System.IntPtr NativeFieldInfoPtr_reconnectAttempts;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxReconnectAttempts;

	private static readonly System.IntPtr NativeFieldInfoPtr_reconnectDelay;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReconnecting;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastHost;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastPort;

	private static readonly System.IntPtr NativeFieldInfoPtr_reconnectThread;

	private static readonly System.IntPtr NativeFieldInfoPtr_messageCollector;

	private static readonly System.IntPtr NativeFieldInfoPtr_isShuttingDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastConnect;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clearSendingMessage_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_gI_Public_Static_Session_ME_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isConnected_Public_Virtual_Final_New_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setHandler_Public_Virtual_Final_New_Void_IMessageHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReconnectSocket_Public_Boolean_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoReconnectProcess_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartNetworkThreads_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBackoffDelay_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttemptConnection_Private_Boolean_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetConnectionState_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_connect_Public_Virtual_Final_New_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInit_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProxyTcpClient_Public_TcpClient_String_Int32_0;

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

	private static readonly System.IntPtr NativeMethodInfoPtr__ReconnectSocket_b__46_0_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__NetworkInit_b__54_0_Private_Void_0;

	public unsafe static Session_ME instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Session_ME>(intPtr2) : null;
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

	public unsafe static int count
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_count, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_count, (void*)(&num));
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

	public unsafe static int reconnectAttempts
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reconnectAttempts, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reconnectAttempts, (void*)(&num));
		}
	}

	public unsafe static int maxReconnectAttempts
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxReconnectAttempts, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxReconnectAttempts, (void*)(&num));
		}
	}

	public unsafe static int reconnectDelay
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reconnectDelay, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reconnectDelay, (void*)(&num));
		}
	}

	public unsafe static bool isReconnecting
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isReconnecting, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isReconnecting, (void*)(&flag));
		}
	}

	public unsafe static string lastHost
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastHost, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastHost, (void*)IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe static int lastPort
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastPort, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastPort, (void*)(&num));
		}
	}

	public unsafe static Thread reconnectThread
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reconnectThread, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reconnectThread, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thread));
		}
	}

	public unsafe static MessageCollector messageCollector
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_messageCollector, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MessageCollector>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_messageCollector, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)messageCollector));
		}
	}

	public unsafe static bool isShuttingDown
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isShuttingDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isShuttingDown, (void*)(&flag));
		}
	}

	public unsafe long lastConnect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastConnect);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastConnect)) = num;
		}
	}

	static Session_ME()
	{
		Il2CppClassPointerStore<Session_ME>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Session_ME");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Session_ME>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_dataStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "dataStream");
		NativeFieldInfoPtr_dis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "dis");
		NativeFieldInfoPtr_dos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "dos");
		NativeFieldInfoPtr_messageHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "messageHandler");
		NativeFieldInfoPtr_isMainSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "isMainSession");
		NativeFieldInfoPtr_sc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "sc");
		NativeFieldInfoPtr_connected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "connected");
		NativeFieldInfoPtr_connecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "connecting");
		NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "sender");
		NativeFieldInfoPtr_initThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "initThread");
		NativeFieldInfoPtr_collectorThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "collectorThread");
		NativeFieldInfoPtr_sendThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "sendThread");
		NativeFieldInfoPtr_sendByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "sendByteCount");
		NativeFieldInfoPtr_recvByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "recvByteCount");
		NativeFieldInfoPtr_getKeyComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "getKeyComplete");
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "key");
		NativeFieldInfoPtr_curR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "curR");
		NativeFieldInfoPtr_curW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "curW");
		NativeFieldInfoPtr_timeConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "timeConnected");
		NativeFieldInfoPtr_lastTimeConn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "lastTimeConn");
		NativeFieldInfoPtr_strRecvByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "strRecvByteCount");
		NativeFieldInfoPtr_isCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "isCancel");
		NativeFieldInfoPtr_host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "host");
		NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "port");
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "count");
		NativeFieldInfoPtr_recieveMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "recieveMsg");
		NativeFieldInfoPtr_recieveMsgLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "recieveMsgLock");
		NativeFieldInfoPtr_isDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "isDisposed");
		NativeFieldInfoPtr_CONNECTION_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "CONNECTION_TIMEOUT");
		NativeFieldInfoPtr_reconnectAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "reconnectAttempts");
		NativeFieldInfoPtr_maxReconnectAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "maxReconnectAttempts");
		NativeFieldInfoPtr_reconnectDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "reconnectDelay");
		NativeFieldInfoPtr_isReconnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "isReconnecting");
		NativeFieldInfoPtr_lastHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "lastHost");
		NativeFieldInfoPtr_lastPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "lastPort");
		NativeFieldInfoPtr_reconnectThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "reconnectThread");
		NativeFieldInfoPtr_messageCollector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "messageCollector");
		NativeFieldInfoPtr_isShuttingDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "isShuttingDown");
		NativeFieldInfoPtr_lastConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, "lastConnect");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100665999);
		NativeMethodInfoPtr_clearSendingMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666000);
		NativeMethodInfoPtr_gI_Public_Static_Session_ME_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666001);
		NativeMethodInfoPtr_isConnected_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666002);
		NativeMethodInfoPtr_setHandler_Public_Virtual_Final_New_Void_IMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666003);
		NativeMethodInfoPtr_ReconnectSocket_Public_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666004);
		NativeMethodInfoPtr_DoReconnectProcess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666005);
		NativeMethodInfoPtr_StartNetworkThreads_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666006);
		NativeMethodInfoPtr_CalculateBackoffDelay_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666007);
		NativeMethodInfoPtr_AttemptConnection_Private_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666008);
		NativeMethodInfoPtr_ResetConnectionState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666009);
		NativeMethodInfoPtr_connect_Public_Virtual_Final_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666010);
		NativeMethodInfoPtr_NetworkInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666011);
		NativeMethodInfoPtr_ProxyTcpClient_Public_TcpClient_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666012);
		NativeMethodInfoPtr_doConnect_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666013);
		NativeMethodInfoPtr_sendMessage_Public_Virtual_Final_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666014);
		NativeMethodInfoPtr_doSendMessage_Private_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666015);
		NativeMethodInfoPtr_readKey_Public_Static_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666016);
		NativeMethodInfoPtr_writeKey_Public_Static_SByte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666017);
		NativeMethodInfoPtr_onRecieveMsg_Public_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666018);
		NativeMethodInfoPtr_enqueueMessage_Public_Static_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666019);
		NativeMethodInfoPtr_update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666020);
		NativeMethodInfoPtr_close_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666021);
		NativeMethodInfoPtr_cleanNetwork_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666022);
		NativeMethodInfoPtr_currentTimeMillis_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666023);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Byte_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666024);
		NativeMethodInfoPtr_convertSbyteToByte_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666025);
		NativeMethodInfoPtr__ReconnectSocket_b__46_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666027);
		NativeMethodInfoPtr__NetworkInit_b__54_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Session_ME>.NativeClassPtr, 100666028);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93067, RefRangeEnd = 93069, XrefRangeStart = 93060, XrefRangeEnd = 93067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Session_ME()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Session_ME>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93075, RefRangeEnd = 93077, XrefRangeStart = 93069, XrefRangeEnd = 93075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearSendingMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clearSendingMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93077, XrefRangeEnd = 93097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Session_ME gI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_gI_Public_Static_Session_ME_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Session_ME>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93097, XrefRangeEnd = 93109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 93115, RefRangeEnd = 93116, XrefRangeStart = 93109, XrefRangeEnd = 93115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 93187, RefRangeEnd = 93188, XrefRangeStart = 93116, XrefRangeEnd = 93187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReconnectSocket(int maxAttempts = 5, int delayMs = 2000, bool forceReconnect = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&maxAttempts);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayMs;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceReconnect;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReconnectSocket_Public_Boolean_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93324, RefRangeEnd = 93325, XrefRangeStart = 93188, XrefRangeEnd = 93324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoReconnectProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoReconnectProcess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93387, RefRangeEnd = 93388, XrefRangeStart = 93325, XrefRangeEnd = 93387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartNetworkThreads()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartNetworkThreads_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93394, RefRangeEnd = 93395, XrefRangeStart = 93388, XrefRangeEnd = 93394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalculateBackoffDelay(int attempt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&attempt);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBackoffDelay_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93463, RefRangeEnd = 93464, XrefRangeStart = 93395, XrefRangeEnd = 93463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AttemptConnection(string targetHost, int targetPort)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetPort;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttemptConnection_Private_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93491, RefRangeEnd = 93492, XrefRangeStart = 93464, XrefRangeEnd = 93491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetConnectionState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetConnectionState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93540, RefRangeEnd = 93541, XrefRangeStart = 93492, XrefRangeEnd = 93540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93541, XrefRangeEnd = 93620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NetworkInit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NetworkInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 93629, RefRangeEnd = 93631, XrefRangeStart = 93620, XrefRangeEnd = 93629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TcpClient ProxyTcpClient(string targetHost, int targetPort)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetPort;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProxyTcpClient_Public_TcpClient_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TcpClient>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93731, RefRangeEnd = 93732, XrefRangeStart = 93631, XrefRangeEnd = 93731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93732, XrefRangeEnd = 93739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void sendMessage(Message message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)message);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sendMessage_Public_Virtual_Final_New_Void_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 93829, RefRangeEnd = 93832, XrefRangeStart = 93739, XrefRangeEnd = 93829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void doSendMessage(Message m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doSendMessage_Private_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93832, XrefRangeEnd = 93839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93839, XrefRangeEnd = 93846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 93871, RefRangeEnd = 93872, XrefRangeStart = 93846, XrefRangeEnd = 93871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void onRecieveMsg(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_onRecieveMsg_Public_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93872, XrefRangeEnd = 93884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void enqueueMessage(Message msg)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)msg);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_enqueueMessage_Public_Static_Void_Message_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93930, RefRangeEnd = 93931, XrefRangeStart = 93884, XrefRangeEnd = 93930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void update()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_update_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 93937, RefRangeEnd = 93949, XrefRangeStart = 93931, XrefRangeEnd = 93937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void close()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_close_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 94095, RefRangeEnd = 94101, XrefRangeStart = 93949, XrefRangeEnd = 94095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void cleanNetwork()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_cleanNetwork_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94101, XrefRangeEnd = 94102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94102, XrefRangeEnd = 94107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94107, XrefRangeEnd = 94155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ReconnectSocket_b__46_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReconnectSocket_b__46_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94155, XrefRangeEnd = 94156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NetworkInit_b__54_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NetworkInit_b__54_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Session_ME(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
