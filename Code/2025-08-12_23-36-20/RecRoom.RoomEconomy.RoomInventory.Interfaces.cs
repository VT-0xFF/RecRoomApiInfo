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
public class MJLGILJJFNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly NPODIONALLL JOLJDOILEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long KFMIHBFLPLI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LFJJDJGDNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA7C0", Offset = "0x8BC95C0", VA = "0x188BCA7C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA7D0", Offset = "0x8BC95D0", VA = "0x188BCA7D0")]
	public MJLGILJJFNN(NPODIONALLL MOBFLOHJOKJ, long FFKCBONKOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OFMFJICPLFJ
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
public interface JJGOLLENIHA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MKAEDPHCCBC BACNDHPCMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	GBCEOPMAPJH<GFMIADJGPJH> GCHPIFLDKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	GBCEOPMAPJH<Guid> LACDFBICGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FLNBPEKPFIH<GLJJEPBELIM, int> KKBBEPDFEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GBCEOPMAPJH<POJMEDGDKKM> JILGHNCANDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GBCEOPMAPJH<long> IADIKFDFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MKAEDPHCCBC JDNMFKCHDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MKAEDPHCCBC GNBPOMIJANP
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
	Task<GECIHKBMECG<GFMIADJGPJH, string>> LBDHMAEJOFI(Guid? LHMBOGGFNPO, long MDNJLMOPJKG, string PFLDDMDPCBI, string CDEPGINEGKG, string ECFOLMEBCEO, RoomInventoryItemProperties EAHIEHKAAEI, byte ADPIMLAGACM, int BGBIPHDMBPB, [Optional] List<long> HBDODEBOMAF, [Optional] List<OBBMAADMKFG> OMCANAEJFHP, bool GLOBDHAMDBI = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<GECIHKBMECG<GFMIADJGPJH, string>> LIDLMIIFNCA(Guid ENEOEDNPCBA, long MDNJLMOPJKG, [Optional] string PFLDDMDPCBI, [Optional] string CDEPGINEGKG, [Optional] string ECFOLMEBCEO, [Optional] List<long> HBDODEBOMAF, [Optional] Dictionary<string, RoomInventoryTagClientProperties> OMCANAEJFHP, [Optional] RoomInventoryItemProperties EAHIEHKAAEI, [Optional] byte? ADPIMLAGACM, [Optional] int? BGBIPHDMBPB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<GECIHKBMECG<bool, string>> CHHBLHHEJGD(Guid ENEOEDNPCBA, long MDNJLMOPJKG);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<GFMIADJGPJH> FDIJANNCJJN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<GFMIADJGPJH> IDDJPONDANJ();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool DFBOFJCDNPA();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool APNDBPJHDAJ(Guid ENEOEDNPCBA, [Out] GFMIADJGPJH EJNEHIPFOJM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool DFDMPGAMIBF(string AJADEPPIBBF, [Out] GFMIADJGPJH EJNEHIPFOJM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<GLJJEPBELIM> IANAAMAHNPJ();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool EEBNJFLHBNO(Guid ENEOEDNPCBA, [Out] GLJJEPBELIM PIGPNPJKFBJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? JPBBIFPIEHN(Guid ENEOEDNPCBA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> CPOGPGDDLNA(AFLCFHLHEHB GLMBLPAKFLM, Guid ENEOEDNPCBA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<MJLGILJJFNN> DKPPFJMHOCD(AFLCFHLHEHB GLMBLPAKFLM, Guid ENEOEDNPCBA, int EBABNKEEAMD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string JBMEIFIFEMI(NPODIONALLL MOBFLOHJOKJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool GILGGMPNKGB();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MMCGJDDLPCD DFADGLNCEEG(GFMIADJGPJH KFAPLAGDMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties NKCFGNOCPML(string PNDJKDLDJBN);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<GECIHKBMECG<POJMEDGDKKM, string>> LLGIOILLNHI(long LAHANCCOJIN, RoomInventoryTagClientProperties EAHIEHKAAEI);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<GECIHKBMECG<bool, string>> ENOAJGPLADN(long LAHANCCOJIN);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<GECIHKBMECG<bool, string>> BDIIHMBOMLP(long MDNJLMOPJKG, bool HPHHJJMHCEB);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool AOLGOLJJEDI();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> EAHICDGEHBB(long ALACKPBHGHK, int LOCEMHMAACA);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool JDKODOKFKBL(long LAHANCCOJIN, [Out] POJMEDGDKKM FNLFDCDNBKI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool DGKMEHIJFEL(string HELFCCCMPFC, [Out] POJMEDGDKKM FNLFDCDNBKI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool APPMNCCOGOD(long LAHANCCOJIN, Guid CGLKEOONBOI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<POJMEDGDKKM> BJLLDKPCIBF();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<POJMEDGDKKM> JIJGDLCBFDM();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<POJMEDGDKKM> JJABFOAFBAO();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<GFMIADJGPJH> FBEJMICPBIC(long LAHANCCOJIN);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LFPDPAOKDHJ(string HELFCCCMPFC, [Out] IReadOnlyList<GFMIADJGPJH> LOAGAMKLHJL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KCDGNBKAIKC : JJGOLLENIHA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABHMBIMFOKP(IEnumerable<COAABHJIMMF> BHLCFIOIDKF);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EMLCOIDMGEB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GLJJEPBELIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid JLKNCFMDCON;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long KFMIHBFLPLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA6A0", Offset = "0x8BC94A0", VA = "0x188BCA6A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int LFJJDJGDNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA680", Offset = "0x8BC9480", VA = "0x188BCA680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long ENHEDBHJCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA98B70", Offset = "0xA97970", VA = "0x180A98B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long FALFDFFBMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAA2020", Offset = "0xAA0E20", VA = "0x180AA2020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? MAKPDJNDDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA99CD0", Offset = "0xA98AD0", VA = "0x180A99CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA99D10", Offset = "0xA98B10", VA = "0x180A99D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool ADJGOMFOOND
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD63540", Offset = "0xD62340", VA = "0x180D63540")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD62860", Offset = "0xD61660", VA = "0x180D62860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA710", Offset = "0x8BC9510", VA = "0x188BCA710")]
	public GLJJEPBELIM(COAABHJIMMF LMJDFLKIALD, bool AFHDODKBGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x10F61A0", Offset = "0x10F4FA0", VA = "0x1810F61A0")]
	public GLJJEPBELIM(Guid ENEOEDNPCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA490", Offset = "0x8BC9290", VA = "0x188BCA490")]
	internal bool AFCEEABIEMI(COAABHJIMMF LMJDFLKIALD, long MECKHELACKG, Action<GLJJEPBELIM, int> GNGLOAFLMBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA6B0", Offset = "0x8BC94B0", VA = "0x188BCA6B0")]
	internal void PEIMAOIHFCP(long LFHAKOAFOLE, Action<GLJJEPBELIM, int> GNGLOAFLMBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GFMIADJGPJH : IEquatable<GFMIADJGPJH>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int KNBGDMHKENC = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int OGFFLNJFOOP = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int FONMNGEOJKO = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int NOLAPKNMIJJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int OEOLGDGDBBJ = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid JLKNCFMDCON
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xEAB030", Offset = "0xEA9E30", VA = "0x180EAB030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long PCLKEPGGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE184D0", Offset = "0xE172D0", VA = "0x180E184D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string LPOBFFEBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string PHKHFNAGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA98C30", Offset = "0xA97A30", VA = "0x180A98C30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime LMDDFBEGNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xFBCAA0", Offset = "0xFBB8A0", VA = "0x180FBCAA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime PGHCONMJLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x13D4C20", Offset = "0x13D3A20", VA = "0x1813D4C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> BBJELCLNGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA93190", Offset = "0xA91F90", VA = "0x180A93190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties NLHEDKPIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA931A0", Offset = "0xA91FA0", VA = "0x180A931A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte MLPCGHEIFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA98B80", Offset = "0xA97980", VA = "0x180A98B80")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA98B30", Offset = "0xA97930", VA = "0x180A98B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BEIEMLGIDNI MDANDEECNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xFF1040", Offset = "0xFEFE40", VA = "0x180FF1040")]
		[CompilerGenerated]
		get
		{
			return default(BEIEMLGIDNI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x29FB090", Offset = "0x29F9E90", VA = "0x1829FB090")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public GFMIADJGPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA330", Offset = "0x8BC9130", VA = "0x188BCA330")]
	public GFMIADJGPJH(MMCGJDDLPCD LMJDFLKIALD, [Optional] RoomInventoryItemProperties EAHIEHKAAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9DE0", Offset = "0x8BC8BE0", VA = "0x188BC9DE0", Slot = "4")]
	public bool Equals(GFMIADJGPJH FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9C10", Offset = "0x8BC8A10", VA = "0x188BC9C10", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8BC9F60", Offset = "0x8BC8D60", VA = "0x188BC9F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA040", Offset = "0x8BC8E40", VA = "0x188BCA040")]
	private HashSet<long> LOOJOIHCKBP(MMCGJDDLPCD LMJDFLKIALD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class PGINKKACHGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GLJJEPBELIM PIGPNPJKFBJ;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GFMIADJGPJH JBOEKGNLJAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GLJJEPBELIM FLABKCLKCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8BCA810", Offset = "0x8BC9610", VA = "0x188BCA810")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA8A0", Offset = "0x8BC96A0", VA = "0x188BCA8A0")]
	public PGINKKACHGB(GFMIADJGPJH EJNEHIPFOJM, [Optional] GLJJEPBELIM PIGPNPJKFBJ)
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
			[Cpp2IlInjected.Address(RVA = "0x8BCB350", Offset = "0x8BCA150", VA = "0x188BCB350")]
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
			[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x12FD860", Offset = "0x12FC660", VA = "0x1812FD860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1608700", Offset = "0x1607500", VA = "0x181608700")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public OFMFJICPLFJ Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA94B20", Offset = "0xA93920", VA = "0x180A94B20")]
			[CompilerGenerated]
			get
			{
				return default(OFMFJICPLFJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA94B80", Offset = "0xA93980", VA = "0x180A94B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB62D30", Offset = "0xB61B30", VA = "0x180B62D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xE8D6C0", Offset = "0xE8C4C0", VA = "0x180E8D6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xC38800", Offset = "0xC37600", VA = "0x180C38800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xC01980", Offset = "0xC00780", VA = "0x180C01980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xF5C830", Offset = "0xF5B630", VA = "0x180F5C830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xF5C840", Offset = "0xF5B640", VA = "0x180F5C840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB1A0", Offset = "0x8BC9FA0", VA = "0x188BCB1A0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB0B0", Offset = "0x8BC9EB0", VA = "0x188BCB0B0")]
		public static RoomInventoryItemProperties BKCDCCJFPOM(RoomInventoryItemProperties EAHIEHKAAEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB2F0", Offset = "0x8BCA0F0", VA = "0x188BCB2F0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class POJMEDGDKKM
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int PAIOEHDFAHI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string FBGMEKFLBBF;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder OHLMPLEOAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string EPOGOFIDEFK;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long BDPACNIMDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xE94830", Offset = "0xE93630", VA = "0x180E94830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string LBDOKALIJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8BCACD0", Offset = "0x8BC9AD0", VA = "0x188BCACD0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string HFLFOHLMPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BCAD00", Offset = "0x8BC9B00", VA = "0x188BCAD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties NLHEDKPIJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GFEKBPFOFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8BCABF0", Offset = "0x8BC99F0", VA = "0x188BCABF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public POJMEDGDKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAFC0", Offset = "0x8BC9DC0", VA = "0x188BCAFC0")]
	public POJMEDGDKKM(OBBMAADMKFG LMJDFLKIALD, [Optional] RoomInventoryTagClientProperties EAHIEHKAAEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8BCAC10", Offset = "0x8BC9A10", VA = "0x188BCAC10")]
	public OBBMAADMKFG JMACCEIDJBL()
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
			[Cpp2IlInjected.Address(RVA = "0x8BCB5B0", Offset = "0x8BCA3B0", VA = "0x188BCB5B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8BCB3A0", Offset = "0x8BCA1A0", VA = "0x188BCB3A0")]
		public void INCFGCPNMDD(Dictionary<string, object> FFEGLLCDOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
