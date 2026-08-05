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
public class NIDFFOKILOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly FJANAPFOKNF OCFEIGBDKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long BMBFHPLNLGE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FDOCANPJAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7642510", Offset = "0x7640D10", VA = "0x187642510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7642520", Offset = "0x7640D20", VA = "0x187642520")]
	public NIDFFOKILOC(FJANAPFOKNF HANDIANDCDI, long NELOIEKKMHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum CJECGCFHBKP
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
public interface OIMBFMJJBEE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	GCOJJNPJFGN PJFMNIDIPED
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ANHAMBLCGDC<CEFHKFDMFIL> GELDIFLJBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ANHAMBLCGDC<Guid> GIBJCGDCEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BHNOANLGPMK<FPBJCHLAPPB, int> IMLELFCMBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ANHAMBLCGDC<PMKLBAJPLGH> HABJMAOFJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ANHAMBLCGDC<long> POCDGHAKIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GCOJJNPJFGN JEFDJOPMGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GCOJJNPJFGN IPGLOJICGIA
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
	Task<DNFCNMKAMCE<CEFHKFDMFIL, string>> LCLOELNHIAN(Guid? HJJKIPAJDBE, long NKDNOGOOODN, string IKMKCMDHFDC, string GIMKNCGKHFF, string DFDGAJNBHBE, RoomInventoryItemProperties DABHNNJBAFE, byte LJMPACNDPEI, int LCDEMOPFJEN, [Optional] List<long> HLODAEEPKPK, [Optional] List<LFBCALJHPGG> BDFCJHGHMEK, bool BDDIGPLKNCP = false);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<DNFCNMKAMCE<CEFHKFDMFIL, string>> AKNEOEDBLLC(Guid JBDEJHNEIJJ, long NKDNOGOOODN, [Optional] string IKMKCMDHFDC, [Optional] string GIMKNCGKHFF, [Optional] string DFDGAJNBHBE, [Optional] List<long> HLODAEEPKPK, [Optional] Dictionary<string, RoomInventoryTagClientProperties> BDFCJHGHMEK, [Optional] RoomInventoryItemProperties DABHNNJBAFE, [Optional] byte? LJMPACNDPEI, [Optional] int? LCDEMOPFJEN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<DNFCNMKAMCE<bool, string>> LDBFJOOLGHE(Guid JBDEJHNEIJJ, long NKDNOGOOODN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<CEFHKFDMFIL> DKFFLOHODIB();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<CEFHKFDMFIL> IOKPBKEOHGO();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool EEOGNHCNLCO();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool GCPPHIFEEDA(Guid JBDEJHNEIJJ, [Out] CEFHKFDMFIL FNKEDEBOPKA);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool BKGIBKGPAOO(string ICMBPAJIKBH, [Out] CEFHKFDMFIL FNKEDEBOPKA);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<FPBJCHLAPPB> HKKPMEHCAOK();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool KMFKLFJKCDN(Guid JBDEJHNEIJJ, [Out] FPBJCHLAPPB EJJDLGLKJKD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? OLGEPEBJFEE(Guid JBDEJHNEIJJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> LPJENNDHMCK(OEDKOGGDKCO FGIHDJGGIMF, Guid JBDEJHNEIJJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<NIDFFOKILOC> ONNBPLALJAM(OEDKOGGDKCO FGIHDJGGIMF, Guid JBDEJHNEIJJ, int CEHMFIFBHOE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string DJIAMLANJMJ(FJANAPFOKNF HANDIANDCDI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DAPMHGKGKKK();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	IFEBHLBMMMJ MMKKJHKKALD(CEFHKFDMFIL KDGJNKEIKID);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	RoomInventoryItemProperties IMBOIALMNDA(string CHCBEMINJOH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<DNFCNMKAMCE<PMKLBAJPLGH, string>> MJMINGHHGGD(long DKAEPLEJMII, RoomInventoryTagClientProperties DABHNNJBAFE);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<DNFCNMKAMCE<bool, string>> BKPKFCMEIGB(long DKAEPLEJMII);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<DNFCNMKAMCE<bool, string>> HNPDMFCGCMF(long NKDNOGOOODN, bool MDKHOHFGOEO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool JBMKCMOIHEA();

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	List<(long, int)> EJODJBAAOEJ(long EABLHEFEBBM, int ONNHGIDDOJI);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	bool IBHMJHACAFO(long DKAEPLEJMII, [Out] PMKLBAJPLGH NJOFMLJFGME);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool DOMEICMDEEI(string GIHEFEHAKAF, [Out] PMKLBAJPLGH NJOFMLJFGME);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool DEKIMMDHGGI(long DKAEPLEJMII, Guid AIHFDFMJDOD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<PMKLBAJPLGH> HHGIFDDDIDP();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	List<PMKLBAJPLGH> CNIJDFOLJLN();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	IReadOnlyList<PMKLBAJPLGH> KKOJCJHKLFG();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "45")]
	IReadOnlyList<CEFHKFDMFIL> NIIFDLBDHNC(long DKAEPLEJMII);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool HLOEPINFJDI(string GIHEFEHAKAF, [Out] IReadOnlyList<CEFHKFDMFIL> EHOMMMMHDBF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FJNBPPDGJPA : OIMBFMJJBEE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KALOELGHCJO(IEnumerable<DKDHHAGBMMD> CCFCLAECIMB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GHGGCIMCKPB();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FPBJCHLAPPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid OKMEAKFPMLD;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long BMBFHPLNLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7642070", Offset = "0x7640870", VA = "0x187642070")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FDOCANPJAPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7641E00", Offset = "0x7640600", VA = "0x187641E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long IFBLHFJBDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BB230", Offset = "0x8B9A30", VA = "0x1808BB230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long BNBHONDBHFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8C1900", Offset = "0x8C0100", VA = "0x1808C1900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? NGHPOMBJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B5220", Offset = "0x8B3A20", VA = "0x1808B5220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B51F0", Offset = "0x8B39F0", VA = "0x1808B51F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IACOLGPKEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA999B0", Offset = "0xA981B0", VA = "0x180A999B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA994E0", Offset = "0xA97CE0", VA = "0x180A994E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7642080", Offset = "0x7640880", VA = "0x187642080")]
	public FPBJCHLAPPB(DKDHHAGBMMD DNGJLLAGICH, bool NMPAPMINPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0xB2E160", Offset = "0xB2C960", VA = "0x180B2E160")]
	public FPBJCHLAPPB(Guid JBDEJHNEIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7641E80", Offset = "0x7640680", VA = "0x187641E80")]
	internal bool LHNLPLKLOMD(DKDHHAGBMMD DNGJLLAGICH, long FOLJLNNFBJC, Action<FPBJCHLAPPB, int> EJIBOCGJOHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7641E20", Offset = "0x7640620", VA = "0x187641E20")]
	internal void GIPLCOHOLCA(long CENMJNHJADJ, Action<FPBJCHLAPPB, int> EJIBOCGJOHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CEFHKFDMFIL : IEquatable<CEFHKFDMFIL>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int CPBBPANACNJ = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int PDLJDPBINAL = 40;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int LEHKDIPFGJN = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int DEKMEFEMDKE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int NPMFOAFHFGO = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid OKMEAKFPMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xB2DD30", Offset = "0xB2C530", VA = "0x180B2DD30")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xB2DF30", Offset = "0xB2C730", VA = "0x180B2DF30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long FMJKOMLKOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA89BA0", Offset = "0xA883A0", VA = "0x180A89BA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BE300", Offset = "0x8BCB00", VA = "0x1808BE300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string ELBEDLFIJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8BE310", Offset = "0x8BCB10", VA = "0x1808BE310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string JHOHNEPBCJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFE0", Offset = "0x8B97E0", VA = "0x1808BAFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime BOCJGDDGGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8BD1D0", Offset = "0x8BB9D0", VA = "0x1808BD1D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA80", Offset = "0xA3B280", VA = "0x180A3CA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime MEJIAEIGDEH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62D5300", Offset = "0x62D3B00", VA = "0x1862D5300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> PJMNONNKDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B7500", Offset = "0x8B5D00", VA = "0x1808B7500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B7510", Offset = "0x8B5D10", VA = "0x1808B7510")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties OCDHKDCFBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B7520", Offset = "0x8B5D20", VA = "0x1808B7520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B7570", Offset = "0x8B5D70", VA = "0x1808B7570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte OPFDAGLGEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8BD190", Offset = "0x8BB990", VA = "0x1808BD190")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8BD210", Offset = "0x8BBA10", VA = "0x1808BD210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CEBKHCOPPLM JLCDCPNFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA99A80", Offset = "0xA98280", VA = "0x180A99A80")]
		[CompilerGenerated]
		get
		{
			return default(CEBKHCOPPLM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1292540", Offset = "0x1290D40", VA = "0x181292540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public CEFHKFDMFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7641CA0", Offset = "0x76404A0", VA = "0x187641CA0")]
	public CEFHKFDMFIL(IFEBHLBMMMJ DNGJLLAGICH, [Optional] RoomInventoryItemProperties DABHNNJBAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7641750", Offset = "0x763FF50", VA = "0x187641750", Slot = "4")]
	public bool Equals(CEFHKFDMFIL LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7641580", Offset = "0x763FD80", VA = "0x187641580", Slot = "0")]
	public override bool Equals(object INCBEIDOHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76418D0", Offset = "0x76400D0", VA = "0x1876418D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x76419B0", Offset = "0x76401B0", VA = "0x1876419B0")]
	private HashSet<long> KEMCCCBGLMB(IFEBHLBMMMJ DNGJLLAGICH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KAEHOPMHDBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FPBJCHLAPPB EJJDLGLKJKD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CEFHKFDMFIL KNBJMKIPEGA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB000", Offset = "0x8B9800", VA = "0x1808BB000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FPBJCHLAPPB PAHHIFAKJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7642130", Offset = "0x7640930", VA = "0x187642130")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x76421C0", Offset = "0x76409C0", VA = "0x1876421C0")]
	public KAEHOPMHDBC(CEFHKFDMFIL FNKEDEBOPKA, [Optional] FPBJCHLAPPB EJJDLGLKJKD)
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
			[Cpp2IlInjected.Address(RVA = "0x7642CE0", Offset = "0x76414E0", VA = "0x187642CE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF80", Offset = "0xCEE780", VA = "0x180CEFF80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xEF8490", Offset = "0xEF6C90", VA = "0x180EF8490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CJECGCFHBKP Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8BC040", Offset = "0x8BA840", VA = "0x1808BC040")]
			[CompilerGenerated]
			get
			{
				return default(CJECGCFHBKP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8C38D0", Offset = "0x8C20D0", VA = "0x1808C38D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x95C5E0", Offset = "0x95ADE0", VA = "0x18095C5E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x95CF30", Offset = "0x95B730", VA = "0x18095CF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8B51E0", Offset = "0x8B39E0", VA = "0x1808B51E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA02A00", Offset = "0xA01200", VA = "0x180A02A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xA028C0", Offset = "0xA010C0", VA = "0x180A028C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA02A10", Offset = "0xA01210", VA = "0x180A02A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA028D0", Offset = "0xA010D0", VA = "0x180A028D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7642A40", Offset = "0x7641240", VA = "0x187642A40", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7642AD0", Offset = "0x76412D0", VA = "0x187642AD0")]
		public static RoomInventoryItemProperties IGANKIJEKEL(RoomInventoryItemProperties DABHNNJBAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7642C80", Offset = "0x7641480", VA = "0x187642C80")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PMKLBAJPLGH
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int KIIBNNFAHCI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string KLLAMAJHALD;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder ANELFOBEPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string PDKLENKGNMI;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long BHEJGFGPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x946360", Offset = "0x944B60", VA = "0x180946360")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string AEHPFKGBHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x76427D0", Offset = "0x7640FD0", VA = "0x1876427D0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string FEFBPCBFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7642560", Offset = "0x7640D60", VA = "0x187642560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties OCDHKDCFBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8BE300", Offset = "0x8BCB00", VA = "0x1808BE300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PIBHHOJMKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x76427B0", Offset = "0x7640FB0", VA = "0x1876427B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public PMKLBAJPLGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7642940", Offset = "0x7641140", VA = "0x187642940")]
	public PMKLBAJPLGH(LFBCALJHPGG DNGJLLAGICH, [Optional] RoomInventoryTagClientProperties DABHNNJBAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7642800", Offset = "0x7641000", VA = "0x187642800")]
	public LFBCALJHPGG NJOKEGJBIMA()
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
			[Cpp2IlInjected.Address(RVA = "0x7642F40", Offset = "0x7641740", VA = "0x187642F40")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8B5210", Offset = "0x8B3A10", VA = "0x1808B5210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7642D30", Offset = "0x7641530", VA = "0x187642D30")]
		public void BGELBIBLJIB(Dictionary<string, object> AMODHGHPMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
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
