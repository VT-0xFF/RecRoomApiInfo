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
public class CJNBNEFHBHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly BLLCGMGNANG AANGCDILCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long NAAONAFFINP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KBMIECGPMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x703A0D0", Offset = "0x7038CD0", VA = "0x18703A0D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x703A0E0", Offset = "0x7038CE0", VA = "0x18703A0E0")]
	public CJNBNEFHBHD(BLLCGMGNANG KKIOBLFFGJH, long LLHINFJPPOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DKNJJOAJDGC
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
public interface JKELDKFCJDA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MMAIJBDFGNK KHBBMMDDKPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BCFOECKJENL<BOIFJDGEIEC> OMIEPFDIGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BCFOECKJENL<Guid> CAIKGLBHAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GAGHBOIDANB<FFKMAOICBHH, int> ENDNGBIDFFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BCFOECKJENL<CBCKCJDOIIL> JAMCINMLPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BCFOECKJENL<long> HADBOHNMPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MMAIJBDFGNK FICBMPCHOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MMAIJBDFGNK BCNBBIAAOMH
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
	Task<NLDGPBPIIJN<BOIFJDGEIEC, string>> EHPAHDENIIL(long ACIHEOIHPAO, string LONKACOOPGJ, string JCKPDENNIBJ, string OOLGEEHGHHO, RoomInventoryItemProperties AKNIKBOBNFK, byte LHMLGAAONPF, int NMMFNOOBBFO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<NLDGPBPIIJN<BOIFJDGEIEC, string>> FMFOJINJPAJ(Guid ECIANNNNGDD, [Optional] string LONKACOOPGJ, [Optional] string JCKPDENNIBJ, [Optional] string OOLGEEHGHHO, [Optional] List<long> AEKAGCNBEJA, [Optional] Dictionary<string, RoomInventoryTagClientProperties> PCLCNDGEMMN, [Optional] RoomInventoryItemProperties AKNIKBOBNFK, [Optional] byte? LHMLGAAONPF, [Optional] int? NMMFNOOBBFO);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<NLDGPBPIIJN<bool, string>> HMJLKDLCIDD(Guid ECIANNNNGDD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<BOIFJDGEIEC> HAHALGDNINC();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<BOIFJDGEIEC> OHCHDLFAOAA();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool JMLELLABNBC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool INMCIBJMNFH(Guid ECIANNNNGDD, [Out] BOIFJDGEIEC GDGEJFINOJN);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CMFBPKGGPGP(string PCHIBPJMPFI, [Out] BOIFJDGEIEC GDGEJFINOJN);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<FFKMAOICBHH> GOLIEJMEOGF();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool PPHNIFOOKEF(Guid ECIANNNNGDD, [Out] FFKMAOICBHH LOLCHMNDPDO);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? PDHICKABEKA(Guid ECIANNNNGDD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> FIIEMIGBGFK(MLFBKPIOFCD OCPDBKCKFCD, Guid ECIANNNNGDD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<CJNBNEFHBHD> ICCMJCMBHOO(MLFBKPIOFCD OCPDBKCKFCD, Guid ECIANNNNGDD, int PGLOJBHLNAB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string OPNEPLGJMMP(BLLCGMGNANG KKIOBLFFGJH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DMMLPFMIHKG();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<NLDGPBPIIJN<CBCKCJDOIIL, string>> AAGFGFEAKAG(long JDOEIGEIMKB, RoomInventoryTagClientProperties AKNIKBOBNFK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<NLDGPBPIIJN<bool, string>> EJLBGLOPGDD(long JDOEIGEIMKB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<NLDGPBPIIJN<bool, string>> FBABCCFFBND(long ACIHEOIHPAO, bool JDDLLFJGAHE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PNAHBPGCCJG();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	List<(long, int)> ODFOMGPIFGA(long NLNFAKNFGGH, int BEKJFLKFPBG);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool KKHNDFJPOAH(long JDOEIGEIMKB, [Out] CBCKCJDOIIL GJJGLILOILH);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool NCGAPBLDAJH(long JDOEIGEIMKB, Guid MOAOOBADHIF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IReadOnlyList<CBCKCJDOIIL> FDLKOAEIMND();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	List<CBCKCJDOIIL> BFLMPMECCMB();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<CBCKCJDOIIL> MGGOOICBPPK();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<BOIFJDGEIEC> MECKFMKLNCI(long JDOEIGEIMKB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool NKIDKFFNECK(string EACLJLDNBAP, [Out] IReadOnlyList<BOIFJDGEIEC> OPJFOJPAKCN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EHPDNNHLCAM : JKELDKFCJDA
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIGKHDAPBKM(IEnumerable<HGKEGHAPPBA> GHBDAGPCDID);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MJFIEGLBIAH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FFKMAOICBHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid DIOJOPDGJCF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x703A120", Offset = "0x7038D20", VA = "0x18703A120")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int KBMIECGPMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x703A130", Offset = "0x7038D30", VA = "0x18703A130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long IHFBIIMHAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86C7A0", Offset = "0x86B3A0", VA = "0x18086C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long KMDFOGHMLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x869F10", Offset = "0x868B10", VA = "0x180869F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? LPAKFGFKLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x868D30", Offset = "0x867930", VA = "0x180868D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x868D50", Offset = "0x867950", VA = "0x180868D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool BMLFCHKPJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA42890", Offset = "0xA41490", VA = "0x180A42890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xEAEA00", Offset = "0xEAD600", VA = "0x180EAEA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x703A3A0", Offset = "0x7038FA0", VA = "0x18703A3A0")]
	public FFKMAOICBHH(HGKEGHAPPBA NCCHJDBDDKN, bool AAFHPICGEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5070", Offset = "0x1DB3C70", VA = "0x181DB5070")]
	public FFKMAOICBHH(Guid ECIANNNNGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x703A1B0", Offset = "0x7038DB0", VA = "0x18703A1B0")]
	internal bool LMJHDDPLKGM(HGKEGHAPPBA NCCHJDBDDKN, long IDONCGFBFKB, Action<FFKMAOICBHH, int> OONCCHHIHCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x703A150", Offset = "0x7038D50", VA = "0x18703A150")]
	internal void IKIAIAMCPNI(long NAOMBIDHFFC, Action<FFKMAOICBHH, int> OONCCHHIHCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BOIFJDGEIEC : IEquatable<BOIFJDGEIEC>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int IEKENIJMJLP = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int NDDPBBLIGAG = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int PHGMJLMGFNN = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int JMLDPLJIOAJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int IPGEPGNJIPN = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid DIOJOPDGJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8DA100", Offset = "0x8D8D00", VA = "0x1808DA100")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9B60E0", Offset = "0x9B4CE0", VA = "0x1809B60E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long NGKIPDLAOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1088690", Offset = "0x1087290", VA = "0x181088690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x869EF0", Offset = "0x868AF0", VA = "0x180869EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string DILEEBNHJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string HPBODPLCLNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86C780", Offset = "0x86B380", VA = "0x18086C780")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime MNBAPAFNGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1CAD2E0", Offset = "0x1CABEE0", VA = "0x181CAD2E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime GPMNLCGIFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAD70", Offset = "0x5DF9970", VA = "0x185DFAD70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> EEJIINBODIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86B550", Offset = "0x86A150", VA = "0x18086B550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86B4E0", Offset = "0x86A0E0", VA = "0x18086B4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties DHKCMBPDLND
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86B4F0", Offset = "0x86A0F0", VA = "0x18086B4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86B530", Offset = "0x86A130", VA = "0x18086B530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte DDJHHODHFDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86FCD0", Offset = "0x86E8D0", VA = "0x18086FCD0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86FB50", Offset = "0x86E750", VA = "0x18086FB50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HKBPBGOBHLL LNDJCPFPLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xEC4060", Offset = "0xEC2C60", VA = "0x180EC4060")]
		[CompilerGenerated]
		get
		{
			return default(HKBPBGOBHLL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xEC3DC0", Offset = "0xEC29C0", VA = "0x180EC3DC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7039B50", Offset = "0x7038750", VA = "0x187039B50")]
	public BOIFJDGEIEC(KLADGKKGONC NCCHJDBDDKN, [Optional] RoomInventoryItemProperties AKNIKBOBNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x70398F0", Offset = "0x70384F0", VA = "0x1870398F0", Slot = "4")]
	public bool Equals(BOIFJDGEIEC HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7039720", Offset = "0x7038320", VA = "0x187039720", Slot = "0")]
	public override bool Equals(object APKAFMDACKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7039A70", Offset = "0x7038670", VA = "0x187039A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7039430", Offset = "0x7038030", VA = "0x187039430")]
	private HashSet<long> CGKEIGGGGFD(KLADGKKGONC NCCHJDBDDKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AHELPEGKKAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FFKMAOICBHH LOLCHMNDPDO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BOIFJDGEIEC NLBMGEONEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FFKMAOICBHH IGAGDMBDDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7039050", Offset = "0x7037C50", VA = "0x187039050")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x70390E0", Offset = "0x7037CE0", VA = "0x1870390E0")]
	public AHELPEGKKAO(BOIFJDGEIEC GDGEJFINOJN, [Optional] FFKMAOICBHH LOLCHMNDPDO)
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
			[Cpp2IlInjected.Address(RVA = "0x703A6E0", Offset = "0x70392E0", VA = "0x18703A6E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x868D10", Offset = "0x867910", VA = "0x180868D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x933860", Offset = "0x932460", VA = "0x180933860")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB19950", Offset = "0xB18550", VA = "0x180B19950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DKNJJOAJDGC Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x867580", Offset = "0x866180", VA = "0x180867580")]
			[CompilerGenerated]
			get
			{
				return default(DKNJJOAJDGC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x867D00", Offset = "0x866900", VA = "0x180867D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD04530", Offset = "0xD03130", VA = "0x180D04530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x44D2D00", Offset = "0x44D1900", VA = "0x1844D2D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA7EAB0", Offset = "0xA7D6B0", VA = "0x180A7EAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB55D80", Offset = "0xB54980", VA = "0x180B55D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDF29F0", Offset = "0xDF15F0", VA = "0x180DF29F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDF2750", Offset = "0xDF1350", VA = "0x180DF2750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x703A450", Offset = "0x7039050", VA = "0x18703A450", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x703A4D0", Offset = "0x70390D0", VA = "0x18703A4D0")]
		public static RoomInventoryItemProperties LIMAJKMFJNK(RoomInventoryItemProperties AKNIKBOBNFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x703A680", Offset = "0x7039280", VA = "0x18703A680")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CBCKCJDOIIL
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int MOBCCEKPIPK = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string NLLNEOBMOMH;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder CMMPDBOIIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string LDBGAPKGHDF;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DEIDLIENFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x150F750", Offset = "0x150E350", VA = "0x18150F750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string ACNBDEPIOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7039F20", Offset = "0x7038B20", VA = "0x187039F20")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string NGJMKJKOLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7039CD0", Offset = "0x70388D0", VA = "0x187039CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties DHKCMBPDLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x869EF0", Offset = "0x868AF0", VA = "0x180869EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool GOEGFCBIAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7039CB0", Offset = "0x70388B0", VA = "0x187039CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public CBCKCJDOIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7039FD0", Offset = "0x7038BD0", VA = "0x187039FD0")]
	public CBCKCJDOIIL(HMCILOIAJEM NCCHJDBDDKN, [Optional] RoomInventoryTagClientProperties AKNIKBOBNFK)
	{
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
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x703A930", Offset = "0x7039530", VA = "0x18703A930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int DisplayOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x868D10", Offset = "0x867910", VA = "0x180868D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x703A730", Offset = "0x7039330", VA = "0x18703A730")]
		public void FJGEFHKNFAA(Dictionary<string, object> LJLIEJDMMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
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
