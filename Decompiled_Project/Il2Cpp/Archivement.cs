using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class Archivement : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_info1;

	private static readonly System.IntPtr NativeFieldInfoPtr_info2;

	private static readonly System.IntPtr NativeFieldInfoPtr_money;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFinish;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRecieve;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string info1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string info2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe int money
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_money)) = num;
		}
	}

	public unsafe bool isFinish
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFinish);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFinish)) = flag;
		}
	}

	public unsafe bool isRecieve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRecieve);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRecieve)) = flag;
		}
	}

	static Archivement()
	{
		Il2CppClassPointerStore<Archivement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Archivement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Archivement>.NativeClassPtr);
		NativeFieldInfoPtr_info1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archivement>.NativeClassPtr, "info1");
		NativeFieldInfoPtr_info2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archivement>.NativeClassPtr, "info2");
		NativeFieldInfoPtr_money = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archivement>.NativeClassPtr, "money");
		NativeFieldInfoPtr_isFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archivement>.NativeClassPtr, "isFinish");
		NativeFieldInfoPtr_isRecieve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Archivement>.NativeClassPtr, "isRecieve");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Archivement>.NativeClassPtr, 100663335);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 360, XrefRangeEnd = 361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Archivement()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Archivement>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public Archivement(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
