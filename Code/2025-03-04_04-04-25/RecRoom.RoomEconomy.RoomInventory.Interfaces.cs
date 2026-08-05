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
public class CDJICEJBLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly FMCINKJPKCF IONAMOKNDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long AGHLCEGEAOJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CEIMIIOANMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EB30", Offset = "0x7C6D130", VA = "0x187C6EB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EB40", Offset = "0x7C6D140", VA = "0x187C6EB40")]
	public CDJICEJBLOA(FMCINKJPKCF BIEIOPPGBOB, long BBEJNKBNMID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JHPMJNHJKJO
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
public interface GABCDJHBCIB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FKDOIPNGGAF NABEBFPHEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JKOOBLENGDB<BKLMOEMONGA> KJCLHCHGMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JKOOBLENGDB<Guid> KONFDJPOCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FLEKKBCEDJE<CBHHOAICOCI, int> LPCLDHGPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JKOOBLENGDB<DCBKNJDFBLO> MBLNAMKNFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JKOOBLENGDB<long> OCEOJELHKJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FKDOIPNGGAF EEPKGOCAHHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FKDOIPNGGAF FNDHJDCACKP
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
	Task<JOFBNNGKBOO<BKLMOEMONGA, string>> JNLALKKPIDG(Guid? AHJIJCMJHIE, long FFFLOIOFAMB, string OMOOEGOLALI, string GPFCOHGCDPH, string BDFBPKBBNAC, RoomInventoryItemProperties GHLDAFCMHAC, byte LFCFKCMCBCB, int NHCBHMJDLHA, [Optional] List<long> OOLAFONFICG, [Optional] List<JLKDPOGIICC> FEHLDHHPDPJ, bool KMKFGPIGKFG = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<JOFBNNGKBOO<BKLMOEMONGA, string>> JPGFGPMDPAE(Guid NHMBBGCGEGI, long FFFLOIOFAMB, [Optional] string OMOOEGOLALI, [Optional] string GPFCOHGCDPH, [Optional] string BDFBPKBBNAC, [Optional] List<long> OOLAFONFICG, [Optional] Dictionary<string, RoomInventoryTagClientProperties> FEHLDHHPDPJ, [Optional] RoomInventoryItemProperties GHLDAFCMHAC, [Optional] byte? LFCFKCMCBCB, [Optional] int? NHCBHMJDLHA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<JOFBNNGKBOO<bool, string>> NOFJFDLOECP(Guid NHMBBGCGEGI, long FFFLOIOFAMB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<BKLMOEMONGA> KGPOKIGKIBI();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<BKLMOEMONGA> LKEEEFAPCBE();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool MKBMGNODAMD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool ABAOINLOEJH(Guid NHMBBGCGEGI, [Out] BKLMOEMONGA OKGLLGKHNLD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool NGLBPPNKNFA(string HJEMLOJPNPA, [Out] BKLMOEMONGA OKGLLGKHNLD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<CBHHOAICOCI> GKCFAAOEKOH();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool FHNJNPCPEPK(Guid NHMBBGCGEGI, [Out] CBHHOAICOCI AKJNNFEFEDB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? KFEGLKNGGCM(Guid NHMBBGCGEGI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> BFLHDGOMBIA(OPHKANJGPPK OEIBHCOIKMG, Guid NHMBBGCGEGI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<CDJICEJBLOA> OGMGBFHAAIP(OPHKANJGPPK OEIBHCOIKMG, Guid NHMBBGCGEGI, int IAKJCHAJGGI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string DCFJHGKEIOF(FMCINKJPKCF BIEIOPPGBOB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JCJMJFJHJBN();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	KBEJPLPECFK KKDBHHEKKAC(BKLMOEMONGA BKOBHLGCLPA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties GAOOLIGBFNK(string GPGKGPPKHHA);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<JOFBNNGKBOO<DCBKNJDFBLO, string>> PKECENFLPNL(long HMKNPJCHMCD, RoomInventoryTagClientProperties GHLDAFCMHAC);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<JOFBNNGKBOO<bool, string>> GMBHPDGMOMG(long HMKNPJCHMCD);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<JOFBNNGKBOO<bool, string>> BHLDAHFCDIK(long FFFLOIOFAMB, bool NPPHCJJHKFL);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool OFLKCKFLCAL();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> JIKMBBILHEJ(long IAGNMHGDCPG, int LKFJHIBMEJF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool OPHFFOIPGFJ(long HMKNPJCHMCD, [Out] DCBKNJDFBLO LPGICKNGFNK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool OBHNKPCINDF(string BPIJDFFGMBJ, [Out] DCBKNJDFBLO LPGICKNGFNK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool MIPJFAAGOJN(long HMKNPJCHMCD, Guid CLNIDOADBBM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<DCBKNJDFBLO> GJJIILAKPDP();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<DCBKNJDFBLO> KPIFJKJIIEE();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<DCBKNJDFBLO> EIJLOIDEEPG();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<BKLMOEMONGA> ABGMLEKMHFL(long HMKNPJCHMCD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool PFAMJFCEPFA(string BPIJDFFGMBJ, [Out] IReadOnlyList<BKLMOEMONGA> KNIPJHJCMNN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HELJKBNOMFB : GABCDJHBCIB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKFHMAMPOCG(IEnumerable<GJLNEEJFHPJ> GALGLJKDDKK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FBGDPJFELLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CBHHOAICOCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid MAIJKLKCAAB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E880", Offset = "0x7C6CE80", VA = "0x187C6E880")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CEIMIIOANMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E860", Offset = "0x7C6CE60", VA = "0x187C6E860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long GNKMLLHELNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x956C80", Offset = "0x955280", VA = "0x180956C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long APJDDOHOJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9529C0", Offset = "0x950FC0", VA = "0x1809529C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? HAEOHLLOEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x959440", Offset = "0x957A40", VA = "0x180959440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x959490", Offset = "0x957A90", VA = "0x180959490")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool HEBGKDGIJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA1400", Offset = "0xA9FA00", VA = "0x180AA1400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAA0ED0", Offset = "0xA9F4D0", VA = "0x180AA0ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EA80", Offset = "0x7C6D080", VA = "0x187C6EA80")]
	public CBHHOAICOCI(GJLNEEJFHPJ ALHHFJAOPJI, bool ABIJGPAGEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xDBBD20", Offset = "0xDBA320", VA = "0x180DBBD20")]
	public CBHHOAICOCI(Guid NHMBBGCGEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E890", Offset = "0x7C6CE90", VA = "0x187C6E890")]
	internal bool PLJNMJIHBJD(GJLNEEJFHPJ ALHHFJAOPJI, long ELOEDDLNDLK, Action<CBHHOAICOCI, int> NBHMCCHGCAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E800", Offset = "0x7C6CE00", VA = "0x187C6E800")]
	internal void DLMAJKGNAIJ(long MODHJFPLCDL, Action<CBHHOAICOCI, int> NBHMCCHGCAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BKLMOEMONGA : IEquatable<BKLMOEMONGA>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int JBGDGFPKGML = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int OPGFBAMEEMK = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int OLAPMNOOIOG = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int PLOIMIHNGCD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int LEAPAACNNMB = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid MAIJKLKCAAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAD38D0", Offset = "0xAD1ED0", VA = "0x180AD38D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAD38E0", Offset = "0xAD1EE0", VA = "0x180AD38E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long MBHFNFGPIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB65960", Offset = "0xB63F60", VA = "0x180B65960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string BAMOFOGPNJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HHPFLEEHPMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x956AD0", Offset = "0x9550D0", VA = "0x180956AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime GOIAPMAOBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCD2FD0", Offset = "0xCD15D0", VA = "0x180CD2FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime DGKFKNCEJNF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x680BEC0", Offset = "0x680A4C0", VA = "0x18680BEC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> BNDJLEIKMIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x956B10", Offset = "0x955110", VA = "0x180956B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties OJOAHAIMDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x956CC0", Offset = "0x9552C0", VA = "0x180956CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x956D40", Offset = "0x955340", VA = "0x180956D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte DAAJNEDOHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x956C70", Offset = "0x955270", VA = "0x180956C70")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x956C90", Offset = "0x955290", VA = "0x180956C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MONBNMPFMMO GKMLNPEPKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCF9370", Offset = "0xCF7970", VA = "0x180CF9370")]
		[CompilerGenerated]
		get
		{
			return default(MONBNMPFMMO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2A3EEF0", Offset = "0x2A3D4F0", VA = "0x182A3EEF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public BKLMOEMONGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E6A0", Offset = "0x7C6CCA0", VA = "0x187C6E6A0")]
	public BKLMOEMONGA(KBEJPLPECFK ALHHFJAOPJI, [Optional] RoomInventoryItemProperties GHLDAFCMHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DF70", Offset = "0x7C6C570", VA = "0x187C6DF70", Slot = "4")]
	public bool Equals(BKLMOEMONGA OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E0F0", Offset = "0x7C6C6F0", VA = "0x187C6E0F0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E2D0", Offset = "0x7C6C8D0", VA = "0x187C6E2D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E3B0", Offset = "0x7C6C9B0", VA = "0x187C6E3B0")]
	private HashSet<long> MJNBHEPCKED(KBEJPLPECFK ALHHFJAOPJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PAPPJOFHMML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CBHHOAICOCI AKJNNFEFEDB;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BKLMOEMONGA IKHIHIHBKMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CBHHOAICOCI MLHFEMCOPIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F060", Offset = "0x7C6D660", VA = "0x187C6F060")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F0F0", Offset = "0x7C6D6F0", VA = "0x187C6F0F0")]
	public PAPPJOFHMML(BKLMOEMONGA OKGLLGKHNLD, [Optional] CBHHOAICOCI AKJNNFEFEDB)
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
			[Cpp2IlInjected.Address(RVA = "0x7C6F6F0", Offset = "0x7C6DCF0", VA = "0x187C6F6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xF63F60", Offset = "0xF62560", VA = "0x180F63F60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x117F390", Offset = "0x117D990", VA = "0x18117F390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public JHPMJNHJKJO Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480")]
			[CompilerGenerated]
			get
			{
				return default(JHPMJNHJKJO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x954450", Offset = "0x952A50", VA = "0x180954450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB2AD20", Offset = "0xB29320", VA = "0x180B2AD20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xBAEAF0", Offset = "0xBAD0F0", VA = "0x180BAEAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xC9DCD0", Offset = "0xC9C2D0", VA = "0x180C9DCD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC9DDF0", Offset = "0xC9C3F0", VA = "0x180C9DDF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xC9DCE0", Offset = "0xC9C2E0", VA = "0x180C9DCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F450", Offset = "0x7C6DA50", VA = "0x187C6F450", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F4E0", Offset = "0x7C6DAE0", VA = "0x187C6F4E0")]
		public static RoomInventoryItemProperties KKJJGGFFFGK(RoomInventoryItemProperties GHLDAFCMHAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F690", Offset = "0x7C6DC90", VA = "0x187C6F690")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DCBKNJDFBLO
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int PABPAJLLCGC = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string OAACCKDDDLJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder HFPCKCBGMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string POPCDNHHAHA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long GLPFJENGKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xBBE930", Offset = "0xBBCF30", VA = "0x180BBE930")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string OPDMIMOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EC60", Offset = "0x7C6D260", VA = "0x187C6EC60")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string DDMJIJIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EC90", Offset = "0x7C6D290", VA = "0x187C6EC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties OJOAHAIMDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PMBLLIOKNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EC40", Offset = "0x7C6D240", VA = "0x187C6EC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public DCBKNJDFBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EF60", Offset = "0x7C6D560", VA = "0x187C6EF60")]
	public DCBKNJDFBLO(JLKDPOGIICC ALHHFJAOPJI, [Optional] RoomInventoryTagClientProperties GHLDAFCMHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EB80", Offset = "0x7C6D180", VA = "0x187C6EB80")]
	public JLKDPOGIICC IEONICHBNOM()
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
			[Cpp2IlInjected.Address(RVA = "0x7C6F950", Offset = "0x7C6DF50", VA = "0x187C6F950")]
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
			[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F740", Offset = "0x7C6DD40", VA = "0x187C6F740")]
		public void JCDFFKOJEAN(Dictionary<string, object> LAJIGGEGODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
