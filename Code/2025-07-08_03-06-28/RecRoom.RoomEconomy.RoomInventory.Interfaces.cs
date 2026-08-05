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
public class LNOMPKJPLNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly DPBEKDJAJPO PCINKEMPDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long OOJPJFMJCLH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BEBFIMKMFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88E6740", Offset = "0x88E5540", VA = "0x1888E6740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x88E6750", Offset = "0x88E5550", VA = "0x1888E6750")]
	public LNOMPKJPLNC(DPBEKDJAJPO OHLBIIOAJDL, long LJEIHABMGGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KAMJBHJNEHL
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
public interface GBGKLLOKACP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EPBKGABEMJJ CHIIMPKNEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IKLFNFDBNDM<AMEPEEKHNOD> ILFPIOKHJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IKLFNFDBNDM<Guid> HJMDAEMKMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HLGFIGBDGLB<PMOCMBLPNKD, int> IHMLFKHGHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IKLFNFDBNDM<CHIKFGPFPFF> PCHGAJHJEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IKLFNFDBNDM<long> MBCKBFCHJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EPBKGABEMJJ DIECAEINCPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EPBKGABEMJJ IPNAGKKLIIF
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
	Task<CKPFCFEHEPP<AMEPEEKHNOD, string>> IJEGIFOJPPA(Guid? DDHBDLPKMNF, long NCGHDDJNJOM, string GGDFKFACHGG, string BKPMFKNMLEK, string GKJABGINPJG, RoomInventoryItemProperties MDOGLHGIMLE, byte KDLDDCCMAJC, int PFKMCINIKNC, [Optional] List<long> BNBPGOMOHIP, [Optional] List<NOOLNGDNLKM> LHOOMDPEHPL, bool LHAPAKMCLNN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<CKPFCFEHEPP<AMEPEEKHNOD, string>> BBBIJNDOBKJ(Guid AAIJMNJDPLL, long NCGHDDJNJOM, [Optional] string GGDFKFACHGG, [Optional] string BKPMFKNMLEK, [Optional] string GKJABGINPJG, [Optional] List<long> BNBPGOMOHIP, [Optional] Dictionary<string, RoomInventoryTagClientProperties> LHOOMDPEHPL, [Optional] RoomInventoryItemProperties MDOGLHGIMLE, [Optional] byte? KDLDDCCMAJC, [Optional] int? PFKMCINIKNC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<CKPFCFEHEPP<bool, string>> DIMMHDFPMEJ(Guid AAIJMNJDPLL, long NCGHDDJNJOM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<AMEPEEKHNOD> EFJIJDDMJNM();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<AMEPEEKHNOD> BEIDHKLIOKO();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool HNMBJPNBOMO();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool HFHFLPIFGDH(Guid AAIJMNJDPLL, [Out] AMEPEEKHNOD MAAMKKOMBDG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool EPEAJNGKJPF(string KGMLPLKKEGJ, [Out] AMEPEEKHNOD MAAMKKOMBDG);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<PMOCMBLPNKD> KOKABMDNIOG();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool OIDBPODIBNF(Guid AAIJMNJDPLL, [Out] PMOCMBLPNKD CKELHPGIHJG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? APABFNEEDEA(Guid AAIJMNJDPLL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> MPONNMJDCHM(CDKFIILELLC IFADLDJHCLA, Guid AAIJMNJDPLL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<LNOMPKJPLNC> KNNDGLEEGNG(CDKFIILELLC IFADLDJHCLA, Guid AAIJMNJDPLL, int MFCGKLNJBDB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string GHMONHLCMDD(DPBEKDJAJPO OHLBIIOAJDL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool GFPBBBGGMMP();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CHOAPCPAOCL KLBEGFPAGMI(AMEPEEKHNOD PKACIKNEKOP);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties JIFNGMPNMLG(string CPCNLCNKDGH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<CKPFCFEHEPP<CHIKFGPFPFF, string>> DHAGODNCCPP(long LIHFKBBFOOJ, RoomInventoryTagClientProperties MDOGLHGIMLE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<CKPFCFEHEPP<bool, string>> KLIFMPGFHPO(long LIHFKBBFOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<CKPFCFEHEPP<bool, string>> FEGBFIIFMGL(long NCGHDDJNJOM, bool BCDEGMPHKHN);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool DHIDJIPOFJD();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> DKONJEBJCFK(long KIGLFFLNEID, int EOHPNNPBHHN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool HPLPDEGKFJA(long LIHFKBBFOOJ, [Out] CHIKFGPFPFF IDIOOCCIFDA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool FLFKGPNPEKG(string LEOAJNABENL, [Out] CHIKFGPFPFF IDIOOCCIFDA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool MFDJOKKFBKD(long LIHFKBBFOOJ, Guid OGJNGGHNBEL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<CHIKFGPFPFF> OOIBNGIBCLF();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<CHIKFGPFPFF> JHPBNCKNHJH();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<CHIKFGPFPFF> JIMGMIJLCCE();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<AMEPEEKHNOD> JFMGJKLMNPI(long LIHFKBBFOOJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HFFDOMCONGA(string LEOAJNABENL, [Out] IReadOnlyList<AMEPEEKHNOD> GODMEDEKGJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FJJICPEIJHK : GBGKLLOKACP
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGLOJHLCHJA(IEnumerable<GHICLFGLALC> NGJHFCCPCJN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JEILKJEAFEK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PMOCMBLPNKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid AJFIHOCJHNB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88E6B80", Offset = "0x88E5980", VA = "0x1888E6B80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BEBFIMKMFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88E6DE0", Offset = "0x88E5BE0", VA = "0x1888E6DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long KAHGHFCABOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA60490", Offset = "0xA5F290", VA = "0x180A60490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long ODOIONNDIHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF90", Offset = "0xA5AD90", VA = "0x180A5BF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? PIJAINMHIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA5A400", Offset = "0xA59200", VA = "0x180A5A400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA5A460", Offset = "0xA59260", VA = "0x180A5A460")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MKDDCHLPCMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD16540", Offset = "0xD15340", VA = "0x180D16540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD16010", Offset = "0xD14E10", VA = "0x180D16010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x88E6E00", Offset = "0x88E5C00", VA = "0x1888E6E00")]
	public PMOCMBLPNKD(GHICLFGLALC DCLMMNDJBGH, bool MBEHEBBHCPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1088200", Offset = "0x1087000", VA = "0x181088200")]
	public PMOCMBLPNKD(Guid AAIJMNJDPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x88E6B90", Offset = "0x88E5990", VA = "0x1888E6B90")]
	internal bool FLCGEBIGNJN(GHICLFGLALC DCLMMNDJBGH, long GCAGOGOBGDM, Action<PMOCMBLPNKD, int> MFPBPHPEIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x88E6D80", Offset = "0x88E5B80", VA = "0x1888E6D80")]
	internal void HEEOBOPMCCG(long KBCIDHEAMCE, Action<PMOCMBLPNKD, int> MFPBPHPEIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AMEPEEKHNOD : IEquatable<AMEPEEKHNOD>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int GFHEDKEPNHF = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int PCAJJEKOEDM = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int OFKOLOCABLJ = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int KKDKOLMBCPJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int EDPMMCBIJMH = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid AJFIHOCJHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDD0", Offset = "0xE4ABD0", VA = "0x180E4BDD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE4BDE0", Offset = "0xE4ABE0", VA = "0x180E4BDE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long NBAAIIHONBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xDD1BC0", Offset = "0xDD09C0", VA = "0x180DD1BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string CPNIMADMGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string POFMCMPHBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime CAJCMCPBANE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF56D00", Offset = "0xF55B00", VA = "0x180F56D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime KDHHKJDAOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA604A0", Offset = "0xA5F2A0", VA = "0x180A604A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x72C3E80", Offset = "0x72C2C80", VA = "0x1872C3E80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> EAKAOMCOFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA5F3A0", Offset = "0xA5E1A0", VA = "0x180A5F3A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties FEAKJLPCOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA5F330", Offset = "0xA5E130", VA = "0x180A5F330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA5F370", Offset = "0xA5E170", VA = "0x180A5F370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte MICPALLACDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA604E0", Offset = "0xA5F2E0", VA = "0x180A604E0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA60420", Offset = "0xA5F220", VA = "0x180A60420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AOKFBPFAEAA JEKBJHDPEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xF993A0", Offset = "0xF981A0", VA = "0x180F993A0")]
		[CompilerGenerated]
		get
		{
			return default(AOKFBPFAEAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2F30360", Offset = "0x2F2F160", VA = "0x182F30360")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public AMEPEEKHNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x88E6100", Offset = "0x88E4F00", VA = "0x1888E6100")]
	public AMEPEEKHNOD(CHOAPCPAOCL DCLMMNDJBGH, [Optional] RoomInventoryItemProperties MDOGLHGIMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x88E59E0", Offset = "0x88E47E0", VA = "0x1888E59E0", Slot = "4")]
	public bool Equals(AMEPEEKHNOD LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x88E5B60", Offset = "0x88E4960", VA = "0x1888E5B60", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x88E5D30", Offset = "0x88E4B30", VA = "0x1888E5D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x88E5E10", Offset = "0x88E4C10", VA = "0x1888E5E10")]
	private HashSet<long> JEEPNBCMPDG(CHOAPCPAOCL DCLMMNDJBGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NJCFJHPFBLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PMOCMBLPNKD CKELHPGIHJG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AMEPEEKHNOD BIDEIKBFHHM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PMOCMBLPNKD ECEEBCJFBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88E6790", Offset = "0x88E5590", VA = "0x1888E6790")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88E6820", Offset = "0x88E5620", VA = "0x1888E6820")]
	public NJCFJHPFBLP(AMEPEEKHNOD MAAMKKOMBDG, [Optional] PMOCMBLPNKD CKELHPGIHJG)
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
			[Cpp2IlInjected.Address(RVA = "0x88E7150", Offset = "0x88E5F50", VA = "0x1888E7150")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1272A30", Offset = "0x1271830", VA = "0x181272A30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x15685B0", Offset = "0x15673B0", VA = "0x1815685B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KAMJBHJNEHL Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA5E620", Offset = "0xA5D420", VA = "0x180A5E620")]
			[CompilerGenerated]
			get
			{
				return default(KAMJBHJNEHL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA5E630", Offset = "0xA5D430", VA = "0x180A5E630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB0D250", Offset = "0xB0C050", VA = "0x180B0D250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xE42BA0", Offset = "0xE419A0", VA = "0x180E42BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xABC810", Offset = "0xABB610", VA = "0x180ABC810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xABC540", Offset = "0xABB340", VA = "0x180ABC540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xEBA790", Offset = "0xEB9590", VA = "0x180EBA790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xEBA7C0", Offset = "0xEB95C0", VA = "0x180EBA7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88E6FA0", Offset = "0x88E5DA0", VA = "0x1888E6FA0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x88E6EB0", Offset = "0x88E5CB0", VA = "0x1888E6EB0")]
		public static RoomInventoryItemProperties AJBMEKOGIKE(RoomInventoryItemProperties MDOGLHGIMLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88E70F0", Offset = "0x88E5EF0", VA = "0x1888E70F0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CHIKFGPFPFF
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int AEPNKEKOGMF = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string BJLKJAIHIAL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder DIHBHIOLOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string JPIJOOEOEHB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long PCCGIGAOFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xE319C0", Offset = "0xE307C0", VA = "0x180E319C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string OFMLOIDKMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88E6260", Offset = "0x88E5060", VA = "0x1888E6260")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string HAPNNFMFLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x88E6370", Offset = "0x88E5170", VA = "0x1888E6370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties FEAKJLPCOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JBLMADJGKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x88E6290", Offset = "0x88E5090", VA = "0x1888E6290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public CHIKFGPFPFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x88E6640", Offset = "0x88E5440", VA = "0x1888E6640")]
	public CHIKFGPFPFF(NOOLNGDNLKM DCLMMNDJBGH, [Optional] RoomInventoryTagClientProperties MDOGLHGIMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x88E62B0", Offset = "0x88E50B0", VA = "0x1888E62B0")]
	public NOOLNGDNLKM DOHPGLNIKPE()
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
			[Cpp2IlInjected.Address(RVA = "0x88E73B0", Offset = "0x88E61B0", VA = "0x1888E73B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x88E71A0", Offset = "0x88E5FA0", VA = "0x1888E71A0")]
		public void MBEGFACMNCK(Dictionary<string, object> DGMJKJCCJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
