using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KFGJNLIAHNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly OBDKPKCMBBN OMMOIDMJEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long JGJMKJIDNDK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CACAECFCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B01CB0", Offset = "0x8B010B0", VA = "0x188B01CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8B01CC0", Offset = "0x8B010C0", VA = "0x188B01CC0")]
	public KFGJNLIAHNO(OBDKPKCMBBN HJBCDFKDKBA, long PPNAGMANAKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HKIPBCLMECB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	HiddenWhenNone,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Hidden,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	AlwaysVisibleOnceOwned,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	AlwaysVisible
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface HGIIBAMIKMG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OFFOKCJIMNI BEBJGFOIPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BBKKNBJGBDM<OJPBKHOGCCD> OIOPHMDMBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BBKKNBJGBDM<Guid> BDFLLNDNNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NIFKGGOBKPN<EJOCNAPEDLD, int> MPJOHJIABCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BBKKNBJGBDM<LCMLIFLEICJ> BCDHPOPENKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BBKKNBJGBDM<long> APILLNNDJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OFFOKCJIMNI MFLNELMALNM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OFFOKCJIMNI HMGMPLAHNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<DGHPMJAIBNO<OJPBKHOGCCD, string>> OEMMPFJKKMK(Guid? KOEDADEEMCB, long DCONEHIDLCB, string HDNPPEBJPAE, string GMABBLIJJKB, string JDPAGNELAJI, RoomInventoryItemProperties GALOKDCMNPH, byte PDPKIFONADM, int IFBOGFLAOGG, [Optional] List<long> POCIFBHGJGK, [Optional] List<ENBKGOEFIJF> NAEOOFHFMCG, bool LDEHICOMJIF = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<DGHPMJAIBNO<OJPBKHOGCCD, string>> LLACNHOEGLK(Guid AHJKDKEADJN, long DCONEHIDLCB, [Optional] string HDNPPEBJPAE, [Optional] string GMABBLIJJKB, [Optional] string JDPAGNELAJI, [Optional] List<long> POCIFBHGJGK, [Optional] Dictionary<string, RoomInventoryTagClientProperties> NAEOOFHFMCG, [Optional] RoomInventoryItemProperties GALOKDCMNPH, [Optional] byte? PDPKIFONADM, [Optional] int? IFBOGFLAOGG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<DGHPMJAIBNO<bool, string>> IHCKGDOCAGM(Guid AHJKDKEADJN, long DCONEHIDLCB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<OJPBKHOGCCD> JHHFDCMPEGF();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<OJPBKHOGCCD> PEEAMLEEDAF();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool ABFIBDJODOC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool LBPIEBILAAO(Guid AHJKDKEADJN, [Out] OJPBKHOGCCD NIFOBEAHKML);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool PDDJNANGOPJ(string BKCFMANJMCI, [Out] OJPBKHOGCCD NIFOBEAHKML);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<EJOCNAPEDLD> DHGJNGKIJOM();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool FOLELDODOAI(Guid AHJKDKEADJN, [Out] EJOCNAPEDLD MGKBDPHONDL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? CPJLLIOKIKD(Guid AHJKDKEADJN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> CNJJGIEHJAN(NELIJLIGAOD NICGPJDLKCM, Guid AHJKDKEADJN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<KFGJNLIAHNO> AGCDLCLDOIC(NELIJLIGAOD NICGPJDLKCM, Guid AHJKDKEADJN, int CMFLOMKPDCN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string MJLHCNCNAAF(OBDKPKCMBBN HJBCDFKDKBA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HBPAGPEHNAH();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DOMGOCPPJBI LPJAJICGNJJ(OJPBKHOGCCD PHMKLCIPCAA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties CLKMEGNLDOJ(string MOEMOBEBFJH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<DGHPMJAIBNO<LCMLIFLEICJ, string>> OIEBHMEDPKN(long JFBBOAHPOJP, RoomInventoryTagClientProperties GALOKDCMNPH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<DGHPMJAIBNO<bool, string>> BEKHKOKIBFF(long JFBBOAHPOJP);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<DGHPMJAIBNO<bool, string>> DICGHLJNCKE(long DCONEHIDLCB, bool GJJCDLGLMED);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool KEDIDGHOALC();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> DEPCHBDDJMM(long FJDHNNGJPIA, int FPJBKAPDLPI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool AEKDELHMGEP(long JFBBOAHPOJP, [Out] LCMLIFLEICJ HGNANINGJJP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool IDBENCBHGLE(string HCLAAPKABBB, [Out] LCMLIFLEICJ HGNANINGJJP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool KIMBDEGJPAA(long JFBBOAHPOJP, Guid OMGLMKIDPGA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<LCMLIFLEICJ> CJALJPCNGJB();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<LCMLIFLEICJ> LKHEKIOCPPB();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<LCMLIFLEICJ> HIMNLILEACM();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<OJPBKHOGCCD> GIEAHABNNHG(long JFBBOAHPOJP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool ALPLJBPABFD(string HCLAAPKABBB, [Out] IReadOnlyList<OJPBKHOGCCD> CBOMOODEGOE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ABBKKMENHKL : HGIIBAMIKMG
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAKOOKLDLDA(IEnumerable<OEINNDAJNEG> HFEGJMLJMGE);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BHDNNAGBNEH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EJOCNAPEDLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid GJHBGEDEINF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B01610", Offset = "0x8B00A10", VA = "0x188B01610")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CACAECFCIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B015F0", Offset = "0x8B009F0", VA = "0x188B015F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long JJHLEPMGEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA70450", Offset = "0xA6F850", VA = "0x180A70450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long IINPBGALPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA7B820", Offset = "0xA7AC20", VA = "0x180A7B820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? CBGNDMAIBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1A0", Offset = "0xA6C5A0", VA = "0x180A6D1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D160", Offset = "0xA6C560", VA = "0x180A6D160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DHJAJFOEIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD24CE0", Offset = "0xD240E0", VA = "0x180D24CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD24080", Offset = "0xD23480", VA = "0x180D24080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8B01810", Offset = "0x8B00C10", VA = "0x188B01810")]
	public EJOCNAPEDLD(OEINNDAJNEG BOKAPJBFNLB, bool FIMOFECHCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10B98B0", Offset = "0x10B8CB0", VA = "0x1810B98B0")]
	public EJOCNAPEDLD(Guid AHJKDKEADJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8B01620", Offset = "0x8B00A20", VA = "0x188B01620")]
	internal bool OGELNPLKAMN(OEINNDAJNEG BOKAPJBFNLB, long OJOHCGMBDFB, Action<EJOCNAPEDLD, int> KNDPCFFCGDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8B01590", Offset = "0x8B00990", VA = "0x188B01590")]
	internal void AAHDLIBCOLG(long MELCPEMJIJA, Action<EJOCNAPEDLD, int> KNDPCFFCGDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OJPBKHOGCCD : IEquatable<OJPBKHOGCCD>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int AANGCEFDCBL = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int FKEEGCJGOPF = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int NOKICIINKNE = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int IGOIKIBFELF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int OAJFKFPNDLJ = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid GJHBGEDEINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE6E0A0", Offset = "0xE6D4A0", VA = "0x180E6E0A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long NMJFOBHOBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xDDB130", Offset = "0xDDA530", VA = "0x180DDB130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string GLHAEMONBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string POEEFANCFBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime LPGFJDBFKJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF78720", Offset = "0xF77B20", VA = "0x180F78720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime PGKBDGCPJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA70420", Offset = "0xA6F820", VA = "0x180A70420")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1394000", Offset = "0x1393400", VA = "0x181394000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> LLAJGPJNEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties IBKAFBPMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte JEJKJBLPDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA703C0", Offset = "0xA6F7C0", VA = "0x180A703C0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA70460", Offset = "0xA6F860", VA = "0x180A70460")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HOPHEEHHBNP LEHEPOAPIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xFB6750", Offset = "0xFB5B50", VA = "0x180FB6750")]
		[CompilerGenerated]
		get
		{
			return default(HOPHEEHHBNP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x301B940", Offset = "0x301AD40", VA = "0x18301B940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OJPBKHOGCCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8B02910", Offset = "0x8B01D10", VA = "0x188B02910")]
	public OJPBKHOGCCD(DOMGOCPPJBI BOKAPJBFNLB, [Optional] RoomInventoryItemProperties GALOKDCMNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8B023C0", Offset = "0x8B017C0", VA = "0x188B023C0", Slot = "4")]
	public bool Equals(OJPBKHOGCCD LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8B021E0", Offset = "0x8B015E0", VA = "0x188B021E0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8B02540", Offset = "0x8B01940", VA = "0x188B02540", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B02620", Offset = "0x8B01A20", VA = "0x188B02620")]
	private HashSet<long> HFKJBKDLLIL(DOMGOCPPJBI BOKAPJBFNLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EKMFKAMDGKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EJOCNAPEDLD MGKBDPHONDL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OJPBKHOGCCD GLEPEPKOGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EJOCNAPEDLD HNLGAPNECOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8B018C0", Offset = "0x8B00CC0", VA = "0x188B018C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8B01950", Offset = "0x8B00D50", VA = "0x188B01950")]
	public EKMFKAMDGKN(OJPBKHOGCCD NIFOBEAHKML, [Optional] EJOCNAPEDLD MGKBDPHONDL)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B02D10", Offset = "0x8B02110", VA = "0x188B02D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x12CA5C0", Offset = "0x12C99C0", VA = "0x1812CA5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x15C3F00", Offset = "0x15C3300", VA = "0x1815C3F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public HKIPBCLMECB Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			[CompilerGenerated]
			get
			{
				return default(HKIPBCLMECB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA72110", Offset = "0xA71510", VA = "0x180A72110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB259A0", Offset = "0xB24DA0", VA = "0x180B259A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xE55AD0", Offset = "0xE54ED0", VA = "0x180E55AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xF1F450", Offset = "0xF1E850", VA = "0x180F1F450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF1F460", Offset = "0xF1E860", VA = "0x180F1F460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8B02A70", Offset = "0x8B01E70", VA = "0x188B02A70", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8B02B00", Offset = "0x8B01F00", VA = "0x188B02B00")]
		public static RoomInventoryItemProperties JCIOENFMGMF(RoomInventoryItemProperties GALOKDCMNPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8B02CB0", Offset = "0x8B020B0", VA = "0x188B02CB0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LCMLIFLEICJ
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int CKODMLFGIJL = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string EFINADMOPDC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder GOOOMKPEOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string NANPEGNLJPH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EKFILPEIAGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xE54A90", Offset = "0xE53E90", VA = "0x180E54A90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8B01D00", Offset = "0x8B01100", VA = "0x188B01D00")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8B01D30", Offset = "0x8B01130", VA = "0x188B01D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties IBKAFBPMOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool EOINPOMAHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8B01F80", Offset = "0x8B01380", VA = "0x188B01F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LCMLIFLEICJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8B020E0", Offset = "0x8B014E0", VA = "0x188B020E0")]
	public LCMLIFLEICJ(ENBKGOEFIJF BOKAPJBFNLB, [Optional] RoomInventoryTagClientProperties GALOKDCMNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8B01FA0", Offset = "0x8B013A0", VA = "0x188B01FA0")]
	public ENBKGOEFIJF OLEAMPEAPAM()
	{
		return null;
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static RoomInventoryTagClientProperties DefaultNonSortingTab
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8B02F70", Offset = "0x8B02370", VA = "0x188B02F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8B02D60", Offset = "0x8B02160", VA = "0x188B02D60")]
		public void KKMIAPMGLGM(Dictionary<string, object> GILAAHLNHOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public RoomInventoryTagClientProperties()
		{
		}
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
