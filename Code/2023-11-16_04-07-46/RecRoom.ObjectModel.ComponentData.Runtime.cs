using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.CodeGen.Attributes;
using RecRoom.Components;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JNNDFFELCAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode EBGFEDFBILN;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HDDPMMPGLAI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public PAFBKJKOEMO GODAALBJJOG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly AIKDHEMNJNM<HDDPMMPGLAI> ENPBEGLBBIN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LOBMEOLDJFE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ALPKECKAFDC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PAFBKJKOEMO
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Invalid = -1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BFLGNJNJNFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct JMNDCIDBPEB : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity DNNMPMAOGBP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BLEIPACGJNJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity IGPIMCJILMM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DNDDDOMHNJK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct IKBHLGODEFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity GLACNLFCFNI;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct IFICFCEJEGE : BEBHONAALEL, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public OLCNJDGDDON IJNFDCAGGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(OLCNJDGDDON);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct ILMCLGEFJCH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 JJBJOBIPOGE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IJGONBGAEII : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LLIEIBKDBIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 DKDKNIAGBLF;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly AIKDHEMNJNM<APJABIDLGPK> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct APJABIDLGPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 DKDKNIAGBLF;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly AIKDHEMNJNM<APJABIDLGPK> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct EKFIJKFHMIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 BLPBCBDMAFB;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct PKIKOHHIAPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 MFEPICJKGPK;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct EBNAOFFMILK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float HLILLDABBNC;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly AIKDHEMNJNM<EBNAOFFMILK> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NJEKNOKBEFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float KFNCLGBNBOD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly AIKDHEMNJNM<NJEKNOKBEFM> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KMAJIFDPKJD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 CHELGPEFPDH;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HAMLKKAIEHF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public HJJEIONKHEK MEJOPMNLIME;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OJEBPOFPGBJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public HJJEIONKHEK BGDJGCNHHHI;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[MBMABJFONFG]
public struct LBIGIGIEAKH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity CFNJODNKJAM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GDIODKONJBO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct AJBMEDFCLEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BBGMALFAMEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct PLOOCECPADG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints NAKNPLKLHCP;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PAOMPPJHDOH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float GOICHLNLLIC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly AIKDHEMNJNM<PAOMPPJHDOH> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PNPGOPKMGIA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float GPDPAMOGICI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct PFONFAMIDDL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PBFLIAKILOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int KGJKKNLCEBP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD512D0", Offset = "0xD502D0", VA = "0x180D512D0")]
	public static PBFLIAKILOC OKGBDLIDGHC(int APPJEOKOGAK)
	{
		return default(PBFLIAKILOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NIHELLJNAJB : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody JFBLILNAOMM;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0840", Offset = "0x5EAF840", VA = "0x185EB0840", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public NIHELLJNAJB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct PJJLJGPKOAA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct MMGNBCMFFEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 DHDAKHKKKMH;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct MODAAOPCOHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 OBNDDJFFKOO;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct CMLHLOPMKME : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float JGBHAJAINJC;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly AIKDHEMNJNM<CMLHLOPMKME> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class NHIFBCDCDEM : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object JJGPMBBMNOH;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB07D0", Offset = "0x5EAF7D0", VA = "0x185EB07D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public NHIFBCDCDEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MJOJCDOPIGI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object HCLCFLIABHM;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0630", Offset = "0x5EAF630", VA = "0x185EB0630", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public MJOJCDOPIGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum HJJEIONKHEK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum BAGHKPJGLEA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface CBBNHNONOOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIBFJFIDBJN(PAFBKJKOEMO JHHHBJMAAKM, PAFBKJKOEMO NMBEDMIFDIA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEKCNBMHPNL();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOLKNCFLMDO();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMMJOFBDFBB(bool JIPBGPFOHIP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GPPDMENNEDJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCBFCEHGCKM();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class FLCGIIMKHCC : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public CBBNHNONOOK EPBLKNJELFM;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE5A0", Offset = "0x5EAD5A0", VA = "0x185EAE5A0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FLCGIIMKHCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class FKLNDAKNJBF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(AIAHDGAFLGO nameHash, NENHIINAELP stableTypeHash, Type type)> PJHALJDFOED;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(AIAHDGAFLGO nameHash, NENHIINAELP stableTypeHash, Type type)> DLFJJDKAGIC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(AIAHDGAFLGO previousNameHash, NENHIINAELP previousStableTypeHash, Type currentTypeName)> BBEIMEKKIMH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DDPEINDGKFK : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, BPBLKPNAMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9D50", Offset = "0x5EA8D50", VA = "0x185EA9D50", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
[CKNPCAGGEJE]
public struct LEMKPDHFHNH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[EBFCKOIAMOE(1)]
	public quaternion ODJCGHEELMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[EBFCKOIAMOE(2)]
	public float3 LGJKNOILLNC;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly AIKDHEMNJNM<LEMKPDHFHNH> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A470", Offset = "0x3A49470", VA = "0x183A4A470")]
	public LEMKPDHFHNH(quaternion ODJCGHEELMK, float3 LGJKNOILLNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFC60", Offset = "0x5EAEC60", VA = "0x185EAFC60")]
	public static LEMKPDHFHNH OKGBDLIDGHC(RigidTransform GHMOODLBINE)
	{
		return default(LEMKPDHFHNH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FOGOBFLAEPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[CKNPCAGGEJE]
public struct HPJNNHADOEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[EBFCKOIAMOE(1)]
	public float LCAFNBOHFDC;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly AIKDHEMNJNM<HPJNNHADOEL> ENPBEGLBBIN;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CKNPCAGGEJE]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, BPBLKPNAMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[EBFCKOIAMOE(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9D60", Offset = "0x5EA8D60", VA = "0x185EA9D60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IPNDBHMOIHD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, BPBLKPNAMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct OIFGEDPBDGN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct GLHNGEPMMGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[EBFCKOIAMOE(1)]
	public SerializableGuid BCDEFAJKINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[EBFCKOIAMOE(2)]
	public SerializableGuid OCKKPJOGMKO;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct PAPIJBLJHMM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity NKICEKFDFBB;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct MMFPJHDAPPN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity NKICEKFDFBB;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[JCBCFFGAICJ("Container", 0)]
[CKNPCAGGEJE]
public struct KNINEBDGJPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(1)]
	public NBMGBMCGCBP JELDFPEBLJM;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly AIKDHEMNJNM<KNINEBDGJPD> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[CKAINMKJNEK(0, 127)]
public enum NBMGBMCGCBP
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CGJOBIPPOHC
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum HFBILBKPAPH
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum DOCINDDKILG
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9FF0", Offset = "0x5EA8FF0", VA = "0x185EA9FF0")]
	public static (HFBILBKPAPH, DOCINDDKILG) CMMNLOCAIEB(this NBMGBMCGCBP OKHIKFDOHBI)
	{
		return default((HFBILBKPAPH, DOCINDDKILG));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[CKNPCAGGEJE]
[JCBCFFGAICJ("Container", 0)]
public struct JNAHJMFECCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[EBFCKOIAMOE(1)]
	[FINLLHLJKNE(0)]
	public NDADHHOBCHG BHEDHJOHELL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly AIKDHEMNJNM<JNAHJMFECCC> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[CKAINMKJNEK(0, 2)]
public enum NDADHHOBCHG
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[CKNPCAGGEJE]
[JCBCFFGAICJ("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct HPLMCANBMPF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(1)]
	public HLMPGCIBJOF GHCDABCIPIL;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
[CKAINMKJNEK(0, 15943)]
public enum HLMPGCIBJOF
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct HNMFODELGII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct NFIBGFIJMNA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct NJAEBGCKHHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct HOHHEPLPIBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct ICKPFMBGKFI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct EKPFFCHAPJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct GCFJBNNGJEN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct BALNNAHHMON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct AMLFLPDLBKN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[JCBCFFGAICJ("Container", 0)]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
public struct GLBKIDNNMKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[EBFCKOIAMOE(1)]
	[FINLLHLJKNE(0)]
	public float EPAALMILAGA;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[CKNPCAGGEJE]
[JCBCFFGAICJ("Container", 0)]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
public struct EGKJHPADGFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(1)]
	public FixedString64Bytes JNMEJDHMADI;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MHJBOMDJNNH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<AJHMNLNJPKA> LFPPNDFJDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<Entity> BPLBIEAIMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JobHandle KHPBICCBDEG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IBKEJLGGENP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB03F0", Offset = "0x5EAF3F0", VA = "0x185EB03F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PLKFCNLILAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB05E0", Offset = "0x5EAF5E0", VA = "0x185EB05E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43D2300", Offset = "0x43D1300", VA = "0x1843D2300")]
	public MHJBOMDJNNH(NativeList<AJHMNLNJPKA> LFPPNDFJDNB, NativeList<Entity> BPLBIEAIMIH, JobHandle KHPBICCBDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EB04C0", Offset = "0x5EAF4C0", VA = "0x185EB04C0")]
	public (Entity, NativeSlice<Entity>) HECCEPPFBLG(int LNBKADIBNBM)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0460", Offset = "0x5EAF460", VA = "0x185EB0460", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct AJHMNLNJPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity GLACNLFCFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int ODJLNMBFCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int EHBIPHOJPOK;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GIMBIKGLCLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PHGJGCHLHON(bool JCGLHONLNDA);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[JCBCFFGAICJ("Container", 0)]
[CKNPCAGGEJE]
public struct PPECOINDGDD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(1)]
	public JPAKAGKPODE ALIKLBCCNGA;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[CKAINMKJNEK(0, 1)]
public enum JPAKAGKPODE
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[AIMCDKHLCIF(1)]
public struct AJONKJGGLAE : IComparable<AJONKJGGLAE>, IEquatable<AJONKJGGLAE>, BBIMOGAIALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[DIINBPLLEDB(1)]
	public uint AKABKGNCKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[DIINBPLLEDB(2)]
	public uint IMCBFKDOALH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint DAFNEJBODBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9700", Offset = "0x5EA8700", VA = "0x185EA9700")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9AA0", Offset = "0x5EA8AA0", VA = "0x185EA9AA0")]
	public AJONKJGGLAE(int AKABKGNCKPC, int AMGPMFFAGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9AA0", Offset = "0x5EA8AA0", VA = "0x185EA9AA0")]
	public AJONKJGGLAE(uint AKABKGNCKPC, uint AMGPMFFAGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9620", Offset = "0x5EA8620", VA = "0x185EA9620")]
	public AJONKJGGLAE ACIOCNGIGJP(int ODJLNMBFCPC = 1)
	{
		return default(AJONKJGGLAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EA97E0", Offset = "0x5EA87E0", VA = "0x185EA97E0")]
	public AJONKJGGLAE GODPPPFDMPK(int ODJLNMBFCPC = 1)
	{
		return default(AJONKJGGLAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9940", Offset = "0x5EA8940", VA = "0x185EA9940")]
	public static AJONKJGGLAE KMFDIODHEFP(AJONKJGGLAE ANOMGKBFKJP, AJONKJGGLAE DMFPEEHDAKO)
	{
		return default(AJONKJGGLAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9850", Offset = "0x5EA8850", VA = "0x185EA9850")]
	private static uint GOMMINICCNL(uint HMDDIJJDAIK, uint NDOJJCKFJID)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9710", Offset = "0x5EA8710", VA = "0x185EA9710", Slot = "4")]
	public int CompareTo(AJONKJGGLAE EJEDDDCGMMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9750", Offset = "0x5EA8750", VA = "0x185EA9750", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA99C0", Offset = "0x5EA89C0", VA = "0x185EA99C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9730", Offset = "0x5EA8730", VA = "0x185EA9730", Slot = "5")]
	public bool Equals(AJONKJGGLAE EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9880", Offset = "0x5EA8880", VA = "0x185EA9880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA98D0", Offset = "0x5EA88D0", VA = "0x185EA98D0", Slot = "6")]
	public void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9690", Offset = "0x5EA8690", VA = "0x185EA9690", Slot = "7")]
	public void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24F5270", Offset = "0x24F4270", VA = "0x1824F5270")]
	public static bool LICIMLDMCMN(AJONKJGGLAE ANOMGKBFKJP, AJONKJGGLAE DMFPEEHDAKO)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[AIMCDKHLCIF(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[DIINBPLLEDB(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[DIINBPLLEDB(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[DIINBPLLEDB(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[DIINBPLLEDB(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[AIMCDKHLCIF(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, BBIMOGAIALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[DIINBPLLEDB(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0")]
		public static SerializableGuid OKGBDLIDGHC(Guid BCPPFHNPEMA)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2100", Offset = "0x5EB1100", VA = "0x185EB2100", Slot = "4")]
		public bool Equals(SerializableGuid EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EB20E0", Offset = "0x5EB10E0", VA = "0x185EB20E0", Slot = "5")]
		public int CompareTo(SerializableGuid EJEDDDCGMMB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2130", Offset = "0x5EB1130", VA = "0x185EB2130", Slot = "6")]
		public void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2060", Offset = "0x5EB1060", VA = "0x185EB2060", Slot = "7")]
		public void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EB21F0", Offset = "0x5EB11F0", VA = "0x185EB21F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct AMDJACJGKOG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct FBBKBNJLOGA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct FCCJMPGKLBL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
public struct JNBBIAJNNGB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[EBFCKOIAMOE(1)]
	public Entity DGKGJHCILMA;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[InternalBufferCapacity(17)]
public struct JKEJJDECCPH : IBufferElementData, IEquatable<JKEJJDECCPH>, BPBLKPNAMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity DNNMPMAOGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public int PMOGKDHCCLI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity HKJIADLPDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF580", Offset = "0x5EAE580", VA = "0x185EAF580", Slot = "4")]
	public bool Equals(JKEJJDECCPH EJEDDDCGMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
[CKNPCAGGEJE]
public struct PCBAJGDIGNF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[EBFCKOIAMOE(1)]
	public int PMOGKDHCCLI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
[CKNPCAGGEJE]
public struct HDCDAOIJKLJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
public struct CBLNJHDNLGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[EBFCKOIAMOE(1)]
	public Entity KOMDKDGCILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[EBFCKOIAMOE(2)]
	public uint DHOENKGAHJF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId CCFGKABMJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1CCC140", Offset = "0x1CCB140", VA = "0x181CCC140")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1CE3890", Offset = "0x1CE2890", VA = "0x181CE3890")]
	public CBLNJHDNLGD(Entity KOMDKDGCILL, EntityBundlePartId HMANHLHPHHO)
	{
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct EntityBundlePartId : IEquatable<EntityBundlePartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50")]
		internal EntityBundlePartId(uint LPCEACMGEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		internal uint EEOLEBEEGEM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x16C9AD0", Offset = "0x16C8AD0", VA = "0x1816C9AD0", Slot = "4")]
		public bool Equals(EntityBundlePartId EJEDDDCGMMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB000", Offset = "0x5EAA000", VA = "0x185EAB000", Slot = "0")]
		public override bool Equals(object GPCHHCACPPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83B7D0", Offset = "0x83A7D0", VA = "0x18083B7D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x16C9AF0", Offset = "0x16C8AF0", VA = "0x1816C9AF0")]
		public static bool LICIMLDMCMN(EntityBundlePartId HMDDIJJDAIK, EntityBundlePartId NDOJJCKFJID)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct KJCGGHOPIGG : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Entity BLDAGMFBBLI;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
[CKNPCAGGEJE]
public struct JHFHCLBMNIG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[EBFCKOIAMOE(1)]
	public Entity MNNJBJHGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[EBFCKOIAMOE(2)]
	public bool EGFCPPDPOLF;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct HBPDEJPABLF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[EBFCKOIAMOE(1)]
	public OBFLECJAPHH HAOBLKKDGOB;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[CKAINMKJNEK(0, 4)]
public enum OBFLECJAPHH
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct HMIPMHFDICB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[EBFCKOIAMOE(1)]
	public Entity MNNJBJHGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[EBFCKOIAMOE(2)]
	public bool HIMEMENGGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[EBFCKOIAMOE(3)]
	public float DMGJLKFCGLM;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct MKFMLNMJBLK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[EBFCKOIAMOE(1)]
	public bool AKNDOLIKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[EBFCKOIAMOE(2)]
	public bool HIMEMENGGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[EBFCKOIAMOE(3)]
	public float AEJFIFLCFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[EBFCKOIAMOE(4)]
	public float FFLDCCJCEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[EBFCKOIAMOE(5)]
	public float IKHANJLEPJG;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[CKNPCAGGEJE]
public struct MGFLCEILPCO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[EBFCKOIAMOE(1)]
	public bool AKNDOLIKNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[EBFCKOIAMOE(2)]
	public bool HIMEMENGGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[EBFCKOIAMOE(3)]
	public float DMGJLKFCGLM;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, BPBLKPNAMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9D50", Offset = "0x5EA8D50", VA = "0x185EA9D50", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[CKNPCAGGEJE]
	public struct ParentData : IComponentData, BPBLKPNAMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[EBFCKOIAMOE(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, BPBLKPNAMAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB900", Offset = "0x7DA900", VA = "0x1807DB900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x16CF6D0", Offset = "0x16CE6D0", VA = "0x1816CF6D0")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct GIAAMCHJLAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface BPBLKPNAMAF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity FMJHDNMICKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public struct DFOAAIAGOBB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly bool EMFJBOKKGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public uint HEFCPNPEEAJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	private static bool EGIEJNAPNFH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[CKNPCAGGEJE]
[JCBCFFGAICJ("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct GKAFAGHKNKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[EBFCKOIAMOE(1)]
	[FINLLHLJKNE(0)]
	public bool NHIMOAGIDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[EBFCKOIAMOE(2)]
	[FINLLHLJKNE(0)]
	public float LNJCHDEMGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[EBFCKOIAMOE(3)]
	[FINLLHLJKNE(0)]
	public float GJLAMMJLEOL;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[JCBCFFGAICJ("Light", 0)]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[CKNPCAGGEJE]
public struct OHJEFBFBJFM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(1)]
	public float BFLMOCFLFIC;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.TypeVersion(2)]
public struct KLNJPKKAEBE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public uint CGLFNGDEMBE;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF8F0", Offset = "0x5EAE8F0", VA = "0x185EAF8F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	[CKNPCAGGEJE]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[DIINBPLLEDB(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct IIJKNBDBOHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public int LECICHFMCBN;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct ILJNODFMBHL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public GCHandle MBIPEODAMGO;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[CKAINMKJNEK(0, 4)]
public enum LACJOCIFNNA
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	MAX = 4
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct JLNAGAJDBJD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct GNLCEOBMKGD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public int LECICHFMCBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct KICJIEFAJDL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct IHBDPGNAFGM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct GMICDPABPDP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[JCBCFFGAICJ("Object", 0)]
[CKNPCAGGEJE]
[TypeManager.TypeVersion(3)]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
public struct GBGHJGFLMFG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[EBFCKOIAMOE(2)]
	public DLNDJCOLLJJ ACOAMBFAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(3)]
	public BKFLMAPINJG JALIDCGGAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(4)]
	public FGNLHALLCCB BLDMJBHDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[DIINBPLLEDB(5)]
	public IMMPNBDLNGH GHCDABCIPIL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static readonly AIKDHEMNJNM<GBGHJGFLMFG> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class OLJDFDEPHAM
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0DE0", Offset = "0x5EAFDE0", VA = "0x185EB0DE0")]
	public static void GBPMDEJOJHE(this IMMPNBDLNGH GHCDABCIPIL, EEDFGECFCFK EEDLLOGNAGM, bool DNJKBADFLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0E20", Offset = "0x5EAFE20", VA = "0x185EB0E20")]
	public static bool JEFLCFIPPDA(this IMMPNBDLNGH GHCDABCIPIL, EEDFGECFCFK EEDLLOGNAGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0E10", Offset = "0x5EAFE10", VA = "0x185EB0E10")]
	public static IMMPNBDLNGH IDDJBDBDDCO(this EEDFGECFCFK EEDLLOGNAGM)
	{
		return default(IMMPNBDLNGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0DC0", Offset = "0x5EAFDC0", VA = "0x185EB0DC0")]
	public static void GBPMDEJOJHE(this BKFLMAPINJG GHCDABCIPIL, BKFLMAPINJG GHCLMJNFNLO, bool DNJKBADFLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD82C0", Offset = "0x5DD72C0", VA = "0x185DD82C0")]
	public static bool JEFLCFIPPDA(this BKFLMAPINJG GHCDABCIPIL, BKFLMAPINJG EEDLLOGNAGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public enum EEDFGECFCFK
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[Flags]
[CKAINMKJNEK(0, 16383)]
public enum IMMPNBDLNGH
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[CKAINMKJNEK(0, 3)]
[Flags]
public enum BKFLMAPINJG
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	MAX = 3
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[LBNOOLFEIDN]
[CKAINMKJNEK(0, 4)]
public enum FGNLHALLCCB
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class LBNOOLFEIDN : JCGAMAKNFDB
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFA30", Offset = "0x5EAEA30", VA = "0x185EAFA30", Slot = "7")]
	public override string EALBBHEHGED(string KFLFOHECPON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x30FCDD0", Offset = "0x30FBDD0", VA = "0x1830FCDD0")]
	public LBNOOLFEIDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[AIMCDKHLCIF(1)]
public struct DLNDJCOLLJJ : BBIMOGAIALL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[DIINBPLLEDB(1)]
	public bool NHIMOAGIDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[DIINBPLLEDB(2)]
	public float3 JAGCHELFJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[DIINBPLLEDB(3)]
	public float3 NPEICIINOCF;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly AIKDHEMNJNM<DLNDJCOLLJJ> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA570", Offset = "0x5EA9570", VA = "0x185EAA570", Slot = "5")]
	public void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA5E0", Offset = "0x5EA95E0", VA = "0x185EAA5E0", Slot = "4")]
	public void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct KEBLNMPOPHP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct BJCJKNGNKFJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct NDJIGNDMPIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct OBPMOFMLMBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public FixedString32Bytes JNMEJDHMADI;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[MBMABJFONFG]
public struct GEJELEIHHJI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Entity HFIHMDOKDEI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static GEJELEIHHJI OKGBDLIDGHC(Entity APPJEOKOGAK)
	{
		return default(GEJELEIHHJI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct ENMOELCDIOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[EBFCKOIAMOE(1)]
	public Entity DKHNNMEPIGJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static ENMOELCDIOC OKGBDLIDGHC(Entity CFNJODNKJAM)
	{
		return default(ENMOELCDIOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal struct PMPLIBDGHLD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Entity CFNJODNKJAM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static PMPLIBDGHLD OKGBDLIDGHC(Entity CFNJODNKJAM)
	{
		return default(PMPLIBDGHLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct FMFFOMIIIJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Entity CKIPDLAFCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Entity GEFMADFAGNO;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct JDDLMIKJLLC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Entity ILIICCDGIPJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static JDDLMIKJLLC OKGBDLIDGHC(Entity CFNJODNKJAM)
	{
		return default(JDDLMIKJLLC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal struct GCFIDDIHKEF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[CKAINMKJNEK(0, 2)]
public enum HMDJIJGHMMA
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[CKNPCAGGEJE]
[JCBCFFGAICJ("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct GLPKNEBFLDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(1)]
	public float BGPCNNFIGPC;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly AIKDHEMNJNM<GLPKNEBFLDM> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct AMCAIJPLHLH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[EBFCKOIAMOE(1)]
	public EPBBLHAHLDD JDGEKLHKGEC;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[CKAINMKJNEK(-1, 38)]
public enum EPBBLHAHLDD
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
[CKNPCAGGEJE]
public struct PDMMKCABCOI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CKAINMKJNEK(0, 7)]
	[Flags]
	public enum BKGNDOBDKMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[EBFCKOIAMOE(1)]
	public BKGNDOBDKMG GHCDABCIPIL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static readonly AIKDHEMNJNM<PDMMKCABCOI> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PBMMNIJNFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1090", Offset = "0x5EB0090", VA = "0x185EB1090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool BNMGGLAOJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1080", Offset = "0x5EB0080", VA = "0x185EB1080")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct DCPLKLEMNNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[EBFCKOIAMOE(1)]
	public HMDJIJGHMMA JDGEKLHKGEC;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct PJLHPHLJBIE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public uint CEJKGGNMCNG;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[AIMCDKHLCIF(1)]
public struct FIGCDCPGKHC : BBIMOGAIALL
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[Flags]
	[CKAINMKJNEK(0, 7)]
	public enum MDMBBEFPDID
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[DIINBPLLEDB(1)]
	public float PNANIMEJEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[DIINBPLLEDB(2)]
	public int CHPLBHDDHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[DIINBPLLEDB(3)]
	public MDMBBEFPDID GHCDABCIPIL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JOABMEMCKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB1E0", Offset = "0x5EAA1E0", VA = "0x185EAB1E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB280", Offset = "0x5EAA280", VA = "0x185EAB280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool GHBEGNHPHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB1D0", Offset = "0x5EAA1D0", VA = "0x185EAB1D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB250", Offset = "0x5EAA250", VA = "0x185EAB250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EEJMMBIELKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB270", Offset = "0x5EAA270", VA = "0x185EAB270")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB1B0", Offset = "0x5EAA1B0", VA = "0x185EAB1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB160", Offset = "0x5EAA160", VA = "0x185EAB160", Slot = "5")]
	public void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB1F0", Offset = "0x5EAA1F0", VA = "0x185EAB1F0", Slot = "4")]
	public void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[MBMABJFONFG]
internal struct LOPMLHIJGJA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Entity BLMHMCMDHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public int NFJIPMHILEL;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[CKNPCAGGEJE]
public struct IDBBHBDHGCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[EBFCKOIAMOE(1)]
	public AJONKJGGLAE KAEBGANGLLL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x814FF0", Offset = "0x813FF0", VA = "0x180814FF0")]
	public static IDBBHBDHGCD OKGBDLIDGHC(AJONKJGGLAE APPJEOKOGAK)
	{
		return default(IDBBHBDHGCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[CKNPCAGGEJE]
public struct JONFAPJADFH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[EBFCKOIAMOE(1)]
	public Entity GEGLHHMOFEK;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal struct HNHGIFODKBN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Entity GEGLHHMOFEK;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct JNOFELAKEFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[EBFCKOIAMOE(1)]
	public float3 LGJKNOILLNC;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static readonly AIKDHEMNJNM<JNOFELAKEFD> ENPBEGLBBIN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x200F7B0", Offset = "0x200E7B0", VA = "0x18200F7B0")]
	public static JNOFELAKEFD OKGBDLIDGHC(float3 APPJEOKOGAK)
	{
		return default(JNOFELAKEFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct OIBNADHFNJO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[EBFCKOIAMOE(1)]
	public quaternion ODJCGHEELMK;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static readonly AIKDHEMNJNM<OIBNADHFNJO> ENPBEGLBBIN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F7BB0", Offset = "0x7F6BB0", VA = "0x1807F7BB0")]
	public static OIBNADHFNJO OKGBDLIDGHC(quaternion APPJEOKOGAK)
	{
		return default(OIBNADHFNJO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
[CKNPCAGGEJE]
public struct ELPLIPJAABM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[EBFCKOIAMOE(1)]
	public float3 ODPBFAJMNGB;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly AIKDHEMNJNM<ELPLIPJAABM> ENPBEGLBBIN;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x200F7B0", Offset = "0x200E7B0", VA = "0x18200F7B0")]
	public static ELPLIPJAABM OKGBDLIDGHC(float3 APPJEOKOGAK)
	{
		return default(ELPLIPJAABM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct JOMNKIEGCJI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[EBFCKOIAMOE(1)]
	public FIGCDCPGKHC DFHMEJDFNAL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct NAMMAIEGNBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct DFGGPANPLNC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public uint HEFCPNPEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public int MGLHEFGOIEE;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9CE1C0", Offset = "0x9CD1C0", VA = "0x1809CE1C0")]
	public DFGGPANPLNC(uint JJLECFJECKL, int JADICEONAGK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct BODKIHJCALL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct IFGFPMAPCDO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct LGJOGFOIPEE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct GCHJPPFANMO : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct DPKILPFBDGC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct DIPJLJPFENM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct CKCDMOGCDEF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct MCLNINGFOHE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal struct DNKKEIKPHJG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct MIJANNGAOEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct FADPLIIOMNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal struct NOCIFGGCLKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct GDBDBAPPOBH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct GDKPIAAELED : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct DAFOHFIGCOO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct EEIGCMCBELP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[EBFCKOIAMOE(1)]
	public FixedList32Bytes<int> CLBLJOJNOIC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct DGPHCMKEOFA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct OCJMCCDMMDG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct JHLMFAIMDHI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct KLIEGNONNMH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct PNMODJBKDDD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct KBFDEKGIBJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct MALEFFKJKDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct NDKPCPEMKJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[MBMABJFONFG]
public struct IHLKDKOJHFC : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public FixedString32Bytes HAPGJANIBPK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct JFMOOBJKIEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct MAHANEHPJGK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct GLONEOIJAME : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct IKJLAPMHNGG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[DIINBPLLEDB(1)]
	public KJDIGFGCEKH CEJKGGNMCNG;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static readonly AIKDHEMNJNM<IKJLAPMHNGG> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum KJDIGFGCEKH : uint
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct EKIPNOAAHMM : IComponentData, IComparable<EKIPNOAAHMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public int LIGADOEHOOI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x16D99D0", Offset = "0x16D89D0", VA = "0x1816D99D0", Slot = "4")]
	public int CompareTo(EKIPNOAAHMM EJEDDDCGMMB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[CKNPCAGGEJE]
public struct IMANBPKPEMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[EBFCKOIAMOE(2)]
	public bool CIDBIIDAMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[EBFCKOIAMOE(3)]
	public bool PMFAHENMOGG;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly AIKDHEMNJNM<IMANBPKPEMB> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[CKNPCAGGEJE]
public struct EBMKFLKBKLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[EBFCKOIAMOE(1)]
	public bool EOGKECNAEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[EBFCKOIAMOE(2)]
	public byte PHFEGJIIHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[EBFCKOIAMOE(3)]
	public short LFKAINKPOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[EBFCKOIAMOE(4)]
	public ushort OOAJBLOLBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[EBFCKOIAMOE(5)]
	public int PLIADAKFMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[EBFCKOIAMOE(6)]
	public uint BALOMPEPLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[EBFCKOIAMOE(7)]
	public long FPEBLJGPPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[EBFCKOIAMOE(8)]
	public ulong DENHCPIBKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[EBFCKOIAMOE(9)]
	public float PKLMKDHMNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[EBFCKOIAMOE(10)]
	public double FDHMOMAAKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[EBFCKOIAMOE(11)]
	public LAIAHMONNKP MCNOIEOPCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[EBFCKOIAMOE(12)]
	public GIOEEMFCOFI OKIHBKOOFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[EBFCKOIAMOE(13)]
	public BOANAPIKFDL GAOHJBJOBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[EBFCKOIAMOE(14)]
	public NFDNAJPFBPK KNKCBLDMELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[EBFCKOIAMOE(15)]
	public MDFLOCFLILD DDGJFGELAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[EBFCKOIAMOE(16)]
	public BBPGHMBPMHE IBCGGKDLACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[EBFCKOIAMOE(17)]
	public NKLKBDAGFJO MBJKFGACNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[EBFCKOIAMOE(18)]
	public IEGECGJOAGM MCLOJPGGKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[EBFCKOIAMOE(20)]
	public Quaternion DEBEPHBGCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[EBFCKOIAMOE(22)]
	public Vector3 FHHNKKMHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[EBFCKOIAMOE(23)]
	public Vector4 FHHMLNKNOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[EBFCKOIAMOE(40)]
	public Entity NGLAGBBKADC;
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public enum LAIAHMONNKP : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public enum GIOEEMFCOFI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum BOANAPIKFDL : short
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public enum NFDNAJPFBPK : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum MDFLOCFLILD
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum BBPGHMBPMHE : uint
{
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum NKLKBDAGFJO : long
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum IEGECGJOAGM : ulong
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CKNPCAGGEJE]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CKNPCAGGEJE]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class FINFLJEIGIN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public int LNCOLHOCFJN;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public int FLHHGCKIGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public GameObject GFBHJHHLEFD;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public FINFLJEIGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class EFKCJFPMNAP : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public struct CGPAKLGCFGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 IECDLLACFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public List<SerializableGuid> DLAOAHCCBGB;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class FKGPLFLODPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CGPAKLGCFGH GACOEAJECHI;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FKGPLFLODPE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public SerializableGuid LMBPLEDADBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public List<int> NNJIHOKDGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public List<CGPAKLGCFGH> DGFHDFLELGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public List<FKGPLFLODPE> CPHMCFOGOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public GameObject GFBHJHHLEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Light EGAKGGBPKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Collider ADLAAIPCPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public string LIIDEKHJEGC;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public EFKCJFPMNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[CKNPCAGGEJE]
public struct LJAHEDHILFA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	[EBFCKOIAMOE(1)]
	public float3 GKMIIOCDJGB;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static readonly AIKDHEMNJNM<LJAHEDHILFA> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct ODAOEMJNIEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	[EBFCKOIAMOE(1)]
	public quaternion ODJCGHEELMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	[EBFCKOIAMOE(2)]
	public float3 LGJKNOILLNC;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static readonly AIKDHEMNJNM<ODAOEMJNIEO> ENPBEGLBBIN;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3A4A470", Offset = "0x3A49470", VA = "0x183A4A470")]
	public ODAOEMJNIEO(quaternion ODJCGHEELMK, float3 LGJKNOILLNC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFC60", Offset = "0x5EAEC60", VA = "0x185EAFC60")]
	public static RigidTransform OKGBDLIDGHC(ODAOEMJNIEO HHJLAONDMPF)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFC60", Offset = "0x5EAEC60", VA = "0x185EAFC60")]
	public static ODAOEMJNIEO OKGBDLIDGHC(RigidTransform GHMOODLBINE)
	{
		return default(ODAOEMJNIEO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class JDMFEABKBMA
{
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct NMKEEFFEMCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public float4x4 JJAELDCFILP;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly AIKDHEMNJNM<NMKEEFFEMCN> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct DIMMCGPJMCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float4x4 GCNLNEAOLDL;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public static readonly AIKDHEMNJNM<DIMMCGPJMCC> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct LAMHCHOICJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[EBFCKOIAMOE(1)]
	public float LCAFNBOHFDC;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static readonly AIKDHEMNJNM<LAMHCHOICJM> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public struct GBBMKFPBJHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private int FKMKKEBNPFI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NFJIPMHILEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE610", Offset = "0x5EAD610", VA = "0x185EAE610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE620", Offset = "0x5EAD620", VA = "0x185EAE620")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[CKNPCAGGEJE]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct JFCKJHLGLFB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[EBFCKOIAMOE(1)]
	public KNPDNFMDLBD DIEDHFEKCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[EBFCKOIAMOE(2)]
	public FICDFOAOJPH AHKBMEKIOLK;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[CKAINMKJNEK(0, 1)]
[Flags]
public enum KNPDNFMDLBD
{
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	All = 1
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[CKAINMKJNEK(-2, 2)]
public enum FICDFOAOJPH
{
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct HOBLIKCJOPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public float3 NBBEMBBCBIO;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static readonly AIKDHEMNJNM<HOBLIKCJOPD> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct LEKPGLFFGEL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public float3 LPGLCEHEHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public quaternion LGOFCBEILGM;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly AIKDHEMNJNM<LEKPGLFFGEL> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class CIIFKCAOPKM
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct LMBDCHJEAIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public float MOBHENKHFIO;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly AIKDHEMNJNM<LMBDCHJEAIC> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[CKAINMKJNEK(1000, 8000)]
public enum LBHIBFADKLF
{
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	CostumePieceShapeContainer = 1003,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	GameObject_HierarchyObject = 7002,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	GameObject_StudioProp = 7006,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	GameObject_NetworkedTransform = 7007,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	GameObject_PlayerNetworkedTransform = 7008,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	GameObject_HierarchyObject_Container = 7009,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	GameObject_Socket = 7010,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	GameObject_PlayerSocket = 7011,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	GameObject_PlayerRbexNetworkedTransform = 7012,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	GameObject_CostumeDummy = 7013,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class MJKGAGFPKEK
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal enum BAHDPIAAJNH
{
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	UNUSED = 0,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal static class NDAMNHCMLJD
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[CKAINMKJNEK(0, 9)]
public enum LCIFOIEHOAC
{
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	UNUSED = 5,
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public static class EHPJNAKKHBM
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAC60", Offset = "0x5EA9C60", VA = "0x185EAAC60")]
	public static bool FFDJLKOILHI(this LCIFOIEHOAC OFCLDEPDEEO)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CKNPCAGGEJE]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public LBHIBFADKLF prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class ENGAFBIFFJO
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAFE0", Offset = "0x5EA9FE0", VA = "0x185EAAFE0")]
	public static LCIFOIEHOAC KOBLIHACACI(this LBHIBFADKLF MMIOCMIOHFJ)
	{
		return default(LCIFOIEHOAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[CKAINMKJNEK(int.MinValue, int.MaxValue)]
public enum DOPMHANFEKL
{
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[CKAINMKJNEK(-1, 31)]
public enum JIGLJABBNHO
{
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[CKNPCAGGEJE]
[JCBCFFGAICJ("Visual", 0)]
public struct NMGLDMGBBFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(1)]
	public DOPMHANFEKL NGFEKFKHCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(2)]
	public JIGLJABBNHO DMOCGBANHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(3)]
	public float PKDODMJFILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(4)]
	public Vector3 LLDEACMBIIF;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[PJDCGHPABJO]
[CDPGOLEOLJB(2613756846563002039uL, 6372660366488563574uL)]
[JCBCFFGAICJ("Container", 0)]
public struct MNMBDKBOLMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[EBFCKOIAMOE(1)]
	[FINLLHLJKNE(0)]
	public FBOJLFLCEJF OKLJKNNNNBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[CKAINMKJNEK(0, 15)]
[Flags]
public enum FBOJLFLCEJF
{
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
[CDPGOLEOLJB(9804513251708000208uL, 10903582988135044631uL)]
[PJDCGHPABJO]
public struct MDMOFPFNPHC : IComponentData, IEquatable<MDMOFPFNPHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[EBFCKOIAMOE(1)]
	public FixedString64Bytes JNMEJDHMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[EBFCKOIAMOE(2)]
	public NDADHHOBCHG BHEDHJOHELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[EBFCKOIAMOE(3)]
	public FBOJLFLCEJF OKLJKNNNNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[EBFCKOIAMOE(4)]
	public JPAKAGKPODE ALIKLBCCNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[EBFCKOIAMOE(5)]
	public HLMPGCIBJOF GHCDABCIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[EBFCKOIAMOE(6)]
	public float EPAALMILAGA;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0310", Offset = "0x5EAF310", VA = "0x185EB0310", Slot = "4")]
	public bool Equals(MDMOFPFNPHC EJEDDDCGMMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[CDPGOLEOLJB(1213445203937950283uL, 119653618660684511uL)]
[PJDCGHPABJO]
public struct EAHEEBOBCKH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[EBFCKOIAMOE(1)]
	public DPCOHLANFED ANHDKPMOKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public GCHandle PBJLMCDEAOF;
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[AIMCDKHLCIF(1)]
public struct DPCOHLANFED : BBIMOGAIALL, IEquatable<DPCOHLANFED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[DIINBPLLEDB(1)]
	public int LPCEACMGEAL;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA770", Offset = "0x5EA9770", VA = "0x185EAA770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA6F0", Offset = "0x5EA96F0", VA = "0x185EAA6F0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x16C9AD0", Offset = "0x16C8AD0", VA = "0x1816C9AD0", Slot = "6")]
	public bool Equals(DPCOHLANFED EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x16D9A60", Offset = "0x16D8A60", VA = "0x1816D9A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA6D0", Offset = "0x5EA96D0", VA = "0x185EAA6D0", Slot = "5")]
	public void AJBPOCIDFHA(ADPHFBNFONE JPPGFPLOJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA7D0", Offset = "0x5EA97D0", VA = "0x185EAA7D0", Slot = "4")]
	public void KJONJHMMAMK(HNBKBBLFGFP BBENPAOCMIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[PJDCGHPABJO]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[CDPGOLEOLJB(218523523639012570uL, 15191719635551116065uL)]
public struct FOBCLJOFDCN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private uint FHGFAKDKBMF;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[PJDCGHPABJO]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[CDPGOLEOLJB(9898405628982320166uL, 2023375009558162791uL)]
public struct EIIICDGLMAG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[EBFCKOIAMOE(1)]
	public IMMPNBDLNGH GHCDABCIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[EBFCKOIAMOE(2)]
	public DLNDJCOLLJJ ACOAMBFAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(3)]
	public bool DCFMHAAEOPO;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly AIKDHEMNJNM<EIIICDGLMAG> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[CDPGOLEOLJB(9807788745867066359uL, 15168486114979071194uL)]
[PJDCGHPABJO]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct BKDGGHGMOKN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[EBFCKOIAMOE(1)]
	public IMMPNBDLNGH GHCDABCIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[EBFCKOIAMOE(2)]
	public DLNDJCOLLJJ ACOAMBFAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[EBFCKOIAMOE(3)]
	[FINLLHLJKNE(0)]
	public bool DCFMHAAEOPO;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly AIKDHEMNJNM<BKDGGHGMOKN> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[PJDCGHPABJO]
[CDPGOLEOLJB(4470189027631723570uL, 5922380073816386711uL)]
public struct HJNAPOEADAF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[DIINBPLLEDB(1)]
	public IMMPNBDLNGH GHCDABCIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[EBFCKOIAMOE(2)]
	public DLNDJCOLLJJ ACOAMBFAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[FINLLHLJKNE(0)]
	[EBFCKOIAMOE(3)]
	public BKFLMAPINJG JALIDCGGAFN;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly AIKDHEMNJNM<HJNAPOEADAF> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[CDPGOLEOLJB(12226092714547765037uL, 15970362445488810630uL)]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[PJDCGHPABJO]
public struct IPKFBLNEHEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[EBFCKOIAMOE(2)]
	public DLNDJCOLLJJ ACOAMBFAJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[EBFCKOIAMOE(3)]
	[FINLLHLJKNE(0)]
	public BKFLMAPINJG JALIDCGGAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[DIINBPLLEDB(4)]
	public IMMPNBDLNGH GHCDABCIPIL;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly AIKDHEMNJNM<IPKFBLNEHEK> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[CDPGOLEOLJB(3318727941304405759uL, 6047901070934821887uL)]
[PJDCGHPABJO]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct LMCDOCAMDAN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public int LINDMFAFBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[EBFCKOIAMOE(2)]
	public bool CIDBIIDAMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[EBFCKOIAMOE(3)]
	public bool PMFAHENMOGG;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly AIKDHEMNJNM<LMCDOCAMDAN> ENPBEGLBBIN;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[PJDCGHPABJO]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[CDPGOLEOLJB(5861057081882613294uL, 13746475565109640919uL)]
public struct BKKGDHLEMEN : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CKAINMKJNEK(0, 1)]
	public enum GNIAINBBBNP
	{
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		Custom = 1,
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		MAX = 1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	[EBFCKOIAMOE(1)]
	public GNIAINBBBNP OMIOFOEMGBJ;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[PJDCGHPABJO]
[CDPGOLEOLJB(14327281633525910712uL, 2559857777606771911uL)]
public struct KBJKLCDKIAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	[EBFCKOIAMOE(1)]
	public LBHIBFADKLF MMIOCMIOHFJ;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[CDPGOLEOLJB(15725208981563603541uL, 17017036095303668770uL)]
[PJDCGHPABJO]
public struct NHNJCEEDGDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	[EBFCKOIAMOE(1)]
	public LBHIBFADKLF MMIOCMIOHFJ;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[PJDCGHPABJO]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[CDPGOLEOLJB(1029043735688538310uL, 14256247939851101839uL)]
public struct AFGBFLBABGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public LCIFOIEHOAC OFCLDEPDEEO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[CDPGOLEOLJB(17667479821163689808uL, 11946378475791123970uL)]
[PJDCGHPABJO]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
public struct NFIIAFFELID : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : MEDPHPOAELF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2200", Offset = "0x5EB1200", VA = "0x185EB2200", Slot = "4")]
		public sealed override void OMBDJIABMFK()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class ADGLBMPIDNG : ContainerPropertyBag<NIHELLJNAJB>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class IBEFIJBICPE : Property<NIHELLJNAJB, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5EAF020", Offset = "0x5EAE020", VA = "0x185EAF020", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEFE0", Offset = "0x5EADFE0", VA = "0x185EAEFE0")]
		public IBEFIJBICPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9AF0", Offset = "0x5EA8AF0", VA = "0x185EA9AF0", Slot = "14")]
		public override Rigidbody GetValue(NIHELLJNAJB KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9B10", Offset = "0x5EA8B10", VA = "0x185EA9B10", Slot = "15")]
		public override void SetValue(NIHELLJNAJB KMOLABGHAKI, Rigidbody APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA92E0", Offset = "0x5EA82E0", VA = "0x185EA92E0")]
	public ADGLBMPIDNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class DLMLPEGEBLK : ContainerPropertyBag<NHIFBCDCDEM>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class AOACMNPCBCI : Property<NHIFBCDCDEM, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9B80", Offset = "0x5EA8B80", VA = "0x185EA9B80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9B40", Offset = "0x5EA8B40", VA = "0x185EA9B40")]
		public AOACMNPCBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9AF0", Offset = "0x5EA8AF0", VA = "0x185EA9AF0", Slot = "14")]
		public override object GetValue(NHIFBCDCDEM KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9B10", Offset = "0x5EA8B10", VA = "0x185EA9B10", Slot = "15")]
		public override void SetValue(NHIFBCDCDEM KMOLABGHAKI, object APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA490", Offset = "0x5EA9490", VA = "0x185EAA490")]
	public DLMLPEGEBLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class KKENMFHOPJC : ContainerPropertyBag<MJOJCDOPIGI>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class LNGOOHBPPGE : Property<MJOJCDOPIGI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0060", Offset = "0x5EAF060", VA = "0x185EB0060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0020", Offset = "0x5EAF020", VA = "0x185EB0020")]
		public LNGOOHBPPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9AF0", Offset = "0x5EA8AF0", VA = "0x185EA9AF0", Slot = "14")]
		public override object GetValue(MJOJCDOPIGI KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9B10", Offset = "0x5EA8B10", VA = "0x185EA9B10", Slot = "15")]
		public override void SetValue(MJOJCDOPIGI KMOLABGHAKI, object APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF810", Offset = "0x5EAE810", VA = "0x185EAF810")]
	public KKENMFHOPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class FFPFHGFPJCB : ContainerPropertyBag<FLCGIIMKHCC>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class POEKDFOJGPO : Property<FLCGIIMKHCC, CBBNHNONOOK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5EB1270", Offset = "0x5EB0270", VA = "0x185EB1270", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1230", Offset = "0x5EB0230", VA = "0x185EB1230")]
		public POEKDFOJGPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9AF0", Offset = "0x5EA8AF0", VA = "0x185EA9AF0", Slot = "14")]
		public override CBBNHNONOOK GetValue(FLCGIIMKHCC KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9B10", Offset = "0x5EA8B10", VA = "0x185EA9B10", Slot = "15")]
		public override void SetValue(FLCGIIMKHCC KMOLABGHAKI, CBBNHNONOOK APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB080", Offset = "0x5EAA080", VA = "0x185EAB080")]
	public FFPFHGFPJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class AHGGPHKLEND : ContainerPropertyBag<FINFLJEIGIN>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class OHKIOGPPGFL : Property<FINFLJEIGIN, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0D10", Offset = "0x5EAFD10", VA = "0x185EB0D10", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0CD0", Offset = "0x5EAFCD0", VA = "0x185EB0CD0")]
		public OHKIOGPPGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0C90", Offset = "0x5EAFC90", VA = "0x185EB0C90", Slot = "14")]
		public override int GetValue(FINFLJEIGIN KMOLABGHAKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0CB0", Offset = "0x5EAFCB0", VA = "0x185EB0CB0", Slot = "15")]
		public override void SetValue(FINFLJEIGIN KMOLABGHAKI, int APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class NKMHMADGLCJ : Property<FINFLJEIGIN, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0990", Offset = "0x5EAF990", VA = "0x185EB0990", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0950", Offset = "0x5EAF950", VA = "0x185EB0950")]
		public NKMHMADGLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0910", Offset = "0x5EAF910", VA = "0x185EB0910", Slot = "14")]
		public override int GetValue(FINFLJEIGIN KMOLABGHAKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0930", Offset = "0x5EAF930", VA = "0x185EB0930", Slot = "15")]
		public override void SetValue(FINFLJEIGIN KMOLABGHAKI, int APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class EKKFIFGHOEE : Property<FINFLJEIGIN, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5EAAF40", Offset = "0x5EA9F40", VA = "0x185EAAF40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAF00", Offset = "0x5EA9F00", VA = "0x185EAAF00")]
		public EKKFIFGHOEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAEB0", Offset = "0x5EA9EB0", VA = "0x185EAAEB0", Slot = "14")]
		public override GameObject GetValue(FINFLJEIGIN KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAED0", Offset = "0x5EA9ED0", VA = "0x185EAAED0", Slot = "15")]
		public override void SetValue(FINFLJEIGIN KMOLABGHAKI, GameObject APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA93C0", Offset = "0x5EA83C0", VA = "0x185EA93C0")]
	public AHGGPHKLEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class EGILDACLNAJ : ContainerPropertyBag<EFKCJFPMNAP>
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class FILKBHPJJOG : Property<EFKCJFPMNAP, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x5EAB330", Offset = "0x5EAA330", VA = "0x185EAB330", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB2F0", Offset = "0x5EAA2F0", VA = "0x185EAB2F0")]
		public FILKBHPJJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB2A0", Offset = "0x5EAA2A0", VA = "0x185EAB2A0", Slot = "14")]
		public override SerializableGuid GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB2D0", Offset = "0x5EAA2D0", VA = "0x185EAB2D0", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, SerializableGuid APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class LIEEBHFMHDE : Property<EFKCJFPMNAP, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5EAFD90", Offset = "0x5EAED90", VA = "0x185EAFD90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFD50", Offset = "0x5EAED50", VA = "0x185EAFD50")]
		public LIEEBHFMHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFD00", Offset = "0x5EAED00", VA = "0x185EAFD00", Slot = "14")]
		public override List<int> GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EAFD20", Offset = "0x5EAED20", VA = "0x185EAFD20", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, List<int> APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class AIFBBPFNJED : Property<EFKCJFPMNAP, List<EFKCJFPMNAP.CGPAKLGCFGH>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x5EA95F0", Offset = "0x5EA85F0", VA = "0x185EA95F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA95B0", Offset = "0x5EA85B0", VA = "0x185EA95B0")]
		public AIFBBPFNJED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9560", Offset = "0x5EA8560", VA = "0x185EA9560", Slot = "14")]
		public override List<EFKCJFPMNAP.CGPAKLGCFGH> GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9580", Offset = "0x5EA8580", VA = "0x185EA9580", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, List<EFKCJFPMNAP.CGPAKLGCFGH> APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class DCDLOCPFMPP : Property<EFKCJFPMNAP, List<EFKCJFPMNAP.FKGPLFLODPE>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA380", Offset = "0x5EA9380", VA = "0x185EAA380", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA340", Offset = "0x5EA9340", VA = "0x185EAA340")]
		public DCDLOCPFMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA2F0", Offset = "0x5EA92F0", VA = "0x185EAA2F0", Slot = "14")]
		public override List<EFKCJFPMNAP.FKGPLFLODPE> GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA310", Offset = "0x5EA9310", VA = "0x185EAA310", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, List<EFKCJFPMNAP.FKGPLFLODPE> APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class BKLBKGLIPAH : Property<EFKCJFPMNAP, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9F00", Offset = "0x5EA8F00", VA = "0x185EA9F00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9EC0", Offset = "0x5EA8EC0", VA = "0x185EA9EC0")]
		public BKLBKGLIPAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9E70", Offset = "0x5EA8E70", VA = "0x185EA9E70", Slot = "14")]
		public override GameObject GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9E90", Offset = "0x5EA8E90", VA = "0x185EA9E90", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, GameObject APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class OCEKPBBLEAD : Property<EFKCJFPMNAP, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0BA0", Offset = "0x5EAFBA0", VA = "0x185EB0BA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0B60", Offset = "0x5EAFB60", VA = "0x185EB0B60")]
		public OCEKPBBLEAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0B10", Offset = "0x5EAFB10", VA = "0x185EB0B10", Slot = "14")]
		public override Light GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0B30", Offset = "0x5EAFB30", VA = "0x185EB0B30", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, Light APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class PBIMFCFEKHP : Property<EFKCJFPMNAP, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5EB1050", Offset = "0x5EB0050", VA = "0x185EB1050", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1010", Offset = "0x5EB0010", VA = "0x185EB1010")]
		public PBIMFCFEKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0FC0", Offset = "0x5EAFFC0", VA = "0x185EB0FC0", Slot = "14")]
		public override Collider GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0FE0", Offset = "0x5EAFFE0", VA = "0x185EB0FE0", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, Collider APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class BLIANECKGPD : Property<EFKCJFPMNAP, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9FC0", Offset = "0x5EA8FC0", VA = "0x185EA9FC0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9F80", Offset = "0x5EA8F80", VA = "0x185EA9F80")]
		public BLIANECKGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9F30", Offset = "0x5EA8F30", VA = "0x185EA9F30", Slot = "14")]
		public override string GetValue(EFKCJFPMNAP KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9F50", Offset = "0x5EA8F50", VA = "0x185EA9F50", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP KMOLABGHAKI, string APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA840", Offset = "0x5EA9840", VA = "0x185EAA840")]
	public EGILDACLNAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class IONMHLFMOPB : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class IPMIMICGJKE : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5EAF550", Offset = "0x5EAE550", VA = "0x185EAF550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF460", Offset = "0x5EAE460", VA = "0x185EAF460")]
		public IPMIMICGJKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD00", Offset = "0xDCCD00", VA = "0x180DCDD00", Slot = "14")]
		public override Data128 GetValue(SerializableGuid KMOLABGHAKI)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF450", Offset = "0x5EAE450", VA = "0x185EAF450", Slot = "15")]
		public override void SetValue(SerializableGuid KMOLABGHAKI, Data128 APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF1F0", Offset = "0x5EAE1F0", VA = "0x185EAF1F0")]
	public IONMHLFMOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class GJPGOPGPOKC : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class MOHCIMMIBOA : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5EB07A0", Offset = "0x5EAF7A0", VA = "0x185EB07A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5EB06B0", Offset = "0x5EAF6B0", VA = "0x185EB06B0")]
		public MOHCIMMIBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1294EC0", Offset = "0x1293EC0", VA = "0x181294EC0", Slot = "14")]
		public override int GetValue(Data128 KMOLABGHAKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5EB06A0", Offset = "0x5EAF6A0", VA = "0x185EB06A0", Slot = "15")]
		public override void SetValue(Data128 KMOLABGHAKI, int APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	private class PKAFFEHNCDC : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5EB1200", Offset = "0x5EB0200", VA = "0x185EB1200", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1110", Offset = "0x5EB0110", VA = "0x185EB1110")]
		public PKAFFEHNCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5EB10F0", Offset = "0x5EB00F0", VA = "0x185EB10F0", Slot = "14")]
		public override int GetValue(Data128 KMOLABGHAKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1100", Offset = "0x5EB0100", VA = "0x185EB1100", Slot = "15")]
		public override void SetValue(Data128 KMOLABGHAKI, int APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	private class CNLLPCPMLNA : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA2C0", Offset = "0x5EA92C0", VA = "0x185EAA2C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA1D0", Offset = "0x5EA91D0", VA = "0x185EAA1D0")]
		public CNLLPCPMLNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1567230", Offset = "0x1566230", VA = "0x181567230", Slot = "14")]
		public override int GetValue(Data128 KMOLABGHAKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA1C0", Offset = "0x5EA91C0", VA = "0x185EAA1C0", Slot = "15")]
		public override void SetValue(Data128 KMOLABGHAKI, int APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class EJPHEDAIDEF : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5EAAE80", Offset = "0x5EA9E80", VA = "0x185EAAE80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAD90", Offset = "0x5EA9D90", VA = "0x185EAAD90")]
		public EJPHEDAIDEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAD70", Offset = "0x5EA9D70", VA = "0x185EAAD70", Slot = "14")]
		public override int GetValue(Data128 KMOLABGHAKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAD80", Offset = "0x5EA9D80", VA = "0x185EAAD80", Slot = "15")]
		public override void SetValue(Data128 KMOLABGHAKI, int APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE7C0", Offset = "0x5EAD7C0", VA = "0x185EAE7C0")]
	public GJPGOPGPOKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class JLJDJDGCMHA : ContainerPropertyBag<EFKCJFPMNAP.CGPAKLGCFGH>
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class GDPGPKJPFOG : Property<EFKCJFPMNAP.CGPAKLGCFGH, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x5EAE790", Offset = "0x5EAD790", VA = "0x185EAE790", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE750", Offset = "0x5EAD750", VA = "0x185EAE750")]
		public GDPGPKJPFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8B49E0", Offset = "0x8B39E0", VA = "0x1808B49E0", Slot = "14")]
		public override Vector3 GetValue(EFKCJFPMNAP.CGPAKLGCFGH KMOLABGHAKI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE730", Offset = "0x5EAD730", VA = "0x185EAE730", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP.CGPAKLGCFGH KMOLABGHAKI, Vector3 APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	private class OPNFPDAGFOK : Property<EFKCJFPMNAP.CGPAKLGCFGH, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0F30", Offset = "0x5EAFF30", VA = "0x185EB0F30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0EF0", Offset = "0x5EAFEF0", VA = "0x185EB0EF0")]
		public OPNFPDAGFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0ED0", Offset = "0x5EAFED0", VA = "0x185EB0ED0", Slot = "14")]
		public override List<SerializableGuid> GetValue(EFKCJFPMNAP.CGPAKLGCFGH KMOLABGHAKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0EE0", Offset = "0x5EAFEE0", VA = "0x185EB0EE0", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP.CGPAKLGCFGH KMOLABGHAKI, List<SerializableGuid> APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF5D0", Offset = "0x5EAE5D0", VA = "0x185EAF5D0")]
	public JLJDJDGCMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class LOKCNOBODEI : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class PPOADIDBPKK : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5EB1300", Offset = "0x5EB0300", VA = "0x185EB1300", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5EB12C0", Offset = "0x5EB02C0", VA = "0x185EB12C0")]
		public PPOADIDBPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5EB12A0", Offset = "0x5EB02A0", VA = "0x185EB12A0", Slot = "14")]
		public override float GetValue(Vector3 KMOLABGHAKI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5EB12B0", Offset = "0x5EB02B0", VA = "0x185EB12B0", Slot = "15")]
		public override void SetValue(Vector3 KMOLABGHAKI, float APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	private class OONOFOKAKBA : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0EA0", Offset = "0x5EAFEA0", VA = "0x185EB0EA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0E60", Offset = "0x5EAFE60", VA = "0x185EB0E60")]
		public OONOFOKAKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0E40", Offset = "0x5EAFE40", VA = "0x185EB0E40", Slot = "14")]
		public override float GetValue(Vector3 KMOLABGHAKI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0E50", Offset = "0x5EAFE50", VA = "0x185EB0E50", Slot = "15")]
		public override void SetValue(Vector3 KMOLABGHAKI, float APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class APFELFIBGAK : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9C00", Offset = "0x5EA8C00", VA = "0x185EA9C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9BC0", Offset = "0x5EA8BC0", VA = "0x185EA9BC0")]
		public APFELFIBGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1945510", Offset = "0x1944510", VA = "0x181945510", Slot = "14")]
		public override float GetValue(Vector3 KMOLABGHAKI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9BB0", Offset = "0x5EA8BB0", VA = "0x185EA9BB0", Slot = "15")]
		public override void SetValue(Vector3 KMOLABGHAKI, float APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0090", Offset = "0x5EAF090", VA = "0x185EB0090")]
	public LOKCNOBODEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class IEMFKLNBFGG : ContainerPropertyBag<EFKCJFPMNAP.FKGPLFLODPE>
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	private class HOFIODOIENM : Property<EFKCJFPMNAP.FKGPLFLODPE, EFKCJFPMNAP.CGPAKLGCFGH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5EAEF50", Offset = "0x5EADF50", VA = "0x185EAEF50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEF10", Offset = "0x5EADF10", VA = "0x185EAEF10")]
		public HOFIODOIENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEEA0", Offset = "0x5EADEA0", VA = "0x185EAEEA0", Slot = "14")]
		public override EFKCJFPMNAP.CGPAKLGCFGH GetValue(EFKCJFPMNAP.FKGPLFLODPE KMOLABGHAKI)
		{
			return default(EFKCJFPMNAP.CGPAKLGCFGH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEED0", Offset = "0x5EADED0", VA = "0x185EAEED0", Slot = "15")]
		public override void SetValue(EFKCJFPMNAP.FKGPLFLODPE KMOLABGHAKI, EFKCJFPMNAP.CGPAKLGCFGH APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF050", Offset = "0x5EAE050", VA = "0x185EAF050")]
	public IEMFKLNBFGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class MBDFLKKEJDC : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class OBPADHOONOD : Property<RRObjectPrefabV2Data, LBHIBFADKLF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string GMOLFEBHJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x5EB0AE0", Offset = "0x5EAFAE0", VA = "0x185EB0AE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool HFHPEHMAAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0AA0", Offset = "0x5EAFAA0", VA = "0x185EB0AA0")]
		public OBPADHOONOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1294EC0", Offset = "0x1293EC0", VA = "0x181294EC0", Slot = "14")]
		public override LBHIBFADKLF GetValue(RRObjectPrefabV2Data KMOLABGHAKI)
		{
			return default(LBHIBFADKLF);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB06A0", Offset = "0x5EAF6A0", VA = "0x185EB06A0", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data KMOLABGHAKI, LBHIBFADKLF APPJEOKOGAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0230", Offset = "0x5EAF230", VA = "0x185EB0230")]
	public MBDFLKKEJDC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1330", Offset = "0x5EB0330", VA = "0x185EB1330")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public class OHHMJHHAJKD
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OHHMJHHAJKD()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
