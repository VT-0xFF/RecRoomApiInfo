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
public class MPDOEGHIBFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly LHABPDEBEFJ IBGOAACNDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long GFOKFGGJOIM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NEKMNEOBGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x858E8D0", Offset = "0x858D6D0", VA = "0x18858E8D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x858E8E0", Offset = "0x858D6E0", VA = "0x18858E8E0")]
	public MPDOEGHIBFA(LHABPDEBEFJ BPINCJLADGC, long ALFGNAHPKIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CHNHJINOACC
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
public interface KKOCNIAPAFM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LLEAAEBCCKF KMHLIGPBLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IMAAKJGDPMH<CJJLLLNGFKM> JGDAJIILBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	IMAAKJGDPMH<Guid> JMGPKOOEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DPJKFCBILHL<NKADEBCKGAC, int> PLBLLINCFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IMAAKJGDPMH<HMNCEMLKPAE> IALNOCHDAJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IMAAKJGDPMH<long> FDHOMNHKBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LLEAAEBCCKF JOAHNBCKFOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LLEAAEBCCKF AHICIOHGDGI
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
	Task<JKEBLLKKBOM<CJJLLLNGFKM, string>> OFLKOGIBONK(Guid? AGGEDCBPBDE, long CEACGIDOODJ, string IHGFMOMOADA, string CDDMBEEGKND, string DBCDJMCMAJM, RoomInventoryItemProperties ADPBPEDNFCM, byte HMDNNMIJNJJ, int DEJLIDMJHPI, [Optional] List<long> LPODAADEFKK, [Optional] List<EHEPKBOFNKL> NKOOIEHKAOG, bool KCOAHFLFPNO = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<JKEBLLKKBOM<CJJLLLNGFKM, string>> CLBPOPLDFBG(Guid PPGGGPECKLI, long CEACGIDOODJ, [Optional] string IHGFMOMOADA, [Optional] string CDDMBEEGKND, [Optional] string DBCDJMCMAJM, [Optional] List<long> LPODAADEFKK, [Optional] Dictionary<string, RoomInventoryTagClientProperties> NKOOIEHKAOG, [Optional] RoomInventoryItemProperties ADPBPEDNFCM, [Optional] byte? HMDNNMIJNJJ, [Optional] int? DEJLIDMJHPI);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<JKEBLLKKBOM<bool, string>> BCEMBOKMDJH(Guid PPGGGPECKLI, long CEACGIDOODJ);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<CJJLLLNGFKM> JCHAIJFOHPN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<CJJLLLNGFKM> DJJJKGHOLHM();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool LCCNCLLJLJO();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool EAEPLGHIDHL(Guid PPGGGPECKLI, [Out] CJJLLLNGFKM DPCLFPFFHIF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool DMFKIMOAPOO(string GDFFGOMDOJI, [Out] CJJLLLNGFKM DPCLFPFFHIF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<NKADEBCKGAC> PLNHACIHMDC();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool PKNOCNPALIP(Guid PPGGGPECKLI, [Out] NKADEBCKGAC GBCBLMPEJAA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? EJFLLPMJIKP(Guid PPGGGPECKLI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> JFCCNPCOJBL(AHNIMKBJLEJ ENPELEHFGFF, Guid PPGGGPECKLI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<MPDOEGHIBFA> NKBFHHOGIPL(AHNIMKBJLEJ ENPELEHFGFF, Guid PPGGGPECKLI, int CGKKBLKIKKA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string NHIMLLEIKBN(LHABPDEBEFJ BPINCJLADGC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool GPCOFMKGLJA();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MAHLFJHHAOK CLEDAEHIAJA(CJJLLLNGFKM APPALJINPAA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties GKKKJAJCIHJ(string OFIALCCLDGE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<JKEBLLKKBOM<HMNCEMLKPAE, string>> JLFMIIPMLBI(long NFFIHLEPONH, RoomInventoryTagClientProperties ADPBPEDNFCM);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<JKEBLLKKBOM<bool, string>> AILNIOJPBNG(long NFFIHLEPONH);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<JKEBLLKKBOM<bool, string>> GILDLIEHGMO(long CEACGIDOODJ, bool PEFDDLGIKNJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool PGMIIIPAKFJ();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> AGKJMMJPLNP(long GIBAHGHGMOP, int OEJMGPHJBIP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool NFBCMLEHOGN(long NFFIHLEPONH, [Out] HMNCEMLKPAE NFNCFFGLNDI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool GNGHENMCGJA(string EONPHNIJJBM, [Out] HMNCEMLKPAE NFNCFFGLNDI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool CJMFCGBOGOP(long NFFIHLEPONH, Guid IKEAOGJBFFB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<HMNCEMLKPAE> GHMDDGLLHDH();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<HMNCEMLKPAE> GPJOPNALAKJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<HMNCEMLKPAE> MCLPCEFMFBH();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<CJJLLLNGFKM> AONIMAOHDDK(long NFFIHLEPONH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool NDPPKLEACDB(string EONPHNIJJBM, [Out] IReadOnlyList<CJJLLLNGFKM> FINNBGEFMMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MLBFKJKNKNH : KKOCNIAPAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKKFGCNBLDN(IEnumerable<GLNKJILIANA> LDOPKKGHONL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CIIHCCCOHLB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NKADEBCKGAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid ABAFIKBLBBK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long GFOKFGGJOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x858E920", Offset = "0x858D720", VA = "0x18858E920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NEKMNEOBGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x858E990", Offset = "0x858D790", VA = "0x18858E990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long LCKKEOIMOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAE0", Offset = "0xA0D8E0", VA = "0x180A0EAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long GBNEKIFIJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA128F0", Offset = "0xA116F0", VA = "0x180A128F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? IBJNHCPDMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA11350", Offset = "0xA10150", VA = "0x180A11350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA11330", Offset = "0xA10130", VA = "0x180A11330")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MODGAIKHJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC2CF80", Offset = "0xC2BD80", VA = "0x180C2CF80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xC2CEE0", Offset = "0xC2BCE0", VA = "0x180C2CEE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x858EBA0", Offset = "0x858D9A0", VA = "0x18858EBA0")]
	public NKADEBCKGAC(GLNKJILIANA PDLCIFEIIGK, bool IHCJKKNJLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xFE3E80", Offset = "0xFE2C80", VA = "0x180FE3E80")]
	public NKADEBCKGAC(Guid PPGGGPECKLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x858E9B0", Offset = "0x858D7B0", VA = "0x18858E9B0")]
	internal bool JPEBABACHJL(GLNKJILIANA PDLCIFEIIGK, long JABOIHNNEKH, Action<NKADEBCKGAC, int> KGJPMIGEBIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x858E930", Offset = "0x858D730", VA = "0x18858E930")]
	internal void BIONKGBLLOB(long LBJPFENCPGE, Action<NKADEBCKGAC, int> KGJPMIGEBIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CJJLLLNGFKM : IEquatable<CJJLLLNGFKM>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int FJONJKJLOKJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int NBEHBPHOLFH = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int DIBDJEPDACJ = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int BGBDHFIOPFL = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int PEEHJPHFABH = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid ABAFIKBLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xD60130", Offset = "0xD5EF30", VA = "0x180D60130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long FBNGFADIKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F70", Offset = "0xCD4D70", VA = "0x180CD5F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string OLGOMDLLMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA13780", Offset = "0xA12580", VA = "0x180A13780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string OGEKIGBBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime KLKDKMAPOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xE52500", Offset = "0xE51300", VA = "0x180E52500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime LMHCPFIKIHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF1AD0", Offset = "0x6FF08D0", VA = "0x186FF1AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> DMGEPMEHDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA0D010", Offset = "0xA0BE10", VA = "0x180A0D010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties AHPNGHHEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA0D030", Offset = "0xA0BE30", VA = "0x180A0D030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte JDLMNFBMMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED40", Offset = "0xA0DB40", VA = "0x180A0ED40")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAD0", Offset = "0xA0D8D0", VA = "0x180A0EAD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FLGDJDIBGKI KEMFIGNEAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xEA6FB0", Offset = "0xEA5DB0", VA = "0x180EA6FB0")]
		[CompilerGenerated]
		get
		{
			return default(FLGDJDIBGKI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2D32320", Offset = "0x2D31120", VA = "0x182D32320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public CJJLLLNGFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x858E290", Offset = "0x858D090", VA = "0x18858E290")]
	public CJJLLLNGFKM(MAHLFJHHAOK PDLCIFEIIGK, [Optional] RoomInventoryItemProperties ADPBPEDNFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x858DB70", Offset = "0x858C970", VA = "0x18858DB70", Slot = "4")]
	public bool Equals(CJJLLLNGFKM HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x858DCF0", Offset = "0x858CAF0", VA = "0x18858DCF0", Slot = "0")]
	public override bool Equals(object GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x858E1B0", Offset = "0x858CFB0", VA = "0x18858E1B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x858DEC0", Offset = "0x858CCC0", VA = "0x18858DEC0")]
	private HashSet<long> GGPAELDKHBP(MAHLFJHHAOK PDLCIFEIIGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AABGKCINGEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NKADEBCKGAC GBCBLMPEJAA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CJJLLLNGFKM JCIKJIOPBLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NKADEBCKGAC KDDLEDPMCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x858D790", Offset = "0x858C590", VA = "0x18858D790")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x858D820", Offset = "0x858C620", VA = "0x18858D820")]
	public AABGKCINGEI(CJJLLLNGFKM DPCLFPFFHIF, [Optional] NKADEBCKGAC GBCBLMPEJAA)
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
			[Cpp2IlInjected.Address(RVA = "0x858EEF0", Offset = "0x858DCF0", VA = "0x18858EEF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1173110", Offset = "0x1171F10", VA = "0x181173110")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x13C56B0", Offset = "0x13C44B0", VA = "0x1813C56B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CHNHJINOACC Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990")]
			[CompilerGenerated]
			get
			{
				return default(CHNHJINOACC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA574D0", Offset = "0xA562D0", VA = "0x180A574D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD49CB0", Offset = "0xD48AB0", VA = "0x180D49CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA0CC40", Offset = "0xA0BA40", VA = "0x180A0CC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CC0", Offset = "0xDD7AC0", VA = "0x180DD8CC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAD8900", Offset = "0xAD7700", VA = "0x180AD8900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CA0", Offset = "0xDD7AA0", VA = "0x180DD8CA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xDD8CB0", Offset = "0xDD7AB0", VA = "0x180DD8CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x858EC50", Offset = "0x858DA50", VA = "0x18858EC50", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties HBLONCAMFLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x858ECE0", Offset = "0x858DAE0", VA = "0x18858ECE0")]
		public static RoomInventoryItemProperties LAGKNEOGNDP(RoomInventoryItemProperties ADPBPEDNFCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x858EE90", Offset = "0x858DC90", VA = "0x18858EE90")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class HMNCEMLKPAE
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int CDANGABCCBG = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string DKJHJNGABDG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder HMBCODEMBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string EOGLOJLBGBA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NDHKHHEELCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xD48D00", Offset = "0xD47B00", VA = "0x180D48D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x858E410", Offset = "0x858D210", VA = "0x18858E410")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string KPDIBFFPHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x858E500", Offset = "0x858D300", VA = "0x18858E500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties AHPNGHHEAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA12900", Offset = "0xA11700", VA = "0x180A12900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FPLBGANODMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x858E3F0", Offset = "0x858D1F0", VA = "0x18858E3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public HMNCEMLKPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x858E7D0", Offset = "0x858D5D0", VA = "0x18858E7D0")]
	public HMNCEMLKPAE(EHEPKBOFNKL PDLCIFEIIGK, [Optional] RoomInventoryTagClientProperties ADPBPEDNFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x858E440", Offset = "0x858D240", VA = "0x18858E440")]
	public EHEPKBOFNKL IGJOGIBDJPH()
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
			[Cpp2IlInjected.Address(RVA = "0x858F150", Offset = "0x858DF50", VA = "0x18858F150")]
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
			[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x858EF40", Offset = "0x858DD40", VA = "0x18858EF40")]
		public void CLEHBILODKK(Dictionary<string, object> CEABBOIMCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
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
