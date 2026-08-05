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
public class MHNLDCDDIMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly ACPDCBCMFIG DDFNFMDIDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long GMILMIAEFMI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JJEBHENDJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8046480", Offset = "0x8045880", VA = "0x188046480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8046490", Offset = "0x8045890", VA = "0x188046490")]
	public MHNLDCDDIMG(ACPDCBCMFIG HBALBIOOGIJ, long ECKHNAPCKGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GKBEMGLKJAP
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
public interface NAOLKLDGMEC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OPNNLJDPBAB NGMFHNMIENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GLDBGNIANKN<EKAIJBLKMHB> MDJANJMAPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GLDBGNIANKN<Guid> DOBLBOAEEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	APHAPGEAMFF<CCAJIMOLOLP, int> OLNEDFGDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GLDBGNIANKN<LICKFMKFNIF> CLJLPJBPCMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GLDBGNIANKN<long> ABDIOMMMDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OPNNLJDPBAB HDOFDCJLIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OPNNLJDPBAB ONIDLADIJKD
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
	Task<KGPHFOFOMPJ<EKAIJBLKMHB, string>> BLMFFIMCFHK(Guid? LHDMHJPEPAM, long MIFADOBCMAC, string IGEPDAOOLBO, string ONJHPHOODPK, string KIINNOIMCAK, RoomInventoryItemProperties GOEHJDBLOMA, byte KFBPKKLDJOM, int ODFBFMBMBOG, [Optional] List<long> LGDDOMBKHAK, [Optional] List<CGKJCNLDHFB> MOJBODFNLJL, bool LJKFAGDCLKD = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<KGPHFOFOMPJ<EKAIJBLKMHB, string>> DBDLHIGNEOJ(Guid JIHGPAIIALE, long MIFADOBCMAC, [Optional] string IGEPDAOOLBO, [Optional] string ONJHPHOODPK, [Optional] string KIINNOIMCAK, [Optional] List<long> LGDDOMBKHAK, [Optional] Dictionary<string, RoomInventoryTagClientProperties> MOJBODFNLJL, [Optional] RoomInventoryItemProperties GOEHJDBLOMA, [Optional] byte? KFBPKKLDJOM, [Optional] int? ODFBFMBMBOG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<KGPHFOFOMPJ<bool, string>> OFADPCJJBJP(Guid JIHGPAIIALE, long MIFADOBCMAC);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<EKAIJBLKMHB> AAHOFPOCIEJ();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<EKAIJBLKMHB> HKJJNBELMGP();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PNADCCGHFCF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool GKMBHKFEPKH(Guid JIHGPAIIALE, [Out] EKAIJBLKMHB OOEBDLDLJKL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool POAEEDHENHD(string PKNPMFCFMEH, [Out] EKAIJBLKMHB OOEBDLDLJKL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<CCAJIMOLOLP> MDGGEMOJCEE();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CNKAGMNNMOC(Guid JIHGPAIIALE, [Out] CCAJIMOLOLP JPJBGEJCBJN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? FJHAGANPMIM(Guid JIHGPAIIALE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> OOPOOIFJBPB(DNIGIBHMBIB IBDBHCFLLPC, Guid JIHGPAIIALE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<MHNLDCDDIMG> CGJCLFCBEHK(DNIGIBHMBIB IBDBHCFLLPC, Guid JIHGPAIIALE, int OMENMEAMBDP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string GKHGMFECIHB(ACPDCBCMFIG HBALBIOOGIJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool PKKAOBDEMEK();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	FEKNCHECBPA HJHEEMNOKEH(EKAIJBLKMHB KBABLGBKOLN);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties POFFDHEHLGK(string LBDJAEBNPNL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<KGPHFOFOMPJ<LICKFMKFNIF, string>> DAELMAPMACM(long HGELDMDNKBO, RoomInventoryTagClientProperties GOEHJDBLOMA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<KGPHFOFOMPJ<bool, string>> PFLHMPDOHBG(long HGELDMDNKBO);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<KGPHFOFOMPJ<bool, string>> EPDJMOPDPFE(long MIFADOBCMAC, bool ILHCLNBPAJJ);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool JOOKDMFCCBA();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> PMJJMOGGGGH(long NLLHOCBDGOP, int OKBADMDILIL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool AOKHCGFHBEM(long HGELDMDNKBO, [Out] LICKFMKFNIF FNPOJMALJBC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool DDDNAEMCLKJ(string ACAMKKDDJOD, [Out] LICKFMKFNIF FNPOJMALJBC);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool BKJANEEHHIE(long HGELDMDNKBO, Guid FMAOLGLJALC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<LICKFMKFNIF> EKMMEHJIACB();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<LICKFMKFNIF> GOHECGOLJEC();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<LICKFMKFNIF> EPENEFGFPMA();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<EKAIJBLKMHB> IHPAOBLFBFG(long HGELDMDNKBO);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool IPGHCFGAALB(string ACAMKKDDJOD, [Out] IReadOnlyList<EKAIJBLKMHB> MAHBDHFOEJA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EOLNCLAPIND : NAOLKLDGMEC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHBNDMMDPDJ(IEnumerable<MPBDOGIHOIP> PBKNDIKCNCJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KKOJMONCJFF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CCAJIMOLOLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid BIGMFEJDPEC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long GMILMIAEFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8045410", Offset = "0x8044810", VA = "0x188045410")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JJEBHENDJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8045420", Offset = "0x8044820", VA = "0x188045420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long BOKJMLHKMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AA500", Offset = "0x9A9900", VA = "0x1809AA500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long FJOPECGPAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B0020", Offset = "0x9AF420", VA = "0x1809B0020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? HJAOLHOFCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A91F0", Offset = "0x9A85F0", VA = "0x1809A91F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9A9270", Offset = "0x9A8670", VA = "0x1809A9270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IFFJCMBBELC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xB52420", Offset = "0xB51820", VA = "0x180B52420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xB517C0", Offset = "0xB50BC0", VA = "0x180B517C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8045690", Offset = "0x8044A90", VA = "0x188045690")]
	public CCAJIMOLOLP(MPBDOGIHOIP OOPABBIBDMP, bool HNCJLHAFJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xE918F0", Offset = "0xE90CF0", VA = "0x180E918F0")]
	public CCAJIMOLOLP(Guid JIHGPAIIALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x80454A0", Offset = "0x80448A0", VA = "0x1880454A0")]
	internal bool ODNOMLGNGJI(MPBDOGIHOIP OOPABBIBDMP, long JDMNCLDABEN, Action<CCAJIMOLOLP, int> CFBGHCPFNDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8045440", Offset = "0x8044840", VA = "0x188045440")]
	internal void IIFNJEHAEPI(long IHPAKNIAKNF, Action<CCAJIMOLOLP, int> CFBGHCPFNDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EKAIJBLKMHB : IEquatable<EKAIJBLKMHB>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int BFLANOOOHPN = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int JOHHHMLKDIE = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int EELMAJDCJMO = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int JGDDPDCAPHG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int EOFPCMEALAF = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid BIGMFEJDPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F10", Offset = "0xBA3310", VA = "0x180BA3F10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long GGHGNFHHKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xC0FC20", Offset = "0xC0F020", VA = "0x180C0FC20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string PKJGJAKPLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B40A0", Offset = "0x9B34A0", VA = "0x1809B40A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string OLBGIJNAOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3D0", Offset = "0x9A97D0", VA = "0x1809AA3D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime NDCALOMOGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD81240", Offset = "0xD80640", VA = "0x180D81240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime LEFIDHIKGKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B81730", Offset = "0x6B80B30", VA = "0x186B81730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> PBLIMLMEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AC0", Offset = "0x9A8EC0", VA = "0x1809A9AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties IEFPFMFOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A70", Offset = "0x9A8E70", VA = "0x1809A9A70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A80", Offset = "0x9A8E80", VA = "0x1809A9A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte EANJNAHMNDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AA350", Offset = "0x9A9750", VA = "0x1809AA350")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4C0", Offset = "0x9A98C0", VA = "0x1809AA4C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HHGCLPMBJBD BANAMCLKDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xDAA820", Offset = "0xDA9C20", VA = "0x180DAA820")]
		[CompilerGenerated]
		get
		{
			return default(HHGCLPMBJBD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B4E510", Offset = "0x2B4D910", VA = "0x182B4E510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public EKAIJBLKMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8045E60", Offset = "0x8045260", VA = "0x188045E60")]
	public EKAIJBLKMHB(FEKNCHECBPA OOPABBIBDMP, [Optional] RoomInventoryItemProperties GOEHJDBLOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8045910", Offset = "0x8044D10", VA = "0x188045910", Slot = "4")]
	public bool Equals(EKAIJBLKMHB KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8045740", Offset = "0x8044B40", VA = "0x188045740", Slot = "0")]
	public override bool Equals(object BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8045D80", Offset = "0x8045180", VA = "0x188045D80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8045A90", Offset = "0x8044E90", VA = "0x188045A90")]
	private HashSet<long> GPHLEKKNKKJ(FEKNCHECBPA OOPABBIBDMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PFHJPKDCNMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CCAJIMOLOLP JPJBGEJCBJN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EKAIJBLKMHB PEMBMBONPDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA4D0", Offset = "0x9A98D0", VA = "0x1809AA4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CCAJIMOLOLP DANEMELFIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80464D0", Offset = "0x80458D0", VA = "0x1880464D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9A9210", Offset = "0x9A8610", VA = "0x1809A9210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8046560", Offset = "0x8045960", VA = "0x188046560")]
	public PFHJPKDCNMB(EKAIJBLKMHB OOEBDLDLJKL, [Optional] CCAJIMOLOLP JPJBGEJCBJN)
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
			[Cpp2IlInjected.Address(RVA = "0x8046B50", Offset = "0x8045F50", VA = "0x188046B50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x103D7A0", Offset = "0x103CBA0", VA = "0x18103D7A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x12451B0", Offset = "0x12445B0", VA = "0x1812451B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public GKBEMGLKJAP Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9AE430", Offset = "0x9AD830", VA = "0x1809AE430")]
			[CompilerGenerated]
			get
			{
				return default(GKBEMGLKJAP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B51D0", Offset = "0x9B45D0", VA = "0x1809B51D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA0E460", Offset = "0xA0D860", VA = "0x180A0E460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xC5D140", Offset = "0xC5C540", VA = "0x180C5D140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9A9260", Offset = "0x9A8660", VA = "0x1809A9260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7C0", Offset = "0xD0DBC0", VA = "0x180D0E7C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA2A290", Offset = "0xA29690", VA = "0x180A2A290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7B0", Offset = "0xD0DBB0", VA = "0x180D0E7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xD0E780", Offset = "0xD0DB80", VA = "0x180D0E780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x80468B0", Offset = "0x8045CB0", VA = "0x1880468B0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8046940", Offset = "0x8045D40", VA = "0x188046940")]
		public static RoomInventoryItemProperties IPLKNPADEBH(RoomInventoryItemProperties GOEHJDBLOMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8046AF0", Offset = "0x8045EF0", VA = "0x188046AF0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LICKFMKFNIF
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int BODLLKBHCBJ = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string KDOCJFNPGPN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder KOIIKHJHJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string GCDHLONDHHE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DAJHGFCCNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xC67C10", Offset = "0xC67010", VA = "0x180C67C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string KAFLMFCDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8045FE0", Offset = "0x80453E0", VA = "0x188045FE0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string FPBPKFOFMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80460D0", Offset = "0x80454D0", VA = "0x1880460D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties IEFPFMFOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3A0", Offset = "0x9A97A0", VA = "0x1809AA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B01E0", Offset = "0x9AF5E0", VA = "0x1809B01E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DHMOOCGAKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8045FC0", Offset = "0x80453C0", VA = "0x188045FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public LICKFMKFNIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8046390", Offset = "0x8045790", VA = "0x188046390")]
	public LICKFMKFNIF(CGKJCNLDHFB OOPABBIBDMP, [Optional] RoomInventoryTagClientProperties GOEHJDBLOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8046010", Offset = "0x8045410", VA = "0x188046010")]
	public CGKJCNLDHFB HJOGCAKOEMA()
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
			[Cpp2IlInjected.Address(RVA = "0x8046DB0", Offset = "0x80461B0", VA = "0x188046DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A91A0", Offset = "0x9A85A0", VA = "0x1809A91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9A9250", Offset = "0x9A8650", VA = "0x1809A9250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8046BA0", Offset = "0x8045FA0", VA = "0x188046BA0")]
		public void IBFCJFAKBHE(Dictionary<string, object> OPIBNPLCMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
