using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppNQMP.Object.Disciple;

public class GetTabDisciple : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_gI;

	private static readonly System.IntPtr NativeFieldInfoPtr_setTab;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static GetTabDisciple gI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_gI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GetTabDisciple>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_gI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)getTabDisciple));
		}
	}

	public unsafe bool setTab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setTab);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setTab)) = flag;
		}
	}

	static GetTabDisciple()
	{
		Il2CppClassPointerStore<GetTabDisciple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NQMP.Object.Disciple", "GetTabDisciple");
		NativeFieldInfoPtr_gI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTabDisciple>.NativeClassPtr, "gI");
		NativeFieldInfoPtr_setTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetTabDisciple>.NativeClassPtr, "setTab");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetTabDisciple>.NativeClassPtr, 100666708);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GetTabDisciple()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetTabDisciple>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public GetTabDisciple(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
