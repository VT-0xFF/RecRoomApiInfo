using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F3020", Offset = "0x7F1C20", VA = "0x1807F3020")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FCF990", Offset = "0x6FCE590", VA = "0x186FCF990")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83E010", Offset = "0x83CC10", VA = "0x18083E010")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xBF6D90", Offset = "0xBF5990", VA = "0x180BF6D90")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EKABEMINOAP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed(in EDLBELDIMLN KFIFOACCOBG);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void MGNELBEPOLC(in HEEEIFICCNO PDEDDIGJHCG);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class MJEOEEEGEHH
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct MJBHACCNKIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IMNIHLGBDNI NIBEKCGPHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly OHEAGHBKIGJ AABNIDHKHID;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
	public MJBHACCNKIH(IMNIHLGBDNI ACFCCJGDFGH, OHEAGHBKIGJ HNACOCBLEJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JCPABPHJMMA
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EFIODMELMJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Action<EFIODMELMJL> NIDEMAANECO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NFGAHKPBDCA();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PNLLDCOACGL(GFLMBMOIAPM MAOPJNOIHBH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IJMLDAEIIPH(GFLMBMOIAPM MAOPJNOIHBH);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A86F0", Offset = "0x7A7AF0")]
		public readonly OOHDKCNKKJB<GBHOLOEGOCK> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A78B0", Offset = "0x7A6CB0")]
		public readonly FLKPPPHNEOM<MFKIKMMFFON> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7910", Offset = "0x7A6D10")]
		public readonly FLKPPPHNEOM<KMOMAJMFANO> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7970", Offset = "0x7A6D70")]
		public readonly OOHDKCNKKJB<GBHOLOEGOCK> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A79D0", Offset = "0x7A6DD0")]
		public readonly FLKPPPHNEOM<MFKIKMMFFON> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7A30", Offset = "0x7A6E30")]
		public readonly FLKPPPHNEOM<IFAPNPKCHPO> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FB3F80", Offset = "0x5FB2B80", VA = "0x185FB3F80")]
		public StaticEdge([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7A90", Offset = "0x7A6E90")] in OOHDKCNKKJB<GBHOLOEGOCK> PLGCILCKDGE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7B00", Offset = "0x7A6F00")] FLKPPPHNEOM<MFKIKMMFFON> AIALANGOBIG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7B60", Offset = "0x7A6F60")] FLKPPPHNEOM<KMOMAJMFANO> EKNFMEMLOHN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7BC0", Offset = "0x7A6FC0")] in OOHDKCNKKJB<GBHOLOEGOCK> ALPCGACKNDF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7C30", Offset = "0x7A7030")] FLKPPPHNEOM<MFKIKMMFFON> GHDBEOOMOND, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7C90", Offset = "0x7A7090")] FLKPPPHNEOM<IFAPNPKCHPO> FKMPMLELAAB)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFBC0", Offset = "0x6FCE7C0", VA = "0x186FCFBC0")]
		public static bool FMMDKFLNNFA(in StaticEdge FDMHBFLJJHC, in StaticEdge DNGDHCADJJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFA20", Offset = "0x6FCE620", VA = "0x186FCFA20", Slot = "4")]
		public bool Equals(StaticEdge MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFB10", Offset = "0x6FCE710", VA = "0x186FCFB10", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFCB0", Offset = "0x6FCE8B0", VA = "0x186FCFCB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FCFDA0", Offset = "0x6FCE9A0", VA = "0x186FCFDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LLJNFLLHJEB
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF710", Offset = "0x6FCE310", VA = "0x186FCF710")]
	public static StaticEdge NLJPEOGMFGO(this BKDHHICILNN GPOCLJBKMHA)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface COJBDDLGCOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLKMMLDOKFE : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate void JPONMIIJFMJ(in EDLBELDIMLN KFIFOACCOBG);
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JKJGEMKNGEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct LFHFNCEJCMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly MLJEGCBGPGL DKMPFGNABJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly IReadOnlyDictionary<Guid, Guid> KFPDLJKJIMB;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28AAB70", Offset = "0x28A9770", VA = "0x1828AAB70")]
		public LFHFNCEJCMD(MLJEGCBGPGL LMMHAIGBGJO, IReadOnlyDictionary<Guid, Guid> IALEGAFODIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JEJMDLLCLNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly IReadOnlyCollection<ByteString> DAGPFFAIHOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly IReadOnlyCollection<ByteString> NJDJEFALGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly IReadOnlyCollection<ByteString> MEPDGDMCNPB;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x91C510", Offset = "0x91B110", VA = "0x18091C510")]
		public JEJMDLLCLNK(IReadOnlyCollection<ByteString> DLKFFAKNCOE, IReadOnlyCollection<ByteString> PDKEOFBIPGD, IReadOnlyCollection<ByteString> KDHOEEDIDAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public readonly struct GAFJDGGIGFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly MLJEGCBGPGL DKMPFGNABJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly IEnumerable<HGNMPOIAAKI> GMPHCGIJEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly bool CPPDKBLFMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7E90", Offset = "0x7A7290")]
		public readonly OOHDKCNKKJB<DJPDHPKBBFK> FHDFKKHGCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int? IJDFIBOAPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly CODGPOKJEGN? NCHBPAPBDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly CODGPOKJEGN? FENEJHPPADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly JEJMDLLCLNK? LJMPGLFKBHD;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FCF5D0", Offset = "0x6FCE1D0", VA = "0x186FCF5D0")]
		public GAFJDGGIGFM(in MLJEGCBGPGL LMMHAIGBGJO, IEnumerable<HGNMPOIAAKI> LDOJACGGACG, bool EBIGPHIOJBE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7EF0", Offset = "0x7A72F0")] in OOHDKCNKKJB<DJPDHPKBBFK> PHNBFNJHAAA, int? HDPIIINCCLN, in CODGPOKJEGN? BODDDJEPBCM, in CODGPOKJEGN? KEPDHFAHOOI, in JEJMDLLCLNK? HKBICEKALOH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKAJPLLDHFL? EMLKFEIIMAL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7CF0", Offset = "0x7A70F0")] in OOHDKCNKKJB<DJPDHPKBBFK?> DJCGAIJIDMG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DMMBFDBCOPO? LBHCFJHELLH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7D60", Offset = "0x7A7160")] in OOHDKCNKKJB<GBHOLOEGOCK?> ENELKLKDEHJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PKJAENHCLMN<LFHFNCEJCMD, NKLELKIHOJN> PBCFHNOCALL(in GAFJDGGIGFM PFFFGKKOEPM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPMEAPKGEMA MCPKAJBIOEI(IEnumerable<HGNMPOIAAKI> LDOJACGGACG);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPMEAPKGEMA JLONPEIILBB();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MLJEGCBGPGL PMJEFEFNHPL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7DD0", Offset = "0x7A71D0")] IEnumerable<OOHDKCNKKJB<GBHOLOEGOCK>> OPEPIJBOEOG, IEnumerable<HGNMPOIAAKI> LDOJACGGACG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KLHIJOEMLDH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool DHGALMBFHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PBCIKJFNLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TypeKey JKHFJODHGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LELJHDPFGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JKOKPKIEOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class CINOEDHPPIC
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MKLFLFOOJGN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string JBBBOLIAGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int MIDNIKLIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool AHPGPIFIPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class KMOMAJMFANO : NECCJDOBLAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[KPFEFEMPEAJ("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class MFKIKMMFFON
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GJPMJPJNPOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly CIOHJELGAHC APAFFFJKKII;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	public GJPMJPJNPOO(CIOHJELGAHC LAMKLOBMDBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class IFAPNPKCHPO : NECCJDOBLAP
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class AKGLNDCPNFB
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface MOIPMGHGLDD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JKJGEMKNGEJ? EABDDJEADPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool AHCEGHKGNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool BJALAJPBALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JKJGEMKNGEJ> PCGKBMHJHJL();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PKJAENHCLMN<MJBHACCNKIH, NKLELKIHOJN> EPALGFBLAPM(in MJBHACCNKIH LMMHAIGBGJO, IEnumerable<HGNMPOIAAKI> LDOJACGGACG, int EMIGLHINIKN);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class DJPDHPKBBFK
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NKAJPLLDHFL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BILDBJHNPPE? DNFDNICACLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface DMMBFDBCOPO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	object CKAFNFFOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CEPBNJGDDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int OHBNBDLMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	ELAIDPHHMOG MPKOMPNKHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NodeVisualizationKey JKHFJODHGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8050", Offset = "0x7A7450")]
	FLKPPPHNEOM<MJEOEEEGEHH> BBEFCCIPBGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OADKJGNLOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NNDOMNKDFKF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MLEGGMABAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool AJDHJFENABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HHOLLEJIGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MBJPPEJMCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int AMOOBDNHCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IBBAOEHGOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string ADOJPJFCHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool HMAGBKIHIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MNMBEEHLPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FOFPDJEMNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool POMFGMPDBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CEMLOPEBMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	NENFILKLNLH FLNDEGFPBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HEEEIFICCNO OCOFEOLGBBG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[AEIDOAEHPPH(true, "FloatingText")]
	bool OENELDBNNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	MKLFLFOOJGN? NKBDMOIPLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool NOHBCJLLDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A80E0", Offset = "0x7A74E0")]
	OOHDKCNKKJB<DJPDHPKBBFK> OBJFEABEMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	[KPFEFEMPEAJ("This isn't great UX and we should consider removing it.")]
	bool OCPLNNIHMED
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8180", Offset = "0x7A7580")]
	OOHDKCNKKJB<DJPDHPKBBFK>? GCHMEDNKCFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JOFMJBBGELH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A81F0", Offset = "0x7A75F0")]
	OOHDKCNKKJB<GBHOLOEGOCK> BJPHJBMNEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string EKPDCEFJBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8260", Offset = "0x7A7660")]
	[KPFEFEMPEAJ("This should eventually be an `IdReadOnlySpan`.")]
	FLKPPPHNEOM<MFKIKMMFFON>? HBFKNCPBIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IIOJCADNPFF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NOAOIOFDIAM HEBNBHNHAKM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event MGNELBEPOLC MNEMJFHPOGJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action FFEPICIPMIG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<int> PCLOJFBOKOC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action EEAHEIGPFHP;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GINJEKDFHNI(int MHIDDOOKKLA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CEGBFEOBNEL(in NENFILKLNLH ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LGAGLBLDGLF(in HEEEIFICCNO ECNGHFJBIJL);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void POPIHLAMFGJ();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MPNMKADFDMA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ALGBBDNEIDE();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NEGBHCEKFEM();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void FFDHOFOOFIE(string BPOKAAOBIOI);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FKOJLPDCGAA(int NHHNPPKPBIA);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "43")]
	PKJAENHCLMN<DPIJIKFEAOC, HECNFFAEBGF> DJHCJKHDGEN(string EHNPFOADAIA);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool GKPOPACCABJ(out Guid NJFBFFHEIKP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool IDNLIEGNIFB(in Guid DJCGAIJIDMG);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void NHGHFKAFNCD();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void DBGNPGEPPAN(bool CFDLPCFDLDE);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "58")]
	CODGPOKJEGN AOGHJEBIGLF();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "59")]
	bool CGLNNMGBGIO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A7FF0", Offset = "0x7A73F0")] FLKPPPHNEOM<MFKIKMMFFON> DELGEHDFFCB);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task<PKJAENHCLMN<DPIJIKFEAOC, HECNFFAEBGF>> IJCHCONOBDC(string EHNPFOADAIA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class NECCJDOBLAP
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct DPMEAPKGEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly MJBHACCNKIH DGLPPFDBOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly GJPMJPJNPOO FHBEENEPMDJ;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6FCF590", Offset = "0x6FCE190", VA = "0x186FCF590")]
	public DPMEAPKGEMA(in MJBHACCNKIH CMMCIHFHBLL, GJPMJPJNPOO IKHHHDILDNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class IJPNAPMLKPH
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Color
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class DJCGNFAHCJO
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct EDLBELDIMLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool KNEEOCEEKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly KIGGLGDIPGL EOPCCIPKLAD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2904CB0", Offset = "0x29038B0", VA = "0x182904CB0")]
	public EDLBELDIMLN(bool EMPMMCDNEFM, KIGGLGDIPGL KFDHHKPJICE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GBHOLOEGOCK
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public delegate void NOAOIOFDIAM(in NENFILKLNLH ELPFDBFBPJP);
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct MLJEGCBGPGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly EEONMADIGIK EODKNKCBLBG;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB1CC20", Offset = "0xB1B820", VA = "0x180B1CC20")]
	public MLJEGCBGPGL(EEONMADIGIK OJPPIJGPJCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface HECNFFAEBGF : NKLELKIHOJN
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum KIGGLGDIPGL
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GKFPINGACLD : BELEEFKDBKB
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	MOIPMGHGLDD OLGIPHNBIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct BILDBJHNPPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8320", Offset = "0x7A7720")]
	public readonly OOHDKCNKKJB<GBHOLOEGOCK> BEMIKDEIMHK;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x81BCD0", Offset = "0x81A8D0", VA = "0x18081BCD0")]
	public BILDBJHNPPE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8380", Offset = "0x7A7780")] in OOHDKCNKKJB<GBHOLOEGOCK> DBBFALJLGKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface NEJHAPFOGFM : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A83F0", Offset = "0x7A77F0")]
	Func<List<KeyValuePair<string, MKEHFBIKBJP>>> BOCHNHFBEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	Func<bool>? CCECIAANGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8450", Offset = "0x7A7850")]
	Func<int, string> HGCOMMMPMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	Action? AJCHALLLDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Action? JKEDFJJCNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool FFHNIAIMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool AKDLIKGPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KAIKGELPCNJ : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Func<Dictionary<string, MKEHFBIKBJP>> BOCHNHFBEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Func<bool>? CCECIAANGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A84B0", Offset = "0x7A78B0")]
	Func<int, string> HGCOMMMPMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FFHNIAIMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool AKDLIKGPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface BLJIKNHJAHG : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	GFLMBMOIAPM LPKFLLFNCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HDAIKPEDMEI : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	Func<float> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Action<float> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string FOKLCAMMKMG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool OLGCKHOLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float FDMJOHNAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float AGIOHNAEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface DEFPINCHODA : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int? BKBFEACHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool MKOJIIHNKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum GLCPLKCMIGN
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface EPHJIACDJHG : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int? BKBFEACHAGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool MKOJIIHNKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DPBBNKFIFOK : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Func<float> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Action<float> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float FDMJOHNAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float AGIOHNAEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Func<bool>? CHJPNJPAHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int JFIFGDMKEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string FOKLCAMMKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Func<float, float>? FOBKBMOMBHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Func<float, float>? PPDLMLNPGDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BKDEFKHMNHG : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Func<bool> BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Func<IReadOnlyList<object>> PAILAJFBAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Func<object, string> FBCEHICJIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Func<object> PAEGAEHLKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Action<object> EPEGIKANBAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface DLMHBEFHDGL : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	int FKKADJMHIFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8510", Offset = "0x7A7910")]
	Func<string, bool> FABCLANFMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	string? OJCBLPPINGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool MKOJIIHNKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	GLCPLKCMIGN JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BIAAGEBPCKJ : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Func<bool> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Action<bool> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	int FEBAPKLGMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IANDKLAOHCC : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Dictionary<string, MKEHFBIKBJP> FABCNDBLNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Action? AJCHALLLDCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Action? JKEDFJJCNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8570", Offset = "0x7A7970")]
	Func<int, string> HGCOMMMPMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool FFHNIAIMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool AKDLIKGPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A85D0", Offset = "0x7A79D0")]
	Action<EFIODMELMJL> NLIANCOKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ECCABHJGCCC : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Action HDJEAGGKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	GLCPLKCMIGN JFINBJKLHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	string MOPBINMAJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	string FPCNFPFHBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DCPBHBJPKBO : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Action HDJEAGGKGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface BFEEEGIDHBM : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	string LEJNMGCPJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GFLMBMOIAPM
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface JEBDGFODPDF : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	Func<string> GDKBMCNIAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	Action<string> NMALOAKDGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	int FKKADJMHIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7A8650", Offset = "0x7A7A50")]
	Func<string, bool> FABCLANFMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	string? OJCBLPPINGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string MFPCMOJJDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string CJJHIHCAHAK
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string EFBDGIANNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	bool OLBMBPJLHHI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface KHDKLPGKFLI : GFLMBMOIAPM
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	Func<int> OOHOOINDJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Action<int> OFOLIBOAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	Func<bool>? BAJFOAKIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	Func<bool>? MAPLFIHDDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	bool OJEAODJKICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	string OENPBJPEEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	Func<bool>? CICMFMHMFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool DFNADGNCMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool NJDNMOGIOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
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
