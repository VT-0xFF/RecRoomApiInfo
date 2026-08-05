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
		[Cpp2IlInjected.Address(RVA = "0x956600", Offset = "0x954C00", VA = "0x180956600")]
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
		[Cpp2IlInjected.Address(RVA = "0x722FD70", Offset = "0x722E370", VA = "0x18722FD70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBD9AB0", Offset = "0xBD80B0", VA = "0x180BD9AB0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xEA93B0", Offset = "0xEA79B0", VA = "0x180EA93B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MGBIIDPLNEA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed(in DGGMGIFFPPF EDCHGGHAOGO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void CKOECKGBJNE(in EAKIHAGBMPE DGGEILNBDKG);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class KHPNMOEIPOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DCBEJGIJEGB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct AFFCGGCCIKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly BJNIIDPCIGO ICGFAGOBLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly OJGINLPFMIK GFGCPNFMDII;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
	public AFFCGGCCIKH(BJNIIDPCIGO JDNDLCHHMAK, OJGINLPFMIK MKOKMFCHDKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KGBLBLNDDHH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EOGFGHLMLJA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Action<EOGFGHLMLJA> FOGDNJAFGJC
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
	void DHFEDPFLDDC();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGHDENAHPJH(LEBPLEBJGDN FPKHPGOOGKG);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JEMCOCDPCEF(LEBPLEBJGDN FPKHPGOOGKG);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71AF00", Offset = "0x71A300")]
		public readonly JPOCEKCOFNM<NHPKHOLKBID> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71AF60", Offset = "0x71A360")]
		public readonly JIONBOANMAG<CBJJCECCLED> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71AFC0", Offset = "0x71A3C0")]
		public readonly JIONBOANMAG<EEDCDMMIIBG> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B020", Offset = "0x71A420")]
		public readonly JPOCEKCOFNM<NHPKHOLKBID> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B080", Offset = "0x71A480")]
		public readonly JIONBOANMAG<CBJJCECCLED> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B0E0", Offset = "0x71A4E0")]
		public readonly JIONBOANMAG<PCPILLPFDEE> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69B14D0", Offset = "0x69AFAD0", VA = "0x1869B14D0")]
		public StaticEdge([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B140", Offset = "0x71A540")] in JPOCEKCOFNM<NHPKHOLKBID> JPNFOKECGEH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B1B0", Offset = "0x71A5B0")] JIONBOANMAG<CBJJCECCLED> IFFEAFAIHND, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B210", Offset = "0x71A610")] JIONBOANMAG<EEDCDMMIIBG> JLBKMLBGAOF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B270", Offset = "0x71A670")] in JPOCEKCOFNM<NHPKHOLKBID> KCLPBCCMDED, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B2E0", Offset = "0x71A6E0")] JIONBOANMAG<CBJJCECCLED> FFDKDHELGGN, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B340", Offset = "0x71A740")] JIONBOANMAG<PCPILLPFDEE> FLADJIJCHIC)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7230090", Offset = "0x722E690", VA = "0x187230090")]
		public static bool MOJFGPLDDKP(in StaticEdge CNCLMHODMJG, in StaticEdge ECNLMNDOGCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x722FE00", Offset = "0x722E400", VA = "0x18722FE00", Slot = "4")]
		public bool Equals(StaticEdge EJECOGCICOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x722FEF0", Offset = "0x722E4F0", VA = "0x18722FEF0", Slot = "0")]
		public override bool Equals(object IAMEECMGPIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x722FFA0", Offset = "0x722E5A0", VA = "0x18722FFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7230180", Offset = "0x722E780", VA = "0x187230180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EHPBLEHODHK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x722FA90", Offset = "0x722E090", VA = "0x18722FA90")]
	public static StaticEdge EMHFJGFFMPB(this KJNPAHKMPNM PBJDHAKDMFG)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NGNJBNIFGMK
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCHKHOMMBIG();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CLHEAGCFBDD
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LBIPKANINEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void AAPKLBMIAEK([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BDE0", Offset = "0x71B1E0")] JIONBOANMAG<CBJJCECCLED> ABBAPCAIMDJ, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BE40", Offset = "0x71B240")] JIONBOANMAG<CBJJCECCLED> BGBLNMDAKNB);

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IIMLMDDKNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KNALDDOFGII
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KNHCCBIHCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B9A0", Offset = "0x71ADA0")]
	JPOCEKCOFNM<HDIJODLLCKJ> GFKFKBLJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MEBHJBEEMIG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BA10", Offset = "0x71AE10")]
	FMGPEJOACDM<PCPILLPFDEE, NPPJIEJOKNB> HAIHBOMPNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BA70", Offset = "0x71AE70")]
	JPOCEKCOFNM<NHPKHOLKBID> PAAADIKKPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BAE0", Offset = "0x71AEE0")]
	FMGPEJOACDM<EEDCDMMIIBG, ANBBPAEMKEJ> ELBNFNIMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BB40", Offset = "0x71AF40")]
	JIONBOANMAG<CBJJCECCLED> PLNNBOPJIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action EIGLCLGHANP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<JIONBOANMAG<PCPILLPFDEE>, NPPJIEJOKNB> KKFKLMCBMJF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<JIONBOANMAG<PCPILLPFDEE>> LNHOLPLNHJC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<JIONBOANMAG<PCPILLPFDEE>, NPPJIEJOKNB> CHDKMHBEBCG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<JIONBOANMAG<EEDCDMMIIBG>, ANBBPAEMKEJ> EOPGHFDHBNM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JIONBOANMAG<EEDCDMMIIBG>> DLCHEOFMJNN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JIONBOANMAG<EEDCDMMIIBG>, ANBBPAEMKEJ> ELGAIBKLAPB;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> FBIJAFJNMEH();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> ENDJMKFHGNJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B820", Offset = "0x71AC20")] JIONBOANMAG<JPGMCAGEODF> LIHHDMOGNEL);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> LPIOFHPAMDE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B880", Offset = "0x71AC80")] JIONBOANMAG<OKGIOFOLIJK> KLKKNKHBJDA);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> KMAOIIFPBLJ();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> LICFGOCMDEB(string GLHBIMOHKGB);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> NOIONOCLKBL([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B8E0", Offset = "0x71ACE0")] JIONBOANMAG<JPGMCAGEODF> LIHHDMOGNEL, string HNPIEGONNBC);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> KHEFNPBFEJG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71B940", Offset = "0x71AD40")] JIONBOANMAG<OKGIOFOLIJK> KLKKNKHBJDA, string HNPIEGONNBC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void CELEIOLCAND(in DGGMGIFFPPF EDCHGGHAOGO);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EBBBBJEHIBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<StaticEdge> JLPFCLAPCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DisplayKind OBKCBOHGJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BF60", Offset = "0x71B360")]
	JPOCEKCOFNM<HDIJODLLCKJ> GFKFKBLJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71BFD0", Offset = "0x71B3D0")]
	JPOCEKCOFNM<NHPKHOLKBID> PAAADIKKPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C040", Offset = "0x71B440")]
	JIONBOANMAG<CBJJCECCLED> PLNNBOPJIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C0A0", Offset = "0x71B4A0")]
	JIONBOANMAG<JPHCJPPOCMO> AIOFFFEGNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EFDMPBKAPHJ PHDPMGPDBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NIGCKFBJGOL(KGBLBLNDDHH ABCNCGGNAMF);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OACDPLDMGOB(MGBIIDPLNEA ABCNCGGNAMF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BMNELENICOF(HCKEIHIABKP GBNKEKJOOLK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KKEKMAIMDNC(KGBLBLNDDHH ABCNCGGNAMF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KAAEAMDAHMI(MGBIIDPLNEA ABCNCGGNAMF);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NLNHDEHHKIE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct ANPGCFPPOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly MIPKKFIMEKE OBDMGEPDGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly IReadOnlyDictionary<Guid, Guid> OJLPJDBFJLO;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x218F9F0", Offset = "0x218DFF0", VA = "0x18218F9F0")]
		public ANPGCFPPOIL(MIPKKFIMEKE PGOJIELHMMI, IReadOnlyDictionary<Guid, Guid> KKPKHNPJGLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct KOBBGEDOOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly IReadOnlyCollection<ByteString> OGCNOIJKNFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly IReadOnlyCollection<ByteString> CDMELEIIOEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly IReadOnlyCollection<ByteString> IMLPFMEHDCP;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xE3F220", Offset = "0xE3D820", VA = "0x180E3F220")]
		public KOBBGEDOOFM(IReadOnlyCollection<ByteString> AONOGOCEHKG, IReadOnlyCollection<ByteString> DOCCKICBOGN, IReadOnlyCollection<ByteString> PCBCOKDDGLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct MDNDKJNHAAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MIPKKFIMEKE OBDMGEPDGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly IEnumerable<NFFPAONFDAO> FMFFALLKMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly bool GBKIEKLFCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C2A0", Offset = "0x71B6A0")]
		public readonly JPOCEKCOFNM<HDIJODLLCKJ> AOHLECDMPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly int? MOEOMGHLJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly EHEPBCAELPC? MKCGGDPKFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly EHEPBCAELPC? PINDHEAOMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly KOBBGEDOOFM? CIFPHNJLGCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly DCBEJGIJEGB GBJOCCGEBKI;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x722FC30", Offset = "0x722E230", VA = "0x18722FC30")]
		public MDNDKJNHAAG(in MIPKKFIMEKE PGOJIELHMMI, IEnumerable<NFFPAONFDAO> FBODAKFKGIM, bool EAADJOADHOK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C300", Offset = "0x71B700")] in JPOCEKCOFNM<HDIJODLLCKJ> FNIIBALLEIC, int? FHLAMJGGLCC, in EHEPBCAELPC? OALGBAGOANC, in EHEPBCAELPC? JGGPFKFIMNM, in KOBBGEDOOFM? EGDOILAHKDM, DCBEJGIJEGB JFJLOAOHDPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OBJCEGJHMLO? DFNCKECCJDG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C100", Offset = "0x71B500")] in JPOCEKCOFNM<HDIJODLLCKJ?> ELEBJEJCHNH);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JPLJMLFKNMC? EMIENFAAMEM([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C170", Offset = "0x71B570")] in JPOCEKCOFNM<NHPKHOLKBID?> IGPIKBBAHPG);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JNLOMNLNGMP> EHAMDFAMDCL(bool NGBJHKEGJIH, bool BEKHGAHOIFA, bool EDHNEFBHCOB, bool HEGFNGBJJKG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EGKNCMFMAMB<ANPGCFPPOIL, AGHPCJDDHII> MMAOFELCFBP(in MDNDKJNHAAG GDDHAFPALIL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LGLGIKEFBEG KLPJKMPILFC(IEnumerable<NFFPAONFDAO> FBODAKFKGIM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LGLGIKEFBEG MLPGDIJIPIO();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MIPKKFIMEKE LPPFFDECDJN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C1E0", Offset = "0x71B5E0")] IEnumerable<JPOCEKCOFNM<NHPKHOLKBID>> NIOIHEPPGEF, IEnumerable<NFFPAONFDAO> FBODAKFKGIM, DCBEJGIJEGB JFJLOAOHDPJ = DCBEJGIJEGB.CopyPaste);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EFDMPBKAPHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LFMGEMECAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DHEBOCFEGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	TypeKey BMFMEFAJFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GGBIEBKMDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class GCIOHNGLIMJ
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface EHLOIKCGDFE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string CGONCLEJBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int PKBHAMCJJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PLJDGCAHGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class EEDCDMMIIBG : JPHCJPPOCMO
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[GFNBIBHBBNO("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class CBJJCECCLED
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct KFHIHPNOACN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly PPJKDKMANPD HJFLMDLEBHM;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	public KFHIHPNOACN(PPJKDKMANPD IELABEHPCPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface ANBBPAEMKEJ : EBBBBJEHIBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C3A0", Offset = "0x71B7A0")]
	JIONBOANMAG<EEDCDMMIIBG> DHCKKGNPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class PCPILLPFDEE : JPHCJPPOCMO
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class OKGIOFOLIJK
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface JNLOMNLNGMP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string BFKEGCGFBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> MBCPEIDFACF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C400", Offset = "0x71B800")] JPOCEKCOFNM<HDIJODLLCKJ> ELEBJEJCHNH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C460", Offset = "0x71B860")] JPOCEKCOFNM<NHPKHOLKBID> IGPIKBBAHPG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C4C0", Offset = "0x71B8C0")] JIONBOANMAG<CBJJCECCLED> BNIOHMNLNLA, string HNPIEGONNBC);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> IDCCPJDPAAJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C520", Offset = "0x71B920")] JPOCEKCOFNM<HDIJODLLCKJ> ELEBJEJCHNH, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C580", Offset = "0x71B980")] JPOCEKCOFNM<NHPKHOLKBID> IGPIKBBAHPG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C5E0", Offset = "0x71B9E0")] JIONBOANMAG<CBJJCECCLED> BNIOHMNLNLA, string HNPIEGONNBC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface LOPIOHEIMLM
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	NLNHDEHHKIE? FBBAELKBDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool AGFLGOGGBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NLAAGJGDEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<NLNHDEHHKIE> IAHHAGFDCDG();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EGKNCMFMAMB<AFFCGGCCIKH, AGHPCJDDHII> NICKALPEOLD(in AFFCGGCCIKH PGOJIELHMMI, IEnumerable<NFFPAONFDAO> FBODAKFKGIM, int AOFJMNGLCAK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HDIJODLLCKJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface OBJCEGJHMLO
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	BOOPNCJKEGG? DEHFAEJMEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JPLJMLFKNMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	object JADCFGAFFKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OHCLDIMPHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int NCILMPDNAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	BOKDOGPLGPD ELIMNBGOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	NodeVisualizationKey BMFMEFAJFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C9C0", Offset = "0x71BDC0")]
	JIONBOANMAG<KHPNMOEIPOB> PJJIHCBAIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool JCBOEOCGAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HGOCAPMFNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool PAMCBEBNJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MFGPBGFNJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool IEIOMHKIMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FPIEEOAKDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int EJGKFNIOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool HOCBPFPPDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string CFLMJHKKOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool ENIIHBDGECO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool KCMILCCJBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool EGMMHMENACG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool GFIKDPJKMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool GOLIKCNEMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IIPBFLKFCOP LNGMBEAPKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	EAKIHAGBMPE ADFIAGOOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[JKLNIBFJALJ(true, "FloatingText")]
	bool HDLFPALCILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	EHLOIKCGDFE? CPOPGJHJEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool MPHOFPNDBCL
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CA50", Offset = "0x71BE50")]
	JPOCEKCOFNM<HDIJODLLCKJ> GFKFKBLJLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[GFNBIBHBBNO("This isn't great UX and we should consider removing it.")]
	bool HJLMBCOPIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CAF0", Offset = "0x71BEF0")]
	JPOCEKCOFNM<HDIJODLLCKJ>? IOAIAODCMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool LLNCHNOLAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CB60", Offset = "0x71BF60")]
	JPOCEKCOFNM<NHPKHOLKBID> PAAADIKKPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string NHAFHGAJCFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CBD0", Offset = "0x71BFD0")]
	FMGPEJOACDM<CBJJCECCLED, LBIPKANINEN> EIOAMBMLIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CC30", Offset = "0x71C030")]
	JIONBOANMAG<CBJJCECCLED>? OFIHCFEDLON
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action IDCMHBGPLGF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event NKLMPLMIKJO LAAEKPOMDNJ;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CKOECKGBJNE KHBKPHJPKNI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action LJFLDFIFFCF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action GOLHEPHDFNP;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JIONBOANMAG<CBJJCECCLED>, LBIPKANINEN> BFNBNPIIHLN;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<JIONBOANMAG<CBJJCECCLED>> OEJKKALJEFM;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JIONBOANMAG<CBJJCECCLED>, LBIPKANINEN> MFIIEJLJNAC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<JIONBOANMAG<CBJJCECCLED>, LBIPKANINEN> BDGNOANDKAG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPMAALJLMKB(int ILMMHGOOAIP);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void ILIJKDKJPLP(in IIPBFLKFCOP FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AKOHACCCCHD(in EAKIHAGBMPE FEBHELIDNED);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DIIIKKAKLDL();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EMELCOPOIDN();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FMNACKAIMDM();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void GJCFFKLPGGO(string HNPIEGONNBC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void DMHHBDLJLJB(int IIOMOLKAONM);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "40")]
	EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO> HLPPIMBFHLB(string GLHBIMOHKGB);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool DKEPKAINIBB(out Guid PPEPHBAFPDB);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool NKOGCIIBGGH(in Guid ELEBJEJCHNH);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void BCFKLBADKBF();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void KGLDKFAFMGP(bool IODKJOEGKND);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "64")]
	EHEPBCAELPC IBPENKLLMOG();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "65")]
	bool CIMPEHPFFMJ([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C960", Offset = "0x71BD60")] JIONBOANMAG<CBJJCECCLED> BNIOHMNLNLA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "66")]
	Task<EGKNCMFMAMB<DABEAPPDAMA, MNMNGBCAHAO>> LBDBCOHKCIM(string GLHBIMOHKGB);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class JPHCJPPOCMO
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct LGLGIKEFBEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly AFFCGGCCIKH PLIDCAFDGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KFHIHPNOACN LNFHLAMHMNL;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x722FBF0", Offset = "0x722E1F0", VA = "0x18722FBF0")]
	public LGLGIKEFBEG(in AFFCGGCCIKH DNCLKGCICOE, KFHIHPNOACN PEGIFAKLECB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class EMDFCJMPODL
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Color
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface NPPJIEJOKNB : EBBBBJEHIBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CE10", Offset = "0x71C210")]
	JIONBOANMAG<PCPILLPFDEE> JIDMBAEDPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool DFIDGDBIIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHBHECLKOLA(NGNJBNIFGMK MJNGJPIFIJH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFCIALAABFD(GBOEIKAAHBD FPJECPIFBLJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NINGBNLLDLH(int FJHPIDCEGNP);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HGAFKLEPNOF(CLHEAGCFBDD ABCNCGGNAMF);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AJEHMHJKBGK(CLHEAGCFBDD ABCNCGGNAMF);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HCKEIHIABKP
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADMMAILEKMJ();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBMLKKJMPDP(string JLMMLPJBEBG, in BOKDOGPLGPD OOJLGEBJDPI);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDHHFENABIH(string JIEHBANCLJP);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIDBHELPIGH(string EGOBKGDOFOI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class JPGMCAGEODF
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct DGGMGIFFPPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly bool GBCDLBIGFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly PGNOOLLCGHD DDMKBKMLNHD;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x15C41D0", Offset = "0x15C27D0", VA = "0x1815C41D0")]
	public DGGMGIFFPPF(bool BAAOCHJCFME, PGNOOLLCGHD FDPJNLNBKHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class NHPKHOLKBID
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public delegate void NKLMPLMIKJO(in IIPBFLKFCOP BMLLLNHBIGO);
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct MIPKKFIMEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly NLOLJGKJBGK FICPKPGGHHO;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xA7EC30", Offset = "0xA7D230", VA = "0x180A7EC30")]
	public MIPKKFIMEKE(NLOLJGKJBGK IEOMMPGNPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MNMNGBCAHAO : AGHPCJDDHII
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GBOEIKAAHBD
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBNKECOCOPL(string EAEJCCGFAJO, Func<string> DEINCGJLLNC, Action<string> LLFOPFNCODB, Func<bool> IAFGMJBAHGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OANNOMNOOIH(string EAEJCCGFAJO, Action GHKPHFIBBMI, Func<bool> IAFGMJBAHGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBAJHBJIFLL(string EAEJCCGFAJO, Func<int> MHHMAFFNPKN, Action<int> HENELCBMEHA, Func<bool> IAFGMJBAHGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DBGOAOHLLHP(string EAEJCCGFAJO, Func<int> DEINCGJLLNC, Action<int> LLFOPFNCODB, Func<bool> IAFGMJBAHGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GAGNDHELJIH(string EAEJCCGFAJO, Func<int> PIGAHHDLJHO, Action<object> NGNMHIOGNOP, Func<object, string> GJOOGNGGJAA, Func<bool> IAFGMJBAHGJ, Type HCMMNJOLBJI, IReadOnlyList<object> IIIOAGKAMMB);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NFGKECOBJKL(string EAEJCCGFAJO, Func<string> DEINCGJLLNC, Action<string> LLFOPFNCODB, Func<bool> IAFGMJBAHGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HKGKIIJBONG(string EAEJCCGFAJO, Func<bool> DEINCGJLLNC, Action<bool> LLFOPFNCODB, Func<bool> IAFGMJBAHGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum PGNOOLLCGHD
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AEGPOHHMBFB
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GLJNFIPDLCI : BEEGKCCCFIM
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LOPIOHEIMLM PCNHPLOHJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct BOOPNCJKEGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CE70", Offset = "0x71C270")]
	public readonly JPOCEKCOFNM<NHPKHOLKBID> GGICBENCCKM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1B3F6A0", Offset = "0x1B3DCA0", VA = "0x181B3F6A0")]
	public BOOPNCJKEGG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CED0", Offset = "0x71C2D0")] in JPOCEKCOFNM<NHPKHOLKBID> NFHHGFFBNPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface AAGFPOHFOJG : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CF40", Offset = "0x71C340")]
	Func<List<KeyValuePair<string, LDDEMNLKLDG>>> KLIJBMHGDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Func<int> JLMFBDFDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Action<int> CCCLGHNDNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	Func<bool>? NKCGCBACHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71CFA0", Offset = "0x71C3A0")]
	Func<int, string> IHMJDENEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Action? EDEADGCIJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Action? IBLLFMMHHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool JDOEKLAMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool ICLIKLOCAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface JNIOMGPOBKH : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Func<Dictionary<string, LDDEMNLKLDG>> KLIJBMHGDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Func<int> JLMFBDFDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Action<int> CCCLGHNDNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Func<bool>? NKCGCBACHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D000", Offset = "0x71C400")]
	Func<int, string> IHMJDENEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool JDOEKLAMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool ICLIKLOCAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AAKDEDBKOBD : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	LEBPLEBJGDN BPGJNIFLJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FAACDDMHCNF : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Func<float> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Action<float> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	string JGKHHOJGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OOOJJIMEFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float CLOLJJJAAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	float KFGFKCENFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ADANBAIIPJN : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Func<string> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Action<string> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int? LGNPMGLCBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool MGEGIINFPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public enum ODPABBMIKGI
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface PKMCMJIELDM : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Func<string> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Action<string> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	int? LGNPMGLCBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool MGEGIINFPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PKKJMNFJEHF : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Func<float> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Action<float> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float CLOLJJJAAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	float KFGFKCENFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Func<bool>? BMGFMOILAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	int LKKNOCMNCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	string JGKHHOJGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Func<float, float>? DLOHEMBPELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Func<float, float>? MFFMNAJCOEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BKCLAFPKEAC : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Func<bool> PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Func<IReadOnlyList<object>> IPAEBNFBONH
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Func<object, string> ALCDLJGBFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Func<object> AEEFDIPDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Action<object> JJCAAPPOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface KFAJKEAOKAK : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	int GFLLBLHMBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D060", Offset = "0x71C460")]
	Func<string, bool> HENNGIKOKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string? IFJNLKOADGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool MGEGIINFPHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	ODPABBMIKGI KBBBDODNMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Func<string> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Action<string> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface BMOJLIEMPFL : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Func<bool> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Action<bool> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	int GCBAEJGNGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface INDDHHBLAOO : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Dictionary<string, LDDEMNLKLDG> PNEJJFAJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Func<int> JLMFBDFDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	Action<int> CCCLGHNDNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Action? EDEADGCIJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	Action? IBLLFMMHHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D0C0", Offset = "0x71C4C0")]
	Func<int, string> IHMJDENEPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool JDOEKLAMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	bool ICLIKLOCAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D120", Offset = "0x71C520")]
	Action<EOGFGHLMLJA> DBKKGGAMKFE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KAKBDBHIIMG : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	Func<string> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	Action<string> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	Action DFBLBAAOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	ODPABBMIKGI KBBBDODNMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string PGLBHCCEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string FPPLLCCIAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface ACPBAHINPAC : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Action DFBLBAAOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface MDCEMNCBEOM : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	string IDNEPKHJHII
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface LEBPLEBJGDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface BNJJJGGOHJO : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	Func<string> HCIOJMLJOJI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	Action<string> KHANDJPCKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	int GFLLBLHMBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71D1A0", Offset = "0x71C5A0")]
	Func<string, bool> HENNGIKOKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	string? IFJNLKOADGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	string PJNPLOKLDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	string OKPPMFMBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	string NEJCHICIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool GNILAACFDDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HEANMOINCEC : LEBPLEBJGDN
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	Func<int> JLMFBDFDPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	Action<int> CCCLGHNDNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	Func<bool>? PJFKLGOGJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	Func<bool>? ADPFCLIAGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	bool LGLMJGNIBAM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	string GDBFCOICCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Func<bool>? AKAFIBPHIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	bool NPCFFMANFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	bool IADMLIHDMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
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
