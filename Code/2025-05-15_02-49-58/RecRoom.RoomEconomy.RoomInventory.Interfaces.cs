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
public class NPGEFAPAANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly MFEBDNMCCIM CIJAJIIDNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long CMIOJAJFIMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CMGCCBLFDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83E2090", Offset = "0x83E0690", VA = "0x1883E2090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x83E20A0", Offset = "0x83E06A0", VA = "0x1883E20A0")]
	public NPGEFAPAANA(MFEBDNMCCIM OBOOAPELMPF, long JAALIADHHOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EAMLMFIGALM
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
public interface KFJKIOCBFLM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GCADBNOOJOM AMJMAAKCFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NPNKPOOAOFG<AFLLNPHGMEA> MKMHIMHGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NPNKPOOAOFG<Guid> JNKDLGNNOCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	KICNHCAEGMA<LLGFAIJGGMG, int> MFGCMGMICKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NPNKPOOAOFG<IKOGMGLMEPJ> OHOOIBGILKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NPNKPOOAOFG<long> KNHKLEGBJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GCADBNOOJOM OBDPKIMGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GCADBNOOJOM MOPBMBGGDLL
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
	Task<HHHCCNLMPJL<AFLLNPHGMEA, string>> MEMDAIDDBGB(Guid? LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string HHPFBMBMELN, string PCHIHCHIMHB, RoomInventoryItemProperties FBEFHOGBKOJ, byte HIECCNNOPLP, int NGGKCKILBNF, [Optional] List<long> FNAGIFOGJOE, [Optional] List<HKDBDNMIAHA> HLMEELBCLMF, bool NHLBKAEBPKA = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<HHHCCNLMPJL<AFLLNPHGMEA, string>> BJBHJOGMKDI(Guid EDFMANFDKLC, long CINEDGEJAIA, [Optional] string NFHOBPDKIPM, [Optional] string HHPFBMBMELN, [Optional] string PCHIHCHIMHB, [Optional] List<long> FNAGIFOGJOE, [Optional] Dictionary<string, RoomInventoryTagClientProperties> HLMEELBCLMF, [Optional] RoomInventoryItemProperties FBEFHOGBKOJ, [Optional] byte? HIECCNNOPLP, [Optional] int? NGGKCKILBNF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<HHHCCNLMPJL<bool, string>> ELAEIOLHINB(Guid EDFMANFDKLC, long CINEDGEJAIA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<AFLLNPHGMEA> CAJOCGOKCEE();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<AFLLNPHGMEA> JNIIGLONDKA();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool NEFOGEJHPIM();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool AAPAJFADHBN(Guid EDFMANFDKLC, [Out] AFLLNPHGMEA BHBGJPKFAGB);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool BOKGENOKIOC(string NHBHGFEMCKC, [Out] AFLLNPHGMEA BHBGJPKFAGB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<LLGFAIJGGMG> KCAJDIOPADG();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool JHJBAINNLJN(Guid EDFMANFDKLC, [Out] LLGFAIJGGMG JOGAAHCGFLK);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? HIDHEBNHMLG(Guid EDFMANFDKLC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> NFNDENMOHAI(AIPAHMNCJKP EKEPPODJHCN, Guid EDFMANFDKLC);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<NPGEFAPAANA> IMJJKHLHIMN(AIPAHMNCJKP EKEPPODJHCN, Guid EDFMANFDKLC, int GFNDILIHOFK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string NIKHBKBENJL(MFEBDNMCCIM OBOOAPELMPF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool BGACCKNIGEA();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	NAHKCOBJMOP PCDJIEIHDJI(AFLLNPHGMEA KEMGNFAOCCE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties AFEDMFPHMNM(string ENOBBNAGNHN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<HHHCCNLMPJL<IKOGMGLMEPJ, string>> JBGKFJEFMBL(long HJPBKGBOCJN, RoomInventoryTagClientProperties FBEFHOGBKOJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<HHHCCNLMPJL<bool, string>> BKBEAJOFPID(long HJPBKGBOCJN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<HHHCCNLMPJL<bool, string>> LHLNAEEHHML(long CINEDGEJAIA, bool LMILHBBDLAK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool KAAHAKFFCOD();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> IKAEELIJIKM(long AJGBLNMOGKC, int BJHBFGAEEOB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool EAFCKMGLDMC(long HJPBKGBOCJN, [Out] IKOGMGLMEPJ NKGHDOPEJHN);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool NJOMGNFHHON(string GJELJGBKILI, [Out] IKOGMGLMEPJ NKGHDOPEJHN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool AGNOEDCLCFG(long HJPBKGBOCJN, Guid FIKGMCGPCHA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<IKOGMGLMEPJ> FBNLCFIHKEJ();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<IKOGMGLMEPJ> GAOENJIALIO();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<IKOGMGLMEPJ> AJKBBEKKEAL();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<AFLLNPHGMEA> KILIDLPHNEO(long HJPBKGBOCJN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool IFAJILCBLIL(string GJELJGBKILI, [Out] IReadOnlyList<AFLLNPHGMEA> OJFNPEMMIGO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CAFIFKCHJAI : KFJKIOCBFLM
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOEINPONPNJ(IEnumerable<AOLCJDKHAPO> GNLBCGGIPBC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DDEDFLAJHNB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LLGFAIJGGMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid BFKCMMGFLNM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83E1FD0", Offset = "0x83E05D0", VA = "0x1883E1FD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CMGCCBLFDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83E1DC0", Offset = "0x83E03C0", VA = "0x1883E1DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long EKDKOOIFECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long ALPAECJNLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? LPENJNOHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC70", Offset = "0x9E9270", VA = "0x1809EAC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9EACF0", Offset = "0x9E92F0", VA = "0x1809EACF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LBHJMFEIOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC0A3E0", Offset = "0xC089E0", VA = "0x180C0A3E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC09700", Offset = "0xC07D00", VA = "0x180C09700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83E1FE0", Offset = "0x83E05E0", VA = "0x1883E1FE0")]
	public LLGFAIJGGMG(AOLCJDKHAPO PJMJKCNHNBG, bool AKKBFHKCNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF6A3B0", Offset = "0xF689B0", VA = "0x180F6A3B0")]
	public LLGFAIJGGMG(Guid EDFMANFDKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83E1DE0", Offset = "0x83E03E0", VA = "0x1883E1DE0")]
	internal bool IEKHBJGOAKB(AOLCJDKHAPO PJMJKCNHNBG, long PKFIBKKAHHG, Action<LLGFAIJGGMG, int> BJHNCKOPMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83E1D60", Offset = "0x83E0360", VA = "0x1883E1D60")]
	internal void EOMHHHEAFPE(long IDMDBFGLNGO, Action<LLGFAIJGGMG, int> BJHNCKOPMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AFLLNPHGMEA : IEquatable<AFLLNPHGMEA>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int FDFBCFDGDBP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int PCPNIPPGMEP = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int PJANKBFCOIJ = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int CGLEHFEHPOH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int IFBHGNNPMPO = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid BFKCMMGFLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xE28760", Offset = "0xE26D60", VA = "0x180E28760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02A0", Offset = "0x6E9E8A0", VA = "0x186EA02A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> GANFANEEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte PBBEPMMNECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CA0", Offset = "0x9F32A0", VA = "0x1809F4CA0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F4C90", Offset = "0x9F3290", VA = "0x1809F4C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IHNAGNCLKBF FIGDBNMNPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xE82C30", Offset = "0xE81230", VA = "0x180E82C30")]
		[CompilerGenerated]
		get
		{
			return default(IHNAGNCLKBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2C898D0", Offset = "0x2C87ED0", VA = "0x182C898D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AFLLNPHGMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83E1740", Offset = "0x83DFD40", VA = "0x1883E1740")]
	public AFLLNPHGMEA(NAHKCOBJMOP PJMJKCNHNBG, [Optional] RoomInventoryItemProperties FBEFHOGBKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83E1010", Offset = "0x83DF610", VA = "0x1883E1010", Slot = "4")]
	public bool Equals(AFLLNPHGMEA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83E1190", Offset = "0x83DF790", VA = "0x1883E1190", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83E1370", Offset = "0x83DF970", VA = "0x1883E1370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83E1450", Offset = "0x83DFA50", VA = "0x1883E1450")]
	private HashSet<long> JFMBAABNIGI(NAHKCOBJMOP PJMJKCNHNBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PLCBHFGGLGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private LLGFAIJGGMG JOGAAHCGFLK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AFLLNPHGMEA FAFBGFDMKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LLGFAIJGGMG HJAEAMNIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83E20E0", Offset = "0x83E06E0", VA = "0x1883E20E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x83E2170", Offset = "0x83E0770", VA = "0x1883E2170")]
	public PLCBHFGGLGD(AFLLNPHGMEA BHBGJPKFAGB, [Optional] LLGFAIJGGMG JOGAAHCGFLK)
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
			[Cpp2IlInjected.Address(RVA = "0x83E2760", Offset = "0x83E0D60", VA = "0x1883E2760")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1132F70", Offset = "0x1131570", VA = "0x181132F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1372D50", Offset = "0x1371350", VA = "0x181372D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public EAMLMFIGALM Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(EAMLMFIGALM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA3C270", Offset = "0xA3A870", VA = "0x180A3C270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD1E5E0", Offset = "0xD1CBE0", VA = "0x180D1E5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFA0", Offset = "0xDBA5A0", VA = "0x180DBBFA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xDBBFD0", Offset = "0xDBA5D0", VA = "0x180DBBFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83E24C0", Offset = "0x83E0AC0", VA = "0x1883E24C0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83E2550", Offset = "0x83E0B50", VA = "0x1883E2550")]
		public static RoomInventoryItemProperties OKKBPPIELHH(RoomInventoryItemProperties FBEFHOGBKOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83E2700", Offset = "0x83E0D00", VA = "0x1883E2700")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class IKOGMGLMEPJ
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int ANJBGEKIDAP = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string JGPIPNPJJEO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder FCDKIGOOINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string HAKPICBGCEH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long LGADKPMDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83E18A0", Offset = "0x83DFEA0", VA = "0x1883E18A0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83E18D0", Offset = "0x83DFED0", VA = "0x1883E18D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JGPGEIPKNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83E1B10", Offset = "0x83E0110", VA = "0x1883E1B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public IKOGMGLMEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x83E1C70", Offset = "0x83E0270", VA = "0x1883E1C70")]
	public IKOGMGLMEPJ(HKDBDNMIAHA PJMJKCNHNBG, [Optional] RoomInventoryTagClientProperties FBEFHOGBKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x83E1B30", Offset = "0x83E0130", VA = "0x1883E1B30")]
	public HKDBDNMIAHA KCJLHKLFNEG()
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
			[Cpp2IlInjected.Address(RVA = "0x83E29C0", Offset = "0x83E0FC0", VA = "0x1883E29C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83E27B0", Offset = "0x83E0DB0", VA = "0x1883E27B0")]
		public void OPPHNFCLHEO(Dictionary<string, object> JFCMAFFDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
