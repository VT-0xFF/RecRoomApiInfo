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
		[Cpp2IlInjected.Address(RVA = "0x841A80", Offset = "0x840C80", VA = "0x180841A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x1580AF0", Offset = "0x157FCF0", VA = "0x181580AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F3350", Offset = "0x8F2550", VA = "0x1808F3350")]
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
		[Cpp2IlInjected.Address(RVA = "0xE73C20", Offset = "0xE72E20", VA = "0x180E73C20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface POCMPDIJCGL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed(in APMGLONEHIH JOCACMCANBL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NCGCKMABAGA(in BKOELCEBLFL JELLMBCLNHB);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class PHLBEMKJMNJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DJIDFINOKCC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct IMDKNDGGLMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly CANCNIKNEJJ CENLAODPIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly NIDGJMAENEO FGKADJEJGMB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
	public IMDKNDGGLMH(CANCNIKNEJJ PGEEBICBNAO, NIDGJMAENEO JMCALEHIIJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JKOEPLFEKPH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MCJPCPJIKHD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Action<MCJPCPJIKHD> ICNOMENJIKA
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
	void KIFNMIPNNGP();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKCJICCPAIB(KGEBHPBKGIA LJHEFGCEMAD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BKIBAPGAOGE(KGEBHPBKGIA LJHEFGCEMAD);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64960", Offset = "0x63D60")]
		public readonly BEJFKHGBIOB<KOBCOHBEDIO> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x649C0", Offset = "0x63DC0")]
		public readonly IECPEPBGFBA<ENBDLBKCMBH> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64A20", Offset = "0x63E20")]
		public readonly IECPEPBGFBA<HDMGEGPENHJ> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64A80", Offset = "0x63E80")]
		public readonly BEJFKHGBIOB<KOBCOHBEDIO> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64AE0", Offset = "0x63EE0")]
		public readonly IECPEPBGFBA<ENBDLBKCMBH> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64B40", Offset = "0x63F40")]
		public readonly IECPEPBGFBA<GEIGDJCGDNJ> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1581520", Offset = "0x1580720", VA = "0x181581520")]
		public StaticEdge([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64BA0", Offset = "0x63FA0")] in BEJFKHGBIOB<KOBCOHBEDIO> OKMCKPJEIDC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64C10", Offset = "0x64010")] IECPEPBGFBA<ENBDLBKCMBH> INDCLHCHJLB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64C70", Offset = "0x64070")] IECPEPBGFBA<HDMGEGPENHJ> MPCLAMNFMJO, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64CD0", Offset = "0x640D0")] in BEJFKHGBIOB<KOBCOHBEDIO> MNNAGBOLHAF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64D40", Offset = "0x64140")] IECPEPBGFBA<ENBDLBKCMBH> MKOAAFKPJOG, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x64DA0", Offset = "0x641A0")] IECPEPBGFBA<GEIGDJCGDNJ> NAAENBOPKBC)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1580F50", Offset = "0x1580150", VA = "0x181580F50")]
		public static bool JGKKLLGINAK(in StaticEdge NGKKOMJDENH, in StaticEdge KEJINCBACKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1580CC0", Offset = "0x157FEC0", VA = "0x181580CC0", Slot = "4")]
		public bool Equals(StaticEdge HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1580DB0", Offset = "0x157FFB0", VA = "0x181580DB0", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1580E60", Offset = "0x1580060", VA = "0x181580E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1581040", Offset = "0x1580240", VA = "0x181581040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IFKJBOEINHF
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1580580", Offset = "0x157F780", VA = "0x181580580")]
	public static StaticEdge AKLCAJOKCCK(this CCPPDDJEEAB DCMHODHEGEC)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MKINEAMBLGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGOFHBCHPMD();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NGHLMGJOAGH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JALOFJDICKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void GNHFKMMEBEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65840", Offset = "0x64C40")] IECPEPBGFBA<ENBDLBKCMBH> GFFDBEMENLA, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x658A0", Offset = "0x64CA0")] IECPEPBGFBA<ENBDLBKCMBH> FINDDEHFBJE);

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CODEFLNIOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GPMFBIEGDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JFGFOLLEEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65400", Offset = "0x64800")]
	BEJFKHGBIOB<ALMHILPOKND> LHCGADNDINF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KFBHBGPEHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65470", Offset = "0x64870")]
	ELJJGBIJPJE<GEIGDJCGDNJ, HMEPBJHEBJD> ACABDCLFEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x654D0", Offset = "0x648D0")]
	BEJFKHGBIOB<KOBCOHBEDIO> OIDKNIGHLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65540", Offset = "0x64940")]
	ELJJGBIJPJE<HDMGEGPENHJ, JIPCFOELLBN> CKCBIBCEJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x655A0", Offset = "0x649A0")]
	IECPEPBGFBA<ENBDLBKCMBH> AFIBPBPMIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FPAEABCCLLB;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IECPEPBGFBA<GEIGDJCGDNJ>, HMEPBJHEBJD> ADHKHHJLHLO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<IECPEPBGFBA<GEIGDJCGDNJ>> LBCIEGDFLDL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<IECPEPBGFBA<GEIGDJCGDNJ>, HMEPBJHEBJD> NMJLIDAKCDJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<IECPEPBGFBA<HDMGEGPENHJ>, JIPCFOELLBN> IDDICOJBIIF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<IECPEPBGFBA<HDMGEGPENHJ>> LHEAHLHLCMA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<IECPEPBGFBA<HDMGEGPENHJ>, JIPCFOELLBN> EPCPJCHNJKK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> MEGHBCDHANC();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> LJIIBGOMDAH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65280", Offset = "0x64680")] IECPEPBGFBA<IMCNOEAJGEK> AJPJAAEAKAA);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> PPHDDPPCJDG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x652E0", Offset = "0x646E0")] IECPEPBGFBA<BIKINIMJHJP> EJDOGGBGCOC);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> GLPJOKPNBGD();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> KDGBMKKONMI(string HAMDOEPOHJF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> LAKFALNINGG([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65340", Offset = "0x64740")] IECPEPBGFBA<IMCNOEAJGEK> AJPJAAEAKAA, string PCKMHBLNCII);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> KGINKGFALAD([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x653A0", Offset = "0x647A0")] IECPEPBGFBA<BIKINIMJHJP> EJDOGGBGCOC, string PCKMHBLNCII);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void IOGKADCAGMB(in APMGLONEHIH JOCACMCANBL);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EBBLGKOCEPM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<StaticEdge> JGJLPHLAOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	DisplayKind GGFBIHODBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x659C0", Offset = "0x64DC0")]
	BEJFKHGBIOB<ALMHILPOKND> LHCGADNDINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65A30", Offset = "0x64E30")]
	BEJFKHGBIOB<KOBCOHBEDIO> OIDKNIGHLPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65AA0", Offset = "0x64EA0")]
	IECPEPBGFBA<ENBDLBKCMBH> AFIBPBPMIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65B00", Offset = "0x64F00")]
	IECPEPBGFBA<PHGLMCKICLD> MHDMMDPPECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MKCKAOKMBFP MDENFGBMCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KJCPCKKHIHB(JKOEPLFEKPH IINMHMGKFJG);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KBGHHIJCECB(POCMPDIJCGL IINMHMGKFJG);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NLGIEHNCDDC(KFGDPPPONOK AOLHFNLPOOL);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KBEPNCCIIEM(JKOEPLFEKPH IINMHMGKFJG);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EIGIDDJDBCA(POCMPDIJCGL IINMHMGKFJG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MDJIMDKJNOB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public readonly struct KADOKHGCPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly ONBFMCBADLC DDPBBDAIGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly IReadOnlyDictionary<Guid, Guid> LBBKLCDGNLE;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1580A20", Offset = "0x157FC20", VA = "0x181580A20")]
		public KADOKHGCPAO(ONBFMCBADLC DLMMNHIBAND, IReadOnlyDictionary<Guid, Guid> EPACCGGOBJC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct GNIAGDLAPEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly IReadOnlyCollection<ByteString> ACOAPBLMICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly IReadOnlyCollection<ByteString> EJIGKJNLGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly IReadOnlyCollection<ByteString> CFKACCGPHFG;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA5D850", Offset = "0xA5CA50", VA = "0x180A5D850")]
		public GNIAGDLAPEA(IReadOnlyCollection<ByteString> FMEGDFCAEOD, IReadOnlyCollection<ByteString> HLOAJMHLPCM, IReadOnlyCollection<ByteString> COPAPMAMIKO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct OFJOPMFKGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly ONBFMCBADLC DDPBBDAIGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly IEnumerable<LLLPGKDBIPO> FEKAAOGBNAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly bool BMIMKHNHGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65D00", Offset = "0x65100")]
		public readonly BEJFKHGBIOB<ALMHILPOKND> BDKKHPAEFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly int? CHLJEADMCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly MCPJAFNLLKB? GOLMPHAJBAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly MCPJAFNLLKB? DELBKJKCEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly GNIAGDLAPEA? BCGDFHOLLPK;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1580C10", Offset = "0x157FE10", VA = "0x181580C10")]
		public OFJOPMFKGFF(in ONBFMCBADLC DLMMNHIBAND, IEnumerable<LLLPGKDBIPO> FIALEMGCPMI, bool COCJJPKBOGK, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65D60", Offset = "0x65160")] in BEJFKHGBIOB<ALMHILPOKND> GACPKAEGJGA, int? HPKANHBEBPD, in MCPJAFNLLKB? BBDLONKMGHB, in MCPJAFNLLKB? MPNPJCODCDF, in GNIAGDLAPEA? BBJOOAJEKFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPFCNMFNHOF? GDIJDKBOIDE([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65B60", Offset = "0x64F60")] in BEJFKHGBIOB<ALMHILPOKND?> DDEOLFGMHMC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OCPGFMJFFAJ? FLGENOMCIDH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65BD0", Offset = "0x64FD0")] in BEJFKHGBIOB<KOBCOHBEDIO?> ECDINGOLKBF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<KGPEOGJKDPN> NDOAOJGCINM(bool CPKKENBBPGM, bool GALJJELHKPL, bool KHBIBLBDDPB, bool NKGHHHCGDDP);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CLFKONEBOLH<KADOKHGCPAO, IAPKFGPHFCN> DPJLIADDKJM(in OFJOPMFKGFF AHLCEBMCJMF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ACHLCAOINGN LHCGBMFBJCP(IEnumerable<LLLPGKDBIPO> FIALEMGCPMI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ACHLCAOINGN CFEIPCLACJH();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ONBFMCBADLC JLPNBCOHPAB([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65C40", Offset = "0x65040")] IEnumerable<BEJFKHGBIOB<KOBCOHBEDIO>> NEEDICMDJIK, IEnumerable<LLLPGKDBIPO> FIALEMGCPMI, DJIDFINOKCC LGJELNJFPFH = DJIDFINOKCC.CopyPaste);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MKCKAOKMBFP
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JINPFEFHDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CEPAMDPDJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	TypeKey EGHHJNNLLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CDLFDFJDIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class ADFIPFMNBII
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LAKGAHBHPIO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string GJLOHKIGFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int FLIIGIIMNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LLPNIMHHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class HDMGEGPENHJ : PHGLMCKICLD
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[AMLFBPMMCGO("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class ENBDLBKCMBH
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct EDKPNBIAOAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly PJHLEBGLDJJ PFMGICMGKKO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	public EDKPNBIAOAD(PJHLEBGLDJJ MHFEKDAJKPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface JIPCFOELLBN : EBBLGKOCEPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65E40", Offset = "0x65240")]
	IECPEPBGFBA<HDMGEGPENHJ> AMBOCLOCJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class GEIGDJCGDNJ : PHGLMCKICLD
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class BIKINIMJHJP
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface KGPEOGJKDPN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string FMDACMBCKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> PMOFBBKGMAI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65EA0", Offset = "0x652A0")] BEJFKHGBIOB<ALMHILPOKND> DDEOLFGMHMC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65F00", Offset = "0x65300")] BEJFKHGBIOB<KOBCOHBEDIO> ECDINGOLKBF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65F60", Offset = "0x65360")] IECPEPBGFBA<ENBDLBKCMBH> PMCBDJNAAPH, string PCKMHBLNCII);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> DJIPNHNAAOF([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x65FC0", Offset = "0x653C0")] BEJFKHGBIOB<ALMHILPOKND> DDEOLFGMHMC, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66020", Offset = "0x65420")] BEJFKHGBIOB<KOBCOHBEDIO> ECDINGOLKBF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66080", Offset = "0x65480")] IECPEPBGFBA<ENBDLBKCMBH> PMCBDJNAAPH, string PCKMHBLNCII);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CAGMDEPLNHL
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	MDJIMDKJNOB? EBEPLDELFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BCDJEODODKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool AEBEBNMHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<MDJIMDKJNOB> OAFCDGBKPEK();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CLFKONEBOLH<IMDKNDGGLMH, IAPKFGPHFCN> DNONLMJKKNM(in IMDKNDGGLMH DLMMNHIBAND, IEnumerable<LLLPGKDBIPO> FIALEMGCPMI, int BCEAFKCDAEH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class ALMHILPOKND
{
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface EPFCNMFNHOF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	FDCMJLCODII? BDEEGKPDEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface OCPGFMJFFAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	object IMHNGOEBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OMOGGDIJOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int CBHLHFBIIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	KPMDOFPDKFC CLKCBCAAKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	NodeVisualizationKey EGHHJNNLLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66460", Offset = "0x65860")]
	IECPEPBGFBA<PHLBEMKJMNJ> BFBAFPGHHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MHDJIIEBGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FKANFIDJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool IGKDJGOEGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HPHLFKFLPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool PJJLJGJIEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool IBIGNMEODOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int IAAPGNFKGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool IIBGFBHKKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	string LBCIGEPNINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool KDPFHOJKMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool KBNKLLJKANP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool KOHFGDNOHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool OKHBEPGBNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool DIIMFHIKKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	KHHILIHMLIO KGBIENJBPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	BKOELCEBLFL AHCAPKEEIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[LNPKNGPGOJJ(true, "FloatingText")]
	bool JIHEPCKFJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LAKGAHBHPIO? AIBIOGHKIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool DMKLFBDHGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x664F0", Offset = "0x658F0")]
	BEJFKHGBIOB<ALMHILPOKND> LHCGADNDINF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	[AMLFBPMMCGO("This isn't great UX and we should consider removing it.")]
	bool PDLBGNPKHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66590", Offset = "0x65990")]
	BEJFKHGBIOB<ALMHILPOKND>? AHGNOOEMKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool EALEANJFAIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66600", Offset = "0x65A00")]
	BEJFKHGBIOB<KOBCOHBEDIO> OIDKNIGHLPA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	string AOPINHAKJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66670", Offset = "0x65A70")]
	ELJJGBIJPJE<ENBDLBKCMBH, JALOFJDICKM> NBGBLOLIBKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x666D0", Offset = "0x65AD0")]
	IECPEPBGFBA<ENBDLBKCMBH>? DHMGKAPKIME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BKKGAGLJPAF;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event OABEANHIAID FGPCDCKMPPO;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event NCGCKMABAGA HEIOJOFJABA;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action BIGNKMCDMNA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action COFAAIHHCNB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<IECPEPBGFBA<ENBDLBKCMBH>, JALOFJDICKM> MCGDCMINFPB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<IECPEPBGFBA<ENBDLBKCMBH>> BPMDCDLFFEB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<IECPEPBGFBA<ENBDLBKCMBH>, JALOFJDICKM> KODMMEAKLNJ;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<IECPEPBGFBA<ENBDLBKCMBH>, JALOFJDICKM> OHIPADMIDCG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GLDCGJKAADA(int NMOCADCPJFG);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CLCFHMBKGNJ(in KHHILIHMLIO ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IOFIAOFDAPO(in BKOELCEBLFL ACKOJNNBEBO);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NGKMLOJMDHA();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NCLHOABOFKM();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EACABEBGGAI();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void ABKAACGICHG(string PCKMHBLNCII);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void FDCNPMBIMOJ(int MMFFFGBLCAP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "40")]
	CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB> KPAJLOMLNCN(string HAMDOEPOHJF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool HJFPKMBEEIB(out Guid JJGPOPCIOOD);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool FHMGMOAENIG(in Guid DDEOLFGMHMC);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void BLKLFBLJHAF();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void OIMLAFLFGMN(bool FNODNCFALIM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "64")]
	MCPJAFNLLKB NNNJLGNLLPH();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "65")]
	bool JNEMOCHNDCP([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66400", Offset = "0x65800")] IECPEPBGFBA<ENBDLBKCMBH> PMCBDJNAAPH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "66")]
	Task<CLFKONEBOLH<HHFDPGOJPDI, IDFBCILOOIB>> HOHIHKGEKDE(string HAMDOEPOHJF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class PHGLMCKICLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct ACHLCAOINGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly IMDKNDGGLMH HBEALCPNAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EDKPNBIAOAD OCNBLPIJFPJ;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x15801C0", Offset = "0x157F3C0", VA = "0x1815801C0")]
	public ACHLCAOINGN(in IMDKNDGGLMH ALBGHDBNPBA, EDKPNBIAOAD JNLAJBEPGHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DODHCDPCDMF
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Color
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface HMEPBJHEBJD : EBBLGKOCEPM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x668B0", Offset = "0x65CB0")]
	IECPEPBGFBA<GEIGDJCGDNJ> KNBPAJHEKHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool PFLACJKFGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIMNKAJHNDD(MKINEAMBLGJ BOJBFEIDHFK);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMDPKIDEIPN(BHBOGMBHLEG EKPEBPNBDIH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string KHNEDELFLMK(int BCDOOFLOGMD);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABKMACGAPAJ(NGHLMGJOAGH IINMHMGKFJG);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNEKFFEKCJD(NGHLMGJOAGH IINMHMGKFJG);
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KFGDPPPONOK
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMJAKICGJEE();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDOFONBPAMB(string JPPNDFOFJGA, in KPMDOFPDKFC MBOFNGAOJFM);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFBGJIDJCEN(string CEOMJLPEFPB);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDLEMEEPDFM(string OPJHAOHKCPC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class IMCNOEAJGEK
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct APMGLONEHIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool BPJOHPCNPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly HPLOHOLLNND GPFPOKLGBPG;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1580200", Offset = "0x157F400", VA = "0x181580200")]
	public APMGLONEHIH(bool PMLFJELIPBI, HPLOHOLLNND JFCJEBFELOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class KOBCOHBEDIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public delegate void OABEANHIAID(in KHHILIHMLIO EAFDNPIHGME);
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct ONBFMCBADLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly JNFKDEGAPLA OICKGCOOFEE;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0xD48AD0", Offset = "0xD47CD0", VA = "0x180D48AD0")]
	public ONBFMCBADLC(JNFKDEGAPLA BFDACMCIFBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IDFBCILOOIB : IAPKFGPHFCN
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface BHBOGMBHLEG
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCAPOPDEMCI(string LCOICBDCDIP, Func<string> ABFIBECJEPN, Action<string> ANFFPFNIFID, Func<bool> NBMFHCCKAKJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKACDKOHOMK(string LCOICBDCDIP, Action NDGPMJDEEJB, Func<bool> NBMFHCCKAKJ);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMJFKPMKCFF(string LCOICBDCDIP, Func<int> CPFGHNLELPO, Action<int> HEKBAPCDBFA, Func<bool> NBMFHCCKAKJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNOJIEDNOFH(string LCOICBDCDIP, Func<int> ABFIBECJEPN, Action<int> ANFFPFNIFID, Func<bool> NBMFHCCKAKJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKNLLMCALEM(string LCOICBDCDIP, Func<int> KHAIPIHOPMI, Action<object> OKNAJLBDBKL, Func<object, string> AMOCHKPJDLL, Func<bool> NBMFHCCKAKJ, Type MJFECEDFNAH, IReadOnlyList<object> MHEMNNFMFOH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPJCCEJLHCL(string LCOICBDCDIP, Func<string> ABFIBECJEPN, Action<string> ANFFPFNIFID, Func<bool> NBMFHCCKAKJ);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCKMINKAHEB(string LCOICBDCDIP, Func<bool> ABFIBECJEPN, Action<bool> ANFFPFNIFID, Func<bool> NBMFHCCKAKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum HPLOHOLLNND
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface OEEPLBKKBED : ALFBLNMKIEI
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	CAGMDEPLNHL MFDBLAOKPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct FDCMJLCODII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66910", Offset = "0x65D10")]
	public readonly BEJFKHGBIOB<KOBCOHBEDIO> BFDDHHHMDFM;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x86A760", Offset = "0x869960", VA = "0x18086A760")]
	public FDCMJLCODII([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66970", Offset = "0x65D70")] in BEJFKHGBIOB<KOBCOHBEDIO> BCCIBFMMDIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HOAFJLJBEDM : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x669E0", Offset = "0x65DE0")]
	Func<List<KeyValuePair<string, FPPLCBGCKJJ>>> DKEBOAHIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Func<int> PADFOMFNMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Action<int> LHCHCEDNIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	Func<bool>? MDHNEOIKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66A40", Offset = "0x65E40")]
	Func<int, string> IKGDDIKEKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Action? FKGPGJJFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Action? NFCFPHBPBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool DHJBBIIJGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool LMJFHHJKLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KLDMFMBICGE : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Func<Dictionary<string, FPPLCBGCKJJ>> DKEBOAHIPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Func<int> PADFOMFNMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Action<int> LHCHCEDNIMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	Func<bool>? MDHNEOIKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66AA0", Offset = "0x65EA0")]
	Func<int, string> IKGDDIKEKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool DHJBBIIJGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool LMJFHHJKLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface KLNIKMEKBMG : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	KGEBHPBKGIA OOCPAIJMDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface PMALKACLFOM : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Func<float> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Action<float> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	string FENKOEHKGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool MINIKNNFEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float JHMFBNMLIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	float NPJAHKCGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface FNAHFJGPCCA : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Func<string> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Action<string> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int? NJMCEHGGKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool OCNFJBLINKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum AFJIBMNFEOO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Custom
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HPICGNNPPBO : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Func<string> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Action<string> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	int? NJMCEHGGKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool OCNFJBLINKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface MHCIDKALMCJ : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Func<float> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Action<float> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float JHMFBNMLIOM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	float NPJAHKCGJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Func<bool>? DEFLMFANNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	int DMGDOOEILNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	string FENKOEHKGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Func<float, float>? COFPHAJAECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Func<float, float>? CEAGJFACICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface BPLGCENBJII : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	Func<bool> LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Func<IReadOnlyList<object>> NFLHHLKDAKP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Func<object, string> GLJDDCIGCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	Func<object> BKLDGAOACAC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Action<object> POLMELHAJCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface DCDDMHGJLAA : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	int NGGPCGGCKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66B00", Offset = "0x65F00")]
	Func<string, bool> KALLCEDLGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	string? LAPDGLDOHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool OCNFJBLINKM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	AFJIBMNFEOO PDFLIGHJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Func<string> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	Action<string> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface FGAMKLMLIPN : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	Func<bool> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	Action<bool> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	int GIAHOLBDHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface ODABNEGFPJA : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Dictionary<string, FPPLCBGCKJJ> GHNGNBFABMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	Func<int> PADFOMFNMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	Action<int> LHCHCEDNIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Action? FKGPGJJFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	Action? NFCFPHBPBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66B60", Offset = "0x65F60")]
	Func<int, string> IKGDDIKEKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool DHJBBIIJGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	bool LMJFHHJKLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66BC0", Offset = "0x65FC0")]
	Action<MCJPCPJIKHD> BOEFGFKPHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface IOFGPEJFMAE : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	Func<string> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	Action<string> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	Action PMKELGGNCKF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	AFJIBMNFEOO PDFLIGHJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string NLHIGEBDFNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string DAEGPGNPBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface LIAMANOJBBF : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Action PMKELGGNCKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface HFPELGICNMP : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	string IDLMPBMACPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface KGEBHPBKGIA
{
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface MBOMEKFPDPN : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	Func<string> FGNMGJJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	Action<string> GBKEGFCLCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	int NGGPCGGCKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x66C40", Offset = "0x66040")]
	Func<string, bool> KALLCEDLGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	string? LAPDGLDOHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	string OPGLDNHNFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	string EEHHOECDLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	string PGKEJGNNLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool IBCNMDBOBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool FIELPIIJJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface ENOPGEDPKPH : KGEBHPBKGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	Func<int> PADFOMFNMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	Action<int> LHCHCEDNIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	Func<bool>? LPGPAIIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	Func<bool>? DNGOJBFLAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	bool MNPJJOOKKED
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	string IMGNKPNLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	Func<bool>? EAHMPPAHCJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	bool CICGLFKJAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	bool FIELPIIJJFP
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
