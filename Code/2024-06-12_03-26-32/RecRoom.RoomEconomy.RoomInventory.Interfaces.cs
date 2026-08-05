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
public class DGHCLGMDODC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly CEOMFLKDBLE IJJBKBIAPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly long FPIENNPNDKO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MJFGHOBMBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F33620", Offset = "0x6F32220", VA = "0x186F33620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F33630", Offset = "0x6F32230", VA = "0x186F33630")]
	public DGHCLGMDODC(CEOMFLKDBLE JFBAIGMLPKE, long HDFABDCMCAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BNEFENIGNCJ
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
public interface FLPBHIEEBFG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	DEHOLECDIJP GOFJIFKOAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JFCBGCCGGGE<EKICNLEGFBE> GLBMBILBJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JFCBGCCGGGE<Guid> EJBHHENBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	FFKNAOPGKON<DBAMMHCPHCA, int> IHDNPKLAOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JFCBGCCGGGE<MDHDBBEIJGC> HIALOCKPBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	JFCBGCCGGGE<long> CCGMLMHDPAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DEHOLECDIJP HMHBOFGJBKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DEHOLECDIJP LKBOLNOMCGK
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
	Task<GFFELLBKJIA<EKICNLEGFBE, string>> AIKEGFHNHJD(long NBIMAGPPMDN, string GFLNGGKHEOH, string HDGEDEGBPPD, string ODMDHGIMIKM, RoomInventoryItemProperties BDOEOJENHDO, byte FLIJILBLFOH, int BFOBNFFGJIL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<GFFELLBKJIA<EKICNLEGFBE, string>> IKMALDELANJ(Guid PANNKLGDCMD, [Optional] string GFLNGGKHEOH, [Optional] string HDGEDEGBPPD, [Optional] string ODMDHGIMIKM, [Optional] List<long> BGOBFHACCEM, [Optional] Dictionary<string, RoomInventoryTagClientProperties> CJKMNLFMBNI, [Optional] RoomInventoryItemProperties BDOEOJENHDO, [Optional] byte? FLIJILBLFOH, [Optional] int? BFOBNFFGJIL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<GFFELLBKJIA<bool, string>> OIAONMICEAC(Guid PANNKLGDCMD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IReadOnlyList<EKICNLEGFBE> AABNDOEBDCN();

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IReadOnlyList<EKICNLEGFBE> AEGPALEEABB();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool PAFDKKHHJMD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool AMFHICDAMBC(Guid PANNKLGDCMD, [Out] EKICNLEGFBE ANPABEIMBCC);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool NIBHHKFMMEN(string DBAGKCGNPCH, [Out] EKICNLEGFBE ANPABEIMBCC);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	IReadOnlyList<DBAMMHCPHCA> MIPKJHMIPPO();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool ECCHFOPBCEJ(Guid PANNKLGDCMD, [Out] DBAMMHCPHCA NLBFKPPHMGF);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	long? CJKJDKALDHM(Guid PANNKLGDCMD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Task<int> PCBMFJBCDKB(OICKONADKGK KBMFHBINANN, Guid PANNKLGDCMD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<DGHCLGMDODC> DOOOIHMNNFO(OICKONADKGK KBMFHBINANN, Guid PANNKLGDCMD, int NEFBLEELBHL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "29")]
	string IKIKDELOJLO(CEOMFLKDBLE JFBAIGMLPKE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool OMNMHIPCGOG();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<GFFELLBKJIA<MDHDBBEIJGC, string>> LELLDDMJDIK(long EIICFPLCPIL, RoomInventoryTagClientProperties BDOEOJENHDO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<GFFELLBKJIA<bool, string>> BIBLBDCJKDN(long EIICFPLCPIL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<GFFELLBKJIA<bool, string>> BMLPOHELJCA(long NBIMAGPPMDN, bool DAILOGKJFGF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool EIJAPHHIFPN();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "36")]
	List<(long, int)> DHKBGDONDMG(long IKJNCFKLOMO, int DNHKMCBFJOF);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool PNMNAGFIOBJ(long EIICFPLCPIL, [Out] MDHDBBEIJGC OCKHCHKPFEF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool NEFFPDLEHHF(long EIICFPLCPIL, Guid MHDAPEFILHB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	IReadOnlyList<MDHDBBEIJGC> PKLKEFAHIKL();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	List<MDHDBBEIJGC> MEFIPBLFDJA();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	IReadOnlyList<MDHDBBEIJGC> GHKFNNLGBDF();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	IReadOnlyList<EKICNLEGFBE> NJMGHCLGIKF(long EIICFPLCPIL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool BKFAMCOMMDB(string JIEEEJHNMLG, [Out] IReadOnlyList<EKICNLEGFBE> DKJCJPJDPMB);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NGAHFEFNEFM : FLPBHIEEBFG
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNAGFOBOPJJ(IEnumerable<MDFBIIBCICO> KGJDEJNBDFJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task IAHBDKIOPLK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DBAMMHCPHCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly Guid ADPDKPLAIMK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public long FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F33540", Offset = "0x6F32140", VA = "0x186F33540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MJFGHOBMBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F33550", Offset = "0x6F32150", VA = "0x186F33550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public long FEELKJHCIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8434B0", Offset = "0x8420B0", VA = "0x1808434B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public long LPIGHFGMPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84B8E0", Offset = "0x84A4E0", VA = "0x18084B8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Guid? LGAGJFKAHNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8444E0", Offset = "0x8430E0", VA = "0x1808444E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8444D0", Offset = "0x8430D0", VA = "0x1808444D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MCOFAFCGFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1CC50", VA = "0x180A1E050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE78E40", Offset = "0xE77A40", VA = "0x180E78E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F33570", Offset = "0x6F32170", VA = "0x186F33570")]
	public DBAMMHCPHCA(MDFBIIBCICO JHGEMPHPJMH, bool JAPCMJGHKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1D78310", Offset = "0x1D76F10", VA = "0x181D78310")]
	public DBAMMHCPHCA(Guid PANNKLGDCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F33350", Offset = "0x6F31F50", VA = "0x186F33350")]
	internal bool NBJEMGDMOCC(MDFBIIBCICO JHGEMPHPJMH, long BKOFEMBPIBN, Action<DBAMMHCPHCA, int> IBFDOMAFDBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F332F0", Offset = "0x6F31EF0", VA = "0x186F332F0")]
	internal void MCBFNBLJIDL(long NJLADJKJICM, Action<DBAMMHCPHCA, int> IBFDOMAFDBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EKICNLEGFBE : IEquatable<EKICNLEGFBE>
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OJHKHHEIHII = 3;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const int GGAEKMBOICI = 25;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const int DBEEFNMCLEE = 180;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const int KOECDBFBCEH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const int CIGMHIHAAHE = 10;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid ADPDKPLAIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B92D0", Offset = "0x8B7ED0", VA = "0x1808B92D0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x978B90", Offset = "0x977790", VA = "0x180978B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public long HDLBFFFLPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x105B610", Offset = "0x105A210", VA = "0x18105B610")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public string LDEKDOMMOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public string OKBMEIEFIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x843310", Offset = "0x841F10", VA = "0x180843310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DateTime BCHBLFEEHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1C6D590", Offset = "0x1C6C190", VA = "0x181C6D590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DateTime GFKKFBOJOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5D270B0", Offset = "0x5D25CB0", VA = "0x185D270B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public HashSet<long> GLLPKDOJLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8433B0", Offset = "0x841FB0", VA = "0x1808433B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x843340", Offset = "0x841F40", VA = "0x180843340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public RoomInventoryItemProperties CECAJGPIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x843360", Offset = "0x841F60", VA = "0x180843360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8434C0", Offset = "0x8420C0", VA = "0x1808434C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public byte MGOKCEPFKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x843200", Offset = "0x841E00", VA = "0x180843200")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8431D0", Offset = "0x841DD0", VA = "0x1808431D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IEKJABEGPBP IFLIDIAMOMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xE99840", Offset = "0xE98440", VA = "0x180E99840")]
		[CompilerGenerated]
		get
		{
			return default(IEKJABEGPBP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xE987D0", Offset = "0xE973D0", VA = "0x180E987D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6F33D90", Offset = "0x6F32990", VA = "0x186F33D90")]
	public EKICNLEGFBE(IKNANHNECBN JHGEMPHPJMH, [Optional] RoomInventoryItemProperties BDOEOJENHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F33840", Offset = "0x6F32440", VA = "0x186F33840", Slot = "4")]
	public bool Equals(EKICNLEGFBE OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F33670", Offset = "0x6F32270", VA = "0x186F33670", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F339C0", Offset = "0x6F325C0", VA = "0x186F339C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F33AA0", Offset = "0x6F326A0", VA = "0x186F33AA0")]
	private HashSet<long> JGNMGNEIKBI(IKNANHNECBN JHGEMPHPJMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class NNOMPODEGAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private DBAMMHCPHCA NLBFKPPHMGF;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EKICNLEGFBE NHAAOKBEPGF
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DBAMMHCPHCA IHGCGEEJEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6F34310", Offset = "0x6F32F10", VA = "0x186F34310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F343A0", Offset = "0x6F32FA0", VA = "0x186F343A0")]
	public NNOMPODEGAG(EKICNLEGFBE ANPABEIMBCC, [Optional] DBAMMHCPHCA NLBFKPPHMGF)
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
			[Cpp2IlInjected.Address(RVA = "0x6F34980", Offset = "0x6F33580", VA = "0x186F34980")]
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
			[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8444C0", Offset = "0x8430C0", VA = "0x1808444C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool SupportsUseAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x90BF50", Offset = "0x90AB50", VA = "0x18090BF50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAF5FA0", Offset = "0xAF4BA0", VA = "0x180AF5FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public BNEFENIGNCJ Visibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
			[CompilerGenerated]
			get
			{
				return default(BNEFENIGNCJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x84DE00", Offset = "0x84CA00", VA = "0x18084DE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ShowsCountInEquipmentSlots
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCDD560", Offset = "0xCDC160", VA = "0x180CDD560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4475170", Offset = "0x4473D70", VA = "0x184475170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool EnableEquipButton
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xA53410", Offset = "0xA52010", VA = "0x180A53410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB30190", Offset = "0xB2ED90", VA = "0x180B30190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CloseWatchOnUse
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDCFC60", Offset = "0xDCE860", VA = "0x180DCFC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xDD07C0", Offset = "0xDCF3C0", VA = "0x180DD07C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F346F0", Offset = "0x6F332F0", VA = "0x186F346F0", Slot = "4")]
		public bool Equals(RoomInventoryItemProperties OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F34770", Offset = "0x6F33370", VA = "0x186F34770")]
		public static RoomInventoryItemProperties KLPACBHCBJJ(RoomInventoryItemProperties BDOEOJENHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F34920", Offset = "0x6F33520", VA = "0x186F34920")]
		public RoomInventoryItemProperties()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MDHDBBEIJGC
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const int LPFOCJIDGMB = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private string JLMAFHOJDPO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static StringBuilder AHDPALCLHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private string EDLCIGJNLMA;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long CAICPJDODAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x14E0260", Offset = "0x14DEE60", VA = "0x1814E0260")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F34160", Offset = "0x6F32D60", VA = "0x186F34160")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string DKCABFIGINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F33F10", Offset = "0x6F32B10", VA = "0x186F33F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public RoomInventoryTagClientProperties CECAJGPIJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool JNNLHLAHIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F33EF0", Offset = "0x6F32AF0", VA = "0x186F33EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MDHDBBEIJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F34210", Offset = "0x6F32E10", VA = "0x186F34210")]
	public MDHDBBEIJGC(FLODLMCEBGP JHGEMPHPJMH, [Optional] RoomInventoryTagClientProperties BDOEOJENHDO)
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
			[Cpp2IlInjected.Address(RVA = "0x6F34BD0", Offset = "0x6F337D0", VA = "0x186F34BD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8444C0", Offset = "0x8430C0", VA = "0x1808444C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F349D0", Offset = "0x6F335D0", VA = "0x186F349D0")]
		public void JAOMGILHFGA(Dictionary<string, object> MEIOPBDHBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
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
