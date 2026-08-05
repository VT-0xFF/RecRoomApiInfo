using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EMIEKKLAEON
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly List<(FIFLCEFEDEL nameHash, IMMBALAGBFO stableTypeHash, Type type)> FMNGIILLHPE;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly List<(FIFLCEFEDEL nameHash, IMMBALAGBFO stableTypeHash, Type type)> GFNBFINPIGK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly List<(FIFLCEFEDEL previousNameHash, IMMBALAGBFO previousStableTypeHash, Type currentTypeName)> ANGLLGHOIMP;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FBGCGFEIIFO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Rigidbody FMPHIOBBCLL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x663AD50", Offset = "0x6639350", VA = "0x18663AD50", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public FBGCGFEIIFO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FMEOJFFEEGH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FMJBBKBMCNE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public LMAKLIPDGJL ELKAPNBKJFJ;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GIIFNELAMMI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NNGFJNBFKMK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public object KPOJFEOBAGH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x663E720", Offset = "0x663CD20", VA = "0x18663E720", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NNGFJNBFKMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[InternalBufferCapacity(0)]
public struct MBAOJIMALKP : IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Entity BIKOOLOFJJA;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DMKJHMDIPLC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float MFAOFDACMDO;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly OAJOHIJPGNL<DMKJHMDIPLC> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ICGOKEJPFPL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float3 DPNBMGGNCBN;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JDIMHEMIHPP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NBAPNPGIPAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIKBPHKHBBI(PLHLBCMJFLC PPJEODAFBKD, PLHLBCMJFLC FFAOKGEEGLC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBPCDOPOOMF();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJMJIIPPJPF();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMENLOEIPCO(bool GLHHGCHMOND);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CBIJPEJAMND();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIJJBKLNHLC();
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BNMPLAHHOBD : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct PCGPENCLMBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int LGIDGPKFJOB;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x19EE800", Offset = "0x19ECE00", VA = "0x1819EE800")]
	public static PCGPENCLMBO LBBGOAOJJNO(int MOLEJFDINLH)
	{
		return default(PCGPENCLMBO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum LMAKLIPDGJL
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum LMDIKFABHDL : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OIPDKILGLCN : FNCDDBGLKGE, IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GENIMFADPLB KLLBDNMCGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(GENIMFADPLB);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NLEMIJLGCLO : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NBAPNPGIPAA DODHDKBAHNE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x663E6B0", Offset = "0x663CCB0", VA = "0x18663E6B0", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NLEMIJLGCLO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LKLKBACLCLB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct MEAHDKDHCHJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float3x3 KOMDCJMGILD;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly OAJOHIJPGNL<MEAHDKDHCHJ> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NFDBBJJDILH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float HDAKPDFOFBI;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly OAJOHIJPGNL<NFDBBJJDILH> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KIGOJLCLFMB]
public struct NIBBLBFMIMP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Entity MPAGCMNFGMI;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MNJGBFPFJCD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float LBJHKLPMIHG;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly OAJOHIJPGNL<MNJGBFPFJCD> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KBPIEDEACLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float3 GEFAOJGLHPE;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IDCOKLJNAOF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Entity AIMNENJKCBP;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct PCELGJGLJIE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PLHLBCMJFLC
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct OCNLKBGNLAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public float3x3 KOMDCJMGILD;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly OAJOHIJPGNL<MEAHDKDHCHJ> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AKKIGEHGAIH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public Entity HDBBNLFBJKG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct EILGMKEFIKB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct IGGEAACOKKO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public LMAKLIPDGJL KJKPBKMHGGF;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct ENDBIFIMLHL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public RigidbodyConstraints FLIHBOMIALI;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct OOIAEDPDEEK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float DEPBJPBCLCD;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly OAJOHIJPGNL<OOIAEDPDEEK> EOJNEJPDGDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct IMAHDBGMPAP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct NFNGNHNDHML : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public PLHLBCMJFLC IFCLGDALEOD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly OAJOHIJPGNL<NFNGNHNDHML> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct COKAJAPMMKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public CollisionDetectionMode JAINHJJAKPA;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NLBGHMGFGLK : IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public object OCCIGNFIKKJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x663E640", Offset = "0x663CC40", VA = "0x18663E640", Slot = "4")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public NLBGHMGFGLK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct AAHJDFHGJMI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JPMKJJICHLG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct NKPLAKIFABK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float3 JNJNDPIOPJL;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct KPJKELHIOGI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float AJMIJLJBCFE;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct PALGPNCPLOK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float3 LCMLDCPALFO;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[InternalBufferCapacity(8)]
public struct IHMGEAEOPIO : ISystemStateBufferElementData, IBufferElementData, IEquatable<IHMGEAEOPIO>, IINMBNDBECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Entity BIKOOLOFJJA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private Entity DDIPOEAFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90")]
	public IHMGEAEOPIO(Entity BIKOOLOFJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x663C960", Offset = "0x663AF60", VA = "0x18663C960", Slot = "4")]
	public bool Equals(IHMGEAEOPIO FKJGPCABBJN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static IHMGEAEOPIO LBBGOAOJJNO(Entity MPAGCMNFGMI)
	{
		return default(IHMGEAEOPIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(17861436664589231963uL)]
public struct CBAKHOCKHNG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[BKFAGFEANKJ(1)]
	public Entity LIGIEJOGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[BKFAGFEANKJ(2)]
	public bool DJLJGHOEFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[BKFAGFEANKJ(3)]
	public float BCDFPGPMGIF;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[GENLAPEGFFP(1)]
public struct MGJBCBDODFM : HLLDBJJMAKE, IEquatable<MGJBCBDODFM>
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly MGJBCBDODFM CJBAGCINGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[IBIHLBLNPHD(1)]
	public int MJBJADACIFB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140")]
	public MGJBCBDODFM(int MJBJADACIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x663DE00", Offset = "0x663C400", VA = "0x18663DE00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x663DD70", Offset = "0x663C370", VA = "0x18663DD70", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA010", Offset = "0x3BD8610", VA = "0x183BDA010", Slot = "6")]
	public bool Equals(MGJBCBDODFM FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x663DEA0", Offset = "0x663C4A0", VA = "0x18663DEA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x663DE80", Offset = "0x663C480", VA = "0x18663DE80", Slot = "5")]
	public void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x663DE70", Offset = "0x663C470", VA = "0x18663DE70", Slot = "4")]
	public void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
public struct GEELFDNKLBO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[BKFAGFEANKJ(1)]
	public float LONBLMKEDEF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly OAJOHIJPGNL<GEELFDNKLBO> EOJNEJPDGDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal struct AELIKHDBIDN : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal struct EKDDJPACKIG : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Entity MPAGCMNFGMI;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static EKDDJPACKIG LBBGOAOJJNO(Entity MPAGCMNFGMI)
	{
		return default(EKDDJPACKIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[JBNLHFBJJNA]
[FGHCPEJMPAH("Container", 0)]
[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
public struct MHHBPGDPMOE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(1)]
	public JFOLKPKEHBJ EJBKGMJFFOC;
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Flags]
[KPBCNLAEJPF(0, 15943)]
public enum JFOLKPKEHBJ
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	PhysicsEnabled = 1,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	GravityEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	HasCustomMass = 4,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CollisionEvent = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CanUse = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CanClimb = 0x400,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CanWallRun = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CanClamber = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CanTeleport = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	ALL = 0x3E47,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	MAX = 0x3E47
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct JLOCBELGKKH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KDENFPKHMMG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct FLCAEIFAGLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct CJHLDKDANGF : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct HDOKFNADMHJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public struct HGPAILHKGBC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct CGHPHMFEABL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct GILNIIODJIE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200003B")]
public struct KGNNPCONOHK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(10026670690793008625uL)]
public struct AKFEDBPJDOJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[IBIHLBLNPHD(1)]
	public FNILJLPBJPB MPNDOHBKHJO;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly OAJOHIJPGNL<AKFEDBPJDOJ> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum FNILJLPBJPB : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	VERSION_0 = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DEFORMABLE_SCALE_REMOVED_FROM_SPLINES = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CURRENT = 1u
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
public struct FJEOOOCNEKL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[BKFAGFEANKJ(1)]
	public float3 IJEBNGNKLON;

	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly OAJOHIJPGNL<FJEOOOCNEKL> EOJNEJPDGDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
	public static FJEOOOCNEKL LBBGOAOJJNO(float3 MOLEJFDINLH)
	{
		return default(FJEOOOCNEKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[GJCEKCHGDCD]
[BDAGNAIDOGN(3318727941304405759uL, 6047901070934821887uL)]
[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
public struct KLOPGFFGGJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public int NNMJCNFFFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[BKFAGFEANKJ(2)]
	public bool PIALICHAIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[BKFAGFEANKJ(3)]
	public bool HJIIOJMOAOE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly OAJOHIJPGNL<KLOPGFFGGJH> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public struct EOEAFFEAOLE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float HBIJEGODDDK;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly OAJOHIJPGNL<EOEAFFEAOLE> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
public struct JJCLPAEIJMF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[BKFAGFEANKJ(1)]
	public SerializableGuid NEDBLEJEGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[BKFAGFEANKJ(2)]
	public SerializableGuid DJLOBGOMBEL;
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(2914713536404587710uL)]
[FGHCPEJMPAH("Container", 0)]
public struct AHALKBKLIJE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[BKFAGFEANKJ(1)]
	[OCFCANNNEKL(0)]
	public COMHGNEIAFA KJHKBCEOCEI;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly OAJOHIJPGNL<AHALKBKLIJE> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[KPBCNLAEJPF(0, 2)]
public enum COMHGNEIAFA
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Off = 0,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Children = 1,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Hull = 2,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal enum OCDLFLOBPFG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Gizmo = 4000,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Primitive = 2000,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Other = 6000,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Prop = 5000,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	GameObject = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class HEDNLKEPJMN
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct IBMOBJFHLCM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(2287738525371715436uL)]
public struct KBADCCOIBMJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[BKFAGFEANKJ(1)]
	public bool MAMJCPDDLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[BKFAGFEANKJ(2)]
	public bool DJLJGHOEFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[BKFAGFEANKJ(3)]
	public float PBBMALJCNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[BKFAGFEANKJ(4)]
	public float JKJLIBLKLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[BKFAGFEANKJ(5)]
	public float OEJABJDKHOO;
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[GENLAPEGFFP(1)]
public struct LCDOAODHHAO : HLLDBJJMAKE
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Flags]
	[KPBCNLAEJPF(0, 7)]
	public enum AOHGEDAEEKG
	{
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[IBIHLBLNPHD(1)]
	public float GKCJNECNBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[IBIHLBLNPHD(2)]
	public int CJBOEJFJDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[IBIHLBLNPHD(3)]
	public AOHGEDAEEKG EJBKGMJFFOC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PEHJIAMCJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x663D8C0", Offset = "0x663BEC0", VA = "0x18663D8C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x663D940", Offset = "0x663BF40", VA = "0x18663D940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool GFMDNIAAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x663D7F0", Offset = "0x663BDF0", VA = "0x18663D7F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x663D770", Offset = "0x663BD70", VA = "0x18663D770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MCAIFJJKGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x663D6D0", Offset = "0x663BCD0", VA = "0x18663D6D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x663D750", Offset = "0x663BD50", VA = "0x18663D750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x663D870", Offset = "0x663BE70", VA = "0x18663D870", Slot = "5")]
	public void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x663D790", Offset = "0x663BD90", VA = "0x18663D790", Slot = "4")]
	public void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal struct LLBEDNNHNON : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct OEKKBLAFHKG : ISystemStateComponentData, IComponentData, IINMBNDBECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Entity NMNJMGLKIGP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Entity DDIPOEAFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90", Slot = "5")]
		set
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal struct AIEBCMOJOGB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200004D")]
public struct PHGCNACCBDO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LCEGPOLIGKI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float4x4 BOENMDMEFLB;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly OAJOHIJPGNL<LCEGPOLIGKI> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
public struct CNJDLGBMLKF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[BKFAGFEANKJ(1)]
	public MMLPKMBDFID PNGDFPNKKAA;
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
public struct JCEKDMMOENF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Flags]
	[KPBCNLAEJPF(0, 7)]
	public enum LKFJKAAIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		MAX = 7
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[BKFAGFEANKJ(1)]
	public LKFJKAAIEAJ EJBKGMJFFOC;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly OAJOHIJPGNL<JCEKDMMOENF> EOJNEJPDGDL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MELPALFEEKH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x663CB40", Offset = "0x663B140", VA = "0x18663CB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HBCIMFKBCHO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x663CAC0", Offset = "0x663B0C0", VA = "0x18663CAC0")]
		get
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
public struct PMBIOKAECJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[BKFAGFEANKJ(1)]
	public float LONBLMKEDEF;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly OAJOHIJPGNL<PMBIOKAECJH> EOJNEJPDGDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000053")]
public struct HJLJCAGMDAG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(13746475565109640919uL)]
public struct JKPFIMDDCDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[BKFAGFEANKJ(1)]
	public CPNJNHMENFJ EAKGHPHOGAL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct IGCEBDFIBOF : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
public struct PCNIEMKNHNM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[BKFAGFEANKJ(1)]
	public Entity JCPFBEJJJPM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct CLCFJNBEOOB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[KPBCNLAEJPF(0, 9)]
public enum DLBKPAILIEM
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Container = 1,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Primitive = 2,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Spline = 3,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Gizmo = 4,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Prop = 5,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Other = 6,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	GameObject = 7,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Player = 8,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Unused = 9,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	COUNT = 10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	MAX = 9
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class DPCDELCEAKB
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6638440", Offset = "0x6636A40", VA = "0x186638440")]
	public static bool AIBCICMOGHA(this DLBKPAILIEM LHEFCBKFAKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[KPBCNLAEJPF(-1, 38)]
public enum IFEBDPAFELD
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	LegacyBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	RR_Sphere = 3,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RR_Cylinder = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	LEGACY_Wedge = 5,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	LEGACY_Pyramid = 6,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LEGACY_TriggerVolumeBox = 7,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RR_Box = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LEGACY_RoundedBox = 9,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	RR_Wedge = 10,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	RR_Pyramid = 11,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RR_HalfSphere = 12,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	RR_Cone = 13,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RR_Pipe = 14,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	RR_Donut = 15,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RR_HalfPipe = 16,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RR_Diamond = 17,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	ADVANCED_Mound = 18,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	ADVANCED_Cube = 19,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	ADVANCED_Sphere = 20,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	ADVANCED_Cylinder = 21,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	ADVANCED_Cone = 22,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	ADVANCED_Pyramid = 23,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	ADVANCED_Octagon = 24,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	ADVANCED_Triangle = 25,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	ADVANCED_Hexagon = 26,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	ADVANCED_QuarterPipe = 27,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	ADVANCED_Pentagon = 28,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	ADVANCED_Dodecahedron = 29,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	ADVANCED_Trihedron = 30,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	ADVANCED_Octahedron = 31,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	RR_QuarterCylinder = 32,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	RR_Pentagon = 33,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	RR_QuarterSphere = 34,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	ADVANCED_Wedge = 35,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	RR_Hexagon = 36,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	RR_Octagon = 37,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	RR_Triangle = 38,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	COUNT = 39,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	MIN_VALUE = -1,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	MAX_VALUE = 38
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[GJCEKCHGDCD]
[TypeManager.ForcedStableTypeHash(17017036095303668770uL)]
[BDAGNAIDOGN(15725208981563603541uL, 17017036095303668770uL)]
public struct CNOBHIGJNMG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[BKFAGFEANKJ(1)]
	public BLIAAMDKPNO POJMFCODLHG;
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public struct GGKDGOKKBOG : IComponentData, IComparable<GGKDGOKKBOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public int GCBPOIPBFEF;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1891060", Offset = "0x188F660", VA = "0x181891060", Slot = "4")]
	public int CompareTo(GGKDGOKKBOG FKJGPCABBJN)
	{
		return default(int);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct OPODNNPPPIB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[GJCEKCHGDCD]
[BDAGNAIDOGN(12226092714547765037uL, 15970362445488810630uL)]
[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
public struct OJPEGELMFKM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[BKFAGFEANKJ(2)]
	public PKDCFMEDGMN CBFJDMODLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(3)]
	public FPKNHKANDMB IOMLPDBOBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[IBIHLBLNPHD(4)]
	public FFGHAHAEKGF EJBKGMJFFOC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public static readonly OAJOHIJPGNL<OJPEGELMFKM> EOJNEJPDGDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal struct CIBLFCLIPAL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[KPBCNLAEJPF(0, 2)]
public enum OPMNBOAEHGB
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Primitive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Spline = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	MAX = 2
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[KPBCNLAEJPF(0, 1)]
public enum CPNJNHMENFJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Custom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	MAX = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct HANGLEPMMLC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FEEIGPNDGON : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
public struct GDEOBAAEKDF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[BKFAGFEANKJ(1)]
	public LBNLJFLJFKA NCDJCLLFOIF;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static GDEOBAAEKDF LBBGOAOJJNO(LBNLJFLJFKA MOLEJFDINLH)
	{
		return default(GDEOBAAEKDF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
[FGHCPEJMPAH("Container", 0)]
public struct ELLFNEHLMBC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[BKFAGFEANKJ(1)]
	[OCFCANNNEKL(0)]
	public FixedString64Bytes ECMAPGHKHFB;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class HNLJHOHENEB
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x663C560", Offset = "0x663AB60", VA = "0x18663C560")]
	public static void FGMAFKALEHD(this ref FFGHAHAEKGF EJBKGMJFFOC, JNPNKFKPBJG EIJMADLIEFJ, bool GKJOEINIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x663C5B0", Offset = "0x663ABB0", VA = "0x18663C5B0")]
	public static bool MMPFJCOAFIN(this FFGHAHAEKGF EJBKGMJFFOC, JNPNKFKPBJG EIJMADLIEFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x663C550", Offset = "0x663AB50", VA = "0x18663C550")]
	public static FFGHAHAEKGF AHGPGBFJMDD(this JNPNKFKPBJG EIJMADLIEFJ)
	{
		return default(FFGHAHAEKGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x663C590", Offset = "0x663AB90", VA = "0x18663C590")]
	public static void FGMAFKALEHD(this ref FPKNHKANDMB EJBKGMJFFOC, FPKNHKANDMB PDLGJEIPEDC, bool GKJOEINIIAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public enum JNPNKFKPBJG
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	SupportsRotation,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	SupportsDeformation,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	SupportsScaling,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SupportsMirroring,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	SupportsCloning,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	SupportsRecoloring,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	CanDestroy,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	CanSaveIntoInventions,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	SupportsRespawn,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	SupportsMerging,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	SupportsSplitting,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	SupportsKeys,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	CanEditWithMakerPen,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	DEPRECATED_IsGrabbable,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[Flags]
[KPBCNLAEJPF(0, 16383)]
public enum FFGHAHAEKGF
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	All = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Default = 0x3FFF,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	MAX = 0x3FFF
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[Flags]
[KPBCNLAEJPF(0, 3)]
public enum FPKNHKANDMB
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	IsFrozen = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	IsGrabbable = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	COUNT = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ALL = 3,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	DEFAULT = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	MAX = 3
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[BCPKLAINDNO]
[KPBCNLAEJPF(0, 4)]
public enum IMFMNLGPJGN
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Default = 1,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	CircuitsCanTransform = 2,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	AlwaysStatic = 3,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	COUNT = 4,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BCPKLAINDNO : FPLCNKLFNGK
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6637CA0", Offset = "0x66362A0", VA = "0x186637CA0", Slot = "7")]
	public override string KOCCOHMJDND(string KEFANKKKDEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x249D590", Offset = "0x249BB90", VA = "0x18249D590")]
	public BCPKLAINDNO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006C")]
[GJCEKCHGDCD]
[TypeManager.ForcedStableTypeHash(11946378475791123970uL)]
[BDAGNAIDOGN(17667479821163689808uL, 11946378475791123970uL)]
public struct HNKBLKLKNKK : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200006D")]
public struct DIOKKOIGBCO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[GJCEKCHGDCD]
[BDAGNAIDOGN(1029043735688538310uL, 14256247939851101839uL)]
[TypeManager.ForcedStableTypeHash(14256247939851101839uL)]
public struct OLAPNLFKGNN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public DLBKPAILIEM LHEFCBKFAKH;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[KPBCNLAEJPF(int.MinValue, int.MaxValue)]
public enum DFHKOKGFHIE
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Red = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Orange = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Yellow = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	LightGreen = 3,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Blue = 4,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	LightBlue = 5,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Teal = 6,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Green = 7,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Purple = 8,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	LightPink = 9,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Pink = 10,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Brown = 11,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Tan = 12,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	White = 13,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Grey = 14,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	DarkGrey = 15,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	DarkBrown = 16,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	LightBrown = 17,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	LightGrey = 18,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	Black = 19,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	DarkRed = 20,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	DarkOrange = 21,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	DarkYellow = 22,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	DarkGreen = 23,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	DarkTeal = 24,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	DarkBlue = 25,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	DarkPurple = 26,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	DarkPink = 27,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	LightRed = 28,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	LightOrange = 29,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	LightYellow = 30,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Cyan = 31,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	LightPurple = 32,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	DarkTan = 33,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	NewColor1 = 34,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	NewColor2 = 35,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	NewColor3 = 36,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	NewColor4 = 37,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	NewColor5 = 38,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	NewColor6 = 39,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	NewColor7 = 40,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	NewColor8 = 41,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	NewColor9 = 42,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	NewColor10 = 43,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	NewColor11 = 44,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	NewColor12 = 45,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	NewColor13 = 46,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	NewColor14 = 47,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	NewColor15 = 48,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	NewColor16 = 49,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	NewColor17 = 50,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	NewColor18 = 51,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	NewColor19 = 52,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	NewColor20 = 53,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	NewColor21 = 54,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	NewColor22 = 55,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	NewColor23 = 56,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	NewColor24 = 57,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	NewColor25 = 58,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	NewColor26 = 59,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	NewColor27 = 60,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[JBNLHFBJJNA]
[FGHCPEJMPAH("Light", 0)]
[TypeManager.ForcedStableTypeHash(8784076330129195209uL)]
public struct PNOANKGFDEF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(1)]
	public bool LHEAMNILFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[BKFAGFEANKJ(2)]
	[OCFCANNNEKL(0)]
	public float HEDLHDDFHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(3)]
	public float NILANNAAGKO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct KCBDDDNNOLI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
[FGHCPEJMPAH("Container", 0)]
public struct KIMDCJNJFJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(1)]
	public float GHNEJKFLBGF;
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct MOPLMCMCOIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private NativeList<MAMGMBCFDON> BCPEGPJDFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private NativeList<Entity> JIJFOGPOMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private JobHandle CJAPIGNMJBN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ALFPHPKCOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x663E210", Offset = "0x663C810", VA = "0x18663E210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x663E070", Offset = "0x663C670", VA = "0x18663E070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x21C8310", Offset = "0x21C6910", VA = "0x1821C8310")]
	public MOPLMCMCOIP(NativeList<MAMGMBCFDON> BCPEGPJDFMI, NativeList<Entity> JIJFOGPOMHA, JobHandle CJAPIGNMJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x663E0C0", Offset = "0x663C6C0", VA = "0x18663E0C0")]
	public (Entity, NativeSlice<Entity>) KAGBMAMJDIJ(int GPAKLECDLDD)
	{
		return default((Entity, NativeSlice<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x663E010", Offset = "0x663C610", VA = "0x18663E010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct GGKCINHFHOC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public float3 POOFJFBIOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public quaternion MEHKCJCIOOL;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public static readonly OAJOHIJPGNL<GGKCINHFHOC> EOJNEJPDGDL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x663BF60", Offset = "0x663A560", VA = "0x18663BF60")]
	public float3 PIKKGALAOBK(float3 DFPNLMILODO)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public static class GGIBPNKIDJG
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[GJCEKCHGDCD]
[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
[BDAGNAIDOGN(218523523639012570uL, 15191719635551116065uL)]
public struct CPMHGMPMCAO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private uint NLLKMBEPOGE;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000077")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
public struct FNMHBKFNLLP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[JBNLHFBJJNA]
[FGHCPEJMPAH("Light", 0)]
[TypeManager.ForcedStableTypeHash(2702973985211583679uL)]
public struct IHMCLEIHKJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	[BKFAGFEANKJ(1)]
	[OCFCANNNEKL(0)]
	public float MMDBEDPNKPP;
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
public struct DMAOJAIBEFF : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[BKFAGFEANKJ(1)]
	public quaternion EOGEEAFFCFC;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public static readonly OAJOHIJPGNL<DMAOJAIBEFF> EOJNEJPDGDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
	public static DMAOJAIBEFF LBBGOAOJJNO(quaternion MOLEJFDINLH)
	{
		return default(DMAOJAIBEFF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(1175825970410250986uL)]
public struct ECOKIHFDDDL : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	[BKFAGFEANKJ(1)]
	public Entity LIGIEJOGFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[BKFAGFEANKJ(2)]
	public bool JBIAAPCJFPN;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct MGDABBDBCJK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public FixedString32Bytes ECMAPGHKHFB;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[GJCEKCHGDCD]
[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
[BDAGNAIDOGN(4470189027631723570uL, 5922380073816386711uL)]
public struct BEHAEGOGLIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	[IBIHLBLNPHD(1)]
	public FFGHAHAEKGF EJBKGMJFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	[BKFAGFEANKJ(2)]
	public PKDCFMEDGMN CBFJDMODLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	[BKFAGFEANKJ(3)]
	[OCFCANNNEKL(0)]
	public FPKNHKANDMB IOMLPDBOBED;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public static readonly OAJOHIJPGNL<BEHAEGOGLIO> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public struct EMEJBGNBNKI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public Entity AIEOEHJCENN;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[Flags]
[KPBCNLAEJPF(0, 1)]
public enum FEFKLPDEBLN
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	Static = 0,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	Dynamic = 1,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	All = 1
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007F")]
public struct BADMBCNMDPK : IComponentData
{
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[GENLAPEGFFP(1)]
	public struct Data128
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[IBIHLBLNPHD(1)]
		public int a;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[IBIHLBLNPHD(2)]
		public int b;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[IBIHLBLNPHD(3)]
		public int c;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[IBIHLBLNPHD(4)]
		public int d;
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[GENLAPEGFFP(1)]
	public struct SerializableGuid : IEquatable<SerializableGuid>, IComparable<SerializableGuid>, HLLDBJJMAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[IBIHLBLNPHD(1)]
		public Data128 data;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Guid guid;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
			get
			{
				return default(Guid);
			}
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB91190", Offset = "0xB8F790", VA = "0x180B91190")]
		public static SerializableGuid LBBGOAOJJNO(Guid NAMBIBPENHK)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6640020", Offset = "0x663E620", VA = "0x186640020", Slot = "4")]
		public bool Equals(SerializableGuid FKJGPCABBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6640000", Offset = "0x663E600", VA = "0x186640000", Slot = "5")]
		public int CompareTo(SerializableGuid FKJGPCABBJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x66400B0", Offset = "0x663E6B0", VA = "0x1866400B0", Slot = "6")]
		public void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x66401A0", Offset = "0x663E7A0", VA = "0x1866401A0", Slot = "7")]
		public void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6640220", Offset = "0x663E820", VA = "0x186640220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public struct JDCPHIIOBPN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct LEPJMGMLEEM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[KPBCNLAEJPF(0, 4)]
public enum BICNMPJGDJB
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	Box = 1,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	Sphere = 2,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Capsule = 3,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Mesh = 4,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(10500292550812335578uL)]
public struct LKMEPBNNONH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[BKFAGFEANKJ(1)]
	public bool JNCOAHOACIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[BKFAGFEANKJ(2)]
	public byte HLKDKEEHMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[BKFAGFEANKJ(3)]
	public short KGENEMIINDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[BKFAGFEANKJ(4)]
	public ushort PLNDENOFMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	[BKFAGFEANKJ(5)]
	public int OKBMGFIBFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	[BKFAGFEANKJ(6)]
	public uint KFFJBABNNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	[BKFAGFEANKJ(7)]
	public long MNNKGADLFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	[BKFAGFEANKJ(8)]
	public ulong MFNJBPJDGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	[BKFAGFEANKJ(9)]
	public float INEBJHOGODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	[BKFAGFEANKJ(10)]
	public double MMCHOCDBPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[BKFAGFEANKJ(11)]
	public IHAGNJONOIH ENEFICGEMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	[BKFAGFEANKJ(12)]
	public KIFMFMONIHO MJCAEFAOGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[BKFAGFEANKJ(13)]
	public DEMLBMBMKMN FMCBEEELGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[BKFAGFEANKJ(14)]
	public GLJPNDGFDBL MIEFFOGBJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	[BKFAGFEANKJ(15)]
	public FIJGEJCJOAK KECBDLLCNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	[BKFAGFEANKJ(16)]
	public IFAFOAKHBDN EFDBPCGPJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	[BKFAGFEANKJ(17)]
	public MJBMNGKBNMN JLHKFNOPKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	[BKFAGFEANKJ(18)]
	public JPPEDEBFEBG KIOBJFCJNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	[BKFAGFEANKJ(20)]
	public Quaternion FNHOCPIOJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	[BKFAGFEANKJ(22)]
	public Vector3 MDADDAALEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	[BKFAGFEANKJ(23)]
	public Vector4 JNLPKBHMEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	[BKFAGFEANKJ(40)]
	public Entity GEIFGLPEKGO;
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum IHAGNJONOIH : sbyte
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Lo = sbyte.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	Hi = sbyte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum KIFMFMONIHO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Hi = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum DEMLBMBMKMN : short
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Lo = short.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	Hi = short.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public enum GLJPNDGFDBL : ushort
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Lo = 0,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Hi = ushort.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public enum FIJGEJCJOAK
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Lo = int.MinValue,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Hi = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public enum IFAFOAKHBDN : uint
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	Lo = 0u,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Hi = uint.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public enum MJBMNGKBNMN : long
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	Lo = long.MinValue,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	Hi = long.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public enum JPPEDEBFEBG : ulong
{
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Lo = 0uL,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	Hi = ulong.MaxValue
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[JBNLHFBJJNA]
	[TypeManager.ForcedStableTypeHash(16989005648453901889uL)]
	public struct TestSerializableGuidData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public SerializableGuid myGuid;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[JBNLHFBJJNA]
	[TypeManager.ForcedStableTypeHash(5686768604321027331uL)]
	public struct TestNonSerializedNativeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int serialized;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int nonSerialized;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class EGJFFAMMEPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public int NFNCBDOMNAL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public int LOAJOHBMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public GameObject FLCGKEKAMCK;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public EGJFFAMMEPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class DPJGDMIOKNF : IComponentData
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public struct LPLFOCGAOLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector3 KPFKCNAELDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public List<SerializableGuid> DJNBGHDLHCB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class JPDMLMECAMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public LPLFOCGAOLN FCNHHJKBMEN;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JPDMLMECAMH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public SerializableGuid CDIAELCGDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public List<int> DKNEGLCADNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public List<LPLFOCGAOLN> EFEJGNDMBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public List<JPDMLMECAMH> JCFIKFFLMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public GameObject FLCGKEKAMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Light MPBPNGOCDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Collider HCHCJABNKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public string ABMBKHBCJFL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public DPJGDMIOKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[GJCEKCHGDCD]
[FGHCPEJMPAH("Container", 0)]
[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
[BDAGNAIDOGN(2613756846563002039uL, 6372660366488563574uL)]
public struct ACCOAJDACPD : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	[BKFAGFEANKJ(1)]
	[OCFCANNNEKL(0)]
	public MIBPPLJIIEC POBINHDMIOP;
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[Flags]
[KPBCNLAEJPF(0, 15)]
public enum MIBPPLJIIEC
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	NONE = 0,
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	Object = 1,
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	Player = 2,
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	Projectile = 4,
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	Vehicle = 8,
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	ALL = 0xF,
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	MAX = 0xF
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[GJCEKCHGDCD]
[BDAGNAIDOGN(9804513251708000208uL, 10903582988135044631uL)]
[TypeManager.ForcedStableTypeHash(10903582988135044631uL)]
public struct HOGLDMLGMDM : IComponentData, IEquatable<HOGLDMLGMDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	[BKFAGFEANKJ(1)]
	public FixedString64Bytes ECMAPGHKHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	[BKFAGFEANKJ(2)]
	public COMHGNEIAFA KJHKBCEOCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	[BKFAGFEANKJ(3)]
	public MIBPPLJIIEC POBINHDMIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	[BKFAGFEANKJ(4)]
	public AHANMLEKNPF LAMKNFAOLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	[BKFAGFEANKJ(5)]
	public JFOLKPKEHBJ EJBKGMJFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	[BKFAGFEANKJ(6)]
	public float GHNEJKFLBGF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x663C5D0", Offset = "0x663ABD0", VA = "0x18663C5D0", Slot = "4")]
	public bool Equals(HOGLDMLGMDM FKJGPCABBJN)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct MACLAGOABDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
public struct DKMEAPNDDIB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	[BKFAGFEANKJ(1)]
	public LCDOAODHHAO FKGPFMNALNI;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
public struct EOJLFMPKHEN : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	[BKFAGFEANKJ(1)]
	public float3 IPKLBGKEJKA;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly OAJOHIJPGNL<EOJLFMPKHEN> EOJNEJPDGDL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
	public static EOJLFMPKHEN LBBGOAOJJNO(float3 MOLEJFDINLH)
	{
		return default(EOJLFMPKHEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct MGKCNAGGBBM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public Entity AIEOEHJCENN;
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[InternalBufferCapacity(8)]
public struct MJAGKJKNKOM : ISystemStateBufferElementData, IBufferElementData, IEquatable<MJAGKJKNKOM>, IINMBNDBECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public Entity BIKOOLOFJJA;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Entity DDIPOEAFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "5")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90", Slot = "6")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x663C960", Offset = "0x663AF60", VA = "0x18663C960", Slot = "4")]
	public bool Equals(MJAGKJKNKOM FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal struct DJFCHHDFPEB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public Entity JCPFBEJJJPM;
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[KPBCNLAEJPF(0, 4)]
public enum MMLPKMBDFID
{
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Clamp = 1,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	Piston = 2,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	Rotator = 3,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	LookAt = 4,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	COUNT = 5,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	MAX = 4
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
public struct OGEEBLLKOPC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	[BKFAGFEANKJ(1)]
	public quaternion EOGEEAFFCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	[BKFAGFEANKJ(2)]
	public float3 IPKLBGKEJKA;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static readonly OAJOHIJPGNL<OGEEBLLKOPC> EOJNEJPDGDL;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2509330", Offset = "0x2507930", VA = "0x182509330")]
	public OGEEBLLKOPC(quaternion EOGEEAFFCFC, float3 IPKLBGKEJKA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x663CE80", Offset = "0x663B480", VA = "0x18663CE80")]
	public static RigidTransform LBBGOAOJJNO(OGEEBLLKOPC HIMCLFEDNLF)
	{
		return default(RigidTransform);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x663CE80", Offset = "0x663B480", VA = "0x18663CE80")]
	public static OGEEBLLKOPC LBBGOAOJJNO(RigidTransform HODCICPOGLO)
	{
		return default(OGEEBLLKOPC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public static class NNGHAKBDIOH
{
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface IINMBNDBECP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Entity HIPHDCMNHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[GJCEKCHGDCD]
[BDAGNAIDOGN(9807788745867066359uL, 15168486114979071194uL)]
[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
public struct LHBAAFMGKHE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	[BKFAGFEANKJ(1)]
	public FFGHAHAEKGF EJBKGMJFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	[BKFAGFEANKJ(2)]
	public PKDCFMEDGMN CBFJDMODLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	[BKFAGFEANKJ(3)]
	[OCFCANNNEKL(0)]
	public bool PIILFGJNOKI;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static readonly OAJOHIJPGNL<LHBAAFMGKHE> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[JBNLHFBJJNA]
[TypeManager.TypeVersion(2)]
[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
public struct FLAKOIGHJDJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[BKFAGFEANKJ(2)]
	public bool PIALICHAIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[BKFAGFEANKJ(3)]
	public bool HJIIOJMOAOE;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly OAJOHIJPGNL<FLAKOIGHJDJ> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(16541670854338945984uL)]
[TypeManager.TypeVersion(3)]
[FGHCPEJMPAH("Object", 0)]
public struct NGCDNCDIPIJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	[BKFAGFEANKJ(2)]
	public PKDCFMEDGMN CBFJDMODLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	[BKFAGFEANKJ(3)]
	[OCFCANNNEKL(0)]
	public FPKNHKANDMB IOMLPDBOBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(5)]
	public IMFMNLGPJGN OGLMELHBELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	[IBIHLBLNPHD(4)]
	public FFGHAHAEKGF EJBKGMJFFOC;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly OAJOHIJPGNL<NGCDNCDIPIJ> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public struct MNIBFMPEFMN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public int JFFCAOEMPPP;
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public struct OHGFPEDNCJP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public GCHandle PIJDIPADCNB;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public struct ACIGAKLLBFH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private int OIDKFKLNDAG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OLGOBCPPPBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6637510", Offset = "0x6635B10", VA = "0x186637510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6637500", Offset = "0x6635B00", VA = "0x186637500")]
		set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
public struct BJEHHDCELCJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	[BKFAGFEANKJ(1)]
	public Entity NHJBMCPAGCJ;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static BJEHHDCELCJ LBBGOAOJJNO(Entity MPAGCMNFGMI)
	{
		return default(BJEHHDCELCJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[GJCEKCHGDCD]
[TypeManager.ForcedStableTypeHash(2559857777606771911uL)]
[BDAGNAIDOGN(14327281633525910712uL, 2559857777606771911uL)]
public struct GPMDIEICLIM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	[BKFAGFEANKJ(1)]
	public BLIAAMDKPNO POJMFCODLHG;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct IMALGFFDHFO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
public struct DDHBNLFNGBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	[BKFAGFEANKJ(1)]
	public float3 DFHKIINLEAD;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public static readonly OAJOHIJPGNL<DDHBNLFNGBI> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[JBNLHFBJJNA]
[FGHCPEJMPAH("Container", 0)]
[TypeManager.ForcedStableTypeHash(5176564412348566398uL)]
public struct ANMNJIBPKPK : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	[BKFAGFEANKJ(1)]
	[OCFCANNNEKL(0)]
	public AHANMLEKNPF LAMKNFAOLPG;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[KPBCNLAEJPF(0, 1)]
public enum AHANMLEKNPF
{
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	Pivot = 0,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	Bounds = 1,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	COUNT = 2,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	MAX = 1
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[GENLAPEGFFP(1)]
public struct PKDCFMEDGMN : HLLDBJJMAKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	[IBIHLBLNPHD(1)]
	public bool LHEAMNILFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	[IBIHLBLNPHD(2)]
	public float3 OFFOIPDBIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	[IBIHLBLNPHD(3)]
	public float3 NDKEJPHMHHO;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public static readonly OAJOHIJPGNL<PKDCFMEDGMN> EOJNEJPDGDL;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x663F1F0", Offset = "0x663D7F0", VA = "0x18663F1F0", Slot = "5")]
	public void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x663F1A0", Offset = "0x663D7A0", VA = "0x18663F1A0", Slot = "4")]
	public void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
public struct OLFICOFHAAA : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	[BKFAGFEANKJ(1)]
	public IFEBDPAFELD ILDPIPJCHKJ;
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct JEAHGPJFGLB : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public int JFFCAOEMPPP;
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface IHCBJKJDAMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPPGKJCCLKO(bool IAMHOKFEKDD);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[TypeManager.TypeVersion(2)]
public struct GPFOFHIKGAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public uint PODEKELPJJP;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x663C2C0", Offset = "0x663A8C0", VA = "0x18663C2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct DCJCLIAEFLI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B3")]
internal struct LFOPDPPHCOE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct BBLOINNAAAM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[KIGOJLCLFMB]
internal struct EJGDELKHAJG : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public Entity NBDMJMAJLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public int OLGOBCPPPBB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public struct NDNKLODDEKL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
[FGHCPEJMPAH("Visual", 0)]
public struct CCEOMEHKNFO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	[BKFAGFEANKJ(1)]
	[OCFCANNNEKL(0)]
	public DFHKOKGFHIE CMDNLIJPJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(2)]
	public BMMIDHIMKGI FMBPBGHJJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	[BKFAGFEANKJ(3)]
	[OCFCANNNEKL(0)]
	public float FBHLMAOAOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	[BKFAGFEANKJ(4)]
	[OCFCANNNEKL(0)]
	public Vector3 KIKIMCEKCCG;
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[JBNLHFBJJNA]
[FGHCPEJMPAH("Physics", 0)]
[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
public struct MPMDBHHLKDH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	[BKFAGFEANKJ(1)]
	[OCFCANNNEKL(0)]
	public float BNDJIBADLBL;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public static readonly OAJOHIJPGNL<MPMDBHHLKDH> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[GENLAPEGFFP(1)]
public struct LBNLJFLJFKA : IComparable<LBNLJFLJFKA>, IEquatable<LBNLJFLJFKA>, HLLDBJJMAKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	[IBIHLBLNPHD(1)]
	public uint CNLIMCKOKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	[IBIHLBLNPHD(2)]
	public uint GIKIENELGLI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private uint DEFNLONMDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x663D230", Offset = "0x663B830", VA = "0x18663D230")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x663D680", Offset = "0x663BC80", VA = "0x18663D680")]
	public LBNLJFLJFKA(int CNLIMCKOKBD, int IINIGLBFFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x663D680", Offset = "0x663BC80", VA = "0x18663D680")]
	public LBNLJFLJFKA(uint CNLIMCKOKBD, uint IINIGLBFFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x663D380", Offset = "0x663B980", VA = "0x18663D380")]
	public LBNLJFLJFKA HBJAPDOPFKM(int EBMCNIDEEKK = 1)
	{
		return default(LBNLJFLJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x663D4D0", Offset = "0x663BAD0", VA = "0x18663D4D0")]
	public LBNLJFLJFKA JKJNNHOHDJA(int EBMCNIDEEKK = 1)
	{
		return default(LBNLJFLJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x663D3E0", Offset = "0x663B9E0", VA = "0x18663D3E0")]
	public static LBNLJFLJFKA HGGMGFLPPFH(LBNLJFLJFKA CBNLLBDNGLG, LBNLJFLJFKA FDIDEGFPCIP)
	{
		return default(LBNLJFLJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x663D300", Offset = "0x663B900", VA = "0x18663D300")]
	private static uint GCNEFFEHCJC(uint GNJGFBLEGKK, uint HEPECHBEGLE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x663D210", Offset = "0x663B810", VA = "0x18663D210", Slot = "4")]
	public int CompareTo(LBNLJFLJFKA FKJGPCABBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x663D240", Offset = "0x663B840", VA = "0x18663D240", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x663D5A0", Offset = "0x663BBA0", VA = "0x18663D5A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x663D2E0", Offset = "0x663B8E0", VA = "0x18663D2E0", Slot = "5")]
	public bool Equals(LBNLJFLJFKA FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x663D330", Offset = "0x663B930", VA = "0x18663D330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x663D460", Offset = "0x663BA60", VA = "0x18663D460", Slot = "6")]
	public void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x663D530", Offset = "0x663BB30", VA = "0x18663D530", Slot = "7")]
	public void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3092250", Offset = "0x3090850", VA = "0x183092250")]
	public static bool BDIEMMGDBNG(LBNLJFLJFKA CBNLLBDNGLG, LBNLJFLJFKA FDIDEGFPCIP)
	{
		return default(bool);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[JBNLHFBJJNA]
	[TypeManager.ForcedStableTypeHash(798350452111942523uL)]
	public struct RRObjectPrefabV2Data : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public BLIAAMDKPNO prefabType;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public static class LGJJFGHEPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x663DA40", Offset = "0x663C040", VA = "0x18663DA40")]
	public static bool BEHAGHLLDDB(this BLIAAMDKPNO KLGGKKGCLHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x663DAC0", Offset = "0x663C0C0", VA = "0x18663DAC0")]
	public static string OGDKGEFJOFB(this BLIAAMDKPNO KLGGKKGCLHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x663DA70", Offset = "0x663C070", VA = "0x18663DA70")]
	public static DLBKPAILIEM LGLNCHECMNH(this BLIAAMDKPNO POJMFCODLHG)
	{
		return default(DLBKPAILIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x663DAB0", Offset = "0x663C0B0", VA = "0x18663DAB0")]
	internal static OCDLFLOBPFG LKDHLJEAPAE(this DLBKPAILIEM LHEFCBKFAKH)
	{
		return default(OCDLFLOBPFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x663DA90", Offset = "0x663C090", VA = "0x18663DA90")]
	internal static OCDLFLOBPFG LKDHLJEAPAE(this BLIAAMDKPNO POJMFCODLHG)
	{
		return default(OCDLFLOBPFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class FBKLNBBAFPG
{
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly Dictionary<BLIAAMDKPNO, string> GHPMOEOHNJL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x663ADC0", Offset = "0x66393C0", VA = "0x18663ADC0")]
	public static string NGBLJFMLKFJ(this BLIAAMDKPNO KLGGKKGCLHM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public struct GMFPEFFGBGK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[GJCEKCHGDCD]
[BDAGNAIDOGN(9898405628982320166uL, 2023375009558162791uL)]
[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
public struct NDMGNOFKACP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[BKFAGFEANKJ(1)]
	public FFGHAHAEKGF EJBKGMJFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	[BKFAGFEANKJ(2)]
	public PKDCFMEDGMN CBFJDMODLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	[BKFAGFEANKJ(3)]
	[OCFCANNNEKL(0)]
	public bool PIILFGJNOKI;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public static readonly OAJOHIJPGNL<NDMGNOFKACP> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal struct IFDFDOPAHIP : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public Entity BLGIKJGPCEH;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static IFDFDOPAHIP LBBGOAOJJNO(Entity MPAGCMNFGMI)
	{
		return default(IFDFDOPAHIP);
	}
}
namespace RecRoom.Components
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[JBNLHFBJJNA]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[IBIHLBLNPHD(1)]
		public uint networkIdBits;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public struct PENOILPCCBB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public struct ACMLALFAKEH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public float3 IJJFGJAFMPD;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public static readonly OAJOHIJPGNL<ACMLALFAKEH> EOJNEJPDGDL;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public struct EIFIONNOOAH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(11104975410044731874uL)]
[FGHCPEJMPAH("Container", 0)]
public struct DHJHEPJCIBI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[OCFCANNNEKL(0)]
	[BKFAGFEANKJ(1)]
	public CNDOOEKNEFJ NLCFPEDLIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public static readonly OAJOHIJPGNL<DHJHEPJCIBI> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[KPBCNLAEJPF(0, 127)]
public enum CNDOOEKNEFJ
{
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	IsDynamicEnvironment = 0,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	IsDynamic = 10,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	IsDynamicIgnoreStaticGeometry = 11,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	IsDynamicIgnoreOtherDynamic = 12,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	IsDynamicIgnorePlayers = 13,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	IsDynamicIgnoreMost = 14,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	IsEnemyCollision = 30,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	IsEnemyProjectile = 31,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	IsVehicleCollision = 40,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	STATIC = 100,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	DECORATION = 101,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	MIN = 0,
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	MAX = 127
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public static class HPHPLCBBLGF
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public enum ICJOCOIHENM
	{
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		Dynamic,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		Static,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		Enemy,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		Vehicle
	}

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public enum MINKNPBLKEG
	{
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		Environmental,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		IgnoreStaticGeometry,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		IgnoreOtherDynamic,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		IgnorePlayers,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		IgnoreMost,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		Projectile
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x663C780", Offset = "0x663AD80", VA = "0x18663C780")]
	public static (ICJOCOIHENM, MINKNPBLKEG) FHFOILBPKBK(this CNDOOEKNEFJ BLKIFNMOPNO)
	{
		return default((ICJOCOIHENM, MINKNPBLKEG));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public struct MAMGMBCFDON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Entity AIMNENJKCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public int EBMCNIDEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public int BFDDLCIBNMB;
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
public struct BCIOGPLFNGO : IComponentData, IINMBNDBECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	[BKFAGFEANKJ(1)]
	public Entity HDBBNLFBJKG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private Entity DDIPOEAFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90")]
	public BCIOGPLFNGO(Entity HDBBNLFBJKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static BCIOGPLFNGO LBBGOAOJJNO(Entity MPAGCMNFGMI)
	{
		return default(BCIOGPLFNGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public struct MJMBIIBNCJB : ISystemStateComponentData, IComponentData, IINMBNDBECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Entity NMNJMGLKIGP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private Entity DDIPOEAFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90")]
	public MJMBIIBNCJB(Entity HDBBNLFBJKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static MJMBIIBNCJB LBBGOAOJJNO(Entity MPAGCMNFGMI)
	{
		return default(MJMBIIBNCJB);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public struct OFBDJCKAPOI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[KPBCNLAEJPF(1000, 8000)]
public enum BLIAAMDKPNO
{
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	Container = 1000,
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	LegacyShapeContainer = 1001,
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	CreationShapeContainer = 1002,
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	Gizmo_Clamp = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	Gizmo_Piston = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	Gizmo_Rotator = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	Gizmo_LookAt = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	Shape_Primitive_LegacyBox = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	Shape_Primitive_Sphere = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	Shape_Primitive_Cylinder = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Shape_Primitive_LegacyWedge = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Shape_Primitive_LegacyPyramid = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	Shape_Primitive_TriggerVolumeBox = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Shape_Primitive_Box = 2006,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Shape_Primitive_RoundedBox = 2007,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	Shape_Primitive_Wedge = 2008,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Shape_Primitive_Pyramid = 2009,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Shape_Primitive_HalfSphere = 2010,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Shape_Primitive_Cone = 2011,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Shape_Primitive_Pipe = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Shape_Primitive_Donut = 2013,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Shape_Primitive_HalfPipe = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Shape_Primitive_Diamond = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Shape_Primitive_Mound = 2016,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Shape_Primitive_ADVANCED_Cube = 2017,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	Shape_Primitive_ADVANCED_Sphere = 2018,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Shape_Primitive_ADVANCED_Cylinder = 2019,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Shape_Primitive_ADVANCED_Cone = 2020,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	Shape_Primitive_ADVANCED_Pyramid = 2021,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Shape_Primitive_ADVANCED_Octagon = 2022,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Shape_Primitive_ADVANCED_Triangle = 2023,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Shape_Primitive_ADVANCED_Hexagon = 2024,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Shape_Primitive_ADVANCED_QuarterPipe = 2025,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Shape_Primitive_ADVANCED_Pentagon = 2026,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Shape_Primitive_ADVANCED_Dodecahedron = 2027,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Shape_Primitive_ADVANCED_Trihedron = 2028,
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	Shape_Primitive_ADVANCED_Octahedron = 2029,
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	Shape_Primitive_RR_QuarterCylinder = 2030,
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	Shape_Primitive_RR_Pentagon = 2031,
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	Shape_Primitive_RR_QuarterSphere = 2032,
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	Shape_Primitive_ADVANCED_Wedge = 2033,
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	Shape_Primitive_RR_Hexagon = 2034,
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	Shape_Primitive_RR_Octagon = 2035,
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	Shape_Primitive_RR_Triangle = 2036,
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	Shape_Spline = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	Other_ContainerPivot = 6000,
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	Other_SplinePoint = 6001,
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	Other_ReferencePoint = 6002,
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	Prop_Custom = 5000,
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	GameObject_Transform = 7000,
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	GameObject_Rbex = 7001,
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	GameObject_Prop = 7002,
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	GameObject_LegacyGizmo = 7003,
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	GameObject_GameRoleNode = 7004,
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	GameObject_PlayerRbex = 7005,
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	Player = 8000
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public static class NEEKMOGEABB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public struct DHAAAOHHMLG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[KPBCNLAEJPF(-2, 2)]
public enum AKCLPPOLBLP
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	Frozen = -2,
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	Low = -1,
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	High = 1,
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	Realtime = 2,
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	MIN = -2,
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	MAX = 2
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public struct KFMIIMHGDMK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public struct NBHLOOFJEDB : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public uint KMJLMOGHNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public int GOGDMIDKHMF;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
	public NBHLOOFJEDB(uint FNKHCMNDJKG, int NJDCLKNHNPJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct FIINPCOKHHA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[KPBCNLAEJPF(-1, 31)]
public enum BMMIDHIMKGI
{
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	Cardboard = 0,
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	Neon = 1,
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	Brick = 2,
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	Carpet = 3,
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	Dirt = 4,
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	Grass = 5,
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	MetalReflective = 6,
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	Concrete = 7,
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	Linoleum = 8,
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	Plaster = 9,
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	WoodLogs = 10,
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	WoodBoards = 11,
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	WoodGrain = 12,
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	WoodFloor = 13,
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	Sand = 14,
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	GlossyPlastic = 15,
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Cloth = 16,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	RubberFloor = 17,
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	MetalFloorTread = 18,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	PaintedBrick = 19,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	Crashpad = 20,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	PaintedWood = 21,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	GripTape = 22,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	GalvanizedMetal = 23,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	ParticleBoard = 24,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	CheckeredFloor = 25,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	SparklyVinyl = 26,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	Gravel = 27,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	Rock = 28,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	Placeholder29 = 29,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	Placeholder30 = 30,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	Placeholder31 = 31,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	COUNT = 32,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	MIN = -1,
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	MAX = 31,
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	Default = 0
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(119653618660684511uL)]
public struct GHCCPKENDJG : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	[BKFAGFEANKJ(1)]
	public MGJBCBDODFM AHPGKLPDJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public GCHandle DFKGLOBLDNJ;
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public struct JKCIFKNJAAP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public float4x4 CNKALCHPDKE;

	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public static readonly OAJOHIJPGNL<JKCIFKNJAAP> EOJNEJPDGDL;
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
public struct OEMCDAHANNB : IComponentData, IINMBNDBECP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	[BKFAGFEANKJ(1)]
	public Entity HDBBNLFBJKG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Entity DDIPOEAFLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000", Slot = "4")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x19D1C90", Offset = "0x19D0290", VA = "0x1819D1C90")]
	public OEMCDAHANNB(Entity HDBBNLFBJKG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static OEMCDAHANNB LBBGOAOJJNO(Entity MPAGCMNFGMI)
	{
		return default(OEMCDAHANNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x663E9D0", Offset = "0x663CFD0", VA = "0x18663E9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public struct HGNDMLIGLLB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[KIGOJLCLFMB]
public struct MAOFNHAFPHH : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public Entity GHAEGLKDDJL;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x974F00", Offset = "0x973500", VA = "0x180974F00")]
	public static MAOFNHAFPHH LBBGOAOJJNO(Entity MOLEJFDINLH)
	{
		return default(MAOFNHAFPHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
public struct JHJKAPHBION : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	[BKFAGFEANKJ(1)]
	public FEFKLPDEBLN HFDCGCJHBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	[BKFAGFEANKJ(2)]
	public AKCLPPOLBLP LKJJECIAHGE;
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(7633334472333680614uL)]
public struct BDGOFIOOHFJ : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	[BKFAGFEANKJ(1)]
	public bool MAMJCPDDLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	[BKFAGFEANKJ(2)]
	public bool DJLJGHOEFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	[BKFAGFEANKJ(3)]
	public float BCDFPGPMGIF;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public struct FABBAFGEKLI : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal struct BCJBGOABNEL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
public struct JLEHAKNHCDI : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	[BKFAGFEANKJ(1)]
	public quaternion EOGEEAFFCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	[BKFAGFEANKJ(2)]
	public float3 IPKLBGKEJKA;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly OAJOHIJPGNL<JLEHAKNHCDI> EOJNEJPDGDL;

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2509330", Offset = "0x2507930", VA = "0x182509330")]
	public JLEHAKNHCDI(quaternion EOGEEAFFCFC, float3 IPKLBGKEJKA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x663CE80", Offset = "0x663B480", VA = "0x18663CE80")]
	public static JLEHAKNHCDI LBBGOAOJJNO(RigidTransform HODCICPOGLO)
	{
		return default(JLEHAKNHCDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public static class DCIJNLJGAGL
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[JBNLHFBJJNA]
[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
public struct GPDJJLAFFPH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	[BKFAGFEANKJ(1)]
	public OPMNBOAEHGB ILDPIPJCHKJ;
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ComponentData.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : KHJNECAEAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x91C600", Offset = "0x91AC00", VA = "0x18091C600")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6640230", Offset = "0x663E830", VA = "0x186640230", Slot = "4")]
		public sealed override void HLIMFKHODMA()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal class GCCGHFEKJMH : ContainerPropertyBag<FBGCGFEIIFO>
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	private class IAMFLIICHHO : Property<FBGCGFEIIFO, Rigidbody>
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x663C930", Offset = "0x663AF30", VA = "0x18663C930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x663C8F0", Offset = "0x663AEF0", VA = "0x18663C8F0")]
		public IAMFLIICHHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1C0", Offset = "0x28F87C0", VA = "0x1828FA1C0", Slot = "14")]
		public override Rigidbody GetValue(ref FBGCGFEIIFO IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1E0", Offset = "0x28F87E0", VA = "0x1828FA1E0", Slot = "15")]
		public override void SetValue(ref FBGCGFEIIFO IBEPDAFMEAD, Rigidbody MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x663BCA0", Offset = "0x663A2A0", VA = "0x18663BCA0")]
	public GCCGHFEKJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal class HOHGEBKBLHE : ContainerPropertyBag<NNGFJNBFKMK>
{
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class AAMGGNEGDEK : Property<NNGFJNBFKMK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6637440", Offset = "0x6635A40", VA = "0x186637440", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6637400", Offset = "0x6635A00", VA = "0x186637400")]
		public AAMGGNEGDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1C0", Offset = "0x28F87C0", VA = "0x1828FA1C0", Slot = "14")]
		public override object GetValue(ref NNGFJNBFKMK IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1E0", Offset = "0x28F87E0", VA = "0x1828FA1E0", Slot = "15")]
		public override void SetValue(ref NNGFJNBFKMK IBEPDAFMEAD, object MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x663C6B0", Offset = "0x663ACB0", VA = "0x18663C6B0")]
	public HOHGEBKBLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
internal class IIABOINIMIB : ContainerPropertyBag<NLEMIJLGCLO>
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	private class GPHDIPFCMOM : Property<NLEMIJLGCLO, NBAPNPGIPAA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x663C390", Offset = "0x663A990", VA = "0x18663C390", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x663C350", Offset = "0x663A950", VA = "0x18663C350")]
		public GPHDIPFCMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1C0", Offset = "0x28F87C0", VA = "0x1828FA1C0", Slot = "14")]
		public override NBAPNPGIPAA GetValue(ref NLEMIJLGCLO IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1E0", Offset = "0x28F87E0", VA = "0x1828FA1E0", Slot = "15")]
		public override void SetValue(ref NLEMIJLGCLO IBEPDAFMEAD, NBAPNPGIPAA MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x663C970", Offset = "0x663AF70", VA = "0x18663C970")]
	public IIABOINIMIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal class PGCDIBFPGGM : ContainerPropertyBag<NLBGHMGFGLK>
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	private class BAAIGKMOIFC : Property<NLBGHMGFGLK, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6637B50", Offset = "0x6636150", VA = "0x186637B50", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6637B10", Offset = "0x6636110", VA = "0x186637B10")]
		public BAAIGKMOIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1C0", Offset = "0x28F87C0", VA = "0x1828FA1C0", Slot = "14")]
		public override object GetValue(ref NLBGHMGFGLK IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28FA1E0", Offset = "0x28F87E0", VA = "0x1828FA1E0", Slot = "15")]
		public override void SetValue(ref NLBGHMGFGLK IBEPDAFMEAD, object MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x663F0D0", Offset = "0x663D6D0", VA = "0x18663F0D0")]
	public PGCDIBFPGGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class HBNLLEEIFIK : ContainerPropertyBag<EGJFFAMMEPE>
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	private class NCDNHEDLDGO : Property<EGJFFAMMEPE, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x663E340", Offset = "0x663C940", VA = "0x18663E340", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x663E300", Offset = "0x663C900", VA = "0x18663E300")]
		public NCDNHEDLDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x42B4AC0", Offset = "0x42B30C0", VA = "0x1842B4AC0", Slot = "14")]
		public override int GetValue(ref EGJFFAMMEPE IBEPDAFMEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x663E2E0", Offset = "0x663C8E0", VA = "0x18663E2E0", Slot = "15")]
		public override void SetValue(ref EGJFFAMMEPE IBEPDAFMEAD, int MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	private class BKLBDJAPOPG : Property<EGJFFAMMEPE, int>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x6638060", Offset = "0x6636660", VA = "0x186638060", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6638020", Offset = "0x6636620", VA = "0x186638020")]
		public BKLBDJAPOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x42B4B50", Offset = "0x42B3150", VA = "0x1842B4B50", Slot = "14")]
		public override int GetValue(ref EGJFFAMMEPE IBEPDAFMEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6638000", Offset = "0x6636600", VA = "0x186638000", Slot = "15")]
		public override void SetValue(ref EGJFFAMMEPE IBEPDAFMEAD, int MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	private class AGEBEBONMMA : Property<EGJFFAMMEPE, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6637780", Offset = "0x6635D80", VA = "0x186637780", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6637740", Offset = "0x6635D40", VA = "0x186637740")]
		public AGEBEBONMMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x66376F0", Offset = "0x6635CF0", VA = "0x1866376F0", Slot = "14")]
		public override GameObject GetValue(ref EGJFFAMMEPE IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6637710", Offset = "0x6635D10", VA = "0x186637710", Slot = "15")]
		public override void SetValue(ref EGJFFAMMEPE IBEPDAFMEAD, GameObject MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x663C3C0", Offset = "0x663A9C0", VA = "0x18663C3C0")]
	public HBNLLEEIFIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class OGFHPJIKNMM : ContainerPropertyBag<DPJGDMIOKNF>
{
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	private class BGIALHDPEAB : Property<DPJGDMIOKNF, SerializableGuid>
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6637FD0", Offset = "0x66365D0", VA = "0x186637FD0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6637F90", Offset = "0x6636590", VA = "0x186637F90")]
		public BGIALHDPEAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6637F40", Offset = "0x6636540", VA = "0x186637F40", Slot = "14")]
		public override SerializableGuid GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return default(SerializableGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6637F70", Offset = "0x6636570", VA = "0x186637F70", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, SerializableGuid MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	private class JEGAACGPLEJ : Property<DPJGDMIOKNF, List<int>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x663CCA0", Offset = "0x663B2A0", VA = "0x18663CCA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x663CC60", Offset = "0x663B260", VA = "0x18663CC60")]
		public JEGAACGPLEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x663CC10", Offset = "0x663B210", VA = "0x18663CC10", Slot = "14")]
		public override List<int> GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x663CC30", Offset = "0x663B230", VA = "0x18663CC30", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, List<int> MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	private class AHFJLNFBIAF : Property<DPJGDMIOKNF, List<DPJGDMIOKNF.LPLFOCGAOLN>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x66378A0", Offset = "0x6635EA0", VA = "0x1866378A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6637860", Offset = "0x6635E60", VA = "0x186637860")]
		public AHFJLNFBIAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6637810", Offset = "0x6635E10", VA = "0x186637810", Slot = "14")]
		public override List<DPJGDMIOKNF.LPLFOCGAOLN> GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6637830", Offset = "0x6635E30", VA = "0x186637830", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, List<DPJGDMIOKNF.LPLFOCGAOLN> MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	private class CBAOHICKGPD : Property<DPJGDMIOKNF, List<DPJGDMIOKNF.JPDMLMECAMH>>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6638120", Offset = "0x6636720", VA = "0x186638120", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x66380E0", Offset = "0x66366E0", VA = "0x1866380E0")]
		public CBAOHICKGPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6638090", Offset = "0x6636690", VA = "0x186638090", Slot = "14")]
		public override List<DPJGDMIOKNF.JPDMLMECAMH> GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x66380B0", Offset = "0x66366B0", VA = "0x1866380B0", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, List<DPJGDMIOKNF.JPDMLMECAMH> MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	private class CEPPFOBEAEN : Property<DPJGDMIOKNF, GameObject>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x66381E0", Offset = "0x66367E0", VA = "0x1866381E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x66381A0", Offset = "0x66367A0", VA = "0x1866381A0")]
		public CEPPFOBEAEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6638150", Offset = "0x6636750", VA = "0x186638150", Slot = "14")]
		public override GameObject GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6638170", Offset = "0x6636770", VA = "0x186638170", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, GameObject MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	private class MMHINKBAONP : Property<DPJGDMIOKNF, Light>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x663DF80", Offset = "0x663C580", VA = "0x18663DF80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x663DF40", Offset = "0x663C540", VA = "0x18663DF40")]
		public MMHINKBAONP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x663DEF0", Offset = "0x663C4F0", VA = "0x18663DEF0", Slot = "14")]
		public override Light GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x663DF10", Offset = "0x663C510", VA = "0x18663DF10", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, Light MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	private class AOHHFOPHDJD : Property<DPJGDMIOKNF, Collider>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x66379C0", Offset = "0x6635FC0", VA = "0x1866379C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6637980", Offset = "0x6635F80", VA = "0x186637980")]
		public AOHHFOPHDJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6637930", Offset = "0x6635F30", VA = "0x186637930", Slot = "14")]
		public override Collider GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6637950", Offset = "0x6635F50", VA = "0x186637950", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, Collider MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	private class FCLONLKNCEC : Property<DPJGDMIOKNF, string>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x663B720", Offset = "0x6639D20", VA = "0x18663B720", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x663B6E0", Offset = "0x6639CE0", VA = "0x18663B6E0")]
		public FCLONLKNCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x663B690", Offset = "0x6639C90", VA = "0x18663B690", Slot = "14")]
		public override string GetValue(ref DPJGDMIOKNF IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x663B6B0", Offset = "0x6639CB0", VA = "0x18663B6B0", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF IBEPDAFMEAD, string MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x663EB30", Offset = "0x663D130", VA = "0x18663EB30")]
	public OGFHPJIKNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
internal class GDIAOCBMEKK : ContainerPropertyBag<SerializableGuid>
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	private class NOMHJMCJFAP : Property<SerializableGuid, Data128>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x663E880", Offset = "0x663CE80", VA = "0x18663E880", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x663E790", Offset = "0x663CD90", VA = "0x18663E790")]
		public NOMHJMCJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x19A8230", Offset = "0x19A6830", VA = "0x1819A8230", Slot = "14")]
		public override Data128 GetValue(ref SerializableGuid IBEPDAFMEAD)
		{
			return default(Data128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6425610", Offset = "0x6423C10", VA = "0x186425610", Slot = "15")]
		public override void SetValue(ref SerializableGuid IBEPDAFMEAD, Data128 MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x663BD70", Offset = "0x663A370", VA = "0x18663BD70")]
	public GDIAOCBMEKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal class FPDHDDOBMCC : ContainerPropertyBag<Data128>
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	private class BBANBKADCNJ : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6637C70", Offset = "0x6636270", VA = "0x186637C70", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6637B80", Offset = "0x6636180", VA = "0x186637B80")]
		public BBANBKADCNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0", Slot = "14")]
		public override int GetValue(ref Data128 IBEPDAFMEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E690", Offset = "0x3D4CC90", VA = "0x183D4E690", Slot = "15")]
		public override void SetValue(ref Data128 IBEPDAFMEAD, int MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	private class APIEFINFKOH : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x6637AE0", Offset = "0x66360E0", VA = "0x186637AE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x66379F0", Offset = "0x6635FF0", VA = "0x1866379F0")]
		public APIEFINFKOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6427940", Offset = "0x6425F40", VA = "0x186427940", Slot = "14")]
		public override int GetValue(ref Data128 IBEPDAFMEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x42C6C00", Offset = "0x42C5200", VA = "0x1842C6C00", Slot = "15")]
		public override void SetValue(ref Data128 IBEPDAFMEAD, int MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private class LBIKNGHAGKE : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x663D1E0", Offset = "0x663B7E0", VA = "0x18663D1E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x663D0F0", Offset = "0x663B6F0", VA = "0x18663D0F0")]
		public LBIKNGHAGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x98B450", Offset = "0x989A50", VA = "0x18098B450", Slot = "14")]
		public override int GetValue(ref Data128 IBEPDAFMEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x642DF30", Offset = "0x642C530", VA = "0x18642DF30", Slot = "15")]
		public override void SetValue(ref Data128 IBEPDAFMEAD, int MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	private class AFPIMJLEOOM : Property<Data128, int>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x66376C0", Offset = "0x6635CC0", VA = "0x1866376C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x66375D0", Offset = "0x6635BD0", VA = "0x1866375D0")]
		public AFPIMJLEOOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x642DDC0", Offset = "0x642C3C0", VA = "0x18642DDC0", Slot = "14")]
		public override int GetValue(ref Data128 IBEPDAFMEAD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x642DDD0", Offset = "0x642C3D0", VA = "0x18642DDD0", Slot = "15")]
		public override void SetValue(ref Data128 IBEPDAFMEAD, int MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x663B820", Offset = "0x6639E20", VA = "0x18663B820")]
	public FPDHDDOBMCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class JLKGHEHAJGI : ContainerPropertyBag<DPJGDMIOKNF.LPLFOCGAOLN>
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private class DPNJKAKOKPD : Property<DPJGDMIOKNF.LPLFOCGAOLN, Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x66384B0", Offset = "0x6636AB0", VA = "0x1866384B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6638470", Offset = "0x6636A70", VA = "0x186638470")]
		public DPNJKAKOKPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xD14E90", Offset = "0xD13490", VA = "0x180D14E90", Slot = "14")]
		public override Vector3 GetValue(ref DPJGDMIOKNF.LPLFOCGAOLN IBEPDAFMEAD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6638450", Offset = "0x6636A50", VA = "0x186638450", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF.LPLFOCGAOLN IBEPDAFMEAD, Vector3 MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private class OFPNKJIAGBL : Property<DPJGDMIOKNF.LPLFOCGAOLN, List<SerializableGuid>>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x663EA40", Offset = "0x663D040", VA = "0x18663EA40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x663EA00", Offset = "0x663D000", VA = "0x18663EA00")]
		public OFPNKJIAGBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x663E9E0", Offset = "0x663CFE0", VA = "0x18663E9E0", Slot = "14")]
		public override List<SerializableGuid> GetValue(ref DPJGDMIOKNF.LPLFOCGAOLN IBEPDAFMEAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x663E9F0", Offset = "0x663CFF0", VA = "0x18663E9F0", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF.LPLFOCGAOLN IBEPDAFMEAD, List<SerializableGuid> MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x663CF30", Offset = "0x663B530", VA = "0x18663CF30")]
	public JLKGHEHAJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
internal class EINDGOFNHDA : ContainerPropertyBag<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	private class AAMPFPMBKOH : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x66374D0", Offset = "0x6635AD0", VA = "0x1866374D0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6637490", Offset = "0x6635A90", VA = "0x186637490")]
		public AAMPFPMBKOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6637470", Offset = "0x6635A70", VA = "0x186637470", Slot = "14")]
		public override float GetValue(ref Vector3 IBEPDAFMEAD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6637480", Offset = "0x6635A80", VA = "0x186637480", Slot = "15")]
		public override void SetValue(ref Vector3 IBEPDAFMEAD, float MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000103")]
	private class DHBKCGGKEPD : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x66382E0", Offset = "0x66368E0", VA = "0x1866382E0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x66382A0", Offset = "0x66368A0", VA = "0x1866382A0")]
		public DHBKCGGKEPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6638280", Offset = "0x6636880", VA = "0x186638280", Slot = "14")]
		public override float GetValue(ref Vector3 IBEPDAFMEAD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6638290", Offset = "0x6636890", VA = "0x186638290", Slot = "15")]
		public override void SetValue(ref Vector3 IBEPDAFMEAD, float MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000104")]
	private class IOPJMBOCNPK : Property<Vector3, float>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x663CA90", Offset = "0x663B090", VA = "0x18663CA90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x663CA50", Offset = "0x663B050", VA = "0x18663CA50")]
		public IOPJMBOCNPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xFEF330", Offset = "0xFED930", VA = "0x180FEF330", Slot = "14")]
		public override float GetValue(ref Vector3 IBEPDAFMEAD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x663CA40", Offset = "0x663B040", VA = "0x18663CA40", Slot = "15")]
		public override void SetValue(ref Vector3 IBEPDAFMEAD, float MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x66384E0", Offset = "0x6636AE0", VA = "0x1866384E0")]
	public EINDGOFNHDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
internal class JHLJAPIFPLB : ContainerPropertyBag<DPJGDMIOKNF.JPDMLMECAMH>
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	private class GOOJDBCKDEO : Property<DPJGDMIOKNF.JPDMLMECAMH, DPJGDMIOKNF.LPLFOCGAOLN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x663C290", Offset = "0x663A890", VA = "0x18663C290", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x663C250", Offset = "0x663A850", VA = "0x18663C250")]
		public GOOJDBCKDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6424470", Offset = "0x6422A70", VA = "0x186424470", Slot = "14")]
		public override DPJGDMIOKNF.LPLFOCGAOLN GetValue(ref DPJGDMIOKNF.JPDMLMECAMH IBEPDAFMEAD)
		{
			return default(DPJGDMIOKNF.LPLFOCGAOLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x663C210", Offset = "0x663A810", VA = "0x18663C210", Slot = "15")]
		public override void SetValue(ref DPJGDMIOKNF.JPDMLMECAMH IBEPDAFMEAD, DPJGDMIOKNF.LPLFOCGAOLN MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x663CCD0", Offset = "0x663B2D0", VA = "0x18663CCD0")]
	public JHLJAPIFPLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
internal class BEHGFOMDBIF : ContainerPropertyBag<RRObjectPrefabV2Data>
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	private class PEMFCDBHDAE : Property<RRObjectPrefabV2Data, BLIAAMDKPNO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override string OMBLKOFJABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x663F0A0", Offset = "0x663D6A0", VA = "0x18663F0A0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool MIKIMACELCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x663F060", Offset = "0x663D660", VA = "0x18663F060")]
		public PEMFCDBHDAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xBF9BB0", Offset = "0xBF81B0", VA = "0x180BF9BB0", Slot = "14")]
		public override BLIAAMDKPNO GetValue(ref RRObjectPrefabV2Data IBEPDAFMEAD)
		{
			return default(BLIAAMDKPNO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E690", Offset = "0x3D4CC90", VA = "0x183D4E690", Slot = "15")]
		public override void SetValue(ref RRObjectPrefabV2Data IBEPDAFMEAD, BLIAAMDKPNO MOLEJFDINLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6637E70", Offset = "0x6636470", VA = "0x186637E70")]
	public BEHGFOMDBIF()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x663F360", Offset = "0x663D960", VA = "0x18663F360")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200010A")]
public class JCIBJNJLFPG
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JCIBJNJLFPG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public class AuthoredParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public class AuthoredPreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	public class AuthoredChildrenData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	public class ParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	public class PreviousParentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	public class ChildrenData
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
