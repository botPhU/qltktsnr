using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2Cpp;

public class MyHashTable : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_h;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Public_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_size_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_put_Public_Void_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_containsKey_Public_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Hashtable h
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_h)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hashtable));
		}
	}

	static MyHashTable()
	{
		Il2CppClassPointerStore<MyHashTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyHashTable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr);
		NativeFieldInfoPtr_h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, "h");
		NativeMethodInfoPtr_get_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665124);
		NativeMethodInfoPtr_clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665125);
		NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665126);
		NativeMethodInfoPtr_size_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665127);
		NativeMethodInfoPtr_put_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665128);
		NativeMethodInfoPtr_remove_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665129);
		NativeMethodInfoPtr_Remove_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665130);
		NativeMethodInfoPtr_containsKey_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr, 100665132);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 65635, RefRangeEnd = 65646, XrefRangeStart = 65634, XrefRangeEnd = 65635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object get(Il2CppSystem.Object k)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)k);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Public_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 65647, RefRangeEnd = 65649, XrefRangeStart = 65646, XrefRangeEnd = 65647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 65650, RefRangeEnd = 65651, XrefRangeStart = 65649, XrefRangeEnd = 65650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IDictionaryEnumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr) : null;
	}

	[CallerCount(75)]
	[CachedScanResults(RefRangeStart = 65652, RefRangeEnd = 65727, XrefRangeStart = 65651, XrefRangeEnd = 65652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int size()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_size_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 65993, RefRangeEnd = 66011, XrefRangeStart = 65727, XrefRangeEnd = 65993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void put(Il2CppSystem.Object k, Il2CppSystem.Object v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)k);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)v);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_put_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(328)]
	[CachedScanResults(RefRangeStart = 66012, RefRangeEnd = 66340, XrefRangeStart = 66011, XrefRangeEnd = 66012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove(Il2CppSystem.Object k)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)k);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(328)]
	[CachedScanResults(RefRangeStart = 66012, RefRangeEnd = 66340, XrefRangeStart = 66012, XrefRangeEnd = 66340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(string key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 66341, RefRangeEnd = 66349, XrefRangeStart = 66340, XrefRangeEnd = 66341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool containsKey(Il2CppSystem.Object key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)key);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_containsKey_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66355, RefRangeEnd = 66356, XrefRangeStart = 66349, XrefRangeEnd = 66355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyHashTable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyHashTable>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public MyHashTable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
