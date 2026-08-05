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
public enum LPKNHOENMHH : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal static class PPGMJOLKLPO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60528E0", Offset = "0x6051CE0", VA = "0x1860528E0")]
	private static void MCMBLMHDKLG(BLHCHMNCMBD GMDHDDHHENE, Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60522B0", Offset = "0x60516B0", VA = "0x1860522B0")]
	public static bool EOBMOMKLKIF(this BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, [Optional] Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6052160", Offset = "0x6051560", VA = "0x186052160")]
	public static DPMBKLMPHDM AAHBBEDGAOD(this BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, string NMENOOMOOJP, [Optional] Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6052660", Offset = "0x6051A60", VA = "0x186052660")]
	public static DPMBKLMPHDM HFOOFIPFODJ(this BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, int NMENOOMOOJP, [Optional] Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6052960", Offset = "0x6051D60", VA = "0x186052960")]
	public static DPMBKLMPHDM PHLKFKGHOGJ(this BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, bool NMENOOMOOJP, [Optional] Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6052510", Offset = "0x6051910", VA = "0x186052510")]
	public static DPMBKLMPHDM GLDAOEPJABC(this BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, float NMENOOMOOJP, [Optional] Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60523A0", Offset = "0x60517A0", VA = "0x1860523A0")]
	public static DPMBKLMPHDM FPAJOPFDJEG(this BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, DateTime NMENOOMOOJP, [Optional] Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60527A0", Offset = "0x6051BA0", VA = "0x1860527A0")]
	public static DPMBKLMPHDM LCCKCLDHIND(this BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, long NMENOOMOOJP, [Optional] Action<BLHCHMNCMBD> MIFNMJMDHDJ)
	{
		return default(DPMBKLMPHDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BAHILEDNFKJ : NGOIOCEKMBE, BLHCHMNCMBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BKBIGLGMPOC ILFFNDIJJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<string, byte> OHNGBIKBEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private Dictionary<string, string> JLKNCAIDBGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Dictionary<string, string> KLENNHEOJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x604A220", Offset = "0x6049620", VA = "0x18604A220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action AAHDMKMOCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x604AB20", Offset = "0x6049F20", VA = "0x18604AB20")]
	[Preserve]
	public BAHILEDNFKJ([MJHHGJKKIMK(null)] BKBIGLGMPOC ILFFNDIJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "8")]
	public void JKAPHGNOMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x604A260", Offset = "0x6049660", VA = "0x18604A260")]
	private DirectoryInfo MIPHFHLDBKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6049120", Offset = "0x6048520", VA = "0x186049120", Slot = "6")]
	public Task AMCMMAEGFNK(long GEHPPAAKCLF, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6049E60", Offset = "0x6049260", VA = "0x186049E60", Slot = "14")]
	public float GIBNMALDPGA(string MIMFBLPNKOG, float IEKAHKGFLJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x604A140", Offset = "0x6049540", VA = "0x18604A140", Slot = "13")]
	public void KLFAIMAEEDO(string MIMFBLPNKOG, bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60493C0", Offset = "0x60487C0", VA = "0x1860493C0", Slot = "12")]
	public bool DALMPAODNLF(string MIMFBLPNKOG, bool IEKAHKGFLJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x604A1B0", Offset = "0x60495B0", VA = "0x18604A1B0", Slot = "10")]
	public int KPMFIHDNFCI(string MIMFBLPNKOG, int IEKAHKGFLJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6049F40", Offset = "0x6049340", VA = "0x186049F40", Slot = "18")]
	public DateTime ILCEHAMNHJC(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x604A0D0", Offset = "0x60494D0", VA = "0x18604A0D0", Slot = "19")]
	public void JOKLBBFDPPF(string MIMFBLPNKOG, DateTime NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6049ED0", Offset = "0x60492D0", VA = "0x186049ED0", Slot = "15")]
	public void IJBKNBOJMNO(string MIMFBLPNKOG, float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6049FB0", Offset = "0x60493B0", VA = "0x186049FB0", Slot = "11")]
	public void IOGEOPEGCFB(string MIMFBLPNKOG, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6049220", Offset = "0x6048620", VA = "0x186049220", Slot = "20")]
	public long BFMFDOELOPE(string JJOBNGACPHH, long IEKAHKGFLJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6049290", Offset = "0x6048690", VA = "0x186049290", Slot = "21")]
	public void BKNNMLCMOGA(string JJOBNGACPHH, long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x22BB140", Offset = "0x22BA540", VA = "0x1822BB140", Slot = "22")]
	public T PGCJDGAFNOO<T>(string JJOBNGACPHH, T IEKAHKGFLJB, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x22BB0A0", Offset = "0x22BA4A0", VA = "0x1822BB0A0", Slot = "23")]
	public void NLMIJFOAMGA<T>(string JJOBNGACPHH, T NMENOOMOOJP, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x604A020", Offset = "0x6049420", VA = "0x18604A020", Slot = "16")]
	public string JKACOHPGJEJ(string MIMFBLPNKOG, string IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60491B0", Offset = "0x60485B0", VA = "0x1860491B0", Slot = "17")]
	public void AMHBBCEGELK(string MIMFBLPNKOG, string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6049300", Offset = "0x6048700", VA = "0x186049300", Slot = "24")]
	public void BPAAMDJEAFO(string MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6049090", Offset = "0x6048490", VA = "0x186049090", Slot = "9")]
	public bool AHFGLDFNFOK(string MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6049A20", Offset = "0x6048E20", VA = "0x186049A20", Slot = "25")]
	public Task EIEFGPDDGIP(CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6049490", Offset = "0x6048890", VA = "0x186049490")]
	private void DFFJKLDDGKA(DirectoryInfo KMEGDNCCHCH, string NHHMBCJMKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6049820", Offset = "0x6048C20", VA = "0x186049820")]
	private static string DIMEIOKCHLK(string MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6049D60", Offset = "0x6049160", VA = "0x186049D60")]
	private static string ENCMEAAHNBO(byte[] HPGJIANHJNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x22B8D00", Offset = "0x22B8100", VA = "0x1822B8D00")]
	private T EHGHEBAOCHM<T>(string JJOBNGACPHH, T IEKAHKGFLJB, [Optional] KKPFKAMFHMP<T> DDLACINCNAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x22B9E50", Offset = "0x22B9250", VA = "0x1822B9E50")]
	private void HPDCNGOHBJP<T>(string JJOBNGACPHH, T NMENOOMOOJP, [Optional] KKPFKAMFHMP<T> DDLACINCNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x604A360", Offset = "0x6049760", VA = "0x18604A360")]
	private Dictionary<string, string> NIGPJHOBCGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MGKHKEDJCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6050810", Offset = "0x604FC10", VA = "0x186050810")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void KLOPPCLPFPI(DIBCBJLEDOH KIMBONFFHDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HNFLMLJCCIB : PFIACNFHKGB
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x604FF10", Offset = "0x604F310", VA = "0x18604FF10")]
	[Preserve]
	public HNFLMLJCCIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PFIACNFHKGB : NGOIOCEKMBE, BLHCHMNCMBD, BDKMPJKCKNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<string, object> OFMALGGIEBH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AAHDMKMOCNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "8")]
	public void JKAPHGNOMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6051970", Offset = "0x6050D70", VA = "0x186051970", Slot = "6")]
	public Task AMCMMAEGFNK(long GEHPPAAKCLF, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6051910", Offset = "0x6050D10", VA = "0x186051910", Slot = "9")]
	public bool AHFGLDFNFOK(string JJOBNGACPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6051F10", Offset = "0x6051310", VA = "0x186051F10", Slot = "10")]
	public int KPMFIHDNFCI(string JJOBNGACPHH, int IEKAHKGFLJB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6051D90", Offset = "0x6051190", VA = "0x186051D90", Slot = "11")]
	public void IOGEOPEGCFB(string JJOBNGACPHH, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6051B80", Offset = "0x6050F80", VA = "0x186051B80", Slot = "12")]
	public bool DALMPAODNLF(string JJOBNGACPHH, bool IEKAHKGFLJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6051EB0", Offset = "0x60512B0", VA = "0x186051EB0", Slot = "13")]
	public void KLFAIMAEEDO(string JJOBNGACPHH, bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6051C70", Offset = "0x6051070", VA = "0x186051C70", Slot = "14")]
	public float GIBNMALDPGA(string JJOBNGACPHH, float IEKAHKGFLJB = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6051CD0", Offset = "0x60510D0", VA = "0x186051CD0", Slot = "15")]
	public void IJBKNBOJMNO(string JJOBNGACPHH, float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6051DF0", Offset = "0x60511F0", VA = "0x186051DF0", Slot = "16")]
	public string JKACOHPGJEJ(string JJOBNGACPHH, [Optional] string IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6051A00", Offset = "0x6050E00", VA = "0x186051A00", Slot = "17")]
	public void AMHBBCEGELK(string JJOBNGACPHH, string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6051D30", Offset = "0x6051130", VA = "0x186051D30", Slot = "18")]
	public DateTime ILCEHAMNHJC(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6051E50", Offset = "0x6051250", VA = "0x186051E50", Slot = "19")]
	public void JOKLBBFDPPF(string JJOBNGACPHH, DateTime NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6051A60", Offset = "0x6050E60", VA = "0x186051A60", Slot = "20")]
	public long BFMFDOELOPE(string JJOBNGACPHH, long IEKAHKGFLJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6051AC0", Offset = "0x6050EC0", VA = "0x186051AC0", Slot = "21")]
	public void BKNNMLCMOGA(string JJOBNGACPHH, long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2667A00", Offset = "0x2666E00", VA = "0x182667A00", Slot = "22")]
	public T PGCJDGAFNOO<T>(string JJOBNGACPHH, T IEKAHKGFLJB, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2667960", Offset = "0x2666D60", VA = "0x182667960", Slot = "23")]
	public void NLMIJFOAMGA<T>(string JJOBNGACPHH, T NMENOOMOOJP, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2666C30", Offset = "0x2666030", VA = "0x182666C30")]
	public T EHGHEBAOCHM<T>(string JJOBNGACPHH, T IEKAHKGFLJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2667470", Offset = "0x2666870", VA = "0x182667470")]
	public void HPDCNGOHBJP<T>(string JJOBNGACPHH, T NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6051B20", Offset = "0x6050F20", VA = "0x186051B20", Slot = "24")]
	public void BPAAMDJEAFO(string JJOBNGACPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6051BE0", Offset = "0x6050FE0", VA = "0x186051BE0", Slot = "25")]
	public Task EIEFGPDDGIP(CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x604FF10", Offset = "0x604F310", VA = "0x18604FF10")]
	public PFIACNFHKGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class GBBHBLMPEKC<TParent> where TParent : BLHCHMNCMBD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly HashSet<GBBHBLMPEKC<TParent>> IHBJKOOOMEE;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3500C20", Offset = "0x3500020", VA = "0x183500C20")]
	protected GBBHBLMPEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void ILNOFIHDCKG();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EPOLLBLHIAH(string MIMFBLPNKOG);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3500670", Offset = "0x34FFA70", VA = "0x183500670")]
	public static void EDNKKAAIHDE(string MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35008B0", Offset = "0x34FFCB0", VA = "0x1835008B0")]
	public static void FLCGACKLJEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DBNACMLIPFJ<TParent, TValue> : GBBHBLMPEKC<TParent> where TParent : BLHCHMNCMBD
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly DBNACMLIPFJ<TParent, TValue> LHECNHAABJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Dictionary<string, TValue> LMGKKLGDHJP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34749B0", Offset = "0x3473DB0", VA = "0x1834749B0")]
	public bool AFCHMNEGHNL(string NGGIFCJNAHC, [Out] TValue CEEBCGLJBHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5C10", Offset = "0x4DA5010", VA = "0x184DA5C10")]
	public void PNLEGOGLIAK(string NGGIFCJNAHC, TValue NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C999A0", Offset = "0x3C98DA0", VA = "0x183C999A0", Slot = "4")]
	protected override void ILNOFIHDCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x36B4D80", Offset = "0x36B4180", VA = "0x1836B4D80", Slot = "5")]
	protected override void EPOLLBLHIAH(string NGGIFCJNAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5E40", Offset = "0x4DA5240", VA = "0x184DA5E40")]
	public DBNACMLIPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BLHCHMNCMBD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKAPHGNOMCA();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AHFGLDFNFOK(string JJOBNGACPHH);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KPMFIHDNFCI(string JJOBNGACPHH, int IEKAHKGFLJB = 0);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOGEOPEGCFB(string JJOBNGACPHH, int NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DALMPAODNLF(string JJOBNGACPHH, bool IEKAHKGFLJB = false);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLFAIMAEEDO(string JJOBNGACPHH, bool NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float GIBNMALDPGA(string JJOBNGACPHH, float IEKAHKGFLJB = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IJBKNBOJMNO(string JJOBNGACPHH, float NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string JKACOHPGJEJ(string JJOBNGACPHH, [Optional] string IEKAHKGFLJB);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AMHBBCEGELK(string JJOBNGACPHH, string NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime ILCEHAMNHJC(string JJOBNGACPHH, [Optional] DateTime FGIPPEJBGDB);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOKLBBFDPPF(string JJOBNGACPHH, DateTime FGIPPEJBGDB);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long BFMFDOELOPE(string JJOBNGACPHH, long IEKAHKGFLJB);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BKNNMLCMOGA(string JJOBNGACPHH, long NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T PGCJDGAFNOO<T>(string JJOBNGACPHH, T IEKAHKGFLJB, KKPFKAMFHMP<T> MBLEBLCCBLO);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NLMIJFOAMGA<T>(string JJOBNGACPHH, T NMENOOMOOJP, KKPFKAMFHMP<T> MBLEBLCCBLO);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BPAAMDJEAFO(string JJOBNGACPHH);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task EIEFGPDDGIP([Optional] CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NGOIOCEKMBE : BLHCHMNCMBD
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AAHDMKMOCNM;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task AMCMMAEGFNK(long GEHPPAAKCLF, CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BDKMPJKCKNJ : BLHCHMNCMBD
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AEJGGCFGJLE : NGOIOCEKMBE, BLHCHMNCMBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct POGOMLJMJKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AEJGGCFGJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6051F70", Offset = "0x6051370", VA = "0x186051F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6052100", Offset = "0x6051500", VA = "0x186052100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HMHGBKDGHIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AEJGGCFGJLE <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x604FBC0", Offset = "0x604EFC0", VA = "0x18604FBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x604FEB0", Offset = "0x604F2B0", VA = "0x18604FEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NGOIOCEKMBE AHHNOCONMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly BAHILEDNFKJ DOGBBJNGMHO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6047E00", Offset = "0x6047200", VA = "0x186047E00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AAHDMKMOCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6048450", Offset = "0x6047850", VA = "0x186048450", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6048D70", Offset = "0x6048170", VA = "0x186048D70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6048DE0", Offset = "0x60481E0", VA = "0x186048DE0")]
	[Preserve]
	public AEJGGCFGJLE([MJHHGJKKIMK(null)] BKBIGLGMPOC ILFFNDIJJFD, [MJHHGJKKIMK("Disk_Unity")] NGOIOCEKMBE AHHNOCONMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6048AE0", Offset = "0x6047EE0", VA = "0x186048AE0", Slot = "8")]
	public void JKAPHGNOMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6047D70", Offset = "0x6047170", VA = "0x186047D70", Slot = "9")]
	public bool AHFGLDFNFOK(string JJOBNGACPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6048C20", Offset = "0x6048020", VA = "0x186048C20", Slot = "10")]
	public int KPMFIHDNFCI(string JJOBNGACPHH, int IEKAHKGFLJB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60488D0", Offset = "0x6047CD0", VA = "0x1860488D0", Slot = "11")]
	public void IOGEOPEGCFB(string JJOBNGACPHH, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60482C0", Offset = "0x60476C0", VA = "0x1860482C0", Slot = "12")]
	public bool DALMPAODNLF(string JJOBNGACPHH, bool IEKAHKGFLJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6048BB0", Offset = "0x6047FB0", VA = "0x186048BB0", Slot = "13")]
	public void KLFAIMAEEDO(string JJOBNGACPHH, bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60485A0", Offset = "0x60479A0", VA = "0x1860485A0", Slot = "14")]
	public float GIBNMALDPGA(string JJOBNGACPHH, float IEKAHKGFLJB = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6048700", Offset = "0x6047B00", VA = "0x186048700", Slot = "15")]
	public void IJBKNBOJMNO(string JJOBNGACPHH, float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6048940", Offset = "0x6047D40", VA = "0x186048940", Slot = "16")]
	public string JKACOHPGJEJ(string JJOBNGACPHH, [Optional] string IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6047F70", Offset = "0x6047370", VA = "0x186047F70", Slot = "17")]
	public void AMHBBCEGELK(string JJOBNGACPHH, string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6048770", Offset = "0x6047B70", VA = "0x186048770", Slot = "18")]
	public DateTime ILCEHAMNHJC(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6048B40", Offset = "0x6047F40", VA = "0x186048B40", Slot = "19")]
	public void JOKLBBFDPPF(string JJOBNGACPHH, DateTime FGIPPEJBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6047FE0", Offset = "0x60473E0", VA = "0x186047FE0", Slot = "20")]
	public long BFMFDOELOPE(string JJOBNGACPHH, long IEKAHKGFLJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6048140", Offset = "0x6047540", VA = "0x186048140", Slot = "21")]
	public void BKNNMLCMOGA(string JJOBNGACPHH, long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2B23400", Offset = "0x2B22800", VA = "0x182B23400", Slot = "22")]
	public T PGCJDGAFNOO<T>(string JJOBNGACPHH, T IEKAHKGFLJB, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2B23330", Offset = "0x2B22730", VA = "0x182B23330", Slot = "23")]
	public void NLMIJFOAMGA<T>(string JJOBNGACPHH, T NMENOOMOOJP, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60481B0", Offset = "0x60475B0", VA = "0x1860481B0", Slot = "24")]
	public void BPAAMDJEAFO(string JJOBNGACPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60484B0", Offset = "0x60478B0", VA = "0x1860484B0", Slot = "25")]
	[AsyncStateMachine(typeof(POGOMLJMJKL))]
	public Task EIEFGPDDGIP([Optional] CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6047E60", Offset = "0x6047260", VA = "0x186047E60", Slot = "6")]
	[AsyncStateMachine(typeof(HMHGBKDGHIB))]
	public Task AMCMMAEGFNK(long GEHPPAAKCLF, CancellationToken EANFAKGANNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HJIIJNFFCGB : NGOIOCEKMBE, BLHCHMNCMBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DAHCMBIAKAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HJIIJNFFCGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x604E9F0", Offset = "0x604DDF0", VA = "0x18604E9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x604EDC0", Offset = "0x604E1C0", VA = "0x18604EDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class APLAJLJMLEG : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public HJIIJNFFCGB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public APLAJLJMLEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6048FD0", Offset = "0x60483D0", VA = "0x186048FD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6049040", Offset = "0x6048440", VA = "0x186049040", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly BKBIGLGMPOC ILFFNDIJJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool BLMOMMOODOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool KBBDOPPIJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private DAHKGHMHLKA FDOFKCPCEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private BDOFDMHMNPK LJPIPEAGNOO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action AAHDMKMOCNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x604FAD0", Offset = "0x604EED0", VA = "0x18604FAD0")]
	[Preserve]
	public HJIIJNFFCGB([MJHHGJKKIMK(null)] BKBIGLGMPOC ILFFNDIJJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "8")]
	public void JKAPHGNOMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x604F350", Offset = "0x604E750", VA = "0x18604F350", Slot = "6")]
	public Task AMCMMAEGFNK(long GEHPPAAKCLF, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51BCDB0", Offset = "0x51BC1B0", VA = "0x1851BCDB0")]
	private static int OGIKGJFAMIN(bool NMENOOMOOJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x604F330", Offset = "0x604E730", VA = "0x18604F330", Slot = "9")]
	public bool AHFGLDFNFOK(string JJOBNGACPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x604F9E0", Offset = "0x604EDE0", VA = "0x18604F9E0", Slot = "10")]
	public int KPMFIHDNFCI(string JJOBNGACPHH, int IEKAHKGFLJB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x604F8E0", Offset = "0x604ECE0", VA = "0x18604F8E0", Slot = "11")]
	public void IOGEOPEGCFB(string JJOBNGACPHH, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x604F5E0", Offset = "0x604E9E0", VA = "0x18604F5E0", Slot = "12")]
	public bool DALMPAODNLF(string JJOBNGACPHH, bool IEKAHKGFLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x604F9B0", Offset = "0x604EDB0", VA = "0x18604F9B0", Slot = "13")]
	public void KLFAIMAEEDO(string JJOBNGACPHH, bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x604F770", Offset = "0x604EB70", VA = "0x18604F770", Slot = "14")]
	public float GIBNMALDPGA(string JJOBNGACPHH, float IEKAHKGFLJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x604F840", Offset = "0x604EC40", VA = "0x18604F840", Slot = "15")]
	public void IJBKNBOJMNO(string JJOBNGACPHH, float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x604F870", Offset = "0x604EC70", VA = "0x18604F870", Slot = "18")]
	public DateTime ILCEHAMNHJC(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x604F940", Offset = "0x604ED40", VA = "0x18604F940", Slot = "19")]
	public void JOKLBBFDPPF(string JJOBNGACPHH, DateTime FGIPPEJBGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x604F410", Offset = "0x604E810", VA = "0x18604F410", Slot = "20")]
	public long BFMFDOELOPE(string JJOBNGACPHH, long IEKAHKGFLJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x604F480", Offset = "0x604E880", VA = "0x18604F480", Slot = "21")]
	public void BKNNMLCMOGA(string JJOBNGACPHH, long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2533E10", Offset = "0x2533210", VA = "0x182533E10", Slot = "22")]
	public T PGCJDGAFNOO<T>(string JJOBNGACPHH, T IEKAHKGFLJB, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2533610", Offset = "0x2532A10", VA = "0x182533610", Slot = "23")]
	public void NLMIJFOAMGA<T>(string JJOBNGACPHH, T NMENOOMOOJP, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x2532BC0", Offset = "0x2531FC0", VA = "0x182532BC0")]
	private T CHPDHFMKPBE<T>(string JJOBNGACPHH, T IEKAHKGFLJB, [Optional] KKPFKAMFHMP<T> DDLACINCNAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2533740", Offset = "0x2532B40", VA = "0x182533740")]
	private void PBKCOJPEBML<T>(string JJOBNGACPHH, T NMENOOMOOJP, [Optional] KKPFKAMFHMP<T> DDLACINCNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x604F910", Offset = "0x604ED10", VA = "0x18604F910", Slot = "16")]
	public string JKACOHPGJEJ(string JJOBNGACPHH, string IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x604F3E0", Offset = "0x604E7E0", VA = "0x18604F3E0", Slot = "17")]
	public void AMHBBCEGELK(string JJOBNGACPHH, string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x604F7A0", Offset = "0x604EBA0", VA = "0x18604F7A0")]
	private void GJOMFNMANLG(string JJOBNGACPHH, string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x604FAB0", Offset = "0x604EEB0", VA = "0x18604FAB0")]
	private string MJDLGKDKMOA(string JJOBNGACPHH, string IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x604F4F0", Offset = "0x604E8F0", VA = "0x18604F4F0", Slot = "24")]
	public void BPAAMDJEAFO(string JJOBNGACPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x604FA10", Offset = "0x604EE10", VA = "0x18604FA10")]
	private string MDAOPAOJHBC(string MIMFBLPNKOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x604F610", Offset = "0x604EA10", VA = "0x18604F610", Slot = "25")]
	[AsyncStateMachine(typeof(DAHCMBIAKAB))]
	public Task EIEFGPDDGIP(CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x604F7C0", Offset = "0x604EBC0", VA = "0x18604F7C0")]
	[IteratorStateMachine(typeof(APLAJLJMLEG))]
	private IEnumerator<EIIEDLICJGP> HBJIDMFNHJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x604F580", Offset = "0x604E980", VA = "0x18604F580")]
	private void CMOLHPLCGBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x604F2C0", Offset = "0x604E6C0", VA = "0x18604F2C0")]
	private void AAEJLBODKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x604F700", Offset = "0x604EB00", VA = "0x18604F700")]
	private void FDPKJPIFFND(bool OHKFABCALMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NAIBILBICEC : NGOIOCEKMBE, BLHCHMNCMBD
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
	private Dictionary<string, string> JLKNCAIDBGG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool EJJHGBIINJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private string BHGOPIBNHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x60512F0", Offset = "0x60506F0", VA = "0x1860512F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Dictionary<string, string> KLENNHEOJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6051440", Offset = "0x6050840", VA = "0x186051440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action AAHDMKMOCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
	[Preserve]
	public NAIBILBICEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "8")]
	public void JKAPHGNOMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6050A00", Offset = "0x604FE00", VA = "0x186050A00", Slot = "6")]
	public Task AMCMMAEGFNK(long GEHPPAAKCLF, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6051010", Offset = "0x6050410", VA = "0x186051010", Slot = "14")]
	public float GIBNMALDPGA(string MIMFBLPNKOG, float IEKAHKGFLJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6051360", Offset = "0x6050760", VA = "0x186051360", Slot = "13")]
	public void KLFAIMAEEDO(string MIMFBLPNKOG, bool NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6050CD0", Offset = "0x60500D0", VA = "0x186050CD0", Slot = "12")]
	public bool DALMPAODNLF(string MIMFBLPNKOG, bool IEKAHKGFLJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x60513D0", Offset = "0x60507D0", VA = "0x1860513D0", Slot = "10")]
	public int KPMFIHDNFCI(string MIMFBLPNKOG, int IEKAHKGFLJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x60510F0", Offset = "0x60504F0", VA = "0x1860510F0", Slot = "18")]
	public DateTime ILCEHAMNHJC(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6051280", Offset = "0x6050680", VA = "0x186051280", Slot = "19")]
	public void JOKLBBFDPPF(string MIMFBLPNKOG, DateTime NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6051080", Offset = "0x6050480", VA = "0x186051080", Slot = "15")]
	public void IJBKNBOJMNO(string MIMFBLPNKOG, float NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6051160", Offset = "0x6050560", VA = "0x186051160", Slot = "11")]
	public void IOGEOPEGCFB(string MIMFBLPNKOG, int NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6050B30", Offset = "0x604FF30", VA = "0x186050B30", Slot = "20")]
	public long BFMFDOELOPE(string JJOBNGACPHH, long IEKAHKGFLJB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6050BA0", Offset = "0x604FFA0", VA = "0x186050BA0", Slot = "21")]
	public void BKNNMLCMOGA(string JJOBNGACPHH, long NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22BB140", Offset = "0x22BA540", VA = "0x1822BB140", Slot = "22")]
	public T PGCJDGAFNOO<T>(string JJOBNGACPHH, T IEKAHKGFLJB, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22BB0A0", Offset = "0x22BA4A0", VA = "0x1822BB0A0", Slot = "23")]
	public void NLMIJFOAMGA<T>(string JJOBNGACPHH, T NMENOOMOOJP, KKPFKAMFHMP<T> MBLEBLCCBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x60511D0", Offset = "0x60505D0", VA = "0x1860511D0", Slot = "16")]
	public string JKACOHPGJEJ(string MIMFBLPNKOG, string IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6050A90", Offset = "0x604FE90", VA = "0x186050A90", Slot = "17")]
	public void AMHBBCEGELK(string MIMFBLPNKOG, string NMENOOMOOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6050C10", Offset = "0x6050010", VA = "0x186050C10", Slot = "24")]
	public void BPAAMDJEAFO(string MIMFBLPNKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6050970", Offset = "0x604FD70", VA = "0x186050970", Slot = "9")]
	public bool AHFGLDFNFOK(string MIMFBLPNKOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6050DA0", Offset = "0x60501A0", VA = "0x186050DA0", Slot = "25")]
	public Task EIEFGPDDGIP(CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x260E580", Offset = "0x260D980", VA = "0x18260E580")]
	private T EHGHEBAOCHM<T>(string JJOBNGACPHH, T IEKAHKGFLJB, [Optional] KKPFKAMFHMP<T> DDLACINCNAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x260F6D0", Offset = "0x260EAD0", VA = "0x18260F6D0")]
	private void HPDCNGOHBJP<T>(string JJOBNGACPHH, T NMENOOMOOJP, [Optional] KKPFKAMFHMP<T> DDLACINCNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6051480", Offset = "0x6050880", VA = "0x186051480")]
	private Dictionary<string, string> NIGPJHOBCGL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OFEIPEOOHLH
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action AAHDMKMOCNM;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKAPHGNOMCA();

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FMHNAJGGKAD(long GEHPPAAKCLF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KAOCJKBGCHM(LPKNHOENMHH HOAHEDCAODA = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OFHDHELBJJJ(string JJOBNGACPHH, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GDDHDFAEEOG(string JJOBNGACPHH, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string KPGDHPMMGAJ(string JJOBNGACPHH, [Optional] string IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DPMBKLMPHDM NCGHJMEHFKE(string JJOBNGACPHH, string NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int CHOKLDCAIMI(string JJOBNGACPHH, int IEKAHKGFLJB = 0, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DPMBKLMPHDM NLHEJAFFINM(string JJOBNGACPHH, int NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LFHBILDIIDI(string JJOBNGACPHH, bool IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DPMBKLMPHDM EAJFOEOGNIP(string JJOBNGACPHH, bool NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float IBJJHKJJNNF(string JJOBNGACPHH, float IEKAHKGFLJB = 0f, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DPMBKLMPHDM OGEAONCBGLO(string JJOBNGACPHH, float NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime DIFNEGGLPDB(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DPMBKLMPHDM CLABDKFNGDJ(string JJOBNGACPHH, DateTime NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long PEEILOLPKFC(string JJOBNGACPHH, long IEKAHKGFLJB = 0L, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DPMBKLMPHDM HEADDELCKKC(string JJOBNGACPHH, long NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T HKLABLOLBLH<T>(string JJOBNGACPHH, [Optional] T IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DPMBKLMPHDM AJJMLONPIFC<T>(string JJOBNGACPHH, T NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool MHICIKJLKJJ(string JJOBNGACPHH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool FEELCKKAEDI(string JJOBNGACPHH);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string AJOEAOOGGOE(string JJOBNGACPHH, [Optional] string IEKAHKGFLJB);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DPMBKLMPHDM KDEAMGJHJJA(string JJOBNGACPHH, string NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int HNILGJHNMPF(string JJOBNGACPHH, int IEKAHKGFLJB = 0);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DPMBKLMPHDM GFJCEPJKFFM(string JJOBNGACPHH, int NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CMEOBFDCKJJ(string JJOBNGACPHH, bool IEKAHKGFLJB);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "28")]
	DPMBKLMPHDM HPDLCCMJHHL(string JJOBNGACPHH, bool NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float BILPKGKEFNA(string JJOBNGACPHH, float IEKAHKGFLJB = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	DPMBKLMPHDM LOIDOPMIEKL(string JJOBNGACPHH, float NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime HMLDOBPEFAE(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "32")]
	DPMBKLMPHDM EOGHDOKCCPH(string JJOBNGACPHH, DateTime NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long ACOFLBOPLJB(string JJOBNGACPHH, long IEKAHKGFLJB = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "34")]
	DPMBKLMPHDM AKNNBOPLLBK(string JJOBNGACPHH, long NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void EFEJJFBMGOI<T>(KKPFKAMFHMP<T> MBLEBLCCBLO, [Optional] IEqualityComparer<T> CIFLAHPMLGH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void FGMPHJGPJMJ<T>();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable EHJNCOJKHHL();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void JPNKFGCPMME(float IODAOFLOKJG);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task CMOLHPLCGBN([Optional] CancellationToken EANFAKGANNH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum DPMBKLMPHDM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CFDLBGKDCFB : OFEIPEOOHLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class BCOPIBODEGL
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		protected static readonly HashSet<BCOPIBODEGL> PGIBELDKDKJ;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x604ABC0", Offset = "0x6049FC0", VA = "0x18604ABC0")]
		public static void FLCGACKLJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void ILNOFIHDCKG();

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		protected BCOPIBODEGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class DPOPIEJPKFE<T> : BCOPIBODEGL
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly DPOPIEJPKFE<T> NMGLFNHIICP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public KKPFKAMFHMP<T> KOGIPPLBONI
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7738B0", Offset = "0x772CB0", VA = "0x1807738B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x773880", Offset = "0x772C80", VA = "0x180773880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IEqualityComparer<T> GDDJKNPKJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x773840", Offset = "0x772C40", VA = "0x180773840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FNPALEEBJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x30E1260", Offset = "0x30E0660", VA = "0x1830E1260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4DED7A0", Offset = "0x4DECBA0", VA = "0x184DED7A0")]
		private DPOPIEJPKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4DED0D0", Offset = "0x4DEC4D0", VA = "0x184DED0D0")]
		public void CNJGKMHEDKP(KKPFKAMFHMP<T> DDLACINCNAH, [Optional] IEqualityComparer<T> CIFLAHPMLGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4DED520", Offset = "0x4DEC920", VA = "0x184DED520", Slot = "4")]
		public override void ILNOFIHDCKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class ANGPONBLDHA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly CFDLBGKDCFB EAJJNAFLPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly object MLNKEHIKKIG;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6048F20", Offset = "0x6048320", VA = "0x186048F20")]
		public ANGPONBLDHA(CFDLBGKDCFB EAJJNAFLPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6048EF0", Offset = "0x60482F0", VA = "0x186048EF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct JKGFKBEIOAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CFDLBGKDCFB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x604FFA0", Offset = "0x604F3A0", VA = "0x18604FFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6050280", Offset = "0x604F680", VA = "0x186050280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private struct NGCEFFNIFIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public CFDLBGKDCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BLHCHMNCMBD backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6051780", Offset = "0x6050B80", VA = "0x186051780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7F66E0", Offset = "0x7F5AE0", VA = "0x1807F66E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct LBHMKJLHOHN : IAsyncStateMachine
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
		public CFDLBGKDCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x60502E0", Offset = "0x604F6E0", VA = "0x1860502E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x60507B0", Offset = "0x604FBB0", VA = "0x1860507B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ACOBOLKNMDG : IEnumerator<EIIEDLICJGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private EIIEDLICJGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CFDLBGKDCFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float seconds;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private EIIEDLICJGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x77C2A0", Offset = "0x77B6A0", VA = "0x18077C2A0")]
		[DebuggerHidden]
		public ACOBOLKNMDG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x772DB0", Offset = "0x7721B0", VA = "0x180772DB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6047C90", Offset = "0x6047090", VA = "0x186047C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6047D20", Offset = "0x6047120", VA = "0x186047D20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly NGOIOCEKMBE NNDKNLKIBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly NGOIOCEKMBE MJNEGGMHGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly BDKMPJKCKNJ CAKKABDFNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly DAHKGHMHLKA FDOFKCPCEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EFHEONJKJKH LBGNAGNDOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly HashSet<BLHCHMNCMBD> INENHJJHMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private Task HLCPOGOAADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BDOFDMHMNPK LHNHNEEMOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly object JPCIAILFFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly object GMFJFALGCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private long GBFGDDKMJCC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private bool BDIJPJBJGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xC241E0", Offset = "0xC235E0", VA = "0x180C241E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private CancellationTokenSource DKNHHNJANEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x770B10", Offset = "0x76FF10", VA = "0x180770B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x770CF0", Offset = "0x7700F0", VA = "0x180770CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action AAHDMKMOCNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x604B4B0", Offset = "0x604A8B0", VA = "0x18604B4B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x604E4C0", Offset = "0x604D8C0", VA = "0x18604E4C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x604E560", Offset = "0x604D960", VA = "0x18604E560")]
	[JMGGEKJCAGA(PLCOHLLKCIG.None)]
	private static void OODFKLIGDLO(DIBCBJLEDOH KIMBONFFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x604E790", Offset = "0x604DB90", VA = "0x18604E790")]
	[Preserve]
	public CFDLBGKDCFB([MJHHGJKKIMK("Disk")] NGOIOCEKMBE NNDKNLKIBJI, [MJHHGJKKIMK("Cloud")] NGOIOCEKMBE MJNEGGMHGLB, [MJHHGJKKIMK(null)] BDKMPJKCKNJ CAKKABDFNLI, [MJHHGJKKIMK(null)] DAHKGHMHLKA FDOFKCPCEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x604B6B0", Offset = "0x604AAB0", VA = "0x18604B6B0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E65C30", Offset = "0x5E65030", VA = "0x185E65C30")]
	private void PHHCOCKGLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x604D030", Offset = "0x604C430", VA = "0x18604D030", Slot = "6")]
	public void JKAPHGNOMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x604C040", Offset = "0x604B440", VA = "0x18604C040", Slot = "7")]
	public Task FMHNAJGGKAD(long GEHPPAAKCLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x604DEE0", Offset = "0x604D2E0", VA = "0x18604DEE0")]
	[AsyncStateMachine(typeof(JKGFKBEIOAM))]
	private Task OFEPBMEAECN(long GEHPPAAKCLF, CancellationToken EANFAKGANNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1626DA0", Offset = "0x16261A0", VA = "0x181626DA0")]
	private void MFDACKAFKME(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x604C7A0", Offset = "0x604BBA0", VA = "0x18604C7A0")]
	private void GJCLMHFECBJ(object NOEAHPPKHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x604D230", Offset = "0x604C630", VA = "0x18604D230")]
	private string KNNHNDKKNLD(string GAGCMCLOJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x604E3C0", Offset = "0x604D7C0", VA = "0x18604E3C0")]
	private void OJBDKGCOILD(LPKNHOENMHH HOAHEDCAODA, string MIMFBLPNKOG, [Out] NGOIOCEKMBE GMDHDDHHENE, [Out] string HDFLAAGEBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x604D580", Offset = "0x604C980", VA = "0x18604D580")]
	private NGOIOCEKMBE MAJGIOMFGMG(LPKNHOENMHH HOAHEDCAODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x604D0B0", Offset = "0x604C4B0", VA = "0x18604D0B0", Slot = "8")]
	public bool KAOCJKBGCHM(LPKNHOENMHH HOAHEDCAODA = LPKNHOENMHH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x604DFF0", Offset = "0x604D3F0", VA = "0x18604DFF0", Slot = "9")]
	public bool OFHDHELBJJJ(string JJOBNGACPHH, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x604C1F0", Offset = "0x604B5F0", VA = "0x18604C1F0", Slot = "10")]
	public bool GDDHDFAEEOG(string JJOBNGACPHH, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x604D290", Offset = "0x604C690", VA = "0x18604D290", Slot = "11")]
	public string KPGDHPMMGAJ(string JJOBNGACPHH, [Optional] string IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x604D660", Offset = "0x604CA60", VA = "0x18604D660", Slot = "12")]
	public DPMBKLMPHDM NCGHJMEHFKE(string JJOBNGACPHH, string NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x604AF40", Offset = "0x604A340", VA = "0x18604AF40", Slot = "13")]
	public int CHOKLDCAIMI(string JJOBNGACPHH, int IEKAHKGFLJB = 0, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x604D8E0", Offset = "0x604CCE0", VA = "0x18604D8E0", Slot = "14")]
	public DPMBKLMPHDM NLHEJAFFINM(string JJOBNGACPHH, int NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x604D3F0", Offset = "0x604C7F0", VA = "0x18604D3F0", Slot = "15")]
	public bool LFHBILDIIDI(string JJOBNGACPHH, bool IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x604B6F0", Offset = "0x604AAF0", VA = "0x18604B6F0", Slot = "16")]
	public DPMBKLMPHDM EAJFOEOGNIP(string JJOBNGACPHH, bool NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x604CD40", Offset = "0x604C140", VA = "0x18604CD40", Slot = "17")]
	public float IBJJHKJJNNF(string JJOBNGACPHH, float IEKAHKGFLJB = 0f, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x604E140", Offset = "0x604D540", VA = "0x18604E140", Slot = "18")]
	public DPMBKLMPHDM OGEAONCBGLO(string JJOBNGACPHH, float NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x604B550", Offset = "0x604A950", VA = "0x18604B550", Slot = "19")]
	public DateTime DIFNEGGLPDB(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x604B0A0", Offset = "0x604A4A0", VA = "0x18604B0A0", Slot = "20")]
	public DPMBKLMPHDM CLABDKFNGDJ(string JJOBNGACPHH, DateTime NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x604E5D0", Offset = "0x604D9D0", VA = "0x18604E5D0", Slot = "21")]
	public long PEEILOLPKFC(string JJOBNGACPHH, long IEKAHKGFLJB = 0L, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x604C9C0", Offset = "0x604BDC0", VA = "0x18604C9C0", Slot = "22")]
	public DPMBKLMPHDM HEADDELCKKC(string JJOBNGACPHH, long NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2338BF0", Offset = "0x2337FF0", VA = "0x182338BF0", Slot = "23")]
	public T HKLABLOLBLH<T>(string JJOBNGACPHH, [Optional] T IEKAHKGFLJB, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2338BF0", Offset = "0x2337FF0", VA = "0x182338BF0", Slot = "24")]
	public DPMBKLMPHDM AJJMLONPIFC<T>(string JJOBNGACPHH, T NMENOOMOOJP, LPKNHOENMHH NIPMANMMHND = LPKNHOENMHH.CLOUD)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x604D600", Offset = "0x604CA00", VA = "0x18604D600", Slot = "25")]
	public bool MHICIKJLKJJ(string JJOBNGACPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x604BD00", Offset = "0x604B100", VA = "0x18604BD00", Slot = "26")]
	public bool FEELCKKAEDI(string JJOBNGACPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x604AE00", Offset = "0x604A200", VA = "0x18604AE00", Slot = "27")]
	public string AJOEAOOGGOE(string JJOBNGACPHH, [Optional] string IEKAHKGFLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x604D170", Offset = "0x604C570", VA = "0x18604D170", Slot = "28")]
	public DPMBKLMPHDM KDEAMGJHJJA(string JJOBNGACPHH, string NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x604CCA0", Offset = "0x604C0A0", VA = "0x18604CCA0", Slot = "29")]
	public int HNILGJHNMPF(string JJOBNGACPHH, int IEKAHKGFLJB = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x604C3F0", Offset = "0x604B7F0", VA = "0x18604C3F0", Slot = "30")]
	public DPMBKLMPHDM GFJCEPJKFFM(string JJOBNGACPHH, int NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x604B350", Offset = "0x604A750", VA = "0x18604B350", Slot = "31")]
	public bool CMEOBFDCKJJ(string JJOBNGACPHH, bool IEKAHKGFLJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x604CD10", Offset = "0x604C110", VA = "0x18604CD10", Slot = "32")]
	public DPMBKLMPHDM HPDLCCMJHHL(string JJOBNGACPHH, bool NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x604AED0", Offset = "0x604A2D0", VA = "0x18604AED0", Slot = "33")]
	public float BILPKGKEFNA(string JJOBNGACPHH, float IEKAHKGFLJB = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x604D550", Offset = "0x604C950", VA = "0x18604D550", Slot = "34")]
	public DPMBKLMPHDM LOIDOPMIEKL(string JJOBNGACPHH, float NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x604CC30", Offset = "0x604C030", VA = "0x18604CC30", Slot = "35")]
	public DateTime HMLDOBPEFAE(string JJOBNGACPHH, [Optional] DateTime IEKAHKGFLJB)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x604BB10", Offset = "0x604AF10", VA = "0x18604BB10", Slot = "36")]
	public DPMBKLMPHDM EOGHDOKCCPH(string JJOBNGACPHH, DateTime NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x604AD90", Offset = "0x604A190", VA = "0x18604AD90", Slot = "37")]
	public long ACOFLBOPLJB(string JJOBNGACPHH, long IEKAHKGFLJB = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x604AE70", Offset = "0x604A270", VA = "0x18604AE70", Slot = "38")]
	public DPMBKLMPHDM AKNNBOPLLBK(string JJOBNGACPHH, long NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x604E730", Offset = "0x604DB30", VA = "0x18604E730")]
	private bool PFJCGHBFELA(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x604DDD0", Offset = "0x604D1D0", VA = "0x18604DDD0")]
	private bool NPGKLOJPMKC(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x604C820", Offset = "0x604BC20", VA = "0x18604C820")]
	private DPMBKLMPHDM GKEPMEBEKFC(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, string NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x604BD10", Offset = "0x604B110", VA = "0x18604BD10")]
	private DPMBKLMPHDM FJLFDMNGGNG(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, int NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x604BEA0", Offset = "0x604B2A0", VA = "0x18604BEA0")]
	private DPMBKLMPHDM FKLBDINPPLN(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, bool NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x604C600", Offset = "0x604BA00", VA = "0x18604C600")]
	private DPMBKLMPHDM GIDBAPCKFAL(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, float NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x604BB40", Offset = "0x604AF40", VA = "0x18604BB40")]
	private DPMBKLMPHDM EPKHFKEOMBD(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, DateTime NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x604CEA0", Offset = "0x604C2A0", VA = "0x18604CEA0")]
	private DPMBKLMPHDM IFBIIEBGGHP(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, long NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x23399D0", Offset = "0x2338DD0", VA = "0x1823399D0")]
	private T FMCECDGADDO<T>(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, T IEKAHKGFLJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2338D90", Offset = "0x2338190", VA = "0x182338D90")]
	private DPMBKLMPHDM DCCADLENBEB<T>(BLHCHMNCMBD GMDHDDHHENE, string JJOBNGACPHH, T NMENOOMOOJP)
	{
		return default(DPMBKLMPHDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x23398B0", Offset = "0x2338CB0", VA = "0x1823398B0", Slot = "39")]
	public void EFEJJFBMGOI<T>(KKPFKAMFHMP<T> MBLEBLCCBLO, [Optional] IEqualityComparer<T> CIFLAHPMLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2339950", Offset = "0x2338D50", VA = "0x182339950", Slot = "40")]
	public void FGMPHJGPJMJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x604BA40", Offset = "0x604AE40", VA = "0x18604BA40")]
	[AsyncStateMachine(typeof(NGCEFFNIFIK))]
	private void EIEFGPDDGIP(BLHCHMNCMBD DAHJOGENCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x604B3C0", Offset = "0x604A7C0", VA = "0x18604B3C0", Slot = "43")]
	[AsyncStateMachine(typeof(LBHMKJLHOHN))]
	public Task CMOLHPLCGBN([Optional] CancellationToken NOEAHPPKHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x604C420", Offset = "0x604B820", VA = "0x18604C420")]
	private void GGCLPODLACJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x604B960", Offset = "0x604AD60", VA = "0x18604B960", Slot = "41")]
	public IDisposable EHJNCOJKHHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x604D0A0", Offset = "0x604C4A0", VA = "0x18604D0A0", Slot = "42")]
	public void JPNKFGCPMME(float IODAOFLOKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x604DB50", Offset = "0x604CF50", VA = "0x18604DB50")]
	private void NLMEDJPPBEE(float GFMPABMAPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x604D1A0", Offset = "0x604C5A0", VA = "0x18604D1A0")]
	[IteratorStateMachine(typeof(ACOBOLKNMDG))]
	private IEnumerator<EIIEDLICJGP> KLLEKPNOEHE(float IODAOFLOKJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x604AEA0", Offset = "0x604A2A0", VA = "0x18604AEA0")]
	[CompilerGenerated]
	private void ANJDDKJIBDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FJLAAOOFDCN : FIIPPEBMGAN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static FJLAAOOFDCN NMGLFNHIICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x604EF10", Offset = "0x604E310", VA = "0x18604EF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x604EE20", Offset = "0x604E220", VA = "0x18604EE20", Slot = "9")]
	public override string ALIOEPOJFBC(bool CGOLCEEBMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x604EF60", Offset = "0x604E360", VA = "0x18604EF60", Slot = "10")]
	protected override bool OMFCGOMFFKI(string CGOLCEEBMBE, [Out] bool NMENOOMOOJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x604F280", Offset = "0x604E680", VA = "0x18604F280")]
	public FJLAAOOFDCN()
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
