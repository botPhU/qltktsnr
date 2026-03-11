using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class ItemTemplates : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_itemTemplates;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Public_Static_Void_ItemTemplate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Public_Static_ItemTemplate_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getPart_Public_Static_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getIcon_Public_Static_Int16_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static MyHashTable itemTemplates
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_itemTemplates, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyHashTable>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_itemTemplates, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myHashTable));
		}
	}

	static ItemTemplates()
	{
		Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ItemTemplates");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr);
		NativeFieldInfoPtr_itemTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr, "itemTemplates");
		NativeMethodInfoPtr_add_Public_Static_Void_ItemTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr, 100664597);
		NativeMethodInfoPtr_get_Public_Static_ItemTemplate_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr, 100664598);
		NativeMethodInfoPtr_getPart_Public_Static_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr, 100664599);
		NativeMethodInfoPtr_getIcon_Public_Static_Int16_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr, 100664600);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr, 100664601);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54363, RefRangeEnd = 54365, XrefRangeStart = 54355, XrefRangeEnd = 54363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add(ItemTemplate it)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)it);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_Public_Static_Void_ItemTemplate_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 54375, RefRangeEnd = 54394, XrefRangeStart = 54365, XrefRangeEnd = 54375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ItemTemplate get(short id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Public_Static_ItemTemplate_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ItemTemplate>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54394, XrefRangeEnd = 54398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short getPart(short itemTemplateID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemTemplateID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getPart_Public_Static_Int16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54398, XrefRangeEnd = 54402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short getIcon(short itemTemplateID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&itemTemplateID);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getIcon_Public_Static_Int16_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ItemTemplates()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemTemplates>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public ItemTemplates(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
