using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class ServerScr : mScreen
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mainSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_vecServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_cmdCheck;

	private static readonly System.IntPtr NativeFieldInfoPtr_icmd;

	private static readonly System.IntPtr NativeFieldInfoPtr_wc;

	private static readonly System.IntPtr NativeFieldInfoPtr_hc;

	private static readonly System.IntPtr NativeFieldInfoPtr_w2c;

	private static readonly System.IntPtr NativeFieldInfoPtr_numw;

	private static readonly System.IntPtr NativeFieldInfoPtr_numh;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_update_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0;

	public unsafe int mainSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainSelect);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mainSelect)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<Command> vecServer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vecServer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Command>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vecServer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe Command cmdCheck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdCheck);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Command>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cmdCheck)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)command));
		}
	}

	public unsafe static int icmd
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_icmd, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_icmd, (void*)(&num));
		}
	}

	public unsafe int wc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wc)) = num;
		}
	}

	public unsafe int hc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hc)) = num;
		}
	}

	public unsafe int w2c
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w2c);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_w2c)) = num;
		}
	}

	public unsafe int numw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numw);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numw)) = num;
		}
	}

	public unsafe int numh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numh);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numh)) = num;
		}
	}

	static ServerScr()
	{
		Il2CppClassPointerStore<ServerScr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ServerScr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerScr>.NativeClassPtr);
		NativeFieldInfoPtr_mainSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "mainSelect");
		NativeFieldInfoPtr_vecServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "vecServer");
		NativeFieldInfoPtr_cmdCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "cmdCheck");
		NativeFieldInfoPtr_icmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "icmd");
		NativeFieldInfoPtr_wc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "wc");
		NativeFieldInfoPtr_hc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "hc");
		NativeFieldInfoPtr_w2c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "w2c");
		NativeFieldInfoPtr_numw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "numw");
		NativeFieldInfoPtr_numh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, "numh");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, 100665831);
		NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, 100665832);
		NativeMethodInfoPtr_update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, 100665833);
		NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, 100665834);
		NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, 100665835);
		NativeMethodInfoPtr_perform_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerScr>.NativeClassPtr, 100665836);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 88749, RefRangeEnd = 88751, XrefRangeStart = 88726, XrefRangeEnd = 88749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ServerScr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerScr>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88751, XrefRangeEnd = 88803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void switchToMe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_switchToMe_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88803, XrefRangeEnd = 88827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88827, XrefRangeEnd = 88836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void paint(mGraphics g)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)g);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_paint_Public_Virtual_Void_mGraphics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88836, XrefRangeEnd = 88874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void updateKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_updateKey_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88874, XrefRangeEnd = 88888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public ServerScr(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
