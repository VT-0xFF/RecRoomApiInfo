using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6000", Offset = "0x5CC4600", VA = "0x185CC6000")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xE65B40", Offset = "0xE64140", VA = "0x180E65B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FEAABBDDLMM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3DC0", Offset = "0x5CC23C0", VA = "0x185CC3DC0")]
	public static bool GJBEIFBPCIM(GGCJNIMFEND MGPIFHHJNGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3A40", Offset = "0x5CC2040", VA = "0x185CC3A40")]
	private static bool GJBEIFBPCIM(IPKEJDBNDEC EOJBPKALALP, ref GGCJNIMFEND MGPIFHHJNGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MJDPGJOLLHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<DACGKLHBLIE> PIFCKJGGEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<NNPINKKKPKP> LPIMONCHGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public DOBEMAPNGKH FCDEFLMGLDL;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OOFNKEDJFKF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(PBGCDCPMMIL JIHCLPECHIB, out Dictionary<int, int> OENOPKGIBOG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(KECCLNDCEEL MKIJCLJEPJN, OINPFEEGPCE HGNOALLINCG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JMPNHLMCPMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DEDOFPENDPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> FKKLFCNECHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> CGNEAHKIKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x709E40", Offset = "0x708440", VA = "0x180709E40")]
	public DEDOFPENDPA(Dictionary<Guid, Guid> FKKLFCNECHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC39A0", Offset = "0x5CC1FA0", VA = "0x185CC39A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class PLGGLBPIKAH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class EIIEJLEGLFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public OECFCBNJLAA destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public EIIEJLEGLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5CC39F0", Offset = "0x5CC1FF0", VA = "0x185CC39F0")]
		internal bool <InitializeCircuitsV2Remapping>b__0(MGKJIBKNGDG n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GPEJJALPFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GPEJJALPFOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5430", Offset = "0x5CC3A30", VA = "0x185CC5430")]
		internal void <InitializeCircuitsV2Remapping>b__1(MGKJIBKNGDG n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly Dictionary<Guid, IPKEJDBNDEC> EFDJMCJAHLA;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly Dictionary<Guid, Guid> HCKEPEIHBJI;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HashSet<NNPINKKKPKP> OEMADBKBJMG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<OECFCBNJLAA> ALICAKALHDB;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<DDBIHBBFPMN> OBNHIGHDPGG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8480", Offset = "0x5CC6A80", VA = "0x185CC8480")]
	public static LHHHAADIFPP ICCPJNFDPNM(MJDPGJOLLHP KMBALCOCAPJ, out HOHIDEJJGEL PHMOJEPEKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9220", Offset = "0x5CC7820", VA = "0x185CC9220")]
	private static void KHIGJLNPLCL(LHHHAADIFPP MMCKGEKFIBI, out HOHIDEJJGEL PHMOJEPEKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA040", Offset = "0x5CC8640", VA = "0x185CCA040")]
	private static void OAMKKJONNMH(DACGKLHBLIE MCONGCCCHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7C90", Offset = "0x5CC6290", VA = "0x185CC7C90")]
	private static void FDFCFKIIPOA(LHHHAADIFPP MMCKGEKFIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7070", Offset = "0x5CC5670", VA = "0x185CC7070")]
	private static void EGEBKMKNKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8170", Offset = "0x5CC6770", VA = "0x185CC8170")]
	private static void HOJAMMDDOLB(ref MJDPGJOLLHP KOIHKGCGPGP, DACGKLHBLIE MCONGCCCHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6090", Offset = "0x5CC4690", VA = "0x185CC6090")]
	public static bool AHPLHHGMBOF(LHHHAADIFPP MMCKGEKFIBI, CPPOODBBIEC CCBAKEAMIGL, out DEDOFPENDPA? PINHEIAKHCP, out string? OOMNIJBIFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7F80", Offset = "0x5CC6580", VA = "0x185CC7F80")]
	private static void GEPFANKPHJM(LHHHAADIFPP MMCKGEKFIBI, ref CPPOODBBIEC CCBAKEAMIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6F50", Offset = "0x5CC5550", VA = "0x185CC6F50")]
	private static void DHFIFPLJCDO(LHHHAADIFPP MMCKGEKFIBI, ref CPPOODBBIEC CCBAKEAMIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8960", Offset = "0x5CC6F60", VA = "0x185CC8960")]
	private static bool JIPLGFBGNPE(LHHHAADIFPP MMCKGEKFIBI, KECCLNDCEEL MKIJCLJEPJN, ref CPPOODBBIEC CCBAKEAMIGL, out string OOMNIJBIFDC, out Dictionary<int, int> OENOPKGIBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9DC0", Offset = "0x5CC83C0", VA = "0x185CC9DC0")]
	private static Dictionary<Guid, IPKEJDBNDEC> NJAPPIKCKFE(LHHHAADIFPP MMCKGEKFIBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9D40", Offset = "0x5CC8340", VA = "0x185CC9D40")]
	private static void MKAMEGMLKLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9350", Offset = "0x5CC7950", VA = "0x185CC9350")]
	private static bool LEECFCKDEBB(LHHHAADIFPP MMCKGEKFIBI, ref CPPOODBBIEC CCBAKEAMIGL, out string? OOMNIJBIFDC, out EPJFCKOCMKD? PDCEPJDAOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6FE0", Offset = "0x5CC55E0", VA = "0x185CC6FE0")]
	private static void EBLDMIKGBON(bool PJNDPPOKLFJ, DACGKLHBLIE AEABGDOMKJP, Dictionary<Guid, Guid> BBFEIKIAHFK, EPJFCKOCMKD DCMGLLFIOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA1D0", Offset = "0x5CC87D0", VA = "0x185CCA1D0")]
	private static void OPEELJAOLKB(bool PJNDPPOKLFJ, DACGKLHBLIE AEABGDOMKJP, EPJFCKOCMKD PDCEPJDAOGI, Guid LBNOEGJEDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8F80", Offset = "0x5CC7580", VA = "0x185CC8F80")]
	private static void JOOCFEDNLKB(DACGKLHBLIE AEABGDOMKJP, Guid FNILFCGHGND, BAODOBOCCJB? NMAGIJJIFEH, Dictionary<Guid, IPKEJDBNDEC> PMINACKHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8080", Offset = "0x5CC6680", VA = "0x185CC8080")]
	private static void HKBJEMKGBJD(DACGKLHBLIE AEABGDOMKJP, Dictionary<Guid, Guid> BBFEIKIAHFK, Dictionary<int, int> FIHLPDFJJLE, KECCLNDCEEL JOEKNLHMDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6910", Offset = "0x5CC4F10", VA = "0x185CC6910")]
	public static void BFHBPIICDAL(RepeatedField<DACGKLHBLIE> JEJKAFADIKJ, FAIAEMMAMKM HDCFNJINFNJ, IEnumerable<ByteString> FMJDAFAOOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7150", Offset = "0x5CC5750", VA = "0x185CC7150")]
	private static void EKMBOEONCNO(RepeatedField<DACGKLHBLIE> JEJKAFADIKJ, GCJOMCHOLCP GEHKDLFJEGI, JMPNHLMCPMJ OIECBHABCNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CPPOODBBIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool PJNDPPOKLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool JPLAMJOEGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public BAODOBOCCJB? NMAGIJJIFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public BAODOBOCCJB? BMCLLHLKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KGBIEOPGBLP LCDKHBGLHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public JMPNHLMCPMJ OIECBHABCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public OOFNKEDJFKF GDMFBNFINNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Guid LBNOEGJEDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public DOBEMAPNGKH FCDEFLMGLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public List<DACGKLHBLIE> KCNOFJKANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Dictionary<string, object> JGKPLIKEFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public OOBHJMNKLGL OLFNBJEKCCL;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct BAODOBOCCJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 EINGNKDKDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion JGCPJBFFFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float IIOOEIFOODC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 OFMMOAKMMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3000", Offset = "0x5CC1600", VA = "0x185CC3000")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static BAODOBOCCJB CLABDLEKAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2E00", Offset = "0x5CC1400", VA = "0x185CC2E00")]
		get
		{
			return default(BAODOBOCCJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FCNJEFOKJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3250", Offset = "0x5CC1850", VA = "0x185CC3250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x227AA20", Offset = "0x2279020", VA = "0x18227AA20")]
	public BAODOBOCCJB(Vector3 EINGNKDKDHC, Quaternion JGCPJBFFFAC, float IIOOEIFOODC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3480", Offset = "0x5CC1A80", VA = "0x185CC3480")]
	public BAODOBOCCJB(HIHIBEMHLMN EMBLGEALPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3420", Offset = "0x5CC1A20", VA = "0x185CC3420")]
	private BAODOBOCCJB(NAFEIACPJKK FEBNHMNHLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CC33F0", Offset = "0x5CC19F0", VA = "0x185CC33F0")]
	public static BAODOBOCCJB OEKMACNCPIF(NNPINKKKPKP CINCMEGDDNK)
	{
		return default(BAODOBOCCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3100", Offset = "0x5CC1700", VA = "0x185CC3100")]
	public static BAODOBOCCJB HFNODMLLHDI(BAODOBOCCJB LFAIGCEGCPL, BAODOBOCCJB OHEMGHNHJNB)
	{
		return default(BAODOBOCCJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2CB0", Offset = "0x5CC12B0", VA = "0x185CC2CB0")]
	public static BAODOBOCCJB DGKBAOBECFH((Vector3, Quaternion, float) JIHCLPECHIB)
	{
		return default(BAODOBOCCJB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2D00", Offset = "0x5CC1300", VA = "0x185CC2D00")]
	public static BAODOBOCCJB DGKBAOBECFH(Matrix4x4 KHMHDJDEHCN)
	{
		return default(BAODOBOCCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3260", Offset = "0x5CC1860", VA = "0x185CC3260")]
	public BAODOBOCCJB LOLBLKECJMK(Matrix4x4 HJLACGOIJCA)
	{
		return default(BAODOBOCCJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2E30", Offset = "0x5CC1430", VA = "0x185CC2E30")]
	[CompilerGenerated]
	internal static BAODOBOCCJB GKFCCINHPIK(NNPINKKKPKP ELOCLFMIMAL)
	{
		return default(BAODOBOCCJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class GONABMHMLHM : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4BA0", Offset = "0x5CC31A0", VA = "0x185CC4BA0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4CB0", Offset = "0x5CC32B0", VA = "0x185CC4CB0")]
	private void JCILPAABILC(Dictionary<Guid, Guid> GFOLEFFBJGC, LCLHGCLBOKF FBPBLOADEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4C50", Offset = "0x5CC3250", VA = "0x185CC4C50")]
	private void JCILPAABILC(Dictionary<Guid, Guid> GFOLEFFBJGC, FIAKLCOIGGI CAMCLBDCGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CC51E0", Offset = "0x5CC37E0", VA = "0x185CC51E0")]
	private void JCILPAABILC(Dictionary<Guid, Guid> GFOLEFFBJGC, PPCNFFLNPKD HFACFEGGHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public GONABMHMLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class BMOMPILCFDL : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3790", Offset = "0x5CC1D90", VA = "0x185CC3790", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BMOMPILCFDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LOFBALPMHEG : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5E90", Offset = "0x5CC4490", VA = "0x185CC5E90", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LOFBALPMHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class DDNECEMMAJG : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3850", Offset = "0x5CC1E50", VA = "0x185CC3850", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public DDNECEMMAJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class KIFNOCHKDLB : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC59E0", Offset = "0x5CC3FE0", VA = "0x185CC59E0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KIFNOCHKDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class LMDIEKGDOGK : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5D10", Offset = "0x5CC4310", VA = "0x185CC5D10", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LMDIEKGDOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class IHBHMFFKGII : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5450", Offset = "0x5CC3A50", VA = "0x185CC5450", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public IHBHMFFKGII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class LIKOPCFAFIE : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5BF0", Offset = "0x5CC41F0", VA = "0x185CC5BF0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public LIKOPCFAFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class JMMIKNEEIPL : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5640", Offset = "0x5CC3C40", VA = "0x185CC5640", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public JMMIKNEEIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class KGABJMANEGO : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5810", Offset = "0x5CC3E10", VA = "0x185CC5810", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public KGABJMANEGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class BCGNHMABCHI : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CC35A0", Offset = "0x5CC1BA0", VA = "0x185CC35A0", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public BCGNHMABCHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class AALJNDNFLPB : PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random LOLMMGJELMA;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2B70", Offset = "0x5CC1170", VA = "0x185CC2B70", Slot = "4")]
	public void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public AALJNDNFLPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GGCJNIMFEND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public KECCLNDCEEL AJGHIJIKOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public BMHGMDONJJK ABIEHJLLPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> FIHLPDFJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> AOGGCOBJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public OOBHJMNKLGL OLFNBJEKCCL;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PJDLPOOEAGH
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADFLLOFBKAG(BKAAKHLCGBH OILMHDFMDMN);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface OOBHJMNKLGL
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int POCAAILBFLC, out Guid MAKCINDBLOL);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GIOCPGJEFFL
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly PJDLPOOEAGH[] LHCNCJNCFBL;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4350", Offset = "0x5CC2950", VA = "0x185CC4350")]
	public static void NBCANOHHLCP(DACGKLHBLIE JIHCLPECHIB, Dictionary<Guid, Guid> MDMPNGGCMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4160", Offset = "0x5CC2760", VA = "0x185CC4160")]
	public static void JMENOLPBNBA(DACGKLHBLIE? JIHCLPECHIB, EPJFCKOCMKD DCMGLLFIOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3E00", Offset = "0x5CC2400", VA = "0x185CC3E00")]
	public static void GJBEIFBPCIM(BKAAKHLCGBH OILMHDFMDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BKAAKHLCGBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public KECCLNDCEEL IOHNHPEIKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public DACGKLHBLIE AEABGDOMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> FIHLPDFJJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> AOGGCOBJNLD;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CC36C0", Offset = "0x5CC1CC0", VA = "0x185CC36C0")]
	public Guid BNCKKFONACA(Guid GDIIAHJOKME)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class PNLDGLNPKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> KPPGNLAIKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> BKEPBPBBOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> OKAKKCAJMEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyCollection<string> OIJBHOAJDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<long, int> JNNPNKKENCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA990", Offset = "0x5CC8F90", VA = "0x185CCA990")]
	public static PNLDGLNPKLK GHLJDBKFIGJ(CIFBNNGALCD MJGIEGEMGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA920", Offset = "0x5CC8F20", VA = "0x185CCA920")]
	public static PNLDGLNPKLK FIPMALLMLND(LHHHAADIFPP MOENFIEOJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA7D0", Offset = "0x5CC8DD0", VA = "0x185CCA7D0")]
	public static PNLDGLNPKLK BOFLCAFGHJI(IEnumerable<string> KPPGNLAIKLD, IDictionary<long, int> BMLLIGLFEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBA20", Offset = "0x5CCA020", VA = "0x185CCBA20")]
	private PNLDGLNPKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB900", Offset = "0x5CC9F00", VA = "0x185CCB900")]
	private PNLDGLNPKLK(IEnumerable<string> KPPGNLAIKLD, IDictionary<long, int> BMLLIGLFEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB740", Offset = "0x5CC9D40", VA = "0x185CCB740")]
	private void OCJCJIPKIJP(CIFBNNGALCD MJGIEGEMGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB580", Offset = "0x5CC9B80", VA = "0x185CCB580")]
	private void OCJCJIPKIJP(LHHHAADIFPP MOENFIEOJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAC40", Offset = "0x5CC9240", VA = "0x185CCAC40")]
	private void OCJCJIPKIJP(FAIAEMMAMKM COMPFMNMPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB410", Offset = "0x5CC9A10", VA = "0x185CCB410")]
	private void OCJCJIPKIJP(MGKJIBKNGDG ELOCLFMIMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB060", Offset = "0x5CC9660", VA = "0x185CCB060")]
	private void OCJCJIPKIJP(DACGKLHBLIE AEABGDOMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5CCABD0", Offset = "0x5CC91D0", VA = "0x185CCABD0")]
	private void JGFDHCOHMCI(string BAMPFOAHBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAA00", Offset = "0x5CC9000", VA = "0x185CCAA00")]
	private void HFGDHHFCHAL(MAJNHPOMHMG PGNJOMFAMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAAE0", Offset = "0x5CC90E0", VA = "0x185CCAAE0")]
	private void HFGDHHFCHAL(KOCKOCNLNMO PGNJOMFAMCP)
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
