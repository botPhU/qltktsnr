using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class InfoItem : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s;

	private static readonly System.IntPtr NativeFieldInfoPtr_voiceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_f;

	private static readonly System.IntPtr NativeFieldInfoPtr_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_charInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_isChatServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOnline;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_last;

	private static readonly System.IntPtr NativeFieldInfoPtr_curr;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_mFont_Int32_0;

	public unsafe string s
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe long voiceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voiceId);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_voiceId)) = num;
		}
	}

	public unsafe mFont f
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<mFont>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_f)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mFont2));
		}
	}

	public unsafe int speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed)) = num;
		}
	}

	public unsafe Char charInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Char>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_charInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
		}
	}

	public unsafe bool isChatServer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChatServer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isChatServer)) = flag;
		}
	}

	public unsafe bool isOnline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOnline);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOnline)) = flag;
		}
	}

	public unsafe int timeCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeCount)) = num;
		}
	}

	public unsafe int maxTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxTime)) = num;
		}
	}

	public unsafe long last
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_last)) = num;
		}
	}

	public unsafe long curr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curr);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curr)) = num;
		}
	}

	static InfoItem()
	{
		Il2CppClassPointerStore<InfoItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InfoItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfoItem>.NativeClassPtr);
		NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "s");
		NativeFieldInfoPtr_voiceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "voiceId");
		NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "f");
		NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "speed");
		NativeFieldInfoPtr_charInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "charInfo");
		NativeFieldInfoPtr_isChatServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "isChatServer");
		NativeFieldInfoPtr_isOnline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "isOnline");
		NativeFieldInfoPtr_timeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "timeCount");
		NativeFieldInfoPtr_maxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "maxTime");
		NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "last");
		NativeFieldInfoPtr_curr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, "curr");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, 100664464);
		NativeMethodInfoPtr__ctor_Public_Void_String_mFont_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoItem>.NativeClassPtr, 100664465);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52988, RefRangeEnd = 52991, XrefRangeStart = 52981, XrefRangeEnd = 52988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfoItem(string s)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfoItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52991, XrefRangeEnd = 52994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfoItem(string s, mFont f, int speed)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfoItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)f);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &speed;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_mFont_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InfoItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
