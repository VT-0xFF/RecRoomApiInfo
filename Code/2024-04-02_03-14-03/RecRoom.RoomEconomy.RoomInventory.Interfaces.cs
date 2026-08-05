using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.RoomEconomy.RoomInventory;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LAJJFLKBJNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly JKDDBOIBMHC FNKNJMLIKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long LOHCAPLAMPA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CHDBOKNCNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66EDB20", Offset = "0x66EC720", VA = "0x1866EDB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66EDB30", Offset = "0x66EC730", VA = "0x1866EDB30")]
	public LAJJFLKBJNB(JKDDBOIBMHC MGHLKGJFBCD, long MAJIECOCCAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KDENAHOHCBH
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
public interface FLGLFLKKOJD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GPEAFMNAGCL KBAEOCJFEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	CGCFLAHJDPK<BDKKHIFDOJJ> PKIPPBGBFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	CGCFLAHJDPK<Guid> ICGIKKHFJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MICCGNDBPKA<MLDLHJLLNOG, int> OLPDAKAEALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CGCFLAHJDPK<DBMKLNAKPDN> GEOLLPELGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CGCFLAHJDPK<long> KFELIKDFKCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GPEAFMNAGCL EPJOMIMPGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<DGKNLHNBBJB<BDKKHIFDOJJ, string>> AMLMKDABJNG(long MGDJPIEDFNB, string MPGNMPAPHDB, string PCPJCEHFFMB, string KJBKODHFLNP, RoomInventoryItemProperties PLGMENCLMDH, [Optional] List<long> GAGLAEKPHLM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<DGKNLHNBBJB<BDKKHIFDOJJ, string>> FBICADLCNNN(Guid LBPEJEEOFCO, [Optional] string MPGNMPAPHDB, [Optional] string PCPJCEHFFMB, [Optional] string KJBKODHFLNP, [Optional] List<long> GAGLAEKPHLM, [Optional] RoomInventoryItemProperties PLGMENCLMDH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<DGKNLHNBBJB<bool, string>> KCDJLJOLNNP(Guid LBPEJEEOFCO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IReadOnlyList<BDKKHIFDOJJ> KMDPOHEGJJC();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	IReadOnlyList<BDKKHIFDOJJ> JHGKBFGNFKA();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool PMHKCKBEPHO();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool PGDECMDDDMD(Guid LBPEJEEOFCO, [Out] BDKKHIFDOJJ NGMJEBMHKBE);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool HBKKPJBPGDL(string OGBIMNCPHKK, [Out] BDKKHIFDOJJ NGMJEBMHKBE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IReadOnlyList<MLDLHJLLNOG> JBILPAGEIEH();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool JNFLFADGLBN(Guid LBPEJEEOFCO, [Out] MLDLHJLLNOG FNLODLHPJHL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<int> JAHECOMDNCI(IFDGJPHDBFK POHDOBOBLAI, Guid LBPEJEEOFCO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<LAJJFLKBJNB> EMGGHEPOHPG(IFDGJPHDBFK POHDOBOBLAI, Guid LBPEJEEOFCO, int AIMJKOABHLL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	string MMMKDINBBGB(JKDDBOIBMHC MGHLKGJFBCD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KCPNIILNGOJ();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task<DGKNLHNBBJB<DBMKLNAKPDN, string>> MMBLBDOBIPB(long MGDJPIEDFNB, string MPGNMPAPHDB, RoomInventoryTagClientProperties PLGMENCLMDH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool HAKFMBHFOHO(long GGHGHCKBGGP, [Out] DBMKLNAKPDN KKJMKLCOIHH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NKIFLONDKBD : FLGLFLKKOJD
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEPOABMMAAC(IEnumerable<HNONNCDBCEI> BJLFGBIOBFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MLDLHJLLNOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid OEMBNILNKEL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66EE140", Offset = "0x66ECD40", VA = "0x1866EE140")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CHDBOKNCNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66EE1B0", Offset = "0x66ECDB0", VA = "0x1866EE1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public long LECNIPGLOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F90", Offset = "0x7B8B90", VA = "0x1807B9F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long DEFBNGKOKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D90", Offset = "0x7B1990", VA = "0x1807B2D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Guid? KJDAEFIEMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B9640", Offset = "0x7B8240", VA = "0x1807B9640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B9630", Offset = "0x7B8230", VA = "0x1807B9630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DDOCELANKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD70", Offset = "0x8BA970", VA = "0x1808BBD70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1AC0240", Offset = "0x1ABEE40", VA = "0x181AC0240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x66EE1D0", Offset = "0x66ECDD0", VA = "0x1866EE1D0")]
	public MLDLHJLLNOG(HNONNCDBCEI LFFIKHNAODJ, bool BMDPIDKLJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B8CC30", Offset = "0x1B8B830", VA = "0x181B8CC30")]
	public MLDLHJLLNOG(Guid LBPEJEEOFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x66EDF50", Offset = "0x66ECB50", VA = "0x1866EDF50")]
	internal bool BBEBOIIGBMN(HNONNCDBCEI LFFIKHNAODJ, long AAPOIOJGDGH, Action<MLDLHJLLNOG, int> JCKOMAEKBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x66EE150", Offset = "0x66ECD50", VA = "0x1866EE150")]
	internal void LGJBLEEHIBL(long LMGJPPLEDHJ, Action<MLDLHJLLNOG, int> JCKOMAEKBCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BDKKHIFDOJJ : IEquatable<BDKKHIFDOJJ>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int IHMDPJMJAEM = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int LDPONBKOFCA = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int AGOGPMFDICB = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int KOLFPNAIOBC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int IEAHNDJJJEF = 10;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Guid OEMBNILNKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84DD40", Offset = "0x84C940", VA = "0x18084DD40")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84DD30", Offset = "0x84C930", VA = "0x18084DD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public long NBHCAKIGHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xEE4470", Offset = "0xEE3070", VA = "0x180EE4470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string OGFDOLMKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string LMNOOCMGOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B9F30", Offset = "0x7B8B30", VA = "0x1807B9F30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DateTime HBODMNABHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1A9BC60", Offset = "0x1A9A860", VA = "0x181A9BC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime CPLDNOOKBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1AC3EC0", Offset = "0x1AC2AC0", VA = "0x181AC3EC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public HashSet<long> EPPCMABADLH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6590", VA = "0x1807B7990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B79E0", Offset = "0x7B65E0", VA = "0x1807B79E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public RoomInventoryItemProperties AOIMLAOFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A00", Offset = "0x7B6600", VA = "0x1807B7A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B79C0", Offset = "0x7B65C0", VA = "0x1807B79C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x66ED880", Offset = "0x66EC480", VA = "0x1866ED880")]
	public BDKKHIFDOJJ(CKGAPGEINAA LFFIKHNAODJ, [Optional] RoomInventoryItemProperties PLGMENCLMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x66ED330", Offset = "0x66EBF30", VA = "0x1866ED330", Slot = "4")]
	public bool Equals(BDKKHIFDOJJ NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x66ED150", Offset = "0x66EBD50", VA = "0x1866ED150", Slot = "0")]
	public override bool Equals(object OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66ED4B0", Offset = "0x66EC0B0", VA = "0x1866ED4B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x66ED590", Offset = "0x66EC190", VA = "0x1866ED590")]
	private HashSet<long> LJGJIEHBCFK(CKGAPGEINAA LFFIKHNAODJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MKIHOAGKOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private MLDLHJLLNOG FNLODLHPJHL;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BDKKHIFDOJJ EHGJBMGFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MLDLHJLLNOG MFMDANNDBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x66EDB70", Offset = "0x66EC770", VA = "0x1866EDB70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x66EDC00", Offset = "0x66EC800", VA = "0x1866EDC00")]
	public MKIHOAGKOIB(BDKKHIFDOJJ NGMJEBMHKBE, [Optional] MLDLHJLLNOG FNLODLHPJHL)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomInventoryItemProperties : IEquatable<RoomInventoryItemProperties>
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public const int MAX_ACTION_BUTTON_TEXT_LENGTH = 12;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const int CURRENT_VERSION = 1;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static RoomInventoryItemProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66EE500", Offset = "0x66ED100", VA = "0x1866EE500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7AF180", Offset = "0x7ADD80", VA = "0x1807AF180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7B9610", Offset = "0x7B8210", VA = "0x1807B9610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9B0470", Offset = "0x9AF070", VA = "0x1809B0470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9B0480", Offset = "0x9AF080", VA = "0x1809B0480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public KDENAHOHCBH Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560")]
			[CompilerGenerated]
			get
			{
				return default(KDENAHOHCBH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7B6580", Offset = "0x7B5180", VA = "0x1807B6580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB79A60", Offset = "0xB78660", VA = "0x180B79A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3ED64A0", Offset = "0x3ED50A0", VA = "0x183ED64A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F8240", Offset = "0x8F6E40", VA = "0x1808F8240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9EE7B0", Offset = "0x9ED3B0", VA = "0x1809EE7B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x66EE280", Offset = "0x66ECE80", VA = "0x1866EE280", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x66EE300", Offset = "0x66ECF00", VA = "0x1866EE300")]
		public static RoomInventoryItemProperties HAJEGJOEBAB(RoomInventoryItemProperties PLGMENCLMDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x66EE4A0", Offset = "0x66ED0A0", VA = "0x1866EE4A0")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DBMKLNAKPDN
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const int LGIEPFFHOGO = 10;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public long JFLBPFOFPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1357DE0", Offset = "0x13569E0", VA = "0x181357DE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B30", Offset = "0x7B1730", VA = "0x1807B2B30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public RoomInventoryTagClientProperties AOIMLAOFLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool GAFEKDMJBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x66ED9C0", Offset = "0x66EC5C0", VA = "0x1866ED9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x66ED9E0", Offset = "0x66EC5E0", VA = "0x1866ED9E0")]
	public DBMKLNAKPDN(BHBKEKHMLME LFFIKHNAODJ, [Optional] RoomInventoryTagClientProperties PLGMENCLMDH)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static RoomInventoryTagClientProperties Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x66EE750", Offset = "0x66ED350", VA = "0x1866EE750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7AF180", Offset = "0x7ADD80", VA = "0x1807AF180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7B9610", Offset = "0x7B8210", VA = "0x1807B9610")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x66EE550", Offset = "0x66ED150", VA = "0x1866EE550")]
		public void CMMFLLPDNLN(Dictionary<string, object> LJAIEPDANGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public RoomInventoryTagClientProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class KIAHFHMFNEC
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x66EDAC0", Offset = "0x66EC6C0", VA = "0x1866EDAC0")]
	public static int BPGHCPOPAOM(long MENKCHLGBFO)
	{
		return default(int);
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
