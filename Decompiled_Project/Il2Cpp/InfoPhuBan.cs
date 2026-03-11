using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public class InfoPhuBan : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_type_PB;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointTeam1;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointTeam2;

	private static readonly System.IntPtr NativeFieldInfoPtr_color_1;

	private static readonly System.IntPtr NativeFieldInfoPtr_color_2;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLife;

	private static readonly System.IntPtr NativeFieldInfoPtr_lifeTeam1;

	private static readonly System.IntPtr NativeFieldInfoPtr_lifeTeam2;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameTeam1;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameTeam2;

	private static readonly System.IntPtr NativeFieldInfoPtr_idmapPaint;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_timepaintSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxtimeSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_owner;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_vecInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_String_String_Int32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateTime_Public_Void_Int32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updatePoint_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateLife_Public_Void_Int32_Int32_Int32_0;

	public unsafe int type_PB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type_PB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type_PB)) = num;
		}
	}

	public unsafe int maxPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPoint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxPoint)) = num;
		}
	}

	public unsafe int pointTeam1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointTeam1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointTeam1)) = num;
		}
	}

	public unsafe int pointTeam2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointTeam2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointTeam2)) = num;
		}
	}

	public unsafe int color_1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color_1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color_1)) = num;
		}
	}

	public unsafe int color_2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color_2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color_2)) = num;
		}
	}

	public unsafe int maxLife
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLife);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLife)) = num;
		}
	}

	public unsafe int lifeTeam1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTeam1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTeam1)) = num;
		}
	}

	public unsafe int lifeTeam2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTeam2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lifeTeam2)) = num;
		}
	}

	public unsafe string nameTeam1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameTeam1);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameTeam1)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe string nameTeam2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameTeam2);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameTeam2)), IL2CPP.ManagedStringToIl2Cpp(text));
		}
	}

	public unsafe short idmapPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idmapPaint);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_idmapPaint)) = num;
		}
	}

	public unsafe short timeSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSecond);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSecond)) = num;
		}
	}

	public unsafe short timepaintSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timepaintSecond);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timepaintSecond)) = num;
		}
	}

	public unsafe short maxtimeSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxtimeSecond);
			return *(short*)num;
		}
		set
		{
			*(short*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxtimeSecond)) = num;
		}
	}

	public unsafe byte owner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_owner)) = b;
		}
	}

	public unsafe long timeStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStart);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStart)) = num;
		}
	}

	public unsafe MyVector vecInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vecInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyVector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vecInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)myVector));
		}
	}

	static InfoPhuBan()
	{
		Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InfoPhuBan");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr);
		NativeFieldInfoPtr_type_PB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "type_PB");
		NativeFieldInfoPtr_maxPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "maxPoint");
		NativeFieldInfoPtr_pointTeam1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "pointTeam1");
		NativeFieldInfoPtr_pointTeam2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "pointTeam2");
		NativeFieldInfoPtr_color_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "color_1");
		NativeFieldInfoPtr_color_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "color_2");
		NativeFieldInfoPtr_maxLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "maxLife");
		NativeFieldInfoPtr_lifeTeam1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "lifeTeam1");
		NativeFieldInfoPtr_lifeTeam2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "lifeTeam2");
		NativeFieldInfoPtr_nameTeam1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "nameTeam1");
		NativeFieldInfoPtr_nameTeam2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "nameTeam2");
		NativeFieldInfoPtr_idmapPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "idmapPaint");
		NativeFieldInfoPtr_timeSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "timeSecond");
		NativeFieldInfoPtr_timepaintSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "timepaintSecond");
		NativeFieldInfoPtr_maxtimeSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "maxtimeSecond");
		NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "owner");
		NativeFieldInfoPtr_timeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "timeStart");
		NativeFieldInfoPtr_vecInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, "vecInfo");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_String_String_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, 100664476);
		NativeMethodInfoPtr_updateTime_Public_Void_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, 100664477);
		NativeMethodInfoPtr_updatePoint_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, 100664478);
		NativeMethodInfoPtr_updateLife_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr, 100664479);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53337, RefRangeEnd = 53338, XrefRangeStart = 53323, XrefRangeEnd = 53337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InfoPhuBan(int type_PB, short idmapPaint, string nameTeam1, string nameTeam2, int maxPoint, short timeSecond)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InfoPhuBan>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&type_PB);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idmapPaint;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(nameTeam1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(nameTeam2);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxPoint;
		*(short**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeSecond;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_String_String_Int32_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53342, RefRangeEnd = 53343, XrefRangeStart = 53338, XrefRangeEnd = 53342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateTime(int type_PB, short timeSecond)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type_PB);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeSecond;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateTime_Public_Void_Int32_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53343, RefRangeEnd = 53344, XrefRangeStart = 53343, XrefRangeEnd = 53343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updatePoint(int type_PB, int pointTeam1, int pointTeam2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type_PB);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointTeam1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointTeam2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updatePoint_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53344, RefRangeEnd = 53346, XrefRangeStart = 53344, XrefRangeEnd = 53344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateLife(int type_PB, int lifeTeam1, int lifeTeam2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type_PB);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lifeTeam1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lifeTeam2;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateLife_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public InfoPhuBan(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
