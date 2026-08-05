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
public class JDIENCNKJJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly DLALDHKLAHH FAFJLKPDBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long OGMGMMMEFKC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EIJMLHIAIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8454000", Offset = "0x8453200", VA = "0x188454000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8454010", Offset = "0x8453210", VA = "0x188454010")]
	public JDIENCNKJJE(DLALDHKLAHH ACALKMLJJOL, long OCEHNHGKKJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MBHHCOOALJA
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
public interface HBPIDBGMIOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EPHHEFDKGKL JDGKKNNAGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KFOHPPMEALH<EIOOAIMJNAB> KNFEHBFDCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	KFOHPPMEALH<Guid> GGPOJBNDNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LDFPLGIGGEB<EJGNEINAMOA, int> PHAIOAADAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KFOHPPMEALH<LBBBFBJIEAL> EBEMKJFNCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KFOHPPMEALH<long> JLDNAINLOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EPHHEFDKGKL LFNBBGAOJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EPHHEFDKGKL POMEMAGLDIP
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
	Task<DJNAMIFBMIO<EIOOAIMJNAB, string>> BOCHEJKMOJN(Guid? PLGGGIJOHAJ, long LADMAADOIBG, string GBOCGPJOEEK, string AOOEEPGFGKK, string OFLIHBONFIK, RoomInventoryItemProperties GFKOIMIAEOH, byte GEPHAPCMEAA, int NEMIFEKMDAI, [Optional] List<long> GPIINABBHNG, [Optional] List<BPKDKDHKGBE> LPDHGMJEOAL, bool KMGMAGJBOOG = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<DJNAMIFBMIO<EIOOAIMJNAB, string>> MPNHGAOICNK(Guid MBINFGFHAKD, long LADMAADOIBG, [Optional] string GBOCGPJOEEK, [Optional] string AOOEEPGFGKK, [Optional] string OFLIHBONFIK, [Optional] List<long> GPIINABBHNG, [Optional] Dictionary<string, RoomInventoryTagClientProperties> LPDHGMJEOAL, [Optional] RoomInventoryItemProperties GFKOIMIAEOH, [Optional] byte? GEPHAPCMEAA, [Optional] int? NEMIFEKMDAI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<DJNAMIFBMIO<bool, string>> MNGCIKEGMED(Guid MBINFGFHAKD, long LADMAADOIBG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<EIOOAIMJNAB> GHAAIGDHPBE();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<EIOOAIMJNAB> ELOLAJNJIBL();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JDDDBNOBLDB();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool KPBCEBPDMLK(Guid MBINFGFHAKD, [Out] EIOOAIMJNAB BEJICGCJAJN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool FMELJOGKIHN(string OFNKGHOBEIL, [Out] EIOOAIMJNAB BEJICGCJAJN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<EJGNEINAMOA> JONDNPKKJIB();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool FOBJMDOLJFN(Guid MBINFGFHAKD, [Out] EJGNEINAMOA KHMIGDFADNL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? PAHDAGLDBAL(Guid MBINFGFHAKD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> KPJGBDNABLI(BNFABCHNBCL NLIBDKKPKLB, Guid MBINFGFHAKD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<JDIENCNKJJE> FMMFINOHINO(BNFABCHNBCL NLIBDKKPKLB, Guid MBINFGFHAKD, int MIKCOPHLPJK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string LLNMALOOMJJ(DLALDHKLAHH ACALKMLJJOL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KFMOCNFLJHP();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	ANJHCHGJELJ FGJAPDMNIBO(EIOOAIMJNAB AJIAPLKPDCI);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties HOMMHOBCIKG(string AAEEIPAIGCO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<DJNAMIFBMIO<LBBBFBJIEAL, string>> PDKBOLHMLHM(long CHPACKMLBKF, RoomInventoryTagClientProperties GFKOIMIAEOH);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<DJNAMIFBMIO<bool, string>> MCILMPICPMM(long CHPACKMLBKF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<DJNAMIFBMIO<bool, string>> KNFNGOKFCAM(long LADMAADOIBG, bool JBPEFFIDDPE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool OAAGALNKLNA();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> FCELPMEKOFK(long IFEAOAFMDCN, int KPOGCCODFKP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool KFKLJBENBFO(long CHPACKMLBKF, [Out] LBBBFBJIEAL JNMGPOGANPP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool BPMBHCJIOMJ(string CBGINMMNNCD, [Out] LBBBFBJIEAL JNMGPOGANPP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool ENDFDHKDFJG(long CHPACKMLBKF, Guid DCJABKEMCDD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<LBBBFBJIEAL> BHPDAHGAFPH();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<LBBBFBJIEAL> BNLDEJMHLIA();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<LBBBFBJIEAL> BNEACMCMGDN();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<EIOOAIMJNAB> MCCHFAACPEO(long CHPACKMLBKF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool PDOPEEGFEAH(string CBGINMMNNCD, [Out] IReadOnlyList<EIOOAIMJNAB> FGOIFEDLNCF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ELPLLLCHPFJ : HBPIDBGMIOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKKIODBJKJO(IEnumerable<OOCKLHFLEDM> KFEBFHCIFAE);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IJCDLNMDOMA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EJGNEINAMOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid NHKKHFFNMLO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long OGMGMMMEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8453CD0", Offset = "0x8452ED0", VA = "0x188453CD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EIJMLHIAIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8453D40", Offset = "0x8452F40", VA = "0x188453D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long IEBIGKHACJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA0D660", Offset = "0xA0C860", VA = "0x180A0D660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long FDIONCGMNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA00F80", Offset = "0xA00180", VA = "0x180A00F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? DIOJLPDOPPC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA036D0", Offset = "0xA028D0", VA = "0x180A036D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA03710", Offset = "0xA02910", VA = "0x180A03710")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool JEKMBJEHCDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC6A590", Offset = "0xC69790", VA = "0x180C6A590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC69C40", Offset = "0xC68E40", VA = "0x180C69C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8453F50", Offset = "0x8453150", VA = "0x188453F50")]
	public EJGNEINAMOA(OOCKLHFLEDM CIDHLIAPJFB, bool PCBALHEDHFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFAEF80", Offset = "0xFAE180", VA = "0x180FAEF80")]
	public EJGNEINAMOA(Guid MBINFGFHAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8453D60", Offset = "0x8452F60", VA = "0x188453D60")]
	internal bool KJFMNLEBHBJ(OOCKLHFLEDM CIDHLIAPJFB, long LGKAJDBCKHP, Action<EJGNEINAMOA, int> COKKOCCACEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8453CE0", Offset = "0x8452EE0", VA = "0x188453CE0")]
	internal void ICNCLDJMOHP(long PGENOGKEKNH, Action<EJGNEINAMOA, int> COKKOCCACEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EIOOAIMJNAB : IEquatable<EIOOAIMJNAB>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int FADGHBKFNBH = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int CNPDFMHKGJF = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int AIGPMDEHBDF = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int AHLGOCAIADF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int PMKNKJLIHAI = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid NHKKHFFNMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xD9D600", Offset = "0xD9C800", VA = "0x180D9D600")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long NICOLNMBAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xD12D40", Offset = "0xD11F40", VA = "0x180D12D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ENNIBIAAHEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA09EE0", Offset = "0xA090E0", VA = "0x180A09EE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string IKDJHDDNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3E0", Offset = "0xA0C5E0", VA = "0x180A0D3E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime LLPDOGLDAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xEA0120", Offset = "0xE9F320", VA = "0x180EA0120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime BFPHKBDIJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6E89520", Offset = "0x6E88720", VA = "0x186E89520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> BGIHMGJAPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA003E0", Offset = "0x9FF5E0", VA = "0x180A003E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties GDECKNAOPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA00350", Offset = "0x9FF550", VA = "0x180A00350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA003D0", Offset = "0x9FF5D0", VA = "0x180A003D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte KHEOHIEBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0FD10", Offset = "0xA0EF10", VA = "0x180A0FD10")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA0FC10", Offset = "0xA0EE10", VA = "0x180A0FC10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IPAPAOLOGOE IDDHCGFKLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xEDD5E0", Offset = "0xEDC7E0", VA = "0x180EDD5E0")]
		[CompilerGenerated]
		get
		{
			return default(IPAPAOLOGOE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2DE6DF0", Offset = "0x2DE5FF0", VA = "0x182DE6DF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public EIOOAIMJNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8453B70", Offset = "0x8452D70", VA = "0x188453B70")]
	public EIOOAIMJNAB(ANJHCHGJELJ CIDHLIAPJFB, [Optional] RoomInventoryItemProperties GFKOIMIAEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8453740", Offset = "0x8452940", VA = "0x188453740", Slot = "4")]
	public bool Equals(EIOOAIMJNAB CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x84538C0", Offset = "0x8452AC0", VA = "0x1884538C0", Slot = "0")]
	public override bool Equals(object KFMNDOMPAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8453A90", Offset = "0x8452C90", VA = "0x188453A90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8453450", Offset = "0x8452650", VA = "0x188453450")]
	private HashSet<long> BKJPOHMHOKM(ANJHCHGJELJ CIDHLIAPJFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MMNJFNCIGGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EJGNEINAMOA KHMIGDFADNL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EIOOAIMJNAB EEPGKFAIAII
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA00FA0", Offset = "0xA001A0", VA = "0x180A00FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EJGNEINAMOA DDGCIMGONMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8454510", Offset = "0x8453710", VA = "0x188454510")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA00F60", Offset = "0xA00160", VA = "0x180A00F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x84545A0", Offset = "0x84537A0", VA = "0x1884545A0")]
	public MMNJFNCIGGG(EIOOAIMJNAB BEJICGCJAJN, [Optional] EJGNEINAMOA KHMIGDFADNL)
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
			[Cpp2IlInjected.Address(RVA = "0x8454BA0", Offset = "0x8453DA0", VA = "0x188454BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x11891F0", Offset = "0x11883F0", VA = "0x1811891F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x143B610", Offset = "0x143A810", VA = "0x18143B610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public MBHHCOOALJA Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA09790", Offset = "0xA08990", VA = "0x180A09790")]
			[CompilerGenerated]
			get
			{
				return default(MBHHCOOALJA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA09780", Offset = "0xA08980", VA = "0x180A09780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA52350", Offset = "0xA51550", VA = "0x180A52350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD7FF60", Offset = "0xD7F160", VA = "0x180D7FF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA01190", Offset = "0xA00390", VA = "0x180A01190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA674A0", Offset = "0xA666A0", VA = "0x180A674A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA671B0", Offset = "0xA663B0", VA = "0x180A671B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xE222D0", Offset = "0xE214D0", VA = "0x180E222D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xE222C0", Offset = "0xE214C0", VA = "0x180E222C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84549F0", Offset = "0x8453BF0", VA = "0x1884549F0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8454900", Offset = "0x8453B00", VA = "0x188454900")]
		public static RoomInventoryItemProperties EDIKNCAPOAM(RoomInventoryItemProperties GFKOIMIAEOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8454B40", Offset = "0x8453D40", VA = "0x188454B40")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LBBBFBJIEAL
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int MDDIADOOPDM = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string NMMEJKENFOI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder ECBCCKLOMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string EFKPMJJMHPO;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MBEJEAJLNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xD87B40", Offset = "0xD86D40", VA = "0x180D87B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string KGCJIDMKOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8454370", Offset = "0x8453570", VA = "0x188454370")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string MCPIOFNNGEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8454050", Offset = "0x8453250", VA = "0x188454050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties GDECKNAOPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA00F90", Offset = "0xA00190", VA = "0x180A00F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA00D60", Offset = "0x9FFF60", VA = "0x180A00D60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JDFMOPIFDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8454290", Offset = "0x8453490", VA = "0x188454290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public LBBBFBJIEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8454420", Offset = "0x8453620", VA = "0x188454420")]
	public LBBBFBJIEAL(BPKDKDHKGBE CIDHLIAPJFB, [Optional] RoomInventoryTagClientProperties GFKOIMIAEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x84542B0", Offset = "0x84534B0", VA = "0x1884542B0")]
	public BPKDKDHKGBE GJNEFDBCKMM()
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
			[Cpp2IlInjected.Address(RVA = "0x8454E00", Offset = "0x8454000", VA = "0x188454E00")]
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
			[Cpp2IlInjected.Address(RVA = "0xA00110", Offset = "0x9FF310", VA = "0x180A00110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA03700", Offset = "0xA02900", VA = "0x180A03700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8454BF0", Offset = "0x8453DF0", VA = "0x188454BF0")]
		public void KPCIGBMBFEI(Dictionary<string, object> LMFDDJEFIOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
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
