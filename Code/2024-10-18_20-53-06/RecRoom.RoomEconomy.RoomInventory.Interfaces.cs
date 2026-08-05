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
public class KAGOAHBGBNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MEMHEIJFJKL ECALPEPLJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long ICBOPDBFFOG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ANNIGLKNIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7478100", Offset = "0x7477500", VA = "0x187478100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7478110", Offset = "0x7477510", VA = "0x187478110")]
	public KAGOAHBGBNE(MEMHEIJFJKL IPNDOKDOGDG, long HMELIAGANNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PMIOIPGJFGC
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
public interface OCFCLMGPDKC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LDNMACGBDLI ODNEANPALFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	PJFDJKKNHLD<CEDJELAJNBK> KGIFGPFADFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	PJFDJKKNHLD<Guid> MPIACBHFHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HBLLMAEIFAH<MLGJCOEGELJ, int> NHPANGKHODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PJFDJKKNHLD<ADJGBMNPMCM> BJJCFDILOBP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PJFDJKKNHLD<long> JPKJGPGPNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LDNMACGBDLI HCJBIJOKCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LDNMACGBDLI HKKDLOCPCPM
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
	Task<LMFFMMPMNDB<CEDJELAJNBK, string>> GHHNFHBPJMK(long FJBFONPAOAD, string DDDHPCNFCEK, string BCAMDINMAHA, string DBALDCNBIMF, RoomInventoryItemProperties FFGFGLBHEDJ, byte GPIPGIMFHKC, int KLMDPLMNJMP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<LMFFMMPMNDB<CEDJELAJNBK, string>> FHLJOELLEEK(Guid DIDFLDPPBOO, [Optional] string DDDHPCNFCEK, [Optional] string BCAMDINMAHA, [Optional] string DBALDCNBIMF, [Optional] List<long> MDKPKEONCAP, [Optional] Dictionary<string, RoomInventoryTagClientProperties> MHEKLOFFGPG, [Optional] RoomInventoryItemProperties FFGFGLBHEDJ, [Optional] byte? GPIPGIMFHKC, [Optional] int? KLMDPLMNJMP);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<LMFFMMPMNDB<bool, string>> DHMGDFMLBEM(Guid DIDFLDPPBOO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<CEDJELAJNBK> JILBPHBODMI();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<CEDJELAJNBK> CNLDNCAFAED();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool KGODIPOLHFO();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool NAHICPIBNJC(Guid DIDFLDPPBOO, [Out] CEDJELAJNBK GFCOEDIFBDO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool FJMACKAAIGC(string ILFDBPMGJOJ, [Out] CEDJELAJNBK GFCOEDIFBDO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<MLGJCOEGELJ> EICCDNJPECO();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool GNHKFMEDAMM(Guid DIDFLDPPBOO, [Out] MLGJCOEGELJ HLABDPAPJJM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? DNDHPHINFBN(Guid DIDFLDPPBOO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> NOBPNIGOKPA(JDJLHJHOJPN PEIJBHPINLD, Guid DIDFLDPPBOO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<KAGOAHBGBNE> BMNCNFLJPFD(JDJLHJHOJPN PEIJBHPINLD, Guid DIDFLDPPBOO, int HBPMKNLKLPD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string LCKCLDAOFCF(MEMHEIJFJKL IPNDOKDOGDG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool NCGPALEBJNJ();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<LMFFMMPMNDB<ADJGBMNPMCM, string>> GGHDIGHJFCF(long HJOKGEPKING, RoomInventoryTagClientProperties FFGFGLBHEDJ);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<LMFFMMPMNDB<bool, string>> NAFFKPJLIPO(long HJOKGEPKING);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<LMFFMMPMNDB<bool, string>> JKNEEHDFJLL(long FJBFONPAOAD, bool DIPABKMBDPL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool OFEAKGOHDEH();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	List<(long, int)> KCKPEKBLDNC(long OLEIOCJJEND, int JDPPACELCKO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool IDIPMPNLLGD(long HJOKGEPKING, [Out] ADJGBMNPMCM LGFAFNBIMKC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool HFNOHFPPODH(long HJOKGEPKING, Guid HDOGBJGGILJ);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IReadOnlyList<ADJGBMNPMCM> POEJCFCOKAP();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	List<ADJGBMNPMCM> HDDPLAPNBFF();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<ADJGBMNPMCM> NPDIGCJJHJH();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<CEDJELAJNBK> PGAOBALEELM(long HJOKGEPKING);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool JMHCPNGFNEF(string OACDNPBHDON, [Out] IReadOnlyList<CEDJELAJNBK> GPLPFLBAIDD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BLKCNFAPLAO : OCFCLMGPDKC
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AODPIGFLEML(IEnumerable<GIMOEJECHGD> HEOHHFPHKHH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LMHOCONOBGI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MLGJCOEGELJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid EEGNGPBMFPA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7478170", Offset = "0x7477570", VA = "0x187478170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int ANNIGLKNIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7478150", Offset = "0x7477550", VA = "0x187478150")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long JLMNHDCGGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CF0", Offset = "0x8B20F0", VA = "0x1808B2CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long KEBOLDNMMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA50", Offset = "0x8ACE50", VA = "0x1808ADA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? FOLFBELGEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A8990", Offset = "0x8A7D90", VA = "0x1808A8990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8A89B0", Offset = "0x8A7DB0", VA = "0x1808A89B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool JDDKBNKEJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFC0", Offset = "0x9AF3C0", VA = "0x1809AFFC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9AFCC0", Offset = "0x9AF0C0", VA = "0x1809AFCC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x74783D0", Offset = "0x74777D0", VA = "0x1874783D0")]
	public MLGJCOEGELJ(GIMOEJECHGD CJHDDFPEFOK, bool AANCFFKCCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xA74840", Offset = "0xA73C40", VA = "0x180A74840")]
	public MLGJCOEGELJ(Guid DIDFLDPPBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74781E0", Offset = "0x74775E0", VA = "0x1874781E0")]
	internal bool PPNDJIMKPLE(GIMOEJECHGD CJHDDFPEFOK, long HEAEGNCCPMG, Action<MLGJCOEGELJ, int> NHECNGCGCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7478180", Offset = "0x7477580", VA = "0x187478180")]
	internal void OKJDIMPFAEK(long NAMONLHJNCA, Action<MLGJCOEGELJ, int> NHECNGCGCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CEDJELAJNBK : IEquatable<CEDJELAJNBK>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int MFGPJGPPEKJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int GMAPBMEAPIL = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int LLFPBMDJAMN = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int FOCNIHHEOKG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int KIFIIHMJOBM = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid EEGNGPBMFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA9A660", VA = "0x180A9B260")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA9B470", Offset = "0xA9A870", VA = "0x180A9B470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long LMAPJLOLJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B50", Offset = "0x9A1F50", VA = "0x1809A2B50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string DDLACOBGPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD00", Offset = "0x8AA100", VA = "0x1808AAD00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string EHHJIEIBFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C20", Offset = "0x8B2020", VA = "0x1808B2C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime IPEDOELAFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9857E0", Offset = "0x984BE0", VA = "0x1809857E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime FMBFJBCBEJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC00", Offset = "0x8AF000", VA = "0x1808AFC00")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61D67B0", Offset = "0x61D5BB0", VA = "0x1861D67B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> PEHMFHHIGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAD0", Offset = "0x8ABED0", VA = "0x1808ACAD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties DMKECDOMAAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB50", Offset = "0x8ABF50", VA = "0x1808ACB50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB20", Offset = "0x8ABF20", VA = "0x1808ACB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte MCBNJHIHCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C80", Offset = "0x8B2080", VA = "0x1808B2C80")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CA0", Offset = "0x8B20A0", VA = "0x1808B2CA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JNMGAPGEGHB BFHKACAHKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9BE8E0", Offset = "0x9BDCE0", VA = "0x1809BE8E0")]
		[CompilerGenerated]
		get
		{
			return default(JNMGAPGEGHB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x11B4EB0", Offset = "0x11B42B0", VA = "0x1811B4EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7477BB0", Offset = "0x7476FB0", VA = "0x187477BB0")]
	public CEDJELAJNBK(HDFHNDLNIJN CJHDDFPEFOK, [Optional] RoomInventoryItemProperties FFGFGLBHEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7477490", Offset = "0x7476890", VA = "0x187477490", Slot = "4")]
	public bool Equals(CEDJELAJNBK KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7477610", Offset = "0x7476A10", VA = "0x187477610", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7477AD0", Offset = "0x7476ED0", VA = "0x187477AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x74777E0", Offset = "0x7476BE0", VA = "0x1874777E0")]
	private HashSet<long> FCPOIDIPIMO(HDFHNDLNIJN CJHDDFPEFOK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GCNBIAOLPHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MLGJCOEGELJ HLABDPAPJJM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CEDJELAJNBK JKFGOLLOPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MLGJCOEGELJ CPMEFMDNGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7477D10", Offset = "0x7477110", VA = "0x187477D10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7477DA0", Offset = "0x74771A0", VA = "0x187477DA0")]
	public GCNBIAOLPHP(CEDJELAJNBK GFCOEDIFBDO, [Optional] MLGJCOEGELJ HLABDPAPJJM)
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
			[Cpp2IlInjected.Address(RVA = "0x7478720", Offset = "0x7477B20", VA = "0x187478720")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xBE3D50", Offset = "0xBE3150", VA = "0x180BE3D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDFD320", Offset = "0xDFC720", VA = "0x180DFD320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public PMIOIPGJFGC Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
			[CompilerGenerated]
			get
			{
				return default(PMIOIPGJFGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8AACE0", Offset = "0x8AA0E0", VA = "0x1808AACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA5AAE0", Offset = "0xA59EE0", VA = "0x180A5AAE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x488D0F0", Offset = "0x488C4F0", VA = "0x18488D0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9439B0", Offset = "0x942DB0", VA = "0x1809439B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9438A0", Offset = "0x942CA0", VA = "0x1809438A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9439C0", Offset = "0x942DC0", VA = "0x1809439C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9438B0", Offset = "0x942CB0", VA = "0x1809438B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7478570", Offset = "0x7477970", VA = "0x187478570", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7478480", Offset = "0x7477880", VA = "0x187478480")]
		public static RoomInventoryItemProperties ANLGIKBMHBN(RoomInventoryItemProperties FFGFGLBHEDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74786C0", Offset = "0x7477AC0", VA = "0x1874786C0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ADJGBMNPMCM
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int BAPOJCOLPGI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string CENOPFAEPNM;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder FBPFIBGDBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string EJNFDALLIMA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FJKENBLGCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9667D0", Offset = "0x965BD0", VA = "0x1809667D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7477090", Offset = "0x7476490", VA = "0x187477090")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string NCDEOLGHIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x74770C0", Offset = "0x74764C0", VA = "0x1874770C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties DMKECDOMAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KIPFGDNGFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7477300", Offset = "0x7476700", VA = "0x187477300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public ADJGBMNPMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74773A0", Offset = "0x74767A0", VA = "0x1874773A0")]
	public ADJGBMNPMCM(MBNEEIOCPHC CJHDDFPEFOK, [Optional] RoomInventoryTagClientProperties FFGFGLBHEDJ)
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
			[Cpp2IlInjected.Address(RVA = "0x7478980", Offset = "0x7477D80", VA = "0x187478980")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7478770", Offset = "0x7477B70", VA = "0x187478770")]
		public void FMJKFAHAMKH(Dictionary<string, object> OKAAIGKOFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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
