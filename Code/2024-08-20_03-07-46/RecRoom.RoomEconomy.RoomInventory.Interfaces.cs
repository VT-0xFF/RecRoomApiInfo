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
public class MNKHAAMFNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly GDINHGINMEI PKJIEJGMNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long DHMBIHOHONP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JAJJIKAHAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE4B0", Offset = "0x6FED4B0", VA = "0x186FEE4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE4C0", Offset = "0x6FED4C0", VA = "0x186FEE4C0")]
	public MNKHAAMFNBK(GDINHGINMEI KNFGDDANCCK, long DOPPKGNLPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OKDDPJPMDOH
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
public interface DEBJMDNJELP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	PEHINEDJEEO CFPLMIFEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HLGIBODIABL<FHMPCKILFAI> PJAINIIELPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HLGIBODIABL<Guid> OJFAIKPMGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DNDLMNGOFAF<PHPIOMGOOOI, int> BGGCMCGDCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HLGIBODIABL<ODJAIADLHMO> MEJIEKJIGDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HLGIBODIABL<long> OPOLLOECLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PEHINEDJEEO JBOEHMFDCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	PEHINEDJEEO BGAALAODJCG
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
	Task<DFAHBLOKBPH<FHMPCKILFAI, string>> CKGNKICCOHH(long MFLLPFDNGGL, string CKEJJGPNKGO, string EHMGHMNDKCC, string IACHHHAGMNO, RoomInventoryItemProperties BGCNJECCDBE, byte GDADABDCJHE, int NHCEIDKGILJ);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<DFAHBLOKBPH<FHMPCKILFAI, string>> CFGHHOFKDLB(Guid HPLDFHHOEDG, [Optional] string CKEJJGPNKGO, [Optional] string EHMGHMNDKCC, [Optional] string IACHHHAGMNO, [Optional] List<long> DMMPOBNGNIM, [Optional] Dictionary<string, RoomInventoryTagClientProperties> PHOLMKFCDMB, [Optional] RoomInventoryItemProperties BGCNJECCDBE, [Optional] byte? GDADABDCJHE, [Optional] int? NHCEIDKGILJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<DFAHBLOKBPH<bool, string>> JDALGJJLBMJ(Guid HPLDFHHOEDG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<FHMPCKILFAI> BFPDBCMECOM();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<FHMPCKILFAI> GGACHNADPBN();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool MLIAMPLPDKL();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool PIKBELHPIPA(Guid HPLDFHHOEDG, [Out] FHMPCKILFAI EFLLDMNEKHI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool HGCMHBIPOFH(string CNMCFCBONPI, [Out] FHMPCKILFAI EFLLDMNEKHI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<PHPIOMGOOOI> GHIMGJHNFEG();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool BJLGOCAGHIB(Guid HPLDFHHOEDG, [Out] PHPIOMGOOOI OJELBKGJMMO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? DJIAIFBONIB(Guid HPLDFHHOEDG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> NKKPCJJKEIE(EEPDJJKFILM GOJJHGGKKML, Guid HPLDFHHOEDG);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<MNKHAAMFNBK> EPKIMFPBJPN(EEPDJJKFILM GOJJHGGKKML, Guid HPLDFHHOEDG, int BHANGKNKGFI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string GPLIHBHAILB(GDINHGINMEI KNFGDDANCCK);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JEDOBALMIKM();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<DFAHBLOKBPH<ODJAIADLHMO, string>> GIEMOPMFKPG(long GNKPEPIAGNF, RoomInventoryTagClientProperties BGCNJECCDBE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<DFAHBLOKBPH<bool, string>> BDNKFLGBOCH(long GNKPEPIAGNF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<DFAHBLOKBPH<bool, string>> GHIBKHJIACO(long MFLLPFDNGGL, bool NNNPGABJGEG);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HJPCBJLDEAB();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	List<(long, int)> HGBHENJHBHF(long HCGMFOFGIMJ, int NCDMBACIKME);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool IEGJBPFEDDM(long GNKPEPIAGNF, [Out] ODJAIADLHMO JGLJLDIOOFG);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool FPLCLBNFLKO(long GNKPEPIAGNF, Guid IPAAJCMMEKO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IReadOnlyList<ODJAIADLHMO> MOKAFMHDGGP();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	List<ODJAIADLHMO> FCACFDMOMLH();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<ODJAIADLHMO> MNHMBNHKMNF();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<FHMPCKILFAI> LAAOMMBFBFB(long GNKPEPIAGNF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool KIDDNGMKAON(string GIAGEGLOMNG, [Out] IReadOnlyList<FHMPCKILFAI> LFKHLHEIPML);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BFDEPGGAKPM : DEBJMDNJELP
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEGCOEOGKFD(IEnumerable<IIKKEMPCKDF> DOHFAOLDFMG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CLBAIABNLIO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PHPIOMGOOOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid JNOPJMODLCP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEF70", Offset = "0x6FEDF70", VA = "0x186FEEF70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JAJJIKAHAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEF50", Offset = "0x6FEDF50", VA = "0x186FEEF50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long MAGJOENDLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x851850", Offset = "0x850850", VA = "0x180851850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long CFCMOFCNIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x859570", Offset = "0x858570", VA = "0x180859570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? ADNPNDBILLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x854660", Offset = "0x853660", VA = "0x180854660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x854690", Offset = "0x853690", VA = "0x180854690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HIKGAKNHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xB109F0", Offset = "0xB0F9F0", VA = "0x180B109F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xF7FC20", Offset = "0xF7EC20", VA = "0x180F7FC20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEF80", Offset = "0x6FEDF80", VA = "0x186FEEF80")]
	public PHPIOMGOOOI(IIKKEMPCKDF MGJPOJNKFOP, bool NKPGEOAIFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1EBA5F0", Offset = "0x1EB95F0", VA = "0x181EBA5F0")]
	public PHPIOMGOOOI(Guid HPLDFHHOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FEED60", Offset = "0x6FEDD60", VA = "0x186FEED60")]
	internal bool GACAEOGENLN(IIKKEMPCKDF MGJPOJNKFOP, long NFNKOEPDEFI, Action<PHPIOMGOOOI, int> CMMEEDDOCEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEED00", Offset = "0x6FEDD00", VA = "0x186FEED00")]
	internal void EKIENAJMDFO(long MDFDKABEMDB, Action<PHPIOMGOOOI, int> CMMEEDDOCEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FHMPCKILFAI : IEquatable<FHMPCKILFAI>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int LCOHPLBCIOJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int DKOCOPKDEKO = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int CEKCHBFHNHD = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int GDPIFEEJOAC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int GEABIDHCACP = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid JNOPJMODLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA892A0", Offset = "0xA882A0", VA = "0x180A892A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long NCHINCKKPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1171890", Offset = "0x1170890", VA = "0x181171890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x855820", Offset = "0x854820", VA = "0x180855820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string JLKBGJOCNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PFGNONMDMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x851620", Offset = "0x850620", VA = "0x180851620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime CKBNDNJPANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8517B0", Offset = "0x8507B0", VA = "0x1808517B0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1DD37E0", Offset = "0x1DD27E0", VA = "0x181DD37E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime IIHMCJPANIF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x8507F0", VA = "0x1808517F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D8FA00", Offset = "0x5D8EA00", VA = "0x185D8FA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> IEIGBELIHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8515F0", Offset = "0x8505F0", VA = "0x1808515F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8518B0", Offset = "0x8508B0", VA = "0x1808518B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties ELDHPFKIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8516F0", Offset = "0x8506F0", VA = "0x1808516F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8518A0", Offset = "0x8508A0", VA = "0x1808518A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte EPGHLCKONAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8518F0", Offset = "0x8508F0", VA = "0x1808518F0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x851900", Offset = "0x850900", VA = "0x180851900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LCHJIFIKODO JCCNEGPADMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xFA6830", Offset = "0xFA5830", VA = "0x180FA6830")]
		[CompilerGenerated]
		get
		{
			return default(LCHJIFIKODO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xFA5B20", Offset = "0xFA4B20", VA = "0x180FA5B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE350", Offset = "0x6FED350", VA = "0x186FEE350")]
	public FHMPCKILFAI(FLAHNCMBKIJ MGJPOJNKFOP, [Optional] RoomInventoryItemProperties BGCNJECCDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDE00", Offset = "0x6FECE00", VA = "0x186FEDE00", Slot = "4")]
	public bool Equals(FHMPCKILFAI ACBLPNJDJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDC30", Offset = "0x6FECC30", VA = "0x186FEDC30", Slot = "0")]
	public override bool Equals(object NOPFNIKINJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6FEDF80", Offset = "0x6FECF80", VA = "0x186FEDF80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE060", Offset = "0x6FED060", VA = "0x186FEE060")]
	private HashSet<long> MLLOFIHEAEO(FLAHNCMBKIJ MGJPOJNKFOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NFCMDHLEIMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PHPIOMGOOOI OJELBKGJMMO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FHMPCKILFAI GPMIMPKMJNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x851910", Offset = "0x850910", VA = "0x180851910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PHPIOMGOOOI AOODKJFPADD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE500", Offset = "0x6FED500", VA = "0x186FEE500")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEE590", Offset = "0x6FED590", VA = "0x186FEE590")]
	public NFCMDHLEIMD(FHMPCKILFAI EFLLDMNEKHI, [Optional] PHPIOMGOOOI OJELBKGJMMO)
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
			[Cpp2IlInjected.Address(RVA = "0x6FEF2C0", Offset = "0x6FEE2C0", VA = "0x186FEF2C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x854620", Offset = "0x853620", VA = "0x180854620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9F2A60", Offset = "0x9F1A60", VA = "0x1809F2A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xC03D00", Offset = "0xC02D00", VA = "0x180C03D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public OKDDPJPMDOH Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0")]
			[CompilerGenerated]
			get
			{
				return default(OKDDPJPMDOH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x85BDC0", Offset = "0x85ADC0", VA = "0x18085BDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x95D900", Offset = "0x95C900", VA = "0x18095D900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x45BAA20", Offset = "0x45B9A20", VA = "0x1845BAA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB4A400", Offset = "0xB49400", VA = "0x180B4A400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xC42BC0", Offset = "0xC41BC0", VA = "0x180C42BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xED2AA0", Offset = "0xED1AA0", VA = "0x180ED2AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xED3F30", Offset = "0xED2F30", VA = "0x180ED3F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF120", Offset = "0x6FEE120", VA = "0x186FEF120", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties ACBLPNJDJBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF030", Offset = "0x6FEE030", VA = "0x186FEF030")]
		public static RoomInventoryItemProperties DMJCFLNALOI(RoomInventoryItemProperties BGCNJECCDBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF260", Offset = "0x6FEE260", VA = "0x186FEF260")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ODJAIADLHMO
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int JGBIJHHFPNE = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string JJGDEGMALFN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder CLKAJHKINIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string EHBEAKPOAAP;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FILHGFPKEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x15E8280", Offset = "0x15E7280", VA = "0x1815E8280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6FEEB50", Offset = "0x6FEDB50", VA = "0x186FEEB50")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string AFJILKDEOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE900", Offset = "0x6FED900", VA = "0x186FEE900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties ELDHPFKIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x855820", Offset = "0x854820", VA = "0x180855820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GINLLEJMFCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE8E0", Offset = "0x6FED8E0", VA = "0x186FEE8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public ODJAIADLHMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6FEEC00", Offset = "0x6FEDC00", VA = "0x186FEEC00")]
	public ODJAIADLHMO(GLIHCMNMEOG MGJPOJNKFOP, [Optional] RoomInventoryTagClientProperties BGCNJECCDBE)
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
			[Cpp2IlInjected.Address(RVA = "0x6FEF510", Offset = "0x6FEE510", VA = "0x186FEF510")]
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
			[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x854620", Offset = "0x853620", VA = "0x180854620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FEF310", Offset = "0x6FEE310", VA = "0x186FEF310")]
		public void KPEANPFNKBH(Dictionary<string, object> KIGCHOEOBEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
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
