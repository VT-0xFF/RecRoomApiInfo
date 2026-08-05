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
		[Cpp2IlInjected.Address(RVA = "0x83FBDE0", Offset = "0x83FADE0", VA = "0x1883FBDE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x83FBDF0", Offset = "0x83FADF0", VA = "0x1883FBDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83FBD20", Offset = "0x83FAD20", VA = "0x1883FBD20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CMGCCBLFDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83FBB10", Offset = "0x83FAB10", VA = "0x1883FBB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long EKDKOOIFECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long ALPAECJNLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? LPENJNOHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C70", Offset = "0x9EFC70", VA = "0x1809F0C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CF0", Offset = "0x9EFCF0", VA = "0x1809F0CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LBHJMFEIOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBE1E20", Offset = "0xBE0E20", VA = "0x180BE1E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xBE1140", Offset = "0xBE0140", VA = "0x180BE1140")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83FBD30", Offset = "0x83FAD30", VA = "0x1883FBD30")]
	public LLGFAIJGGMG(AOLCJDKHAPO PJMJKCNHNBG, bool AKKBFHKCNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF59520", Offset = "0xF58520", VA = "0x180F59520")]
	public LLGFAIJGGMG(Guid EDFMANFDKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83FBB30", Offset = "0x83FAB30", VA = "0x1883FBB30")]
	internal bool IEKHBJGOAKB(AOLCJDKHAPO PJMJKCNHNBG, long PKFIBKKAHHG, Action<LLGFAIJGGMG, int> BJHNCKOPMPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83FBAB0", Offset = "0x83FAAB0", VA = "0x1883FBAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xF79DB0", Offset = "0xF78DB0", VA = "0x180F79DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xE16A00", Offset = "0xE15A00", VA = "0x180E16A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77B0", Offset = "0x6EC67B0", VA = "0x186EC77B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> GANFANEEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte PBBEPMMNECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9FACA0", Offset = "0x9F9CA0", VA = "0x1809FACA0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9FAC90", Offset = "0x9F9C90", VA = "0x1809FAC90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IHNAGNCLKBF FIGDBNMNPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xE5B220", Offset = "0xE5A220", VA = "0x180E5B220")]
		[CompilerGenerated]
		get
		{
			return default(IHNAGNCLKBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A2B0", Offset = "0x2C892B0", VA = "0x182C8A2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public AFLLNPHGMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x83FB470", Offset = "0x83FA470", VA = "0x1883FB470")]
	public AFLLNPHGMEA(NAHKCOBJMOP PJMJKCNHNBG, [Optional] RoomInventoryItemProperties FBEFHOGBKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83FAD50", Offset = "0x83F9D50", VA = "0x1883FAD50", Slot = "4")]
	public bool Equals(AFLLNPHGMEA MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83FAED0", Offset = "0x83F9ED0", VA = "0x1883FAED0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83FB0A0", Offset = "0x83FA0A0", VA = "0x1883FB0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83FB180", Offset = "0x83FA180", VA = "0x1883FB180")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LLGFAIJGGMG HJAEAMNIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83FBE30", Offset = "0x83FAE30", VA = "0x1883FBE30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x83FBEC0", Offset = "0x83FAEC0", VA = "0x1883FBEC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x83FC4C0", Offset = "0x83FB4C0", VA = "0x1883FC4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x111FC50", Offset = "0x111EC50", VA = "0x18111FC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1357050", Offset = "0x1356050", VA = "0x181357050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public EAMLMFIGALM Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			get
			{
				return default(EAMLMFIGALM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA41D50", Offset = "0xA40D50", VA = "0x180A41D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD073A0", Offset = "0xD063A0", VA = "0x180D073A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xDA98B0", Offset = "0xDA88B0", VA = "0x180DA98B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA92FB0", Offset = "0xA91FB0", VA = "0x180A92FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xDA9870", Offset = "0xDA8870", VA = "0x180DA9870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xDA98A0", Offset = "0xDA88A0", VA = "0x180DA98A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83FC220", Offset = "0x83FB220", VA = "0x1883FC220", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83FC2B0", Offset = "0x83FB2B0", VA = "0x1883FC2B0")]
		public static RoomInventoryItemProperties OKKBPPIELHH(RoomInventoryItemProperties FBEFHOGBKOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83FC460", Offset = "0x83FB460", VA = "0x1883FC460")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xCF3540", Offset = "0xCF2540", VA = "0x180CF3540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83FB5D0", Offset = "0x83FA5D0", VA = "0x1883FB5D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83FB600", Offset = "0x83FA600", VA = "0x1883FB600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JGPGEIPKNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83FB850", Offset = "0x83FA850", VA = "0x1883FB850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public IKOGMGLMEPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x83FB9B0", Offset = "0x83FA9B0", VA = "0x1883FB9B0")]
	public IKOGMGLMEPJ(HKDBDNMIAHA PJMJKCNHNBG, [Optional] RoomInventoryTagClientProperties FBEFHOGBKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x83FB870", Offset = "0x83FA870", VA = "0x1883FB870")]
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
			[Cpp2IlInjected.Address(RVA = "0x83FC720", Offset = "0x83FB720", VA = "0x1883FC720")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83FC510", Offset = "0x83FB510", VA = "0x1883FC510")]
		public void OPPHNFCLHEO(Dictionary<string, object> JFCMAFFDJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
