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
public class ILFHIPDFCHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MCAKCACOAIP KLAGANJLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long FBDCOBNEAFE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HMMBHBOOMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x828B9D0", Offset = "0x828ADD0", VA = "0x18828B9D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x828B9E0", Offset = "0x828ADE0", VA = "0x18828B9E0")]
	public ILFHIPDFCHM(MCAKCACOAIP APLCGCDLEGH, long PCGLBCNIEAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum COFHMJBBKMF
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
public interface NLKBHDMFNDB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KFBDEOPEKLE EFBCPOFBFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MAAICPKGELE<NJEGMICCCFM> HHOLMJGILPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	MAAICPKGELE<Guid> DKMBBPEPGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DEBGLLPOJFA<MIDPFMHDKDL, int> GEGGINNNMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MAAICPKGELE<HIDKFEEDPJI> JJNBAKFMGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MAAICPKGELE<long> OKFHLHHGODF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KFBDEOPEKLE IDJKDOEGNHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	KFBDEOPEKLE NLDALADODCL
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
	Task<BECHBBIPIFM<NJEGMICCCFM, string>> MMOOPDEMPAO(Guid? GOPEMOLHOBL, long NFMLPECGLEO, string KCCMEIDBNGP, string IKFIIFEGFHM, string FMJPEADOCOC, RoomInventoryItemProperties OMHDOHEIEHP, byte BLJJLAFHKPA, int JLFKDHGAEDA, [Optional] List<long> LLBPLMMMOPA, [Optional] List<IEBMNNPBBNJ> DCLIILECBPN, bool FIHAPEEKPMN = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<BECHBBIPIFM<NJEGMICCCFM, string>> NBLCDLJEKHK(Guid ACJKKOJOHFL, long NFMLPECGLEO, [Optional] string KCCMEIDBNGP, [Optional] string IKFIIFEGFHM, [Optional] string FMJPEADOCOC, [Optional] List<long> LLBPLMMMOPA, [Optional] Dictionary<string, RoomInventoryTagClientProperties> DCLIILECBPN, [Optional] RoomInventoryItemProperties OMHDOHEIEHP, [Optional] byte? BLJJLAFHKPA, [Optional] int? JLFKDHGAEDA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<BECHBBIPIFM<bool, string>> NBGIPCHFOHL(Guid ACJKKOJOHFL, long NFMLPECGLEO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<NJEGMICCCFM> CNPKFGJCINK();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<NJEGMICCCFM> JBJOBHIAFCO();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool BFBNJBFHBFB();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool KNPJIMAEBEF(Guid ACJKKOJOHFL, [Out] NJEGMICCCFM KOLDOGPPEJC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool MIBCOOANGAG(string GNOLFDJDGCJ, [Out] NJEGMICCCFM KOLDOGPPEJC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<MIDPFMHDKDL> DAKOHHDDLPE();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool DFHFPPKELGG(Guid ACJKKOJOHFL, [Out] MIDPFMHDKDL IAHGGBDHKNI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? KDAIBMNCICL(Guid ACJKKOJOHFL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> GEFEALHLCAA(EKIKILMCLIO PCGEDHPAHKB, Guid ACJKKOJOHFL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<ILFHIPDFCHM> BNGGPEFPENA(EKIKILMCLIO PCGEDHPAHKB, Guid ACJKKOJOHFL, int MDJBHEDHFND);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string NIDKHBAFANI(MCAKCACOAIP APLCGCDLEGH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool IPAGKAHODLJ();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NHMBNHFJHMI JBIBLHLDBKH(NJEGMICCCFM AFCOLPDLGLK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties GGPJLOHCMNC(string BKBLGGDNAGJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<BECHBBIPIFM<HIDKFEEDPJI, string>> NPFHCHNBPKK(long LCFNMOPINPI, RoomInventoryTagClientProperties OMHDOHEIEHP);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<BECHBBIPIFM<bool, string>> EMLKKKKJMOB(long LCFNMOPINPI);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<BECHBBIPIFM<bool, string>> NFNILLFOLGD(long NFMLPECGLEO, bool PFGFLAGNGML);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool JNDPCDCONJE();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> GHGONJALMOP(long JBGNCDODLJF, int LCKJLCNLBBF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool JBMJBDBADFI(long LCFNMOPINPI, [Out] HIDKFEEDPJI LHLKCJMMOKA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool MAACMCMFKIL(string FENPBMGLFLE, [Out] HIDKFEEDPJI LHLKCJMMOKA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool OEJFLJOGBBL(long LCFNMOPINPI, Guid PKJBFOIPMBL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<HIDKFEEDPJI> BELAHAJBHGI();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<HIDKFEEDPJI> GPLHOPBKJOG();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<HIDKFEEDPJI> JIHOMDOAKJA();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<NJEGMICCCFM> OGCBDOIEPFF(long LCFNMOPINPI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool CJIGIGIECHI(string FENPBMGLFLE, [Out] IReadOnlyList<NJEGMICCCFM> GNNNNCIMAEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JJIENHKKGGF : NLKBHDMFNDB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JABGEBOKJHL(IEnumerable<EHMPLFHOGOK> OCBHEEPPKAI);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BLIOJFMDAMC();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MIDPFMHDKDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid FEDHBCAOOIL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long FBDCOBNEAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x828BC90", Offset = "0x828B090", VA = "0x18828BC90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int HMMBHBOOMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x828BA80", Offset = "0x828AE80", VA = "0x18828BA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long BAGLJFBBHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C9220", Offset = "0x9C8620", VA = "0x1809C9220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long MCFGAFBICHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9D9490", Offset = "0x9D8890", VA = "0x1809D9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? FJGOFLEMEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD00", Offset = "0x9CF100", VA = "0x1809CFD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCF0", Offset = "0x9CF0F0", VA = "0x1809CFCF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PLIDOMPKEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBBB7C0", Offset = "0xBBABC0", VA = "0x180BBB7C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xBBAB60", Offset = "0xBB9F60", VA = "0x180BBAB60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x828BCA0", Offset = "0x828B0A0", VA = "0x18828BCA0")]
	public MIDPFMHDKDL(EHMPLFHOGOK APHOHOAKPPE, bool CHGFJECCLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xEFF6F0", Offset = "0xEFEAF0", VA = "0x180EFF6F0")]
	public MIDPFMHDKDL(Guid ACJKKOJOHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x828BAA0", Offset = "0x828AEA0", VA = "0x18828BAA0")]
	internal bool LFKOACHICEI(EHMPLFHOGOK APHOHOAKPPE, long HBNHPFGGMPI, Action<MIDPFMHDKDL, int> DKNPEEKCNNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x828BA20", Offset = "0x828AE20", VA = "0x18828BA20")]
	internal void AGHFJDFAFDP(long KFCONOKAMLC, Action<MIDPFMHDKDL, int> DKNPEEKCNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NJEGMICCCFM : IEquatable<NJEGMICCCFM>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int MOCALOGEEFM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int LFKFOGJEFAK = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int DELBFFFPCMJ = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int HHHDGPPGAPF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int ONIGNKOHGAN = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid FEDHBCAOOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEFF6E0", Offset = "0xEFEAE0", VA = "0x180EFF6E0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xEFF440", Offset = "0xEFE840", VA = "0x180EFF440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long OOPNDDKBIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xC628F0", Offset = "0xC61CF0", VA = "0x180C628F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string DBONIOPGFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string AJINEAMGDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime EIGFAOKHJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xDF2840", Offset = "0xDF1C40", VA = "0x180DF2840")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime MGFOPDNDGAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9C9450", Offset = "0x9C8850", VA = "0x1809C9450")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6D73370", Offset = "0x6D72770", VA = "0x186D73370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> KCFKGDCBIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7E0", Offset = "0x9CCBE0", VA = "0x1809CD7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties LNGEDENAKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9CD810", Offset = "0x9CCC10", VA = "0x1809CD810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7F0", Offset = "0x9CCBF0", VA = "0x1809CD7F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte IEGMGFMIGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9CE3A0", Offset = "0x9CD7A0", VA = "0x1809CE3A0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9CE370", Offset = "0x9CD770", VA = "0x1809CE370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ADLIHGEBFFL GCPEOPHCDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xE36D50", Offset = "0xE36150", VA = "0x180E36D50")]
		[CompilerGenerated]
		get
		{
			return default(ADLIHGEBFFL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2BE58F0", Offset = "0x2BE4CF0", VA = "0x182BE58F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public NJEGMICCCFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x828C470", Offset = "0x828B870", VA = "0x18828C470")]
	public NJEGMICCCFM(NHMBNHFJHMI APHOHOAKPPE, [Optional] RoomInventoryItemProperties OMHDOHEIEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x828BD50", Offset = "0x828B150", VA = "0x18828BD50", Slot = "4")]
	public bool Equals(NJEGMICCCFM DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x828BED0", Offset = "0x828B2D0", VA = "0x18828BED0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x828C0A0", Offset = "0x828B4A0", VA = "0x18828C0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x828C180", Offset = "0x828B580", VA = "0x18828C180")]
	private HashSet<long> LHOCLKLNFGF(NHMBNHFJHMI APHOHOAKPPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EPFGIKHOOIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MIDPFMHDKDL IAHGGBDHKNI;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public NJEGMICCCFM KJGHAINGMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MIDPFMHDKDL FGPCHPLOBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x828B100", Offset = "0x828A500", VA = "0x18828B100")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x828B190", Offset = "0x828A590", VA = "0x18828B190")]
	public EPFGIKHOOIH(NJEGMICCCFM KOLDOGPPEJC, [Optional] MIDPFMHDKDL IAHGGBDHKNI)
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
			[Cpp2IlInjected.Address(RVA = "0x828C870", Offset = "0x828BC70", VA = "0x18828C870")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x10AE5A0", Offset = "0x10AD9A0", VA = "0x1810AE5A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x12CA900", Offset = "0x12C9D00", VA = "0x1812CA900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public COFHMJBBKMF Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
			[CompilerGenerated]
			get
			{
				return default(COFHMJBBKMF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9D75F0", Offset = "0x9D69F0", VA = "0x1809D75F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA28FD0", Offset = "0xA283D0", VA = "0x180A28FD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7D10", Offset = "0xCE7110", VA = "0x180CE7D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD74840", Offset = "0xD73C40", VA = "0x180D74840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D8A0", Offset = "0xA6CCA0", VA = "0x180A6D8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xD74860", Offset = "0xD73C60", VA = "0x180D74860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xD74850", Offset = "0xD73C50", VA = "0x180D74850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x828C5D0", Offset = "0x828B9D0", VA = "0x18828C5D0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x828C660", Offset = "0x828BA60", VA = "0x18828C660")]
		public static RoomInventoryItemProperties LEEDLDCPNEM(RoomInventoryItemProperties OMHDOHEIEHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x828C810", Offset = "0x828BC10", VA = "0x18828C810")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HIDKFEEDPJI
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int GAHKMPFGPON = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string ICKGLOLEKEM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder ODOLIIEAPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string OBKILKKIKMB;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long HKFMIDANKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xCCDC70", Offset = "0xCCD070", VA = "0x180CCDC70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x828B820", Offset = "0x828AC20", VA = "0x18828B820")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string ODEDFFJLGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x828B5D0", Offset = "0x828A9D0", VA = "0x18828B5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties LNGEDENAKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool EDHGNCPFIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x828B4F0", Offset = "0x828A8F0", VA = "0x18828B4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HIDKFEEDPJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x828B8D0", Offset = "0x828ACD0", VA = "0x18828B8D0")]
	public HIDKFEEDPJI(IEBMNNPBBNJ APHOHOAKPPE, [Optional] RoomInventoryTagClientProperties OMHDOHEIEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x828B510", Offset = "0x828A910", VA = "0x18828B510")]
	public IEBMNNPBBNJ DJLHFDJDNPM()
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
			[Cpp2IlInjected.Address(RVA = "0x828CAD0", Offset = "0x828BED0", VA = "0x18828CAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x828C8C0", Offset = "0x828BCC0", VA = "0x18828C8C0")]
		public void FHJPHKBIOKA(Dictionary<string, object> EMPFLIOAEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
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
