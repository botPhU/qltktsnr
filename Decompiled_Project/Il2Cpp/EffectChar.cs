using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class EffectChar : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_effTemplates;

	private static readonly System.IntPtr NativeFieldInfoPtr_EFF_ME;

	private static readonly System.IntPtr NativeFieldInfoPtr_EFF_FRIEND;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeLenght;

	private static readonly System.IntPtr NativeFieldInfoPtr_param;

	private static readonly System.IntPtr NativeFieldInfoPtr_template;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_Int32_Int32_Int16_0;

	public unsafe static Il2CppReferenceArray<EffectTemplate> effTemplates
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_effTemplates, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EffectTemplate>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_effTemplates, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)val));
		}
	}

	public unsafe static sbyte EFF_ME
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EFF_ME, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EFF_ME, (void*)(&b));
		}
	}

	public unsafe static sbyte EFF_FRIEND
	{
		get
		{
			Unsafe.SkipInit(out sbyte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EFF_FRIEND, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EFF_FRIEND, (void*)(&b));
		}
	}

	public unsafe int timeStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStart)) = num;
		}
	}

	public unsafe int timeLenght
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLenght);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeLenght)) = num;
		}
	}

	public unsafe short param
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_param)) = num;
		}
	}

	public unsafe EffectTemplate template
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EffectTemplate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_template)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)effectTemplate));
		}
	}

	static EffectChar()
	{
		Il2CppClassPointerStore<EffectChar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EffectChar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectChar>.NativeClassPtr);
		NativeFieldInfoPtr_effTemplates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, "effTemplates");
		NativeFieldInfoPtr_EFF_ME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, "EFF_ME");
		NativeFieldInfoPtr_EFF_FRIEND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, "EFF_FRIEND");
		NativeFieldInfoPtr_timeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, "timeStart");
		NativeFieldInfoPtr_timeLenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, "timeLenght");
		NativeFieldInfoPtr_param = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, "param");
		NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, "template");
		NativeMethodInfoPtr__ctor_Public_Void_SByte_Int32_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectChar>.NativeClassPtr, 100663892);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32813, RefRangeEnd = 32814, XrefRangeStart = 32807, XrefRangeEnd = 32813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EffectChar(sbyte templateId, int timeStart, int timeLenght, short param)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectChar>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&templateId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeStart;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeLenght;
		*(short**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &param;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SByte_Int32_Int32_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EffectChar(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
