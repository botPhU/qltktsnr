using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Il2Cpp;

public class MyVector : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_a;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArrayList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_addElement_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_contains_Public_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_size_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_elementAt_Public_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Public_Void_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_setElementAt_Public_Void_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_indexOf_Public_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeElementAt_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeElement_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_removeAllElements_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_insertElementAt_Public_Void_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_firstElement_Public_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_lastElement_Public_Object_0;

	public unsafe ArrayList a
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArrayList>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arrayList));
		}
	}

	static MyVector()
	{
		Il2CppClassPointerStore<MyVector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyVector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyVector>.NativeClassPtr);
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyVector>.NativeClassPtr, "a");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665175);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665176);
		NativeMethodInfoPtr__ctor_Public_Void_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665177);
		NativeMethodInfoPtr_addElement_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665178);
		NativeMethodInfoPtr_contains_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665179);
		NativeMethodInfoPtr_size_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665180);
		NativeMethodInfoPtr_elementAt_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665181);
		NativeMethodInfoPtr_set_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665182);
		NativeMethodInfoPtr_setElementAt_Public_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665183);
		NativeMethodInfoPtr_indexOf_Public_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665184);
		NativeMethodInfoPtr_removeElementAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665185);
		NativeMethodInfoPtr_removeElement_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665186);
		NativeMethodInfoPtr_removeAllElements_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665187);
		NativeMethodInfoPtr_insertElementAt_Public_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665188);
		NativeMethodInfoPtr_firstElement_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665189);
		NativeMethodInfoPtr_lastElement_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyVector>.NativeClassPtr, 100665190);
	}

	[CallerCount(164)]
	[CachedScanResults(RefRangeStart = 67395, RefRangeEnd = 67559, XrefRangeStart = 67389, XrefRangeEnd = 67395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyVector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyVector>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 67565, RefRangeEnd = 67580, XrefRangeStart = 67559, XrefRangeEnd = 67565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyVector(string s)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyVector>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 66432, RefRangeEnd = 66446, XrefRangeStart = 66432, XrefRangeEnd = 66446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MyVector(ArrayList a)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyVector>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(328)]
	[CachedScanResults(RefRangeStart = 66012, RefRangeEnd = 66340, XrefRangeStart = 66012, XrefRangeEnd = 66340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void addElement(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addElement_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 67580, RefRangeEnd = 67583, XrefRangeStart = 67580, XrefRangeEnd = 67580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool contains(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_contains_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(393)]
	[CachedScanResults(RefRangeStart = 67583, RefRangeEnd = 67976, XrefRangeStart = 67583, XrefRangeEnd = 67583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int size()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_size_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(338)]
	[CachedScanResults(RefRangeStart = 67976, RefRangeEnd = 68314, XrefRangeStart = 67976, XrefRangeEnd = 67976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object elementAt(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_elementAt_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void set(int index, Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Public_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 68314, RefRangeEnd = 68320, XrefRangeStart = 68314, XrefRangeEnd = 68314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void setElementAt(Il2CppSystem.Object obj, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_setElementAt_Public_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68320, XrefRangeEnd = 68321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int indexOf(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_indexOf_Public_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 68321, RefRangeEnd = 68351, XrefRangeStart = 68321, XrefRangeEnd = 68321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeElementAt(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeElementAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 68352, RefRangeEnd = 68386, XrefRangeStart = 68351, XrefRangeEnd = 68352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeElement(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeElement_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(75)]
	[CachedScanResults(RefRangeStart = 65652, RefRangeEnd = 65727, XrefRangeStart = 65652, XrefRangeEnd = 65727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void removeAllElements()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_removeAllElements_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 68387, RefRangeEnd = 68393, XrefRangeStart = 68386, XrefRangeEnd = 68387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void insertElementAt(Il2CppSystem.Object o, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_insertElementAt_Public_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 68394, RefRangeEnd = 68399, XrefRangeStart = 68393, XrefRangeEnd = 68394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object firstElement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_firstElement_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 68400, RefRangeEnd = 68403, XrefRangeStart = 68399, XrefRangeEnd = 68400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object lastElement()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lastElement_Public_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public MyVector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
