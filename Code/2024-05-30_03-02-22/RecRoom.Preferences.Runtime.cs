using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LNLBKINLICM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class JPEKEAAFECJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66351A0", Offset = "0x66343A0", VA = "0x1866351A0")]
	private static void JMGDCPLNBJD(GDECPFGKBAI HDJFNKPPJCG, Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66354E0", Offset = "0x66346E0", VA = "0x1866354E0")]
	public static bool MHLMDIIPKDD(this GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, [Optional] Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6634C90", Offset = "0x6633E90", VA = "0x186634C90")]
	public static EKPLEIANAOO DNEMMIENIKD(this GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, string HLCKBKFCMPI, [Optional] Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6634DE0", Offset = "0x6633FE0", VA = "0x186634DE0")]
	public static EKPLEIANAOO IECALMDHLLD(this GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, int HLCKBKFCMPI, [Optional] Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6634F20", Offset = "0x6634120", VA = "0x186634F20")]
	public static EKPLEIANAOO JENLNBKBGEA(this GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, bool HLCKBKFCMPI, [Optional] Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6635390", Offset = "0x6634590", VA = "0x186635390")]
	public static EKPLEIANAOO MDAEEEABNPE(this GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, float HLCKBKFCMPI, [Optional] Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6635220", Offset = "0x6634420", VA = "0x186635220")]
	public static EKPLEIANAOO KGCMGJGMCGF(this GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, DateTime HLCKBKFCMPI, [Optional] Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6635060", Offset = "0x6634260", VA = "0x186635060")]
	public static EKPLEIANAOO JKIMPCIJFPD(this GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, long HLCKBKFCMPI, [Optional] Action<GDECPFGKBAI> DGKJHGBCCCD)
	{
		return default(EKPLEIANAOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NPPEIAEOHIK : MOEEFGKBBDM, GDECPFGKBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ONPAOLELHHI ALCPFGNJPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> KKEEKNMEMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> LAOBOHCKIJM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> LOBEMBHBMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x66372E0", Offset = "0x66364E0", VA = "0x1866372E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action OPDOMMNCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66376B0", Offset = "0x66368B0", VA = "0x1866376B0")]
	[Preserve]
	public NPPEIAEOHIK([KFHLAIGNCCH(null)] ONPAOLELHHI ALCPFGNJPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "8")]
	public void MKBEGPKGMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6637520", Offset = "0x6636720", VA = "0x186637520")]
	private DirectoryInfo PLPOHNGHDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6636220", Offset = "0x6635420", VA = "0x186636220", Slot = "6")]
	public Task GBDICAPDAIA(long CFJBLECGFOD, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6636F50", Offset = "0x6636150", VA = "0x186636F50", Slot = "14")]
	public float KFCJPHKJCHD(string MNOIAMGNLNL, float AKBALOLNFML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6635BF0", Offset = "0x6634DF0", VA = "0x186635BF0", Slot = "13")]
	public void AMDKEKIEMOH(string MNOIAMGNLNL, bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6637030", Offset = "0x6636230", VA = "0x186637030", Slot = "12")]
	public bool MLHHCEHDOKH(string MNOIAMGNLNL, bool AKBALOLNFML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66362B0", Offset = "0x66354B0", VA = "0x1866362B0", Slot = "10")]
	public int GNFJPCIMLDK(string MNOIAMGNLNL, int AKBALOLNFML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6637270", Offset = "0x6636470", VA = "0x186637270", Slot = "18")]
	public DateTime NLJICNLEFLE(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6635FA0", Offset = "0x66351A0", VA = "0x186635FA0", Slot = "19")]
	public void DHJKCPPNCLB(string MNOIAMGNLNL, DateTime HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6637100", Offset = "0x6636300", VA = "0x186637100", Slot = "15")]
	public void MNDPFKEPAMC(string MNOIAMGNLNL, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6636FC0", Offset = "0x66361C0", VA = "0x186636FC0", Slot = "11")]
	public void KIMICNGBKDC(string MNOIAMGNLNL, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6636080", Offset = "0x6635280", VA = "0x186636080", Slot = "20")]
	public long EKLPDOKCFHL(string HFIBFDNGBHE, long AKBALOLNFML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6636010", Offset = "0x6635210", VA = "0x186636010", Slot = "21")]
	public void DMKPNLANKEA(string HFIBFDNGBHE, long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2937560", Offset = "0x2936760", VA = "0x182937560", Slot = "22")]
	public T FJJBDPLPOCP<T>(string HFIBFDNGBHE, T AKBALOLNFML, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2983400", Offset = "0x2982600", VA = "0x182983400", Slot = "23")]
	public void IBNAPGFHEME<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6636320", Offset = "0x6635520", VA = "0x186636320", Slot = "16")]
	public string IFAAGBJOGJD(string MNOIAMGNLNL, string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x66360F0", Offset = "0x66352F0", VA = "0x1866360F0", Slot = "17")]
	public void FBNFLJMOFAN(string MNOIAMGNLNL, string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6636160", Offset = "0x6635360", VA = "0x186636160", Slot = "24")]
	public void FFBHNBNOEAE(string MNOIAMGNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6637620", Offset = "0x6636820", VA = "0x186637620", Slot = "9")]
	public bool POHNDNALPGF(string MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6635C60", Offset = "0x6634E60", VA = "0x186635C60", Slot = "25")]
	public Task CONGHHNFEPH(CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6636BC0", Offset = "0x6635DC0", VA = "0x186636BC0")]
	private void KELPJAFKKAE(DirectoryInfo IJPMFOJPBHG, string MJFIKBLBNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6637320", Offset = "0x6636520", VA = "0x186637320")]
	private static string PKCKKPDBDHJ(string MNOIAMGNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6637170", Offset = "0x6636370", VA = "0x186637170")]
	private static string NKFGNBDNHOO(byte[] PGPEJDBBJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2AD5DE0", Offset = "0x2AD4FE0", VA = "0x182AD5DE0")]
	private T JIBGFLOLNJM<T>(string HFIBFDNGBHE, T AKBALOLNFML, [Optional] FHKPNCBPLPG<T> DBJHPBHLHGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4BA0", Offset = "0x2AD3DA0", VA = "0x182AD4BA0")]
	private void HNJFJKPNHAB<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, [Optional] FHKPNCBPLPG<T> DBJHPBHLHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66363D0", Offset = "0x66355D0", VA = "0x1866363D0")]
	private Dictionary<string, string> JGNDGAMCMHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class GOCEACBLNJL
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6633490", Offset = "0x6632690", VA = "0x186633490")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void KKAGNGKELMI(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EKDCNFPFANC : EIGLGKBGKGD
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6631250", Offset = "0x6630450", VA = "0x186631250")]
	[Preserve]
	public EKDCNFPFANC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EIGLGKBGKGD : MOEEFGKBBDM, GDECPFGKBAI, HJGLDODOELF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> KMNCGCNMOPN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action OPDOMMNCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "8")]
	public void MKBEGPKGMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6630EC0", Offset = "0x66300C0", VA = "0x186630EC0", Slot = "6")]
	public Task GBDICAPDAIA(long CFJBLECGFOD, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x66311F0", Offset = "0x66303F0", VA = "0x1866311F0", Slot = "9")]
	public bool POHNDNALPGF(string HFIBFDNGBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6630F50", Offset = "0x6630150", VA = "0x186630F50", Slot = "10")]
	public int GNFJPCIMLDK(string HFIBFDNGBHE, int AKBALOLNFML = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6631070", Offset = "0x6630270", VA = "0x186631070", Slot = "11")]
	public void KIMICNGBKDC(string HFIBFDNGBHE, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x66310D0", Offset = "0x66302D0", VA = "0x1866310D0", Slot = "12")]
	public bool MLHHCEHDOKH(string HFIBFDNGBHE, bool AKBALOLNFML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6630BF0", Offset = "0x662FDF0", VA = "0x186630BF0", Slot = "13")]
	public void AMDKEKIEMOH(string HFIBFDNGBHE, bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6631010", Offset = "0x6630210", VA = "0x186631010", Slot = "14")]
	public float KFCJPHKJCHD(string HFIBFDNGBHE, float AKBALOLNFML = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6631130", Offset = "0x6630330", VA = "0x186631130", Slot = "15")]
	public void MNDPFKEPAMC(string HFIBFDNGBHE, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6630FB0", Offset = "0x66301B0", VA = "0x186630FB0", Slot = "16")]
	public string IFAAGBJOGJD(string HFIBFDNGBHE, [Optional] string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6630E00", Offset = "0x6630000", VA = "0x186630E00", Slot = "17")]
	public void FBNFLJMOFAN(string HFIBFDNGBHE, string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6631190", Offset = "0x6630390", VA = "0x186631190", Slot = "18")]
	public DateTime NLJICNLEFLE(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6630CE0", Offset = "0x662FEE0", VA = "0x186630CE0", Slot = "19")]
	public void DHJKCPPNCLB(string HFIBFDNGBHE, DateTime HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6630DA0", Offset = "0x662FFA0", VA = "0x186630DA0", Slot = "20")]
	public long EKLPDOKCFHL(string HFIBFDNGBHE, long AKBALOLNFML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6630D40", Offset = "0x662FF40", VA = "0x186630D40", Slot = "21")]
	public void DMKPNLANKEA(string HFIBFDNGBHE, long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2826360", Offset = "0x2825560", VA = "0x182826360", Slot = "22")]
	public T FJJBDPLPOCP<T>(string HFIBFDNGBHE, T AKBALOLNFML, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2826950", Offset = "0x2825B50", VA = "0x182826950", Slot = "23")]
	public void IBNAPGFHEME<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x28269F0", Offset = "0x2825BF0", VA = "0x1828269F0")]
	public T JIBGFLOLNJM<T>(string HFIBFDNGBHE, T AKBALOLNFML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2826460", Offset = "0x2825660", VA = "0x182826460")]
	public void HNJFJKPNHAB<T>(string HFIBFDNGBHE, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6630E60", Offset = "0x6630060", VA = "0x186630E60", Slot = "24")]
	public void FFBHNBNOEAE(string HFIBFDNGBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6630C50", Offset = "0x662FE50", VA = "0x186630C50", Slot = "25")]
	public Task CONGHHNFEPH(CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6631250", Offset = "0x6630450", VA = "0x186631250")]
	public EIGLGKBGKGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class MMADLIOBNOC<TParent> where TParent : GDECPFGKBAI
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<MMADLIOBNOC<TParent>> OLHPGHEJMHP;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4146DE0", Offset = "0x4145FE0", VA = "0x184146DE0")]
	protected MMADLIOBNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void BFDHFEEMFPE();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void GKLFAAHDMJF(string MNOIAMGNLNL);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4146870", Offset = "0x4145A70", VA = "0x184146870")]
	public static void HDGHNPAHKMH(string MNOIAMGNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4146AA0", Offset = "0x4145CA0", VA = "0x184146AA0")]
	public static void IAFNEENGCCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JNPCFPMBCPD<TParent, TValue> : MMADLIOBNOC<TParent> where TParent : GDECPFGKBAI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JNPCFPMBCPD<TParent, TValue> DNJMIDOFPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> PFGOJEOIEDN;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D90720", Offset = "0x3D8F920", VA = "0x183D90720")]
	public bool GMADCLHMMHE(string AOIPADELMCO, [Out] TValue LFGFOGMKBPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D90620", Offset = "0x3D8F820", VA = "0x183D90620")]
	public void CAMOONIEILB(string AOIPADELMCO, TValue HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3CE32D0", Offset = "0x3CE24D0", VA = "0x183CE32D0", Slot = "4")]
	protected override void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD4E0", Offset = "0x3AFC6E0", VA = "0x183AFD4E0", Slot = "5")]
	protected override void GKLFAAHDMJF(string AOIPADELMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3D90890", Offset = "0x3D8FA90", VA = "0x183D90890")]
	public JNPCFPMBCPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GDECPFGKBAI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MKBEGPKGMCE();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool POHNDNALPGF(string HFIBFDNGBHE);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int GNFJPCIMLDK(string HFIBFDNGBHE, int AKBALOLNFML = 0);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KIMICNGBKDC(string HFIBFDNGBHE, int HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MLHHCEHDOKH(string HFIBFDNGBHE, bool AKBALOLNFML = false);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMDKEKIEMOH(string HFIBFDNGBHE, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float KFCJPHKJCHD(string HFIBFDNGBHE, float AKBALOLNFML = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNDPFKEPAMC(string HFIBFDNGBHE, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string IFAAGBJOGJD(string HFIBFDNGBHE, [Optional] string AKBALOLNFML);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FBNFLJMOFAN(string HFIBFDNGBHE, string HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime NLJICNLEFLE(string HFIBFDNGBHE, [Optional] DateTime IGFAIIEGNDI);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DHJKCPPNCLB(string HFIBFDNGBHE, DateTime IGFAIIEGNDI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long EKLPDOKCFHL(string HFIBFDNGBHE, long AKBALOLNFML);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DMKPNLANKEA(string HFIBFDNGBHE, long HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T FJJBDPLPOCP<T>(string HFIBFDNGBHE, T AKBALOLNFML, FHKPNCBPLPG<T> IIBHJIMOEIB);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IBNAPGFHEME<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, FHKPNCBPLPG<T> IIBHJIMOEIB);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FFBHNBNOEAE(string HFIBFDNGBHE);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task CONGHHNFEPH([Optional] CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MOEEFGKBBDM : GDECPFGKBAI
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OPDOMMNCFPE;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GBDICAPDAIA(long CFJBLECGFOD, CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HJGLDODOELF : GDECPFGKBAI
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IPDFMCADJAE : MOEEFGKBBDM, GDECPFGKBAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KPHMLCCPIGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public IPDFMCADJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66355D0", Offset = "0x66347D0", VA = "0x1866355D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6635760", Offset = "0x6634960", VA = "0x186635760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FICOOHPNEIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IPDFMCADJAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66314B0", Offset = "0x66306B0", VA = "0x1866314B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x66317A0", Offset = "0x66309A0", VA = "0x1866317A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly MOEEFGKBBDM EFOKPJKIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly NPPEIAEOHIK IKBKHDGDGLI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x66341A0", Offset = "0x66333A0", VA = "0x1866341A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action OPDOMMNCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6633B80", Offset = "0x6632D80", VA = "0x186633B80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6634A80", Offset = "0x6633C80", VA = "0x186634A80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6634B80", Offset = "0x6633D80", VA = "0x186634B80")]
	[Preserve]
	public IPDFMCADJAE([KFHLAIGNCCH(null)] ONPAOLELHHI ALCPFGNJPIP, [KFHLAIGNCCH("Disk_Unity")] MOEEFGKBBDM EFOKPJKIJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x66346C0", Offset = "0x66338C0", VA = "0x1866346C0", Slot = "8")]
	public void MKBEGPKGMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6634AF0", Offset = "0x6633CF0", VA = "0x186634AF0", Slot = "9")]
	public bool POHNDNALPGF(string HFIBFDNGBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6634200", Offset = "0x6633400", VA = "0x186634200", Slot = "10")]
	public int GNFJPCIMLDK(string HFIBFDNGBHE, int AKBALOLNFML = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6634650", Offset = "0x6633850", VA = "0x186634650", Slot = "11")]
	public void KIMICNGBKDC(string HFIBFDNGBHE, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6634720", Offset = "0x6633920", VA = "0x186634720", Slot = "12")]
	public bool MLHHCEHDOKH(string HFIBFDNGBHE, bool AKBALOLNFML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6633B10", Offset = "0x6632D10", VA = "0x186633B10", Slot = "13")]
	public void AMDKEKIEMOH(string HFIBFDNGBHE, bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x66344F0", Offset = "0x66336F0", VA = "0x1866344F0", Slot = "14")]
	public float KFCJPHKJCHD(string HFIBFDNGBHE, float AKBALOLNFML = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x66348B0", Offset = "0x6633AB0", VA = "0x1866348B0", Slot = "15")]
	public void MNDPFKEPAMC(string HFIBFDNGBHE, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6634350", Offset = "0x6633550", VA = "0x186634350", Slot = "16")]
	public string IFAAGBJOGJD(string HFIBFDNGBHE, [Optional] string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6633F10", Offset = "0x6633110", VA = "0x186633F10", Slot = "17")]
	public void FBNFLJMOFAN(string HFIBFDNGBHE, string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6634920", Offset = "0x6633B20", VA = "0x186634920", Slot = "18")]
	public DateTime NLJICNLEFLE(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6633CD0", Offset = "0x6632ED0", VA = "0x186633CD0", Slot = "19")]
	public void DHJKCPPNCLB(string HFIBFDNGBHE, DateTime IGFAIIEGNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6633DB0", Offset = "0x6632FB0", VA = "0x186633DB0", Slot = "20")]
	public long EKLPDOKCFHL(string HFIBFDNGBHE, long AKBALOLNFML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6633D40", Offset = "0x6632F40", VA = "0x186633D40", Slot = "21")]
	public void DMKPNLANKEA(string HFIBFDNGBHE, long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x29E0190", Offset = "0x29DF390", VA = "0x1829E0190", Slot = "22")]
	public T FJJBDPLPOCP<T>(string HFIBFDNGBHE, T AKBALOLNFML, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x29E0850", Offset = "0x29DFA50", VA = "0x1829E0850", Slot = "23")]
	public void IBNAPGFHEME<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6633F80", Offset = "0x6633180", VA = "0x186633F80", Slot = "24")]
	public void FFBHNBNOEAE(string HFIBFDNGBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6633BE0", Offset = "0x6632DE0", VA = "0x186633BE0", Slot = "25")]
	[AsyncStateMachine(typeof(KPHMLCCPIGD))]
	public Task CONGHHNFEPH([Optional] CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6634090", Offset = "0x6633290", VA = "0x186634090", Slot = "6")]
	[AsyncStateMachine(typeof(FICOOHPNEIA))]
	public Task GBDICAPDAIA(long CFJBLECGFOD, CancellationToken GILHKFNDIJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FNDHEJFCGNJ : MOEEFGKBBDM, GDECPFGKBAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PEHLONFIEBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FNDHEJFCGNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6637750", Offset = "0x6636950", VA = "0x186637750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6637B10", Offset = "0x6636D10", VA = "0x186637B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class DAOAAIFDELL : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FNDHEJFCGNJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public DAOAAIFDELL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x662CF00", Offset = "0x662C100", VA = "0x18662CF00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x662CF70", Offset = "0x662C170", VA = "0x18662CF70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly ONPAOLELHHI ALCPFGNJPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool BKMPHKNILAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool IDMMBCBFCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CDBPDONECIJ DKNGCACELHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private MGBJAGNHOEE MLDHCGLCONO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action OPDOMMNCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6632010", Offset = "0x6631210", VA = "0x186632010")]
	[Preserve]
	public FNDHEJFCGNJ([KFHLAIGNCCH(null)] ONPAOLELHHI ALCPFGNJPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "8")]
	public void MKBEGPKGMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6631BC0", Offset = "0x6630DC0", VA = "0x186631BC0", Slot = "6")]
	public Task GBDICAPDAIA(long CFJBLECGFOD, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x111C980", Offset = "0x111BB80", VA = "0x18111C980")]
	private static int KHCLAACANDP(bool HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6631FF0", Offset = "0x66311F0", VA = "0x186631FF0", Slot = "9")]
	public bool POHNDNALPGF(string HFIBFDNGBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6631C50", Offset = "0x6630E50", VA = "0x186631C50", Slot = "10")]
	public int GNFJPCIMLDK(string HFIBFDNGBHE, int AKBALOLNFML = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6631DF0", Offset = "0x6630FF0", VA = "0x186631DF0", Slot = "11")]
	public void KIMICNGBKDC(string HFIBFDNGBHE, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6631E80", Offset = "0x6631080", VA = "0x186631E80", Slot = "12")]
	public bool MLHHCEHDOKH(string HFIBFDNGBHE, bool AKBALOLNFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6631800", Offset = "0x6630A00", VA = "0x186631800", Slot = "13")]
	public void AMDKEKIEMOH(string HFIBFDNGBHE, bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6631D20", Offset = "0x6630F20", VA = "0x186631D20", Slot = "14")]
	public float KFCJPHKJCHD(string HFIBFDNGBHE, float AKBALOLNFML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6631EB0", Offset = "0x66310B0", VA = "0x186631EB0", Slot = "15")]
	public void MNDPFKEPAMC(string HFIBFDNGBHE, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6631F00", Offset = "0x6631100", VA = "0x186631F00", Slot = "18")]
	public DateTime NLJICNLEFLE(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6631990", Offset = "0x6630B90", VA = "0x186631990", Slot = "19")]
	public void DHJKCPPNCLB(string HFIBFDNGBHE, DateTime IGFAIIEGNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6631A70", Offset = "0x6630C70", VA = "0x186631A70", Slot = "20")]
	public long EKLPDOKCFHL(string HFIBFDNGBHE, long AKBALOLNFML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6631A00", Offset = "0x6630C00", VA = "0x186631A00", Slot = "21")]
	public void DMKPNLANKEA(string HFIBFDNGBHE, long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2963B10", Offset = "0x2962D10", VA = "0x182963B10", Slot = "22")]
	public T FJJBDPLPOCP<T>(string HFIBFDNGBHE, T AKBALOLNFML, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2964700", Offset = "0x2963900", VA = "0x182964700", Slot = "23")]
	public void IBNAPGFHEME<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2963CD0", Offset = "0x2962ED0", VA = "0x182963CD0")]
	private T GDKALIPGGLM<T>(string HFIBFDNGBHE, T AKBALOLNFML, [Optional] FHKPNCBPLPG<T> DBJHPBHLHGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2964830", Offset = "0x2963A30", VA = "0x182964830")]
	private void NMJCEHOIMMH<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, [Optional] FHKPNCBPLPG<T> DBJHPBHLHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6631CF0", Offset = "0x6630EF0", VA = "0x186631CF0", Slot = "16")]
	public string IFAAGBJOGJD(string HFIBFDNGBHE, string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6631AE0", Offset = "0x6630CE0", VA = "0x186631AE0", Slot = "17")]
	public void FBNFLJMOFAN(string HFIBFDNGBHE, string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6631B10", Offset = "0x6630D10", VA = "0x186631B10")]
	private void FDGOMCBIEBB(string HFIBFDNGBHE, string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6631EE0", Offset = "0x66310E0", VA = "0x186631EE0")]
	private string NGNIFOEDLGM(string HFIBFDNGBHE, string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6631B30", Offset = "0x6630D30", VA = "0x186631B30", Slot = "24")]
	public void FFBHNBNOEAE(string HFIBFDNGBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6631D50", Offset = "0x6630F50", VA = "0x186631D50")]
	private string KHKEGADDEBD(string MNOIAMGNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x66318A0", Offset = "0x6630AA0", VA = "0x1866318A0", Slot = "25")]
	[AsyncStateMachine(typeof(PEHLONFIEBK))]
	public Task CONGHHNFEPH(CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6631F70", Offset = "0x6631170", VA = "0x186631F70")]
	[IteratorStateMachine(typeof(DAOAAIFDELL))]
	private IEnumerator<AEBIBAEBDOJ> OIFIAIGAGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6631E20", Offset = "0x6631020", VA = "0x186631E20")]
	private void LIFHNCLKMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6631830", Offset = "0x6630A30", VA = "0x186631830")]
	private void CKAAGJAHNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6631C80", Offset = "0x6630E80", VA = "0x186631C80")]
	private void HOJBBDPELFN(bool HKOBAMHMOKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GDLLDCILILE : MOEEFGKBBDM, GDECPFGKBAI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Dictionary<string, string> LAOBOHCKIJM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CABIBPNMJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string MPLOAPNNKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6632C20", Offset = "0x6631E20", VA = "0x186632C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> LOBEMBHBMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6632E40", Offset = "0x6632040", VA = "0x186632E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OPDOMMNCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	[Preserve]
	public GDLLDCILILE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "8")]
	public void MKBEGPKGMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6632690", Offset = "0x6631890", VA = "0x186632690", Slot = "6")]
	public Task GBDICAPDAIA(long CFJBLECGFOD, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6632B40", Offset = "0x6631D40", VA = "0x186632B40", Slot = "14")]
	public float KFCJPHKJCHD(string MNOIAMGNLNL, float AKBALOLNFML)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6632100", Offset = "0x6631300", VA = "0x186632100", Slot = "13")]
	public void AMDKEKIEMOH(string MNOIAMGNLNL, bool HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6632C90", Offset = "0x6631E90", VA = "0x186632C90", Slot = "12")]
	public bool MLHHCEHDOKH(string MNOIAMGNLNL, bool AKBALOLNFML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6632720", Offset = "0x6631920", VA = "0x186632720", Slot = "10")]
	public int GNFJPCIMLDK(string MNOIAMGNLNL, int AKBALOLNFML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6632DD0", Offset = "0x6631FD0", VA = "0x186632DD0", Slot = "18")]
	public DateTime NLJICNLEFLE(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x66323E0", Offset = "0x66315E0", VA = "0x1866323E0", Slot = "19")]
	public void DHJKCPPNCLB(string MNOIAMGNLNL, DateTime HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6632D60", Offset = "0x6631F60", VA = "0x186632D60", Slot = "15")]
	public void MNDPFKEPAMC(string MNOIAMGNLNL, float HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6632BB0", Offset = "0x6631DB0", VA = "0x186632BB0", Slot = "11")]
	public void KIMICNGBKDC(string MNOIAMGNLNL, int HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x66324C0", Offset = "0x66316C0", VA = "0x1866324C0", Slot = "20")]
	public long EKLPDOKCFHL(string HFIBFDNGBHE, long AKBALOLNFML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6632450", Offset = "0x6631650", VA = "0x186632450", Slot = "21")]
	public void DMKPNLANKEA(string HFIBFDNGBHE, long HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2937560", Offset = "0x2936760", VA = "0x182937560", Slot = "22")]
	public T FJJBDPLPOCP<T>(string HFIBFDNGBHE, T AKBALOLNFML, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2983400", Offset = "0x2982600", VA = "0x182983400", Slot = "23")]
	public void IBNAPGFHEME<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, FHKPNCBPLPG<T> IIBHJIMOEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6632790", Offset = "0x6631990", VA = "0x186632790", Slot = "16")]
	public string IFAAGBJOGJD(string MNOIAMGNLNL, string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6632530", Offset = "0x6631730", VA = "0x186632530", Slot = "17")]
	public void FBNFLJMOFAN(string MNOIAMGNLNL, string HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x66325D0", Offset = "0x66317D0", VA = "0x1866325D0", Slot = "24")]
	public void FFBHNBNOEAE(string MNOIAMGNLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6632E80", Offset = "0x6632080", VA = "0x186632E80", Slot = "9")]
	public bool POHNDNALPGF(string MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6632170", Offset = "0x6631370", VA = "0x186632170", Slot = "25")]
	public Task CONGHHNFEPH(CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x29834A0", Offset = "0x29826A0", VA = "0x1829834A0")]
	private T JIBGFLOLNJM<T>(string HFIBFDNGBHE, T AKBALOLNFML, [Optional] FHKPNCBPLPG<T> DBJHPBHLHGE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x29824D0", Offset = "0x29816D0", VA = "0x1829824D0")]
	private void HNJFJKPNHAB<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, [Optional] FHKPNCBPLPG<T> DBJHPBHLHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6632840", Offset = "0x6631A40", VA = "0x186632840")]
	private Dictionary<string, string> JGNDGAMCMHO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JFGFBDBIPIN
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OPDOMMNCFPE;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKBEGPKGMCE();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task OPEHMMJKKOG(long CFJBLECGFOD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NHBIPPFAAAJ(LNLBKINLICM PPMCINIHELC = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IAIFFGPGIEH(string HFIBFDNGBHE, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IBOJIPMOLLN(string HFIBFDNGBHE, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string MKHNKFEFHHC(string HFIBFDNGBHE, [Optional] string AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EKPLEIANAOO PPBKOIFANHK(string HFIBFDNGBHE, string HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int GMPOCCPIHJA(string HFIBFDNGBHE, int AKBALOLNFML = 0, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EKPLEIANAOO JDCBAMJANFG(string HFIBFDNGBHE, int HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DAEJGOJJONH(string HFIBFDNGBHE, bool AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EKPLEIANAOO FFJCHMPIOCJ(string HFIBFDNGBHE, bool HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float OCCAHHPHHPG(string HFIBFDNGBHE, float AKBALOLNFML = 0f, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EKPLEIANAOO OHGKJKDFAKH(string HFIBFDNGBHE, float HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime DFDLOPFLOJO(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EKPLEIANAOO AJDBIHPNLPM(string HFIBFDNGBHE, DateTime HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long DJHJMKKCFOK(string HFIBFDNGBHE, long AKBALOLNFML = 0L, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EKPLEIANAOO MAFLFBPNFMF(string HFIBFDNGBHE, long HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T GFKGILMAOBM<T>(string HFIBFDNGBHE, [Optional] T AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	EKPLEIANAOO EOPMNAFLPIA<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CILOJAKDDCJ(string HFIBFDNGBHE);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool AHPIDCOODJJ(string HFIBFDNGBHE);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string AILIGIJAKJI(string HFIBFDNGBHE, [Optional] string AKBALOLNFML);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	EKPLEIANAOO MAMFLIFJHGD(string HFIBFDNGBHE, string HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int LJMLIOFHLLI(string HFIBFDNGBHE, int AKBALOLNFML = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	EKPLEIANAOO LELGGCFHKOF(string HFIBFDNGBHE, int HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool FOGKNJMMKKA(string HFIBFDNGBHE, bool AKBALOLNFML);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EKPLEIANAOO EBFGJKCALNL(string HFIBFDNGBHE, bool HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float FOOFPMIOKGC(string HFIBFDNGBHE, float AKBALOLNFML = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	EKPLEIANAOO MMMFLOCBLLI(string HFIBFDNGBHE, float HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime BMNPLJBGMPE(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "32")]
	EKPLEIANAOO EMNKAOOEEDJ(string HFIBFDNGBHE, DateTime HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long ENOAMAMHGOM(string HFIBFDNGBHE, long AKBALOLNFML = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "34")]
	EKPLEIANAOO PAKELHEJGED(string HFIBFDNGBHE, long HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FJIHEDKECMJ<T>(FHKPNCBPLPG<T> IIBHJIMOEIB, [Optional] IEqualityComparer<T> MGOCODLOLKK);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void LIMJBFAJEBM<T>();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable EKEHCNOEDOA();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KJGCNHFFIDB(float CNDFBLFAGOA);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task LIFHNCLKMOB([Optional] CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum EKPLEIANAOO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class DFPFCDMMMKI : JFGFBDBIPIN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class EJLFEMBJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected static readonly HashSet<EJLFEMBJPKC> CEICBFALNAI;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x66312E0", Offset = "0x66304E0", VA = "0x1866312E0")]
		public static void IAFNEENGCCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void BFDHFEEMFPE();

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		protected EJLFEMBJPKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class IANALGICFLA<T> : EJLFEMBJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly IANALGICFLA<T> LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public FHKPNCBPLPG<T> IKMHGDPJEJF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> JFJEBPEIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KHKAOJINPDH
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x355D690", Offset = "0x355C890", VA = "0x18355D690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3AFFB30", Offset = "0x3AFED30", VA = "0x183AFFB30")]
		private IANALGICFLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF740", Offset = "0x3AFE940", VA = "0x183AFF740")]
		public void FLGJIGKCNJL(FHKPNCBPLPG<T> DBJHPBHLHGE, [Optional] IEqualityComparer<T> MGOCODLOLKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3AFF590", Offset = "0x3AFE790", VA = "0x183AFF590", Slot = "4")]
		public override void BFDHFEEMFPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class GHPMKCJNDMK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly DFPFCDMMMKI GNAPBMFDOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly object ICDIEFLIMKL;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6632F40", Offset = "0x6632140", VA = "0x186632F40")]
		public GHPMKCJNDMK(DFPFCDMMMKI GNAPBMFDOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6632F10", Offset = "0x6632110", VA = "0x186632F10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MCCDHCKKKJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DFPFCDMMMKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x66357C0", Offset = "0x66349C0", VA = "0x1866357C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6635AB0", Offset = "0x6634CB0", VA = "0x186635AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct AIHOKEFLBBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DFPFCDMMMKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GDECPFGKBAI backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x662CD70", Offset = "0x662BF70", VA = "0x18662CD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct HEBJIGHLECB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public DFPFCDMMMKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x66335E0", Offset = "0x66327E0", VA = "0x1866335E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6633AB0", Offset = "0x6632CB0", VA = "0x186633AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NLGLAPNGNOF : IEnumerator<AEBIBAEBDOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private AEBIBAEBDOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DFPFCDMMMKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private AEBIBAEBDOJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7CD190", Offset = "0x7CC390", VA = "0x1807CD190")]
		[DebuggerHidden]
		public NLGLAPNGNOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6635B10", Offset = "0x6634D10", VA = "0x186635B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6635BA0", Offset = "0x6634DA0", VA = "0x186635BA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly MOEEFGKBBDM INFOJPHIBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly MOEEFGKBBDM PMEGGFLGNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly HJGLDODOELF JGELMCHIJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly CDBPDONECIJ DKNGCACELHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IHDMHCMLFDH BJMMKBDPACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<GDECPFGKBAI> FFMGJDNDNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Task INDKMADFENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MGBJAGNHOEE BACFMNNAECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly object MBADLLBLDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly object GDLJOEJOEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private long KMFBJJKGFEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool ODGACDFNIPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xDB64F0", Offset = "0xDB56F0", VA = "0x180DB64F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource LAAGDIHKFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA70", Offset = "0x7CDC70", VA = "0x1807CEA70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7CEAD0", Offset = "0x7CDCD0", VA = "0x1807CEAD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action OPDOMMNCFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x662D610", Offset = "0x662C810", VA = "0x18662D610", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6630590", Offset = "0x662F790", VA = "0x186630590", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x662F420", Offset = "0x662E620", VA = "0x18662F420")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void LJKAJEFLMOE(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6630990", Offset = "0x662FB90", VA = "0x186630990")]
	[Preserve]
	public DFPFCDMMMKI([KFHLAIGNCCH("Disk")] MOEEFGKBBDM INFOJPHIBKI, [KFHLAIGNCCH("Cloud")] MOEEFGKBBDM PMEGGFLGNPH, [KFHLAIGNCCH(null)] HJGLDODOELF JGELMCHIJAC, [KFHLAIGNCCH(null)] CDBPDONECIJ DKNGCACELHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x662DE10", Offset = "0x662D010", VA = "0x18662DE10", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x64853F0", Offset = "0x64845F0", VA = "0x1864853F0")]
	private void GGGBNAJNGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x662F8B0", Offset = "0x662EAB0", VA = "0x18662F8B0", Slot = "6")]
	public void MKBEGPKGMCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x66303B0", Offset = "0x662F5B0", VA = "0x1866303B0", Slot = "7")]
	public Task OPEHMMJKKOG(long CFJBLECGFOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x66302A0", Offset = "0x662F4A0", VA = "0x1866302A0")]
	[AsyncStateMachine(typeof(MCCDHCKKKJM))]
	private Task OOCPBBGHDLH(long CFJBLECGFOD, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x17E0FB0", Offset = "0x17E01B0", VA = "0x1817E0FB0")]
	private void GCAFOPEBGON(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6630630", Offset = "0x662F830", VA = "0x186630630")]
	private void PIOAMGDGCME(object CEFPPEHCFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x662D450", Offset = "0x662C650", VA = "0x18662D450")]
	private string CCPAFMKPFIO(string FBBDMCNMKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x662D4B0", Offset = "0x662C6B0", VA = "0x18662D4B0")]
	private void CFPJBOLIHAL(LNLBKINLICM PPMCINIHELC, string MNOIAMGNLNL, [Out] MOEEFGKBBDM HDJFNKPPJCG, [Out] string ELHHOOCDIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x662F490", Offset = "0x662E690", VA = "0x18662F490")]
	private MOEEFGKBBDM LJKFNHINDOD(LNLBKINLICM PPMCINIHELC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x662FC70", Offset = "0x662EE70", VA = "0x18662FC70", Slot = "8")]
	public bool NHBIPPFAAAJ(LNLBKINLICM PPMCINIHELC = LNLBKINLICM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x662EB90", Offset = "0x662DD90", VA = "0x18662EB90", Slot = "9")]
	public bool IAIFFGPGIEH(string HFIBFDNGBHE, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x662ECE0", Offset = "0x662DEE0", VA = "0x18662ECE0", Slot = "10")]
	public bool IBOJIPMOLLN(string HFIBFDNGBHE, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x662F920", Offset = "0x662EB20", VA = "0x18662F920", Slot = "11")]
	public string MKHNKFEFHHC(string HFIBFDNGBHE, [Optional] string AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6630710", Offset = "0x662F910", VA = "0x186630710", Slot = "12")]
	public EKPLEIANAOO PPBKOIFANHK(string HFIBFDNGBHE, string HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x662E6C0", Offset = "0x662D8C0", VA = "0x18662E6C0", Slot = "13")]
	public int GMPOCCPIHJA(string HFIBFDNGBHE, int AKBALOLNFML = 0, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x662EEE0", Offset = "0x662E0E0", VA = "0x18662EEE0", Slot = "14")]
	public EKPLEIANAOO JDCBAMJANFG(string HFIBFDNGBHE, int HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x662D780", Offset = "0x662C980", VA = "0x18662D780", Slot = "15")]
	public bool DAEJGOJJONH(string HFIBFDNGBHE, bool AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x662E1D0", Offset = "0x662D3D0", VA = "0x18662E1D0", Slot = "16")]
	public EKPLEIANAOO FFJCHMPIOCJ(string HFIBFDNGBHE, bool HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x662FEC0", Offset = "0x662F0C0", VA = "0x18662FEC0", Slot = "17")]
	public float OCCAHHPHHPG(string HFIBFDNGBHE, float AKBALOLNFML = 0f, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6630020", Offset = "0x662F220", VA = "0x186630020", Slot = "18")]
	public EKPLEIANAOO OHGKJKDFAKH(string HFIBFDNGBHE, float HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x662DB50", Offset = "0x662CD50", VA = "0x18662DB50", Slot = "19")]
	public DateTime DFDLOPFLOJO(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x662D150", Offset = "0x662C350", VA = "0x18662D150", Slot = "20")]
	public EKPLEIANAOO AJDBIHPNLPM(string HFIBFDNGBHE, DateTime HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x662DCB0", Offset = "0x662CEB0", VA = "0x18662DCB0", Slot = "21")]
	public long DJHJMKKCFOK(string HFIBFDNGBHE, long AKBALOLNFML = 0L, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x662F580", Offset = "0x662E780", VA = "0x18662F580", Slot = "22")]
	public EKPLEIANAOO MAFLFBPNFMF(string HFIBFDNGBHE, long HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x28009A0", Offset = "0x27FFBA0", VA = "0x1828009A0", Slot = "23")]
	public T GFKGILMAOBM<T>(string HFIBFDNGBHE, [Optional] T AKBALOLNFML, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x28009A0", Offset = "0x27FFBA0", VA = "0x1828009A0", Slot = "24")]
	public EKPLEIANAOO EOPMNAFLPIA<T>(string HFIBFDNGBHE, T HLCKBKFCMPI, LNLBKINLICM JOPKPBEMOKJ = LNLBKINLICM.CLOUD)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x662D5B0", Offset = "0x662C7B0", VA = "0x18662D5B0", Slot = "25")]
	public bool CILOJAKDDCJ(string HFIBFDNGBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x662D0D0", Offset = "0x662C2D0", VA = "0x18662D0D0", Slot = "26")]
	public bool AHPIDCOODJJ(string HFIBFDNGBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x662D0E0", Offset = "0x662C2E0", VA = "0x18662D0E0", Slot = "27")]
	public string AILIGIJAKJI(string HFIBFDNGBHE, [Optional] string AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x662F7F0", Offset = "0x662E9F0", VA = "0x18662F7F0", Slot = "28")]
	public EKPLEIANAOO MAMFLIFJHGD(string HFIBFDNGBHE, string HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x662F510", Offset = "0x662E710", VA = "0x18662F510", Slot = "29")]
	public int LJMLIOFHLLI(string HFIBFDNGBHE, int AKBALOLNFML = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x662F300", Offset = "0x662E500", VA = "0x18662F300", Slot = "30")]
	public EKPLEIANAOO LELGGCFHKOF(string HFIBFDNGBHE, int HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x662E440", Offset = "0x662D640", VA = "0x18662E440", Slot = "31")]
	public bool FOGKNJMMKKA(string HFIBFDNGBHE, bool AKBALOLNFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x662DFF0", Offset = "0x662D1F0", VA = "0x18662DFF0", Slot = "32")]
	public EKPLEIANAOO EBFGJKCALNL(string HFIBFDNGBHE, bool HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x662E4B0", Offset = "0x662D6B0", VA = "0x18662E4B0", Slot = "33")]
	public float FOOFPMIOKGC(string HFIBFDNGBHE, float AKBALOLNFML = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x662FA80", Offset = "0x662EC80", VA = "0x18662FA80", Slot = "34")]
	public EKPLEIANAOO MMMFLOCBLLI(string HFIBFDNGBHE, float HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x662D3E0", Offset = "0x662C5E0", VA = "0x18662D3E0", Slot = "35")]
	public DateTime BMNPLJBGMPE(string HFIBFDNGBHE, [Optional] DateTime AKBALOLNFML)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x662E130", Offset = "0x662D330", VA = "0x18662E130", Slot = "36")]
	public EKPLEIANAOO EMNKAOOEEDJ(string HFIBFDNGBHE, DateTime HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x662E160", Offset = "0x662D360", VA = "0x18662E160", Slot = "37")]
	public long ENOAMAMHGOM(string HFIBFDNGBHE, long AKBALOLNFML = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6630560", Offset = "0x662F760", VA = "0x186630560", Slot = "38")]
	public EKPLEIANAOO PAKELHEJGED(string HFIBFDNGBHE, long HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x66306B0", Offset = "0x662F8B0", VA = "0x1866306B0")]
	private bool POOKJGAMHDK(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x662CFC0", Offset = "0x662C1C0", VA = "0x18662CFC0")]
	private bool AGLNKFPOMCD(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x662DE50", Offset = "0x662D050", VA = "0x18662DE50")]
	private EKPLEIANAOO EACLINEAOJG(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, string HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x662EA00", Offset = "0x662DC00", VA = "0x18662EA00")]
	private EKPLEIANAOO IAAPLKJAHKI(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, int HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x662E520", Offset = "0x662D720", VA = "0x18662E520")]
	private EKPLEIANAOO GJEALHOOLIL(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, bool HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x662F150", Offset = "0x662E350", VA = "0x18662F150")]
	private EKPLEIANAOO JDEMBCHNJCF(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, float HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x662FAB0", Offset = "0x662ECB0", VA = "0x18662FAB0")]
	private EKPLEIANAOO NFNGIFOGKMG(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, DateTime HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x662FD30", Offset = "0x662EF30", VA = "0x18662FD30")]
	private EKPLEIANAOO NIPJJIHKGAG(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, long HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2801870", Offset = "0x2800A70", VA = "0x182801870")]
	private T LILPLCIBIJP<T>(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, T AKBALOLNFML)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2800D60", Offset = "0x27FFF60", VA = "0x182800D60")]
	private EKPLEIANAOO HDPMEKANLKI<T>(GDECPFGKBAI HDJFNKPPJCG, string HFIBFDNGBHE, T HLCKBKFCMPI)
	{
		return default(EKPLEIANAOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2800B40", Offset = "0x27FFD40", VA = "0x182800B40", Slot = "39")]
	public void FJIHEDKECMJ<T>(FHKPNCBPLPG<T> IIBHJIMOEIB, [Optional] IEqualityComparer<T> MGOCODLOLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2801D70", Offset = "0x2800F70", VA = "0x182801D70", Slot = "40")]
	public void LIMJBFAJEBM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x662D6B0", Offset = "0x662C8B0", VA = "0x18662D6B0")]
	[AsyncStateMachine(typeof(AIHOKEFLBBC))]
	private void CONGHHNFEPH(GDECPFGKBAI KAFKDIHCICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x662F330", Offset = "0x662E530", VA = "0x18662F330", Slot = "43")]
	[AsyncStateMachine(typeof(HEBJIGHLECB))]
	public Task LIFHNCLKMOB([Optional] CancellationToken CEFPPEHCFCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x662E820", Offset = "0x662DA20", VA = "0x18662E820")]
	private void HGFBBDFNLEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x662E050", Offset = "0x662D250", VA = "0x18662E050", Slot = "41")]
	public IDisposable EKEHCNOEDOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x662F2F0", Offset = "0x662E4F0", VA = "0x18662F2F0", Slot = "42")]
	public void KJGCNHFFIDB(float CNDFBLFAGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x662D8E0", Offset = "0x662CAE0", VA = "0x18662D8E0")]
	private void DANLPKMGEHM(float CCCFKCDJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x662F820", Offset = "0x662EA20", VA = "0x18662F820")]
	[IteratorStateMachine(typeof(NLGLAPNGNOF))]
	private IEnumerator<AEBIBAEBDOJ> MJCNLKGLAEJ(float CNDFBLFAGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x662E020", Offset = "0x662D220", VA = "0x18662E020")]
	[CompilerGenerated]
	private void EJNMEIGHJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GILIMFIOEGD : NNBNBBGOECN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static GILIMFIOEGD LNFBMICMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6633270", Offset = "0x6632470", VA = "0x186633270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x66332C0", Offset = "0x66324C0", VA = "0x1866332C0", Slot = "9")]
	public override string GKNEHCEDNDE(bool NBFGFAAMIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6632FF0", Offset = "0x66321F0", VA = "0x186632FF0", Slot = "10")]
	protected override bool BLEJOEIHMHF(string NBFGFAAMIMJ, [Out] bool HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6633450", Offset = "0x6632650", VA = "0x186633450")]
	public GILIMFIOEGD()
	{
	}
}
namespace Cpp2IlInjected;

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
