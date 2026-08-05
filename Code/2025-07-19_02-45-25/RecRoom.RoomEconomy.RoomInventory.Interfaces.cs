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
public class BHMOJPFPGLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly CFKLLHHINAN IJBEHPGCOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long JHCCKPLGFOI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JLKIGLNJIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x89B9940", Offset = "0x89B8940", VA = "0x1889B9940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x89B9950", Offset = "0x89B8950", VA = "0x1889B9950")]
	public BHMOJPFPGLF(CFKLLHHINAN BGOCMPMGKKI, long MFFPIAPMHCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DBJNLKFCIJI
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
public interface IBHGACJGBBI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	LELKCPPPMEI CKBDLDLLNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	FHLIAIDPCMK<GIDLAGOMAOA> DOAOIIHBMBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FHLIAIDPCMK<Guid> HPDFJDIEAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MDNONHHFIOF<GAPEDJJHMDL, int> NKFFOBNMIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FHLIAIDPCMK<BIMABKLOIIJ> MIGNJIKDALB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FHLIAIDPCMK<long> HOCHFLHOAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LELKCPPPMEI DPMOLFLFPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	LELKCPPPMEI HOLJAFDKNBA
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
	Task<DAFIFKKNPFP<GIDLAGOMAOA, string>> PNMKEAOEGLH(Guid? FFGLKCFBAJA, long DJJNJEHBMJK, string HJLBILHBIIC, string GAPCMICLLJD, string IMHEEBEEIJH, RoomInventoryItemProperties KAEILAKIAKE, byte CBGBGGEBCJG, int AHIICABHHJO, [Optional] List<long> JOOOHKEHDKL, [Optional] List<JDFGKPEHOFB> KNKOMEIPJCO, bool BNOMIEFKLPG = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<DAFIFKKNPFP<GIDLAGOMAOA, string>> IPECFDAFPPG(Guid PMKCJLJOEAA, long DJJNJEHBMJK, [Optional] string HJLBILHBIIC, [Optional] string GAPCMICLLJD, [Optional] string IMHEEBEEIJH, [Optional] List<long> JOOOHKEHDKL, [Optional] Dictionary<string, RoomInventoryTagClientProperties> KNKOMEIPJCO, [Optional] RoomInventoryItemProperties KAEILAKIAKE, [Optional] byte? CBGBGGEBCJG, [Optional] int? AHIICABHHJO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<DAFIFKKNPFP<bool, string>> GJMMPNILPNN(Guid PMKCJLJOEAA, long DJJNJEHBMJK);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<GIDLAGOMAOA> CBKDADPCNIA();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<GIDLAGOMAOA> ODGFGNNNHNL();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool KJGODHINKOF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool OFHOPAHIBCM(Guid PMKCJLJOEAA, [Out] GIDLAGOMAOA KAJMBNDCKHH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool LDCFLIJBEFL(string PLPKFDOFBAA, [Out] GIDLAGOMAOA KAJMBNDCKHH);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<GAPEDJJHMDL> GHIPOIEKIGC();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool ELFDLEKHAIB(Guid PMKCJLJOEAA, [Out] GAPEDJJHMDL HIJLNCPNMLP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? AOHBBBJCJPI(Guid PMKCJLJOEAA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> MFPJOBHDGOD(IALDHONKEJC MFOAOKBDIIM, Guid PMKCJLJOEAA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<BHMOJPFPGLF> OOIEPDJNCDE(IALDHONKEJC MFOAOKBDIIM, Guid PMKCJLJOEAA, int KGCCFJCBKGO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string ILGEGGCDOPG(CFKLLHHINAN BGOCMPMGKKI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool LGMGKPNGCCG();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	ICHKNBGHKHE MMGKMJKJOOF(GIDLAGOMAOA CLPNCMEJAIK);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties ICPGGLFKKNG(string MOODHFCOIPE);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<DAFIFKKNPFP<BIMABKLOIIJ, string>> CJCPNEEPEEG(long PPBCCKPGGJD, RoomInventoryTagClientProperties KAEILAKIAKE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<DAFIFKKNPFP<bool, string>> GGBOJPODNEG(long PPBCCKPGGJD);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<DAFIFKKNPFP<bool, string>> IKLIMHGLNHF(long DJJNJEHBMJK, bool PHEOOAJAJMA);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool NNLNPFOIHBM();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> AENEKIOGHCO(long KJOLKKHJIBM, int AKAOCPNGEDI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool HKCOJHKMGNK(long PPBCCKPGGJD, [Out] BIMABKLOIIJ OANHEJOGAAF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool INHIMLOHPNL(string JAICJDINFJF, [Out] BIMABKLOIIJ OANHEJOGAAF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool LCKOIFEPDAB(long PPBCCKPGGJD, Guid JDMEHGGKIMC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<BIMABKLOIIJ> IPDIGPGBIGM();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<BIMABKLOIIJ> DCLDKIICPCJ();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<BIMABKLOIIJ> DEEGFOJFKBN();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<GIDLAGOMAOA> OFJAEBNEJOF(long PPBCCKPGGJD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LPPOKCMDBEB(string JAICJDINFJF, [Out] IReadOnlyList<GIDLAGOMAOA> FDDCKADJHOG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LEKELPMOABO : IBHGACJGBBI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPEACONLDAL(IEnumerable<OCOMMAHLAAD> JGMGEFBIENL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ODJMNMCIFMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GAPEDJJHMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid OPEOEPOBABP;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89B9E90", Offset = "0x89B8E90", VA = "0x1889B9E90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JLKIGLNJIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89B9E70", Offset = "0x89B8E70", VA = "0x1889B9E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long JBHCGNHHFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA68450", Offset = "0xA67450", VA = "0x180A68450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long LDIAPGGFHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA672F0", Offset = "0xA662F0", VA = "0x180A672F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? LGHPFDKJIBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA65590", Offset = "0xA64590", VA = "0x180A65590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA65560", Offset = "0xA64560", VA = "0x180A65560")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool EMGFGHHOHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD17AA0", Offset = "0xD16AA0", VA = "0x180D17AA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD172B0", Offset = "0xD162B0", VA = "0x180D172B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x89BA0F0", Offset = "0x89B90F0", VA = "0x1889BA0F0")]
	public GAPEDJJHMDL(OCOMMAHLAAD OFNBMHFAAGJ, bool KCOAIHJGAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10A13E0", Offset = "0x10A03E0", VA = "0x1810A13E0")]
	public GAPEDJJHMDL(Guid PMKCJLJOEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x89B9F00", Offset = "0x89B8F00", VA = "0x1889B9F00")]
	internal bool PHBANHJIEKG(OCOMMAHLAAD OFNBMHFAAGJ, long GCDPFAPKPPA, Action<GAPEDJJHMDL, int> ADIOAKMKJGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x89B9EA0", Offset = "0x89B8EA0", VA = "0x1889B9EA0")]
	internal void OILBEIAMMAA(long DNCKLFKNFBL, Action<GAPEDJJHMDL, int> ADIOAKMKJGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GIDLAGOMAOA : IEquatable<GIDLAGOMAOA>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int DONAIGDOFJE = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int PGCAHPHFKPH = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int LJLCPBCKOLE = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int JMMLGFAJALN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int NLILHNHFICI = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid OPEOEPOBABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE70", Offset = "0xE5DE70", VA = "0x180E5EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long ANKPNEKDDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xDCBC10", Offset = "0xDCAC10", VA = "0x180DCBC10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string FMJEMOMMPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA63FA0", Offset = "0xA62FA0", VA = "0x180A63FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string CHIILACPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA68420", Offset = "0xA67420", VA = "0x180A68420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime POBHENPHPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA66F70", Offset = "0xA65F70", VA = "0x180A66F70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF68050", Offset = "0xF67050", VA = "0x180F68050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime GIPIHLKJPLD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1353980", Offset = "0x1352980", VA = "0x181353980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> KKLPPGJPIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA631E0", Offset = "0xA621E0", VA = "0x180A631E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA631D0", Offset = "0xA621D0", VA = "0x180A631D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties LKAKKFHEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA63170", Offset = "0xA62170", VA = "0x180A63170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA631B0", Offset = "0xA621B0", VA = "0x180A631B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte CIHOJNBNFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA683F0", Offset = "0xA673F0", VA = "0x180A683F0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA683C0", Offset = "0xA673C0", VA = "0x180A683C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KOGANNKCGHD CHNEPDKGONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xFA3D20", Offset = "0xFA2D20", VA = "0x180FA3D20")]
		[CompilerGenerated]
		get
		{
			return default(KOGANNKCGHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2FC94E0", Offset = "0x2FC84E0", VA = "0x182FC94E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GIDLAGOMAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x89BA8C0", Offset = "0x89B98C0", VA = "0x1889BA8C0")]
	public GIDLAGOMAOA(ICHKNBGHKHE OFNBMHFAAGJ, [Optional] RoomInventoryItemProperties KAEILAKIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89BA1A0", Offset = "0x89B91A0", VA = "0x1889BA1A0", Slot = "4")]
	public bool Equals(GIDLAGOMAOA EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x89BA320", Offset = "0x89B9320", VA = "0x1889BA320", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89BA4F0", Offset = "0x89B94F0", VA = "0x1889BA4F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x89BA5D0", Offset = "0x89B95D0", VA = "0x1889BA5D0")]
	private HashSet<long> MDMKBLADKON(ICHKNBGHKHE OFNBMHFAAGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IDCIPIFNELM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GAPEDJJHMDL HIJLNCPNMLP;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GIDLAGOMAOA DGHLMIMPIII
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GAPEDJJHMDL NADOGFDPKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89BAA20", Offset = "0x89B9A20", VA = "0x1889BAA20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA616A0", Offset = "0xA606A0", VA = "0x180A616A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x89BAAB0", Offset = "0x89B9AB0", VA = "0x1889BAAB0")]
	public IDCIPIFNELM(GIDLAGOMAOA KAJMBNDCKHH, [Optional] GAPEDJJHMDL HIJLNCPNMLP)
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
			[Cpp2IlInjected.Address(RVA = "0x89BB0B0", Offset = "0x89BA0B0", VA = "0x1889BB0B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1290C40", Offset = "0x128FC40", VA = "0x181290C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1588380", Offset = "0x1587380", VA = "0x181588380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DBJNLKFCIJI Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
			[CompilerGenerated]
			get
			{
				return default(DBJNLKFCIJI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA6A6F0", Offset = "0xA696F0", VA = "0x180A6A6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB1AC50", Offset = "0xB19C50", VA = "0x180B1AC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xE3B020", Offset = "0xE3A020", VA = "0x180E3B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA616B0", Offset = "0xA606B0", VA = "0x180A616B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC333C0", Offset = "0xC323C0", VA = "0x180C333C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xBB3410", Offset = "0xBB2410", VA = "0x180BB3410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xEFF8E0", Offset = "0xEFE8E0", VA = "0x180EFF8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xEFF8D0", Offset = "0xEFE8D0", VA = "0x180EFF8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x89BAF00", Offset = "0x89B9F00", VA = "0x1889BAF00", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties EDJHHGMLKFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x89BAE10", Offset = "0x89B9E10", VA = "0x1889BAE10")]
		public static RoomInventoryItemProperties AABAGJPEDHJ(RoomInventoryItemProperties KAEILAKIAKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x89BB050", Offset = "0x89BA050", VA = "0x1889BB050")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BIMABKLOIIJ
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int BAPIJJGKGCH = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string OFFBGMGPCIJ;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder MCEAGLIHLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string DNLFMLCLHEF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long BPAPEDPJNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xE46310", Offset = "0xE45310", VA = "0x180E46310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string GHLJANJDNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x89B9CC0", Offset = "0x89B8CC0", VA = "0x1889B9CC0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string MDMHNCCIHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x89B9990", Offset = "0x89B8990", VA = "0x1889B9990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties LKAKKFHEPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA63FB0", Offset = "0xA62FB0", VA = "0x180A63FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool LHFIKKIBABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89B9CA0", Offset = "0x89B8CA0", VA = "0x1889B9CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public BIMABKLOIIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x89B9D70", Offset = "0x89B8D70", VA = "0x1889B9D70")]
	public BIMABKLOIIJ(JDFGKPEHOFB OFNBMHFAAGJ, [Optional] RoomInventoryTagClientProperties KAEILAKIAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x89B9BE0", Offset = "0x89B8BE0", VA = "0x1889B9BE0")]
	public JDFGKPEHOFB BEANMDNHHKM()
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
			[Cpp2IlInjected.Address(RVA = "0x89BB310", Offset = "0x89BA310", VA = "0x1889BB310")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x89BB100", Offset = "0x89BA100", VA = "0x1889BB100")]
		public void KLEJFOBLFFG(Dictionary<string, object> KLLAHLEHMOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
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
