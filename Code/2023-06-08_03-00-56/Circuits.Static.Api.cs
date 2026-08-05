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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FF32F0", Offset = "0x6FF20F0", VA = "0x186FF32F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
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
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JIHFHBAMJOB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed(in FICKICOBFHB JJNHGEIAIJF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void KLMIGLFDLGJ(in BIAMBIALDGD MKOKOOBHKBI);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KPBNBJMHBIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct ILEKNONHIFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AFIKOINPDIO PMLCPJNBKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly GEGIFCHLEDG BLPAAAJCOIG;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
	public ILEKNONHIFA(AFIKOINPDIO BLOKAAGNAHK, GEGIFCHLEDG APHGANAOAPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CHEOCONOIOL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IAOFOAAELIB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Action<IAOFOAAELIB> OMJBIOPDKBJ
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
	void HLJHKMDLHLP();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBOPOFAFDPL(EGAFAFHPOOL LJNMLIMGEPB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJCIENMKBBH(EGAFAFHPOOL LJNMLIMGEPB);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F6B0", Offset = "0x7EAB0")]
		public readonly GDHJGHADAGA<GKHJEKNCAJN> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E810", Offset = "0x7DC10")]
		public readonly HPGNBPBAINF<FBMNGKLONCM> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E870", Offset = "0x7DC70")]
		public readonly HPGNBPBAINF<DNKIMBOCCKK> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E8D0", Offset = "0x7DCD0")]
		public readonly GDHJGHADAGA<GKHJEKNCAJN> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E930", Offset = "0x7DD30")]
		public readonly HPGNBPBAINF<FBMNGKLONCM> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E990", Offset = "0x7DD90")]
		public readonly HPGNBPBAINF<BHJCNNEOFAF> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62A5020", Offset = "0x62A3E20", VA = "0x1862A5020")]
		public StaticEdge([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7E9F0", Offset = "0x7DDF0")] in GDHJGHADAGA<GKHJEKNCAJN> ICDIGILFHBL, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EA60", Offset = "0x7DE60")] HPGNBPBAINF<FBMNGKLONCM> ECFBKAMJBJJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EAC0", Offset = "0x7DEC0")] HPGNBPBAINF<DNKIMBOCCKK> DKCMNAFDEGC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EB20", Offset = "0x7DF20")] in GDHJGHADAGA<GKHJEKNCAJN> FCFKCDNBDLN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EB90", Offset = "0x7DF90")] HPGNBPBAINF<FBMNGKLONCM> FJDMIIPBIDA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EBF0", Offset = "0x7DFF0")] HPGNBPBAINF<BHJCNNEOFAF> DMBBEMGFLOD)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3380", Offset = "0x6FF2180", VA = "0x186FF3380")]
		public static bool DDONPFMGGHF(in StaticEdge BGNJLPDNBMK, in StaticEdge MDKJCMEMIDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3470", Offset = "0x6FF2270", VA = "0x186FF3470", Slot = "4")]
		public bool Equals(StaticEdge FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3560", Offset = "0x6FF2360", VA = "0x186FF3560", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3610", Offset = "0x6FF2410", VA = "0x186FF3610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3700", Offset = "0x6FF2500", VA = "0x186FF3700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AOJMPFGOKEC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2EF0", Offset = "0x6FF1CF0", VA = "0x186FF2EF0")]
	public static StaticEdge KMIKNNFPDOG(this NHLFGKKLEGC FEEMIHFJMDK)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EHBPGEGGOMM
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GGBPICDCPJJ : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate void NPPEJIBJJMH(in FICKICOBFHB JJNHGEIAIJF);
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NMECACFAGPK
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public readonly struct CEEHNONHMFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly KLNEPMCHIOG BOOHFAILKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly IReadOnlyDictionary<Guid, Guid> FIBJDJLFKAL;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x30A1970", Offset = "0x30A0770", VA = "0x1830A1970")]
		public CEEHNONHMFL(KLNEPMCHIOG APFCAGCGIBF, IReadOnlyDictionary<Guid, Guid> DOKBBGJHFJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct NIJKNJAEMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly IReadOnlyCollection<ByteString> LLKNLLGGOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly IReadOnlyCollection<ByteString> PBBEBMNJCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly IReadOnlyCollection<ByteString> FEEJPHOHBCN;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAFC160", Offset = "0xAFAF60", VA = "0x180AFC160")]
		public NIJKNJAEMMK(IReadOnlyCollection<ByteString> AAANPBOIAFB, IReadOnlyCollection<ByteString> GPAFBPBFJPK, IReadOnlyCollection<ByteString> OECNOIEBEMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public readonly struct DLDCJJGDKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly KLNEPMCHIOG BOOHFAILKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly IEnumerable<PDONGDEAPNB> KEBCJLANBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly bool MKLPFKPDOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EDF0", Offset = "0x7E1F0")]
		public readonly GDHJGHADAGA<EMCGHMHGJHP> JDPNNFOBKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly int? CNPGNPHMPGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly OHBFEFEKBBF? OGAOMJKLKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly OHBFEFEKBBF? FMGNHKFOMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly NIJKNJAEMMK? DBEAEJFIEJM;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FF3050", Offset = "0x6FF1E50", VA = "0x186FF3050")]
		public DLDCJJGDKBM(in KLNEPMCHIOG APFCAGCGIBF, IEnumerable<PDONGDEAPNB> JCLAJIFDAGM, bool OMBCCNACKEH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EE50", Offset = "0x7E250")] in GDHJGHADAGA<EMCGHMHGJHP> EFAONJJBMBN, int? JLJFHFPDNAC, in OHBFEFEKBBF? JEJBLEOEHMK, in OHBFEFEKBBF? BPHCAKJHCOO, in NIJKNJAEMMK? CDJGAJMFKDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NMGJJOBFFAC? OJFALOJMHFJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EC50", Offset = "0x7E050")] in GDHJGHADAGA<EMCGHMHGJHP?> MMKFOAANGLN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HIMAMCBNOPK? GEFJDHKMDLA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ECC0", Offset = "0x7E0C0")] in GDHJGHADAGA<GKHJEKNCAJN?> IAHLLEDDMDA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABAABAMKHON<CEEHNONHMFL, JILPNNKAMDC> EMALICDKPNC(in DLDCJJGDKBM DCPGFNKOIOA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKIPDJDJANO FAHALFDOCJL(IEnumerable<PDONGDEAPNB> JCLAJIFDAGM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NKIPDJDJANO OGHIEKKPJKP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KLNEPMCHIOG FBANCFBLMMF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7ED30", Offset = "0x7E130")] IEnumerable<GDHJGHADAGA<GKHJEKNCAJN>> MGLEOCDDOAF, IEnumerable<PDONGDEAPNB> JCLAJIFDAGM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ECMNNGAJCMD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool NPFHKDHBGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DBJOJBCEMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TypeKey JIFALOFFGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MEFAINADHAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JDJKBEBFFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class BAAHPDEGHKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DCOKIPHPMPE
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string PGFELENAMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	int NONOALBCPJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MPCDIPPPMME
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class DNKIMBOCCKK : BEHODMFGCJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[NPLFFICJPOI("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class FBMNGKLONCM
{
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EECPMOPNJBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly MCJJGOEJIBB EDFELDGNNMI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	public EECPMOPNJBD(MCJJGOEJIBB POFFPODNPLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class BHJCNNEOFAF : BEHODMFGCJN
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
public sealed class DJBHNLGFLDJ
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface CKJFLAOKPMA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	NMECACFAGPK? LNABDBHCENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CEJJOMNOAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool CECKHHHNHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<NMECACFAGPK> MOCGMIPGCLN();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ABAABAMKHON<ILEKNONHIFA, JILPNNKAMDC> OCLJIIAPNDL(in ILEKNONHIFA APFCAGCGIBF, IEnumerable<PDONGDEAPNB> JCLAJIFDAGM, int DNCPKPAPCOJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public sealed class EMCGHMHGJHP
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NMGJJOBFFAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KDBAHEAOCIC? FNKEMOBIBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HIMAMCBNOPK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	object NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool FKCEHDPFCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int PMLMMLIFOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PIHOCNIGLMI MHBIPIKBNKD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NodeVisualizationKey JIFALOFFGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EFB0", Offset = "0x7E3B0")]
	HPGNBPBAINF<KPBNBJMHBIP> IGBGIEEJIML
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FJHJDMKEGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool AIOGCHHICEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool NLOLHBLGPPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool ECPMANJAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool JEBFHNEPAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool DMHFGFDMBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int NKHFLCMHEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JPPGLBHCBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string HJGABKHFHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool AOHIAHAKBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HHABIGLAOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DIOJNFOFOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool NGKMNCFBDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IEKCJPBMNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	OKNEJIMICGO KBGIFGGDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BIAMBIALDGD LGFANIGDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	[LKOMFAGALHF(true, "FloatingText")]
	bool KMJNHDOCNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	DCOKIPHPMPE? AEHFLOFGBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BIHONNOLPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F040", Offset = "0x7E440")]
	GDHJGHADAGA<EMCGHMHGJHP> JCDIBPGNDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	[NPLFFICJPOI("This isn't great UX and we should consider removing it.")]
	bool AGNACGKOGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F0E0", Offset = "0x7E4E0")]
	GDHJGHADAGA<EMCGHMHGJHP>? MOFKIGAKIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool NGEJIKDADFC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F150", Offset = "0x7E550")]
	GDHJGHADAGA<GKHJEKNCAJN> LMPHODKODND
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	string KGBBPCBIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F1C0", Offset = "0x7E5C0")]
	[NPLFFICJPOI("This should eventually be an `IdReadOnlySpan`.")]
	HPGNBPBAINF<FBMNGKLONCM>? OHLFDDKKMPB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FGPEPNEMJJB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LFJDHEKIBLK LMJIMENGHBA;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event KLMIGLFDLGJ PPFJMJICGNC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action EFCHMBEAKFH;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<int> LBJHLJCHOGM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action DECHPCLMCEB;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLDEPIDDEAN(int FJGNBIALGKD);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FPCDFCHKMIG(in OKNEJIMICGO KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HKJCCFPDNDG(in BIAMBIALDGD KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CIOJJGEKOAB();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PHNNHMEHLLN();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NLFHCODOKHN();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void OEJACPMILIP();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void AJCLHDIKJJM(string PPPOJKMOIGD);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void LIBBLAOFOHE(int FHOMILACEHB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "43")]
	ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO> HHMBEPMDJPD(string JEKCEOBNHDE);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool GMFAGODBABI(out Guid DFIKILGOIKP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool IMKAFNEPKIF(in Guid MMKFOAANGLN);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void HKOMOLJGOCK();

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void HAFIPEBBCPN(bool MKBLDBAHLAB);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "58")]
	OHBFEFEKBBF PHJJGEEIAMM();

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "59")]
	bool ILKACCCACPG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7EF50", Offset = "0x7E350")] HPGNBPBAINF<FBMNGKLONCM> KEPHBMPDMJA);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task<ABAABAMKHON<MELLEHNAKNA, KCFDFNEEHDO>> CGMJKGDIBFN(string JEKCEOBNHDE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public abstract class BEHODMFGCJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct NKIPDJDJANO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly ILEKNONHIFA CMONGNDGMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly EECPMOPNJBD GIIDJGPCHJD;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3220", Offset = "0x6FF2020", VA = "0x186FF3220")]
	public NKIPDJDJANO(in ILEKNONHIFA ODBMILJBDKN, EECPMOPNJBD EANAFOJCGLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class FGMHANHFOBK
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
public sealed class GGMIBKMAMHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct FICKICOBFHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool DHOLBJDLJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly EGMHKPHPPIG IDIMECMCNEG;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2643B10", Offset = "0x2642910", VA = "0x182643B10")]
	public FICKICOBFHB(bool FIFAFDLNDCA, EGMHKPHPPIG IJNHPGEAHCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public sealed class GKHJEKNCAJN
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public delegate void LFJDHEKIBLK(in OKNEJIMICGO ODAJBDOBDMM);
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct KLNEPMCHIOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly BHFGBKDICMK ELJHIOINDKP;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xD2AC10", Offset = "0xD29A10", VA = "0x180D2AC10")]
	public KLNEPMCHIOG(BHFGBKDICMK OECEOEKOLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface KCFDFNEEHDO : JILPNNKAMDC
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum EGMHKPHPPIG
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BKNIKFKAABB : MMNOCIIDDCG
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CKJFLAOKPMA HFEALCLPCGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct KDBAHEAOCIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F280", Offset = "0x7E680")]
	public readonly GDHJGHADAGA<GKHJEKNCAJN> NGJOFALJFAG;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x861610", Offset = "0x860410", VA = "0x180861610")]
	public KDBAHEAOCIC([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F2E0", Offset = "0x7E6E0")] in GDHJGHADAGA<GKHJEKNCAJN> POFDGOFINHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DDMAGFIABHK : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F350", Offset = "0x7E750")]
	Func<List<KeyValuePair<string, HBGNJCEADBB>>> NAKBLEPJKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	Func<bool>? OBELPCIHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F3B0", Offset = "0x7E7B0")]
	Func<int, string> JMOCFMJEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	Action? EGMMNBEGIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	Action? HHDDLMHOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool IONJNLHJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool CBIHEHMFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GICONELFIJB : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Func<Dictionary<string, HBGNJCEADBB>> NAKBLEPJKEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Func<bool>? OBELPCIHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F410", Offset = "0x7E810")]
	Func<int, string> JMOCFMJEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool IONJNLHJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CBIHEHMFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface GHODCFHNIPL : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	EGAFAFHPOOL FBPILNNPKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface ACDNMACMKBG : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	Func<float> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Action<float> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	string MEJJLCCBBMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool ADOPCBLAMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float AANFCMBABMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float JBCLNBBDFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface KPMKKHLGGCM : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	int? DEDEEKLBCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool NFFGGNOODMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum AANNOOFCGCG
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
public interface DCKKAFCDNIE : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	int? DEDEEKLBCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool NFFGGNOODMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface DDEPJMJECKP : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Func<float> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Action<float> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float AANFCMBABMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float JBCLNBBDFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Func<bool>? FMAOMMDFJJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	int HDLLFNKFNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string MEJJLCCBBMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Func<float, float>? DHPDHFLIECD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Func<float, float>? AALIGCJHGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface MEFDGHEKLKK : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	Func<bool> PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Func<IReadOnlyList<object>> GAAPIAFGMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Func<object, string> HCCKPCFDJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	Func<object> IEBJDILBOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Action<object> OEBBPKEENAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface DAPDKKGMFDE : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	int NPJNEGDGJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F470", Offset = "0x7E870")]
	Func<string, bool> JHGBBIGFBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	string? FBPCPDOEMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool NFFGGNOODMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	AANNOOFCGCG MKAJEKLIICM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MEPDGKEBDKN : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Func<bool> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Action<bool> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	int KJABAPGACCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IGPODIKACDG : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Dictionary<string, HBGNJCEADBB> OICOOAKFDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Action? EGMMNBEGIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Action? HHDDLMHOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F4D0", Offset = "0x7E8D0")]
	Func<int, string> JMOCFMJEDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool IONJNLHJHHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool CBIHEHMFPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F530", Offset = "0x7E930")]
	Action<IAOFOAAELIB> KLAAGDGAGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface JMHCNBKKDKC : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Action CAIJFHGGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	AANNOOFCGCG MKAJEKLIICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	string BFJDKMMBFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	string IFLOIIKCLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EHIJJPMIAPM : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Action CAIJFHGGHKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GFIHCFOKBMB : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	string OICDAFPFCCA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface EGAFAFHPOOL
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface DEOMDGDDHAP : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	Func<string> PFPFKEOGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	Action<string> CGPINLHAPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	int NPJNEGDGJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x7F5B0", Offset = "0x7E9B0")]
	Func<string, bool> JHGBBIGFBAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	string? FBPCPDOEMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string KOKJPOJNIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string HFMAHDBGEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string NIMPFNFIMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	bool NAGIFKAHJMB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool EKHHBBDIPMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface IOJBIINKOOL : EGAFAFHPOOL
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	Func<int> OPOBNAOADAO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Action<int> IDJPANOJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	Func<bool>? PNLDIODPKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	Func<bool>? EHDKNFHFPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	bool HIPGMJINIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	string GPOCABHCCHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	Func<bool>? AMIDHNEADGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool GAHBJMKNOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool EKHHBBDIPMM
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
