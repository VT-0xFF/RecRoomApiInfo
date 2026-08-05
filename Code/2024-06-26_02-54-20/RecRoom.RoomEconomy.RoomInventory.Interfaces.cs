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
public class IFIAHCNBIMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly KCNDGGMGFHE NIANODPPPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long FGAKKPCAMNO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LOJJINOEKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E4F0", Offset = "0x6F9CAF0", VA = "0x186F9E4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E500", Offset = "0x6F9CB00", VA = "0x186F9E500")]
	public IFIAHCNBIMN(KCNDGGMGFHE HJBJAPKPPFA, long JPBPNOCHNLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KIIHFDECGHE
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
public interface AJMMJLEHDGO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	BGECMLEGDCD MHPGOGAFMNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GFLPBNMBKPD<GCELKBBLDEG> AKMIHPBBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GFLPBNMBKPD<Guid> PLEPNPFLPFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MLMADGFCCJE<JFILAKCHFBH, int> IJKMDKFHHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GFLPBNMBKPD<NOIBMNFKLNI> BNLLENEBKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GFLPBNMBKPD<long> PDBAKNIHGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BGECMLEGDCD FCCMPOPHBDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BGECMLEGDCD HBKCKFICFDD
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
	Task<PIJKHLBEMKP<GCELKBBLDEG, string>> FBGFMKIPNEI(long NBDDMFOIEKN, string LCLKDNPLMED, string LDFBANEAJLN, string BOAMEGEOPOJ, RoomInventoryItemProperties CLIGLABJMIA, byte ALHFHMDBPCO, int MKAJENPGJDK);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<PIJKHLBEMKP<GCELKBBLDEG, string>> ALNDODPBDPK(Guid GKJEIMGGPKK, [Optional] string LCLKDNPLMED, [Optional] string LDFBANEAJLN, [Optional] string BOAMEGEOPOJ, [Optional] List<long> CFEHBFMJIAH, [Optional] Dictionary<string, RoomInventoryTagClientProperties> PGIIJOGLGBP, [Optional] RoomInventoryItemProperties CLIGLABJMIA, [Optional] byte? ALHFHMDBPCO, [Optional] int? MKAJENPGJDK);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<PIJKHLBEMKP<bool, string>> CLILODOGPHO(Guid GKJEIMGGPKK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<GCELKBBLDEG> GMEFHDPMMNO();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<GCELKBBLDEG> MGDMMOBBAEB();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool ACMKDJBLDOD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool ABPCIFIJNEO(Guid GKJEIMGGPKK, [Out] GCELKBBLDEG JIOGILABEED);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool ADFJJPKFAKK(string LKEALDLFCFG, [Out] GCELKBBLDEG JIOGILABEED);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<JFILAKCHFBH> GLNPCINDOMB();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool EIMMLHDJGAF(Guid GKJEIMGGPKK, [Out] JFILAKCHFBH FBCGFDAHGAG);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? PIBFJMKIPEO(Guid GKJEIMGGPKK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> MADIEGGFNIF(NMCPPAKMEBO GOBKHJJOFMO, Guid GKJEIMGGPKK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<IFIAHCNBIMN> FBKIBPBFBEA(NMCPPAKMEBO GOBKHJJOFMO, Guid GKJEIMGGPKK, int IPAODJJPKNM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string FILADPJBEHP(KCNDGGMGFHE HJBJAPKPPFA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HGKBFMJNBCG();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<PIJKHLBEMKP<NOIBMNFKLNI, string>> LMNBNGGLIHO(long CGGEEFOECOK, RoomInventoryTagClientProperties CLIGLABJMIA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<PIJKHLBEMKP<bool, string>> FJPFMAJALNH(long CGGEEFOECOK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<PIJKHLBEMKP<bool, string>> JNNNINKKAEJ(long NBDDMFOIEKN, bool JMGHEKIBCCE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool DHOKEENJPHE();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	List<(long, int)> ELDALHBEDKI(long OAGNNAJEGLH, int LBDNLHMLDCI);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool IMICPBEOAKE(long CGGEEFOECOK, [Out] NOIBMNFKLNI MMGNBJNPEAE);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool HEFAPHMGKJG(long CGGEEFOECOK, Guid NNPJLHIPGFN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IReadOnlyList<NOIBMNFKLNI> KNBJMEBOEIP();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	List<NOIBMNFKLNI> CNONPEPDJLH();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<NOIBMNFKLNI> HNOJLILMPGF();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<GCELKBBLDEG> MFGFJBDCCGK(long CGGEEFOECOK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool PFBNCKKJAKE(string COBMFDEIHKE, [Out] IReadOnlyList<GCELKBBLDEG> HBILNOFIDKO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JIKBPHHPABM : AJMMJLEHDGO
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELLFHCMGDHJ(IEnumerable<MNPDJAJLPBF> OPJFAAHDLGN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GAJNBGJGKFP();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JFILAKCHFBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid OGGDDBEKMAF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E7B0", Offset = "0x6F9CDB0", VA = "0x186F9E7B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LOJJINOEKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E540", Offset = "0x6F9CB40", VA = "0x186F9E540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long EPPCJDBMKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86CEF0", Offset = "0x86B4F0", VA = "0x18086CEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long NCANLCONHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86DFE0", Offset = "0x86C5E0", VA = "0x18086DFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? FABMCJHLAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x867860", Offset = "0x865E60", VA = "0x180867860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x867840", Offset = "0x865E40", VA = "0x180867840")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KFPBLFEFADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA39B40", Offset = "0xA38140", VA = "0x180A39B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xEA45F0", Offset = "0xEA2BF0", VA = "0x180EA45F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E7C0", Offset = "0x6F9CDC0", VA = "0x186F9E7C0")]
	public JFILAKCHFBH(MNPDJAJLPBF GANLHKCENIN, bool OAOCHINLDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1D7BFC0", Offset = "0x1D7A5C0", VA = "0x181D7BFC0")]
	public JFILAKCHFBH(Guid GKJEIMGGPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E5C0", Offset = "0x6F9CBC0", VA = "0x186F9E5C0")]
	internal bool OMKLHJHPBJI(MNPDJAJLPBF GANLHKCENIN, long OOHCMEGEGFB, Action<JFILAKCHFBH, int> HMLAMGMCCLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E560", Offset = "0x6F9CB60", VA = "0x186F9E560")]
	internal void LFIJICLLKJG(long CODDNFELLLF, Action<JFILAKCHFBH, int> HMLAMGMCCLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GCELKBBLDEG : IEquatable<GCELKBBLDEG>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int DJKNOAAGAEO = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int ACJLHFCHDPA = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int NPLIKHLIJID = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int MEDMEDNPBHL = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int BNJBKGPFCPD = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid OGGDDBEKMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D4790", Offset = "0x8D2D90", VA = "0x1808D4790")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99AFD0", Offset = "0x9995D0", VA = "0x18099AFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long NLCEJDBODNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x107B940", Offset = "0x1079F40", VA = "0x18107B940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x866500", Offset = "0x864B00", VA = "0x180866500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string JJPCBIMLAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string JMLCMNHNFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86CF10", Offset = "0x86B510", VA = "0x18086CF10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime LHBEOHGEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86DC70", Offset = "0x86C270", VA = "0x18086DC70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1C94920", Offset = "0x1C92F20", VA = "0x181C94920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime HGADOGBAFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8689A0", Offset = "0x866FA0", VA = "0x1808689A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D81620", Offset = "0x5D7FC20", VA = "0x185D81620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> KGKLEJGACPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x863DF0", Offset = "0x8623F0", VA = "0x180863DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x863DC0", Offset = "0x8623C0", VA = "0x180863DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties EINIMGGADFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x863E10", Offset = "0x862410", VA = "0x180863E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x863E40", Offset = "0x862440", VA = "0x180863E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte FNDGDDEMKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8711F0", Offset = "0x86F7F0", VA = "0x1808711F0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8712E0", Offset = "0x86F8E0", VA = "0x1808712E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MFEJNOLPLDN POKBFINKFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEB4720", Offset = "0xEB2D20", VA = "0x180EB4720")]
		[CompilerGenerated]
		get
		{
			return default(MFEJNOLPLDN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xEB3880", Offset = "0xEB1E80", VA = "0x180EB3880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E390", Offset = "0x6F9C990", VA = "0x186F9E390")]
	public GCELKBBLDEG(LPOHEOFHIKI GANLHKCENIN, [Optional] RoomInventoryItemProperties CLIGLABJMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DC70", Offset = "0x6F9C270", VA = "0x186F9DC70", Slot = "4")]
	public bool Equals(GCELKBBLDEG LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DDF0", Offset = "0x6F9C3F0", VA = "0x186F9DDF0", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F9E2B0", Offset = "0x6F9C8B0", VA = "0x186F9E2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F9DFC0", Offset = "0x6F9C5C0", VA = "0x186F9DFC0")]
	private HashSet<long> GDKGPFFNDEH(LPOHEOFHIKI GANLHKCENIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OJMHAFGKAEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private JFILAKCHFBH FBCGFDAHGAG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GCELKBBLDEG EDLIDBBIAOM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JFILAKCHFBH OAMJBJLCEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EC90", Offset = "0x6F9D290", VA = "0x186F9EC90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F9ED20", Offset = "0x6F9D320", VA = "0x186F9ED20")]
	public OJMHAFGKAEO(GCELKBBLDEG JIOGILABEED, [Optional] JFILAKCHFBH FBCGFDAHGAG)
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
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6F9F300", Offset = "0x6F9D900", VA = "0x186F9F300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x867850", Offset = "0x865E50", VA = "0x180867850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x92FCB0", Offset = "0x92E2B0", VA = "0x18092FCB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB0EE90", Offset = "0xB0D490", VA = "0x180B0EE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KIIHFDECGHE Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8657F0", Offset = "0x863DF0", VA = "0x1808657F0")]
			[CompilerGenerated]
			get
			{
				return default(KIIHFDECGHE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x865080", Offset = "0x863680", VA = "0x180865080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCF94B0", Offset = "0xCF7AB0", VA = "0x180CF94B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4528460", Offset = "0x4526A60", VA = "0x184528460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA774A0", Offset = "0xA75AA0", VA = "0x180A774A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB50", Offset = "0xB49150", VA = "0x180B4AB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDF21E0", Offset = "0xDF07E0", VA = "0x180DF21E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDF1400", Offset = "0xDEFA00", VA = "0x180DF1400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F070", Offset = "0x6F9D670", VA = "0x186F9F070", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F0F0", Offset = "0x6F9D6F0", VA = "0x186F9F0F0")]
		public static RoomInventoryItemProperties FCBOIHHPCCD(RoomInventoryItemProperties CLIGLABJMIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F2A0", Offset = "0x6F9D8A0", VA = "0x186F9F2A0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NOIBMNFKLNI
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int BFDJHJAAGIA = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string AOMGJEHAJBF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder HCHGIBJNDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string LCDCOKPECFI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long GBGJCOCPEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x14FFCE0", Offset = "0x14FE2E0", VA = "0x1814FFCE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E870", Offset = "0x6F9CE70", VA = "0x186F9E870")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string BHHKKMMCCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E8C0", Offset = "0x6F9CEC0", VA = "0x186F9E8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties EINIMGGADFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x866500", Offset = "0x864B00", VA = "0x180866500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GMDLOKKMAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9E8A0", Offset = "0x6F9CEA0", VA = "0x186F9E8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public NOIBMNFKLNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB90", Offset = "0x6F9D190", VA = "0x186F9EB90")]
	public NOIBMNFKLNI(OBNHLKOEPIK GANLHKCENIN, [Optional] RoomInventoryTagClientProperties CLIGLABJMIA)
	{
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
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6F9F550", Offset = "0x6F9DB50", VA = "0x186F9F550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x867850", Offset = "0x865E50", VA = "0x180867850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F9F350", Offset = "0x6F9D950", VA = "0x186F9F350")]
		public void EJIPLBKIHMG(Dictionary<string, object> JCBKOPIMNEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
