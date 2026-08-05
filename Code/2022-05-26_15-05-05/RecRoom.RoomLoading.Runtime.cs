using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Mono.Math;
using RecNet;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GBBCANCMAJL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x20CBE00", Offset = "0x20CA400", VA = "0x1820CBE00")]
	public GBBCANCMAJL(string EPAKPJCIEHE, Exception AIBMBKKNCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal interface NPJGAJPPJEI : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GFBLLLADAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Task MOANFHAHKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLCIPHEDJLP(Task IPFPIIBOBLL, string NIADDLHGAIA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
internal interface LIFHAIMINNH : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ENHMJOINGNL(EDJOLKBGGON MEHKPGNHAPF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AKILKIIJDDF(CancellationToken CMOIBOJIACL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface LAPDICFBJJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HACKFAEPMNM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ALDIJJBBMNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly long HAJLCMLFPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly long KAMCIMPLACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly HACKFAEPMNM ONIHNDBDHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CanBeNull]
	public readonly Exception IPILGHMCFDA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x20C1660", Offset = "0x20BFC60", VA = "0x1820C1660")]
	public ALDIJJBBMNI(long HAJLCMLFPLL, long KAMCIMPLACP, HACKFAEPMNM ONIHNDBDHGC, [CanBeNull] Exception IPILGHMCFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x20C1610", Offset = "0x20BFC10", VA = "0x1820C1610")]
	public static ALDIJJBBMNI BIOJJPJDKDG(EMBFCHHFKKK MGHCGJAEODN, HACKFAEPMNM ONIHNDBDHGC, [Optional] Exception IPILGHMCFDA)
	{
		return default(ALDIJJBBMNI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void HAFEEJEPELG(ALDIJJBBMNI GMPOPNLDAJA);
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal interface MFHHFAHNJGL : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event HAFEEJEPELG GBEJAPJDDJP;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event HAFEEJEPELG FIDNPAPGOHF;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event HAFEEJEPELG BBILPJBFLPD;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CIPPHAHCMFK(ALDIJJBBMNI GMPOPNLDAJA);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PEKFJDANINA(ALDIJJBBMNI GMPOPNLDAJA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GMBAINFHMGA(ALDIJJBBMNI GMPOPNLDAJA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface BLFGHLPNEHN : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BLBNENCAACM();

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENEBMMKBJFD();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDPMPAFGPGL();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public delegate Task PGGKPPEPLGO(NFJKCBJFLIE EIGJMLMDBAJ, CancellationToken GJGFJFLAGKH);
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal interface NCGJFCNJIOO : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EGMIMPEGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FHNEBLNKNIP(PGGKPPEPLGO INLCLHGCMGC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
internal interface BKIMFDNILBI : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	TaskStatus ICOLJNBCLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task KICAFMGAABI(EMBFCHHFKKK EHDMDEMFAJN, CancellationToken OLMBFPIKDDC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal static class CBKPAOAADOH
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x20C44E0", Offset = "0x20C2AE0", VA = "0x1820C44E0")]
	public static bool MEDOKMLJIOI(this BKIMFDNILBI JFAPPEGPHAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal interface LBAEOCOFFMH : PILDIBIHHII, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CancellationToken JBCLFJCDGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JIFIKNLDFOJ EFAGOGEKHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DENAOPKHIGA MANIDLGMOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MJPGKFDMANL KJKCJFAAGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	CBAJIIEHOBG INKCCOACKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EMGABENEFNH AMMBAJNEPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HLGNNAIFBEA MFNAOAOBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NPJGAJPPJEI DDBJJOBAOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	LIFHAIMINNH POAJDOKMEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MFHHFAHNJGL AKLBBFMCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BLFGHLPNEHN EBABCHCAFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BKIMFDNILBI CDAIJEDBDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NCGJFCNJIOO HIKMAIJFPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FHHJEOGCIEI NEFEJEACJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	FNJCMPBFKHJ FEADKHJPKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MCFLBONNLLI IMKPKINPCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HAEINGHCIEB BJOAPGHAPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	BMPPJIOEELE AKAGLGAOCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KADLIJAOKIC KAJMBPPJNEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	EFOEHPJHIKG APPOLHHNOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GDFPLOEAABF HFGFGNMKBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	DBGDBPBOCKE HJPDNDOBPHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CMEOIBGNCED IEPBKBEADEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FIPHIHKIFBP JLEMJCEPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal interface FHHJEOGCIEI : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLBKKFPNIJF NENJMCKJAJO(Guid KOKPBCLAFDC);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MNHCGCIEOKP(Guid KOKPBCLAFDC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PAPLHFGBIMN(Guid KOKPBCLAFDC, Task NHJCMHGLOGA);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ICNHOIFNPIG(Guid KOKPBCLAFDC, CPPGHHPEEKN COPJHDMPIOB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DDPMPAFGPGL(Guid KOKPBCLAFDC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<(CPPGHHPEEKN, Task)> DKEEFEBEBKG(Guid KOKPBCLAFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal interface FNJCMPBFKHJ : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLBNENCAACM();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal interface MCFLBONNLLI : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPJOBLBOJCG(MGIOABMEIJD EPAKPJCIEHE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOJCMDNGGJA(MGIOABMEIJD EPAKPJCIEHE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LKDPLNJNDNN> LGEPHEMPADI(CancellationToken HENDNIHFHDD);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate CPPGHHPEEKN DLJBOKNHBGA(BMNAGFLMHFA ODCEJMGDBOO, LKDPLNJNDNN KAOJFOHCDAO);
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal interface HAEINGHCIEB : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLBKKFPNIJF HIJEFAEPJIF(EENOJINADGG HDEBKIPOGJE);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OOEHPONBFPE(Guid KOKPBCLAFDC, Task NHJCMHGLOGA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal interface BMPPJIOEELE : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CPPGHHPEEKN> AKAGLGAOCIC(BMNAGFLMHFA JLDONLICNFI, LKDPLNJNDNN CLFEHPMJEFA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal interface KADLIJAOKIC : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCKBMPBIFMP> PKEFCDCKNPJ(GGNPNKPNBJP NFIEDJENJOM, EMBFCHHFKKK EHDMDEMFAJN, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCKBMPBIFMP JJKEHKDMJOC(MFFPLJBNNEB MCKCLGMKBJN, long FDEIGEELENF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface GDFPLOEAABF : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPPGHHPEEKN LNGGKAEPACM(BMNAGFLMHFA ODCEJMGDBOO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NPKNJNNANMG(string IOMEMFDDFKN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface EFOEHPJHIKG : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPCBEJLMGEM();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFEMDFDACGO();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MGIOABMEIJD> MACCGALLMBN(MGIOABMEIJD DMFHFDFMIOL, EGHNIDJHOFI APNFPOCHBNH, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<MGIOABMEIJD> NGMAIHDJAEM(CancellationToken CMOIBOJIACL, EGHNIDJHOFI APNFPOCHBNH);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GGNPNKPNBJP OHGCPADNCGF(CHMPEANIDIP LFHIBEECFAH, BJHOOGFBDGF OADNBMGMCGO);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GGNPNKPNBJP INCDKAONCCM(CHMPEANIDIP LFHIBEECFAH, BJHOOGFBDGF OADNBMGMCGO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface DBGDBPBOCKE : LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPPGHHPEEKN POEGNACDNEF(BMNAGFLMHFA ODCEJMGDBOO, LKDPLNJNDNN KAOJFOHCDAO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CPPGHHPEEKN PJMODPBBIMD(BMNAGFLMHFA IJJLOMGHHAC);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CPPGHHPEEKN PIADHEJPLGD(BMNAGFLMHFA IJJLOMGHHAC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CMEOIBGNCED
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNLOGGOMEKD(JGLIFMEIBOB HELIHCFBIEE);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHGKGNDOCKA(JGLIFMEIBOB HELIHCFBIEE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNGJFEAJNOA(JGLIFMEIBOB HELIHCFBIEE);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IHEIIANEMIF(JGLIFMEIBOB HELIHCFBIEE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JGLIFMEIBOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly EMBFCHHFKKK NLMEDAIIKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Dictionary<string, string> NDPGAHKFEGJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BJHOOGFBDGF EDLAIOGHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x58AD70", Offset = "0x589370", VA = "0x18058AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
	public JGLIFMEIBOB(EMBFCHHFKKK DOPDFGFALCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2025FB0", Offset = "0x20245B0", VA = "0x182025FB0")]
	public JGLIFMEIBOB FBBJPKOAKPO(string MKDJIBNCKNC, string MPHFKGJNMOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2025F10", Offset = "0x2024510", VA = "0x182025F10")]
	public bool BIJEMFIKPGO(out IEnumerable<KeyValuePair<string, string>> FIMEBGCBCFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2025F90", Offset = "0x2024590", VA = "0x182025F90")]
	public JGLIFMEIBOB DMCEEDNCBIC(BJHOOGFBDGF NJKJIAHPBGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PILDIBIHHII : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MEDOKMLJIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MFPDOCAPICE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event HAFEEJEPELG GBEJAPJDDJP;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event HAFEEJEPELG FIDNPAPGOHF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event HAFEEJEPELG BBILPJBFLPD;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ENEBMMKBJFD();

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<CPPGHHPEEKN> NJAEFKLODDK();

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<CPPGHHPEEKN> ABANPEMDJGP(BMNAGFLMHFA OFLLOIKKLEO);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<CPPGHHPEEKN> BLOGHKGCPAP(int IELGLAPLPOC);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task NPKNJNNANMG(string IOMEMFDDFKN);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task ENHMJOINGNL(EDJOLKBGGON MEHKPGNHAPF = EDJOLKBGGON.Incremental);

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task AKILKIIJDDF(CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ANAMNCMBLFI(long FDEIGEELENF);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool BBHFGNOFBHK(long FDEIGEELENF, out DateTime EPHBJLEONLM);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface FNMMNHKHMCA
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	int NECKLMHDHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool OGPLFKANKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MEMJKJFBBOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GJJHGCEMHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool PJOHBKJKFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool PJMLCAEALFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LKCNONIKLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool AJKFNJNMONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MLEFODGAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BMNAGFLMHFA CAFOLMBDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJANJHBNIOE(JIFIKNLDFOJ CDKHPKCDPCI);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task PJGJCHFFJDP(BJHOOGFBDGF OADNBMGMCGO, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task KHFDHEHCLPO(CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task JNGLKCCLLFH(KKDFFHJICII GJHPLFKILIN, [Optional] CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IReadOnlyList<OJPBNECMBED> GNIFJGIJFFK();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IDisposable MGOMLNAHJCG(object GCLGODGIPBD, OJPBNECMBED BPDKNEKOMHG);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DBJMJBCMFPH();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DGBJBAFBGLE FPIHFKDJOLC();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CPAPOJCCPJA(int CLDEMIFMIBL);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task KCHFHBIDIKH();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JGOGIFLAEJL();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "20")]
	bool BNKGADLEKJB();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task LHKGCHIFJME(CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task HJNDLLHPPAH(CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<bool> OFHAIMNBNAE(DateTime ABOGIJBOKHN, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<bool> BFCGNFGADIO(CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HHDILNCMJHD();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DBGNDBIILCO OPLLPPPLCBD(OHAJFKMLEIK MLIDLNJFJHE, BEIGNGGNNMG MGAPEIODPJA, IEnumerable<PersistenceView> PNEAOBABCPD, ref GHGNHBKLOMI MKEMEIPOIFL);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NPBMOOAENBN(JLFGDMMOIKO CPAFMGHNGGP, in DBGNDBIILCO GMLIFKLLKLO);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void APHNCGEJLCA(BEIGNGGNNMG DNJPHNDIFGE, bool OLKCIOCKFAK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OHHFPOIHNJE(long HEDMMBFEFLM, long KAMCIMPLACP, MFFPLJBNNEB DLHDHECGKLB, HEPPHFAIPIK KFNLLONIIMA);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void KCNNOGMFFEH(long HEDMMBFEFLM, long KAMCIMPLACP);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AMOHIIHDMEB(PersistenceView BKIPIGPHLOP);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool CNNCOGGEFGC(PersistenceView GPBCADGHJJP);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool MKLJGOGBOHI(JLFGDMMOIKO CPAFMGHNGGP, ECFNMJJJCGK GIEGDPNNMKD, Dictionary<int, int> PAIHELMGHLP, out NIPMODLHPEL BLGKGMPIGOO);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void FLFPLFNLIOC();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void NCKJEDIKCAB();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "36")]
	IDisposable BEPPAEAPFJP();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Dictionary<int, int> LFFOAHDLKDB(BEIGNGGNNMG DNJPHNDIFGE, ECFNMJJJCGK GIEGDPNNMKD);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task OGOOEPEKHAC(DENAOPKHIGA KKBKNLLLIDH, CancellationToken CMOIBOJIACL, BJHOOGFBDGF OADNBMGMCGO);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void IJJJMGPIPGF(CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<MFFPLJBNNEB> AKJOKOELOED(long HEDMMBFEFLM, long KAMCIMPLACP, string KKBODNOJIJD, string IGLCPKGFKHJ, Dictionary<long, int> KFOLIICJEEC, int AECIIDFCKEL);

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<MFFPLJBNNEB> JMFJCANCAJP(long HEDMMBFEFLM, bool GNPFONOAEGE, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool OCBCNGEFADC();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool GAHHICMOFAK();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "46")]
	GameObject[] LGCGLFIFKDG(OHLNKPALPLN[] KFNAJADHICA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void JAKKFFEGHEO(List<GameObject> FPPDICLFJCG);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float JBIPOJJFHND();

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task FEHLFEAHJAD(string NLEHPBOLMFJ, LoadSceneMode KLBOBKHAMPK, bool JBAGLFBFICM, BJHOOGFBDGF NJKJIAHPBGG);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void MJALINIPFIE(EMBFCHHFKKK HLFEGFDJPCM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NNOFPAKEGLP(string CLFEHPMJEFA, BMNAGFLMHFA JLDONLICNFI);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "52")]
	Task EAGJCHNHBJE(BJHOOGFBDGF OADNBMGMCGO, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "53")]
	Task FJJDLPDFMPK(BJHOOGFBDGF OADNBMGMCGO, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void EDFFJDPEOON();

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "55")]
	IDisposable ANILAAGMPII();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "56")]
	OBGPNEKGDBK KBECDFDFCFA();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface OBGPNEKGDBK
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BHFOMHFDKLN(CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OKGFHBILEMA(CancellationToken CMOIBOJIACL);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct DBGNDBIILCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public HashSet<int> OJFCHKLIGAI;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FHHFIGHJGFP
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	EMBFCHHFKKK DKOPHJLPBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	MFFPLJBNNEB OGFFGHPINBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DBPKBOFJDFM NNPPJCEFDBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool DGAHGAGPLLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool EPNCANBJPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int NECKLMHDHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action APPCOBCHHMF;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<int> CBEGOOOEIPF;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LAMEAMEBEIP();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.CDJMEKBODDJ> OIOLMKKCMDM();

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task HFFIPBNJOOC();

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EMBFCHHFKKK KJFKJGOCCHB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KPADKAHKOCL MEDCBGCNNOH();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EMJBHJOMEFG(long BGJCMABDLFA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FIPHIHKIFBP
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMLOAHMEEGG(out IEnumerable<int> PMBMBJOOCEB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIMMPOEKJAH(KCOJKHFGNGK GJGFJFLAGKH);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEMDJMDNNLJ(KCOJKHFGNGK GJGFJFLAGKH);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GLLCPBDFKCN
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string AHPKAFNKGJH(CPPGHHPEEKN CGGJNNGHPHA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal sealed class ABCIJEKFIDB : PILDIBIHHII, IDisposable, LBAEOCOFFMH
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MPMDNKBGEMC : IEnumerable<LAPDICFBJJO>, IEnumerable, IEnumerator<LAPDICFBJJO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LAPDICFBJJO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public ABCIJEKFIDB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private LAPDICFBJJO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6713E0", Offset = "0x66F9E0", VA = "0x1806713E0")]
		[DebuggerHidden]
		public MPMDNKBGEMC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x20D5AA0", Offset = "0x20D40A0", VA = "0x1820D5AA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x20D5EB0", Offset = "0x20D44B0", VA = "0x1820D5EB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x20D5E10", Offset = "0x20D4410", VA = "0x1820D5E10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LAPDICFBJJO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x20D5E10", Offset = "0x20D4410", VA = "0x1820D5E10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource HJFGMJGIJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly JIFIKNLDFOJ CDKHPKCDPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool ECMCAACONHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OPPGABOEPBM HGJGDENNICN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DENAOPKHIGA MANIDLGMOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B3130", Offset = "0x5B1730", VA = "0x1805B3130", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9F0", Offset = "0x5EBFF0", VA = "0x1805ED9F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MJPGKFDMANL KJKCJFAAGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x584720", Offset = "0x582D20", VA = "0x180584720", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5ED920", Offset = "0x5EBF20", VA = "0x1805ED920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x572220", Offset = "0x570820", VA = "0x180572220", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5FA370", Offset = "0x5F8970", VA = "0x1805FA370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CBAJIIEHOBG INKCCOACKDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x566630", Offset = "0x564C30", VA = "0x180566630", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x573EE0", Offset = "0x5724E0", VA = "0x180573EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EMGABENEFNH AMMBAJNEPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x566620", Offset = "0x564C20", VA = "0x180566620", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public HLGNNAIFBEA MFNAOAOBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x584660", Offset = "0x582C60", VA = "0x180584660", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x566640", Offset = "0x564C40", VA = "0x180566640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NPJGAJPPJEI DDBJJOBAOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x584670", Offset = "0x582C70", VA = "0x180584670", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x572250", Offset = "0x570850", VA = "0x180572250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public LIFHAIMINNH POAJDOKMEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x573EA0", Offset = "0x5724A0", VA = "0x180573EA0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x572230", Offset = "0x570830", VA = "0x180572230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MFHHFAHNJGL AKLBBFMCCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x59A080", Offset = "0x598680", VA = "0x18059A080", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7E0", Offset = "0x5F9DE0", VA = "0x1805FB7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public BLFGHLPNEHN EBABCHCAFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5B3140", Offset = "0x5B1740", VA = "0x1805B3140", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7849A0", Offset = "0x782FA0", VA = "0x1807849A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BKIMFDNILBI CDAIJEDBDCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C40", Offset = "0x5E8240", VA = "0x1805E9C40", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FAE10", Offset = "0x5F9410", VA = "0x1805FAE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NCGJFCNJIOO HIKMAIJFPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5846E0", Offset = "0x582CE0", VA = "0x1805846E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x572240", Offset = "0x570840", VA = "0x180572240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FHHJEOGCIEI NEFEJEACJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5846F0", Offset = "0x582CF0", VA = "0x1805846F0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x787EF0", Offset = "0x7864F0", VA = "0x180787EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public FNJCMPBFKHJ FEADKHJPKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x59A190", Offset = "0x598790", VA = "0x18059A190", Slot = "37")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB60", Offset = "0x5EC160", VA = "0x1805EDB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MCFLBONNLLI IMKPKINPCEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x584700", Offset = "0x582D00", VA = "0x180584700", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x572260", Offset = "0x570860", VA = "0x180572260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public HAEINGHCIEB BJOAPGHAPNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E98F0", Offset = "0x5E7EF0", VA = "0x1805E98F0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EBC50", Offset = "0x5EA250", VA = "0x1805EBC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BMPPJIOEELE AKAGLGAOCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EBAA0", Offset = "0x5EA0A0", VA = "0x1805EBAA0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EA7C0", VA = "0x1805EC1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public KADLIJAOKIC KAJMBPPJNEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5EBAB0", Offset = "0x5EA0B0", VA = "0x1805EBAB0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5ED980", Offset = "0x5EBF80", VA = "0x1805ED980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public EFOEHPJHIKG APPOLHHNOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5EBB50", Offset = "0x5EA150", VA = "0x1805EBB50", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5EBC70", Offset = "0x5EA270", VA = "0x1805EBC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GDFPLOEAABF HFGFGNMKBMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5B10B0", Offset = "0x5AF6B0", VA = "0x1805B10B0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x787800", Offset = "0x785E00", VA = "0x180787800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public DBGDBPBOCKE HJPDNDOBPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8B0", Offset = "0x5EAEB0", VA = "0x1805EC8B0", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB50", Offset = "0x5EB150", VA = "0x1805ECB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public CMEOIBGNCED IEPBKBEADEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5EC890", Offset = "0x5EAE90", VA = "0x1805EC890", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB30", Offset = "0x5EB130", VA = "0x1805ECB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FIPHIHKIFBP JLEMJCEPCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8A0", Offset = "0x5EAEA0", VA = "0x1805EC8A0", Slot = "46")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB40", Offset = "0x5EB140", VA = "0x1805ECB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private bool KEGINBIFFFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x20BFD00", Offset = "0x20BE300", VA = "0x1820BFD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private bool HHLPAEOIIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x20BF330", Offset = "0x20BD930", VA = "0x1820BF330", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private CancellationToken CEHNPBMNNCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x20BF6A0", Offset = "0x20BDCA0", VA = "0x1820BF6A0", Slot = "22")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private JIFIKNLDFOJ KIMNNJDPBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	private event HAFEEJEPELG KDIHCGOEJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x20BF3A0", Offset = "0x20BD9A0", VA = "0x1820BF3A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x20BF7B0", Offset = "0x20BDDB0", VA = "0x1820BF7B0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	private event HAFEEJEPELG EDFLAINDLLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x20BF810", Offset = "0x20BDE10", VA = "0x1820BF810", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x20BFD50", Offset = "0x20BE350", VA = "0x1820BFD50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	private event HAFEEJEPELG HMIOKOLEGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x20BF750", Offset = "0x20BDD50", VA = "0x1820BF750", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x20BFDD0", Offset = "0x20BE3D0", VA = "0x1820BFDD0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x20BFE30", Offset = "0x20BE430", VA = "0x1820BFE30")]
	[Preserve]
	internal ABCIJEKFIDB([IOLMGJIHJFK(null)] JIFIKNLDFOJ CDKHPKCDPCI, [IOLMGJIHJFK(null)] DENAOPKHIGA KKBKNLLLIDH, [IOLMGJIHJFK(null)] MJPGKFDMANL CELMJJPEKAE, [IOLMGJIHJFK(null)] FNMMNHKHMCA PJEAKFPHIGK, [IOLMGJIHJFK(null)] CBAJIIEHOBG IGLLIMKPDLG, [IOLMGJIHJFK(null)] EMGABENEFNH GFPCCCLEKCL, [IOLMGJIHJFK(null)] HLGNNAIFBEA BGONODDGIME, [IOLMGJIHJFK(null)] NPJGAJPPJEI EMLBOAGIGLO, [IOLMGJIHJFK(null)] LIFHAIMINNH CKPAOBHJBMC, [IOLMGJIHJFK(null)] MFHHFAHNJGL JDIKOPFEMKI, [IOLMGJIHJFK(null)] BLFGHLPNEHN AIMKCJLJABH, [IOLMGJIHJFK(null)] BKIMFDNILBI JFAPPEGPHAG, [IOLMGJIHJFK(null)] NCGJFCNJIOO CLLAFAPBEHJ, [IOLMGJIHJFK(null)] FHHJEOGCIEI HDJHGKOIHHL, [IOLMGJIHJFK(null)] FNJCMPBFKHJ EHFCGMNALAN, [IOLMGJIHJFK(null)] MCFLBONNLLI JGCCKCBOIJP, [IOLMGJIHJFK(null)] HAEINGHCIEB CBHCMALKHKH, [IOLMGJIHJFK(null)] BMPPJIOEELE HCMEDAAMLKF, [IOLMGJIHJFK(null)] KADLIJAOKIC JMDKLAKMJDF, [IOLMGJIHJFK(null)] GDFPLOEAABF CFFBIJBFMMD, [IOLMGJIHJFK(null)] EFOEHPJHIKG DHEAIMCJPLD, [IOLMGJIHJFK(null)] DBGDBPBOCKE BJBAJBCALDK, [IOLMGJIHJFK(null)] CMEOIBGNCED CLCLDAFNDHJ, [IOLMGJIHJFK(null)] FIPHIHKIFBP DFLMGONPMNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x20BF5D0", Offset = "0x20BDBD0", VA = "0x1820BF5D0")]
	private void EDEIJCODOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x20BF400", Offset = "0x20BDA00", VA = "0x1820BF400", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x20BFC40", Offset = "0x20BE240", VA = "0x1820BFC40", Slot = "12")]
	private void ODDLCOMONAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x20BF930", Offset = "0x20BDF30", VA = "0x1820BF930", Slot = "18")]
	private Task NCMDFFFFEBD(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x20BF6C0", Offset = "0x20BDCC0", VA = "0x1820BF6C0", Slot = "19")]
	private void IGIEIDGHIAC(long FDEIGEELENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x20BFDB0", Offset = "0x20BE3B0", VA = "0x1820BFDB0", Slot = "20")]
	private bool PFFGPEPEEAC(long KAMCIMPLACP, out DateTime BNCJPAHINEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x20BF870", Offset = "0x20BDE70", VA = "0x1820BF870", Slot = "16")]
	private Task KODBEGDOCHK(string IOMEMFDDFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x20BF6D0", Offset = "0x20BDCD0", VA = "0x1820BF6D0", Slot = "13")]
	private Task<CPPGHHPEEKN> JLENEPJFHKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x20BFC90", Offset = "0x20BE290", VA = "0x1820BFC90", Slot = "14")]
	private Task<CPPGHHPEEKN> OFOGMGLIBDI(BMNAGFLMHFA OFLLOIKKLEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x20BF990", Offset = "0x20BDF90", VA = "0x1820BF990", Slot = "15")]
	private Task<CPPGHHPEEKN> NHIEBCLOBFA(int IELGLAPLPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x20BFAB0", Offset = "0x20BE0B0", VA = "0x1820BFAB0", Slot = "17")]
	private Task NMDFJKIKCLI(EDJOLKBGGON MEHKPGNHAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x20BF560", Offset = "0x20BDB60", VA = "0x1820BF560")]
	[IteratorStateMachine(typeof(MPMDNKBGEMC))]
	private IEnumerable<LAPDICFBJJO> EAACMOIKKGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x20BF2D0", Offset = "0x20BD8D0", VA = "0x1820BF2D0")]
	[CompilerGenerated]
	private void ADIOMLAFCHD(LAPDICFBJJO LPKJELLIJFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OEAAKAHPBHD : OJBPHILPPBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct CEPNNFJOGDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public OEAAKAHPBHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x27CE920", Offset = "0x27CCF20", VA = "0x1827CE920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x27CEBF0", Offset = "0x27CD1F0", VA = "0x1827CEBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x573990", Offset = "0x571F90", VA = "0x180573990")]
	public OEAAKAHPBHD(LBAEOCOFFMH EKJGDPCALOO, FNMMNHKHMCA PJEAKFPHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x27DF080", Offset = "0x27DD680", VA = "0x1827DF080", Slot = "4")]
	[AsyncStateMachine(typeof(CEPNNFJOGDJ))]
	public Task<bool> JLMAOJFCGEG(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x27DF180", Offset = "0x27DD780", VA = "0x1827DF180")]
	[CompilerGenerated]
	private object NLBOCAHDKJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class PMCIFAHIGAA : OJBPHILPPBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct MPNKPIAHHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PMCIFAHIGAA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4E464C0", Offset = "0x4E44AC0", VA = "0x184E464C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4E46A60", Offset = "0x4E45060", VA = "0x184E46A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4E46D70", Offset = "0x4E45370", VA = "0x184E46D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x573990", Offset = "0x571F90", VA = "0x180573990")]
	public PMCIFAHIGAA(LBAEOCOFFMH EKJGDPCALOO, FNMMNHKHMCA PJEAKFPHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4E46C60", Offset = "0x4E45260", VA = "0x184E46C60", Slot = "4")]
	[AsyncStateMachine(typeof(MPNKPIAHHGP))]
	public Task<bool> JLMAOJFCGEG(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4E46B40", Offset = "0x4E45140", VA = "0x184E46B40")]
	[CompilerGenerated]
	private object ACLDGLJBHEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class BAIBDNELIMH : OJBPHILPPBP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct CANKBOODDFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public BAIBDNELIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<Matchmaking.CDJMEKBODDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x20C3F40", Offset = "0x20C2540", VA = "0x1820C3F40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x20C4340", Offset = "0x20C2940", VA = "0x1820C4340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x20C1A50", Offset = "0x20C0050", VA = "0x1820C1A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
	public BAIBDNELIMH(FNMMNHKHMCA PJEAKFPHIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x20C1940", Offset = "0x20BFF40", VA = "0x1820C1940", Slot = "4")]
	[AsyncStateMachine(typeof(CANKBOODDFD))]
	public Task<bool> JLMAOJFCGEG(CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface OJBPHILPPBP
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> JLMAOJFCGEG(CancellationToken CMOIBOJIACL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal struct MCAENKPEKGG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class KLGHFCCIMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public LBAEOCOFFMH manager;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KLGHFCCIMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x27D7730", Offset = "0x27D5D30", VA = "0x1827D7730")]
		internal Task <CreateTask>b__0(NFJKCBJFLIE data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct MFCOLDKINCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public MCAENKPEKGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private bool <restore>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x27DB1C0", Offset = "0x27D97C0", VA = "0x1827DB1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x27DB4B0", Offset = "0x27D9AB0", VA = "0x1827DB4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GNNGEAFLOPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public MCAENKPEKGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x27D2450", Offset = "0x27D0A50", VA = "0x1827D2450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CancellationToken CMOIBOJIACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly LBAEOCOFFMH DPCBPIKGFAF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private DENAOPKHIGA MANIDLGMOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x27D91F0", Offset = "0x27D77F0", VA = "0x1827D91F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x27D8EC0", Offset = "0x27D74C0", VA = "0x1827D8EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x27D9290", Offset = "0x27D7890", VA = "0x1827D9290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private LIFHAIMINNH POAJDOKMEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x27D9240", Offset = "0x27D7840", VA = "0x1827D9240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x27D9640", Offset = "0x27D7C40", VA = "0x1827D9640")]
	public MCAENKPEKGG(CancellationToken CMOIBOJIACL, LBAEOCOFFMH DPCBPIKGFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x27D9000", Offset = "0x27D7600", VA = "0x1827D9000")]
	public static PGGKPPEPLGO CBELIAEENNC(LBAEOCOFFMH DPCBPIKGFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x27D9430", Offset = "0x27D7A30", VA = "0x1827D9430")]
	[AsyncStateMachine(typeof(MFCOLDKINCD))]
	public Task<bool> OBHHENOOAOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x27D9100", Offset = "0x27D7700", VA = "0x1827D9100")]
	private bool DFHPKCDCNCG(out FileInfo MNPDDINKGNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x27D9540", Offset = "0x27D7B40", VA = "0x1827D9540")]
	[AsyncStateMachine(typeof(GNNGEAFLOPH))]
	private Task PMBLMGFILGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x27D9310", Offset = "0x27D7910", VA = "0x1827D9310")]
	private Task<bool> NHMKOPKIJII(FileInfo MNPDDINKGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x27D8F10", Offset = "0x27D7510", VA = "0x1827D8F10")]
	private Task BPDFJONDPDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x27D9090", Offset = "0x27D7690", VA = "0x1827D9090")]
	private void CMLAGCMKNGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal struct DLBKKFPNIJF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly FHHJEOGCIEI HDJHGKOIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Guid KOKPBCLAFDC;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private Task<(CPPGHHPEEKN, Task)> ODGABBKNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x20C71B0", Offset = "0x20C57B0", VA = "0x1820C71B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x20C72D0", Offset = "0x20C58D0", VA = "0x1820C72D0")]
	public DLBKKFPNIJF(FHHJEOGCIEI HDJHGKOIHHL, Guid KOKPBCLAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x20C7280", Offset = "0x20C5880", VA = "0x1820C7280")]
	public TaskAwaiter<(CPPGHHPEEKN, Task)> OPHHLCNJGAI()
	{
		return default(TaskAwaiter<(CPPGHHPEEKN, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x20C70E0", Offset = "0x20C56E0", VA = "0x1820C70E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal struct AEOONJHIJML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly TaskCompletionSource<(CPPGHHPEEKN, Task)> GJCGEDDBBPA;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public Task<(CPPGHHPEEKN, Task)> ODGABBKNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x20C0890", Offset = "0x20BEE90", VA = "0x1820C0890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x20C08D0", Offset = "0x20BEED0", VA = "0x1820C08D0")]
	public AEOONJHIJML(TimeSpan HFMGPPJGPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x20C0720", Offset = "0x20BED20", VA = "0x1820C0720")]
	public void HOHCAJCMMBF(Task NHJCMHGLOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x20C0800", Offset = "0x20BEE00", VA = "0x1820C0800")]
	public void LJMCMEGEGLJ(CPPGHHPEEKN CGGJNNGHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x20C07B0", Offset = "0x20BEDB0", VA = "0x1820C07B0")]
	public void KDCDBEPPIKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x20C06A0", Offset = "0x20BECA0", VA = "0x1820C06A0")]
	internal void DIHEDGBEDAI(string EPAKPJCIEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[Preserve]
internal class JMJILMOOBHE : NPJGAJPPJEI, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct ONANLBEKMHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JMJILMOOBHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x202E580", Offset = "0x202CB80", VA = "0x18202E580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly KCOJKHFGNGK CMACNOFEGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private string MMHMDFMDKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private Task EDFFJGJJLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool GFBLLLADAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2026DE0", Offset = "0x20253E0", VA = "0x182026DE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Task MOANFHAHKDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2026E10", Offset = "0x2025410", VA = "0x182026E10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x673F20", Offset = "0x672520", VA = "0x180673F20", Slot = "7")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2026E70", Offset = "0x2025470", VA = "0x182026E70", Slot = "6")]
	public void GLCIPHEDJLP(Task IPFPIIBOBLL, string NIADDLHGAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2026CB0", Offset = "0x20252B0", VA = "0x182026CB0")]
	[AsyncStateMachine(typeof(ONANLBEKMHM))]
	private Task CJIAKMBKHHI(Task HHMNAEHNEED, string NIADDLHGAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2026FF0", Offset = "0x20255F0", VA = "0x182026FF0")]
	public JMJILMOOBHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[Preserve]
internal class LAGHDODCNDJ : MFHHFAHNJGL, LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class HOINMIFCOIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public ALDIJJBBMNI roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HOINMIFCOIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x27D2F90", Offset = "0x27D1590", VA = "0x1827D2F90")]
		internal object <Invoke>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event HAFEEJEPELG GBEJAPJDDJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x27D7B40", Offset = "0x27D6140", VA = "0x1827D7B40", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x27D7C80", Offset = "0x27D6280", VA = "0x1827D7C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event HAFEEJEPELG FIDNPAPGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x27D7D20", Offset = "0x27D6320", VA = "0x1827D7D20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x27D7DC0", Offset = "0x27D63C0", VA = "0x1827D7DC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event HAFEEJEPELG BBILPJBFLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x27D7BE0", Offset = "0x27D61E0", VA = "0x1827D7BE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x27D7A70", Offset = "0x27D6070", VA = "0x1827D7A70", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "13")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x27D7A40", Offset = "0x27D6040", VA = "0x1827D7A40", Slot = "10")]
	public void CIPPHAHCMFK(ALDIJJBBMNI GMPOPNLDAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x27D7E60", Offset = "0x27D6460", VA = "0x1827D7E60", Slot = "11")]
	public void PEKFJDANINA(ALDIJJBBMNI GMPOPNLDAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x27D7B10", Offset = "0x27D6110", VA = "0x1827D7B10", Slot = "12")]
	public void GMBAINFHMGA(ALDIJJBBMNI GMPOPNLDAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x27D77F0", Offset = "0x27D5DF0", VA = "0x1827D77F0")]
	private void CEKPADBFJKO(HAFEEJEPELG BPDKNEKOMHG, ALDIJJBBMNI GMPOPNLDAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public LAGHDODCNDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Preserve]
internal class HJOOLJCIEGD : BLFGHLPNEHN, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private struct KKAHOIMAMNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public HJOOLJCIEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x202A850", Offset = "0x2028E50", VA = "0x18202A850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct IAGAFDIKNKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public HJOOLJCIEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x20222B0", Offset = "0x20208B0", VA = "0x1820222B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HCPGHAOIEDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HCPGHAOIEDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x201E620", Offset = "0x201CC20", VA = "0x18201E620")]
		internal object <TryRunFallback>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct EMDKJDNOPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HJOOLJCIEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private HCPGHAOIEDN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x201B010", Offset = "0x2019610", VA = "0x18201B010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x201B740", Offset = "0x2019D40", VA = "0x18201B740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class POIKIDHAAHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public POIKIDHAAHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x202F0A0", Offset = "0x202D6A0", VA = "0x18202F0A0")]
		internal object <LogFallbackStart>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private OJBPHILPPBP[] KPCDLJPCGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private CancellationTokenSource LJJFJBNCDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int JNEEOGOKFKB;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x201F990", Offset = "0x201DF90", VA = "0x18201F990", Slot = "7")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x201F980", Offset = "0x201DF80", VA = "0x18201F980", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x201F810", Offset = "0x201DE10", VA = "0x18201F810", Slot = "6")]
	public void DDPMPAFGPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x201FA10", Offset = "0x201E010", VA = "0x18201FA10", Slot = "5")]
	public void ENEBMMKBJFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x201F700", Offset = "0x201DD00", VA = "0x18201F700", Slot = "4")]
	[AsyncStateMachine(typeof(KKAHOIMAMNF))]
	public Task BLBNENCAACM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2020130", Offset = "0x201E730", VA = "0x182020130")]
	private void NMEONDONLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x2020430", Offset = "0x201EA30", VA = "0x182020430")]
	[AsyncStateMachine(typeof(IAGAFDIKNKO))]
	private Task PBNCLDHAEBL(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x2020000", Offset = "0x201E600", VA = "0x182020000")]
	[AsyncStateMachine(typeof(EMDKJDNOPPF))]
	private Task<bool> MGLDDBHENBC(int HOOANEAGKNH, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x201FC50", Offset = "0x201E250", VA = "0x18201FC50")]
	private void IADEELPFBKA(int HOOANEAGKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x201FF00", Offset = "0x201E500", VA = "0x18201FF00")]
	private void KJCBINNHHEO(int HOOANEAGKNH, bool GBEJONPLCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x201FD70", Offset = "0x201E370", VA = "0x18201FD70")]
	private void IOKAODAIAOP(int HOOANEAGKNH, Exception ALOGJNLCMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x201FB60", Offset = "0x201E160", VA = "0x18201FB60")]
	private void GMKBIHGKDHD(CancellationToken CMOIBOJIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HJOOLJCIEGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Preserve]
internal class KBOGEJFCADC : NCGJFCNJIOO, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct HECNNDCOBGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public KBOGEJFCADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NFJKCBJFLIE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x201E8F0", Offset = "0x201CEF0", VA = "0x18201E8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class IKIBOOFCILF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public KBOGEJFCADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NFJKCBJFLIE roomData;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IKIBOOFCILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x20249A0", Offset = "0x2022FA0", VA = "0x1820249A0")]
		internal List<Task> <GetPostLoadTaskGenerator>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct FJIHPIIKNOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public PGGKPPEPLGO taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x201C000", Offset = "0x201A600", VA = "0x18201C000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct HPICHMJLMDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public KBOGEJFCADC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2022010", Offset = "0x2020610", VA = "0x182022010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly HashSet<PGGKPPEPLGO> PMKJOJOLLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private MJPGKFDMANL CELMJJPEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private OJPBNECMBED DHLLAJPPDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private OEEDJMEOFMI INLNOLLPIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private IDisposable CMDDGMIGNCH;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool EGMIMPEGNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x2028900", Offset = "0x2026F00", VA = "0x182028900", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	internal Task ODGABBKNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x2028910", Offset = "0x2026F10", VA = "0x182028910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x2027ED0", Offset = "0x20264D0", VA = "0x182027ED0", Slot = "6")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2027E70", Offset = "0x2026470", VA = "0x182027E70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x20285D0", Offset = "0x2026BD0", VA = "0x1820285D0", Slot = "5")]
	public bool FHNEBLNKNIP(PGGKPPEPLGO INLCLHGCMGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x20278E0", Offset = "0x2025EE0", VA = "0x1820278E0")]
	private void AHBFDKFBAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2027A20", Offset = "0x2026020", VA = "0x182027A20")]
	private void BJAPIKJLPAJ(NFJKCBJFLIE EIGJMLMDBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x20287E0", Offset = "0x2026DE0", VA = "0x1820287E0")]
	[AsyncStateMachine(typeof(HECNNDCOBGC))]
	private Task LNLDDLAIMJE(NFJKCBJFLIE EIGJMLMDBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2028730", Offset = "0x2026D30", VA = "0x182028730")]
	private Func<CancellationToken, List<Task>> LMOOAFMDOFD(NFJKCBJFLIE EIGJMLMDBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2028130", Offset = "0x2026730", VA = "0x182028130")]
	private List<Task> EPFEEPFODIO(NFJKCBJFLIE EIGJMLMDBAJ, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x2027C70", Offset = "0x2026270", VA = "0x182027C70")]
	[AsyncStateMachine(typeof(FJIHPIIKNOJ))]
	private Task DDLPBMDHMFB(PGGKPPEPLGO KDEKMKDFDIG, NFJKCBJFLIE OGNHKENMEGF, CancellationToken GJGFJFLAGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x2028630", Offset = "0x2026C30", VA = "0x182028630")]
	[AsyncStateMachine(typeof(HPICHMJLMDI))]
	private Task HNHFGBBLEMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x2027DA0", Offset = "0x20263A0", VA = "0x182027DA0")]
	private void DDPMPAFGPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x2028920", Offset = "0x2026F20", VA = "0x182028920")]
	public KBOGEJFCADC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
internal class HACLIFGIOLP : BKIMFDNILBI, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct BDAHDEKKBNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x20C1BC0", Offset = "0x20C01C0", VA = "0x1820C1BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct BPPBFFIJEMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private BJHOOGFBDGF <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private EGHNIDJHOFI <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private JGLIFMEIBOB <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x20C36A0", Offset = "0x20C1CA0", VA = "0x1820C36A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct LCKBNHEEFJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public EGHNIDJHOFI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private GAAMEIHCBEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private CancellationTokenSource <roomTokenSource>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private CancellationToken <roomCancellationToken>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Task <roomLoadTask>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x20D2510", Offset = "0x20D0B10", VA = "0x1820D2510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct OAINNPPMKNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private GAAMEIHCBEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x202E130", Offset = "0x202C730", VA = "0x18202E130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct HAIGNHPGOMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public EGHNIDJHOFI joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private GAAMEIHCBEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter<ADACELJDOIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x20D1530", Offset = "0x20CFB30", VA = "0x1820D1530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class LPGPBBFPFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LPGPBBFPFKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class LGIEFGCPMCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public LPGPBBFPFKE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LGIEFGCPMCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x20D38E0", Offset = "0x20D1EE0", VA = "0x1820D38E0")]
		internal string <JoinRoomLoadWithPhoton>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct CFCAKGNNOGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private LGIEFGCPMCB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x20C4C60", Offset = "0x20C3260", VA = "0x1820C4C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct NGOOAJBKFPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public EGHNIDJHOFI joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public EMBFCHHFKKK targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x202D520", Offset = "0x202BB20", VA = "0x18202D520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct AAIIGFIMGHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x20BEE90", Offset = "0x20BD490", VA = "0x1820BEE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct NJNHIEIOMHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x202DB90", Offset = "0x202C190", VA = "0x18202DB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct JGFJCJPIPDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x20D2200", Offset = "0x20D0800", VA = "0x1820D2200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct AJJNPJEGPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private TaskAwaiter<CPPGHHPEEKN> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x20C0FD0", Offset = "0x20BF5D0", VA = "0x1820C0FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class JOGDEDFPBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public MPAMOOGKAGA disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public JOGDEDFPBPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x20D2470", Offset = "0x20D0A70", VA = "0x1820D2470")]
		internal object <OnDisconnectedFromPhotonWhileConnected>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct MDEBAPKIKLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public MPAMOOGKAGA disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x20D49C0", Offset = "0x20D2FC0", VA = "0x1820D49C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct DFKKOKEMGGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public BJHOOGFBDGF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public HACLIFGIOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x20C6BF0", Offset = "0x20C51F0", VA = "0x1820C6BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class LPHABECKNMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LPHABECKNMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x20D4080", Offset = "0x20D2680", VA = "0x1820D4080")]
		internal object <LogRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class NJELDHEGOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public NJELDHEGOOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x202DB00", Offset = "0x202C100", VA = "0x18202DB00")]
		internal void <LogRoomLoadCancellation>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class NDKFNMHNDPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public NDKFNMHNDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x202D4B0", Offset = "0x202BAB0", VA = "0x18202D4B0")]
		internal object <LogRoomLoadFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class IALEINAAFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IALEINAAFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x20D1B90", Offset = "0x20D0190", VA = "0x1820D1B90")]
		internal string <LogRoomLoadSuccess>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static readonly Guid ENOOLFPKFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private HLGNNAIFBEA BGONODDGIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private MJPGKFDMANL CELMJJPEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private DENAOPKHIGA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private BLFGHLPNEHN AIMKCJLJABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private EFOEHPJHIKG DHEAIMCJPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private NPJGAJPPJEI EMLBOAGIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private MFHHFAHNJGL JDIKOPFEMKI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public TaskStatus ICOLJNBCLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB620", Offset = "0x5F9C20", VA = "0x1805FB620", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7D0", Offset = "0x5F9DD0", VA = "0x1805FB7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x20D0DB0", Offset = "0x20CF3B0", VA = "0x1820D0DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x20CF1C0", Offset = "0x20CD7C0", VA = "0x1820CF1C0", Slot = "6")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x20D03D0", Offset = "0x20CE9D0", VA = "0x1820D03D0", Slot = "5")]
	[AsyncStateMachine(typeof(BDAHDEKKBNB))]
	public Task KICAFMGAABI(EMBFCHHFKKK EHDMDEMFAJN, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x20D0E00", Offset = "0x20CF400", VA = "0x1820D0E00")]
	[AsyncStateMachine(typeof(BPPBFFIJEMB))]
	private Task MDCFMHHDADG(EMBFCHHFKKK EHDMDEMFAJN, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x20CFFD0", Offset = "0x20CE5D0", VA = "0x1820CFFD0")]
	[AsyncStateMachine(typeof(LCKBNHEEFJJ))]
	private Task IKMJNIJKJIL(BJHOOGFBDGF NJKJIAHPBGG, EMBFCHHFKKK EHDMDEMFAJN, EGHNIDJHOFI APKFENLGLNG, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x20D0640", Offset = "0x20CEC40", VA = "0x1820D0640")]
	[AsyncStateMachine(typeof(OAINNPPMKNL))]
	private Task LBGPNDLIFLE(BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x20D0890", Offset = "0x20CEE90", VA = "0x1820D0890")]
	private void LJMNFGMJMOM(EMBFCHHFKKK EHDMDEMFAJN, CancellationToken OLMBFPIKDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x20D0F30", Offset = "0x20CF530", VA = "0x1820D0F30")]
	private void NGEFPPBEOBI(EMBFCHHFKKK EHDMDEMFAJN, EGHNIDJHOFI APKFENLGLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x20CEB50", Offset = "0x20CD150", VA = "0x1820CEB50")]
	private void AAODPIDKLHJ(EMBFCHHFKKK EHDMDEMFAJN, EGHNIDJHOFI APKFENLGLNG, Exception ALOGJNLCMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x20CFC10", Offset = "0x20CE210", VA = "0x1820CFC10")]
	private void HEHJPALMBHC(EMBFCHHFKKK EHDMDEMFAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x20CF160", Offset = "0x20CD760", VA = "0x1820CF160")]
	private static ALDIJJBBMNI DNFIMJBNCII(EMBFCHHFKKK EHDMDEMFAJN)
	{
		return default(ALDIJJBBMNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x20CFE70", Offset = "0x20CE470", VA = "0x1820CFE70")]
	private void IJFHFAIJLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x20D1410", Offset = "0x20CFA10", VA = "0x1820D1410")]
	private static ADACELJDOIL PAEHEIIJHGP(EMBFCHHFKKK EHDMDEMFAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x20D0B40", Offset = "0x20CF140", VA = "0x1820D0B40")]
	[AsyncStateMachine(typeof(HAIGNHPGOMM))]
	private Task LKFFIFIOMOK(EMBFCHHFKKK EHDMDEMFAJN, EGHNIDJHOFI APKFENLGLNG, BJHOOGFBDGF NJKJIAHPBGG, CancellationToken NKGIGKCIJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x20CF000", Offset = "0x20CD600", VA = "0x1820CF000")]
	[AsyncStateMachine(typeof(CFCAKGNNOGI))]
	private Task COPCMOJLOOD(EMBFCHHFKKK EHDMDEMFAJN, CancellationTokenSource IEKLCMEOJMN, Task HIILEEHJPEH, CancellationToken NKGIGKCIJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x20D0130", Offset = "0x20CE730", VA = "0x1820D0130")]
	[AsyncStateMachine(typeof(NGOOAJBKFPP))]
	private Task JLFLJANCLMP(EMBFCHHFKKK PNGLCEBBPJA, EGHNIDJHOFI FGPHLJJPNKK, BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CFNNPGGKEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x20CF610", Offset = "0x20CDC10", VA = "0x1820CF610")]
	private EGHNIDJHOFI GBHKMPGAAGJ(EGHNIDJHOFI FGPHLJJPNKK, ref CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x20CF4D0", Offset = "0x20CDAD0", VA = "0x1820CF4D0")]
	[AsyncStateMachine(typeof(AAIIGFIMGHC))]
	private Task EDFGEINCPJI(BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x20CEE20", Offset = "0x20CD420", VA = "0x1820CEE20")]
	[AsyncStateMachine(typeof(NJNHIEIOMHH))]
	private Task AFICBBAIAEO(BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x20D0500", Offset = "0x20CEB00", VA = "0x1820D0500")]
	[AsyncStateMachine(typeof(JGFJCJPIPDD))]
	private Task KOLJLMIDDAF(BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x20D12E0", Offset = "0x20CF8E0", VA = "0x1820D12E0")]
	[AsyncStateMachine(typeof(AJJNPJEGPJK))]
	private Task OKBGFBIMIFN(NFJKCBJFLIE OGNHKENMEGF, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x20D0CA0", Offset = "0x20CF2A0", VA = "0x1820D0CA0")]
	[AsyncStateMachine(typeof(MDEBAPKIKLF))]
	private Task MBFBFHNGLEE(MPAMOOGKAGA MHDPOBMLGDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x20D0290", Offset = "0x20CE890", VA = "0x1820D0290")]
	[AsyncStateMachine(typeof(DFKKOKEMGGM))]
	private Task JNGLKCCLLFH(BJHOOGFBDGF OADNBMGMCGO, CancellationToken NKGIGKCIJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x20D0770", Offset = "0x20CED70", VA = "0x1820D0770")]
	private static void LHHFGNNAGLB(EMBFCHHFKKK EHDMDEMFAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x20CF940", Offset = "0x20CDF40", VA = "0x1820CF940")]
	private static void GIAAHJOAOAM(EMBFCHHFKKK EHDMDEMFAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x20CEF50", Offset = "0x20CD550", VA = "0x1820CEF50")]
	private static void CICNBKPHFNI(EMBFCHHFKKK EHDMDEMFAJN, CancellationToken NKGIGKCIJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x20CFA80", Offset = "0x20CE080", VA = "0x1820CFA80")]
	private static void GNCDALBPHFI(EMBFCHHFKKK EHDMDEMFAJN, Exception ALOGJNLCMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x20CF810", Offset = "0x20CDE10", VA = "0x1820CF810")]
	private void GGILDMEINCC(EMBFCHHFKKK EHDMDEMFAJN, Task HIILEEHJPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x20D1220", Offset = "0x20CF820", VA = "0x1820D1220")]
	private static void NJMIDDMBIGP(Func<string> LIIFAPBKLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x20D1520", Offset = "0x20CFB20", VA = "0x1820D1520")]
	public HACLIFGIOLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Preserve]
internal sealed class OPBFHDFNBHK : FHHJEOGCIEI, LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class AALOENNALFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public AALOENNALFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x27CD480", Offset = "0x27CBA80", VA = "0x1827CD480")]
		internal object <Add>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HMICNLDBLOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HMICNLDBLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x27D2F40", Offset = "0x27D1540", VA = "0x1827D2F40")]
		internal object <Remove>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class AKJFILPOPJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public AKJFILPOPJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x27CD530", Offset = "0x27CBB30", VA = "0x1827CD530")]
		internal object <Cancel>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class HAABPACCNML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HAABPACCNML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x27D26E0", Offset = "0x27D0CE0", VA = "0x1827D26E0")]
		internal object <MarkStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class IBLFCGEEHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IBLFCGEEHJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x27D39F0", Offset = "0x27D1FF0", VA = "0x1827D39F0")]
		internal object <MarkFailed>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<Guid, AEOONJHIJML> HDJHGKOIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly TimeSpan KBPEMLLAPAI;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "10")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x27E18F0", Offset = "0x27DFEF0", VA = "0x1827E18F0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x27E1FA0", Offset = "0x27E05A0", VA = "0x1827E1FA0", Slot = "4")]
	public DLBKKFPNIJF NENJMCKJAJO(Guid KOKPBCLAFDC)
	{
		return default(DLBKKFPNIJF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x27E1D60", Offset = "0x27E0360", VA = "0x1827E1D60", Slot = "5")]
	public bool MNHCGCIEOKP(Guid KOKPBCLAFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x27E1660", Offset = "0x27DFC60", VA = "0x1827E1660", Slot = "8")]
	public bool DDPMPAFGPGL(Guid KOKPBCLAFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x27E2230", Offset = "0x27E0830", VA = "0x1827E2230", Slot = "6")]
	public bool PAPLHFGBIMN(Guid KOKPBCLAFDC, Task NHJCMHGLOGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x27E1B40", Offset = "0x27E0140", VA = "0x1827E1B40", Slot = "7")]
	public bool ICNHOIFNPIG(Guid KOKPBCLAFDC, CPPGHHPEEKN CGGJNNGHPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x27E1870", Offset = "0x27DFE70", VA = "0x1827E1870", Slot = "9")]
	public Task<(CPPGHHPEEKN, Task)> DKEEFEBEBKG(Guid KOKPBCLAFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x27E1900", Offset = "0x27DFF00", VA = "0x1827E1900")]
	private void HNAMEENHKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x27E2590", Offset = "0x27E0B90", VA = "0x1827E2590")]
	public OPBFHDFNBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[Preserve]
internal class OHFDGLFNJOP : FNJCMPBFKHJ, LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	private class JDFELNFGINH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private readonly EMBFCHHFKKK HLFEGFDJPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly CancellationTokenSource LJJFJBNCDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public readonly CancellationToken KCJHDPCONJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool EAPJJNDHCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private bool PGGNJMMOIKA;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x27D40F0", Offset = "0x27D26F0", VA = "0x1827D40F0")]
		public JDFELNFGINH(EMBFCHHFKKK HLFEGFDJPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x27D3F90", Offset = "0x27D2590", VA = "0x1827D3F90")]
		public void DDPMPAFGPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x27D40C0", Offset = "0x27D26C0", VA = "0x1827D40C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class AJBKJOLOKEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public AJBKJOLOKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x27CD4D0", Offset = "0x27CBAD0", VA = "0x1827CD4D0")]
		internal object <OnPlayerPresenceUpdated>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private sealed class KKOIFIIJDFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public EMBFCHHFKKK newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KKOIFIIJDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x27D76A0", Offset = "0x27D5CA0", VA = "0x1827D76A0")]
		internal object <TryJoinRoomInstance>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class JCPHMFMKJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public JCPHMFMKJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x27D3F00", Offset = "0x27D2500", VA = "0x1827D3F00")]
		internal void <TryJoinRoomInstance>b__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct BNMBNBMKJJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public EMBFCHHFKKK newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OHFDGLFNJOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private KKOIFIIJDFF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x27CDA20", Offset = "0x27CC020", VA = "0x1827CDA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private MJPGKFDMANL CELMJJPEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private BLFGHLPNEHN AIMKCJLJABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private BKIMFDNILBI JFAPPEGPHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private long NBEMIPGGPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JDFELNFGINH OOGBLMENONK;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x27E0930", Offset = "0x27DEF30", VA = "0x1827E0930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x27E03F0", Offset = "0x27DE9F0", VA = "0x1827E03F0", Slot = "5")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x27E02A0", Offset = "0x27DE8A0", VA = "0x1827E02A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x27DF7D0", Offset = "0x27DDDD0", VA = "0x1827DF7D0", Slot = "4")]
	public void BLBNENCAACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x27DF5D0", Offset = "0x27DDBD0", VA = "0x1827DF5D0")]
	private void APPCOBCHHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x27E00C0", Offset = "0x27DE6C0", VA = "0x1827E00C0")]
	private void DFEHNPJDBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x27E05E0", Offset = "0x27DEBE0", VA = "0x1827E05E0")]
	private void JDGDMBFAGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x27E0560", Offset = "0x27DEB60", VA = "0x1827E0560")]
	private bool HHPBPFLLOMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x27DF850", Offset = "0x27DDE50", VA = "0x1827DF850")]
	private void CBEGOOOEIPF(int KFGECDIOFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x27E07B0", Offset = "0x27DEDB0", VA = "0x1827E07B0")]
	private bool LBECEEPFNNP(EMBFCHHFKKK HLFEGFDJPCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x27E0980", Offset = "0x27DEF80", VA = "0x1827E0980")]
	[AsyncStateMachine(typeof(BNMBNBMKJJP))]
	private Task MDCFMHHDADG(EMBFCHHFKKK HLFEGFDJPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x27E0A90", Offset = "0x27DF090", VA = "0x1827E0A90")]
	public OHFDGLFNJOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[Preserve]
internal sealed class KCNBBKDAAFF : MCFLBONNLLI, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct MBEHJLDLPAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public AsyncTaskMethodBuilder<LKDPLNJNDNN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public KCNBBKDAAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private TaskAwaiter<LKDPLNJNDNN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x202B290", Offset = "0x2029890", VA = "0x18202B290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x202B460", Offset = "0x2029A60", VA = "0x18202B460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class EIANFHFCDII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public MGIOABMEIJD message;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public EIANFHFCDII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x201A980", Offset = "0x2018F80", VA = "0x18201A980")]
		internal object <MasterTryStartOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class PKAJHDDPNGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public MGIOABMEIJD messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public PKAJHDDPNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x202F050", Offset = "0x202D650", VA = "0x18202F050")]
		internal object <TryStartOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NOFBCPAKLEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public NOFBCPAKLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x202E0E0", Offset = "0x202C6E0", VA = "0x18202E0E0")]
		internal object <RunOperationFromRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct GFEEGFEGKHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public KCNBBKDAAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<CHMPEANIDIP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x201D250", Offset = "0x201B850", VA = "0x18201D250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class ODHELLJBIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public MGIOABMEIJD operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ODHELLJBIMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x202E530", Offset = "0x202CB30", VA = "0x18202E530")]
		internal object <RunOperationFromMaster>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct BNPKKDDNOHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public MGIOABMEIJD operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public KCNBBKDAAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private EGHNIDJHOFI <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2018BE0", Offset = "0x20171E0", VA = "0x182018BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct EDMKODKPMGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder<CHMPEANIDIP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public KCNBBKDAAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private EGHNIDJHOFI <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x201A560", Offset = "0x2018B60", VA = "0x18201A560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x201A930", Offset = "0x2018F30", VA = "0x18201A930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class KHIEBKGANEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public CHMPEANIDIP operation;

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KHIEBKGANEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x202A7E0", Offset = "0x2028DE0", VA = "0x18202A7E0")]
		internal object <RunOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct IDLEBLMPAJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public CHMPEANIDIP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public KCNBBKDAAFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private BJHOOGFBDGF <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x2022C70", Offset = "0x2021270", VA = "0x182022C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class GNOCAIFNMCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GNOCAIFNMCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x201E100", Offset = "0x201C700", VA = "0x18201E100")]
		internal object <TryCreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class LCHAFPADLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LCHAFPADLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x202AF70", Offset = "0x2029570", VA = "0x18202AF70")]
		internal object <CreateOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private NPJGAJPPJEI EMLBOAGIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private HAEINGHCIEB CBHCMALKHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private EFOEHPJHIKG DHEAIMCJPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private DENAOPKHIGA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private TaskCompletionSource<LKDPLNJNDNN> NAPIIABJIAA;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2028CC0", Offset = "0x20272C0", VA = "0x182028CC0", Slot = "7")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x20299B0", Offset = "0x2027FB0", VA = "0x1820299B0", Slot = "6")]
	[AsyncStateMachine(typeof(MBEHJLDLPAM))]
	public Task<LKDPLNJNDNN> LGEPHEMPADI(CancellationToken HENDNIHFHDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2029120", Offset = "0x2027720", VA = "0x182029120", Slot = "4")]
	public void FPJOBLBOJCG(MGIOABMEIJD EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2029B20", Offset = "0x2028120", VA = "0x182029B20", Slot = "5")]
	public void NOJCMDNGGJA(MGIOABMEIJD PEJBDKBHAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2028BB0", Offset = "0x20271B0", VA = "0x182028BB0")]
	[AsyncStateMachine(typeof(GFEEGFEGKHJ))]
	private Task APLDFEBHHDK(MGIOABMEIJD DMFHFDFMIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2029EE0", Offset = "0x20284E0", VA = "0x182029EE0")]
	[AsyncStateMachine(typeof(BNPKKDDNOHJ))]
	private Task ONONJLDGILI(MGIOABMEIJD IKOCPBLMCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x2029870", Offset = "0x2027E70", VA = "0x182029870")]
	[AsyncStateMachine(typeof(EDMKODKPMGC))]
	private Task<CHMPEANIDIP> LEEBCEAHIJJ(MGIOABMEIJD DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2029E60", Offset = "0x2028460", VA = "0x182029E60")]
	private EGHNIDJHOFI OIDNPNJCPNF(MGIOABMEIJD COEEKAFJDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2028DA0", Offset = "0x20273A0", VA = "0x182028DA0")]
	[AsyncStateMachine(typeof(IDLEBLMPAJL))]
	private Task FEIDGGOKBKM(CHMPEANIDIP ADCHCDBFMEI, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2028ED0", Offset = "0x20274D0", VA = "0x182028ED0")]
	private CHMPEANIDIP FIBEAKONIJC(MGIOABMEIJD DMFHFDFMIOL, EGHNIDJHOFI APNFPOCHBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x1E21DC0", Offset = "0x1E203C0", VA = "0x181E21DC0")]
	private T CKPNAPHOGPO<T>(T MPHFKGJNMOK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2029490", Offset = "0x2027A90", VA = "0x182029490")]
	private CHMPEANIDIP HIEGBFJHPAN(MGIOABMEIJD DMFHFDFMIOL, EGHNIDJHOFI APNFPOCHBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public KCNBBKDAAFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2029AD0", Offset = "0x20280D0", VA = "0x182029AD0")]
	[CompilerGenerated]
	private void MDMNPACFIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[Preserve]
internal sealed class MNDENNLFLBK : HAEINGHCIEB, LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class LOJLNJPIBMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LOJLNJPIBMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x27D8C90", Offset = "0x27D7290", VA = "0x1827D8C90")]
		internal object <OnOperationStarted>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private sealed class IMAKFFBEHNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IMAKFFBEHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x27D3EA0", Offset = "0x27D24A0", VA = "0x1827D3EA0")]
		internal object <SendReliableToAll>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private DENAOPKHIGA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private DBGDBPBOCKE BJBAJBCALDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private MCFLBONNLLI JGCCKCBOIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private FHHJEOGCIEI HDJHGKOIHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private FIPHIHKIFBP DFLMGONPMNH;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x27DC0A0", Offset = "0x27DA6A0", VA = "0x1827DC0A0", Slot = "6")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x27DC010", Offset = "0x27DA610", VA = "0x1827DC010", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x27DC1E0", Offset = "0x27DA7E0", VA = "0x1827DC1E0", Slot = "4")]
	public DLBKKFPNIJF HIJEFAEPJIF(EENOJINADGG DMFHFDFMIOL)
	{
		return default(DLBKKFPNIJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x27DD360", Offset = "0x27DB960", VA = "0x1827DD360", Slot = "5")]
	public void OOEHPONBFPE(Guid KOKPBCLAFDC, Task NHJCMHGLOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x27DD7E0", Offset = "0x27DBDE0", VA = "0x1827DD7E0")]
	private void PLAJGEDNCMH(byte JPPKOANDKCC, int HNIPPCIGGDF, object BIJBMBCMLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x27DBB90", Offset = "0x27DA190", VA = "0x1827DBB90")]
	private void CCBLDBEFDMB(AICDPLFHBFK OEELGPMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x27DCAE0", Offset = "0x27DB0E0", VA = "0x1827DCAE0")]
	private void JMDKOOLIGHN(AICDPLFHBFK OEELGPMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x27DB930", Offset = "0x27D9F30", VA = "0x1827DB930")]
	private void BLIMCBAALCI(AICDPLFHBFK OEELGPMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x27DD040", Offset = "0x27DB640", VA = "0x1827DD040")]
	private CPPGHHPEEKN MBBJHNOBDFB(MGIOABMEIJD COEEKAFJDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x27DD5B0", Offset = "0x27DBBB0", VA = "0x1827DD5B0")]
	private void OOPMCGENMKO(MGIOABMEIJD IKOCPBLMCLP, CPPGHHPEEKN CGGJNNGHPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x27DC8C0", Offset = "0x27DAEC0", VA = "0x1827DC8C0")]
	private bool HOMPCPGNPFC(MGIOABMEIJD IKOCPBLMCLP, CPPGHHPEEKN CGGJNNGHPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x27DC670", Offset = "0x27DAC70", VA = "0x1827DC670")]
	private bool HIJEFAEPJIF(MGIOABMEIJD GHAENDMJKDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x27DCD70", Offset = "0x27DB370", VA = "0x1827DCD70")]
	private bool LAEHPGJEJFA(byte JPPKOANDKCC, ExitGames.Client.Photon.Hashtable OEELGPMNOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public MNDENNLFLBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[Preserve]
internal sealed class HKOBEKOCEMJ : BMPPJIOEELE, LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class HGOBCJEJGNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public LKDPLNJNDNN operationType;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HGOBCJEJGNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x201F0B0", Offset = "0x201D6B0", VA = "0x18201F0B0")]
		internal object <RequestOperation>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private struct FNINFPHEAIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder<CPPGHHPEEKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public LKDPLNJNDNN operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public HKOBEKOCEMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public BMNAGFLMHFA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter<CPPGHHPEEKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x201C820", Offset = "0x201AE20", VA = "0x18201C820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x201CDD0", Offset = "0x201B3D0", VA = "0x18201CDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class LPCOCOOKHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public LKDPLNJNDNN operationType;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LPCOCOOKHND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x202B230", Offset = "0x2029830", VA = "0x18202B230")]
		internal object <CanLocalPlayerRequestOperation>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class JBIAHPMMCLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public LKDPLNJNDNN operationType;

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public JBIAHPMMCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x2025B60", Offset = "0x2024160", VA = "0x182025B60")]
		internal object <RequestOperationInternal>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x2025BC0", Offset = "0x20241C0", VA = "0x182025BC0")]
		internal object <RequestOperationInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x2025C20", Offset = "0x2024220", VA = "0x182025C20")]
		internal object <RequestOperationInternal>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct BPOHNLOBBFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder<CPPGHHPEEKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public LKDPLNJNDNN operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public HKOBEKOCEMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public BMNAGFLMHFA player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private JBIAHPMMCLD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private DLBKKFPNIJF <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private CPPGHHPEEKN <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private TaskAwaiter<(CPPGHHPEEKN validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x20192C0", Offset = "0x20178C0", VA = "0x1820192C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x20198F0", Offset = "0x2017EF0", VA = "0x1820198F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class EOFDOAIEKCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public LKDPLNJNDNN operationType;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public EOFDOAIEKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x201B790", Offset = "0x2019D90", VA = "0x18201B790")]
		internal object <CreateOperationRequest>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private KADLIJAOKIC JMDKLAKMJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private DENAOPKHIGA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private DBGDBPBOCKE BJBAJBCALDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private HAEINGHCIEB CBHCMALKHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x2020D50", Offset = "0x201F350", VA = "0x182020D50", Slot = "5")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x2020550", Offset = "0x201EB50", VA = "0x182020550", Slot = "4")]
	[AsyncStateMachine(typeof(FNINFPHEAIG))]
	public Task<CPPGHHPEEKN> AKAGLGAOCIC(BMNAGFLMHFA JLDONLICNFI, LKDPLNJNDNN CLFEHPMJEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x2020AB0", Offset = "0x201F0B0", VA = "0x182020AB0")]
	private bool DJCMCFHIDDH(LKDPLNJNDNN CLFEHPMJEFA, out CPPGHHPEEKN AEOILPMENGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x2020680", Offset = "0x201EC80", VA = "0x182020680")]
	[AsyncStateMachine(typeof(BPOHNLOBBFP))]
	private Task<CPPGHHPEEKN> AOKCICKPPIO(BMNAGFLMHFA JLDONLICNFI, LKDPLNJNDNN CLFEHPMJEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x20207B0", Offset = "0x201EDB0", VA = "0x1820207B0")]
	internal EENOJINADGG BHHCHENPEIN(BMNAGFLMHFA JLDONLICNFI, LKDPLNJNDNN CLFEHPMJEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HKOBEKOCEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[Preserve]
internal sealed class IHLNBHEAMPK : KADLIJAOKIC, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct MIKAEEPIMJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder<CCKBMPBIFMP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public IHLNBHEAMPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<MFFPLJBNNEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x202BC80", Offset = "0x202A280", VA = "0x18202BC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x202C0D0", Offset = "0x202A6D0", VA = "0x18202C0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct FMBLOIAFDJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AsyncTaskMethodBuilder<MFFPLJBNNEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public IHLNBHEAMPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<MFFPLJBNNEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x201C400", Offset = "0x201AA00", VA = "0x18201C400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x201C7D0", Offset = "0x201ADD0", VA = "0x18201C7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class DBIOPDDAAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public DBIOPDDAAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x105ABB0", Offset = "0x10591B0", VA = "0x18105ABB0")]
		internal bool <GetRoomDataBlobWithHashForRoomDetails>b__0(DBPKBOFJDFM sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class HBHLAAGJJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HBHLAAGJJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x201E590", Offset = "0x201CB90", VA = "0x18201E590")]
		internal object <GetRoomDetails>b__0(in long rid)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct FGHHLFGLIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public AsyncTaskMethodBuilder<MFFPLJBNNEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public EMBFCHHFKKK targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public IHLNBHEAMPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public bool forceCacheRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private TaskAwaiter<MFFPLJBNNEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x201BC10", Offset = "0x201A210", VA = "0x18201BC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x201BFB0", Offset = "0x201A5B0", VA = "0x18201BFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly (FHKCFJFJCGG superRoomData, FHKCFJFJCGG subRoomData) LIPGNFDGEJE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x2024730", Offset = "0x2022D30", VA = "0x182024730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x2024240", Offset = "0x2022840", VA = "0x182024240", Slot = "6")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x2024780", Offset = "0x2022D80", VA = "0x182024780", Slot = "4")]
	[AsyncStateMachine(typeof(MIKAEEPIMJF))]
	public Task<CCKBMPBIFMP> PKEFCDCKNPJ(GGNPNKPNBJP NFIEDJENJOM, EMBFCHHFKKK EHDMDEMFAJN, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x2024480", Offset = "0x2022A80", VA = "0x182024480")]
	[AsyncStateMachine(typeof(FMBLOIAFDJN))]
	public Task<MFFPLJBNNEB> JNJJCKGLCOA(GGNPNKPNBJP NFIEDJENJOM, EMBFCHHFKKK EHDMDEMFAJN, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x20242B0", Offset = "0x20228B0", VA = "0x1820242B0", Slot = "5")]
	public CCKBMPBIFMP JJKEHKDMJOC(MFFPLJBNNEB MCKCLGMKBJN, long FDEIGEELENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x20240C0", Offset = "0x20226C0", VA = "0x1820240C0")]
	private static CCKBMPBIFMP CNPEIIPBPOD(MFFPLJBNNEB MCKCLGMKBJN, long FDEIGEELENF, FHKCFJFJCGG MAPPDCFLNNM, FHKCFJFJCGG EIGJMLMDBAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x2023CC0", Offset = "0x20222C0", VA = "0x182023CC0")]
	private (FHKCFJFJCGG, FHKCFJFJCGG) AAKHCAOEFCD(MFFPLJBNNEB MCKCLGMKBJN, long FDEIGEELENF)
	{
		return default((FHKCFJFJCGG, FHKCFJFJCGG));
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2024050", Offset = "0x2022650", VA = "0x182024050")]
	private IDisposable ACHHAEMIKON(GGNPNKPNBJP NFIEDJENJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x20245E0", Offset = "0x2022BE0", VA = "0x1820245E0")]
	[AsyncStateMachine(typeof(FGHHLFGLIIK))]
	private Task<MFFPLJBNNEB> JNJJCKGLCOA(EMBFCHHFKKK EHDMDEMFAJN, bool GNPFONOAEGE, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public IHLNBHEAMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[Preserve]
internal sealed class IMANABIHFPN : EFOEHPJHIKG, LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class HAHNJBLNOEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HAHNJBLNOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x201E540", Offset = "0x201CB40", VA = "0x18201E540")]
		internal object <MasterSynchronizeRequest>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct DLALBGNLJHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public IMANABIHFPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public EGHNIDJHOFI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x201A050", Offset = "0x2018650", VA = "0x18201A050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x201A510", Offset = "0x2018B10", VA = "0x18201A510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct PIOOKBAECIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public IMANABIHFPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public EGHNIDJHOFI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private TaskAwaiter<MECONGMAEID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x202EAF0", Offset = "0x202D0F0", VA = "0x18202EAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x202F000", Offset = "0x202D600", VA = "0x18202F000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class KAIPGLDHGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KAIPGLDHGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x2027890", Offset = "0x2025E90", VA = "0x182027890")]
		internal object <MasterSyncRequestAndValidateResponse>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct ANMOCCPKDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public MGIOABMEIJD request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public IMANABIHFPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public EGHNIDJHOFI pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private DFCJOLGMEGB <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private NGDFFMAGHLP.NOPNOIPLHEL <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private TaskAwaiter<MECONGMAEID> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x20182D0", Offset = "0x20168D0", VA = "0x1820182D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x2018B90", Offset = "0x2017190", VA = "0x182018B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private DENAOPKHIGA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NGDFFMAGHLP EGOPBIEBKPL;

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x2025090", Offset = "0x2023690", VA = "0x182025090", Slot = "10")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x2025060", Offset = "0x2023660", VA = "0x182025060", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x2025060", Offset = "0x2023660", VA = "0x182025060", Slot = "5")]
	public void NFEMDFDACGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x2025100", Offset = "0x2023700", VA = "0x182025100", Slot = "4")]
	public void GPCBEJLMGEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x20252B0", Offset = "0x20238B0", VA = "0x1820252B0", Slot = "6")]
	[AsyncStateMachine(typeof(DLALBGNLJHI))]
	public Task<MGIOABMEIJD> MACCGALLMBN(MGIOABMEIJD DMFHFDFMIOL, EGHNIDJHOFI APNFPOCHBNH, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x2025400", Offset = "0x2023A00", VA = "0x182025400", Slot = "7")]
	[AsyncStateMachine(typeof(PIOOKBAECIO))]
	public Task<MGIOABMEIJD> NGMAIHDJAEM(CancellationToken CMOIBOJIACL, EGHNIDJHOFI APNFPOCHBNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x2025540", Offset = "0x2023B40", VA = "0x182025540", Slot = "8")]
	public GGNPNKPNBJP OHGCPADNCGF(CHMPEANIDIP LFHIBEECFAH, BJHOOGFBDGF OADNBMGMCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x20251B0", Offset = "0x20237B0", VA = "0x1820251B0", Slot = "9")]
	public GGNPNKPNBJP INCDKAONCCM(CHMPEANIDIP LFHIBEECFAH, BJHOOGFBDGF OADNBMGMCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x20255E0", Offset = "0x2023BE0", VA = "0x1820255E0")]
	[AsyncStateMachine(typeof(ANMOCCPKDDJ))]
	private Task<MGIOABMEIJD> PCEMDHKLBHO(MGIOABMEIJD DMFHFDFMIOL, EGHNIDJHOFI APNFPOCHBNH, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x20252A0", Offset = "0x20238A0", VA = "0x1820252A0")]
	private static byte[] LBKJNFGPJIK(MGIOABMEIJD EPAKPJCIEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2024F20", Offset = "0x2023520", VA = "0x182024F20")]
	private static string BJMOAPFNEGG(byte[] NOGDFKMIPHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public IMANABIHFPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[Preserve]
internal sealed class JNGIEBOADGC : DBGDBPBOCKE, LAPDICFBJJO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private CBAJIIEHOBG IGLLIMKPDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private DENAOPKHIGA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private NPJGAJPPJEI EMLBOAGIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private GDFPLOEAABF CFFBIJBFMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private BKIMFDNILBI JFAPPEGPHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private NCGJFCNJIOO CLLAFAPBEHJ;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x20272D0", Offset = "0x20258D0", VA = "0x1820272D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private static CPPGHHPEEKN GNGPOPNJAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x2027060", Offset = "0x2025660", VA = "0x182027060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x2027120", Offset = "0x2025720", VA = "0x182027120", Slot = "7")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x20276E0", Offset = "0x2025CE0", VA = "0x1820276E0", Slot = "4")]
	public CPPGHHPEEKN POEGNACDNEF(BMNAGFLMHFA ODCEJMGDBOO, LKDPLNJNDNN KAOJFOHCDAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x2027500", Offset = "0x2025B00", VA = "0x182027500", Slot = "5")]
	public CPPGHHPEEKN PJMODPBBIMD(BMNAGFLMHFA IJJLOMGHHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x2027320", Offset = "0x2025920", VA = "0x182027320", Slot = "6")]
	public CPPGHHPEEKN PIADHEJPLGD(BMNAGFLMHFA IJJLOMGHHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x20270C0", Offset = "0x20256C0", VA = "0x1820270C0")]
	private static CPPGHHPEEKN DKLBKDPCCFH(NPDLPDPNDEP GJHPLFKILIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public JNGIEBOADGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class NDNFDLJFGEO : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD80", Offset = "0x27DC380", VA = "0x1827DDD80")]
	public NDNFDLJFGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x875880", Offset = "0x873E80", VA = "0x180875880")]
	public NDNFDLJFGEO(string EPAKPJCIEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[Preserve]
internal sealed class GJHDBKCCHDJ : LIFHAIMINNH, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct FKFFPOHLFGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public GJHDBKCCHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public EDJOLKBGGON autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private BJHOOGFBDGF <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private GAAMEIHCBEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<CPPGHHPEEKN> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x20CA4E0", Offset = "0x20C8AE0", VA = "0x1820CA4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct CCLCIFDPCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public GJHDBKCCHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x20C4530", Offset = "0x20C2B30", VA = "0x1820C4530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct EHJCMALAJEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public GJHDBKCCHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x20C86D0", Offset = "0x20C6CD0", VA = "0x1820C86D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private struct AMNNGIDNGIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public GJHDBKCCHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x20C1680", Offset = "0x20BFC80", VA = "0x1820C1680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct NCHHMANLIFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public GJHDBKCCHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public TimeSpan delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x20D5F00", Offset = "0x20D4500", VA = "0x1820D5F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private struct OOKLOKKKNJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public GJHDBKCCHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public EDJOLKBGGON autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private BJHOOGFBDGF <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x20D70A0", Offset = "0x20D56A0", VA = "0x1820D70A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly TimeSpan OIOPNIGNPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private DENAOPKHIGA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private EFOEHPJHIKG DHEAIMCJPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private NPJGAJPPJEI EMLBOAGIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private NCGJFCNJIOO CLLAFAPBEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private CancellationTokenSource LFIMINOJPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private Task NNGMPODDBHL;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x20CD960", Offset = "0x20CBF60", VA = "0x1820CD960", Slot = "6")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x14346D0", Offset = "0x1432CD0", VA = "0x1814346D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x20CDAF0", Offset = "0x20CC0F0", VA = "0x1820CDAF0", Slot = "4")]
	[AsyncStateMachine(typeof(FKFFPOHLFGJ))]
	public Task ENHMJOINGNL(EDJOLKBGGON MEHKPGNHAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x20CD710", Offset = "0x20CBD10", VA = "0x1820CD710", Slot = "5")]
	[AsyncStateMachine(typeof(CCLCIFDPCHP))]
	public Task AKILKIIJDDF([Optional] CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x14346D0", Offset = "0x1432CD0", VA = "0x1814346D0")]
	public void ECPICEPLDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x20CDE50", Offset = "0x20CC450", VA = "0x1820CDE50")]
	private CKKGIAPKAHA LBPDEJAMFGM(EDJOLKBGGON MEHKPGNHAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x20CDD30", Offset = "0x20CC330", VA = "0x1820CDD30")]
	[AsyncStateMachine(typeof(EHJCMALAJEM))]
	private Task IGNGCILDDOL(NFJKCBJFLIE KJDKGIBIDOI, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x20CE0A0", Offset = "0x20CC6A0", VA = "0x1820CE0A0")]
	[AsyncStateMachine(typeof(AMNNGIDNGIO))]
	private Task LGHMNOAHKHM([Optional] CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x20CDC00", Offset = "0x20CC200", VA = "0x1820CDC00")]
	[AsyncStateMachine(typeof(NCHHMANLIFK))]
	private Task FOCLHOBCECB(TimeSpan AHOFCNMPEEI, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x20CE250", Offset = "0x20CC850", VA = "0x1820CE250")]
	private Task NNIBKCKNONA(EDJOLKBGGON MEHKPGNHAPF, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x20CD830", Offset = "0x20CBE30", VA = "0x1820CD830")]
	[AsyncStateMachine(typeof(OOKLOKKKNJL))]
	private Task BENJKKHMFKM(EDJOLKBGGON MEHKPGNHAPF, CancellationToken OLMBFPIKDDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x20CE1B0", Offset = "0x20CC7B0", VA = "0x1820CE1B0")]
	private bool LNGGKAEPACM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public GJHDBKCCHDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[Preserve]
internal class NIJJFHKHNBN : GDFPLOEAABF, LAPDICFBJJO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private struct IABIOLFBMCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public NIJJFHKHNBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private BJHOOGFBDGF <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x27D3070", Offset = "0x27D1670", VA = "0x1827D3070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private EMGABENEFNH GFPCCCLEKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private DBGDBPBOCKE BJBAJBCALDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private EFOEHPJHIKG DHEAIMCJPLD;

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x27DE1D0", Offset = "0x27DC7D0", VA = "0x1827DE1D0", Slot = "6")]
	public void EDEIJCODOEL(LBAEOCOFFMH EKJGDPCALOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x27DE1B0", Offset = "0x27DC7B0", VA = "0x1827DE1B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x27DE370", Offset = "0x27DC970", VA = "0x1827DE370", Slot = "5")]
	[AsyncStateMachine(typeof(IABIOLFBMCN))]
	public Task NPKNJNNANMG(string IOMEMFDDFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x27DE350", Offset = "0x27DC950", VA = "0x1827DE350", Slot = "4")]
	public CPPGHHPEEKN LNGGKAEPACM(BMNAGFLMHFA ODCEJMGDBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x27DE090", Offset = "0x27DC690", VA = "0x1827DE090")]
	private OBENOHLIHJD AJIFJGGHJME(string IOMEMFDDFKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public NIJJFHKHNBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class CPKECFGOCJH
{
	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x20C66D0", Offset = "0x20C4CD0", VA = "0x1820C66D0")]
	public static void AODGHAKEIMG(JIFIKNLDFOJ CDKHPKCDPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x20C6B50", Offset = "0x20C5150", VA = "0x1820C6B50")]
	internal static void JOPCJHKIFJJ(JIFIKNLDFOJ CDKHPKCDPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x20C6AB0", Offset = "0x20C50B0", VA = "0x1820C6AB0")]
	internal static void JHHCKAIFAOI(JIFIKNLDFOJ CDKHPKCDPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x20C6810", Offset = "0x20C4E10", VA = "0x1820C6810")]
	internal static void DFEGMICAOOF(JIFIKNLDFOJ CDKHPKCDPCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
internal class KFPAKJAKDGH : global::PFGCPLEFLPF<MGIOABMEIJD>
{
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class IAMNHBEEILE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public string op;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public MGIOABMEIJD message;

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IAMNHBEEILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x27D36E0", Offset = "0x27D1CE0", VA = "0x1827D36E0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public static readonly KFPAKJAKDGH NNHENCBEIJC;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private const string PKNCNODPPFA = "pl";

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x202A3B0", Offset = "0x20289B0", VA = "0x18202A3B0")]
	public ExitGames.Client.Photon.Hashtable DFIGKGIDJJK(MGIOABMEIJD EPAKPJCIEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x202A2A0", Offset = "0x20288A0", VA = "0x18202A2A0", Slot = "5")]
	protected override void DBBJBGCLDDF(MGIOABMEIJD EPAKPJCIEHE, IDictionary<object, object> OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x202A430", Offset = "0x2028A30", VA = "0x18202A430", Slot = "6")]
	public override MGIOABMEIJD IACEKGNLJIN(IDictionary<object, object> OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x202A5D0", Offset = "0x2028BD0", VA = "0x18202A5D0")]
	private static void NJMIDDMBIGP(string FBOMHNDEFMB, MGIOABMEIJD EPAKPJCIEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x202A7A0", Offset = "0x2028DA0", VA = "0x18202A7A0")]
	public KFPAKJAKDGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class KCJAPNKFPNF
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public static CPPGHHPEEKN GNGPOPNJAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x2027060", Offset = "0x2025660", VA = "0x182027060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x2028B90", Offset = "0x2027190", VA = "0x182028B90")]
	public static bool PFHFDHJFLCH(this CPPGHHPEEKN CGGJNNGHPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x20270C0", Offset = "0x20256C0", VA = "0x1820270C0")]
	public static CPPGHHPEEKN DKLBKDPCCFH(NPDLPDPNDEP FEKNJKHPFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x2028990", Offset = "0x2026F90", VA = "0x182028990")]
	public static CPPGHHPEEKN EDOBPNMMIDF(params CPPGHHPEEKN[] FCDFGMLJNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x2028990", Offset = "0x2026F90", VA = "0x182028990")]
	public static CPPGHHPEEKN EDOBPNMMIDF(IEnumerable<CPPGHHPEEKN> FCDFGMLJNDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x2028B00", Offset = "0x2027100", VA = "0x182028B00")]
	public static string KCOFNLJPKBA(this CPPGHHPEEKN AEOILPMENGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public abstract class BIBHCJOIOLN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public delegate CPPGHHPEEKN BECCJEJLJNI([NotNull] BMNAGFLMHFA DMKFFCCNPMP);

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class LNCANBECCLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public BMNAGFLMHFA photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LNCANBECCLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x20D39D0", Offset = "0x20D1FD0", VA = "0x1820D39D0")]
		internal CPPGHHPEEKN <Validate>b__0(BECCJEJLJNI v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	protected readonly HashSet<BECCJEJLJNI> BLBHEKILBOP;

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x20C2E10", Offset = "0x20C1410", VA = "0x1820C2E10")]
	public void KELBEGNDOEP(BECCJEJLJNI BKNNEBFINKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x20C2BC0", Offset = "0x20C11C0", VA = "0x1820C2BC0")]
	public void AGLPLFKAKDE(BECCJEJLJNI BKNNEBFINKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x20C2DC0", Offset = "0x20C13C0", VA = "0x1820C2DC0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x20C2C20", Offset = "0x20C1220", VA = "0x1820C2C20")]
	protected CPPGHHPEEKN DGKCIJNPHOG(BMNAGFLMHFA IJJLOMGHHAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x20C2E70", Offset = "0x20C1470", VA = "0x1820C2E70")]
	protected BIBHCJOIOLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class CBAJIIEHOBG : BIBHCJOIOLN
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class BKINAODHGNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CPPGHHPEEKN result;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BKINAODHGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x20C2FA0", Offset = "0x20C15A0", VA = "0x1820C2FA0")]
		internal object <CanPlayerReload>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x20C2E70", Offset = "0x20C1470", VA = "0x1820C2E70")]
	[Preserve]
	public CBAJIIEHOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x20C4390", Offset = "0x20C2990", VA = "0x1820C4390")]
	public CPPGHHPEEKN PDGNCEGLCDO(BMNAGFLMHFA IJJLOMGHHAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class EMGABENEFNH : BIBHCJOIOLN
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class HLPDNGJHHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public CPPGHHPEEKN result;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HLPDNGJHHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x20D1B40", Offset = "0x20D0140", VA = "0x1820D1B40")]
		internal object <CanPlayerSave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x20C2E70", Offset = "0x20C1470", VA = "0x1820C2E70")]
	[Preserve]
	public EMGABENEFNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x20C9080", Offset = "0x20C7680", VA = "0x1820C9080")]
	public CPPGHHPEEKN LNGGKAEPACM(BMNAGFLMHFA NKGBOFHOONN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum KKDFFHJICII
{
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	Misc,
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	LoadNewRoom,
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	ReloadRoom
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal static class MLKFKBAOBPC
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class HHDGAIFONEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HHDGAIFONEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x27D2AF0", Offset = "0x27D10F0", VA = "0x1827D2AF0")]
		internal object <PrintTimer>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public const string HBFNKFKHHCA = "START: ";

	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public const string CKBOFDCEAIE = "END: ";

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x27DB5F0", Offset = "0x27D9BF0", VA = "0x1827DB5F0")]
	public static BJHOOGFBDGF BJMGJKHHNMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x27DB500", Offset = "0x27D9B00", VA = "0x1827DB500")]
	private static void AOMOLNDKJCK(string MKDJIBNCKNC, GFOOEOAFMNK NJKJIAHPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x27DB850", Offset = "0x27D9E50", VA = "0x1827DB850")]
	private static void IMJEKCENPJM(string MKDJIBNCKNC, GFOOEOAFMNK NJKJIAHPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x27DB680", Offset = "0x27D9C80", VA = "0x1827DB680")]
	public static void BLENKBEADAM(BJHOOGFBDGF NJKJIAHPBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x27DB7B0", Offset = "0x27D9DB0", VA = "0x1827DB7B0")]
	public static string EOFHKCNONAM(MGIOABMEIJD COEEKAFJDHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal static class BBKFLDELKEO
{
	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x20C1AA0", Offset = "0x20C00A0", VA = "0x1820C1AA0")]
	public static void CABJLCLPNBA(this DENAOPKHIGA KKBKNLLLIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x20C1AB0", Offset = "0x20C00B0", VA = "0x1820C1AB0")]
	public static void DGCCJEIDHPG(this DENAOPKHIGA KKBKNLLLIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x20C1AC0", Offset = "0x20C00C0", VA = "0x1820C1AC0")]
	private static void OPGCDFLMNMB(this DENAOPKHIGA KKBKNLLLIDH, bool GINPFNCPCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class NMHAOFLMKEM : DCCBOMHGGLA, GKPGABPIHEL, BJOCHKNLABA, HNLPJCOGEMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private readonly GKPGABPIHEL LDKKLPNJKGH;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public BMNAGFLMHFA CAFOLMBDNFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x27DEA00", Offset = "0x27DD000", VA = "0x1827DEA00", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public int IKEOIODKOND
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x27DE9B0", Offset = "0x27DCFB0", VA = "0x1827DE9B0", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int IGLJFIBBOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x27DEA50", Offset = "0x27DD050", VA = "0x1827DEA50", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool MHGFNDMDMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x560FE0", Offset = "0x55F5E0", VA = "0x180560FE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event FNILABKJAAD LKAAAAKOAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x27DE490", Offset = "0x27DCA90", VA = "0x1827DE490", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x27DE7D0", Offset = "0x27DCDD0", VA = "0x1827DE7D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<BMNAGFLMHFA> IKKFFDIGJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x27DE730", Offset = "0x27DCD30", VA = "0x1827DE730", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x27DE910", Offset = "0x27DCF10", VA = "0x1827DE910", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action BEMKBDCJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x27DE670", Offset = "0x27DCC70", VA = "0x1827DE670", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x27DE530", Offset = "0x27DCB30", VA = "0x1827DE530", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0xA1E2A0", Offset = "0xA1C8A0", VA = "0x180A1E2A0")]
	public NMHAOFLMKEM(GKPGABPIHEL LDKKLPNJKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x27DE5D0", Offset = "0x27DCBD0", VA = "0x1827DE5D0", Slot = "6")]
	public bool DPKILGMNHDM(byte JPPKOANDKCC, ExitGames.Client.Photon.Hashtable CGMCHBCICFD, KLLALGMDGKB JMGDCMMPMFG, SendOptions HMKBHCDLDLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x27DE870", Offset = "0x27DCE70", VA = "0x1827DE870", Slot = "23")]
	public BMNAGFLMHFA KMKOKANDJKD(int NIOGAFLPMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x27DEAA0", Offset = "0x27DD0A0", VA = "0x1827DEAA0", Slot = "13")]
	public BMNAGFLMHFA MNCEMMOHGAL(int IELGLAPLPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "14")]
	public void DOGBECOGAKP(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "15")]
	public void IMBOEGBNFFN(object GJGFJFLAGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "16")]
	public void DLCINGGHECK(object GJGFJFLAGKH, bool OBEGOLCILLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0", Slot = "17")]
	private bool KGIAKJBANPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "18")]
	public void FGCMLKFLCGJ(StringBuilder BOMHKMINCKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x27DE710", Offset = "0x27DCD10", VA = "0x1827DE710", Slot = "19")]
	public bool IBFOBLIIOFI(bool NJNBKAHFDIA, out string IOBNDAKOHMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80")]
	public void KGOPDAFNLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xDE4320", Offset = "0xDE2920", VA = "0x180DE4320", Slot = "22")]
	public void DEBPHHGOOGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal struct AICDPLFHBFK
{
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public const string MJNBMODOGCD = "v_result";

	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public const string EDLDGKGGBMB = "oid";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private readonly IDictionary<object, object> OEELGPMNOPJ;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool PEKIMJGAHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA89580", Offset = "0xA87B80", VA = "0x180A89580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD90", Offset = "0x6A9390", VA = "0x1806AAD90")]
	public AICDPLFHBFK(IDictionary<object, object> OEELGPMNOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x20C0C80", Offset = "0x20BF280", VA = "0x1820C0C80")]
	public bool FAJLIHOMCIJ(out MGIOABMEIJD EPAKPJCIEHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x20C0F10", Offset = "0x20BF510", VA = "0x1820C0F10")]
	public Guid PKCKIHEJEDI()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x20C0D10", Offset = "0x20BF310", VA = "0x1820C0D10")]
	public CPPGHHPEEKN FNCLIFKEFHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x20C0E40", Offset = "0x20BF440", VA = "0x1820C0E40")]
	public static ExitGames.Client.Photon.Hashtable GPCBEJLMGEM(MGIOABMEIJD EPAKPJCIEHE, CPPGHHPEEKN CGGJNNGHPHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal static class JJFEGGOICPI
{
	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x2026A50", Offset = "0x2025050", VA = "0x182026A50")]
	public static string ADODKJEHCMO(this EMBFCHHFKKK DOPDFGFALCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x2026C30", Offset = "0x2025230", VA = "0x182026C30")]
	public static bool JNGNFOLEDOG(this EMBFCHHFKKK DOPDFGFALCE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal struct OEEDJMEOFMI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct BEFCKPMOFNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public OEEDJMEOFMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x27CD580", Offset = "0x27CBB80", VA = "0x1827CD580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private readonly Func<CancellationToken, List<Task>> GFIMJCFOMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private readonly CancellationTokenSource LJJFJBNCDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private bool ECMCAACONHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private Task IPFPIIBOBLL;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool PEKIMJGAHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x27DF400", Offset = "0x27DDA00", VA = "0x1827DF400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	internal Task ODGABBKNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x27DF430", Offset = "0x27DDA30", VA = "0x1827DF430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x27DF4B0", Offset = "0x27DDAB0", VA = "0x1827DF4B0")]
	public OEEDJMEOFMI(Func<CancellationToken, List<Task>> GFIMJCFOMOE, CancellationToken CMOIBOJIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x27DF2F0", Offset = "0x27DD8F0", VA = "0x1827DF2F0")]
	[AsyncStateMachine(typeof(BEFCKPMOFNI))]
	public Task JJIGPDKPOIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x27DF2A0", Offset = "0x27DD8A0", VA = "0x1827DF2A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class HLGNNAIFBEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly PAHOFPMCLLC GJEIGBLPJLC;

	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private const string FGELKGLAFBA = "RL_LastSetOperationState";

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private const string FMFHBFHLINB = "RL_LastLoadedRoomName";

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private const string BNAOOALCCMN = "RL_LastLoadedRoomId";

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private const string KAFMJADNPBJ = "RL_LastLoadedSubroomId";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private string AKGOPMLKDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private long? LEDCAICJCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private long? ACAJGKLJAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private KAFHGJDFGHD BFNBHILGMCH;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string NBCKHLHABBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public long MGEDDMKFFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x2021670", Offset = "0x201FC70", VA = "0x182021670")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public long NDLNLNJPDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x20216C0", Offset = "0x201FCC0", VA = "0x1820216C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KAFHGJDFGHD JMEFEJDKGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x687AD0", Offset = "0x6860D0", VA = "0x180687AD0")]
		get
		{
			return default(KAFHGJDFGHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x20214A0", Offset = "0x201FAA0", VA = "0x1820214A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x2021AB0", Offset = "0x20200B0", VA = "0x182021AB0")]
	[Preserve]
	public HLGNNAIFBEA([IOLMGJIHJFK(null)] PAHOFPMCLLC GJEIGBLPJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2021950", Offset = "0x201FF50", VA = "0x182021950")]
	private void NKEDGMKKCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x2021710", Offset = "0x201FD10", VA = "0x182021710")]
	public void NCHHFEMBHAM(long HEDMMBFEFLM, long FDEIGEELENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x2021580", Offset = "0x201FB80", VA = "0x182021580")]
	public void HHABGIHLCPB(string FDAIAAFAANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x2021260", Offset = "0x201F860", VA = "0x182021260")]
	public void CMEGEGMBOEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal class GGNPNKPNBJP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct CINAFKDKGHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public GGNPNKPNBJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public MGIOABMEIJD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private TaskAwaiter<IDBIFKBBCPL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x20C6070", Offset = "0x20C4670", VA = "0x1820C6070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x20C6460", Offset = "0x20C4A60", VA = "0x1820C6460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct BLLBNGHFKDH<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class FHNEOFFMNPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public MGIOABMEIJD roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FHNEOFFMNPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x20CA1F0", Offset = "0x20C87F0", VA = "0x1820CA1F0")]
		internal MGIOABMEIJD <MasterSendAllReceiveBufferedMessage>b__0(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct MFNNGLCIAKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public AsyncTaskMethodBuilder<IDBIFKBBCPL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public MGIOABMEIJD roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public GGNPNKPNBJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private DFCJOLGMEGB <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private TaskAwaiter<IDBIFKBBCPL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x20D4F30", Offset = "0x20D3530", VA = "0x1820D4F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x20D5500", Offset = "0x20D3B00", VA = "0x1820D5500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct AOLNJNNCHGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public GGNPNKPNBJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x20C17D0", Offset = "0x20BFDD0", VA = "0x1820C17D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class OCAAHDNMDDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public OCAAHDNMDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x20D6380", Offset = "0x20D4980", VA = "0x1820D6380")]
		internal object <ClearOperationSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class JADECJKEAKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public JADECJKEAKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x20D21A0", Offset = "0x20D07A0", VA = "0x1820D21A0")]
		internal object <ClearRoomLoadSlices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class BOJANAFHLDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BOJANAFHLDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x20C3640", Offset = "0x20C1C40", VA = "0x1820C3640")]
		internal object <StartRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class DPKMDPFOPKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public DPKMDPFOPKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x20C7B10", Offset = "0x20C6110", VA = "0x1820C7B10")]
		internal object <FinishRoomLoad>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class BOHACPEGKCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public GGNPNKPNBJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BOHACPEGKCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x20C33F0", Offset = "0x20C19F0", VA = "0x1820C33F0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class FLMAOBEHOCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public Func<string> stepMessageGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public GGNPNKPNBJP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FLMAOBEHOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x20CA9C0", Offset = "0x20C8FC0", VA = "0x1820CA9C0")]
		internal object <Log>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static readonly Guid LLBELKFAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	[NotNull]
	public readonly BJHOOGFBDGF PJLFLGPINLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public readonly CHMPEANIDIP CPKMDDKIKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private readonly NGDFFMAGHLP EGOPBIEBKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly BJOCHKNLABA KKBKNLLLIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private readonly HNLPJCOGEMP EGIINNPOGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private bool FEHJCBNPFEL;

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x20CD4F0", Offset = "0x20CBAF0", VA = "0x1820CD4F0")]
	public GGNPNKPNBJP(CHMPEANIDIP ADCHCDBFMEI, NGDFFMAGHLP EGOPBIEBKPL, BJOCHKNLABA KKBKNLLLIDH, HNLPJCOGEMP EGIINNPOGHI, BJHOOGFBDGF OADNBMGMCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x20CC2F0", Offset = "0x20CA8F0", VA = "0x1820CC2F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x20CC870", Offset = "0x20CAE70", VA = "0x1820CC870")]
	public void IHACDKMLJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x20CCD20", Offset = "0x20CB320", VA = "0x1820CCD20")]
	public void LMCCNMGLECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x20CC080", Offset = "0x20CA680", VA = "0x1820CC080")]
	public void CMNNOEHHBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x20CC1B0", Offset = "0x20CA7B0", VA = "0x1820CC1B0")]
	[AsyncStateMachine(typeof(CINAFKDKGHB))]
	internal Task<MGIOABMEIJD> DKFMDPGMJOL(MGIOABMEIJD COEEKAFJDHO, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x20252A0", Offset = "0x20238A0", VA = "0x1820252A0")]
	private static byte[] ABENPBOHFLA<T>(T EPAKPJCIEHE) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x1E19990", Offset = "0x1E17F90", VA = "0x181E19990")]
	private static T HPIAHLJMEFP<T>(MessageParser<T> DIGMCLJIAJO, byte[] EPAKPJCIEHE, T JNHAOKCIHCO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x20CCBE0", Offset = "0x20CB1E0", VA = "0x1820CCBE0")]
	[AsyncStateMachine(typeof(MFNNGLCIAKI))]
	private Task<IDBIFKBBCPL> LKLLMJIHFAB(MGIOABMEIJD COEEKAFJDHO, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x2642F30", Offset = "0x2641530", VA = "0x182642F30")]
	[AsyncStateMachine(typeof(HONIBOJDPKK))]
	internal Task<T> NPHEFCIJOJA<T>(CancellationToken OLMBFPIKDDC, Func<CancellationToken, Task<T>> PAGPDEJKFHI, int GODGKECEJNK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x20CD1F0", Offset = "0x20CB7F0", VA = "0x1820CD1F0")]
	[AsyncStateMachine(typeof(AOLNJNNCHGC))]
	internal Task NPHEFCIJOJA(CancellationToken OLMBFPIKDDC, Func<CancellationToken, Task> PAGPDEJKFHI, int GODGKECEJNK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x20CC9F0", Offset = "0x20CAFF0", VA = "0x1820CC9F0")]
	public MGIOABMEIJD IMEOBJBCNDM(DFCJOLGMEGB NFADPBJMIOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x20CC7B0", Offset = "0x20CADB0", VA = "0x1820CC7B0")]
	public ICJCIBIPCHI HCDGMACBOMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x20CC010", Offset = "0x20CA610", VA = "0x1820CC010")]
	public KGCENPHPNIK CLDNNFOBAFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x20CD340", Offset = "0x20CB940", VA = "0x1820CD340")]
	public FNEKJEOLODJ PBLCEPJNPAA([Optional] FKAJGIIFNDN? HODHPEJLAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x20CBFA0", Offset = "0x20CA5A0", VA = "0x1820CBFA0")]
	public MFAIIMMIJHA ALJNCPFPGEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x20CD460", Offset = "0x20CBA60", VA = "0x1820CD460")]
	public void PLCNFKICKAK(Func<Guid, bool> CJHEFBNLMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x20CC630", Offset = "0x20CAC30", VA = "0x1820CC630")]
	public void GBIMCLCCFGD(Func<Guid, bool> IFPIOLMDIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x20CC4D0", Offset = "0x20CAAD0", VA = "0x1820CC4D0")]
	public void FNDNPCCBLCM(Func<Guid, bool> CJHEFBNLMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x20CC300", Offset = "0x20CA900", VA = "0x1820CC300")]
	public Guid ENNCOMDPKFE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x20CCA80", Offset = "0x20CB080", VA = "0x1820CCA80")]
	public void KGNPHEDKCGG(Guid BKNBDDFONFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x20CCE40", Offset = "0x20CB440", VA = "0x1820CCE40")]
	public void MEAGHLCEBNI(MGIOABMEIJD CHMPCMOJNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x20CD0A0", Offset = "0x20CB6A0", VA = "0x1820CD0A0")]
	public void NJMIDDMBIGP(string JPLGDICDHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x20CCF50", Offset = "0x20CB550", VA = "0x1820CCF50")]
	public void NJMIDDMBIGP(Func<string> IPIKANFCHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x1E19910", Offset = "0x1E17F10", VA = "0x181E19910")]
	private T CKPNAPHOGPO<T>(T MPHFKGJNMOK) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x20CC820", Offset = "0x20CAE20", VA = "0x1820CC820")]
	public void IADIJDKBIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x2643230", Offset = "0x2641830", VA = "0x182643230")]
	[CompilerGenerated]
	internal static string PNGEJFHJGHP<T>(byte[] KFCJKMJDFKE, int BCEJADOJHAO, ref BLLBNGHFKDH<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal sealed class IFBGHICIPII : CHMPEANIDIP
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class IDLPPHLDION
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IDLPPHLDION()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2023130", Offset = "0x2021730", VA = "0x182023130")]
		internal object <.ctor>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct CDHPGOPNKCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public IFBGHICIPII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private KPADKAHKOCL <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private CCKBMPBIFMP <request>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private KGCENPHPNIK <loadLogic>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<CCKBMPBIFMP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2019940", Offset = "0x2017F40", VA = "0x182019940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class GLCJGEIDMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public KPADKAHKOCL presence;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GLCJGEIDMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x201D8D0", Offset = "0x201BED0", VA = "0x18201D8D0")]
		internal object <GetLocalPlayerPresence>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private readonly EMBFCHHFKKK MJPGIBDJKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private readonly KADLIJAOKIC JMDKLAKMJDF;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private const bool HHKOMKBBKBD = false;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x20238A0", Offset = "0x2021EA0", VA = "0x1820238A0")]
	public IFBGHICIPII(EMBFCHHFKKK MJPGIBDJKEA, Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, EGHNIDJHOFI NFOIFJNJHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x2023770", Offset = "0x2021D70", VA = "0x182023770", Slot = "5")]
	[AsyncStateMachine(typeof(CDHPGOPNKCN))]
	protected override Task PNJEBLDFEOI(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x2023190", Offset = "0x2021790", VA = "0x182023190")]
	private Task<CCKBMPBIFMP> BBPMCGCIHBJ(GGNPNKPNBJP NFIEDJENJOM, KPADKAHKOCL MKGLNGCOFDP, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x2023450", Offset = "0x2021A50", VA = "0x182023450")]
	private KPADKAHKOCL MEDCBGCNNOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x2023280", Offset = "0x2021880", VA = "0x182023280")]
	private void BIOIHIIANHI(KPADKAHKOCL GELLBNLBLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x20233C0", Offset = "0x20219C0", VA = "0x1820233C0")]
	private static void LHHFGNNAGLB(EMBFCHHFKKK DOPDFGFALCE, [Optional] string EPAKPJCIEHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal class CKKGIAPKAHA : CHMPEANIDIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct GNHBIDFCLME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public CKKGIAPKAHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private TaskAwaiter<MFFPLJBNNEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x20CE540", Offset = "0x20CCB40", VA = "0x1820CE540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly int IJNOHEMGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly EDJOLKBGGON MEHKPGNHAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public readonly long EIJPKAGKCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public readonly long IFHJHLAIOIM;

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x20C65D0", Offset = "0x20C4BD0", VA = "0x1820C65D0")]
	public CKKGIAPKAHA(Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, EGHNIDJHOFI NFOIFJNJHKG, int IJNOHEMGFMP, EDJOLKBGGON MEHKPGNHAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x20C64B0", Offset = "0x20C4AB0", VA = "0x1820C64B0", Slot = "5")]
	[AsyncStateMachine(typeof(GNHBIDFCLME))]
	protected override Task PNJEBLDFEOI(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
internal abstract class GPOIOGNAELG : CHMPEANIDIP
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class FIPANAENBCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public GPOIOGNAELG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public OBGPNEKGDBK playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FIPANAENBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x20CA2E0", Offset = "0x20C88E0", VA = "0x1820CA2E0")]
		internal Task <RunAsync>b__0(BJHOOGFBDGF postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x20CA320", Offset = "0x20C8920", VA = "0x1820CA320")]
		internal object <RunAsync>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct LOFMPMFLEIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public GPOIOGNAELG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private FIPANAENBCG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x20D3A00", Offset = "0x20D2000", VA = "0x1820D3A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct ECIOMIKFNLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public OBGPNEKGDBK playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public GPOIOGNAELG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x20C7B70", Offset = "0x20C6170", VA = "0x1820C7B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x20CEB10", Offset = "0x20CD110", VA = "0x1820CEB10")]
	public GPOIOGNAELG(Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, EGHNIDJHOFI NFOIFJNJHKG, string JKGKADKONEJ, bool LKEIGKCPOLA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x20CE9E0", Offset = "0x20CCFE0", VA = "0x1820CE9E0", Slot = "5")]
	[AsyncStateMachine(typeof(LOFMPMFLEIL))]
	protected override Task PNJEBLDFEOI(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract Task LJEKCHDKHPO(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x20CE8A0", Offset = "0x20CCEA0", VA = "0x1820CE8A0")]
	[AsyncStateMachine(typeof(ECIOMIKFNLA))]
	private Task NMEAAEPIIDA(IDisposable BCBAFAOJCGL, OBGPNEKGDBK LBDDFKKNIBG, BJHOOGFBDGF NJKJIAHPBGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
internal class DOPCGJPOHDD : CHMPEANIDIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct MNBCILIDFGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public DOPCGJPOHDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private MFAIIMMIJHA <autosaveLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private TaskAwaiter<HEPPHFAIPIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x20D5550", Offset = "0x20D3B50", VA = "0x1820D5550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly EDJOLKBGGON MEHKPGNHAPF;

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x20C7A40", Offset = "0x20C6040", VA = "0x1820C7A40")]
	public DOPCGJPOHDD(Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, EGHNIDJHOFI NFOIFJNJHKG, EDJOLKBGGON MEHKPGNHAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x20C7830", Offset = "0x20C5E30", VA = "0x1820C7830", Slot = "4")]
	protected override string GFOKHNLJCHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x20C7900", Offset = "0x20C5F00", VA = "0x1820C7900", Slot = "5")]
	[AsyncStateMachine(typeof(MNBCILIDFGH))]
	protected override Task PNJEBLDFEOI(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
internal abstract class CHMPEANIDIP
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public delegate Task ICCKMBNICLL(BJHOOGFBDGF OADNBMGMCGO, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class MEOAIFJPJKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public CHMPEANIDIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public BJHOOGFBDGF stackTimer;

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public MEOAIFJPJKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x20D4CF0", Offset = "0x20D32F0", VA = "0x1820D4CF0")]
		internal Task <Run>b__0(CancellationToken t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x20D4DE0", Offset = "0x20D33E0", VA = "0x1820D4DE0")]
		internal Task <Run>b__1(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class BIILMKENOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public MEOAIFJPJKH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BIILMKENOMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x20C2EE0", Offset = "0x20C14E0", VA = "0x1820C2EE0")]
		internal object <Run>b__2()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct OKDBDKMELKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public CHMPEANIDIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public BJHOOGFBDGF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Func<CHMPEANIDIP, BJHOOGFBDGF, GGNPNKPNBJP> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private MEOAIFJPJKH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private GGNPNKPNBJP <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private TaskAwaiter<MGIOABMEIJD> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x20D64D0", Offset = "0x20D4AD0", VA = "0x1820D64D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct DGIJFDGKLOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public CHMPEANIDIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public BJHOOGFBDGF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x20C6EA0", Offset = "0x20C54A0", VA = "0x1820C6EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	public readonly Guid NLEIGEHHPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	public readonly ByteString IFNJDIHEIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	public readonly EGHNIDJHOFI KOFMLGHBKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	protected readonly string JOJNOHGFOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private readonly LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private readonly bool LKEIGKCPOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private bool NMGMGDNBCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public KAFHGJDFGHD ANOOIAFHOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public KAFHGJDFGHD LCCBLIDBFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private readonly Queue<ICCKMBNICLL> AJGIFKDHDNI;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public LBAEOCOFFMH HLFCOLEHOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x561010", Offset = "0x55F610", VA = "0x180561010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x20C5B00", Offset = "0x20C4100", VA = "0x1820C5B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x20C5C10", Offset = "0x20C4210", VA = "0x1820C5C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x20C5F70", Offset = "0x20C4570", VA = "0x1820C5F70")]
	protected CHMPEANIDIP(Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, EGHNIDJHOFI NFOIFJNJHKG, string JKGKADKONEJ, bool LKEIGKCPOLA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x20C5B50", Offset = "0x20C4150", VA = "0x1820C5B50", Slot = "4")]
	protected virtual string GFOKHNLJCHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x20C5F10", Offset = "0x20C4510", VA = "0x1820C5F10")]
	public void OOEGFKNECBH(ICCKMBNICLL KDEKMKDFDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x20C5C90", Offset = "0x20C4290", VA = "0x1820C5C90")]
	[AsyncStateMachine(typeof(OKDBDKMELKH))]
	public Task OBHHENOOAOJ(CancellationToken CMOIBOJIACL, BJHOOGFBDGF OADNBMGMCGO, [Optional] Func<CHMPEANIDIP, BJHOOGFBDGF, GGNPNKPNBJP> MIMOPOFKHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract Task PNJEBLDFEOI(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x20C5DD0", Offset = "0x20C43D0", VA = "0x1820C5DD0")]
	[AsyncStateMachine(typeof(DGIJFDGKLOD))]
	private Task OFAOFIFHJIE(BJHOOGFBDGF OADNBMGMCGO, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x20C5B90", Offset = "0x20C4190", VA = "0x1820C5B90")]
	public MGIOABMEIJD IMEOBJBCNDM(DFCJOLGMEGB NFADPBJMIOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal sealed class IGPECEBOAAB : GPOIOGNAELG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct IPEBDAMGLCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public IGPECEBOAAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private ALDIJJBBMNI <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x2025730", Offset = "0x2023D30", VA = "0x182025730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	private readonly CCKBMPBIFMP LEJAEHGCHFP;

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2023C20", Offset = "0x2022220", VA = "0x182023C20")]
	public IGPECEBOAAB(Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, CCKBMPBIFMP LEJAEHGCHFP, EGHNIDJHOFI NFOIFJNJHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2023AF0", Offset = "0x20220F0", VA = "0x182023AF0", Slot = "6")]
	[AsyncStateMachine(typeof(IPEBDAMGLCH))]
	protected override Task LJEKCHDKHPO(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal class OBENOHLIHJD : CHMPEANIDIP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private struct DICKPODNPLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public OBENOHLIHJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter<HEPPHFAIPIK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x27CFE90", Offset = "0x27CE490", VA = "0x1827CFE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private readonly string MLOGMCKPFBO;

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x27DECA0", Offset = "0x27DD2A0", VA = "0x1827DECA0")]
	public OBENOHLIHJD(Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, EGHNIDJHOFI NFOIFJNJHKG, string MLOGMCKPFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x27DEB70", Offset = "0x27DD170", VA = "0x1827DEB70", Slot = "5")]
	[AsyncStateMachine(typeof(DICKPODNPLG))]
	protected override Task PNJEBLDFEOI(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class HPAPEFLGLDP : GPOIOGNAELG
{
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class KKNAACBIEOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public KKNAACBIEOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			private TaskAwaiter<HEPPHFAIPIK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			private TaskAwaiter<MGIOABMEIJD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x202F100", Offset = "0x202D700", VA = "0x18202F100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x202F580", Offset = "0x202DB80", VA = "0x18202F580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public HPAPEFLGLDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public FNEKJEOLODJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public ICJCIBIPCHI uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public long superRoomId;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KKNAACBIEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x202ACD0", Offset = "0x20292D0", VA = "0x18202ACD0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<MGIOABMEIJD> <RunWhilePlayerDespawnedAsync>b__0(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[CompilerGenerated]
	private struct NDBNNBBHKJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public HPAPEFLGLDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private KKNAACBIEOM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private ALDIJJBBMNI <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private KGCENPHPNIK <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x202CDC0", Offset = "0x202B3C0", VA = "0x18202CDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	private readonly int AECIIDFCKEL;

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2021F80", Offset = "0x2020580", VA = "0x182021F80")]
	public HPAPEFLGLDP(Guid KOKPBCLAFDC, LBAEOCOFFMH EKJGDPCALOO, int AECIIDFCKEL, EGHNIDJHOFI NFOIFJNJHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2021E50", Offset = "0x2020450", VA = "0x182021E50", Slot = "6")]
	[AsyncStateMachine(typeof(NDBNNBBHKJK))]
	protected override Task LJEKCHDKHPO(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2021BA0", Offset = "0x20201A0", VA = "0x182021BA0")]
	private void DLFHOLJKNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2021C70", Offset = "0x2020270", VA = "0x182021C70")]
	private void GIGPNKPLJOJ(GGNPNKPNBJP NFIEDJENJOM, ALDIJJBBMNI GMPOPNLDAJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal abstract class BMDLADBLEED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	public readonly CHMPEANIDIP CPKMDDKIKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	public readonly GGNPNKPNBJP MBIHADHHLMN;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x20C2FF0", Offset = "0x20C15F0", VA = "0x1820C2FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x20C3040", Offset = "0x20C1640", VA = "0x1820C3040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x20C3390", Offset = "0x20C1990", VA = "0x1820C3390")]
	protected BMDLADBLEED(GGNPNKPNBJP NFIEDJENJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x20C3230", Offset = "0x20C1830", VA = "0x1820C3230")]
	protected void NJMIDDMBIGP(string JPLGDICDHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x20C30D0", Offset = "0x20C16D0", VA = "0x1820C30D0")]
	public void NJMIDDMBIGP(Func<string> IPIKANFCHLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal struct AEEHLJHIJAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	public Dictionary<Guid, List<AGDOILEGODC>> EHBCIGNCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	public Dictionary<Guid, List<AGDOILEGODC>> PBOHJLBFDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	public Dictionary<Guid, List<AGDOILEGODC>> FENKANAEJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	public List<Guid> PELHIPBCGMO;

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x20C0160", Offset = "0x20BE760", VA = "0x1820C0160")]
	public static AEEHLJHIJAH NELNIMGBJDL(FNMMNHKHMCA PJEAKFPHIGK, KAFHGJDFGHD HLCHOHDONJN)
	{
		return default(AEEHLJHIJAH);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct PPANMJPKAMB
{
	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0")]
	public static PPANMJPKAMB GPCBEJLMGEM()
	{
		return default(PPANMJPKAMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void GGEECGMOIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void CHKJGMLKHDA(NFJKCBJFLIE OGNHKENMEGF, object CPAFMGHNGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80")]
	[Conditional("LOG_ROOM_LOAD_METRICS")]
	public void JAOEHNIGLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct NGIPHJDGCJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	public readonly MFFPLJBNNEB DLHDHECGKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	public readonly DBPKBOFJDFM FCEKFDHGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	public readonly EDENBEBPCEL HLLENNLJMEE;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x27AACD0", Offset = "0x27A92D0", VA = "0x1827AACD0")]
	public NGIPHJDGCJG(MFFPLJBNNEB DLHDHECGKLB, DBPKBOFJDFM FCEKFDHGNEB, EDENBEBPCEL HLLENNLJMEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct EGAFJJBHGIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private readonly GGNPNKPNBJP NFIEDJENJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly Guid BKNBDDFONFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private bool GBEJONPLCGE;

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x20C8130", Offset = "0x20C6730", VA = "0x1820C8130")]
	public static EGAFJJBHGIG ENNCOMDPKFE(GGNPNKPNBJP NFIEDJENJOM)
	{
		return default(EGAFJJBHGIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0xD525B0", Offset = "0xD50BB0", VA = "0x180D525B0")]
	public void EFOLLODHOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x20C8120", Offset = "0x20C6720", VA = "0x1820C8120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x20C84E0", Offset = "0x20C6AE0", VA = "0x1820C84E0")]
	private EGAFJJBHGIG(GGNPNKPNBJP NFIEDJENJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x20C8160", Offset = "0x20C6760", VA = "0x1820C8160")]
	private void KGNPHEDKCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x20C8430", Offset = "0x20C6A30", VA = "0x1820C8430")]
	private Func<Guid, bool> KMILHOMCDLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal class KGCENPHPNIK : BMDLADBLEED
{
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public delegate Task<KAFHGJDFGHD> GNJKIIAEAHM(NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA FIDMBEPOHII, CancellationToken CMOIBOJIACL);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct OHLENEBJIIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public CCKBMPBIFMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private EGAFJJBHGIG <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x27E0B10", Offset = "0x27DF110", VA = "0x1827E0B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct PBNHOMIPJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public CCKBMPBIFMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x27E2BE0", Offset = "0x27E11E0", VA = "0x1827E2BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x27E2EB0", Offset = "0x27E14B0", VA = "0x1827E2EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct HBJLFEMLAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public CCKBMPBIFMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x27D2730", Offset = "0x27D0D30", VA = "0x1827D2730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct CGGJDHHOANF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public CCKBMPBIFMP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private NFJKCBJFLIE <phaseArgs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter<NGIPHJDGCJG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<NFJKCBJFLIE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private ALPGBDAJPMA <timedYielder>5__3;

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x27CEC40", Offset = "0x27CD240", VA = "0x1827CEC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct PBADGCIJNFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public BJHOOGFBDGF timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x27E2630", Offset = "0x27E0C30", VA = "0x1827E2630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct FDNMCDLFHJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x27D0710", Offset = "0x27CED10", VA = "0x1827D0710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private struct FPAMFOKCPOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private BFPJFBMGGAN.PBKOBDLIDOL <mapping>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private TaskAwaiter<BFPJFBMGGAN.PBKOBDLIDOL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x27D1120", Offset = "0x27CF720", VA = "0x1827D1120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x27D1CD0", Offset = "0x27D02D0", VA = "0x1827D1CD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct AAFLJDGLEBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public ALPGBDAJPMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x27CC820", Offset = "0x27CAE20", VA = "0x1827CC820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x27CD430", Offset = "0x27CBA30", VA = "0x1827CD430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct JLIJCIJKFMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public KAFHGJDFGHD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x27D4800", Offset = "0x27D2E00", VA = "0x1827D4800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x27D4980", Offset = "0x27D2F80", VA = "0x1827D4980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct LOMCNBLOHEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public KAFHGJDFGHD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x27D8CF0", Offset = "0x27D72F0", VA = "0x1827D8CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x27D8E70", Offset = "0x27D7470", VA = "0x1827D8E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class AKDBPOLPHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public GNJKIIAEAHM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public ALPGBDAJPMA timedYielder;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public AKDBPOLPHLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class FDCKNDFHOBI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public FDCKNDFHOBI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			private TaskAwaiter<KAFHGJDFGHD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x27E3CA0", Offset = "0x27E22A0", VA = "0x1827E3CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x27E4260", Offset = "0x27E2860", VA = "0x1827E4260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public KAFHGJDFGHD originalRoomLoadPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AKDBPOLPHLL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FDCKNDFHOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x27D05E0", Offset = "0x27CEBE0", VA = "0x1827D05E0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<KAFHGJDFGHD> <MasterLockedPhaseChangeBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct FHKHNCOBMEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public GNJKIIAEAHM masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public ALPGBDAJPMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x27D0CD0", Offset = "0x27CF2D0", VA = "0x1827D0CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x27D10D0", Offset = "0x27CF6D0", VA = "0x1827D10D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct ODKGLIANPHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private KAFHGJDFGHD <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private IEnumerator<KAFHGJDFGHD> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x27DED40", Offset = "0x27DD340", VA = "0x1827DED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct EJLMHJONHIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x27D03A0", Offset = "0x27CE9A0", VA = "0x1827D03A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct CDPODFHPPLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x27CE760", Offset = "0x27CCD60", VA = "0x1827CE760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct GNKPAJPLHGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AsyncTaskMethodBuilder<BFPJFBMGGAN.PBKOBDLIDOL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public KGCENPHPNIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private TaskAwaiter<BFPJFBMGGAN.PBKOBDLIDOL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x27D2270", Offset = "0x27D0870", VA = "0x1827D2270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x27D2400", Offset = "0x27D0A00", VA = "0x1827D2400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class IALGIDMOIMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public MFFPLJBNNEB roomDetails;

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IALGIDMOIMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x27D3470", Offset = "0x27D1A70", VA = "0x1827D3470")]
		internal object <LogRoomDetails>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly KCOJKHFGNGK DCICCPPIJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly KCOJKHFGNGK JAMMHMOKAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly HLGNNAIFBEA BGONODDGIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly KHNMPHEGJAF NPMAHHAJFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private readonly HLBCDEEKLCF DGGJANNCNGG;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private BJHOOGFBDGF EDLAIOGHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x650890", Offset = "0x64EE90", VA = "0x180650890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private LBAEOCOFFMH HLFCOLEHOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2022A60", Offset = "0x2021060", VA = "0x182022A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x27D6830", Offset = "0x27D4E30", VA = "0x1827D6830")]
	public KGCENPHPNIK(GGNPNKPNBJP NFIEDJENJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x27D57E0", Offset = "0x27D3DE0", VA = "0x1827D57E0")]
	[AsyncStateMachine(typeof(OHLENEBJIIA))]
	public Task FOBNPNLDBIH(CCKBMPBIFMP DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x27D66F0", Offset = "0x27D4CF0", VA = "0x1827D66F0")]
	[AsyncStateMachine(typeof(PBNHOMIPJKH))]
	private Task<MGIOABMEIJD> PMALIILNFKC(CCKBMPBIFMP DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x27D65B0", Offset = "0x27D4BB0", VA = "0x1827D65B0")]
	[AsyncStateMachine(typeof(HBJLFEMLAGI))]
	private Task PLAMCKLHDCK(CCKBMPBIFMP DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x27D5AA0", Offset = "0x27D40A0", VA = "0x1827D5AA0")]
	[AsyncStateMachine(typeof(CGGJDHHOANF))]
	private Task JBOPMKJEMHL(CCKBMPBIFMP DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x27D5480", Offset = "0x27D3A80", VA = "0x1827D5480")]
	[AsyncStateMachine(typeof(PBADGCIJNFF))]
	private Task EAGJCHNHBJE(BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x27D6140", Offset = "0x27D4740", VA = "0x1827D6140")]
	[AsyncStateMachine(typeof(FDNMCDLFHJA))]
	private Task MMLHEGLPGDE(NFJKCBJFLIE OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x27D5250", Offset = "0x27D3850", VA = "0x1827D5250")]
	[AsyncStateMachine(typeof(FPAMFOKCPOI))]
	private Task<KAFHGJDFGHD> BIOJLDILJMF(NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x27D5910", Offset = "0x27D3F10", VA = "0x1827D5910")]
	[AsyncStateMachine(typeof(AAFLJDGLEBO))]
	private Task<KAFHGJDFGHD> GPCENAEINJK(NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x27D5BD0", Offset = "0x27D41D0", VA = "0x1827D5BD0")]
	[AsyncStateMachine(typeof(JLIJCIJKFMD))]
	private Task<KAFHGJDFGHD> JHNBIFEADKL(KAFHGJDFGHD HLCHOHDONJN, bool JNOOGNMEBHC, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x27D5D10", Offset = "0x27D4310", VA = "0x1827D5D10")]
	[AsyncStateMachine(typeof(LOMCNBLOHEJ))]
	private Task<KAFHGJDFGHD> JHNBIFEADKL(KAFHGJDFGHD HLCHOHDONJN, bool JNOOGNMEBHC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x27D64C0", Offset = "0x27D4AC0", VA = "0x1827D64C0")]
	private bool PBJAJJGJLEO(NFJKCBJFLIE HBOCEGKJDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x27D5FC0", Offset = "0x27D45C0", VA = "0x1827D5FC0")]
	[AsyncStateMachine(typeof(FHKHNCOBMEP))]
	protected Task<KAFHGJDFGHD> LEEHNDICNEH(NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL, GNJKIIAEAHM KEAMJPJBHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x27D55B0", Offset = "0x27D3BB0", VA = "0x1827D55B0")]
	[AsyncStateMachine(typeof(ODKGLIANPHP))]
	private Task EICBKMHJHDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x27D4F20", Offset = "0x27D3520", VA = "0x1827D4F20")]
	[AsyncStateMachine(typeof(EJLMHJONHIC))]
	private Task AAFDLGEEHBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x27D5050", Offset = "0x27D3650", VA = "0x1827D5050")]
	private Task<NGIPHJDGCJG> AOJKPOIIEMN(CCKBMPBIFMP DMFHFDFMIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x27D5E40", Offset = "0x27D4440", VA = "0x1827D5E40")]
	private Task<NFJKCBJFLIE> KNLFADFFFJO(CCKBMPBIFMP DMFHFDFMIOL, NGIPHJDGCJG OGNHKENMEGF, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x27D56B0", Offset = "0x27D3CB0", VA = "0x1827D56B0")]
	[AsyncStateMachine(typeof(CDPODFHPPLI))]
	private Task ELDMAACAAON(NFJKCBJFLIE OGNHKENMEGF, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x27D6390", Offset = "0x27D4990", VA = "0x1827D6390")]
	[AsyncStateMachine(typeof(GNKPAJPLHGJ))]
	private Task<BFPJFBMGGAN.PBKOBDLIDOL> NJEIBHHMANI(NFJKCBJFLIE OGNHKENMEGF, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x27D5220", Offset = "0x27D3820", VA = "0x1827D5220")]
	private Task AOMNHJONENC(NFJKCBJFLIE OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x27D5A80", Offset = "0x27D4080", VA = "0x1827D5A80")]
	private Task IGNDDDDGBCI(NFJKCBJFLIE OGNHKENMEGF, BFPJFBMGGAN.PBKOBDLIDOL EIJFPCHDIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x27D4F00", Offset = "0x27D3500", VA = "0x1827D4F00")]
	private Task AACCNPOKIGF(NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x27D5A60", Offset = "0x27D4060", VA = "0x1827D5A60")]
	private Task HEICGHCDJDC(NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x27D5390", Offset = "0x27D3990", VA = "0x1827D5390")]
	private static Task DEMMBPKAEMA(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x27D6120", Offset = "0x27D4720", VA = "0x1827D6120")]
	private Task MMGENBPFNIF(NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x27D5E90", Offset = "0x27D4490", VA = "0x1827D5E90")]
	private Task LAAHDGMCEDJ(NFJKCBJFLIE OGNHKENMEGF, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x27D5020", Offset = "0x27D3620", VA = "0x1827D5020")]
	private void AAGJEJBGMDF(CCKBMPBIFMP DMFHFDFMIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x27D6260", Offset = "0x27D4860", VA = "0x1827D6260")]
	private static void NCAGJENKIFP(MFFPLJBNNEB DLHDHECGKLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
internal struct BFPJFBMGGAN
{
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public struct PBKOBDLIDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public readonly Dictionary<int, int> DLDILJHGHJH;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD90", Offset = "0x6A9390", VA = "0x1806AAD90")]
		public PBKOBDLIDOL(Dictionary<int, int> DLDILJHGHJH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private KAFHGJDFGHD EFBOFPJOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private NFJKCBJFLIE OGNHKENMEGF;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x20C27A0", Offset = "0x20C0DA0", VA = "0x1820C27A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x20C27F0", Offset = "0x20C0DF0", VA = "0x1820C27F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x20C2870", Offset = "0x20C0E70", VA = "0x1820C2870")]
	public static Task<PBKOBDLIDOL> OBHHENOOAOJ(LBAEOCOFFMH EKJGDPCALOO, KAFHGJDFGHD EFBOFPJOPKD, NFJKCBJFLIE OGNHKENMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x20C2920", Offset = "0x20C0F20", VA = "0x1820C2920")]
	private PBKOBDLIDOL OBHHENOOAOJ()
	{
		return default(PBKOBDLIDOL);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal struct MLPDFLFNCAA
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x27D5390", Offset = "0x27D3990", VA = "0x1827D5390")]
	public static Task OBHHENOOAOJ(CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct LIIAKIODCPB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct BHNBENDOCLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x27CD710", Offset = "0x27CBD10", VA = "0x1827CD710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x27D8670", Offset = "0x27D6C70", VA = "0x1827D8670")]
	[AsyncStateMachine(typeof(BHNBENDOCLJ))]
	public static Task OBHHENOOAOJ(GGNPNKPNBJP NFIEDJENJOM, NFJKCBJFLIE OGNHKENMEGF, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal struct EMEOHABJNHI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct CHJAKDMCKPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public ALPGBDAJPMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		private KAFHGJDFGHD <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		private LBAEOCOFFMH <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private FNMMNHKHMCA <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private List<(PersistenceView, JLFGDMMOIKO)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private JLFGDMMOIKO <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x20C5420", Offset = "0x20C3A20", VA = "0x1820C5420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x20C8F20", Offset = "0x20C7520", VA = "0x1820C8F20")]
	[AsyncStateMachine(typeof(CHJAKDMCKPB))]
	public static Task OBHHENOOAOJ(GGNPNKPNBJP NFIEDJENJOM, NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x20C8CB0", Offset = "0x20C72B0", VA = "0x1820C8CB0")]
	private static void MBDGDEMIJMN(PersistenceView GPBCADGHJJP, JLFGDMMOIKO CPAFMGHNGGP, NFJKCBJFLIE OGNHKENMEGF, KAFHGJDFGHD HLCHOHDONJN, bool OLKCIOCKFAK)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F9")]
internal struct OILDAJHMGDB
{
	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x27E1050", Offset = "0x27DF650", VA = "0x1827E1050")]
	public static Task OBHHENOOAOJ(LBAEOCOFFMH EKJGDPCALOO, NFJKCBJFLIE OGNHKENMEGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
internal struct JHJJBNNHHDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct KMDKIJLPKOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public LBAEOCOFFMH roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public KAFHGJDFGHD roomOperationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x202ADF0", Offset = "0x20293F0", VA = "0x18202ADF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct MBLOBIMBGNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public JHJJBNNHHDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x202B4B0", Offset = "0x2029AB0", VA = "0x18202B4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class MNMCDGKCGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public ECFNMJJJCGK version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public MNMCDGKCGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x202C670", Offset = "0x202AC70", VA = "0x18202C670")]
		internal object <DestroyActivePersistenceViews>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x202C720", Offset = "0x202AD20", VA = "0x18202C720")]
		internal object <DestroyActivePersistenceViews>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	private KAFHGJDFGHD EFBOFPJOPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private NFJKCBJFLIE OGNHKENMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	private GGNPNKPNBJP NFIEDJENJOM;

	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	private static readonly ByteString LHPBHHCMMCD;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x2026070", Offset = "0x2024670", VA = "0x182026070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private FHHFIGHJGFP FPLKBMOEBOA
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x20260C0", Offset = "0x20246C0", VA = "0x1820260C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x20262A0", Offset = "0x20248A0", VA = "0x1820262A0")]
	[AsyncStateMachine(typeof(KMDKIJLPKOF))]
	public static Task OBHHENOOAOJ(LBAEOCOFFMH EKJGDPCALOO, KAFHGJDFGHD EFBOFPJOPKD, NFJKCBJFLIE OGNHKENMEGF, GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2026170", Offset = "0x2024770", VA = "0x182026170")]
	[AsyncStateMachine(typeof(MBLOBIMBGNK))]
	private Task OBHHENOOAOJ(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x2026400", Offset = "0x2024A00", VA = "0x182026400")]
	private void OJJNJDMMHPP([NotNull] BEIGNGGNNMG DNJPHNDIFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2026140", Offset = "0x2024740", VA = "0x182026140")]
	private bool NMINCNAFJIG(ECFNMJJJCGK MNOJMAIICKJ, BEIGNGGNNMG DNJPHNDIFGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal struct HFPOKOJHPEL
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private struct HEJJOCPIEPF<Arg, Parsed> where Parsed : IMessage<Parsed>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private readonly global::DNJBOGHCELM<Arg> PPEILMFOPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private readonly global::KJNAAJNALGD<Parsed> DIGMCLJIAJO;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x5857B0", Offset = "0x583DB0", VA = "0x1805857B0")]
		public HEJJOCPIEPF(global::DNJBOGHCELM<Arg> PPEILMFOPLG, global::KJNAAJNALGD<Parsed> DIGMCLJIAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x278EDD0", Offset = "0x278D3D0", VA = "0x18278EDD0")]
		[AsyncStateMachine(typeof(GHMGGEKGNOE))]
		public Task<Parsed> LMIDEAPKDEN(Arg NOGDFKMIPHO, BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x278EB10", Offset = "0x278D110", VA = "0x18278EB10")]
		[AsyncStateMachine(typeof(PEHCEBEEBDB))]
		private Task<byte[]> BJADHJHALEH(Arg NOGDFKMIPHO, CancellationToken CMOIBOJIACL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x278F510", Offset = "0x278DB10", VA = "0x18278F510")]
		private Parsed MADGIHMIKEK(byte[] LEJHOJHOKGM)
		{
			return (Parsed)null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct MLHODODHLKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public AsyncTaskMethodBuilder<NFJKCBJFLIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public HFPOKOJHPEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private TaskAwaiter<(BEIGNGGNNMG, DGBJBAFBGLE, MAHFOJIDNFG)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x202C120", Offset = "0x202A720", VA = "0x18202C120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x202C620", Offset = "0x202AC20", VA = "0x18202C620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B8")]
	private HEJJOCPIEPF<FHKCFJFJCGG, BEIGNGGNNMG> FCEKFDHGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	private HEJJOCPIEPF<FHKCFJFJCGG, DGBJBAFBGLE> KAJKCPHDIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	private HEJJOCPIEPF<long, MAHFOJIDNFG> CLGHKNBCOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	private CCKBMPBIFMP DMFHFDFMIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	private MFFPLJBNNEB DLHDHECGKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	private DBPKBOFJDFM EFDCGHEBNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	private BJHOOGFBDGF NJKJIAHPBGG;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x201ED10", Offset = "0x201D310", VA = "0x18201ED10")]
	public static Task<NFJKCBJFLIE> JJAEMHPNKNL(LBAEOCOFFMH EKJGDPCALOO, CCKBMPBIFMP DMFHFDFMIOL, in NGIPHJDGCJG OGNHKENMEGF, BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x201EF70", Offset = "0x201D570", VA = "0x18201EF70")]
	[AsyncStateMachine(typeof(MLHODODHLKM))]
	private Task<NFJKCBJFLIE> OBHHENOOAOJ(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x201ECD0", Offset = "0x201D2D0", VA = "0x18201ECD0")]
	private FHKCFJFJCGG BIOJJPJDKDG(ACAJMNHDKFC JEJGGFOBGJH)
	{
		return default(FHKCFJFJCGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
internal struct LHPOCEOECAP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[CompilerGenerated]
	private struct MNINDADBCAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public AsyncTaskMethodBuilder<NGIPHJDGCJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public LHPOCEOECAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private TaskAwaiter<NGIPHJDGCJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x27DD8B0", Offset = "0x27DBEB0", VA = "0x1827DD8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x27DDCB0", Offset = "0x27DC2B0", VA = "0x1827DDCB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private sealed class AJLDENEDCOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public AJLDENEDCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x105ABB0", Offset = "0x10591B0", VA = "0x18105ABB0")]
		internal bool <FetchRoomDetails>b__0(DBPKBOFJDFM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private struct KFFBJHFGGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public AsyncTaskMethodBuilder<NGIPHJDGCJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public LHPOCEOECAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public bool forceRefresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private AJLDENEDCOP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private TaskAwaiter<MFFPLJBNNEB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x27D4A30", Offset = "0x27D3030", VA = "0x1827D4A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x27D4EB0", Offset = "0x27D34B0", VA = "0x1827D4EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private HLGNNAIFBEA BGONODDGIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private BJHOOGFBDGF NJKJIAHPBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private long HEDMMBFEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private long FDEIGEELENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D9")]
	private FHKCFJFJCGG GFJNNBKJAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003DA")]
	private FHKCFJFJCGG OKBKNGCJDFE;

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x27D8390", Offset = "0x27D6990", VA = "0x1827D8390")]
	public static Task<NGIPHJDGCJG> JJAEMHPNKNL(LBAEOCOFFMH EKJGDPCALOO, CCKBMPBIFMP DMFHFDFMIOL, BJHOOGFBDGF NJKJIAHPBGG, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x27D8530", Offset = "0x27D6B30", VA = "0x1827D8530")]
	[AsyncStateMachine(typeof(MNINDADBCAO))]
	private Task<NGIPHJDGCJG> OBHHENOOAOJ(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x27D80B0", Offset = "0x27D66B0", VA = "0x1827D80B0")]
	[AsyncStateMachine(typeof(KFFBJHFGGPB))]
	private Task<NGIPHJDGCJG> AOJKPOIIEMN(long HEDMMBFEFLM, long FDEIGEELENF, CancellationToken CMOIBOJIACL, bool BJOFCCKGLFK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x27D8360", Offset = "0x27D6960", VA = "0x1827D8360")]
	private void FIPBBFHGEPL(MFFPLJBNNEB DLHDHECGKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x27D8220", Offset = "0x27D6820", VA = "0x1827D8220")]
	private bool EHHCCPCGNPO(NGIPHJDGCJG OGNHKENMEGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x27D7F50", Offset = "0x27D6550", VA = "0x1827D7F50")]
	private void AGMADDHKNBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
internal struct PEHBJEIJJEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private struct EIIPGLEDCJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public PEHBJEIJJEF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x4E461A0", Offset = "0x4E447A0", VA = "0x184E461A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003EE")]
	private const int HIOAFGOICIL = 20;

	[Cpp2IlInjected.Token(Token = "0x40003EF")]
	private const float PIPJKEGJGBB = 15f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F0")]
	private FNMMNHKHMCA PJEAKFPHIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	private NFJKCBJFLIE OGNHKENMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	private BJHOOGFBDGF NJKJIAHPBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	private float JMIGEMEPEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	private float HOHEICDAEJB;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x27E3210", Offset = "0x27E1810", VA = "0x1827E3210")]
	public static Task KDNBJIKGPHF(LBAEOCOFFMH EKJGDPCALOO, GGNPNKPNBJP NFIEDJENJOM, NFJKCBJFLIE OGNHKENMEGF, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x27E3490", Offset = "0x27E1A90", VA = "0x1827E3490")]
	[AsyncStateMachine(typeof(EIIPGLEDCJN))]
	public Task OBHHENOOAOJ(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x27E30A0", Offset = "0x27E16A0", VA = "0x1827E30A0")]
	private static void GLEBNDHMBIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x27E2F20", Offset = "0x27E1520", VA = "0x1827E2F20")]
	private void ECDKACBPHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x27E33D0", Offset = "0x27E19D0", VA = "0x1827E33D0")]
	private static float KHDAPKNOCPC(FNMMNHKHMCA PJEAKFPHIGK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x27E2F00", Offset = "0x27E1500", VA = "0x1827E2F00")]
	private static float EAKDBIADKJH()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010B")]
internal struct CEJFGNKPOGN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct PHLBBLKJAKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public GGNPNKPNBJP operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public BFPJFBMGGAN.PBKOBDLIDOL mapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private CHMPEANIDIP <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private LBAEOCOFFMH <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private FCFKLDGFBPG.JADEDMJIFNF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x20D7940", Offset = "0x20D5F40", VA = "0x1820D7940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct AEPDNJAIOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private FCACIOAOMOA.LNEEFJMGPFM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x20C0A10", Offset = "0x20BF010", VA = "0x1820C0A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x20C4AC0", Offset = "0x20C30C0", VA = "0x1820C4AC0")]
	[AsyncStateMachine(typeof(PHLBBLKJAKF))]
	public static Task OBHHENOOAOJ(GGNPNKPNBJP NFIEDJENJOM, NFJKCBJFLIE OGNHKENMEGF, BFPJFBMGGAN.PBKOBDLIDOL EIJFPCHDIOL, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x20C4C10", Offset = "0x20C3210", VA = "0x1820C4C10")]
	private static Task<MGIOABMEIJD> OJHNHLGHOAG(GGNPNKPNBJP NFIEDJENJOM, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x20C49E0", Offset = "0x20C2FE0", VA = "0x1820C49E0")]
	[AsyncStateMachine(typeof(AEPDNJAIOLL))]
	private static Task ANJHHNCGFNE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal struct KEDNPDGAJKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct GMKGLELNCEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public KEDNPDGAJKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x201DD40", Offset = "0x201C340", VA = "0x18201DD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class NODAGKFBJFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public NODAGKFBJFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x202E070", Offset = "0x202C670", VA = "0x18202E070")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct FPHEFDGNKHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public KEDNPDGAJKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private ONHJIBBGPNO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x201CE20", Offset = "0x201B420", VA = "0x18201CE20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	private bool ACLACCLPAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	private BJHOOGFBDGF NJKJIAHPBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private CancellationToken CMOIBOJIACL;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2029FF0", Offset = "0x20285F0", VA = "0x182029FF0")]
	public static Task AGIENKKIBAA(LBAEOCOFFMH EKJGDPCALOO, bool ACLACCLPAHH, BJHOOGFBDGF NJKJIAHPBGG, CancellationToken NKGIGKCIJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x202A1A0", Offset = "0x20287A0", VA = "0x18202A1A0")]
	[AsyncStateMachine(typeof(GMKGLELNCEA))]
	private Task OBHHENOOAOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x202A070", Offset = "0x2028670", VA = "0x18202A070")]
	[AsyncStateMachine(typeof(FPHEFDGNKHO))]
	private Task LIAHPDEOFBC(bool JBAGLFBFICM, string NLEHPBOLMFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0")]
	private bool ANJGHOJJLLI(bool ACLACCLPAHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
internal struct JEFEBJENDGJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct DEIKCHCFPFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public JEFEBJENDGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2019DE0", Offset = "0x20183E0", VA = "0x182019DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class HMLICLLAMKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HMLICLLAMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2021B50", Offset = "0x2020150", VA = "0x182021B50")]
		internal object <SafeLoadSceneAsync>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private struct EOLLHPKGNLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public JEFEBJENDGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private ONHJIBBGPNO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x201B7F0", Offset = "0x2019DF0", VA = "0x18201B7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private EDENBEBPCEL KMMIEIPHEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private bool ACLACCLPAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private BJHOOGFBDGF NJKJIAHPBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2025C80", Offset = "0x2024280", VA = "0x182025C80")]
	public static Task IPEFJIBBCOC(LBAEOCOFFMH EKJGDPCALOO, EDENBEBPCEL EIHOKIECMKB, bool ACLACCLPAHH, BJHOOGFBDGF NJKJIAHPBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2025E00", Offset = "0x2024400", VA = "0x182025E00")]
	[AsyncStateMachine(typeof(DEIKCHCFPFE))]
	private Task OBHHENOOAOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2025CE0", Offset = "0x20242E0", VA = "0x182025CE0")]
	[AsyncStateMachine(typeof(EOLLHPKGNLK))]
	private Task LIAHPDEOFBC(string NLEHPBOLMFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
internal struct HLBCDEEKLCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private struct ELDLBAEOFEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public HLBCDEEKLCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public KAFHGJDFGHD nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private TaskAwaiter<KAFHGJDFGHD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x201A9D0", Offset = "0x2018FD0", VA = "0x18201A9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x201AFC0", Offset = "0x20195C0", VA = "0x18201AFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct LHFEOLPDPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public AsyncTaskMethodBuilder<KAFHGJDFGHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public HLBCDEEKLCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public KAFHGJDFGHD state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x202AFC0", Offset = "0x20295C0", VA = "0x18202AFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x202B1E0", Offset = "0x20297E0", VA = "0x18202B1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private readonly GGNPNKPNBJP NFIEDJENJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private readonly HLGNNAIFBEA BGONODDGIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private readonly KHNMPHEGJAF NPMAHHAJFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private CancellationToken CMOIBOJIACL;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private CHMPEANIDIP CPKMDDKIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x94D810", Offset = "0x94BE10", VA = "0x18094D810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2021200", Offset = "0x201F800", VA = "0x182021200")]
	public HLBCDEEKLCF(GGNPNKPNBJP NFIEDJENJOM, HLGNNAIFBEA BGONODDGIME, KHNMPHEGJAF NPMAHHAJFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2020E80", Offset = "0x201F480", VA = "0x182020E80")]
	public void FMFPBBKDGGH(CancellationToken CMOIBOJIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x20211D0", Offset = "0x201F7D0", VA = "0x1820211D0")]
	public void OJDPGEKFJNB(NFJKCBJFLIE OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2021000", Offset = "0x201F600", VA = "0x182021000")]
	public Task<KAFHGJDFGHD> GONHIJLBGFB(KAFHGJDFGHD DAGAGIKBOBI, bool JNOOGNMEBHC, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2020ED0", Offset = "0x201F4D0", VA = "0x182020ED0")]
	[AsyncStateMachine(typeof(ELDLBAEOFEB))]
	public Task<KAFHGJDFGHD> GONHIJLBGFB(KAFHGJDFGHD DAGAGIKBOBI, bool JNOOGNMEBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2021070", Offset = "0x201F670", VA = "0x182021070")]
	[AsyncStateMachine(typeof(LHFEOLPDPKM))]
	private Task<KAFHGJDFGHD> KMGCGFLBNBJ(KAFHGJDFGHD HMGOCFOIBEE, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2020E50", Offset = "0x201F450", VA = "0x182020E50")]
	private bool DHBOHKIOEMH(KAFHGJDFGHD KPLEPGALMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x20211B0", Offset = "0x201F7B0", VA = "0x1820211B0")]
	private void NJMIDDMBIGP(string LIIFAPBKLLO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct FKBJJAMILFE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private struct EMGHDDEMGDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public CHMPEANIDIP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public ALPGBDAJPMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private List<(PersistenceView, JLFGDMMOIKO)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private (PersistenceView, JLFGDMMOIKO) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x20C91D0", Offset = "0x20C77D0", VA = "0x1820C91D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x20CA390", Offset = "0x20C8990", VA = "0x1820CA390")]
	[AsyncStateMachine(typeof(EMGHDDEMGDN))]
	public static Task OBHHENOOAOJ(CHMPEANIDIP ADCHCDBFMEI, NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200011B")]
internal struct IBEKBFOIBBL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct MPDHFEEEGHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public CHMPEANIDIP operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public NFJKCBJFLIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public ALPGBDAJPMA timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private ECFNMJJJCGK <version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private List<(PersistenceView, JLFGDMMOIKO)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private JLFGDMMOIKO <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x202C7A0", Offset = "0x202ADA0", VA = "0x18202C7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x20227B0", Offset = "0x2020DB0", VA = "0x1820227B0")]
	[AsyncStateMachine(typeof(MPDHFEEEGHK))]
	public static Task OBHHENOOAOJ(CHMPEANIDIP ADCHCDBFMEI, NFJKCBJFLIE OGNHKENMEGF, ALPGBDAJPMA DFKHGFAPHOA, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
internal struct FCFKLDGFBPG
{
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	public struct JADEDMJIFNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public List<NIPMODLHPEL> OIBFBKFOAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public List<JLFGDMMOIKO> OHLJAJCBFAH;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x5857B0", Offset = "0x583DB0", VA = "0x1805857B0")]
		public JADEDMJIFNF(List<NIPMODLHPEL> OIBFBKFOAFB, List<JLFGDMMOIKO> OHLJAJCBFAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class GLGCKMNDMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public List<NIPMODLHPEL> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GLGCKMNDMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x20CE4D0", Offset = "0x20CCAD0", VA = "0x1820CE4D0")]
		internal object <BulkInstantiateObjects>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	private LBAEOCOFFMH EKJGDPCALOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	private NFJKCBJFLIE OGNHKENMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	private BFPJFBMGGAN.PBKOBDLIDOL EIJFPCHDIOL;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	private FNMMNHKHMCA ANHMACCGKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x20C96A0", Offset = "0x20C7CA0", VA = "0x1820C96A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x20CA160", Offset = "0x20C8760", VA = "0x1820CA160")]
	public static JADEDMJIFNF OBHHENOOAOJ(LBAEOCOFFMH EKJGDPCALOO, NFJKCBJFLIE OGNHKENMEGF, BFPJFBMGGAN.PBKOBDLIDOL EIJFPCHDIOL)
	{
		return default(JADEDMJIFNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x20C9F20", Offset = "0x20C8520", VA = "0x1820C9F20")]
	private JADEDMJIFNF OBHHENOOAOJ()
	{
		return default(JADEDMJIFNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x20C9A70", Offset = "0x20C8070", VA = "0x1820C9A70")]
	private JADEDMJIFNF MHHJIDIDIKL(BEIGNGGNNMG DNJPHNDIFGE, ECFNMJJJCGK GIEGDPNNMKD, Dictionary<int, int> PAIHELMGHLP)
	{
		return default(JADEDMJIFNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x20C96F0", Offset = "0x20C7CF0", VA = "0x1820C96F0")]
	private GameObject[] CEKHDFGNFIC(List<NIPMODLHPEL> OIBFBKFOAFB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal struct ILJDMHAGKEL
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class IGGOECCCMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public FCFKLDGFBPG.JADEDMJIFNF instantiations;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IGGOECCCMAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2023A70", Offset = "0x2022070", VA = "0x182023A70")]
		internal object <Run>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private sealed class AFBHLNICABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public AFBHLNICABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2018250", Offset = "0x2016850", VA = "0x182018250")]
		internal object <Run>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x20249D0", Offset = "0x2022FD0", VA = "0x1820249D0")]
	public static void OBHHENOOAOJ(CHMPEANIDIP ADCHCDBFMEI, NFJKCBJFLIE OGNHKENMEGF, FCFKLDGFBPG.JADEDMJIFNF AIAMPAALJDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
internal class KHNMPHEGJAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct JJOEJNICLGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public KAFHGJDFGHD operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x27D41A0", Offset = "0x27D27A0", VA = "0x1827D41A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct NDPFEIIEAOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x27DDDC0", Offset = "0x27DC3C0", VA = "0x1827DDDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct CCDKFAHNDHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private Dictionary<Guid, List<AGDOILEGODC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x27CE390", Offset = "0x27CC990", VA = "0x1827CE390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct OKBPCEHGFMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private Dictionary<Guid, List<AGDOILEGODC>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x27E1250", Offset = "0x27DF850", VA = "0x1827E1250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class DKNOBLMNJFB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public AGDOILEGODC handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public DKNOBLMNJFB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x27E3B40", Offset = "0x27E2140", VA = "0x1827E3B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public KCMOFDEFNIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public List<AGDOILEGODC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public DKNOBLMNJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x27D0100", Offset = "0x27CE700", VA = "0x1827D0100")]
		internal object <InvokeMethodsInParallel>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x27D0280", Offset = "0x27CE880", VA = "0x1827D0280")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task <InvokeMethodsInParallel>b__2(AGDOILEGODC handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x27D01C0", Offset = "0x27CE7C0", VA = "0x1827D01C0")]
		internal object <InvokeMethodsInParallel>b__1()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct IFPFEHPJCIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public KCMOFDEFNIP runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public List<AGDOILEGODC> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private DKNOBLMNJFB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x27D3A40", Offset = "0x27D2040", VA = "0x1827D3A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct PEMGJOELJMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x27E35B0", Offset = "0x27E1BB0", VA = "0x1827E35B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private sealed class LFLBDMONPCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LFLBDMONPCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x27D7EF0", Offset = "0x27D64F0", VA = "0x1827D7EF0")]
		internal object <MasterInvokeHandlerMethods>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct HHIJCHPOGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x27D2B70", Offset = "0x27D1170", VA = "0x1827D2B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private sealed class CICBBMEKKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public CICBBMEKKKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x27CFE30", Offset = "0x27CE430", VA = "0x1827CFE30")]
		internal object <MasterSyncSendCompletionMark>b__0()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000130")]
	[CompilerGenerated]
	private struct LLMBAIPHOKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public KHNMPHEGJAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x27D87E0", Offset = "0x27D6DE0", VA = "0x1827D87E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private sealed class KDKPHPLMHPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KDKPHPLMHPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x27D49D0", Offset = "0x27D2FD0", VA = "0x1827D49D0")]
		internal object <RemoveCompletedHandler>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly GGNPNKPNBJP NFIEDJENJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private NFJKCBJFLIE OGNHKENMEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private CancellationToken CMOIBOJIACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private AEEHLJHIJAH NPMAHHAJFDD;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private CHMPEANIDIP CPKMDDKIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6D0310", Offset = "0x6CE910", VA = "0x1806D0310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private BJHOOGFBDGF EDLAIOGHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x573CF0", Offset = "0x5722F0", VA = "0x180573CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
	public KHNMPHEGJAF(GGNPNKPNBJP NFIEDJENJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x27D6C80", Offset = "0x27D5280", VA = "0x1827D6C80")]
	public void FMFPBBKDGGH(CancellationToken CMOIBOJIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0")]
	public void OJDPGEKFJNB(NFJKCBJFLIE OGNHKENMEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x27D7590", Offset = "0x27D5B90", VA = "0x1827D7590")]
	[AsyncStateMachine(typeof(JJOEJNICLGA))]
	public Task OBHHENOOAOJ(KAFHGJDFGHD HLCHOHDONJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x27D6FC0", Offset = "0x27D55C0", VA = "0x1827D6FC0")]
	[AsyncStateMachine(typeof(NDPFEIIEAOC))]
	private Task HHFGPEOEMEB(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x27D7480", Offset = "0x27D5A80", VA = "0x1827D7480")]
	[AsyncStateMachine(typeof(CCDKFAHNDHO))]
	private Task MLDGGHDKJNK(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x27D6C90", Offset = "0x27D5290", VA = "0x1827D6C90")]
	[AsyncStateMachine(typeof(OKBPCEHGFMN))]
	private Task GLGBPCJCGHG(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x27D69D0", Offset = "0x27D4FD0", VA = "0x1827D69D0")]
	[AsyncStateMachine(typeof(IFPFEHPJCIH))]
	private Task AFPGDICLGJB(Guid BOENIFEPOJN, List<AGDOILEGODC> PHCOEIDEODL, KCMOFDEFNIP LPCGBJHMMIA, CancellationToken GJGFJFLAGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x27D70E0", Offset = "0x27D56E0", VA = "0x1827D70E0")]
	[AsyncStateMachine(typeof(PEMGJOELJMA))]
	private Task IMJDBNOFHPO(CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x27D6E90", Offset = "0x27D5490", VA = "0x1827D6E90")]
	[AsyncStateMachine(typeof(HHIJCHPOGKE))]
	private Task HBJHJJIPACP(Guid HENLKJHGIEO, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x27D7200", Offset = "0x27D5800", VA = "0x1827D7200")]
	[AsyncStateMachine(typeof(LLMBAIPHOKP))]
	private Task KKKFNPFPFJG(Guid HENLKJHGIEO, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x27D7330", Offset = "0x27D5930", VA = "0x1827D7330")]
	private void MCGODDIGOJL(Guid HENLKJHGIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x27D6DA0", Offset = "0x27D53A0", VA = "0x1827D6DA0")]
	private void GOMPNAEGCHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x27D6B10", Offset = "0x27D5110", VA = "0x1827D6B10")]
	[CompilerGenerated]
	private object BMEAOHELAAK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public struct HEPPHFAIPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public BEIGNGGNNMG LNPPFPPDPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	public List<string> DAEIAMMFOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	public Dictionary<long, int> IEJDOGALFJO;
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class MFAIIMMIJHA : BMDLADBLEED
{
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private sealed class BMAGEBGFJDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public EDJOLKBGGON autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public BMAGEBGFJDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[CompilerGenerated]
	private sealed class HGKOJPEJLDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public FileInfo filePath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public BMAGEBGFJDA CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public HGKOJPEJLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x27D2A60", Offset = "0x27D1060", VA = "0x1827D2A60")]
		internal object <TrySaveAutosaveDataToDisk>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private sealed class PNMBFCOLHOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public BMAGEBGFJDA CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public PNMBFCOLHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x27E3AD0", Offset = "0x27E20D0", VA = "0x1827E3AD0")]
		internal object <TrySaveAutosaveDataToDisk>b__1()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private sealed class MNPDDAJIOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public EDJOLKBGGON autosaveType;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public MNPDDAJIOFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x27DDD00", Offset = "0x27DC300", VA = "0x1827DDD00")]
		internal object <TryReadAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000139")]
	[CompilerGenerated]
	private sealed class CCOODFKCLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public FileInfo autosavePathFileInfo;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public CCOODFKCLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x27CE720", Offset = "0x27CCD20", VA = "0x1827CE720")]
		internal object <WriteAutosaveAndChecksumToPath>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private sealed class KOPIIFNFEFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public FileSystemInfo file;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public KOPIIFNFEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x27D7780", Offset = "0x27D5D80", VA = "0x1827D7780")]
		internal object <RemoveOldestAutosavesOverMaximum>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013C")]
	[CompilerGenerated]
	private sealed class LCKIEAMCIAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public LCKIEAMCIAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x27D7E90", Offset = "0x27D6490", VA = "0x1827D7E90")]
		internal object <ClearRecoveryAutosave>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private const string NFGCPDDDPLP = "V2";

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private const int AJIEGOLHBJJ = 5;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private const string JEDILMDEJJC = "AutosavesV2";

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private const string ODHNHMKEFNE = "RecoveryV2";

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private const int DILNGPBDFCO = 32;

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x27DB1B0", Offset = "0x27D97B0", VA = "0x1827DB1B0")]
	public MFAIIMMIJHA(GGNPNKPNBJP NFIEDJENJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x27D9D80", Offset = "0x27D8380", VA = "0x1827D9D80")]
	public bool EKDDOMIGEMP(long FDEIGEELENF, HEPPHFAIPIK KFNLLONIIMA, EDJOLKBGGON MEHKPGNHAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x27DA900", Offset = "0x27D8F00", VA = "0x1827DA900")]
	public static bool JHJLAFLIIBF(long FDEIGEELENF, EDJOLKBGGON MEHKPGNHAPF, out FileInfo BODADILDPNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x27DA9C0", Offset = "0x27D8FC0", VA = "0x1827DA9C0")]
	public bool NOILIOOPFJG(long FDEIGEELENF, EDJOLKBGGON MEHKPGNHAPF, out HEPPHFAIPIK KFNLLONIIMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x27D98A0", Offset = "0x27D7EA0", VA = "0x1827D98A0")]
	private bool CMCPOFABPDC(FileInfo BODADILDPNN, out byte[] IDBONHEABJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x27DA7B0", Offset = "0x27D8DB0", VA = "0x1827DA7B0")]
	private static FileInfo JCGDCBDJHNG(long FDEIGEELENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x27DA6E0", Offset = "0x27D8CE0", VA = "0x1827DA6E0")]
	private static FileInfo JAIDEMBEBHO(long FDEIGEELENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x27DA890", Offset = "0x27D8E90", VA = "0x1827DA890")]
	private static DirectoryInfo JEOJGCLIIAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x27DAE30", Offset = "0x27D9430", VA = "0x1827DAE30")]
	private void OFJDPHCFCBL(FileInfo FPCFEIAAJFI, BEIGNGGNNMG EIGJMLMDBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x27DA1F0", Offset = "0x27D87F0", VA = "0x1827DA1F0")]
	private void HKHFCFBJHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x27D9680", Offset = "0x27D7C80", VA = "0x1827D9680")]
	public static void ANAMNCMBLFI(long FDEIGEELENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x27D9830", Offset = "0x27D7E30", VA = "0x1827D9830")]
	public static bool BBHFGNOFBHK(long FDEIGEELENF, out DateTime EPHBJLEONLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal class FNEKJEOLODJ : BMDLADBLEED
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private struct PDCFHPAOOMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder<HEPPHFAIPIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public FNEKJEOLODJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public OHAJFKMLEIK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x20D73F0", Offset = "0x20D59F0", VA = "0x1820D73F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x20D78F0", Offset = "0x20D5EF0", VA = "0x1820D78F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013F")]
	[CompilerGenerated]
	private sealed class GFNDAELIDLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public OHAJFKMLEIK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GFNDAELIDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x20CBE80", Offset = "0x20CA480", VA = "0x1820CBE80")]
		internal Task <PreserializeViews>b__1(PersistenceView v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private sealed class GAKEHPEDFLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public GFNDAELIDLD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GAKEHPEDFLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x20CBDA0", Offset = "0x20CA3A0", VA = "0x1820CBDA0")]
		internal object <PreserializeViews>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private sealed class DPALOIFLDPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public GFNDAELIDLD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public DPALOIFLDPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x20C7AD0", Offset = "0x20C60D0", VA = "0x1820C7AD0")]
		internal Task <PreserializeViews>b__3(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct MBGGDHDGJKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public OHAJFKMLEIK serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public FNEKJEOLODJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private GAKEHPEDFLE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private FCACIOAOMOA.JAGJPLHBCCF <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x20D44A0", Offset = "0x20D2AA0", VA = "0x1820D44A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	private readonly FKAJGIIFNDN HODHPEJLAFF;

	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private static readonly TimeSpan EFNOMANENOL;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x20CBCC0", Offset = "0x20CA2C0", VA = "0x1820CBCC0")]
	public FNEKJEOLODJ(GGNPNKPNBJP NFIEDJENJOM, [Optional] FKAJGIIFNDN? HODHPEJLAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x20CAC20", Offset = "0x20C9220", VA = "0x1820CAC20")]
	[AsyncStateMachine(typeof(PDCFHPAOOMP))]
	public Task<HEPPHFAIPIK> DFIGKGIDJJK(long FDEIGEELENF, OHAJFKMLEIK MLIDLNJFJHE, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x20CB440", Offset = "0x20C9A40", VA = "0x1820CB440")]
	[AsyncStateMachine(typeof(MBGGDHDGJKM))]
	private Task IMHGCGMFIOA(OHAJFKMLEIK MLIDLNJFJHE, IEnumerable<PersistenceView> PNEAOBABCPD, StringBuilder LGLDAKLANAH, CancellationToken CMOIBOJIACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x20CAD60", Offset = "0x20C9360", VA = "0x1820CAD60")]
	private HEPPHFAIPIK DNFNHBACAHP(long FDEIGEELENF, OHAJFKMLEIK MLIDLNJFJHE, IEnumerable<PersistenceView> PNEAOBABCPD, StringBuilder LGLDAKLANAH)
	{
		return default(HEPPHFAIPIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x20CB290", Offset = "0x20C9890", VA = "0x1820CB290")]
	private BEIGNGGNNMG GIHBGGNAJAP(long FDEIGEELENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x20CB590", Offset = "0x20C9B90", VA = "0x1820CB590")]
	private void KLFIFDGKFOA(BEIGNGGNNMG MGAPEIODPJA, StringBuilder LGLDAKLANAH, IEnumerable<PersistenceView> PNEAOBABCPD, in DBGNDBIILCO GMLIFKLLKLO, ref GHGNHBKLOMI MKEMEIPOIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x20CB790", Offset = "0x20C9D90", VA = "0x1820CB790")]
	private void MCMOCHJDHNO(BEIGNGGNNMG MGAPEIODPJA, StringBuilder LGLDAKLANAH, PersistenceView GPBCADGHJJP, ref GHGNHBKLOMI MKEMEIPOIFL, in DBGNDBIILCO GMLIFKLLKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal class ICJCIBIPCHI : BMDLADBLEED
{
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class GLCJHPAMBON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public string roomMetadataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public byte[] data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public string roomDataFilename;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GLCJHPAMBON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x201DA00", Offset = "0x201C000", VA = "0x18201DA00")]
		internal object <UploadRoomDataBlob>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x201DA80", Offset = "0x201C080", VA = "0x18201DA80")]
		internal object <UploadRoomDataBlob>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x201DAC0", Offset = "0x201C0C0", VA = "0x18201DAC0")]
		internal object <UploadRoomDataBlob>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x201DB30", Offset = "0x201C130", VA = "0x18201DB30")]
		internal object <UploadRoomDataBlob>b__3()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct ABLFKFMEJKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public AsyncTaskMethodBuilder<MFFPLJBNNEB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public HEPPHFAIPIK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public ICJCIBIPCHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private GLCJHPAMBON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private float <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private TaskAwaiter<string> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private TaskAwaiter<MFFPLJBNNEB> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x2017780", Offset = "0x2015D80", VA = "0x182017780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x2018200", Offset = "0x2016800", VA = "0x182018200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class FJINHGDNLFC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000148")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public FJINHGDNLFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			private MGIOABMEIJD <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			private TaskAwaiter<MFFPLJBNNEB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			private TaskAwaiter<MGIOABMEIJD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0x202F5D0", Offset = "0x202DBD0", VA = "0x18202F5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x202FB90", Offset = "0x202E190", VA = "0x18202FB90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public ICJCIBIPCHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public HEPPHFAIPIK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public long subRoomId;

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FJINHGDNLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x201C2D0", Offset = "0x201A8D0", VA = "0x18201C2D0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<MGIOABMEIJD> <UploadRoomDataBlobAndSyncReload>b__0(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct HDHBMMINBEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public AsyncTaskMethodBuilder<MGIOABMEIJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public ICJCIBIPCHI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public HEPPHFAIPIK roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private TaskAwaiter<MGIOABMEIJD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x201E680", Offset = "0x201CC80", VA = "0x18201E680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x201E8A0", Offset = "0x201CEA0", VA = "0x18201E8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private const float CINAPBJPKCK = 10f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly KADLIJAOKIC JMDKLAKMJDF;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private LBAEOCOFFMH HLFCOLEHOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2022A60", Offset = "0x2021060", VA = "0x182022A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2022BE0", Offset = "0x20211E0", VA = "0x182022BE0")]
	public ICJCIBIPCHI(GGNPNKPNBJP NFIEDJENJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2022A90", Offset = "0x2021090", VA = "0x182022A90")]
	[AsyncStateMachine(typeof(ABLFKFMEJKG))]
	public Task<MFFPLJBNNEB> PPLJOMDPDPM(int AECIIDFCKEL, HEPPHFAIPIK KFNLLONIIMA, long HEDMMBFEFLM, long KAMCIMPLACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2022900", Offset = "0x2020F00", VA = "0x182022900")]
	[AsyncStateMachine(typeof(HDHBMMINBEF))]
	public Task<MGIOABMEIJD> ALAMBBDOFAB(int AECIIDFCKEL, HEPPHFAIPIK KFNLLONIIMA, long HEDMMBFEFLM, long KAMCIMPLACP, CancellationToken CMOIBOJIACL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public class EENOJINADGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000511")]
	private readonly Guid KOKPBCLAFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private readonly LKDPLNJNDNN KAOJFOHCDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private CCKBMPBIFMP JMPKGJCDKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private int? CEAOEMJNAKB;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Guid NLEIGEHHPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x83A090", Offset = "0x838690", VA = "0x18083A090")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x20C8080", Offset = "0x20C6680", VA = "0x1820C8080")]
	public EENOJINADGG(LKDPLNJNDNN KAOJFOHCDAO, [Optional] Guid? KOKPBCLAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x20C7FE0", Offset = "0x20C65E0", VA = "0x1820C7FE0")]
	public EENOJINADGG EAANFJBNPDB(CCKBMPBIFMP JMPKGJCDKLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x20C7F10", Offset = "0x20C6510", VA = "0x1820C7F10")]
	public MGIOABMEIJD ABGMMJIMBKE(out Guid AFACFAJKPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x20C8000", Offset = "0x20C6600", VA = "0x1820C8000")]
	public EENOJINADGG JNLLLFAAPIE(BMNAGFLMHFA NKGBOFHOONN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public static class LJAFKMEEONL
{
	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x27D87A0", Offset = "0x27D6DA0", VA = "0x1827D87A0")]
	public static FHKCFJFJCGG FDPPEGLIEAC(this ACAJMNHDKFC JEJGGFOBGJH)
	{
		return default(FHKCFJFJCGG);
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CreateAssetMenu]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200014D")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public NPDLPDPNDEP ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public NPDLPDPNDEP HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60004FE")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private static NPDLPDPNDEP[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private Dictionary<NPDLPDPNDEP, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x4E46F10", Offset = "0x4E45510", VA = "0x184E46F10")]
		public bool MAPIAPNIAEM(NPDLPDPNDEP FEKNJKHPFAO, out ResultConfig MKKBKPHEKHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x4E46E20", Offset = "0x4E45420", VA = "0x184E46E20")]
		public ResultConfig DDHDFINDJJP(NPDLPDPNDEP GJHPLFKILIN, [Optional] HashSet<NPDLPDPNDEP> FMEFNMCHPDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x4E47430", Offset = "0x4E45A30", VA = "0x184E47430", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x4E46F80", Offset = "0x4E45580", VA = "0x184E46F80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0xC6C390", Offset = "0xC6A990", VA = "0x180C6C390")]
		public ValidationResultConfig()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200014F")]
public class HGPPKMCDCLL
{
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private static byte[] PIDGMPFPDGI;

	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private static int CONMIAOECKG;

	[Cpp2IlInjected.Token(Token = "0x4000525")]
	private static int PDHBFKNINGO;

	[Cpp2IlInjected.Token(Token = "0x4000526")]
	private static BigInteger EDLLKHJPMCN;

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public HGPPKMCDCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x201F110", Offset = "0x201D710", VA = "0x18201F110")]
	private static string CKGLFMJKOPM(byte[] IIFMPDAMAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x201F210", Offset = "0x201D810", VA = "0x18201F210")]
	public static string IOHOBOIOFIG(byte[] KFCJKMJDFKE, bool OLNJLDMOIJP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000151")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000527")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
