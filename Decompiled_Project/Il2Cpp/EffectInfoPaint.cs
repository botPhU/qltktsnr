using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2Cpp;

public class EffectInfoPaint : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dx;

	private static readonly System.IntPtr NativeFieldInfoPtr_dy;

	private static readonly System.IntPtr NativeFieldInfoPtr_idImg;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int dx
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dx)) = num;
		}
	}

	public unsafe int dy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dy)) = num;
		}
	}

	public unsafe int idImg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idImg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idImg)) = num;
		}
	}

	static EffectInfoPaint()
	{
		Il2CppClassPointerStore<EffectInfoPaint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "EffectInfoPaint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectInfoPaint>.NativeClassPtr);
		NativeFieldInfoPtr_dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectInfoPaint>.NativeClassPtr, "dx");
		NativeFieldInfoPtr_dy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectInfoPaint>.NativeClassPtr, "dy");
		NativeFieldInfoPtr_idImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectInfoPaint>.NativeClassPtr, "idImg");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectInfoPaint>.NativeClassPtr, 100663912);
	}

	[CallerCount(707)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 1068, XrefRangeStart = 361, XrefRangeEnd = 1068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EffectInfoPaint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectInfoPaint>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public EffectInfoPaint(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
