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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GGBHFCCBJOM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public CollisionDetectionMode EDNONOJCFIM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LNMGPCOCDND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public BCLONCNCHJM AMOBMBMIMKO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly OHPHKNGKMBI<LNMGPCOCDND> PJHGNDJLIEP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct COINCGOPGAP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HLEELJFEIOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BCLONCNCHJM
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
public struct HPLPFGFFOJH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[InternalBufferCapacity(0)]
public struct DGINGIPFPGL : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public Entity COBMMEELOCB;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct IBIJBMILKGE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Entity BMNEKBHDGLJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct PEGHGABIMAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OOMEBPHFOGM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Entity NANDDCHCAEB;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KCJEPAIGCEE : LGIJPFNILCO, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HLANFIJCCPG FIFBCLKCHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(HLANFIJCCPG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct KDINHNOIOPM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float3 IPLNPLMJHCD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LOAMFPIGDHJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FJBFPOPEIIK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float3x3 NPFFHGENMAH;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static readonly OHPHKNGKMBI<BGINLAOIPBP> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BGINLAOIPBP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float3x3 NPFFHGENMAH;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static readonly OHPHKNGKMBI<BGINLAOIPBP> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IOMAMFHJGKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float3 BOLOGGMKPNC;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EIOHCOGOIGK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float3 GNCPIEENHKB;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct PICLKDIPGKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float MIHFDBNMHBE;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly OHPHKNGKMBI<PICLKDIPGKF> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LBMKEKPEIGP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float KFCMPEFKJNK;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OHPHKNGKMBI<LBMKEKPEIGP> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LEGGGLAIADP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 KEIIMOLPELM;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HOCFCMKGMEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public FBMIFKFEGDK GPNGHPLKPGM;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IBFPMBFHHAD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public FBMIFKFEGDK DEFHHLGLLFJ;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[APEMEKKEIFL]
public struct CGOHGNHJDIG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Entity OEEKGABNFEP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GCBHCAKPAIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct AJDGGKMGEPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JGHPGJIMEOC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BKDFCMEMLOI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public RigidbodyConstraints JNMHKCCLGIN;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BJGOOJHKBDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float LGEDOIMNJOJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly OHPHKNGKMBI<BJGOOJHKBDG> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GIKMLIIFPLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float JPHBLGKAJDC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct NPDPBCFDOKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct KODHGOCOHMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public int DBDGIIGOPAJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
	public static KODHGOCOHMJ DNODACOFDOB(int PHPDIJICBJO)
	{
		return default(KODHGOCOHMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class MOHAFLDGAOJ : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Rigidbody EIODOLNINOL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9870", Offset = "0x5EA8670", VA = "0x185EA9870", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public MOHAFLDGAOJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct AOBMNKBLPDO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct FEFFIBCJNIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float3 GEOFLKGAFKA;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct NJPMIBBAEAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float3 MAEAAOMNFME;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct PANCFLEGFGD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float EBOMDOOFNJE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OHPHKNGKMBI<PANCFLEGFGD> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class AJAOOAGFNKK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public object FCBNOIOCBHG;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2870", Offset = "0x5EA1670", VA = "0x185EA2870", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public AJAOOAGFNKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DADPBFFOJLI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public object EDAPMJMMJGP;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EA32D0", Offset = "0x5EA20D0", VA = "0x185EA32D0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DADPBFFOJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum FBMIFKFEGDK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum MDGAADFLMAK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IMPMKPGDGFD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBCHPDBAHPG(BCLONCNCHJM IAKOAOAPBED, BCLONCNCHJM CDKBIKKBPNK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPFPKAGLDKA();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLJIFMHFHBL();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCPNCLELBKA(bool OAKMGPFAMEK);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PECKMKJGIIN();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKBBDNCLFIP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class MBLOAALIBFI : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public IMPMKPGDGFD JECMBCEFPIL;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9350", Offset = "0x5EA8150", VA = "0x185EA9350", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public MBLOAALIBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class GIJJGFIGAPG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly List<(DBKEPFKOJMM nameHash, JKADALDJLPG stableTypeHash, Type type)> EPBGIKJNPMH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly List<(DBKEPFKOJMM nameHash, JKADALDJLPG stableTypeHash, Type type)> OPDGPFFCBJK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly List<(DBKEPFKOJMM previousNameHash, JKADALDJLPG previousStableTypeHash, Type currentTypeName)> KLFPDGAKOKA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct ENBGEFJFNPD : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[InternalBufferCapacity(8)]
	public struct AuthoredChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<AuthoredChildrenData>, GMPOLBHMIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B20", Offset = "0x5EA1920", VA = "0x185EA2B20", Slot = "4")]
		public bool Equals(AuthoredChildrenData other)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
[GMOHHGGHJCA]
public struct CHCFEAKPKJF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[CMOBLPMHPFE(1)]
	public quaternion GBLLLKBIFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[CMOBLPMHPFE(2)]
	public float3 EHFMGFPLNPD;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly OHPHKNGKMBI<CHCFEAKPKJF> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E380", Offset = "0x3A9D180", VA = "0x183A9E380")]
	public CHCFEAKPKJF(quaternion GBLLLKBIFDK, float3 EHFMGFPLNPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EA30D0", Offset = "0x5EA1ED0", VA = "0x185EA30D0")]
	public static CHCFEAKPKJF DNODACOFDOB(RigidTransform HIJNJBFPHFM)
	{
		return default(CHCFEAKPKJF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AKHOLACHDHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
[GMOHHGGHJCA]
public struct KONPEIJAHCI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[CMOBLPMHPFE(1)]
	public float FHDPCEHPCDA;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly OHPHKNGKMBI<KONPEIJAHCI> PJHGNDJLIEP;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[GMOHHGGHJCA]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, GMPOLBHMIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[CMOBLPMHPFE(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
		public static implicit operator AuthoredParentData(Entity entity)
		{
			return default(AuthoredParentData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B30", Offset = "0x5EA1930", VA = "0x185EA2B30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct ADHBCNNINDB : IComponentData
{
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct AuthoredPreviousParentData : ISystemStateComponentData, IComponentData, GMPOLBHMIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "5")]
			set
			{
			}
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct BAPKIAEKPBE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct CALCNLEPKBK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[CMOBLPMHPFE(1)]
	public SerializableGuid CNNNLFIFOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[CMOBLPMHPFE(2)]
	public SerializableGuid MOFFGNIDNJM;
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct GLBGFBEAAAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Entity GKPBGNGGKHI;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct KFPHEOMLMBP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Entity GKPBGNGGKHI;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[JLBHIDJKNNF("Container", 0)]
[GMOHHGGHJCA]
public struct MCOOLIGLNCG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(1)]
	public BPGIMFEDAKL HPJNPDCBCAI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly OHPHKNGKMBI<MCOOLIGLNCG> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[ICDNBMCBNHO(0, 127)]
public enum BPGIMFEDAKL
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
public static class DIBKBGJBFPG
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum DOBKDKELDMC
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
	public enum OINLMJLHMDL
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
	[Cpp2IlInjected.Address(RVA = "0x5EA34F0", Offset = "0x5EA22F0", VA = "0x185EA34F0")]
	public static (DOBKDKELDMC, OINLMJLHMDL) PCLNICDPMBK(this BPGIMFEDAKL MHKMKLEBHKP)
	{
		return default((DOBKDKELDMC, OINLMJLHMDL));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[GMOHHGGHJCA]
[JLBHIDJKNNF("Container", 0)]
public struct FOALEKIJABJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[CMOBLPMHPFE(1)]
	[FKJFGCJHJOK(0)]
	public BJLCIIICICE NADHJIBFGNA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly OHPHKNGKMBI<FOALEKIJABJ> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[ICDNBMCBNHO(0, 2)]
public enum BJLCIIICICE
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
[GMOHHGGHJCA]
[JLBHIDJKNNF("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct HFBOJKKNMPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(1)]
	public BHJEJOPMAHL ODAGDEHGJJO;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
[ICDNBMCBNHO(0, 15943)]
public enum BHJEJOPMAHL
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
public struct IEBHPAIJKEG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct LBPKCCMCNGI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct JFGLNEPNEMA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct MPKGHGDGNJK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct DLECFBABLCK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct COPMGBAJHKJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct LBDBOLOAIJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct GPOHLOJPLAL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct DDBAKHDKJCF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[JLBHIDJKNNF("Container", 0)]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
public struct DDOHDCJIENL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[CMOBLPMHPFE(1)]
	[FKJFGCJHJOK(0)]
	public float NEPNGFCGBPC;
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[GMOHHGGHJCA]
[JLBHIDJKNNF("Container", 0)]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
public struct DAFCFMFADED : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(1)]
	public FixedString64Bytes NDLLBBKGIJD;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MEOKPCFKIJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private NativeList<MGLHNLIMCMN> PKJDMDOEEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<Entity> HALOKAEHBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private JobHandle FNAOMEBIJLL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KCECFBKKACB
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9600", Offset = "0x5EA8400", VA = "0x185EA9600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA95B0", Offset = "0x5EA83B0", VA = "0x185EA95B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43C3ED0", Offset = "0x43C2CD0", VA = "0x1843C3ED0")]
	public MEOKPCFKIJD(NativeList<MGLHNLIMCMN> PKJDMDOEEGO, NativeList<Entity> HALOKAEHBNF, JobHandle FNAOMEBIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EA96D0", Offset = "0x5EA84D0", VA = "0x185EA96D0")]
	public (Entity, NativeSlice<Entity>) MAEJKJEDMIJ(int POGGKDPIPDP)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9670", Offset = "0x5EA8470", VA = "0x185EA9670", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MGLHNLIMCMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Entity NANDDCHCAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int PLIILJHILHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int ELGJIDFGJJH;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface BJGGLAEGEGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNPDHEFBNDE(bool EICAMADEMDL);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
[JLBHIDJKNNF("Container", 0)]
[GMOHHGGHJCA]
public struct KLOKEOHNHDG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(1)]
	public OLCEPKJGCNA PANMMLJCKIA;
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[ICDNBMCBNHO(0, 1)]
public enum OLCEPKJGCNA
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
[PFPCLDMPHGG(1)]
public struct NBINOAPKAEH : IComparable<NBINOAPKAEH>, IEquatable<NBINOAPKAEH>, FEEIINJHFHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[LCABLLEPOPC(1)]
	public uint AOHFGOJBPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[LCABLLEPOPC(2)]
	public uint MMKPMCCMHHM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint GGBHIHPMGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EA99B0", Offset = "0x5EA87B0", VA = "0x185EA99B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9D60", Offset = "0x5EA8B60", VA = "0x185EA9D60")]
	public NBINOAPKAEH(int AOHFGOJBPNL, int HBCMBHCODBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9D60", Offset = "0x5EA8B60", VA = "0x185EA9D60")]
	public NBINOAPKAEH(uint AOHFGOJBPNL, uint HBCMBHCODBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9BA0", Offset = "0x5EA89A0", VA = "0x185EA9BA0")]
	public NBINOAPKAEH ODKOHCAIMCI(int PLIILJHILHI = 1)
	{
		return default(NBINOAPKAEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9B30", Offset = "0x5EA8930", VA = "0x185EA9B30")]
	public NBINOAPKAEH NEAMKAKJGMI(int PLIILJHILHI = 1)
	{
		return default(NBINOAPKAEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9A10", Offset = "0x5EA8810", VA = "0x185EA9A10")]
	public static NBINOAPKAEH IJMJGHAPDJH(NBINOAPKAEH CJNLLBDPPAC, NBINOAPKAEH CCDAOMDJCCI)
	{
		return default(NBINOAPKAEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9B00", Offset = "0x5EA8900", VA = "0x185EA9B00")]
	private static uint MIKBOEHPPGM(uint ALNGIEPPLJJ, uint DCODMCLNKEM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA98E0", Offset = "0x5EA86E0", VA = "0x185EA98E0", Slot = "4")]
	public int CompareTo(NBINOAPKAEH LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9920", Offset = "0x5EA8720", VA = "0x185EA9920", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C80", Offset = "0x5EA8A80", VA = "0x185EA9C80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9900", Offset = "0x5EA8700", VA = "0x185EA9900", Slot = "5")]
	public bool Equals(NBINOAPKAEH LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA99C0", Offset = "0x5EA87C0", VA = "0x185EA99C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C10", Offset = "0x5EA8A10", VA = "0x185EA9C10", Slot = "6")]
	public void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9A90", Offset = "0x5EA8890", VA = "0x185EA9A90", Slot = "7")]
	public void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x261D400", Offset = "0x261C200", VA = "0x18261D400")]
	public static bool HIHGGPGGFPN(NBINOAPKAEH CJNLLBDPPAC, NBINOAPKAEH CCDAOMDJCCI)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[PFPCLDMPHGG(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[LCABLLEPOPC(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[LCABLLEPOPC(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[LCABLLEPOPC(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[LCABLLEPOPC(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[PFPCLDMPHGG(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, FEEIINJHFHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[LCABLLEPOPC(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
		public static SerializableGuid DNODACOFDOB(Guid CHLMGBPAGHG)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB550", Offset = "0x5EAA350", VA = "0x185EAB550", Slot = "4")]
		public bool Equals(SerializableGuid LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB530", Offset = "0x5EAA330", VA = "0x185EAB530", Slot = "5")]
		public int CompareTo(SerializableGuid LCIDHBCOPEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB600", Offset = "0x5EAA400", VA = "0x185EAB600", Slot = "6")]
		public void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB580", Offset = "0x5EAA380", VA = "0x185EAB580", Slot = "7")]
		public void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB6C0", Offset = "0x5EAA4C0", VA = "0x185EAB6C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct OOHALNAPFHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct KLHBNBDDPCH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000059")]
public struct CBFBNAKIAKP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(1537567323754185605uL)]
public struct MJIBDFEBAKE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[CMOBLPMHPFE(1)]
	public Entity MKLHGMPEOEO;
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[InternalBufferCapacity(17)]
public struct PKNNIOHHFML : IBufferElementData, IEquatable<PKNNIOHHFML>, GMPOLBHMIHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Entity COBMMEELOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public int DLMKMBMNBLO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Entity PJHDKGOPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA600", Offset = "0x5EA9400", VA = "0x185EAA600", Slot = "4")]
	public bool Equals(PKNNIOHHFML LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[TypeManager.ForcedStableTypeHash(5115014870530256079uL)]
[GMOHHGGHJCA]
public struct AAMELDHEMKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[CMOBLPMHPFE(1)]
	public int DLMKMBMNBLO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
[GMOHHGGHJCA]
public struct IDLFOAKGNHE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
public struct LAHIADOKFMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[CMOBLPMHPFE(1)]
	public Entity MIPDGJHFDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[CMOBLPMHPFE(2)]
	public uint ACGBGIMHHIE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EntityBundlePartId BCIJCAKIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1CCB4E0", Offset = "0x1CCA2E0", VA = "0x181CCB4E0")]
		get
		{
			return default(EntityBundlePartId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1CD6030", Offset = "0x1CD4E30", VA = "0x181CD6030")]
	public LAHIADOKFMI(Entity MIPDGJHFDLL, EntityBundlePartId BLPCGJNLJBF)
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
		[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0")]
		internal EntityBundlePartId(uint JPODHBJFPKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500")]
		internal uint BIFKOODEELL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x16C9C30", Offset = "0x16C8A30", VA = "0x1816C9C30", Slot = "4")]
		public bool Equals(EntityBundlePartId LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3F70", Offset = "0x5EA2D70", VA = "0x185EA3F70", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83F780", Offset = "0x83E580", VA = "0x18083F780", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x16C9C50", Offset = "0x16C8A50", VA = "0x1816C9C50")]
		public static bool HIHGGPGGFPN(EntityBundlePartId ALNGIEPPLJJ, EntityBundlePartId DCODMCLNKEM)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public struct AIBBNKGLHGK : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Entity BNFCBODAHHE;
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
[GMOHHGGHJCA]
public struct CJENDLPJJOJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[CMOBLPMHPFE(1)]
	public Entity PODCKBKAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[CMOBLPMHPFE(2)]
	public bool EEOEGFKLNNK;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct KBHOFIEPEKK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[CMOBLPMHPFE(1)]
	public LFMCHKJNNHO EMHBAPJBAGN;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[ICDNBMCBNHO(0, 4)]
public enum LFMCHKJNNHO
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
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct CBLICKGNMDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[CMOBLPMHPFE(1)]
	public Entity PODCKBKAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[CMOBLPMHPFE(2)]
	public bool HMBNLAJPEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[CMOBLPMHPFE(3)]
	public float JNHHOCPCOIE;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct ELDMHAJBLJM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[CMOBLPMHPFE(1)]
	public bool NJLPJDHGIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[CMOBLPMHPFE(2)]
	public bool HMBNLAJPEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[CMOBLPMHPFE(3)]
	public float IAOPKDFPKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[CMOBLPMHPFE(4)]
	public float JKEMBJGJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[CMOBLPMHPFE(5)]
	public float LLLCDDJJCLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
[GMOHHGGHJCA]
public struct LAPBCNMEJLM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[CMOBLPMHPFE(1)]
	public bool NJLPJDHGIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[CMOBLPMHPFE(2)]
	public bool HMBNLAJPEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[CMOBLPMHPFE(3)]
	public float JNHHOCPCOIE;
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[InternalBufferCapacity(8)]
	public struct ChildrenData : ISystemStateBufferElementData, IBufferElementData, IEquatable<ChildrenData>, GMPOLBHMIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
		public ChildrenData(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B20", Offset = "0x5EA1920", VA = "0x185EA2B20", Slot = "4")]
		public bool Equals(ChildrenData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
		public static implicit operator ChildrenData(Entity entity)
		{
			return default(ChildrenData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	[GMOHHGGHJCA]
	public struct ParentData : IComponentData, GMPOLBHMIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[CMOBLPMHPFE(1)]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct PreviousParentData : ISystemStateComponentData, IComponentData, GMPOLBHMIHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Entity previousParent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.Components.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
		public PreviousParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
		public static implicit operator PreviousParentData(Entity entity)
		{
			return default(PreviousParentData);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct ABBELAIEPBA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface GMPOLBHMIHC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Entity FLLGCJAACHE
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
public struct DCDPJCGALAB<T> : IComponentData where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly bool ACDJDJBKPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public uint MDMOBJOKHAN;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	private static bool EFHIEAGACDG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[GMOHHGGHJCA]
[JLBHIDJKNNF("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct GJPJDKBNJJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[CMOBLPMHPFE(1)]
	[FKJFGCJHJOK(0)]
	public bool KNJPMDLJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[CMOBLPMHPFE(2)]
	[FKJFGCJHJOK(0)]
	public float JAOKPOOOKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[CMOBLPMHPFE(3)]
	[FKJFGCJHJOK(0)]
	public float DMPANOBEEED;
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[JLBHIDJKNNF("Light", 0)]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
[GMOHHGGHJCA]
public struct MMAFCGDJPAC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(1)]
	public float DPCFGGANAJG;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[TypeManager.TypeVersion(2)]
public struct DEKKLEAIJMB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public uint NOJBBDNIADK;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3400", Offset = "0x5EA2200", VA = "0x185EA3400", Slot = "3")]
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
	[GMOHHGGHJCA]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[LCABLLEPOPC(1)]
		public uint networkIdBits;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct JIAOCHAOKBK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public int POAOEPDLCNC;
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public struct MJOPLAFFOHE : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public GCHandle NOKNGHAFKDB;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[ICDNBMCBNHO(0, 4)]
public enum GEFBNFICNMA
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
public struct MJJNLKMLMBM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct ABNNPIEFDAN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public int POAOEPDLCNC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct AECENKBOIHF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct GIEPLGIDHIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct DFGEEMFOKGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[JLBHIDJKNNF("Object", 0)]
[GMOHHGGHJCA]
[TypeManager.TypeVersion(3)]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
public struct KGKKCAFOIEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[CMOBLPMHPFE(2)]
	public CLIBFNLMKOO BKJMNNHLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(3)]
	public BHOBLHHNKGA BIFFMHKGFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(4)]
	public NHBELKMMMFO CDNGJOBMILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[LCABLLEPOPC(5)]
	public OGABGNOKLAJ ODAGDEHGJJO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static readonly OHPHKNGKMBI<KGKKCAFOIEK> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class HEKLNBMMECB
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7D70", Offset = "0x5EA6B70", VA = "0x185EA7D70")]
	public static void CCOBHHAAMMF(this OGABGNOKLAJ ODAGDEHGJJO, MEDNKPNOEGC KFLGPFEAKBH, bool HKCMOBAFKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7DB0", Offset = "0x5EA6BB0", VA = "0x185EA7DB0")]
	public static bool HNLFLLDLKJE(this OGABGNOKLAJ ODAGDEHGJJO, MEDNKPNOEGC KFLGPFEAKBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7DA0", Offset = "0x5EA6BA0", VA = "0x185EA7DA0")]
	public static OGABGNOKLAJ EKHLABAPCIL(this MEDNKPNOEGC KFLGPFEAKBH)
	{
		return default(OGABGNOKLAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7D50", Offset = "0x5EA6B50", VA = "0x185EA7D50")]
	public static void CCOBHHAAMMF(this BHOBLHHNKGA ODAGDEHGJJO, BHOBLHHNKGA GPCGJFGFKBG, bool HKCMOBAFKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBC80", Offset = "0x5DCAA80", VA = "0x185DCBC80")]
	public static bool HNLFLLDLKJE(this BHOBLHHNKGA ODAGDEHGJJO, BHOBLHHNKGA KFLGPFEAKBH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public enum MEDNKPNOEGC
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
[ICDNBMCBNHO(0, 16383)]
public enum OGABGNOKLAJ
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
[ICDNBMCBNHO(0, 3)]
[Flags]
public enum BHOBLHHNKGA
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
[FALBLNOIFEK]
[ICDNBMCBNHO(0, 4)]
public enum NHBELKMMMFO
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
public class FALBLNOIFEK : DIAJFDCKHAL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA40D0", Offset = "0x5EA2ED0", VA = "0x185EA40D0", Slot = "7")]
	public override string DDDJIDOKCLB(string AONAOKPLIKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x30FE6C0", Offset = "0x30FD4C0", VA = "0x1830FE6C0")]
	public FALBLNOIFEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[PFPCLDMPHGG(1)]
public struct CLIBFNLMKOO : FEEIINJHFHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[LCABLLEPOPC(1)]
	public bool KNJPMDLJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[LCABLLEPOPC(2)]
	public float3 NELGHAEPHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[LCABLLEPOPC(3)]
	public float3 HHIHGECMHKN;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public static readonly OHPHKNGKMBI<CLIBFNLMKOO> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3170", Offset = "0x5EA1F70", VA = "0x185EA3170", Slot = "5")]
	public void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA31E0", Offset = "0x5EA1FE0", VA = "0x185EA31E0", Slot = "4")]
	public void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JJKJONCFGDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct PDIDDKKGJPP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct PKIIGMNHPKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public struct NCBNCEAIMAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public FixedString32Bytes NDLLBBKGIJD;
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[APEMEKKEIFL]
public struct GLODCPGGPGF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Entity KKEBFIJFGOA;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static GLODCPGGPGF DNODACOFDOB(Entity PHPDIJICBJO)
	{
		return default(GLODCPGGPGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct KGFOJNHANOL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[CMOBLPMHPFE(1)]
	public Entity BDCLAKECNNJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static KGFOJNHANOL DNODACOFDOB(Entity OEEKGABNFEP)
	{
		return default(KGFOJNHANOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
internal struct GKOLLEHHKNH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Entity OEEKGABNFEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static GKOLLEHHKNH DNODACOFDOB(Entity OEEKGABNFEP)
	{
		return default(GKOLLEHHKNH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public struct MHCJBDBFIAE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Entity FDOAOKGPOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Entity NFCBOPDFLEM;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal struct PKGDBCPPEKJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Entity HLHGNEANIIL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static PKGDBCPPEKJ DNODACOFDOB(Entity OEEKGABNFEP)
	{
		return default(PKGDBCPPEKJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008A")]
internal struct ONHFBAOFDPB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[ICDNBMCBNHO(0, 2)]
public enum FICHLEILIGP
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
[GMOHHGGHJCA]
[JLBHIDJKNNF("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct OLGDBJFIABO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(1)]
	public float DKNHAHGODPE;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly OHPHKNGKMBI<OLGDBJFIABO> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct DKLDPFJLJJA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[CMOBLPMHPFE(1)]
	public DCKPNNMCENH GFGMJNKCAKE;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[ICDNBMCBNHO(-1, 38)]
public enum DCKPNNMCENH
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
[GMOHHGGHJCA]
public struct FPJPOCMCOOL : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[ICDNBMCBNHO(0, 7)]
	[Flags]
	public enum DMNKHALEADM
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
	[CMOBLPMHPFE(1)]
	public DMNKHALEADM ODAGDEHGJJO;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public static readonly OHPHKNGKMBI<FPJPOCMCOOL> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HFAPCEMEIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5EA45D0", Offset = "0x5EA33D0", VA = "0x185EA45D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool MJGNINPJDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5EA45C0", Offset = "0x5EA33C0", VA = "0x185EA45C0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct OIBGLGOMOFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[CMOBLPMHPFE(1)]
	public FICHLEILIGP GFGMJNKCAKE;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct HPAEBLNBIHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public uint PPBKIGHJOID;
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[PFPCLDMPHGG(1)]
public struct OKEDGBDEDCB : FEEIINJHFHI
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[Flags]
	[ICDNBMCBNHO(0, 7)]
	public enum MFEKOGDHMOC
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
	[LCABLLEPOPC(1)]
	public float DLGMMGAJEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	[LCABLLEPOPC(2)]
	public int FAKECPEOAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	[LCABLLEPOPC(3)]
	public MFEKOGDHMOC ODAGDEHGJJO;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BCILJCAIJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA2F0", Offset = "0x5EA90F0", VA = "0x185EAA2F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA280", Offset = "0x5EA9080", VA = "0x185EAA280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool HKDBCELKBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA240", Offset = "0x5EA9040", VA = "0x185EAA240")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA220", Offset = "0x5EA9020", VA = "0x185EAA220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EHLGEHFJAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA250", Offset = "0x5EA9050", VA = "0x185EAA250")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA260", Offset = "0x5EA9060", VA = "0x185EAA260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA2A0", Offset = "0x5EA90A0", VA = "0x185EAA2A0", Slot = "5")]
	public void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA300", Offset = "0x5EA9100", VA = "0x185EAA300", Slot = "4")]
	public void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[APEMEKKEIFL]
internal struct GJMNKJDNFNB : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Entity MKNGPMODOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public int NGIPPLLBEKC;
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
[GMOHHGGHJCA]
public struct MOCBIONABBB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	[CMOBLPMHPFE(1)]
	public NBINOAPKAEH HDDJMINMJCP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static MOCBIONABBB DNODACOFDOB(NBINOAPKAEH PHPDIJICBJO)
	{
		return default(MOCBIONABBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
[GMOHHGGHJCA]
public struct AJMCMAGFLAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[CMOBLPMHPFE(1)]
	public Entity MDBEDLJAMNE;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal struct NCJIGNOJJDF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Entity MDBEDLJAMNE;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct MIILFEEOBDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	[CMOBLPMHPFE(1)]
	public float3 EHFMGFPLNPD;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public static readonly OHPHKNGKMBI<MIILFEEOBDM> PJHGNDJLIEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2007C10", Offset = "0x2006A10", VA = "0x182007C10")]
	public static MIILFEEOBDM DNODACOFDOB(float3 PHPDIJICBJO)
	{
		return default(MIILFEEOBDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct FKEIOLACLAB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[CMOBLPMHPFE(1)]
	public quaternion GBLLLKBIFDK;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public static readonly OHPHKNGKMBI<FKEIOLACLAB> PJHGNDJLIEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F6CE0", Offset = "0x7F5AE0", VA = "0x1807F6CE0")]
	public static FKEIOLACLAB DNODACOFDOB(quaternion PHPDIJICBJO)
	{
		return default(FKEIOLACLAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
[GMOHHGGHJCA]
public struct KCGDANMOFJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[CMOBLPMHPFE(1)]
	public float3 JDAEJPNMMKA;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public static readonly OHPHKNGKMBI<KCGDANMOFJG> PJHGNDJLIEP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2007C10", Offset = "0x2006A10", VA = "0x182007C10")]
	public static KCGDANMOFJG DNODACOFDOB(float3 PHPDIJICBJO)
	{
		return default(KCGDANMOFJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct FLIDNHOOONK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[CMOBLPMHPFE(1)]
	public OKEDGBDEDCB CNCKHACNADC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009D")]
public struct JFDMODGMLLE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public struct DKCIBKFMIKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public uint MDMOBJOKHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public int AKBPKNIPMLI;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9D7BB0", Offset = "0x9D69B0", VA = "0x1809D7BB0")]
	public DKCIBKFMIKO(uint IMEEPFEJJAD, int AJDPBPEMPFB)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200009F")]
public struct HHBEKMKCKJJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public struct DEBBACMLOPD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public struct EIEHOBIJDGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public struct FEPKBJPNNAF : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public struct DCIAIBPIGEL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct MJJHEGNKEDE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct OAODBJJIEAN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct EGHHFALEONG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal struct CKHHIHNMFMN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct NOKAFLHNKLO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct KLGCGCOHCEB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal struct INLBFHEDDNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal struct IIEFDJEPDCC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct PBOKCPADAOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct IIIFNENODEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
public struct OEOOMNIEHMD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	[CMOBLPMHPFE(1)]
	public FixedList32Bytes<int> LDABNMIJELK;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct DNGJJGIEMHB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public struct HJBAFKEOCDF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public struct CCAKGAEMLCO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct IKBEEFLNJCI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct OPFLHBJNNIM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct LMECAMKNIIL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public struct JIIHOHFLJCM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct HBDHJJKOIMP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[APEMEKKEIFL]
public struct MIIEKKGJNCH : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public FixedString32Bytes PJDDMDCEPLD;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct BEDEKMKAGBP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
internal struct MBIDKMGABIG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BA")]
internal struct GJPOILIPIAO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct DGDKPAHGINM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[LCABLLEPOPC(1)]
	public IHNEGMJDKEE PPBKIGHJOID;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public static readonly OHPHKNGKMBI<DGDKPAHGINM> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public enum IHNEGMJDKEE : uint
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct FOPDEGAHGMJ : IComponentData, IComparable<FOPDEGAHGMJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public int JFEJFEFFBEL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x16D9D10", Offset = "0x16D8B10", VA = "0x1816D9D10", Slot = "4")]
	public int CompareTo(FOPDEGAHGMJ LCIDHBCOPEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
[GMOHHGGHJCA]
public struct BENBCJADAKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	[CMOBLPMHPFE(2)]
	public bool GIAAPPPHLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	[CMOBLPMHPFE(3)]
	public bool LBGPKNCIEHL;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly OHPHKNGKMBI<BENBCJADAKL> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
[GMOHHGGHJCA]
public struct HNFCAPCFFJL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	[CMOBLPMHPFE(1)]
	public bool OKDGLDENKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	[CMOBLPMHPFE(2)]
	public byte EJDKGCILOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	[CMOBLPMHPFE(3)]
	public short KLJBFMBNBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	[CMOBLPMHPFE(4)]
	public ushort EACJNDDPJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	[CMOBLPMHPFE(5)]
	public int APHPBPGJDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[CMOBLPMHPFE(6)]
	public uint LNJIGPDHNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	[CMOBLPMHPFE(7)]
	public long DLANJOPOEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	[CMOBLPMHPFE(8)]
	public ulong JEMLKJMFCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	[CMOBLPMHPFE(9)]
	public float CFGCCLPJKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	[CMOBLPMHPFE(10)]
	public double DPMICJFKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	[CMOBLPMHPFE(11)]
	public MOLPLNBLGJO DBMFLIFGFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	[CMOBLPMHPFE(12)]
	public CJADGMKPCOA KJJCPAPIFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	[CMOBLPMHPFE(13)]
	public HMJCBIOEGCN FLKAKADJOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	[CMOBLPMHPFE(14)]
	public DADLDGDMIHI NJHKNHAKGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[CMOBLPMHPFE(15)]
	public GKCJPAOJIFB AJHLPIHIIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[CMOBLPMHPFE(16)]
	public FADGCGDNOCK JJGPMINAFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[CMOBLPMHPFE(17)]
	public PKDGMMBKIPG PKOMEJOHBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[CMOBLPMHPFE(18)]
	public LCNMNLDKANA OLDIHNAHBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[CMOBLPMHPFE(20)]
	public Quaternion IBLAKBEJFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[CMOBLPMHPFE(22)]
	public Vector3 GOFJFHNEAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[CMOBLPMHPFE(23)]
	public Vector4 INLGGPAHIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[CMOBLPMHPFE(40)]
	public Entity OLBLCBAHLBE;
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public enum MOLPLNBLGJO : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public enum CJADGMKPCOA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public enum HMJCBIOEGCN : short
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public enum DADLDGDMIHI : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public enum GKCJPAOJIFB
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public enum FADGCGDNOCK : uint
{
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public enum PKDGMMBKIPG : long
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public enum LCNMNLDKANA : ulong
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
	[GMOHHGGHJCA]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[GMOHHGGHJCA]
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
public class MPPPGINCGIL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public int BBFMJKBFLAL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public int EEKAFMAGHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public GameObject CJHJDJNKIGF;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public MPPPGINCGIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public class AJLHAJMDLPI : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public struct HIPGHNBDCLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector3 LENFNOGPDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public List<SerializableGuid> EIJGPPCGCJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class LMBJCLNPJBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public HIPGHNBDCLH PBCNDAKHBHN;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LMBJCLNPJBB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public SerializableGuid GDLNFFNLJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public List<int> LMMIJPJDKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public List<HIPGHNBDCLH> DLFGPJLFOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public List<LMBJCLNPJBB> EJFGEACFBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public GameObject CJHJDJNKIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Light BKCHIBEONGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Collider OPLJGLOKEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public string JKKEPPFLPGO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public AJLHAJMDLPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
[GMOHHGGHJCA]
public struct IFDLEIDFEFD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	[CMOBLPMHPFE(1)]
	public float3 ENBOALGHDJG;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public static readonly OHPHKNGKMBI<IFDLEIDFEFD> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct NMEMFIEMGOD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	[CMOBLPMHPFE(1)]
	public quaternion GBLLLKBIFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	[CMOBLPMHPFE(2)]
	public float3 EHFMGFPLNPD;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public static readonly OHPHKNGKMBI<NMEMFIEMGOD> PJHGNDJLIEP;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3A9E380", Offset = "0x3A9D180", VA = "0x183A9E380")]
	public NMEMFIEMGOD(quaternion GBLLLKBIFDK, float3 EHFMGFPLNPD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5EA30D0", Offset = "0x5EA1ED0", VA = "0x185EA30D0")]
	public static RigidTransform DNODACOFDOB(NMEMFIEMGOD KGEFGMEIDHL)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5EA30D0", Offset = "0x5EA1ED0", VA = "0x185EA30D0")]
	public static NMEMFIEMGOD DNODACOFDOB(RigidTransform HIJNJBFPHFM)
	{
		return default(NMEMFIEMGOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public static class MCBMGNJNDMJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct FACPJNBPEHO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public float4x4 INKDIDDJDMG;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public static readonly OHPHKNGKMBI<FACPJNBPEHO> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct AKHDLAGPMIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public float4x4 JNOKJGIKDHC;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public static readonly OHPHKNGKMBI<AKHDLAGPMIC> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct JDNABBOMNIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	[CMOBLPMHPFE(1)]
	public float FHDPCEHPCDA;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public static readonly OHPHKNGKMBI<JDNABBOMNIO> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public struct GEKIEPMDCIO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private int DPKPBMBABNA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NGIPPLLBEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4630", Offset = "0x5EA3430", VA = "0x185EA4630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4640", Offset = "0x5EA3440", VA = "0x185EA4640")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[GMOHHGGHJCA]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct HFNEJGIJLCF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[CMOBLPMHPFE(1)]
	public KCPPEHKIFNB KBAMLPIHFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	[CMOBLPMHPFE(2)]
	public BDCJIBDFFAE EIPLKBDMLAO;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[ICDNBMCBNHO(0, 1)]
[Flags]
public enum KCPPEHKIFNB
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
[ICDNBMCBNHO(-2, 2)]
public enum BDCJIBDFFAE
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
public struct HAHPAAMFEGC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public float3 GNPGINGBHDE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static readonly OHPHKNGKMBI<HAHPAAMFEGC> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct AOMMPIMGFMI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public float3 LMGPBOPOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public quaternion BPBCJFMFECG;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly OHPHKNGKMBI<AOMMPIMGFMI> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public static class HKCLFHFMHBA
{
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public struct FEKCNGEJAHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public float FMJAIENOEHL;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly OHPHKNGKMBI<FEKCNGEJAHJ> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[ICDNBMCBNHO(1000, 8000)]
public enum POLLAGMGKIL
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
public static class DNMOMHDHCJO
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal enum HDBENOEONBC
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
internal static class FAKAMLMCDHF
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[ICDNBMCBNHO(0, 9)]
public enum KHGCHFOOBOE
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
public static class POIJCJJKHGO
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA710", Offset = "0x5EA9510", VA = "0x185EAA710")]
	public static bool CLNDBMBICLK(this KHGCHFOOBOE KOFGDPCIPJI)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[GMOHHGGHJCA]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public POLLAGMGKIL prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class BOJIBEOLCAA
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2F70", Offset = "0x5EA1D70", VA = "0x185EA2F70")]
	public static KHGCHFOOBOE KKOJFONDHEC(this POLLAGMGKIL HPJEHGNFPGN)
	{
		return default(KHGCHFOOBOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[ICDNBMCBNHO(int.MinValue, int.MaxValue)]
public enum PPHADPBLFFA
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
[ICDNBMCBNHO(-1, 31)]
public enum GJNEHLGHKPA
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
[GMOHHGGHJCA]
[JLBHIDJKNNF("Visual", 0)]
public struct PCDGNOKJFCM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(1)]
	public PPHADPBLFFA HBLLOHAOGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(2)]
	public GJNEHLGHKPA EACDLEEFOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(3)]
	public float CGEMCKCFGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(4)]
	public Vector3 JGDFHAPHNCB;
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[JDPKAEMMJIK]
[IIMMNFGPOOD(2613756846563002039uL, 6372660366488563574uL)]
[JLBHIDJKNNF("Container", 0)]
public struct OJAOLFGGAOP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	[CMOBLPMHPFE(1)]
	[FKJFGCJHJOK(0)]
	public GNGLBHJBABB BCJMKHHNJGJ;
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
[ICDNBMCBNHO(0, 15)]
[Flags]
public enum GNGLBHJBABB
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
[IIMMNFGPOOD(9804513251708000208uL, 10903582988135044631uL)]
[JDPKAEMMJIK]
public struct IHMPLEKODKL : IComponentData, IEquatable<IHMPLEKODKL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	[CMOBLPMHPFE(1)]
	public FixedString64Bytes NDLLBBKGIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[CMOBLPMHPFE(2)]
	public BJLCIIICICE NADHJIBFGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	[CMOBLPMHPFE(3)]
	public GNGLBHJBABB BCJMKHHNJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	[CMOBLPMHPFE(4)]
	public OLCEPKJGCNA PANMMLJCKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[CMOBLPMHPFE(5)]
	public BHJEJOPMAHL ODAGDEHGJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[CMOBLPMHPFE(6)]
	public float NEPNGFCGBPC;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8130", Offset = "0x5EA6F30", VA = "0x185EA8130", Slot = "4")]
	public bool Equals(IHMPLEKODKL LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
[IIMMNFGPOOD(1213445203937950283uL, 119653618660684511uL)]
[JDPKAEMMJIK]
public struct DLMEBFGDGND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CMOBLPMHPFE(1)]
	public EBFJCJJBNJK AAJBHCCCBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public GCHandle PCALNAMFDCK;
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[PFPCLDMPHGG(1)]
public struct EBFJCJJBNJK : FEEIINJHFHI, IEquatable<EBFJCJJBNJK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[LCABLLEPOPC(1)]
	public int JPODHBJFPKM;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3880", Offset = "0x5EA2680", VA = "0x185EA3880", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3800", Offset = "0x5EA2600", VA = "0x185EA3800", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x16C9C30", Offset = "0x16C8A30", VA = "0x1816C9C30", Slot = "6")]
	public bool Equals(EBFJCJJBNJK LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x16D9DA0", Offset = "0x16D8BA0", VA = "0x1816D9DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA38E0", Offset = "0x5EA26E0", VA = "0x185EA38E0", Slot = "5")]
	public void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3900", Offset = "0x5EA2700", VA = "0x185EA3900", Slot = "4")]
	public void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[JDPKAEMMJIK]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[IIMMNFGPOOD(218523523639012570uL, 15191719635551116065uL)]
public struct GKMHPDGJPIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	private uint FAIOCNFOKGK;
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[JDPKAEMMJIK]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
[IIMMNFGPOOD(9898405628982320166uL, 2023375009558162791uL)]
public struct LHLKOLMLBLL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[CMOBLPMHPFE(1)]
	public OGABGNOKLAJ ODAGDEHGJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[CMOBLPMHPFE(2)]
	public CLIBFNLMKOO BKJMNNHLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(3)]
	public bool DLGIIIANKFF;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly OHPHKNGKMBI<LHLKOLMLBLL> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[IIMMNFGPOOD(9807788745867066359uL, 15168486114979071194uL)]
[JDPKAEMMJIK]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct INHHPMHDPAM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	[CMOBLPMHPFE(1)]
	public OGABGNOKLAJ ODAGDEHGJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[CMOBLPMHPFE(2)]
	public CLIBFNLMKOO BKJMNNHLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	[CMOBLPMHPFE(3)]
	[FKJFGCJHJOK(0)]
	public bool DLGIIIANKFF;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly OHPHKNGKMBI<INHHPMHDPAM> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[JDPKAEMMJIK]
[IIMMNFGPOOD(4470189027631723570uL, 5922380073816386711uL)]
public struct IPHHALHEECN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	[LCABLLEPOPC(1)]
	public OGABGNOKLAJ ODAGDEHGJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	[CMOBLPMHPFE(2)]
	public CLIBFNLMKOO BKJMNNHLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[FKJFGCJHJOK(0)]
	[CMOBLPMHPFE(3)]
	public BHOBLHHNKGA BIFFMHKGFJB;

	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly OHPHKNGKMBI<IPHHALHEECN> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[IIMMNFGPOOD(12226092714547765037uL, 15970362445488810630uL)]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
[JDPKAEMMJIK]
public struct IADIOMJCJND : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	[CMOBLPMHPFE(2)]
	public CLIBFNLMKOO BKJMNNHLCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	[CMOBLPMHPFE(3)]
	[FKJFGCJHJOK(0)]
	public BHOBLHHNKGA BIFFMHKGFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	[LCABLLEPOPC(4)]
	public OGABGNOKLAJ ODAGDEHGJJO;

	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public static readonly OHPHKNGKMBI<IADIOMJCJND> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[IIMMNFGPOOD(3318727941304405759uL, 6047901070934821887uL)]
[JDPKAEMMJIK]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct IJHEJIHCBDP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public int IHPOMJIMGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	[CMOBLPMHPFE(2)]
	public bool GIAAPPPHLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	[CMOBLPMHPFE(3)]
	public bool LBGPKNCIEHL;

	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public static readonly OHPHKNGKMBI<IJHEJIHCBDP> PJHGNDJLIEP;
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[JDPKAEMMJIK]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
[IIMMNFGPOOD(5861057081882613294uL, 13746475565109640919uL)]
public struct CHKNMDMHMMG : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[ICDNBMCBNHO(0, 1)]
	public enum FLOPCBHDOCE
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
	[CMOBLPMHPFE(1)]
	public FLOPCBHDOCE GPDBJJDFPAB;
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[JDPKAEMMJIK]
[IIMMNFGPOOD(14327281633525910712uL, 2559857777606771911uL)]
public struct MIEJNJBDCNA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	[CMOBLPMHPFE(1)]
	public POLLAGMGKIL HPJEHGNFPGN;
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[IIMMNFGPOOD(15725208981563603541uL, 17017036095303668770uL)]
[JDPKAEMMJIK]
public struct BGDFEHJKAHN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	[CMOBLPMHPFE(1)]
	public POLLAGMGKIL HPJEHGNFPGN;
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[JDPKAEMMJIK]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
[IIMMNFGPOOD(1029043735688538310uL, 14256247939851101839uL)]
public struct GJONDOGGODA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	public KHGCHFOOBOE KOFGDPCIPJI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[IIMMNFGPOOD(17667479821163689808uL, 11946378475791123970uL)]
[JDPKAEMMJIK]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
public struct GKHDBOEOKAM : IComponentData
{
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : IMHCJPKCGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB6D0", Offset = "0x5EAA4D0", VA = "0x185EAB6D0", Slot = "4")]
		public sealed override void LCHFPGEPFPA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class GIEEGDFMAOF : ContainerPropertyBag<MOHAFLDGAOJ>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class IJAFPNKCCAC : Property<MOHAFLDGAOJ, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8250", Offset = "0x5EA7050", VA = "0x185EA8250", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8210", Offset = "0x5EA7010", VA = "0x185EA8210")]
		public IJAFPNKCCAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3A90", Offset = "0x5EA2890", VA = "0x185EA3A90", Slot = "14")]
		public override Rigidbody GetValue(MOHAFLDGAOJ FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3AB0", Offset = "0x5EA28B0", VA = "0x185EA3AB0", Slot = "15")]
		public override void SetValue(MOHAFLDGAOJ FEKKHCCBLJM, Rigidbody PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4850", Offset = "0x5EA3650", VA = "0x185EA4850")]
	public GIEEGDFMAOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
internal class FJAIHJFEMEN : ContainerPropertyBag<AJAOOAGFNKK>
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class OCPPDMLKBHG : Property<AJAOOAGFNKK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA010", Offset = "0x5EA8E10", VA = "0x185EAA010", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9FD0", Offset = "0x5EA8DD0", VA = "0x185EA9FD0")]
		public OCPPDMLKBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3A90", Offset = "0x5EA2890", VA = "0x185EA3A90", Slot = "14")]
		public override object GetValue(AJAOOAGFNKK FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3AB0", Offset = "0x5EA28B0", VA = "0x185EA3AB0", Slot = "15")]
		public override void SetValue(AJAOOAGFNKK FEKKHCCBLJM, object PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4200", Offset = "0x5EA3000", VA = "0x185EA4200")]
	public FJAIHJFEMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
internal class POPEFFHPMDC : ContainerPropertyBag<DADPBFFOJLI>
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private class EJKLEKOIKIA : Property<DADPBFFOJLI, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3B20", Offset = "0x5EA2920", VA = "0x185EA3B20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3AE0", Offset = "0x5EA28E0", VA = "0x185EA3AE0")]
		public EJKLEKOIKIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3A90", Offset = "0x5EA2890", VA = "0x185EA3A90", Slot = "14")]
		public override object GetValue(DADPBFFOJLI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3AB0", Offset = "0x5EA28B0", VA = "0x185EA3AB0", Slot = "15")]
		public override void SetValue(DADPBFFOJLI FEKKHCCBLJM, object PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA720", Offset = "0x5EA9520", VA = "0x185EAA720")]
	public POPEFFHPMDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
internal class FLFKAOCLJOM : ContainerPropertyBag<MBLOAALIBFI>
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class LNMJJMHNKJO : Property<MBLOAALIBFI, IMPMKPGDGFD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8D40", Offset = "0x5EA7B40", VA = "0x185EA8D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8D00", Offset = "0x5EA7B00", VA = "0x185EA8D00")]
		public LNMJJMHNKJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3A90", Offset = "0x5EA2890", VA = "0x185EA3A90", Slot = "14")]
		public override IMPMKPGDGFD GetValue(MBLOAALIBFI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3AB0", Offset = "0x5EA28B0", VA = "0x185EA3AB0", Slot = "15")]
		public override void SetValue(MBLOAALIBFI FEKKHCCBLJM, IMPMKPGDGFD PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4480", Offset = "0x5EA3280", VA = "0x185EA4480")]
	public FLFKAOCLJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class DMAOMJAIEEK : ContainerPropertyBag<MPPPGINCGIL>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class OIJCPJHNAEI : Property<MPPPGINCGIL, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA0C0", Offset = "0x5EA8EC0", VA = "0x185EAA0C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA080", Offset = "0x5EA8E80", VA = "0x185EAA080")]
		public OIJCPJHNAEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA040", Offset = "0x5EA8E40", VA = "0x185EAA040", Slot = "14")]
		public override int GetValue(MPPPGINCGIL FEKKHCCBLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA060", Offset = "0x5EA8E60", VA = "0x185EAA060", Slot = "15")]
		public override void SetValue(MPPPGINCGIL FEKKHCCBLJM, int PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class JAFCNFADPNK : Property<MPPPGINCGIL, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x5EA86B0", Offset = "0x5EA74B0", VA = "0x185EA86B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8670", Offset = "0x5EA7470", VA = "0x185EA8670")]
		public JAFCNFADPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8630", Offset = "0x5EA7430", VA = "0x185EA8630", Slot = "14")]
		public override int GetValue(MPPPGINCGIL FEKKHCCBLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8650", Offset = "0x5EA7450", VA = "0x185EA8650", Slot = "15")]
		public override void SetValue(MPPPGINCGIL FEKKHCCBLJM, int PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class KKEGLILLDON : Property<MPPPGINCGIL, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8AB0", Offset = "0x5EA78B0", VA = "0x185EA8AB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8A70", Offset = "0x5EA7870", VA = "0x185EA8A70")]
		public KKEGLILLDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8A20", Offset = "0x5EA7820", VA = "0x185EA8A20", Slot = "14")]
		public override GameObject GetValue(MPPPGINCGIL FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8A40", Offset = "0x5EA7840", VA = "0x185EA8A40", Slot = "15")]
		public override void SetValue(MPPPGINCGIL FEKKHCCBLJM, GameObject PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3660", Offset = "0x5EA2460", VA = "0x185EA3660")]
	public DMAOMJAIEEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class ENCCODFIDEI : ContainerPropertyBag<AJLHAJMDLPI>
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class PLILNFPBBEH : Property<AJLHAJMDLPI, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA6E0", Offset = "0x5EA94E0", VA = "0x185EAA6E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA6A0", Offset = "0x5EA94A0", VA = "0x185EAA6A0")]
		public PLILNFPBBEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA650", Offset = "0x5EA9450", VA = "0x185EAA650", Slot = "14")]
		public override SerializableGuid GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA680", Offset = "0x5EA9480", VA = "0x185EAA680", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, SerializableGuid PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private class PBFLDCHGEFN : Property<AJLHAJMDLPI, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA4B0", Offset = "0x5EA92B0", VA = "0x185EAA4B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA470", Offset = "0x5EA9270", VA = "0x185EAA470")]
		public PBFLDCHGEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA420", Offset = "0x5EA9220", VA = "0x185EAA420", Slot = "14")]
		public override List<int> GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA440", Offset = "0x5EA9240", VA = "0x185EAA440", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, List<int> PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class AGCBJCOCLOK : Property<AJLHAJMDLPI, List<AJLHAJMDLPI.HIPGHNBDCLH>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2840", Offset = "0x5EA1640", VA = "0x185EA2840", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2800", Offset = "0x5EA1600", VA = "0x185EA2800")]
		public AGCBJCOCLOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA27B0", Offset = "0x5EA15B0", VA = "0x185EA27B0", Slot = "14")]
		public override List<AJLHAJMDLPI.HIPGHNBDCLH> GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA27D0", Offset = "0x5EA15D0", VA = "0x185EA27D0", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, List<AJLHAJMDLPI.HIPGHNBDCLH> PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private class INMBLKJGOMJ : Property<AJLHAJMDLPI, List<AJLHAJMDLPI.LMBJCLNPJBB>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8480", Offset = "0x5EA7280", VA = "0x185EA8480", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8440", Offset = "0x5EA7240", VA = "0x185EA8440")]
		public INMBLKJGOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA83F0", Offset = "0x5EA71F0", VA = "0x185EA83F0", Slot = "14")]
		public override List<AJLHAJMDLPI.LMBJCLNPJBB> GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8410", Offset = "0x5EA7210", VA = "0x185EA8410", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, List<AJLHAJMDLPI.LMBJCLNPJBB> PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private class PHHKNLLBCDJ : Property<AJLHAJMDLPI, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA570", Offset = "0x5EA9370", VA = "0x185EAA570", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA530", Offset = "0x5EA9330", VA = "0x185EAA530")]
		public PHHKNLLBCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA4E0", Offset = "0x5EA92E0", VA = "0x185EAA4E0", Slot = "14")]
		public override GameObject GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA500", Offset = "0x5EA9300", VA = "0x185EAA500", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, GameObject PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private class DDKKNDCAMIO : Property<AJLHAJMDLPI, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5EA33D0", Offset = "0x5EA21D0", VA = "0x185EA33D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3390", Offset = "0x5EA2190", VA = "0x185EA3390")]
		public DDKKNDCAMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3340", Offset = "0x5EA2140", VA = "0x185EA3340", Slot = "14")]
		public override Light GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3360", Offset = "0x5EA2160", VA = "0x185EA3360", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, Light PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	private class ECKLJEONCAP : Property<AJLHAJMDLPI, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5EA39A0", Offset = "0x5EA27A0", VA = "0x185EA39A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3960", Offset = "0x5EA2760", VA = "0x185EA3960")]
		public ECKLJEONCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3910", Offset = "0x5EA2710", VA = "0x185EA3910", Slot = "14")]
		public override Collider GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3930", Offset = "0x5EA2730", VA = "0x185EA3930", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, Collider PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	private class EFKCDFOCLPP : Property<AJLHAJMDLPI, string>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3A60", Offset = "0x5EA2860", VA = "0x185EA3A60", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3A20", Offset = "0x5EA2820", VA = "0x185EA3A20")]
		public EFKCDFOCLPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA39D0", Offset = "0x5EA27D0", VA = "0x185EA39D0", Slot = "14")]
		public override string GetValue(AJLHAJMDLPI FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA39F0", Offset = "0x5EA27F0", VA = "0x185EA39F0", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI FEKKHCCBLJM, string PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3B50", Offset = "0x5EA2950", VA = "0x185EA3B50")]
	public ENCCODFIDEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class ICNMBJICNFP : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	private class HEGOJHKFOPA : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5EA7D20", Offset = "0x5EA6B20", VA = "0x185EA7D20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7C30", Offset = "0x5EA6A30", VA = "0x185EA7C30")]
		public HEGOJHKFOPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xDCD950", Offset = "0xDCC750", VA = "0x180DCD950", Slot = "14")]
		public override Data128 GetValue(SerializableGuid FEKKHCCBLJM)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7C20", Offset = "0x5EA6A20", VA = "0x185EA7C20", Slot = "15")]
		public override void SetValue(SerializableGuid FEKKHCCBLJM, Data128 PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7F40", Offset = "0x5EA6D40", VA = "0x185EA7F40")]
	public ICNMBJICNFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class LPOKEPGIAII : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	private class GIBNOAGALLB : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4820", Offset = "0x5EA3620", VA = "0x185EA4820", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4730", Offset = "0x5EA3530", VA = "0x185EA4730")]
		public GIBNOAGALLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1294140", Offset = "0x1292F40", VA = "0x181294140", Slot = "14")]
		public override int GetValue(Data128 FEKKHCCBLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B40", Offset = "0x5EA1940", VA = "0x185EA2B40", Slot = "15")]
		public override void SetValue(Data128 FEKKHCCBLJM, int PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	private class BHMKIJLEJAH : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2E50", Offset = "0x5EA1C50", VA = "0x185EA2E50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2D60", Offset = "0x5EA1B60", VA = "0x185EA2D60")]
		public BHMKIJLEJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2D40", Offset = "0x5EA1B40", VA = "0x185EA2D40", Slot = "14")]
		public override int GetValue(Data128 FEKKHCCBLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2D50", Offset = "0x5EA1B50", VA = "0x185EA2D50", Slot = "15")]
		public override void SetValue(Data128 FEKKHCCBLJM, int PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000113")]
	private class OJCENOBIKCP : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5EAA1F0", Offset = "0x5EA8FF0", VA = "0x185EAA1F0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA100", Offset = "0x5EA8F00", VA = "0x185EAA100")]
		public OJCENOBIKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1566A70", Offset = "0x1565870", VA = "0x181566A70", Slot = "14")]
		public override int GetValue(Data128 FEKKHCCBLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA0F0", Offset = "0x5EA8EF0", VA = "0x185EAA0F0", Slot = "15")]
		public override void SetValue(Data128 FEKKHCCBLJM, int PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	private class CCIOLDHHNJG : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5EA30A0", Offset = "0x5EA1EA0", VA = "0x185EA30A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2FB0", Offset = "0x5EA1DB0", VA = "0x185EA2FB0")]
		public CCIOLDHHNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2F90", Offset = "0x5EA1D90", VA = "0x185EA2F90", Slot = "14")]
		public override int GetValue(Data128 FEKKHCCBLJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2FA0", Offset = "0x5EA1DA0", VA = "0x185EA2FA0", Slot = "15")]
		public override void SetValue(Data128 FEKKHCCBLJM, int PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8ED0", Offset = "0x5EA7CD0", VA = "0x185EA8ED0")]
	public LPOKEPGIAII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class LPKHGKDLCGD : ContainerPropertyBag<AJLHAJMDLPI.HIPGHNBDCLH>
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	private class BMPNOPOECHE : Property<AJLHAJMDLPI.HIPGHNBDCLH, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2F40", Offset = "0x5EA1D40", VA = "0x185EA2F40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2F00", Offset = "0x5EA1D00", VA = "0x185EA2F00")]
		public BMPNOPOECHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8B3570", Offset = "0x8B2370", VA = "0x1808B3570", Slot = "14")]
		public override Vector3 GetValue(AJLHAJMDLPI.HIPGHNBDCLH FEKKHCCBLJM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2EE0", Offset = "0x5EA1CE0", VA = "0x185EA2EE0", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI.HIPGHNBDCLH FEKKHCCBLJM, Vector3 PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	private class HFGIDPCLINF : Property<AJLHAJMDLPI.HIPGHNBDCLH, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA7E30", Offset = "0x5EA6C30", VA = "0x185EA7E30", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7DF0", Offset = "0x5EA6BF0", VA = "0x185EA7DF0")]
		public HFGIDPCLINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7DD0", Offset = "0x5EA6BD0", VA = "0x185EA7DD0", Slot = "14")]
		public override List<SerializableGuid> GetValue(AJLHAJMDLPI.HIPGHNBDCLH FEKKHCCBLJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7DE0", Offset = "0x5EA6BE0", VA = "0x185EA7DE0", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI.HIPGHNBDCLH FEKKHCCBLJM, List<SerializableGuid> PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8D70", Offset = "0x5EA7B70", VA = "0x185EA8D70")]
	public LPKHGKDLCGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal class MCEBFFDLKKC : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	private class INOKIFLJDDM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8510", Offset = "0x5EA7310", VA = "0x185EA8510", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5EA84D0", Offset = "0x5EA72D0", VA = "0x185EA84D0")]
		public INOKIFLJDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5EA84B0", Offset = "0x5EA72B0", VA = "0x185EA84B0", Slot = "14")]
		public override float GetValue(Vector3 FEKKHCCBLJM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5EA84C0", Offset = "0x5EA72C0", VA = "0x185EA84C0", Slot = "15")]
		public override void SetValue(Vector3 FEKKHCCBLJM, float PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011A")]
	private class JDKHDPJPENM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8740", Offset = "0x5EA7540", VA = "0x185EA8740", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8700", Offset = "0x5EA7500", VA = "0x185EA8700")]
		public JDKHDPJPENM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA86E0", Offset = "0x5EA74E0", VA = "0x185EA86E0", Slot = "14")]
		public override float GetValue(Vector3 FEKKHCCBLJM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA86F0", Offset = "0x5EA74F0", VA = "0x185EA86F0", Slot = "15")]
		public override void SetValue(Vector3 FEKKHCCBLJM, float PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011B")]
	private class NNBKAKKDAEM : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9FA0", Offset = "0x5EA8DA0", VA = "0x185EA9FA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9F60", Offset = "0x5EA8D60", VA = "0x185EA9F60")]
		public NNBKAKKDAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1944690", Offset = "0x1943490", VA = "0x181944690", Slot = "14")]
		public override float GetValue(Vector3 FEKKHCCBLJM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9F50", Offset = "0x5EA8D50", VA = "0x185EA9F50", Slot = "15")]
		public override void SetValue(Vector3 FEKKHCCBLJM, float PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5EA93C0", Offset = "0x5EA81C0", VA = "0x185EA93C0")]
	public MCEBFFDLKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
internal class GFBCPBCMHDJ : ContainerPropertyBag<AJLHAJMDLPI.LMBJCLNPJBB>
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	private class JPLMPAADOHG : Property<AJLHAJMDLPI.LMBJCLNPJBB, AJLHAJMDLPI.HIPGHNBDCLH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5EA8880", Offset = "0x5EA7680", VA = "0x185EA8880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8840", Offset = "0x5EA7640", VA = "0x185EA8840")]
		public JPLMPAADOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5EA87D0", Offset = "0x5EA75D0", VA = "0x185EA87D0", Slot = "14")]
		public override AJLHAJMDLPI.HIPGHNBDCLH GetValue(AJLHAJMDLPI.LMBJCLNPJBB FEKKHCCBLJM)
		{
			return default(AJLHAJMDLPI.HIPGHNBDCLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8800", Offset = "0x5EA7600", VA = "0x185EA8800", Slot = "15")]
		public override void SetValue(AJLHAJMDLPI.LMBJCLNPJBB FEKKHCCBLJM, AJLHAJMDLPI.HIPGHNBDCLH PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4650", Offset = "0x5EA3450", VA = "0x185EA4650")]
	public GFBCPBCMHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
internal class NELMDEKBLNN : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	private class BBHCKINEJNK : Property<RRObjectPrefabV2Data, POLLAGMGKIL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override string NKCKPGIEOEO
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2B90", Offset = "0x5EA1990", VA = "0x185EA2B90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override bool FDJGALFBLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B50", Offset = "0x5EA1950", VA = "0x185EA2B50")]
		public BBHCKINEJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1294140", Offset = "0x1292F40", VA = "0x181294140", Slot = "14")]
		public override POLLAGMGKIL GetValue(RRObjectPrefabV2Data FEKKHCCBLJM)
		{
			return default(POLLAGMGKIL);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B40", Offset = "0x5EA1940", VA = "0x185EA2B40", Slot = "15")]
		public override void SetValue(RRObjectPrefabV2Data FEKKHCCBLJM, POLLAGMGKIL PHPDIJICBJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9DB0", Offset = "0x5EA8BB0", VA = "0x185EA9DB0")]
	public NELMDEKBLNN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA800", Offset = "0x5EA9600", VA = "0x185EAA800")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
public class DBFEEPAPMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DBFEEPAPMKO()
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
