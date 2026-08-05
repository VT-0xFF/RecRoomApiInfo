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
public class GGGFGHNNKFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly IDKKHNLBKPN BPBOPAKJOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long ECPNGLCMABA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HPAOPDJLAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D4C0E0", Offset = "0x7D4B4E0", VA = "0x187D4C0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C0F0", Offset = "0x7D4B4F0", VA = "0x187D4C0F0")]
	public GGGFGHNNKFA(IDKKHNLBKPN HOCIBOCHCFJ, long LOHPPDCIAAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FOFBDJLEJEB
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
public interface BAFMPMOEKPI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EBGLFEEDNOA FOEGJEHJOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CLNABAPAGFB<OKOHAGDCOFJ> PGJPLJAABKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CLNABAPAGFB<Guid> ACCMPLEDOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EIILHECILIH<EIAAPGDMDML, int> FEDPONJKKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CLNABAPAGFB<AGOBGFJPKHI> HLONLBHCMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CLNABAPAGFB<long> JKNMMCGPBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EBGLFEEDNOA ONJGGIEAFPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EBGLFEEDNOA OHPGCGDPCHD
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
	Task<PHLGGJNOBDN<OKOHAGDCOFJ, string>> NPFJDFJMEOC(Guid? HALIPHNIKFM, long LFNEDMLHPHM, string OGOCCCFKJPG, string APDEKOCIEGN, string HOKKCOHJBLO, RoomInventoryItemProperties HLDJDBBCDFE, byte JEMGJFMDIND, int MLLLJKFOPGI, [Optional] List<long> DLPLIBLMKPP, [Optional] List<NFGLDBPDBIA> EOKBPHDHNIN, bool POIICBHNJFL = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<PHLGGJNOBDN<OKOHAGDCOFJ, string>> FOOFEHJCPAL(Guid DBIKJCKLGJN, long LFNEDMLHPHM, [Optional] string OGOCCCFKJPG, [Optional] string APDEKOCIEGN, [Optional] string HOKKCOHJBLO, [Optional] List<long> DLPLIBLMKPP, [Optional] Dictionary<string, RoomInventoryTagClientProperties> EOKBPHDHNIN, [Optional] RoomInventoryItemProperties HLDJDBBCDFE, [Optional] byte? JEMGJFMDIND, [Optional] int? MLLLJKFOPGI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<PHLGGJNOBDN<bool, string>> FABEALJJGPI(Guid DBIKJCKLGJN, long LFNEDMLHPHM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<OKOHAGDCOFJ> FDHFMFKBHNM();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<OKOHAGDCOFJ> MCLLNPIJNKI();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CADGEKIHDPP();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool CDNIBLCDJMP(Guid DBIKJCKLGJN, [Out] OKOHAGDCOFJ GFPLLMDAAJO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool JACFCAANCIJ(string PCGAKMEBBGG, [Out] OKOHAGDCOFJ GFPLLMDAAJO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<EIAAPGDMDML> NEDCMKMEPCA();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool DAJHEIEADMI(Guid DBIKJCKLGJN, [Out] EIAAPGDMDML FHHBOLGLNAN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? MOMLFHDKFAB(Guid DBIKJCKLGJN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> BNJPMGHGAPF(NOFCMGEHFOO EMIBCBKNENI, Guid DBIKJCKLGJN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<GGGFGHNNKFA> NCOBMOPOMOE(NOFCMGEHFOO EMIBCBKNENI, Guid DBIKJCKLGJN, int PNOHIDJABCO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string MAGHMACLLMI(IDKKHNLBKPN HOCIBOCHCFJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool MOMCPDCIMKA();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	HIDOKHPKHNE CNHCHKGHFOA(OKOHAGDCOFJ GHCACHCCMKC);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties MOHJIOFBGNL(string MFDLOLMCNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<PHLGGJNOBDN<AGOBGFJPKHI, string>> KNPDBKLGCPE(long ADBLEABBGCD, RoomInventoryTagClientProperties HLDJDBBCDFE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<PHLGGJNOBDN<bool, string>> PDCGNAKEINL(long ADBLEABBGCD);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<PHLGGJNOBDN<bool, string>> DPJAIPFEIJK(long LFNEDMLHPHM, bool BNJJNNEIELM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool EMKKLONBPEC();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> COPLPKGGNFP(long OHMDJKPIIBF, int BJAPMAPLPHN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool DMMBELAJOCD(long ADBLEABBGCD, [Out] AGOBGFJPKHI DLPICPHHOFK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool MDCBMGNGFKG(string IJJGNDDLFHP, [Out] AGOBGFJPKHI DLPICPHHOFK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool JCIJIMIGNID(long ADBLEABBGCD, Guid FEDOIKLPCNH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<AGOBGFJPKHI> NONNDFJLGMN();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<AGOBGFJPKHI> FFCNKDJFPCF();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<AGOBGFJPKHI> FDDBLIAPLIG();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<OKOHAGDCOFJ> HELIEPMEPLG(long ADBLEABBGCD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HNAABBDNDHE(string IJJGNDDLFHP, [Out] IReadOnlyList<OKOHAGDCOFJ> PAKOALGOAEC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OOBCAMMODJN : BAFMPMOEKPI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEALIOHODFO(IEnumerable<AONAEAACPIK> IBPIBHNFHDH);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KKCHIIOJMCN();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EIAAPGDMDML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid CDBPBFHMDPE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D4BE10", Offset = "0x7D4B210", VA = "0x187D4BE10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HPAOPDJLAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D4BE20", Offset = "0x7D4B220", VA = "0x187D4BE20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long IKAKIFIGNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x96A780", Offset = "0x969B80", VA = "0x18096A780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long GKMNNFAKIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x96FCD0", Offset = "0x96F0D0", VA = "0x18096FCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? LCNBBBDBLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x968300", Offset = "0x967700", VA = "0x180968300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x968320", Offset = "0x967720", VA = "0x180968320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OGJIJJIHJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAFAB30", Offset = "0xAF9F30", VA = "0x180AFAB30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAFA160", Offset = "0xAF9560", VA = "0x180AFA160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C030", Offset = "0x7D4B430", VA = "0x187D4C030")]
	public EIAAPGDMDML(AONAEAACPIK PBDJMOPICGO, bool EPALAEIPBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xE31650", Offset = "0xE30A50", VA = "0x180E31650")]
	public EIAAPGDMDML(Guid DBIKJCKLGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BE40", Offset = "0x7D4B240", VA = "0x187D4BE40")]
	internal bool PCKKFECIKBA(AONAEAACPIK PBDJMOPICGO, long KAFOOAFINAL, Action<EIAAPGDMDML, int> NKLDKFLEHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BDB0", Offset = "0x7D4B1B0", VA = "0x187D4BDB0")]
	internal void BJAAKBOGMBP(long MEIMJMCMFPA, Action<EIAAPGDMDML, int> NKLDKFLEHGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OKOHAGDCOFJ : IEquatable<OKOHAGDCOFJ>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int EGGLEBLKCOH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int FCJCHLFICBG = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int CKBPFDBOBDB = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int CEIIDIBPGCJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int NDIAALJGOHI = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid CDBPBFHMDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xB40EB0", Offset = "0xB402B0", VA = "0x180B40EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long CIKKOOKDCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xBB5B80", Offset = "0xBB4F80", VA = "0x180BB5B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string FEBGHFLEEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string OMJFCELBHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x96A710", Offset = "0x969B10", VA = "0x18096A710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime CPPDNFPLFEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD32860", Offset = "0xD31C60", VA = "0x180D32860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime BOAMNHKJNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969B20", VA = "0x18096A720")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x68FE7A0", Offset = "0x68FDBA0", VA = "0x1868FE7A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> KDNCKJENNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9642D0", Offset = "0x9636D0", VA = "0x1809642D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties DPLJPGHBNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9642C0", Offset = "0x9636C0", VA = "0x1809642C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9642E0", Offset = "0x9636E0", VA = "0x1809642E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte NGGLPJFNINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x96E0B0", Offset = "0x96D4B0", VA = "0x18096E0B0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x96E1C0", Offset = "0x96D5C0", VA = "0x18096E1C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KJLMKLABEMK HCJHNHMBDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xD50460", Offset = "0xD4F860", VA = "0x180D50460")]
		[CompilerGenerated]
		get
		{
			return default(KJLMKLABEMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C90", Offset = "0x2A83090", VA = "0x182A83C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public OKOHAGDCOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7D4CC40", Offset = "0x7D4C040", VA = "0x187D4CC40")]
	public OKOHAGDCOFJ(HIDOKHPKHNE PBDJMOPICGO, [Optional] RoomInventoryItemProperties HLDJDBBCDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C510", Offset = "0x7D4B910", VA = "0x187D4C510", Slot = "4")]
	public bool Equals(OKOHAGDCOFJ MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C690", Offset = "0x7D4BA90", VA = "0x187D4C690", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C870", Offset = "0x7D4BC70", VA = "0x187D4C870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C950", Offset = "0x7D4BD50", VA = "0x187D4C950")]
	private HashSet<long> NDLBGPCCDOO(HIDOKHPKHNE PBDJMOPICGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class LKEADMIBJIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EIAAPGDMDML FHHBOLGLNAN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OKOHAGDCOFJ DDMIJDAICHE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EIAAPGDMDML OFBOLDBJHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7D4C130", Offset = "0x7D4B530", VA = "0x187D4C130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7D4C1C0", Offset = "0x7D4B5C0", VA = "0x187D4C1C0")]
	public LKEADMIBJIJ(OKOHAGDCOFJ GFPLLMDAAJO, [Optional] EIAAPGDMDML FHHBOLGLNAN)
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
			[Cpp2IlInjected.Address(RVA = "0x7D4D040", Offset = "0x7D4C440", VA = "0x187D4D040")]
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
			[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xFD32B0", Offset = "0xFD26B0", VA = "0x180FD32B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x11CBC00", Offset = "0x11CB000", VA = "0x1811CBC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public FOFBDJLEJEB Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0")]
			[CompilerGenerated]
			get
			{
				return default(FOFBDJLEJEB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x973060", Offset = "0x972460", VA = "0x180973060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9C4090", Offset = "0x9C3490", VA = "0x1809C4090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xC0E4B0", Offset = "0xC0D8B0", VA = "0x180C0E4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCEB250", Offset = "0xCEA650", VA = "0x180CEB250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCEB370", Offset = "0xCEA770", VA = "0x180CEB370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xCEB260", Offset = "0xCEA660", VA = "0x180CEB260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D4CDA0", Offset = "0x7D4C1A0", VA = "0x187D4CDA0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D4CE30", Offset = "0x7D4C230", VA = "0x187D4CE30")]
		public static RoomInventoryItemProperties ILDFNOMPHGD(RoomInventoryItemProperties HLDJDBBCDFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7D4CFE0", Offset = "0x7D4C3E0", VA = "0x187D4CFE0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AGOBGFJPKHI
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int BKNKPPCEECH = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string FNDJMLKJIFL;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder FNIFCONMAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string BNIDPGOPIEK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DJAIGBIHEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xC09EF0", Offset = "0xC092F0", VA = "0x180C09EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string NAMECGEJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B9D0", Offset = "0x7D4ADD0", VA = "0x187D4B9D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string ADEJLEBKGFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D4BA00", Offset = "0x7D4AE00", VA = "0x187D4BA00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties DPLJPGHBNFL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool BGBHIIIAFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D4B9B0", Offset = "0x7D4ADB0", VA = "0x187D4B9B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public AGOBGFJPKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7D4BCC0", Offset = "0x7D4B0C0", VA = "0x187D4BCC0")]
	public AGOBGFJPKHI(NFGLDBPDBIA PBDJMOPICGO, [Optional] RoomInventoryTagClientProperties HLDJDBBCDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7D4B8F0", Offset = "0x7D4ACF0", VA = "0x187D4B8F0")]
	public NFGLDBPDBIA EECMNLBHAFO()
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
			[Cpp2IlInjected.Address(RVA = "0x7D4D2A0", Offset = "0x7D4C6A0", VA = "0x187D4D2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D090", Offset = "0x7D4C490", VA = "0x187D4D090")]
		public void OMAAJBBJKHJ(Dictionary<string, object> PHFFPFNJLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
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
