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
public class JONOLEBDJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly KOCLIMMIKKP HLEOGFEMLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long HJGLMCCDDEF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EBGGNLJIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69F9040", Offset = "0x69F8240", VA = "0x1869F9040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69F9050", Offset = "0x69F8250", VA = "0x1869F9050")]
	public JONOLEBDJCA(KOCLIMMIKKP JBENFHJBMMN, long BIFLOKBJAPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NOBCCJCDPLK
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
public interface JNOKDAHHCNH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	OJHEJHCKNBB JCIHNINEMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HKGPCDCMJHO<KFCPBOIBLFM> GAKEIEJCFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	HKGPCDCMJHO<Guid> DBOEMKPOHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LKAEANPNDGO<KPCOIJOFNPI, int> EILPDGAAEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HKGPCDCMJHO<GIFEMCMBKOO> KIENHANENGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HKGPCDCMJHO<long> NJEKOLMFDGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	OJHEJHCKNBB GJLNACMEHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	OJHEJHCKNBB MCHEDKHNCGO
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
	Task<GDHFNIGIAEI<KFCPBOIBLFM, string>> CFEMIPCPOGB(long EAONINJADDB, string IIADHBOODBK, string FLJELGJMIKN, string OGMCBJADCNP, RoomInventoryItemProperties GCKNBJJCNMG, byte FAMHFANMELI, int LHAAJEOMGEG);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<GDHFNIGIAEI<KFCPBOIBLFM, string>> MJNEPJJHKKI(Guid LACFILEHNGA, [Optional] string IIADHBOODBK, [Optional] string FLJELGJMIKN, [Optional] string OGMCBJADCNP, [Optional] List<long> FCLOGHNJOCE, [Optional] Dictionary<string, RoomInventoryTagClientProperties> LDDDFLNCPHP, [Optional] RoomInventoryItemProperties GCKNBJJCNMG, [Optional] byte? FAMHFANMELI, [Optional] int? LHAAJEOMGEG);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<GDHFNIGIAEI<bool, string>> ALLMMPNCCHP(Guid LACFILEHNGA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<KFCPBOIBLFM> KCKPPMFCFHN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<KFCPBOIBLFM> HHJFJCJLHBA();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool NDGHFOOMIIG();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool DIOFHDDMIJL(Guid LACFILEHNGA, [Out] KFCPBOIBLFM KDGGHHIDBCD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool KNPFLJIGLFA(string FIKNCFNINFN, [Out] KFCPBOIBLFM KDGGHHIDBCD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<KPCOIJOFNPI> JKBIBIGNBOL();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool NIBIAPNKCFD(Guid LACFILEHNGA, [Out] KPCOIJOFNPI CAFHBFGKNIH);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? LHHJAGHEAMG(Guid LACFILEHNGA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> KGANABGCOIL(FGIOJHFMDFP PIDLONEPCMN, Guid LACFILEHNGA);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<JONOLEBDJCA> MFCADGEOLIG(FGIOJHFMDFP PIDLONEPCMN, Guid LACFILEHNGA, int JNCACEPFDLL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string OMOMEHOEGIJ(KOCLIMMIKKP JBENFHJBMMN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool ECBPMDHPCCD();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<GDHFNIGIAEI<GIFEMCMBKOO, string>> MLJEFFCDPJK(long DDLOJIIJNDB, RoomInventoryTagClientProperties GCKNBJJCNMG);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<GDHFNIGIAEI<bool, string>> FJCBKMPDNBN(long DDLOJIIJNDB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<GDHFNIGIAEI<bool, string>> JNMKILAEBCD(long EAONINJADDB, bool ACGAPNOAJKO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool DJOELMAOEMG();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	List<(long, int)> FKKNCJFMGBN(long JLEDKLHNGMG, int HBLMCHGFFAP);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ONENNLGJCFL(long DDLOJIIJNDB, [Out] GIFEMCMBKOO MBBFJMMOGAB);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool DAFNKELEPCE(long DDLOJIIJNDB, Guid FJIJHHMGGOM);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IReadOnlyList<GIFEMCMBKOO> NDBPDKGFDAE();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	List<GIFEMCMBKOO> ICONDOONDGJ();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<GIFEMCMBKOO> GIMICOBEBAI();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<KFCPBOIBLFM> PAPELBDMEAD(long DDLOJIIJNDB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool HBCBKAKNPJI(string BKFCMNHKFCB, [Out] IReadOnlyList<KFCPBOIBLFM> NHHPCDHBPEF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PJADFKNFGAI : JNOKDAHHCNH
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGADCIGPJK(IEnumerable<BBMEBMPLJCK> BLLMCJCCIIO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HFMDNEKBFIE();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KPCOIJOFNPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid AECIEHBNICF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69F9B90", Offset = "0x69F8D90", VA = "0x1869F9B90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EBGGNLJIEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69F9B70", Offset = "0x69F8D70", VA = "0x1869F9B70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long CDDGOLCJINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA60", Offset = "0x7CDC60", VA = "0x1807CEA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long MBOLGJCNDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D4980", Offset = "0x7D3B80", VA = "0x1807D4980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? PAEFDMFOECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CE020", Offset = "0x7CD220", VA = "0x1807CE020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7CE010", Offset = "0x7CD210", VA = "0x1807CE010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool CPHKNNBMINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x95F2A0", Offset = "0x95E4A0", VA = "0x18095F2A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xDDDFE0", Offset = "0xDDD1E0", VA = "0x180DDDFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69F9BA0", Offset = "0x69F8DA0", VA = "0x1869F9BA0")]
	public KPCOIJOFNPI(BBMEBMPLJCK HLHJFAEBMBF, bool HNLIEJLABLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1C9AA50", Offset = "0x1C99C50", VA = "0x181C9AA50")]
	public KPCOIJOFNPI(Guid LACFILEHNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69F9980", Offset = "0x69F8B80", VA = "0x1869F9980")]
	internal bool DBKEHPIBNHN(BBMEBMPLJCK HLHJFAEBMBF, long EJIDLNHPINA, Action<KPCOIJOFNPI, int> HGKFADGBFBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69F9920", Offset = "0x69F8B20", VA = "0x1869F9920")]
	internal void CPLBLGNCLJM(long FNBLHLMGJOO, Action<KPCOIJOFNPI, int> HGKFADGBFBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class KFCPBOIBLFM : IEquatable<KFCPBOIBLFM>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OKEEEBCKLKP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int PNEACOCHDGK = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int LFHPCFIHPDB = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int DDGLNABOMOD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int ECMPCPNKHAP = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid AECIEHBNICF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83B450", Offset = "0x83A650", VA = "0x18083B450")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8E5680", Offset = "0x8E4880", VA = "0x1808E5680")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long KBJCDNGCNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xFAC1D0", Offset = "0xFAB3D0", VA = "0x180FAC1D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string AGHMAHMGHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string LHOCGNGJEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7CE970", Offset = "0x7CDB70", VA = "0x1807CE970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime AEBKIKHGBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1BAF5A0", Offset = "0x1BAE7A0", VA = "0x181BAF5A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime ONCOKALOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5856C10", Offset = "0x5855E10", VA = "0x185856C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> FLGAHKGOJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF80", Offset = "0x7CB180", VA = "0x1807CBF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF70", Offset = "0x7CB170", VA = "0x1807CBF70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties LEMPDMCCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF90", Offset = "0x7CB190", VA = "0x1807CBF90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFD0", Offset = "0x7CB1D0", VA = "0x1807CBFD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte KBKAOMFCNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7CE860", Offset = "0x7CDA60", VA = "0x1807CE860")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7CE850", Offset = "0x7CDA50", VA = "0x1807CE850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AEMMBGBKIIN HJNOELOMHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xDF2A20", Offset = "0xDF1C20", VA = "0x180DF2A20")]
		[CompilerGenerated]
		get
		{
			return default(AEMMBGBKIIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xDF1930", Offset = "0xDF0B30", VA = "0x180DF1930")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x69F97C0", Offset = "0x69F89C0", VA = "0x1869F97C0")]
	public KFCPBOIBLFM(PHKODDKOIPP HLHJFAEBMBF, [Optional] RoomInventoryItemProperties GCKNBJJCNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69F9380", Offset = "0x69F8580", VA = "0x1869F9380", Slot = "4")]
	public bool Equals(KFCPBOIBLFM JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69F9500", Offset = "0x69F8700", VA = "0x1869F9500", Slot = "0")]
	public override bool Equals(object CDJAKLIPEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69F96E0", Offset = "0x69F88E0", VA = "0x1869F96E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69F9090", Offset = "0x69F8290", VA = "0x1869F9090")]
	private HashSet<long> DNPEHCNIGEK(PHKODDKOIPP HLHJFAEBMBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JDIIOKGLNDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private KPCOIJOFNPI CAFHBFGKNIH;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KFCPBOIBLFM LFIDKGOKACG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KPCOIJOFNPI FHNHKCPEFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x69F8C60", Offset = "0x69F7E60", VA = "0x1869F8C60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69F8CF0", Offset = "0x69F7EF0", VA = "0x1869F8CF0")]
	public JDIIOKGLNDE(KFCPBOIBLFM KDGGHHIDBCD, [Optional] KPCOIJOFNPI CAFHBFGKNIH)
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
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x69F9EE0", Offset = "0x69F90E0", VA = "0x1869F9EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		internal int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7CE040", Offset = "0x7CD240", VA = "0x1807CE040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x865BA0", Offset = "0x864DA0", VA = "0x180865BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA4F1C0", Offset = "0xA4E3C0", VA = "0x180A4F1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public NOBCCJCDPLK Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
			[CompilerGenerated]
			get
			{
				return default(NOBCCJCDPLK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7CFAB0", Offset = "0x7CECB0", VA = "0x1807CFAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xC1B2D0", Offset = "0xC1A4D0", VA = "0x180C1B2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4186B70", Offset = "0x4185D70", VA = "0x184186B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B6690", Offset = "0x9B5890", VA = "0x1809B6690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA8C3F0", Offset = "0xA8B5F0", VA = "0x180A8C3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD19090", Offset = "0xD18290", VA = "0x180D19090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD18870", Offset = "0xD17A70", VA = "0x180D18870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69F9D40", Offset = "0x69F8F40", VA = "0x1869F9D40", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69F9C50", Offset = "0x69F8E50", VA = "0x1869F9C50")]
		public static RoomInventoryItemProperties CIALDCDEGDF(RoomInventoryItemProperties GCKNBJJCNMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x69F9E80", Offset = "0x69F9080", VA = "0x1869F9E80")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GIFEMCMBKOO
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int EDIBIOKMKED = 10;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long ABADEAELBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x142DE70", Offset = "0x142D070", VA = "0x18142DE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string KLNBLIAPPFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public RoomInventoryTagClientProperties LEMPDMCCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool BLEOEIEOACL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x69F8B60", Offset = "0x69F7D60", VA = "0x1869F8B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public GIFEMCMBKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69F8B80", Offset = "0x69F7D80", VA = "0x1869F8B80")]
	public GIFEMCMBKOO(LLIOGPFANAO HLHJFAEBMBF, [Optional] RoomInventoryTagClientProperties GCKNBJJCNMG)
	{
	}
}
namespace RecRoom.RoomEconomy.RoomInventory
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RoomInventoryTagClientProperties
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static RoomInventoryTagClientProperties DefaultNonSortingTab
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x69FA130", Offset = "0x69F9330", VA = "0x1869FA130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7CE040", Offset = "0x7CD240", VA = "0x1807CE040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x69F9F30", Offset = "0x69F9130", VA = "0x1869F9F30")]
		public void ACDLJIPDKPK(Dictionary<string, object> AJHNIBIOLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
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
