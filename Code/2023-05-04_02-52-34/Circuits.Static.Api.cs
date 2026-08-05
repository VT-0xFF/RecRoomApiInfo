using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0x734AD0", Offset = "0x733ED0", VA = "0x180734AD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D9D0", Offset = "0x6A3CDD0", VA = "0x186A3D9D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x730090", Offset = "0x72F490", VA = "0x180730090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9CC120", Offset = "0x9CB520", VA = "0x1809CC120")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct IFEADDDKLHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LAPIOLFHPCJ JJACLKJJIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly CBPHLIHEOKK EHLELMODPKC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D990", Offset = "0x6A3CD90", VA = "0x186A3D990")]
	public IFEADDDKLHD(in LAPIOLFHPCJ GOKPFGBACOI, CBPHLIHEOKK DDEENGNPJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct LAPIOLFHPCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CNFCMDLNPPA KECJFJMCJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly AIOGENCBFAM CNOKDEILGOP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7EB0F0", Offset = "0x7EA4F0", VA = "0x1807EB0F0")]
	public LAPIOLFHPCJ(CNFCMDLNPPA JDNFBGGKIMJ, AIOGENCBFAM OLOKPCLGMEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CBPHLIHEOKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly JHBALGJGKMA EHLELMODPKC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x982140", Offset = "0x981540", VA = "0x180982140")]
	public CBPHLIHEOKK(JHBALGJGKMA DDEENGNPJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KAEBHALPJPD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Action<KAEBHALPJPD> HLAFJCBKPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENHGCGDLLFK();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JEFAMPBLPAE(FKCACHHMMDF IJFPPFPCGAM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AAFOFHBMDON(FKCACHHMMDF IJFPPFPCGAM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FEMCCEAKMDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LJDDBDHBFHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LKIJNIOMCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IPGEFLMOFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OFLJNPPKMED
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KFDMKDFLNBP? AGBLMGNNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LLCBHNILDCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PHDAEHLOHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<KFDMKDFLNBP?>? BLDMDFGGOOL();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KFDMKDFLNBP
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IFEADDDKLHD PAHLHHJHHHF();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IFEADDDKLHD LAPLOFDCKFP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OMDPJIAGPGH : LGJHGNGBAFP
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OFLJNPPKMED NLEJAAABBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KIHHJLOCPGF : PAMMHIBIBOL
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ANFECBHNCAP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	object JELKDBJJLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	[JMOGFODMLAN("This should be replaced with `MarkedGraphId`.")]
	Guid GNANBKDGNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	[JMOGFODMLAN("This should be replaced with `MarkedNodeId`.")]
	Guid EFNNIAKHCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool BEGNPIMOJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MKGBFLPBLIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int MNHMNLFIKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FNKFEPPPMAB AIFLMNLBJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NodeVisualizationKey MKIHFPLFIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4E70", Offset = "0x6E4270")]
	global::BLPHOENPIDB<CCOFFNEOJDH> KIDMJOOBDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool IBOOPDHFEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Guid GLDEABAGHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool BLCEFGJLCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool APPGKGOMJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JFAFCENBDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool HJJGIAGJEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HJDHONAFFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool EAFJLEPHHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int DLBCLEALHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OHLCMHENOIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EMGAJKKIHDI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string LOHLHOOOBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool ELFLKHBHLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JPMCNNDNDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool ODPGIOGKFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool OOBCHLAHLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool KADCLILOMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool IPPPDPEIBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	MDBPNPIFIKM NAILLMLOGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	OKMADGLLINM FBMHBHAGGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NLBHOBIFDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	[JHDAJBLLBFG(true, "FloatingText")]
	bool LHLLHOOKLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	FEMCCEAKMDJ? MMAAGBEDAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BFELJGHNKHH;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FJMIJAJPNGD LPGBKPOKGEF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event FBHHKMGDBDE IJDPAPJOMBG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action NAOHKJOIIDL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<int> LPMJBONHAOM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action EOMHACKEEEH;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBMFCOGPJGB(string KNCECLHAGBC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGBGCMHEJCC(int DDOHHCKBLDK);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void ENJCMBFDOCN(in MDBPNPIFIKM LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void HKJLMAEMPJL(in OKMADGLLINM LPJDDLMPNCG);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HFHFKOGKHFB();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CBBNIDFBENI();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void AKDAEOINOKJ();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void EICKPJEAPLM();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool AKONNJHHMOG(int LHJHKMNCFIA);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void AFFIMFLMCKI(string AMNLGEBHFHK);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void LGMPAIENPKC(int EGNHJGKABLC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "53")]
	global::LFBADEDAHHF<JAPIHNFIDBB, KIHHJLOCPGF> MCJKIFEJFII(string KNCECLHAGBC);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "54")]
	bool NBCALPDOLBI(out Guid MCIFJHLGFLG);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool FIGBEKJAIGG(in Guid HDIHCPHNJND);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void JAIKDMLJCNA();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void JJLEDBEGOGK(bool HJIFGMOHCKA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LIDMEALLNHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class ILJJDCMCMLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class CCOFFNEOJDH
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void FJMIJAJPNGD(in MDBPNPIFIKM PPNOLBKPBJH);
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void FBHHKMGDBDE(in OKMADGLLINM KAHANPFONLJ);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface KIPJHCAFJGN : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Action APGFNKIDHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AIDLOKKEDPC : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	Func<Dictionary<string, CPFMMOODPIE>> ILKGBKHGDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Func<int> GMBLLBFKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Action<int> OJPFPMMGOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	Func<bool>? LDFCJMBNNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4F40", Offset = "0x6E4340")]
	Func<int, string> ADADFGPCHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool LNPKEHFHDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool DLIBBEGMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface KDFOIIKCLAB : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Func<int> GMBLLBFKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Action<int> OJPFPMMGOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool BJFJFODMKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool DOBGICCNCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OGLEGIKFPMF : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	Func<float> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	Action<float> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string GHAMIBGKOHC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool PDPDAOIGMDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	float DEEPIDEAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float DGLFKGJFDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface FIFLILOMJAO : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Func<string> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Action<string> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	int CDOLJBEMGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E4FA0", Offset = "0x6E43A0")]
	Func<string, bool> HKPDNLHMEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	string? FOEHPPKAHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool IHCFINEJHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface ANALPMDIMMJ : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5000", Offset = "0x6E4400")]
	Func<List<KeyValuePair<string, CPFMMOODPIE>>> ILKGBKHGDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	Func<int> GMBLLBFKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	Action<int> OJPFPMMGOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	Func<bool>? LDFCJMBNNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5060", Offset = "0x6E4460")]
	Func<int, string> ADADFGPCHIF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Action? MEKDDIDEACE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Action? ENCJFBDDKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	bool LNPKEHFHDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	bool DLIBBEGMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FKCACHHMMDF
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface NFHILMJFILE : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Func<string> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Action<string> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Action APGFNKIDHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	HOJILNMDAIE BELDJPAAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string IEPDIECINCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string DPEIIBNIGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FEKJIKOJAAD : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	FKCACHHMMDF BEGICPADGMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DOMKKPLCPEA : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int CDOLJBEMGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E50C0", Offset = "0x6E44C0")]
	Func<string, bool> HKPDNLHMEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	string? FOEHPPKAHCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	bool FFDAFDAGHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	HOJILNMDAIE BELDJPAAHJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Func<string> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Action<string> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface BBGLPJNKAAF : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Func<string> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Action<string> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	int? ECEEKNPPKML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool FFDAFDAGHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AOHNIHLLEHE : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x17000098")]
	Func<float> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Action<float> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	float DEEPIDEAAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float DGLFKGJFDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	Func<bool>? GHHOHBDAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	int KJBLPLMJDPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string GHAMIBGKOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	Func<float, float>? APMOKFMFPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Func<float, float>? CBLJJBAFBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PKMOHFJELOF : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Func<string> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	Action<string> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	int? ECEEKNPPKML
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool FFDAFDAGHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface IOLAOCBENOK : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string ELLLOODOFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface GFNDOGEOJAF : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	Func<bool> AFCPALBBJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	Action<bool> GDKKKCGHMLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	int LEEDLNNOGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Func<bool>? KLCHLKANACF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MIHDEOKMAOA : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	Dictionary<string, CPFMMOODPIE> ODOOPBEOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	Func<int> GMBLLBFKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Action<int> OJPFPMMGOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	string EOLBLONCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	string BKECOFAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	string JIOBLHCFGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	Action? MEKDDIDEACE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	Action? ENCJFBDDKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	Func<bool>? ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	Func<bool>? IJHFPMNCMPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5120", Offset = "0x6E4520")]
	Func<int, string> ADADFGPCHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	bool LNPKEHFHDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool DLIBBEGMGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	bool GJAFODIJMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6E5180", Offset = "0x6E4580")]
	Action<KAEBHALPJPD> ELCKGGPEAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IDEJGJOGGDC : FKCACHHMMDF
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	Func<bool> ODKHIHMAHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	Func<IReadOnlyList<object>> CIEALHKHLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	Func<object, string> HAKGDOKGAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string NEOMCMAALAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	Func<object> BNMKHPONJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	Action<object> BCGALDIPOGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum HOJILNMDAIE
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Custom
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
