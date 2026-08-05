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
public class MHHDPFBFCIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly DNIFKKNCMME JBGJDBLIIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long FCHJPHAGFMP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NJNCHOICIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82AE7B0", Offset = "0x82ACFB0", VA = "0x1882AE7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x82AE7C0", Offset = "0x82ACFC0", VA = "0x1882AE7C0")]
	public MHHDPFBFCIJ(DNIFKKNCMME HLPIAOANGMD, long PCFOAHIEPDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum FDMLICPEEKI
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
public interface HLGDCEAGMHK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	FIEKIAHLEMJ EHLICBAPBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HOPADDCECBJ<IEMMBIPOENM> GFGKIIPJDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HOPADDCECBJ<Guid> ILHADDIFJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LLDDHLANFDF<CMPFPLCKMMJ, int> DBCKLNGOKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HOPADDCECBJ<DMOJDCBOAKF> PCADCILLDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HOPADDCECBJ<long> PAMFKOMBGLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	FIEKIAHLEMJ CDCLKMCADDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FIEKIAHLEMJ GLGPFHOGBBG
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
	Task<HCGBMJDNFKJ<IEMMBIPOENM, string>> MLCPDBOEFOA(Guid? NJHJECCCGDO, long MDLDCACFGIB, string GLGOHIJMLFB, string NIAMDMBDIJG, string LJANIECHELJ, RoomInventoryItemProperties OMHBAAPJDOL, byte AAMAJMKCBNJ, int AGNHOOELDII, [Optional] List<long> JHEIHGLJEKA, [Optional] List<EJIMKFPHKMF> EHCHEIAFPOF, bool BNDADHGIJAI = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<HCGBMJDNFKJ<IEMMBIPOENM, string>> DHGLGFEEMGC(Guid MAOEEMAEHGL, long MDLDCACFGIB, [Optional] string GLGOHIJMLFB, [Optional] string NIAMDMBDIJG, [Optional] string LJANIECHELJ, [Optional] List<long> JHEIHGLJEKA, [Optional] Dictionary<string, RoomInventoryTagClientProperties> EHCHEIAFPOF, [Optional] RoomInventoryItemProperties OMHBAAPJDOL, [Optional] byte? AAMAJMKCBNJ, [Optional] int? AGNHOOELDII);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<HCGBMJDNFKJ<bool, string>> EMALHECPLMH(Guid MAOEEMAEHGL, long MDLDCACFGIB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<IEMMBIPOENM> PEPOCAIHPEN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<IEMMBIPOENM> GAADHFPHKJD();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool KGMCMAGIACF();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool ABOJGKCIJLL(Guid MAOEEMAEHGL, [Out] IEMMBIPOENM KCBFGLLALML);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool LJIODLIJNEO(string GGIFMNICIPC, [Out] IEMMBIPOENM KCBFGLLALML);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<CMPFPLCKMMJ> NPOGCJOCIMJ();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool GGKCHKMIOOO(Guid MAOEEMAEHGL, [Out] CMPFPLCKMMJ AHEFNMJAIHO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? DJDDNJJLKEC(Guid MAOEEMAEHGL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> AFMDOHHGKEO(GFEBJDBBDID PPBALHIMPIH, Guid MAOEEMAEHGL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<MHHDPFBFCIJ> BIPNFIJMPOB(GFEBJDBBDID PPBALHIMPIH, Guid MAOEEMAEHGL, int JBLCDPEEHBE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string JLNIKNFLKNF(DNIFKKNCMME HLPIAOANGMD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool AJMJIFDMDGM();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	EEJBDKFLKNK PBDKKBGCPEG(IEMMBIPOENM PPPHGMCACCO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties HKMGIKDJKBA(string KECLCDEAJME);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<HCGBMJDNFKJ<DMOJDCBOAKF, string>> KNEHNOCKDDC(long KEHLMAAOAKJ, RoomInventoryTagClientProperties OMHBAAPJDOL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<HCGBMJDNFKJ<bool, string>> DFLDNMGELAN(long KEHLMAAOAKJ);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<HCGBMJDNFKJ<bool, string>> OEAGBAPLBEP(long MDLDCACFGIB, bool KAEKCBFKBNK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool FDPDDOEJDBL();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> OKBIJKFNLOH(long HNJGMOGINLJ, int FOCALNMNJBO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool JOIAKLJDDPL(long KEHLMAAOAKJ, [Out] DMOJDCBOAKF FCJGGOOCAKL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool MLKOCLDFHOL(string NCNABDGGCEL, [Out] DMOJDCBOAKF FCJGGOOCAKL);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool DJLBPKMDIOB(long KEHLMAAOAKJ, Guid FDHKOJCLHNE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<DMOJDCBOAKF> HLPLBFMHPOE();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<DMOJDCBOAKF> IBOPEMLDNJA();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<DMOJDCBOAKF> AFGJKMMLKCK();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<IEMMBIPOENM> PDINHHNFMLP(long KEHLMAAOAKJ);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool LBJCNNADDCO(string NCNABDGGCEL, [Out] IReadOnlyList<IEMMBIPOENM> HOLNFEMNHEH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HLIHGPANEKM : HLGDCEAGMHK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FCCEENNDLBH(IEnumerable<DHKFIBAHAEL> ELOJGLDOJNB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NEGJICHFMDM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CMPFPLCKMMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid LIIOIKPMDGD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82AD360", Offset = "0x82ABB60", VA = "0x1882AD360")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NJNCHOICIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82AD370", Offset = "0x82ABB70", VA = "0x1882AD370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long MHNFNMMBLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DF0", Offset = "0x9DF5F0", VA = "0x1809E0DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long EJOAGGHMANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E2B00", VA = "0x1809E4300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? CBHBPMHINGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9EBFB0", Offset = "0x9EA7B0", VA = "0x1809EBFB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9EBFA0", Offset = "0x9EA7A0", VA = "0x1809EBFA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool AOLNFECMDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xBCE330", Offset = "0xBCCB30", VA = "0x180BCE330")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xBCD6D0", Offset = "0xBCBED0", VA = "0x180BCD6D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x82AD5E0", Offset = "0x82ABDE0", VA = "0x1882AD5E0")]
	public CMPFPLCKMMJ(DHKFIBAHAEL BCIDKJANIHJ, bool PELJDAGCIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xF60000", Offset = "0xF5E800", VA = "0x180F60000")]
	public CMPFPLCKMMJ(Guid MAOEEMAEHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82AD3F0", Offset = "0x82ABBF0", VA = "0x1882AD3F0")]
	internal bool MAEEPMKIKNH(DHKFIBAHAEL BCIDKJANIHJ, long NFPGPDLBDOE, Action<CMPFPLCKMMJ, int> HFOKLGFFHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x82AD390", Offset = "0x82ABB90", VA = "0x1882AD390")]
	internal void FHFMDONAKDB(long GDEMOMOAIMP, Action<CMPFPLCKMMJ, int> HFOKLGFFHBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IEMMBIPOENM : IEquatable<IEMMBIPOENM>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OFPIAKDOBJG = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int FPEJJNDGGKG = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int KPDFFDKKDIL = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int LKKJCBEIDLH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int MFNKOIJMNGE = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid LIIOIKPMDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF63890", Offset = "0xF62090", VA = "0x180F63890")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xF63950", Offset = "0xF62150", VA = "0x180F63950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long MPBMECOMGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xC79020", Offset = "0xC77820", VA = "0x180C79020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string NJJPEPDLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string GFJBHKHMHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DC0", Offset = "0x9DF5C0", VA = "0x1809E0DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime OKKIKOGNGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xDFC010", Offset = "0xDFA810", VA = "0x180DFC010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime NEDBPOMOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9E0DD0", Offset = "0x9DF5D0", VA = "0x1809E0DD0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEEC0", Offset = "0x6DAD6C0", VA = "0x186DAEEC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> APOIMAPFIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9DD240", Offset = "0x9DBA40", VA = "0x1809DD240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties FNAJCJLKEEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1D0", Offset = "0x9DB9D0", VA = "0x1809DD1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte PBPAAHAMKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9E24B0", Offset = "0x9E0CB0", VA = "0x1809E24B0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9E2380", Offset = "0x9E0B80", VA = "0x1809E2380")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CGKMKJEAANA GEHPAEKDJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xE3EBE0", Offset = "0xE3D3E0", VA = "0x180E3EBE0")]
		[CompilerGenerated]
		get
		{
			return default(CGKMKJEAANA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2C542A0", Offset = "0x2C52AA0", VA = "0x182C542A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public IEMMBIPOENM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82AE650", Offset = "0x82ACE50", VA = "0x1882AE650")]
	public IEMMBIPOENM(EEJBDKFLKNK BCIDKJANIHJ, [Optional] RoomInventoryItemProperties OMHBAAPJDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82AE220", Offset = "0x82ACA20", VA = "0x1882AE220", Slot = "4")]
	public bool Equals(IEMMBIPOENM PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82AE3A0", Offset = "0x82ACBA0", VA = "0x1882AE3A0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82AE570", Offset = "0x82ACD70", VA = "0x1882AE570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82ADF30", Offset = "0x82AC730", VA = "0x1882ADF30")]
	private HashSet<long> BKAEMNNDFCN(EEJBDKFLKNK BCIDKJANIHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GDMDPMCGMFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private CMPFPLCKMMJ AHEFNMJAIHO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IEMMBIPOENM ADDOAFHBIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CMPFPLCKMMJ MLOAMBBHDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82ADB50", Offset = "0x82AC350", VA = "0x1882ADB50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82ADBE0", Offset = "0x82AC3E0", VA = "0x1882ADBE0")]
	public GDMDPMCGMFG(IEMMBIPOENM KCBFGLLALML, [Optional] CMPFPLCKMMJ AHEFNMJAIHO)
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
			[Cpp2IlInjected.Address(RVA = "0x82AEAA0", Offset = "0x82AD2A0", VA = "0x1882AEAA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x110C0D0", Offset = "0x110A8D0", VA = "0x18110C0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1326130", Offset = "0x1324930", VA = "0x181326130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public FDMLICPEEKI Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
			[CompilerGenerated]
			get
			{
				return default(FDMLICPEEKI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9EC7A0", Offset = "0x9EAFA0", VA = "0x1809EC7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCE8D70", Offset = "0xCE7570", VA = "0x180CE8D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD83850", Offset = "0xD82050", VA = "0x180D83850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA82330", Offset = "0xA80B30", VA = "0x180A82330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xD83860", Offset = "0xD82060", VA = "0x180D83860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xD83870", Offset = "0xD82070", VA = "0x180D83870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82AE800", Offset = "0x82AD000", VA = "0x1882AE800", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82AE890", Offset = "0x82AD090", VA = "0x1882AE890")]
		public static RoomInventoryItemProperties LMNLEEHCNJH(RoomInventoryItemProperties OMHBAAPJDOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x82AEA40", Offset = "0x82AD240", VA = "0x1882AEA40")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DMOJDCBOAKF
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int HCIOHKEAKEB = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string CAMPMBKDEMK;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder ILOKHBJLLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string NFMOJGMEGEG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long LDFIBNHAPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xCDCAB0", Offset = "0xCDB2B0", VA = "0x180CDCAB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string ACOJEEABMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x82AD690", Offset = "0x82ABE90", VA = "0x1882AD690")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string DGFFOJPABFM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x82AD6E0", Offset = "0x82ABEE0", VA = "0x1882AD6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties FNAJCJLKEEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NIAAOBEJBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82AD6C0", Offset = "0x82ABEC0", VA = "0x1882AD6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public DMOJDCBOAKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82ADA60", Offset = "0x82AC260", VA = "0x1882ADA60")]
	public DMOJDCBOAKF(EJIMKFPHKMF BCIDKJANIHJ, [Optional] RoomInventoryTagClientProperties OMHBAAPJDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x82AD920", Offset = "0x82AC120", VA = "0x1882AD920")]
	public EJIMKFPHKMF MLCNPAOEIIC()
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
			[Cpp2IlInjected.Address(RVA = "0x82AED00", Offset = "0x82AD500", VA = "0x1882AED00")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82AEAF0", Offset = "0x82AD2F0", VA = "0x1882AEAF0")]
		public void MNBGPFLAPAL(Dictionary<string, object> NAOCLOHDKMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
