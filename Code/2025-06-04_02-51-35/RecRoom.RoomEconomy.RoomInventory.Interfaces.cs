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
public class NDFCDNCHPLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LDODJIJKDBL EOJDHIBJAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long JAJBNKBAONK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BHOGDLGAOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x879BAD0", Offset = "0x879A2D0", VA = "0x18879BAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x879BAE0", Offset = "0x879A2E0", VA = "0x18879BAE0")]
	public NDFCDNCHPLK(LDODJIJKDBL KJCFPPKBAOB, long FMGALNGIOGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MHAIBHEMBNB
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
public interface GBCPHEKENAK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	KECNPIDOCPH MOOKOMMBKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LBOAOFAOKMM<ENFMBFNNPGJ> GFDPKLLBALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	LBOAOFAOKMM<Guid> NNAJDBDDLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EGCONEOAIAE<NDBJHGJBMKB, int> DDNBIAFIGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LBOAOFAOKMM<MIIKGBFCDND> KDBLANFHNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LBOAOFAOKMM<long> ICNCACOGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KECNPIDOCPH OEMOBLFBIII
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	KECNPIDOCPH CJJFHNBFCBB
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
	Task<AOGODOAGAAO<ENFMBFNNPGJ, string>> CBHCAOBLLID(Guid? LOEJBFFHLNB, long GFHIJAKOMMI, string HPANEBBHGAC, string LLAMBGFCPPC, string FLCIMENMGDL, RoomInventoryItemProperties JKBGANBHBMG, byte GOMGOEKJPBC, int BIKIHAKPCIG, [Optional] List<long> JCMELIGOMOI, [Optional] List<KJIFACFAEFJ> LINGPMCBKFF, bool DGBBFPCCGCI = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<AOGODOAGAAO<ENFMBFNNPGJ, string>> NBBGEFIMBOO(Guid INKJJAKOHOG, long GFHIJAKOMMI, [Optional] string HPANEBBHGAC, [Optional] string LLAMBGFCPPC, [Optional] string FLCIMENMGDL, [Optional] List<long> JCMELIGOMOI, [Optional] Dictionary<string, RoomInventoryTagClientProperties> LINGPMCBKFF, [Optional] RoomInventoryItemProperties JKBGANBHBMG, [Optional] byte? GOMGOEKJPBC, [Optional] int? BIKIHAKPCIG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<AOGODOAGAAO<bool, string>> GAOKCDACOBC(Guid INKJJAKOHOG, long GFHIJAKOMMI);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<ENFMBFNNPGJ> CGMEMEPEJNB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<ENFMBFNNPGJ> GLHHCPFOKCC();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PDCKPHBJGAD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool ECMCNOENHDK(Guid INKJJAKOHOG, [Out] ENFMBFNNPGJ HMOKCCIHCCJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool AINOJLEEHFG(string GIEODNOJMHB, [Out] ENFMBFNNPGJ HMOKCCIHCCJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<NDBJHGJBMKB> BCGCHJMCHGB();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool PDCMHHBPAPJ(Guid INKJJAKOHOG, [Out] NDBJHGJBMKB JJIBICBENEA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? NPOJLHJDOAL(Guid INKJJAKOHOG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> JFHJKHKBDGJ(EIGONBNGIIK OINLJEGCCDI, Guid INKJJAKOHOG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<NDFCDNCHPLK> HOBOALPOLCE(EIGONBNGIIK OINLJEGCCDI, Guid INKJJAKOHOG, int LMIFGKAMFNG);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string AEAECHHELAM(LDODJIJKDBL KJCFPPKBAOB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool EHJOCINGJHK();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DHLKILNGPGH JCMMDFONHJK(ENFMBFNNPGJ BJNMPFPEAGJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties BICMLOFKOFA(string DNBIBLNCJKL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<AOGODOAGAAO<MIIKGBFCDND, string>> DPIINBDJFIH(long GFEINMOMPEO, RoomInventoryTagClientProperties JKBGANBHBMG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<AOGODOAGAAO<bool, string>> GFCHMNJILEC(long GFEINMOMPEO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<AOGODOAGAAO<bool, string>> EPDPIAFOHLG(long GFHIJAKOMMI, bool EOEAMFOCIJA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool KOPKBLNNMJF();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> BEMGKJLHMLN(long AKKOHMLOGHI, int EEGKOMJDOBI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool OKFFMNEAFEE(long GFEINMOMPEO, [Out] MIIKGBFCDND EKNDCDEGNDB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool LFPBFCJGMHF(string OMBIMFIEEME, [Out] MIIKGBFCDND EKNDCDEGNDB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool CHLFJNGLGAA(long GFEINMOMPEO, Guid JEIIKOOLHIA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<MIIKGBFCDND> JHAAIFJKEBJ();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<MIIKGBFCDND> LFAADHEEGLJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<MIIKGBFCDND> JPKHMDLLBID();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<ENFMBFNNPGJ> EDCBDABEGBJ(long GFEINMOMPEO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HDAHLHJPOLF(string OMBIMFIEEME, [Out] IReadOnlyList<ENFMBFNNPGJ> JKJACFDBNPE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HCPIDJLKNNN : GBCPHEKENAK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLFEKGBGJDG(IEnumerable<GABLDAGFLGO> NHEEOMKGNCD);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EEEMHFCNOGH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NDBJHGJBMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid BFDOBJHIIDA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x879BA10", Offset = "0x879A210", VA = "0x18879BA10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BHOGDLGAOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x879B800", Offset = "0x879A000", VA = "0x18879B800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long GPBMPJDAAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA2D360", Offset = "0xA2BB60", VA = "0x180A2D360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long OEIIKEOJMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? NMLOAIIBEDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA37450", Offset = "0xA35C50", VA = "0x180A37450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA37480", Offset = "0xA35C80", VA = "0x180A37480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool JBAHHGMDJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC8E670", Offset = "0xC8CE70", VA = "0x180C8E670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC8DCA0", Offset = "0xC8C4A0", VA = "0x180C8DCA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x879BA20", Offset = "0x879A220", VA = "0x18879BA20")]
	public NDBJHGJBMKB(GABLDAGFLGO ANLDCHLHLAB, bool GGLBIIELEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFD82E0", Offset = "0xFD6AE0", VA = "0x180FD82E0")]
	public NDBJHGJBMKB(Guid INKJJAKOHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x879B820", Offset = "0x879A020", VA = "0x18879B820")]
	internal bool JNHFKCNMNLI(GABLDAGFLGO ANLDCHLHLAB, long LNKDDIIHJAP, Action<NDBJHGJBMKB, int> NIJNBDLHHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x879B7A0", Offset = "0x8799FA0", VA = "0x18879B7A0")]
	internal void BBCPBBPNOPK(long AFJFOCMPEJF, Action<NDBJHGJBMKB, int> NIJNBDLHHOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ENFMBFNNPGJ : IEquatable<ENFMBFNNPGJ>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int HBJGFKAECAC = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int MIFAAEHKDNC = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int PGHFADOLNEB = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int BPDBAKPODEK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int BIIFBFKBBFG = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid BFDOBJHIIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xECAA70", Offset = "0xEC9270", VA = "0x180ECAA70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x720E320", Offset = "0x720CB20", VA = "0x18720E320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> OLCJFMKDJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties PILGCCKNCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte IKLDEACACAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA2D490", Offset = "0xA2BC90", VA = "0x180A2D490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OCHABKGPDJF NOCIFGGBANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xF01B90", Offset = "0xF00390", VA = "0x180F01B90")]
		[CompilerGenerated]
		get
		{
			return default(OCHABKGPDJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2DA70B0", Offset = "0x2DA58B0", VA = "0x182DA70B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ENFMBFNNPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x879ADA0", Offset = "0x87995A0", VA = "0x18879ADA0")]
	public ENFMBFNNPGJ(DHLKILNGPGH ANLDCHLHLAB, [Optional] RoomInventoryItemProperties JKBGANBHBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x879A850", Offset = "0x8799050", VA = "0x18879A850", Slot = "4")]
	public bool Equals(ENFMBFNNPGJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x879A680", Offset = "0x8798E80", VA = "0x18879A680", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x879A9D0", Offset = "0x87991D0", VA = "0x18879A9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x879AAB0", Offset = "0x87992B0", VA = "0x18879AAB0")]
	private HashSet<long> PCLIHFGFFBM(DHLKILNGPGH ANLDCHLHLAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ENPNHAICFBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NDBJHGJBMKB JJIBICBENEA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ENFMBFNNPGJ HAECLIHDILC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NDBJHGJBMKB NPJLPFPMJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x879AF00", Offset = "0x8799700", VA = "0x18879AF00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x879AF90", Offset = "0x8799790", VA = "0x18879AF90")]
	public ENPNHAICFBB(ENFMBFNNPGJ HMOKCCIHCCJ, [Optional] NDBJHGJBMKB JJIBICBENEA)
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
			[Cpp2IlInjected.Address(RVA = "0x879BDC0", Offset = "0x879A5C0", VA = "0x18879BDC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x11A4EE0", Offset = "0x11A36E0", VA = "0x1811A4EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x143EA80", Offset = "0x143D280", VA = "0x18143EA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public MHAIBHEMBNB Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(MHAIBHEMBNB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA78BE0", Offset = "0xA773E0", VA = "0x180A78BE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD9DF30", Offset = "0xD9C730", VA = "0x180D9DF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xE3E930", Offset = "0xE3D130", VA = "0x180E3E930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xE3E920", Offset = "0xE3D120", VA = "0x180E3E920")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x879BB20", Offset = "0x879A320", VA = "0x18879BB20", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x879BBB0", Offset = "0x879A3B0", VA = "0x18879BBB0")]
		public static RoomInventoryItemProperties FGIKHGILDDC(RoomInventoryItemProperties JKBGANBHBMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x879BD60", Offset = "0x879A560", VA = "0x18879BD60")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MIIKGBFCDND
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int IIHFEEMJNCM = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string IFCDCCBLLLN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder DIEKADLDKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string ONCMMKKLENL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long GPFADHNCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x879B600", Offset = "0x8799E00", VA = "0x18879B600")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x879B2E0", Offset = "0x8799AE0", VA = "0x18879B2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties PILGCCKNCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DCAMECAPLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x879B520", Offset = "0x8799D20", VA = "0x18879B520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MIIKGBFCDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x879B6B0", Offset = "0x8799EB0", VA = "0x18879B6B0")]
	public MIIKGBFCDND(KJIFACFAEFJ ANLDCHLHLAB, [Optional] RoomInventoryTagClientProperties JKBGANBHBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x879B540", Offset = "0x8799D40", VA = "0x18879B540")]
	public KJIFACFAEFJ JECFNMGKIOF()
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
			[Cpp2IlInjected.Address(RVA = "0x879C020", Offset = "0x879A820", VA = "0x18879C020")]
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
			[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x879BE10", Offset = "0x879A610", VA = "0x18879BE10")]
		public void KIDDHACFAFC(Dictionary<string, object> DBEDDDJOMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
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
